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
    /// Логика взаимодействия для DriversLicensesListPage.xaml
    /// </summary>
    public partial class DriversLicensesListPage : Page
    {
        public DriversLicensesListPage()
        {
            InitializeComponent();
            DbConnect.dB = new ItogovoeGibddContext();

            var driversLicenses = DbConnect.dB.DriversLicenses.Select(card =>
            new
            {
                card.Number,
                card.Owner,
                card.DateOfIssue,
                card.DateOfExpiry,
                card.WhoIssued,
                card.Category,
            }).ToList();

            DataGrid.ItemsSource = driversLicenses;
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
    }
}
