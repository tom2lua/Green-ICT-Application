using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Collections;

namespace WpfApp1
{
    public partial class ClientBooking : Page
    {
        public ClientBooking()
        {
            InitializeComponent();   
        }

        public static string selectedPerson;
        private string selectedService;
        private string selectedPlace;
        private string[] placeList;
        private string[] combinedList;
        private int placeID;
        private string selectedDate;
        private string servicePersonID;
        private string duration;
        public List<Time> Times = new List<Time>();
        //Product:
        public string[] GetProduct(string SelectedServicePerson)
        {
            string[] products = Global.database.Select("SD", "`appointment_product`, `user_table`", "appointment_product_name", "user_table.real_name = '" + SelectedServicePerson + "' AND user_table.user_table_id = appointment_product.ref_user_emp");
            return products;
        }
        public string[] GetPlace(string selectedPerson, string selectedProduct)
        {
            string[] column = { "appointment_place", "appointment_room" };
            string[] location = Global.database.Select("SD", "appointment_product, appointment_place", column, "appointment_product.appointment_product_name = '" + selectedProduct + "' AND appointment_place.appointment_place_id = appointment_product.ref_appointment_place");
            return location;
        }
        public void GetPlaceID()
        {
            int x = 0;
            while (x < placeList.Length)
            {
                if (selectedPlace.Contains(placeList[x]) && selectedPlace.Contains(placeList[x + 1]) == true)
                {
                    placeID = int.Parse(Global.database.SelectSingle("SD", "appointment_place", "appointment_place_id", "`appointment_place` = '" + placeList[x] + "' AND `appointment_room` ='" + placeList[x + 1] + "'"));
                    break;
                }
                x += 2;
            }
        }
        private void namebox_opened(object sender, EventArgs e)
        {
            nameBox.ItemsSource = Global.database.Select("S", "user_table", "real_name", "role = 'Service Person'");
        }
        private void namebox_closed(object sender, EventArgs e)
        {
            if (nameBox.SelectedValue != null)
            {
                selectedPerson = nameBox.SelectedValue.ToString();
                servicePersonID = Global.database.SelectSingle("SD", "user_table", "user_table_id", "real_name = '" + selectedPerson + "'");

                string[] productList = GetProduct(selectedPerson);
                productBox.ItemsSource = productList;
            }
        }
        private void placeBox_opend(object sender, EventArgs e)
        {
            if (productBox.SelectedValue != null)
            {
                selectedService = productBox.SelectedValue.ToString();

                placeList = GetPlace(selectedPerson, selectedService);
                combinedList = new string[placeList.Length / 2];
                int count = 0;
                for (int i = 0; i < combinedList.Length; i++)
                {
                    combinedList[i] = placeList[i + count] + "_" + placeList[i + count + 1];
                    count++;
                }
                placeBox.ItemsSource = combinedList;
            }
        }
        private void placeBox_closed(object sender, EventArgs e)
        {
            if (placeBox.SelectedValue != null)
            {
                selectedPlace = placeBox.SelectedValue.ToString();
                GetPlaceID();
                duration = Global.database.SelectSingle("SD", "appointment_product", "appoint_duration", "`appointment_product_name` = '" + selectedService + "' AND ref_appointment_place = '" + placeID.ToString() + "'");
                durationLabel.Content = duration;
            }
        }
        private void contiButton_Click(object sender, RoutedEventArgs e)
        {
            //throw mess..
            if (nameBox.Text == null)
            {
                nameMess.Visibility = Visibility.Visible;
            }
            else
            {
                nameMess.Visibility = Visibility.Collapsed;
            }
            if (productBox.Text == null)
            {
                productMess.Visibility = Visibility.Visible;
            }
            else
            {
                productMess.Visibility = Visibility.Collapsed;
            }
            if (placeBox.Text == null)
            {
                placeBox.Visibility = Visibility.Visible;
            }
            else
            {
                placeMess.Visibility = Visibility.Collapsed;
            }

            if (nameMess.Visibility != Visibility.Visible || productMess.Visibility != Visibility.Visible || placeMess.Visibility != Visibility.Visible)
            {
                productGrid.Visibility = Visibility.Collapsed;
                dateTimeGrid.Visibility = Visibility.Visible;
                currentDuration.Content = "Your appointment duration: " + duration;
            }
        }

        //Hamburger Menu:
        private void Booking_Selected(object sender, RoutedEventArgs e)
        {
            
        }
        private void Appointment_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientAppointment());
        }
        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientProfile());
        }
        private void About_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientAbout());
        }
        //Calendar:
        private string addZeroToDate(string myDate)
        {
            if (int.Parse(myDate) < 10)
            {
                return "0" + myDate;
            }
            else
                return myDate;
        }
        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            int TimesCount = Times.Count;
            for (int i = 0; i < TimesCount; i++) //Refresh the Times list:
            {
                Times.RemoveAt(0);
            }

            if (calendar.SelectedDate.Value.Date < DateTime.Now.Date) //Check Date
            {
                    dateMess.Visibility = Visibility.Visible;
            }
            else
            {
                selectedDate = addZeroToDate(calendar.SelectedDate.Value.Month.ToString()) + "/" + addZeroToDate(calendar.SelectedDate.Value.Day.ToString()) + "/" + calendar.SelectedDate.Value.Year.ToString();

                dateMess.Visibility = Visibility.Collapsed;
               
                string[] datas = Global.database.Select("SD", "user_emp_time", new string[] { "DATE_FORMAT(date, '%m/%d/%Y')", "start_time", "time_id" }, "DATE_FORMAT(date, '%m/%d/%Y') = '" + selectedDate + "' AND slot_status = 'free' AND ref_user_emp =" + servicePersonID); //Suitable Date and Time


                for (int i = 0; i < datas.Length; i += 3)
                {
                    Times.Add(new Time { Date = datas[i], StartTimes = datas[i + 1], IDs = datas[i + 2] });
                }               
                for (int i = 0; i < Times.Count; i++)
                {
                    Times[i].id = (i + 1).ToString();
                }

                //CollectionViewSource itemCollectionViewSource;
                //itemCollectionViewSource = (CollectionViewSource)(FindResource("ItemCollectionViewSource"));
                //itemCollectionViewSource.Source = Times;

                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = Times;
            }
        }
        private void back_icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            dateTimeGrid.Visibility = Visibility.Collapsed;
            productGrid.Visibility = Visibility.Visible;
        }
        private void timeSubmit_Click(object sender, RoutedEventArgs e)
        {
            List<string> selectedTimeID = new List<string>();
            List<string> selectedTime = new List<string>();

            for (int i = 0; i < Times.Count; i++) //Save the selected time IDs
            {
                if(Times[i].Selected)
                {
                    selectedTimeID.Add(Times[i].IDs);
                    selectedTime.Add(Times[i].StartTimes);
                }
            }

            if (selectedTime.Count != 0) //Check if no time selected
            {
                noTimeMess.Visibility = Visibility.Collapsed;

                for (int i = 0; i < selectedTime.Count; i++) //Change time slot condition to taken:
                {
                    Global.database.Update("user_emp_time", "slot_status", "taken", "time_id = " + selectedTimeID[i]);
                }
                //Make appointment description:
                string description = selectedService + ";" + selectedPlace + ";" + selectedDate + ";" + Global.StringFromArray(selectedTime.ToArray());
                //Insert appointment to database:
                Global.database.Insert("appointment", Global.informationSchema.GetColumn("appointment"), new string[] { Global.userID, servicePersonID, description });
                appointmentBookedMess.Visibility = Visibility.Visible;
            }
            else
            {
                noTimeMess.Visibility = Visibility.Visible;
            }
        }

        
    }
}
