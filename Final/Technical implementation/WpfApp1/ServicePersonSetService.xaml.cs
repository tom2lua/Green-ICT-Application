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
    /// Interaction logic for serviceperson.xaml
    /// </summary>
    public partial class ServicePersonSetService : Page
    {
        public ServicePersonSetService()
        {
            InitializeComponent();
            date.SelectedDate = DateTime.Now; //Initialize date picker
        }
        List<Product> products = new List<Product>();
        List<Time> times = new List<Time>();
        //Menu:
        private void Service_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void Appointment_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonAppointment());
        }
        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonProfile());
        }
        private void About_Selected(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicePersonAbout());
        }
        
        //Back Icon:
        private void back_icon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            addProductGrid.Visibility = Visibility.Collapsed;
            productGrid.Visibility = Visibility.Collapsed;
            ChooseGrid.Visibility = Visibility.Visible;
        }
        private void back_icon_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            addTimeGrid.Visibility = Visibility.Collapsed;
            timeGrid.Visibility = Visibility.Collapsed;
            ChooseGrid.Visibility = Visibility.Visible;
        }

        //Choose section:
        private void Product_Click(object sender, RoutedEventArgs e)
        {
            ChooseGrid.Visibility = Visibility.Collapsed;
            productGrid.Visibility = Visibility.Visible;

            string[] productData = Global.database.Select("SD", "appointment_product", new string[] { "appointment_product_id", "appointment_product_name", "appoint_duration", "ref_appointment_place" }, "ref_user_emp = " + Global.userID);

            if (products.Count == 0)
            {
                for (int i = 0; i < productData.Length; i += 4)
                {
                    products.Add(new Product
                    {
                        ID = (products.Count() + 1).ToString(),
                        RealID = productData[i],
                        ProductName = productData[i + 1],
                        Duration = productData[i + 2],
                        Place = Global.database.SelectSingle("SD", "appointment_place", "appointment_place", "appointment_place_id = " + productData[i + 3])
                                    + " - " + Global.database.SelectSingle("SD", "appointment_place", "appointment_room", "appointment_place_id = " + productData[i + 3])
                    });
                }
            }
            productDataGrid.ItemsSource = null;
            productDataGrid.ItemsSource = products;
        }
        private void Time_Click(object sender, RoutedEventArgs e)
        {
            ChooseGrid.Visibility = Visibility.Collapsed;
            timeGrid.Visibility = Visibility.Visible;

            string[] timeData = Global.database.Select("SD", "user_emp_time", new string[] { "time_id", "date", "start_time" }, "ref_user_emp = " + Global.userID);

            if (times.Count() == 0)
            {
                for (int i = 0; i < timeData.Length; i += 3)
                {
                    times.Add(new Time
                    {
                        id = (times.Count() + 1).ToString(),
                        IDs = timeData[i],
                        Date = timeData[i + 1].Substring(0, 10),
                        StartTimes = timeData[i + 2]
                    });
                }
            }
            timeDataGrid.ItemsSource = null;
            timeDataGrid.ItemsSource = times;
        }
        private void AddTime_Click(object sender, RoutedEventArgs e)
        {
            addTimeGrid.Visibility = Visibility.Visible;
            timeGrid.Visibility = Visibility.Collapsed;
        }
        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            addProductGrid.Visibility = Visibility.Visible;
            productGrid.Visibility = Visibility.Collapsed;
        }

        // Add location:
        List<string> combinedList = new List<string>();
        private void location_open(object sender, EventArgs e)
        {
            string[] existedLocation = Global.database.Select("SD", "appointment_place", new string[] { "appointment_place_id", "appointment_place", "appointment_room" }, "ref_user_emp IS NULL OR ref_user_emp =" + Global.userID);

            for (int i = 0; i < existedLocation.Length; i += 3)
            {
                combinedList.Add(existedLocation[i] + " : " + existedLocation[i + 1] + " - " + existedLocation[i + 2]);
            }
            generalLocationBox.ItemsSource = combinedList;
        }
        private void productButton_Click(object sender, RoutedEventArgs e)
        {
            if (GeneralLocationGrid.Visibility == Visibility.Visible) //General location selected:
            {
                bool checker = true;
                if (generalLocationBox.SelectedValue == null)
                {
                    //throw mess..
                    checker = false;
                    generalPlaceMess.Visibility = Visibility.Visible;
                    addedMess.Visibility = Visibility.Collapsed;
                    productAddedMess.Visibility = Visibility.Collapsed;
                }
                if (productName.Text == "")
                {
                    //throw mess
                    checker = false;
                    serviceNameMess.Visibility = Visibility.Visible;
                    addedMess.Visibility = Visibility.Collapsed;
                    productAddedMess.Visibility = Visibility.Collapsed;
                }

                if (checker)
                {
                    generalPlaceMess.Visibility = Visibility.Collapsed;
                    serviceNameMess.Visibility = Visibility.Collapsed;
                    addedMess.Visibility = Visibility.Visible;
                    productAddedMess.Visibility = Visibility.Visible;

                    Global.database.Insert //Insert into database:
                    (
                        "appointment_product",
                        Global.informationSchema.GetColumn("appointment_product"),
                        new string[] { Global.userID, productName.Text, hourBox.Text + ":" + minuteBox.Text, generalLocationBox.Text.Substring(0, 2) }
                    );
                    products.Add(new Product
                    {
                        ID = (products.Count() + 1).ToString(),
                        Duration = hourBox.Text + ":" + minuteBox.Text,
                        ProductName = productName.Text,
                        Place = generalLocationBox.Text.Substring(0, 2),
                        RealID = Global.database.SelectSingle("SD", "appointment_product  ORDER BY appointment_product_id DESC LIMIT 1", "appointment_product_id", null)
                    });
                }
            }
            else if (newLocationGrid.Visibility == Visibility.Visible) //New location selected:
            {
                bool checker = true;

                if (newPlaceBox.Text == "" || newRoomBox.Text == "")
                {
                    //throw mess..
                    checker = false;
                    newPlaceMess.Visibility = Visibility.Visible;
                    addedMess.Visibility = Visibility.Collapsed;
                    productAddedMess.Visibility = Visibility.Collapsed;
                }
                else //Check if place already have 
                {
                    string checkString = Global.database.SelectSingle("SD", "appointment_place", "ref_user_emp", "appointment_place = '" + newPlaceBox.Text + "' AND appointment_room = '" + newRoomBox.Text + "'");
                    if (Global.userID == checkString || checkString == "")
                    {
                        //throw dublicate mess..
                        dublicateMess.Visibility = Visibility.Visible;
                        addedMess.Visibility = Visibility.Collapsed;
                        productAddedMess.Visibility = Visibility.Collapsed;
                        checker = false;
                    }
                }
                if (productName.Text == "")
                {
                    //throw mess
                    checker = false;
                    serviceNameMess.Visibility = Visibility.Visible;
                    addedMess.Visibility = Visibility.Collapsed;
                    productAddedMess.Visibility = Visibility.Collapsed;
                }

                if (checker)
                {
                    serviceNameMess.Visibility = Visibility.Collapsed;
                    newPlaceMess.Visibility = Visibility.Collapsed;
                    dublicateMess.Visibility = Visibility.Collapsed;
                    addedMess.Visibility = Visibility.Visible;
                    productAddedMess.Visibility = Visibility.Visible;


                    Global.database.Insert //Add new place first
                        (
                            "appointment_product",
                            Global.informationSchema.GetColumn("appointment_place"),
                            new string[] { Global.userID, newPlaceBox.Text, newRoomBox.Text }
                        );
                    Global.database.Insert
                        (
                            "appointment_product",
                            Global.informationSchema.GetColumn("appointment_product"),
                            new string[] { Global.userID, productName.Text, hourBox.Text + ":" + minuteBox.Text, generalLocationBox.Text.Substring(0, 2) }
                        );
                    products.Add(new Product
                    {
                        ID = (products.Count() + 1).ToString(),
                        Duration = hourBox.Text + ":" + minuteBox.Text,
                        ProductName = productName.Text,
                        Place = newPlaceBox.Text + " - " +newRoomBox.Text,
                        RealID = Global.database.SelectSingle("SD", "appointment_product", "appointment_product_id ORDER BY appointment_product_id DESC LIMIT 1", null)
                    });
                }
            }
            productDataGrid.ItemsSource = products;
        }

        //Radio buttons:
        private void GeneralLocation_Checked(object sender, RoutedEventArgs e)
        {
            GeneralLocationGrid.Visibility = Visibility.Visible;
            newLocationGrid.Visibility = Visibility.Collapsed;

            addedMess.Visibility = Visibility.Collapsed;
            dublicateMess.Visibility = Visibility.Collapsed;
            generalPlaceMess.Visibility = Visibility.Collapsed;
            newPlaceMess.Visibility = Visibility.Collapsed;
            serviceNameMess.Visibility = Visibility.Collapsed;
        }
        private void NewLocation_Checked(object sender, RoutedEventArgs e)
        {
            GeneralLocationGrid.Visibility = Visibility.Collapsed;
            newLocationGrid.Visibility = Visibility.Visible;

            addedMess.Visibility = Visibility.Collapsed;
            dublicateMess.Visibility = Visibility.Collapsed;
            generalPlaceMess.Visibility = Visibility.Collapsed;
            newPlaceMess.Visibility = Visibility.Collapsed;
            serviceNameMess.Visibility = Visibility.Collapsed;
        }

        //Time submit:
        private void TimeButton_Click(object sender, RoutedEventArgs e)
        {
            if (startTime.Text == null || endTime.Text == null) //null boxes
            {
                //throw mess..
                timeMess.Visibility = Visibility.Visible;
                timeCompareMess.Visibility = Visibility.Collapsed;
                timeAddedMess.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (dateMess.Visibility == Visibility.Collapsed) //Check Date:
                {
                    timeMess.Visibility = Visibility.Collapsed;
                    timeCompareMess.Visibility = Visibility.Collapsed;
                    //Adjust time input to format 0:00, 0:15, 0:30, 0:45:
                    string pickedStartTime = Global.TimeAdjuster(startTime.Text);
                    string pickedEndTime = Global.EndTimeAdjuster(endTime.Text);

                    //Check start time and end time:
                    if (Global.GetHour(pickedStartTime) < Global.GetHour(pickedEndTime))
                    {
                        string pickedDate = date.SelectedDate.Value.Year.ToString() + "/" + date.SelectedDate.Value.Month.ToString() + "/" + date.SelectedDate.Value.Day.ToString();
                        while (pickedStartTime != pickedEndTime)
                        {
                            if (Global.database.SelectSingle("SD", "user_emp_time", "time_id", "date = '" + pickedDate + "' AND start_time = '" + pickedStartTime + "'") == "") //Check if time already exist
                            {
                                Global.database.Insert("user_emp_time", Global.informationSchema.GetColumn("user_emp_time"), new string[] { Global.userID, pickedDate, pickedStartTime, Global.Add15Minutes(pickedStartTime), "free" });
                                times.Add(new Time
                                {
                                    id = (times.Count() + 1).ToString(),
                                    IDs = Global.database.SelectSingle("SD", "user_emp_time ORDER BY time_id DESC LIMIT 1", "time_id", null),
                                    Date = pickedDate,
                                    StartTimes = pickedStartTime
                                });
                            }
                            pickedStartTime = Global.Add15Minutes(pickedStartTime);
                        }
                        timeAddedMess.Visibility = Visibility.Visible;
                    }
                    else if (Global.GetHour(pickedStartTime) == Global.GetHour(pickedEndTime))
                    {
                        if (Global.GetMinute(pickedStartTime) < Global.GetMinute(pickedEndTime))
                        {
                            string pickedDate = date.SelectedDate.Value.Year.ToString() + "/" + date.SelectedDate.Value.Month.ToString() + "/" + date.SelectedDate.Value.Day.ToString();
                            while (pickedStartTime != pickedEndTime)
                            {
                                if (Global.database.SelectSingle("SD", "user_emp_time", "time_id", "date = '" + pickedDate + "' AND start_time = '" + pickedStartTime + "'") == "") //Check if time already exist
                                {
                                    Global.database.Insert("user_emp_time", Global.informationSchema.GetColumn("user_emp_time"), new string[] { Global.userID, pickedDate, pickedStartTime, Global.Add15Minutes(pickedStartTime), "free" });
                                    times.Add(new Time
                                    {
                                        id = (times.Count() + 1).ToString(),
                                        IDs = Global.database.SelectSingle("SD", "user_emp_time ORDER BY time_id DESC LIMIT 1", "time_id", null),
                                        Date = pickedDate,
                                        StartTimes = pickedStartTime
                                    });
                                }
                                pickedStartTime = Global.Add15Minutes(pickedStartTime);
                            }
                            timeAddedMess.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            //throw mess..
                            timeCompareMess.Visibility = Visibility.Visible;
                            timeAddedMess.Visibility = Visibility.Collapsed;
                        }
                    }
                    else
                    {
                        //throw mess..
                        timeCompareMess.Visibility = Visibility.Visible;
                        timeAddedMess.Visibility = Visibility.Collapsed;
                    }
                }
            }
            timeDataGrid.ItemsSource = null;
            timeDataGrid.ItemsSource = times;
        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (date.SelectedDate.Value.Date < DateTime.Now.Date) //Check day
            {
                //throw mess
                dateMess.Visibility = Visibility.Visible;
            }
            else
            {
                dateMess.Visibility = Visibility.Collapsed;
            }
        }
    }
}