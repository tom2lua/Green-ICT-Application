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
    /// Interaction logic for AdminProfile.xaml
    /// </summary>
    public partial class AdminProfile : Page
    {
        private string tempUsername;
        private string tempName;
        private string tempMail;
        public AdminProfile()
        {
            InitializeComponent();

            string[] profileData = Global.database.Select("SD", "user_table", new string[] { "user_name", "real_name", "email" }, "user_table_id = " + Global.userID);
            usernameBox.Text = profileData[0];
            nameBox.Text = profileData[1];
            emailBox.Text = profileData[2];

            tempUsername = profileData[0];
            tempName = profileData[1];
            tempMail = profileData[2];
        }
        //Hamburger Menu:
        private void Profile_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void Users_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminUser());
        }
        private void ServicePlace_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminSetPlace());
        }
        private void Appointment_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminAppointments());
        }
        private void About_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminAbout());
        }
        //Edit profile:
        private void EditProfile(object sender, RoutedEventArgs e)
        {
            editButton.Visibility = Visibility.Collapsed;
            passButton.Visibility = Visibility.Collapsed;
            saveButton.Visibility = Visibility.Visible;
            cancelLabel.Visibility = Visibility.Visible;

            usernameBox.IsReadOnly = false;
            nameBox.IsReadOnly = false;
            emailBox.IsReadOnly = false;
        }
        private void usernameBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (usernameBox.Text.Length < 6) //New username too short:
            {
                usernameMess.Visibility = Visibility.Collapsed;
                okMess.Visibility = Visibility.Collapsed;
                shortMess.Visibility = Visibility.Visible;
            }
            else
            {
                if (Global.database.SelectSingle("SD", "user_table", "user_name", "user_name = '" + usernameBox.Text + "'") == "") //Check if username exist:
                {
                    usernameMess.Visibility = Visibility.Collapsed;
                    shortMess.Visibility = Visibility.Collapsed;
                    okMess.Visibility = Visibility.Visible;
                }
                else
                {
                    okMess.Visibility = Visibility.Collapsed;
                    usernameMess.Visibility = Visibility.Visible;
                }
            }
        }
        private void Save_Clicked(object sender, RoutedEventArgs e)
        {
            bool condition = true;
            if (usernameBox.Text == "") //Empty boxes:
            {
                usernameMess.Visibility = Visibility.Visible;
                condition = false;
            }
            if (nameBox.Text == "")
            {
                nameMess.Visibility = Visibility.Visible;
                condition = false;
            }
            if (emailBox.Text == "")
            {
                emailBox.Visibility = Visibility.Visible;
                condition = false;
            }

            if (condition == true && shortMess.Visibility != Visibility.Visible)
            {
                tempUsername = usernameBox.Text;
                tempName = nameBox.Text;
                tempMail = emailBox.Text;

                Global.UpdateProfile(tempUsername, tempMail, tempName);

                editButton.Visibility = Visibility.Visible;
                passButton.Visibility = Visibility.Visible;
                saveButton.Visibility = Visibility.Collapsed;
                cancelLabel.Visibility = Visibility.Collapsed;

                usernameBox.IsReadOnly = true;
                nameBox.IsReadOnly = true;
                emailBox.IsReadOnly = true;
            }

        }
        private void Cancel_Clicked(object sender, MouseButtonEventArgs e)
        {
            usernameBox.Text = tempUsername;
            nameBox.Text = tempName;
            emailBox.Text = tempMail;

            editButton.Visibility = Visibility.Visible;
            passButton.Visibility = Visibility.Visible;
            saveButton.Visibility = Visibility.Collapsed;
            cancelLabel.Visibility = Visibility.Collapsed;
        }
        //Change pass:
        private void savePassButton_Click(object sender, RoutedEventArgs e)
        {
            bool checker = true;
            currentPassMess.Visibility = Visibility.Collapsed;
            passChangedMess.Visibility = Visibility.Collapsed;
            passErrorMess.Visibility = Visibility.Collapsed;
            passMess.Visibility = Visibility.Collapsed;
            retypeMess.Visibility = Visibility.Collapsed;

            if (currentPassBox.Password == "") //null boxes
            {
                //throw mess..
                currentPassMess.Visibility = Visibility.Visible;
                checker = false;
            }
            if (passwordBox.Password == "") //null boxes
            {
                //throw mess..
                passMess.Visibility = Visibility.Visible;
                checker = false;
            }
            if (retypePassBox.Password == "")
            {
                //throw mess..
                retypeMess.Visibility = Visibility.Visible;
                checker = false;
            }

            if (checker)
            {
                if (currentPassBox.Password == Global.database.SelectSingle("SD", "user_table", "user_password", "user_table_id = " + Global.userID)) //Current password correct:
                {
                    if (passwordBox.Password != retypePassBox.Password) //Password not match
                    {
                        //throw mess..
                        passErrorMess.Visibility = Visibility.Visible;
                        passMess.Visibility = Visibility.Collapsed;
                        retypeMess.Visibility = Visibility.Collapsed;
                        passChangedMess.Visibility = Visibility.Collapsed;
                        currentPassMess.Visibility = Visibility.Collapsed;
                    }
                    else
                    {
                        Global.database.Update("user_table", "user_password", passwordBox.Password, "user_table_id = " + Global.userID);
                        passErrorMess.Visibility = Visibility.Collapsed;

                        passMess.Visibility = Visibility.Collapsed;
                        retypeMess.Visibility = Visibility.Collapsed;
                        passChangedMess.Visibility = Visibility.Visible;
                        currentPassMess.Visibility = Visibility.Collapsed;
                    }
                }
                else
                {
                    currentPassMess.Visibility = Visibility.Visible;
                }
            }
        }
        private void ChangePassword(object sender, RoutedEventArgs e)
        {
            profileGrid.Visibility = Visibility.Collapsed;
            passwordGrid.Visibility = Visibility.Visible;
        }
        private void cancelPassLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            usernameBox.Text = tempUsername;
            nameBox.Text = tempName;
            emailBox.Text = tempMail;

            profileGrid.Visibility = Visibility.Visible;
            passwordGrid.Visibility = Visibility.Collapsed;
            passChangedMess.Visibility = Visibility.Collapsed;
            retypeMess.Visibility = Visibility.Collapsed;
            passMess.Visibility = Visibility.Collapsed;
        }
    }
}
