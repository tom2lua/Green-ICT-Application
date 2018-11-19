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
using MySql.Data.MySqlClient;



namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public static string rememberUser ;
        public MainWindow()
        {
            InitializeComponent();
        }
        public string CheckUser(string userName, string pass)
        {
            string userRole = Global.database.SelectSingle("SD", "user_table", "role", "user_name = '" + userName + "' AND user_password = '" + pass + "'");
            return userRole;
        }
        private void LoginButton(object sender, RoutedEventArgs e)
        {
            string userRole = CheckUser(txtusername.Text, password.Password);
            Global.userID = Global.database.SelectSingle("SD", "user_table", "user_table_id", "user_name = '" + txtusername.Text + "'");
            switch (userRole) //Check user role:
            {
                case "Admin":
                    {
                        MainPage.NavigationService.Navigate(new AdminAppointments());
                        break;
                    }
                case "Service Person":
                    {
                        MainPage.NavigationService.Navigate(new ServicePersonSetService());
                        break;
                    }
                case "Client":
                    {
                        MainPage.NavigationService.Navigate(new WelcomePage());
                        break;
                    }
                default:
                    {
                        MainPage.NavigationService.Navigate(new faillogin());
                        break;
                    }
            }
            elements.Visibility = Visibility.Hidden;
        }
        private void checkname_Checked(object sender, RoutedEventArgs e)
        {

        } //Unfinished
        private void regisbt(object sender, MouseButtonEventArgs e)
        {
            MainPage.NavigationService.Navigate(new register());
            elements.Visibility = Visibility.Collapsed;
        }
    }
}
