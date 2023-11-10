using itogovoe_gibdd.Database;
using itogovoe_gibdd.Pages;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            DbConnect.dB = new ItogovoeGibddContext();
            Profiles profile = DbConnect.dB.Profiles.FirstOrDefault();
            DataContext = profile;
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
