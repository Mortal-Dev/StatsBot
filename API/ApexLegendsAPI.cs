using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;

using System.Collections.Generic;
using System.IO;
using System.Net.Http;

using Newtonsoft.Json;

using StatsBot.JsonObjects;

namespace StatsBot.API
{
    class ApexLegendsAPI : IAPIRequest
    {
        private const string apexLegendsAPIKey = "";

        public readonly Dictionary<string, string> validPlatforms = new Dictionary<string, string>()
        {
            {"PS4", "PS4" },
            {"PC", "PC" },
            {"XBOX", "X1" }
        };

        public string GetUserJsonData(string name, string platform)
        {
            var client = new HttpClient();

            if (validPlatforms.TryGetValue(platform, out string _platform)) 
            {
                platform = _platform;
            }

            var webRequest = new HttpRequestMessage(HttpMethod.Get, $"https://api.mozambiquehe.re/bridge?version=5&platform={platform}&player={name}&auth={apexLegendsAPIKey}");

            var response = client.Send(webRequest);

            if (!response.IsSuccessStatusCode) 
            {
                System.Console.WriteLine(response.StatusCode);
                return null; 
            }

            using (var reader = new StreamReader(response.Content.ReadAsStream()))
            {
                return reader.ReadToEnd();
            }
        }

        public DiscordEmbedBuilder GetEmbedFromJson(string json, CommandContext context)
        {
            ApexLegendsRoot jsonOjbectRoot = JsonConvert.DeserializeObject<ApexLegendsRoot>(json);

            DiscordEmbedBuilder embed = new()
            {
                Color = DiscordColor.Red,
                Title = $"Apex Legends Stats: {jsonOjbectRoot.Global.Name}",
                ImageUrl = $"{jsonOjbectRoot.Legends.Selected.ImgAssets.Icon}"
            };

            embed.Thumbnail = new DiscordEmbedBuilder.EmbedThumbnail
            {
                Url = $"{jsonOjbectRoot.Global.Rank.RankImg}"
            };

            embed.AddField("Rank", $"`{jsonOjbectRoot.Global.Rank.RankName} {jsonOjbectRoot.Global.Rank.RankDiv}`");
            embed.AddField("Level", $"`{jsonOjbectRoot.Global.Level}/500`");
            embed.AddField("To Next Level Percent", $"`{jsonOjbectRoot.Global.ToNextLevelPercent}`");
            embed.AddField("Current Legend", $"`{jsonOjbectRoot.Legends.Selected.LegendName}`");

            embed.AddField("Kills", $"`{jsonOjbectRoot.Total.Kills.Value}`");

            return embed;
        }

    }
}
