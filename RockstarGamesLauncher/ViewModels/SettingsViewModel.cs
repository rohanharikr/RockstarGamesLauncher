using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RockstarGamesLauncher.Views.Settings;

namespace RockstarGamesLauncher.ViewModels
{
    partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        object currentPage = new SettingsAccountInfoView();

        public SettingsViewModel()
        {
            GoToGeneral();
        }

        [RelayCommand]
        void GoToGeneral()
        {
            CurrentPage = new SettingsGeneralView();
        }

        [RelayCommand]
        void GoToAccountInfo()
        {
            CurrentPage = new SettingsAccountInfoView();
        }

        [RelayCommand]
        void GoToUpdates()
        {
            CurrentPage = new SettingsUpdatesView();
        }

        [RelayCommand]
        void GoToLegal()
        {
            CurrentPage = new SettingsLegalView();
        }
    }
}
