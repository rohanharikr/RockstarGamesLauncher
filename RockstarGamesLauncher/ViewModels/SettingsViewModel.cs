using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RockstarGamesLauncher.Views.Settings;

namespace RockstarGamesLauncher.ViewModels
{
    partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        object? currentPage;

        private int _selectedPageIndex;
        public int SelectedPageIndex
        {
            get { return _selectedPageIndex; }
            set { _selectedPageIndex = value; Navigate(); }
        }

        public SettingsViewModel()
        {
            SelectedPageIndex = 0;
        }

        [ObservableProperty]
        public List<string> settingsItems = new List<string> { "General", "Account information", "Updates", "Legal" };

        [RelayCommand]
        void Navigate()
        {
            switch (SelectedPageIndex)
            {
                case 0:
                    CurrentPage = new SettingsGeneralView();
                    break;
                case 1:
                    CurrentPage = new SettingsAccountInfoView();
                    break;
                case 2:
                    CurrentPage = new SettingsUpdatesView();
                    break;
                case 3:
                    CurrentPage = new SettingsLegalView();
                    break;
            }
        }
    }
}
