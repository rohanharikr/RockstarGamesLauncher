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

        [JsonPropertyName("bg_image")]
        public string? BackgroundImage{ get; set; }

        [JsonPropertyName("feed")]
        public List<Post>? Feed { get; set; }

        public class Post()
        {
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            [JsonPropertyName("image")]
            public Uri? Image { get; set; }

            [JsonPropertyName("link")]
            public Uri? Link { get; set; }
        }
    }
}
