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
    /// Interaction logic for ServicePersonAppointment.xaml
    /// </summary>
    public partial class ServicePersonAppointment : Page
    {
        public ServicePersonAppointment()
        {
            InitializeComponent();

            List<Appointment> appointments = new List<Appointment>();

            string[] clients = Global.database.Select("SD", "appointment", "ref_client", "ref_emp = " + Global.userID); //Get service person:
            string[] description = Global.database.Select("SD", "appointment", "description", "ref_emp = " + Global.userID); //get description:

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
                    ClientName = Global.database.SelectSingle("SD", "user_table", "real_name", "user_table_id = " + clients[i])
                });
            }

            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = dataGrid.FindResource("ServicePersonAppointment") as CollectionViewSource;
            itemCollectionViewSource.Source = appointments;
        }

        //Menu:
        private void Service_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonSetService());
        }
        private void Appointment_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonProfile());
        }
        private void About_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonAbout());
        }
    }
}
