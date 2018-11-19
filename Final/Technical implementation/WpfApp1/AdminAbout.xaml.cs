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
    /// Interaction logic for AdminAbout.xaml
    /// </summary>
    public partial class AdminAbout : Page
    {
        public AdminAbout()
        {
            InitializeComponent();
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
            this.NavigationService.Navigate(new AdminSetPlace());
        }
        private void Appointment_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminAppointments());
        }
        private void About_Selected(object sender, RoutedEventArgs e)
        {
        }
    }
}
