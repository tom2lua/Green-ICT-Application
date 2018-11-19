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
    /// Interaction logic for AdminAppointments.xaml
    /// </summary>
    public partial class AdminAppointments : Page
    {
        public AdminAppointments()
        {
            InitializeComponent();

            List<Appointment> appointments = new List<Appointment>();

            string[] clients = Global.database.Select("S", "appointment", "ref_client", null); //Get client:
            string[] emps = Global.database.Select("S", "appointment", "ref_emp", null); //Get service person:
            string[] description = Global.database.Select("SD", "appointment", "description", null); //Get description:

            for (int i = 0; i < description.Length; i++) //Loop through number of appointments:
            {
                string[] descriptionDatas = description[i].Split(';'); //Split description into datas:

                appointments.Add(new Appointment
                {
                    ID = (i + 1).ToString(),
                    ProductName = descriptionDatas[0],
                    Place = descriptionDatas[1],
                    Date = descriptionDatas[2],
                    StartTime = descriptionDatas[3],
                    ClientName = Global.database.SelectSingle("SD", "user_table", "real_name", "user_table_id = " + clients[i]),
                    ServicePerson = Global.database.SelectSingle("SD", "user_table", "real_name", "user_table_id = " + emps[i])
                });
            }

            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = dataGrid.FindResource("AdminAppointment") as CollectionViewSource;
            itemCollectionViewSource.Source = appointments;
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

        }
        private void About_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AdminAbout());
        }
    }
}
