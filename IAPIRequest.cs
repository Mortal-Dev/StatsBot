using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot
{
    public interface IAPIRequest
    { 
        abstract string GetUserJsonData(string name, string platform);

        abstract DiscordEmbedBuilder GetEmbedFromJson(string json, CommandContext context);
    }
}
