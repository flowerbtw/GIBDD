using itogovoe_gibdd.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
    /// Логика взаимодействия для DriversCardsListPage.xaml
    /// </summary>
    public partial class DriversCardsListPage : Page
    {
        public DriversCardsListPage()
        {
            InitializeComponent();
            DbConnect.dB = new ItogovoeGibddContext();

            var driversCards = DbConnect.dB.DriversCards.Select(card =>
            new
            {
                card.Guid,
                card.Surname,
                card.Name,
                card.Passport,
                card.RegistrationAddress,
                card.ResidentialAddress,
                card.Company,
                card.Jobname,
                card.PhoneNumber,
                card.Email,
                card.Notes
            }).ToList();

            DataGrid.ItemsSource = driversCards;
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
