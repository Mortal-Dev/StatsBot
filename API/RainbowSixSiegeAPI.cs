using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace StatsBot.API
{
    class RainbowSixSiegeAPI : IAPIRequest
    {
        private readonly string rainbowSixApiKey = "";

        private readonly Dictionary<string, string> validPlatforms = new Dictionary<string, string>()
        {
            {"PC", "pc"},
            {"XBOX", "xbox"},
            {"PS4", "ps" }
        };
        public string GetUserJsonData(string name, string platform)
        {
            if (validPlatforms.TryGetValue(platform, out string _platform))
            {
                platform = _platform;
            }

            var client = new HttpClient();

            var webRequest = new HttpRequestMessage(HttpMethod.Get, $"https://api2.r6stats.com/public-api/stats/{name}/{platform}/generic");

            client.DefaultRequestHeaders.Add("Authorization", rainbowSixApiKey);

            var response = client.Send(webRequest);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode);
                return null;
            }

            using (var reader = new StreamReader(response.Content.ReadAsStream()))
            {
                Console.WriteLine(reader.ReadToEnd());
                return reader.ReadToEnd();
            }
        }

        public DiscordEmbedBuilder GetEmbedFromJson(string json, CommandContext context)
        {
            throw new NotImplementedException();
        }      
    }
}
