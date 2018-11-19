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
    /// Interaction logic for ClientAppointment.xaml
    /// </summary>
    public partial class ClientAppointment : Page
    {
        List<Appointment> appointments = new List<Appointment>();
        public ClientAppointment()
        {
            InitializeComponent();
            
            string [] realID = Global.database.Select("S", "appointment", "appointment_id", "ref_client = " + Global.userID); //Get id:
            string[] emps = Global.database.Select("S", "appointment", "ref_emp", "ref_client = " + Global.userID); //Get service person:
            string[] description = Global.database.Select("SD", "appointment", "description", "ref_client = " + Global.userID); //get description:

            for (int i = 0; i < description.Length; i++) //Loop through number of appointments:
            {
                string[] descriptionDatas = description[i].Split(';'); //Split description into datas:

                appointments.Add(new Appointment {realID = realID[i], ID = (i + 1).ToString(), ProductName = descriptionDatas[0], Place = descriptionDatas[1], Date = descriptionDatas[2], StartTime = descriptionDatas[3],
                    ServicePerson = Global.database.SelectSingle("SD", "user_table", "real_name", "user_table_id = " + emps[i])});
            }

            dataGrid.ItemsSource = appointments;
        }


        //Hamburger Menu:
        private void Booking_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientBooking());
        }
        private void Appointment_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientProfile());
        }
        private void About_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientAbout());
        }

        //private void modifyButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            bool selectChecker = true;
            for (int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i].IsSelected) //Take the selected appointment:
                {
                    noappointmentMess.Visibility = Visibility.Collapsed;
                    warningMess.Visibility = Visibility.Visible;

                    cancelButton.Visibility = Visibility.Collapsed;
                    //modifyButton.Visibility = Visibility.Collapsed;

                    cancelcancelButton.Visibility = Visibility.Visible;
                    confirmCancelButton.Visibility = Visibility.Visible;
                    selectChecker = false;
                }
            }
            if (selectChecker)
            {
                //throw mess..
                noappointmentMess.Visibility = Visibility.Visible;
                warningMess.Visibility = Visibility.Collapsed;
            }
        }
        private void cancelcancelButton_Click(object sender, RoutedEventArgs e)
        {
            cancelButton.Visibility = Visibility.Visible;
            //modifyButton.Visibility = Visibility.Visible;

            warningMess.Visibility = Visibility.Collapsed;

            cancelcancelButton.Visibility = Visibility.Collapsed;
            confirmCancelButton.Visibility = Visibility.Collapsed;
        }
        private void confirmCancelButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < appointments.Count; i++)
            {
                if (appointments[i].IsSelected) //Take the selected appointment:
                {
                    string[] startTimes = appointments[i].StartTime.Split('-');
                    for (int k = 0; k < startTimes.Length; k++) //Set taken slot to free:
                    {
                        Global.database.Update("user_emp_time", "slot_status", "free", "start_time = '" + startTimes[k] + "'");
                        
                    }
                    Global.database.Delete("appointment", "appointment_id = " + appointments[i].realID); //Delete appointment in database:
                    appointments.RemoveAt(i);
                }
            }
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = appointments;

            warningMess.Visibility = Visibility.Collapsed;
        }
    }
}
