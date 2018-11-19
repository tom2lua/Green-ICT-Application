using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for register.xaml
    /// </summary>
    public partial class register : Page
    {
        public register()
        {
            InitializeComponent();
        }
        private void SignUp(object sender, RoutedEventArgs e)
        {
            string[] columns = Global.informationSchema.GetColumn("user_table");
            bool condition = true;

            //Required textboxes:
            if (usernameBox.Text == "") 
            {
                shortMessage.Visibility = Visibility.Collapsed;
                usernameRequiredMess.Visibility = Visibility.Visible;
                condition = false;
            }
            else
            {
                usernameRequiredMess.Visibility = Visibility.Collapsed;
            }

            if (passwordBox.Password == "")
            {
                passwordRequiredMess.Visibility = Visibility.Visible;
                condition = false;
            }
            else
            {
                passwordRequiredMess.Visibility = Visibility.Collapsed;
            }
            if (emailBox.Text == "")
            {
                emailRequiredMess.Visibility = Visibility.Visible;
                condition = false;
            }
            else
            {
                emailRequiredMess.Visibility = Visibility.Collapsed;
            }

            //Password check:
            if (passwordBox.Password == retypePass.Password && condition == true) 
            {
                Global.database.Insert("user_table", columns,  new string[] { usernameBox.Text, passwordBox.Password, nameBox.Text, emailBox.Text, "Client" });
                //Throw success message:
                registeredMess.Visibility = Visibility.Visible;
            }
            else
            {
                //Throw message password not match ...
                passMatchMessage.Visibility = Visibility.Visible;

            }  
        }
        private void usernameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (usernameBox.Text.Length < 6) //Throw message:
            {
                usernameRequiredMess.Visibility = Visibility.Collapsed;
                OkMessage.Visibility = Visibility.Collapsed;
                shortMessage.Visibility = Visibility.Visible;
            }
            else
            {
                if (Global.database.SelectSingle("SD", "user_table", "user_name", "user_name = '" + usernameBox.Text + "'") == "")
                {
                    usernameCheckMess.Visibility = Visibility.Collapsed;
                    shortMessage.Visibility = Visibility.Collapsed;
                    OkMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    OkMessage.Visibility = Visibility.Collapsed;
                    usernameCheckMess.Visibility = Visibility.Visible;
                }
            }
        }
        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).elements.Visibility = Visibility.Visible;
                }
            }
            if (frame.NavigationService.CanGoBack)
            {
                frame.NavigationService.GoBack();
            }
        }
    }
}
