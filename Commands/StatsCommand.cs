using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

using StatsBot.API;
using System.Collections.Generic;
using DSharpPlus.Entities;

namespace StatsBot.Commands
{
    class StatsCommand : BaseCommandModule
    {
        private static readonly Dictionary<string, IAPIRequest> gameAPIs = new Dictionary<string, IAPIRequest>()
        {
            {"apex", new ApexLegendsAPI() },
            {"hypixel", new HypixelAPI() },
            {"fortnite", new FortniteAPI() },
            {"rainbowsix", new RainbowSixSiegeAPI() }
        };

        [Command("stats")]
        public async Task Stats(CommandContext context, string game, string name, string platform = "PC")
        {
            if (!PlatformsCommand.validPlatforms.Contains(platform))
            {
                await context.Channel.SendMessageAsync("Invalid platform entered, use `!sb platforms` to see all valid platforms");
                return;
            }
            
            if (gameAPIs.TryGetValue(game, out IAPIRequest request))
            {
                string json = request.GetUserJsonData(name, platform);

                if (json == null)
                {
                    await context.Channel.SendMessageAsync($"API error").ConfigureAwait(false);
                    return;
                }

                DiscordEmbedBuilder embed = request.GetEmbedFromJson(json, context);

                await context.Channel.SendMessageAsync(embed).ConfigureAwait(false);
            }
            else
            {
                await context.Channel.SendMessageAsync("Invalid game, use `!sb games` to see all valid games");
            }
        }
    }
}
