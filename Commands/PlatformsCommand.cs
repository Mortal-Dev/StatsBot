using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StatsBot.Commands
{
    class PlatformsCommand : BaseCommandModule
    {
        public static readonly List<string> validPlatforms = new List<string>()
        {
            "PS4",
            "XBOX",
            "PC"
        };

        [Command("platforms")]
        public async Task Platforms(CommandContext context)
        {
            var embed = new DiscordEmbedBuilder
            {
                Title = $"platforms",
                Color = DiscordColor.DarkBlue,
            };

            embed.Thumbnail = new DiscordEmbedBuilder.EmbedThumbnail
            {
                Url = "https://www.zembula.com/wp-content/uploads/2017/09/Blog_Header_New-Colors_Analytics.jpg",
            };

            embed.AddField("supported platforms", "`PC` `PS4` `XBOX`");

            await context.Channel.SendMessageAsync(embed).ConfigureAwait(false);
        }
    }
}
