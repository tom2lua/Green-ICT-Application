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
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            InitializeComponent();
            nameLabel.Content = "Hello " + Global.database.SelectSingle("SD", "user_table", "real_name", "user_table_id = " + Global.userID);
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientBooking());
        }
    }
}
