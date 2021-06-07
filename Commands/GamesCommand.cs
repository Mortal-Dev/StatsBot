using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot.Commands
{
    class GamesCommand : BaseCommandModule
    {
        [Command("games")]
        public async Task Games(CommandContext context)
        {
            var embed = new DiscordEmbedBuilder
            {
                Title = $"games",
                Color = DiscordColor.DarkBlue,
            };

            embed.Thumbnail = new DiscordEmbedBuilder.EmbedThumbnail
            {
                Url = "https://www.zembula.com/wp-content/uploads/2017/09/Blog_Header_New-Colors_Analytics.jpg",
            };

            embed.AddField("Supported Games", "`apex` `fortnite`");
            embed.AddField("Coming Soon", "`hypixel`, `rainbowsix`");

            await context.Channel.SendMessageAsync(embed).ConfigureAwait(false);
        }
    }
}
