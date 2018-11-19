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
    public partial class ClientAbout : Page
    {
        public ClientAbout()
        {
            InitializeComponent();
        }

        //Hamburger Menu:
        private void Booking_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientBooking());  
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
        }
    }
}
