using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DSharpPlus;
using DSharpPlus.EventArgs;
using DSharpPlus.CommandsNext;
using System.IO;
using System.Text;

using StatsBot.Commands;

namespace StatsBot
{
    public class Bot
    {
        public DiscordClient Client { get; private set; }
        public CommandsNextExtension Commands { get; private set; }
        public async Task RunAsync() 
        {
            #region config
            string json = string.Empty;

            using (var fs = File.OpenRead("config.json"))
            {
                using (StreamReader sr = new StreamReader(fs, new UTF8Encoding(false)))
                {
                    json = await sr.ReadToEndAsync().ConfigureAwait(false);
                }
            }

            ConfigJson configJson = JsonConvert.DeserializeObject<ConfigJson>(json);

            DiscordConfiguration config = new DiscordConfiguration()
            {
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Information
            };

            Client = new DiscordClient(config);

            #endregion

            Client.Ready += OnClientReady;

            #region commands

            CommandsNextConfiguration commandsConfig = new CommandsNextConfiguration()
            {
                StringPrefixes = new string[] { configJson.Prefix },
                EnableDms = false,
                DmHelp = false,
                EnableDefaultHelp = false
            };

            Commands = Client.UseCommandsNext(commandsConfig);

            Commands.RegisterCommands<HelpCommand>();
            Commands.RegisterCommands<StatsCommand>();
            Commands.RegisterCommands<GamesCommand>();
            Commands.RegisterCommands<PlatformsCommand>();

            #endregion

            await Client.ConnectAsync();
            await Task.Delay(-1);
        }

        private Task OnClientReady(object sender, ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}
