using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RockstarGamesLauncher.Views;

namespace RockstarGamesLauncher.ViewModels
{
    partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        object? currentPage;

        private int _selectedPageIndex;
        public int SelectedPageIndex
        {
            get { return _selectedPageIndex; }
            set { _selectedPageIndex = value; Navigate(); }
        }

        public MainViewModel()
        {
            SelectedPageIndex = 0;
        }

        [ObservableProperty]
        public List<string> navItems = ["GAMES", "SETTINGS"];

        [RelayCommand]
        void Navigate()
        {
            switch (SelectedPageIndex)
            {
                case 0:
                    CurrentPage = new GamesView();
                    break;
                case 1:
                    CurrentPage = new SettingsView();
                    break;
            }
        }
    }
}
