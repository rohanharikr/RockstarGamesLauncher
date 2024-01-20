using System.Windows.Controls;
using RockstarGamesLauncher.ViewModels;

namespace RockstarGamesLauncher.Views
{
    public partial class GamesView : Page
    {
        public GamesView()
        {
            InitializeComponent();
            DataContext = new GamesViewModel();
        }
    }
}
