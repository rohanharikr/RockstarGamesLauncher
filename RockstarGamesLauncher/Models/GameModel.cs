using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace RockstarGamesLauncher.Models
{
    public class GameModel
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("slug")]
        public string? Slug {  get; set; }
        
        [JsonPropertyName("icon")]
        public string? Icon { get; set; }
        
        [JsonPropertyName("logo")]
        public string? Logo { get; set; }

        [JsonPropertyName("images")]
        public List<string>? Images { get; set; }

        public GameModel()
        {
        }

    }
}
