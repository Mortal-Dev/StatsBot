using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot.JsonObjects
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class NameLookupRoot
    {
        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }

    public class Account
    {
        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("progress_pct")]
        public int ProgressPct { get; set; }
    }

    public class Duo
    {
        [JsonProperty("placetop1")]
        public int Placetop1 { get; set; }

        [JsonProperty("kd")]
        public double Kd { get; set; }

        [JsonProperty("winrate")]
        public double Winrate { get; set; }

        [JsonProperty("placetop3")]
        public int Placetop3 { get; set; }

        [JsonProperty("placetop5")]
        public int Placetop5 { get; set; }

        [JsonProperty("placetop6")]
        public int Placetop6 { get; set; }

        [JsonProperty("placetop10")]
        public int Placetop10 { get; set; }

        [JsonProperty("placetop12")]
        public int Placetop12 { get; set; }

        [JsonProperty("placetop25")]
        public int Placetop25 { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("matchesplayed")]
        public int Matchesplayed { get; set; }

        [JsonProperty("minutesplayed")]
        public int Minutesplayed { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("playersoutlived")]
        public int Playersoutlived { get; set; }
    }

    public class Solo
    {
        [JsonProperty("placetop1")]
        public int Placetop1 { get; set; }

        [JsonProperty("kd")]
        public double Kd { get; set; }

        [JsonProperty("winrate")]
        public double Winrate { get; set; }

        [JsonProperty("placetop3")]
        public int Placetop3 { get; set; }

        [JsonProperty("placetop5")]
        public int Placetop5 { get; set; }

        [JsonProperty("placetop6")]
        public int Placetop6 { get; set; }

        [JsonProperty("placetop10")]
        public int Placetop10 { get; set; }

        [JsonProperty("placetop12")]
        public int Placetop12 { get; set; }

        [JsonProperty("placetop25")]
        public int Placetop25 { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("matchesplayed")]
        public int Matchesplayed { get; set; }

        [JsonProperty("minutesplayed")]
        public int Minutesplayed { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("playersoutlived")]
        public int Playersoutlived { get; set; }
    }

    public class Squad
    {
        [JsonProperty("placetop1")]
        public int Placetop1 { get; set; }

        [JsonProperty("kd")]
        public double Kd { get; set; }

        [JsonProperty("winrate")]
        public double Winrate { get; set; }

        [JsonProperty("placetop3")]
        public int Placetop3 { get; set; }

        [JsonProperty("placetop5")]
        public int Placetop5 { get; set; }

        [JsonProperty("placetop6")]
        public int Placetop6 { get; set; }

        [JsonProperty("placetop10")]
        public int Placetop10 { get; set; }

        [JsonProperty("placetop12")]
        public int Placetop12 { get; set; }

        [JsonProperty("placetop25")]
        public int Placetop25 { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("matchesplayed")]
        public int Matchesplayed { get; set; }

        [JsonProperty("minutesplayed")]
        public int Minutesplayed { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("playersoutlived")]
        public int Playersoutlived { get; set; }
    }

    public class GlobalStats
    {
        [JsonProperty("duo")]
        public Duo Duo { get; set; }

        [JsonProperty("solo")]
        public Solo Solo { get; set; }

        [JsonProperty("squad")]
        public Squad Squad { get; set; }
    }

    public class Keyboardmouse
    {
        [JsonProperty("duo")]
        public Duo Duo { get; set; }

        [JsonProperty("solo")]
        public Solo Solo { get; set; }

        [JsonProperty("squad")]
        public Squad Squad { get; set; }
    }

    public class Gamepad
    {
        [JsonProperty("duo")]
        public Duo Duo { get; set; }

        [JsonProperty("squad")]
        public Squad Squad { get; set; }

        [JsonProperty("solo")]
        public Solo Solo { get; set; }
    }

    public class Touch
    {
        [JsonProperty("solo")]
        public Solo Solo { get; set; }
    }

    public class PerInput
    {
        [JsonProperty("keyboardmouse")]
        public Keyboardmouse Keyboardmouse { get; set; }

        [JsonProperty("gamepad")]
        public Gamepad Gamepad { get; set; }

        [JsonProperty("touch")]
        public Touch Touch { get; set; }
    }

    public class FortniteRoot
    {
        [JsonProperty("result")]
        public bool Result { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("global_stats")]
        public GlobalStats GlobalStats { get; set; }

        [JsonProperty("per_input")]
        public PerInput PerInput { get; set; }

        [JsonProperty("seasons_available")]
        public List<int> SeasonsAvailable { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }
    }


}
