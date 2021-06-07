using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;

using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using System.Net.Http;
using System.IO;
using StatsBot.JsonObjects;
using System.Diagnostics;

namespace StatsBot.API
{
    class HypixelAPI : IAPIRequest
    {
        private const string hypixelAPIKey = "";

        public string GetUserJsonData(string name, string platform)
        {
            var client = new HttpClient();

            var webRequest = new HttpRequestMessage(HttpMethod.Get, $"https://api.hypixel.net/player?key={hypixelAPIKey}&name={name}");

            var response = client.Send(webRequest);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            
            using (var reader = new StreamReader(response.Content.ReadAsStream()))
            {
                return reader.ReadToEnd();
            }
        }

        public DiscordEmbedBuilder GetEmbedFromJson(string json, CommandContext context)
        {
             HypixelRoot jsonOjbectRoot = JsonConvert.DeserializeObject<HypixelRoot>(json);

             DiscordEmbedBuilder embed = new DiscordEmbedBuilder
             {
                 Color = DiscordColor.Yellow,
                 Title = $"Hypixel Stats: {jsonOjbectRoot.Player.Playername}",
                 ImageUrl = $"https://hypixel.net/attachments/hypixel-png.2343521/"
             };

            embed.Thumbnail = new DiscordEmbedBuilder.EmbedThumbnail
            {
                Url = "https://www.zembula.com/wp-content/uploads/2017/09/Blog_Header_New-Colors_Analytics.jpg",
            };

            embed.AddField("Duels", "\u200b");

            embed.AddField("Duels Wins", $"`{jsonOjbectRoot.Player.Stats.Duels.Wins}`", true);
            embed.AddField("Duels Kills", $"`{jsonOjbectRoot.Player.Stats.Duels.Kills}`", true);
            embed.AddField("Duels Losses", $"`{jsonOjbectRoot.Player.Stats.Duels.Losses}`", true);

            embed.AddField("\u200b", "\u200b");

            embed.AddField("Skywars", "\u200b");

            embed.AddField("Skywars Wins", $"`{jsonOjbectRoot.Player.Stats.SkyWars.Wins}`", true);
            embed.AddField("Skywars Kills", $"`{jsonOjbectRoot.Player.Stats.SkyWars.Kills}`", true);
            embed.AddField("Skywars Losses", $"`{jsonOjbectRoot.Player.Stats.SkyWars.Losses}`", true);

            embed.AddField("\u200b", "\u200b");

            embed.AddField("Bedwars", "\u200b");

            embed.AddField("Bedwars Wins", $"`{jsonOjbectRoot.Player.Stats.Bedwars.WinsBedwars}`", true);
            embed.AddField("Bedwars Kills", $"`{jsonOjbectRoot.Player.Stats.Bedwars.KillsBedwars}`", true);
            embed.AddField("Bedwars Losses", $"`{jsonOjbectRoot.Player.Stats.Bedwars.LossesBedwars}`", true);

            return embed;
        }
    }
}
