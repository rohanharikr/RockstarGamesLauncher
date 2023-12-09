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
using RockstarGamesLauncher.Views.Settings;

namespace RockstarGamesLauncher.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : Page
    {
        public SettingsView()
        {
            InitializeComponent();
            Settings.Content = new SettingsGeneralView();
        }

        private void GoToGeneral(object sender, RoutedEventArgs e)
        {
            Settings.Content = new SettingsGeneralView();
        }

        private void GoToAccountInfo(object sender, RoutedEventArgs e)
        {
            Settings.Content = new SettingsAccountInfoView();
        }

        private void GoToUpdates(object sender, RoutedEventArgs e)
        {
            Settings.Content = new SettingsGeneralView();
        }

        private void GoToLegal(object sender, RoutedEventArgs e)
        {
            Settings.Content = new SettingsLegalView();
        }
    }
}
