using System.Text.Json;
using RockstarGamesLauncher.Models;
using System.IO;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RockstarGamesLauncher.ViewModels
{
    public partial class GamesViewModel : ObservableObject
    {
        public ObservableCollection<GameModel> Games { get; set; }

        [ObservableProperty]
        public GameModel? selectedGame;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(SidebarWidth))]
        public bool isExpanded = true;

        public int SidebarWidth => IsExpanded ? 320 : 120;

        public GamesViewModel()
        {
            Games = GetGames();
            SelectedGame = Games.FirstOrDefault();
        }

        static ObservableCollection<GameModel> GetGames()
        {
            //TBD: Handle exceptions
            using StreamReader file = new("Resources/Data/games.json");
            string json = file.ReadToEnd();
            return JsonSerializer.Deserialize<ObservableCollection<GameModel>>(json);
        }

        [RelayCommand]
        public void ToggleExpand()
        {
            IsExpanded = !IsExpanded;
        }

        [RelayCommand]
        public void SelectGame(GameModel selectGame)
        {
            SelectedGame = selectGame;
        }
    }
}
