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
    /// Interaction logic for AdminUser.xaml
    /// </summary>
    public partial class AdminUser : Page
    {
        List<Users> users = new List<Users>();
        public AdminUser()
        {
            InitializeComponent();

            string[] userData = Global.database.Select("SD", "user_table", new string[] { "real_name", "user_name", "email", "user_password", "role" }, null); //Get data:
            int count = 1;

            for (int i = 0; i < userData.Length; i += 5) //Loop through number of user:
            {
                users.Add(new Users
                {
                    ID = count.ToString(),
                    RealName = userData[i],
                    UserName = userData[i + 1],
                    Email = userData[i + 2],
                    Password = userData[i + 3],
                    Role = userData[i + 4]
                });
                count++;
            }

            dataGrid.ItemsSource = users;
        }

        //Change role:
        private void ChangeRoleButton_Click(object sender, RoutedEventArgs e)
        {
            bool noUserChecker = true;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Checker == true) //Take the selected user:
                {
                    if (users[i].Role == "Admin") //Admin user cannot be edit
                    {
                        //Throw mess..
                        adminRightMess.Visibility = Visibility.Visible;
                        noUserChecker = false;
                    }
                    else
                    {
                        noUserChecker = false;
                        userGrid.Visibility = Visibility.Collapsed;
                        adminRightMess.Visibility = Visibility.Collapsed;

                        userNameBox.Text = users[i].UserName;
                        if (users[i].Role == "Service Person") //Change default combobox value:
                        {
                            serviceCombo.IsSelected = true;
                        }
                        else
                        {
                            clientCombo.IsSelected = true;
                        }
                        ChangeRoleGrid.Visibility = Visibility.Visible;
                    }
                }
            }
            if (noUserChecker) //No user selected:
            {
                noUserSelectedMess.Visibility = Visibility.Visible;
            }
            else
            {
                noUserSelectedMess.Visibility = Visibility.Collapsed;
            }
        }
        private void ChangeRoleConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Checker == true) //Take the selected user:
                {
                    Global.database.Update("user_table", "role", roleSelectBox.SelectedValue.ToString().Substring(38), "user_name = '" + users[i].UserName + "'");
                    users[i].Role = roleSelectBox.SelectedValue.ToString().Substring(38);

                    ChangeRoleGrid.Visibility = Visibility.Collapsed;
                    userGrid.Visibility = Visibility.Visible;
                }
            }
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = users;
        }
        private void ChangeRoleCancel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ChangeRoleGrid.Visibility = Visibility.Collapsed;
            userGrid.Visibility = Visibility.Visible;
        }
        //Delete user:
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            bool noUserChecker = true;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Checker == true) //Take the selected user:
                {
                    if (users[i].Role == "Admin") //Admin user cannot be deleted..
                    {
                        //Throw mess..
                        adminRightMess.Visibility = Visibility.Visible;
                        noUserChecker = false;
                    }
                    else 
                    {
                        noUserChecker = false;
                        //Throw mess..
                        adminRightMess.Visibility = Visibility.Collapsed;
                        deleteWarningMess.Visibility = Visibility.Visible;
                        //Collapse buttons:
                        ChangeRoleButton.Visibility = Visibility.Collapsed;
                        DeleteBUtton.Visibility = Visibility.Collapsed;

                        DeleteConfirmButton.Visibility = Visibility.Visible;
                        DeleteCancelButton.Visibility = Visibility.Visible;
                    }
                }
            }
            if (noUserChecker)
            {
                noUserSelectedMess.Visibility = Visibility.Visible;
            }
            else
            {
                noUserSelectedMess.Visibility = Visibility.Collapsed;
            }
        }
        private void DeleteConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Checker == true) //Take the selected user:
                {
                    Global.database.Delete("user_table", "user_name = '" + users[i].UserName + "'"); //Remove user from database and List
                    users.RemoveAt(i);

                    deleteWarningMess.Visibility = Visibility.Collapsed;
                    //Collapse buttons:
                    ChangeRoleButton.Visibility = Visibility.Visible;
                    DeleteBUtton.Visibility = Visibility.Visible;

                    DeleteConfirmButton.Visibility = Visibility.Collapsed;
                    DeleteCancelButton.Visibility = Visibility.Collapsed;
                }
            }
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = users;
        }
        private void DeleteCancelButton_Click(object sender, RoutedEventArgs e)
        {
            deleteWarningMess.Visibility = Visibility.Collapsed;
            //Collapse buttons:
            ChangeRoleButton.Visibility = Visibility.Visible;
            DeleteBUtton.Visibility = Visibility.Visible;

            DeleteConfirmButton.Visibility = Visibility.Collapsed;
            DeleteCancelButton.Visibility = Visibility.Collapsed;
        }
        //Hamburger Menu:
        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminProfile());
        }
        private void Users_Selected(object sender, RoutedEventArgs e)
        {

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

    }
}
