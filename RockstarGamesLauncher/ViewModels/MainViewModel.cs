using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RockstarGamesLauncher.Views;
using RockstarGamesLauncher.Views.Settings;

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
        public List<string> navItems = new List<string> { "GAMES", "SETTINGS" };

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


        [RelayCommand]
        void GotoGames()
        {
            if (CurrentPage is GamesView)
                return;

            CurrentPage = new GamesView();
        }

        [RelayCommand]
        void GotoSettings()
        {
            if (CurrentPage is SettingsView)
                return;

            CurrentPage = new SettingsView();
        }
    }
}
