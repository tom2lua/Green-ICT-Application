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
    /// Interaction logic for ServicePersonAbout.xaml
    /// </summary>
    public partial class ServicePersonAbout : Page
    {
        public ServicePersonAbout()
        {
            InitializeComponent();
        }

        //Hamburger Menu:
        private void About_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Service_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonSetService());
        }

        private void Appointment_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonAppointment());
        }

        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonProfile());
        }
    }
}
