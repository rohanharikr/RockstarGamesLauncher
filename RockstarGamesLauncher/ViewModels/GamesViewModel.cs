using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public GamesViewModel()
        {
            Games = GetGames();
            SelectedGame = Games.FirstOrDefault();
        }

        ObservableCollection<GameModel> GetGames()
        {
            //TBD: Handle exceptions
            using (StreamReader file = new StreamReader("Resources/Data/games.json"))
            {
                string json = file.ReadToEnd();
                return JsonSerializer.Deserialize<ObservableCollection<GameModel>>(json);
            }
        }

        [RelayCommand]
        void SelectGame(GameModel selectedGame)
        {
            Console.WriteLine(123);
        }
    }
}
