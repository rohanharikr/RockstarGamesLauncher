using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RockstarGamesLauncher.Views;

namespace RockstarGamesLauncher.ViewModels
{
    partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        object? currentPage;

        private GamesView gamesView;
        private SettingsView settingsView;

        private int _selectedPageIndex;
        public int SelectedPageIndex
        {
            get { return _selectedPageIndex; }
            set { _selectedPageIndex = value; Navigate(); }
        }

        public MainViewModel()
        {
            SelectedPageIndex = 0;
            gamesView = new GamesView();
            settingsView = new SettingsView();
            Navigate();
        }

        [ObservableProperty]
        public List<string> navItems = ["GAMES", "SETTINGS"];

        [RelayCommand]
        void Navigate()
        {
            switch (SelectedPageIndex)
            {
                case 0:
                    CurrentPage = gamesView;
                    break;
                case 1:
                    CurrentPage = settingsView;
                    break;
            }
        }
    }
}
