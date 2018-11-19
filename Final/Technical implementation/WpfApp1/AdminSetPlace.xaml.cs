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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class AdminSetPlace : Page
    {
        List<Place> places = new List<Place>();
        public AdminSetPlace()
        {
            InitializeComponent();

            string[] placeData = Global.database.Select("SD", "appointment_place", new string[] { "appointment_place_id", "appointment_place", "appointment_room" }, "ref_user_emp IS NULL");

            for (int i = 0; i < placeData.Length; i += 3)
            {
                places.Add(new Place { realID = placeData[i], AppointmentPlace = placeData[i + 1], Room = placeData[i + 2] });
            }
            for (int i = 0; i < places.Count; i++)
            {
                places[i].ID = (i + 1).ToString();
            }

            dataGrid.ItemsSource = places;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ServiceGrid.Visibility = Visibility.Collapsed;
            addGrid.Visibility = Visibility.Visible;
        }
        private void AddConfimButton_Click(object sender, RoutedEventArgs e)
        {
            bool checker = true;
            if (placeBox.Text == "")
            {
                placeMess.Visibility = Visibility.Visible;
                checker = false;
                duplicateMess.Visibility = Visibility.Collapsed;
            }
            if (roomBox.Text == "")
            {
                roomMess.Visibility = Visibility.Visible;
                checker = false;
                duplicateMess.Visibility = Visibility.Collapsed;
            }
            if (checker) //Null boxes check:
            {
                placeMess.Visibility = Visibility.Collapsed;
                roomMess.Visibility = Visibility.Collapsed;

                if (Global.database.SelectSingle("SD", "appointment_place", "appointment_place", "appointment_place = '" + placeBox.Text + "' AND appointment_room = '" + roomBox.Text + "'") == "") //Check if place already have:
                {
                    duplicateMess.Visibility = Visibility.Collapsed;
                    Global.database.Insert("appointment_place", new string[] { "appointment_place", "appointment_room" }, new string[] { placeBox.Text, roomBox.Text }); //Insert to database:
                    places.Add(new Place
                    {
                        ID = (places.Count + 1).ToString(),
                        AppointmentPlace = placeBox.Text,
                        Room = roomBox.Text,
                        realID = Global.database.SelectSingle("SD", "appointment_place", "appointment_place_id", "appointment_place = '" + placeBox.Text + "' AND appointment_room = '" + roomBox.Text + "'")
                    });
                    ServiceGrid.Visibility = Visibility.Visible;
                    addGrid.Visibility = Visibility.Collapsed;
                }
                else
                {
                    duplicateMess.Visibility = Visibility.Visible;
                }
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = places;
            }
        }
        private void AddCancel_Click(object sender, RoutedEventArgs e)
        {
            ServiceGrid.Visibility = Visibility.Visible;
            addGrid.Visibility = Visibility.Collapsed;
        }
        //Hamburger Menu:
        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminProfile());
        }
        private void Users_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminUser());
        }
        private void ServicePlace_Selected(object sender, RoutedEventArgs e)
        {
            
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
