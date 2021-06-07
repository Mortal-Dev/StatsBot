using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

using Newtonsoft.Json;

using StatsBot.JsonObjects;

namespace StatsBot.API
{
    class FortniteAPI : IAPIRequest
    {
        private const string apexLegendsAPIKey = "";

        public readonly Dictionary<string, string> validPlatforms = new Dictionary<string, string>()
        {
            {"PS4", "pns" },
            {"PC", string.Empty },
            {"XBOX", "xbl" }
        };

        public string GetUserJsonData(string name, string platform)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", $"{apexLegendsAPIKey}");

            if (validPlatforms.TryGetValue(platform, out string _platform))
            {
                platform = _platform;
            }

            var webRequest = new HttpRequestMessage(HttpMethod.Get, $"https://fortniteapi.io/v1/lookup?username={name}");

            var response = client.Send(webRequest);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            NameLookupRoot nameLookup = JsonConvert.DeserializeObject<NameLookupRoot>(new StreamReader(response.Content.ReadAsStream()).ReadToEnd());

            webRequest = new HttpRequestMessage(HttpMethod.Get, $"https://fortniteapi.io/v1/stats?account={nameLookup.AccountId}");

            response = client.Send(webRequest);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            using (var reader = new StreamReader(response.Content.ReadAsStream())) return reader.ReadToEnd();
        }
        public DiscordEmbedBuilder GetEmbedFromJson(string json, CommandContext context)
        {
            FortniteRoot jsonObjectRoot = JsonConvert.DeserializeObject<FortniteRoot>(json);

            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Black,
                Title = $"Fortnite Stats: {jsonObjectRoot.Name}",
                ImageUrl = "https://pngimg.com/uploads/fortnite/fortnite_PNG158.png"
            };

            embed.Thumbnail = new DiscordEmbedBuilder.EmbedThumbnail
            {
                Url = $"https://blog.logomyway.com/wp-content/uploads/2021/01/fortnite-logo-1024x324.jpg"
            };

            embed.AddField("Solo", "\u200b");
            embed.AddField("Kills", $"`{jsonObjectRoot.GlobalStats.Solo.Kills}`", true);
            embed.AddField("Current Score", $"`{jsonObjectRoot.GlobalStats.Solo.Score}`", true);
            embed.AddField("KD", $"`{jsonObjectRoot.GlobalStats.Solo.Kd}`", true);
            embed.AddField("Winrate", $"`{jsonObjectRoot.GlobalStats.Solo.Winrate}`", true);

            embed.AddField("Duos", "\u200b");
            embed.AddField("Kills", $"`{jsonObjectRoot.GlobalStats.Duo.Kills}`", true);
            embed.AddField("Current Score", $"`{jsonObjectRoot.GlobalStats.Duo.Score}`", true);
            embed.AddField("KD", $"`{jsonObjectRoot.GlobalStats.Duo.Kd}`", true);
            embed.AddField("Winrate", $"`{jsonObjectRoot.GlobalStats.Duo.Winrate}`", true);

            embed.AddField("Squads", "\u200b");
            embed.AddField("Kills", $"`{jsonObjectRoot.GlobalStats.Squad.Kills}`", true);
            embed.AddField("Current Score", $"`{jsonObjectRoot.GlobalStats.Squad.Score}`", true);
            embed.AddField("KD", $"`{jsonObjectRoot.GlobalStats.Squad.Kd}`", true);
            embed.AddField("Winrate", $"`{jsonObjectRoot.GlobalStats.Squad.Winrate}`", true);

            return embed;
        }

    }
}
