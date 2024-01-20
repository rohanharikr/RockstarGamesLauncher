using System.Windows.Controls;
using RockstarGamesLauncher.ViewModels;

namespace RockstarGamesLauncher.Views
{
    public partial class SettingsView : Page
    {
        public SettingsView()
        {
            InitializeComponent();
            DataContext = new SettingsViewModel();
        }
    }
}
