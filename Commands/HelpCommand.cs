using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System.Threading.Tasks;

namespace StatsBot.Commands
{
    public class HelpCommand : BaseCommandModule
    {
        [Command("help")]
        public async Task Help(CommandContext context)
        {
            var embed = new DiscordEmbedBuilder
            {
                Title = $"help",
                Color = DiscordColor.DarkBlue,
            };

            embed.Thumbnail = new DiscordEmbedBuilder.EmbedThumbnail
            {
                Url = "https://www.zembula.com/wp-content/uploads/2017/09/Blog_Header_New-Colors_Analytics.jpg",
            };

            embed.AddField("stats", "`!sb stats <game> <username> <platform>`", false);
            embed.AddField("games", "`!sb games`", false);
            embed.AddField("platforms", "`!sb platforms`", false);
            embed.AddField("help", "`!sb help`", false);

            await context.Channel.SendMessageAsync(embed).ConfigureAwait(false);
        }
    }
}
