using itogovoe_gibdd.Database;
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

namespace itogovoe_gibdd
{
    /// <summary>
    /// Логика взаимодействия для RoadAccidentsListPage.xaml
    /// </summary>
    public partial class RoadAccidentsListPage : Page
    {
        public RoadAccidentsListPage()
        {
            InitializeComponent();
            DbConnect.dB = new ItogovoeGibddContext();

            var roadAccidents = DbConnect.dB.RoadAccidents.Select(accident =>
            new
            {
                accident.Guid,
                accident.Class,
                accident.Culprit,
                accident.Victim
            }).ToList();

            DataGrid.ItemsSource = roadAccidents;
        }

        private void DriversCardsListButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new DriversCardsListPage());
        }

        private void VenichlesListButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new VenichlesListPage());
        }

        private void DriversLicensesListButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new DriversLicensesListPage());
        }

        private void RoadAccidentsListButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new RoadAccidentsListPage());
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new ProfilePage());
        }

        //private void OnRowDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    NavigationService.Navigate(new DriverCard());
        //}
    }
}
