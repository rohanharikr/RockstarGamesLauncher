using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RockstarGamesLauncher.Views;

namespace RockstarGamesLauncher.ViewModels
{
    partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        object currentPage = new GamesView();

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
