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
        object currentPage = new SettingsGeneralView();

        [RelayCommand]
        void GotoGeneral()
        {
            CurrentPage = new SettingsGeneralView();
        }

        [RelayCommand]
        void GotoAccountInfo()
        {
            CurrentPage = new SettingsAccountInfoView();
        }

        [RelayCommand]
        void GotoUpdates()
        {
            CurrentPage = new SettingsUpdatesView();
        }

        [RelayCommand]
        void GotoLegal()
        {
            CurrentPage = new SettingsLegalView();
        }
    }
}
