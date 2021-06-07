using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsBot.JsonObjects
{
    public class Bans
    {
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("remainingSeconds")]
        public int RemainingSeconds { get; set; }

        [JsonProperty("last_banReason")]
        public string LastBanReason { get; set; }
    }

    public class Rank
    {
        [JsonProperty("rankScore")]
        public int RankScore { get; set; }

        [JsonProperty("rankName")]
        public string RankName { get; set; }

        [JsonProperty("rankDiv")]
        public int RankDiv { get; set; }

        [JsonProperty("ladderPosPlatform")]
        public int LadderPosPlatform { get; set; }

        [JsonProperty("rankImg")]
        public string RankImg { get; set; }

        [JsonProperty("rankedSeason")]
        public string RankedSeason { get; set; }

        [JsonProperty("rankPos")]
        public string RankPos { get; set; }

        [JsonProperty("topPercent")]
        public string TopPercent { get; set; }
    }

    public class History
    {
        [JsonProperty("season1")]
        public int Season1 { get; set; }

        [JsonProperty("season2")]
        public int Season2 { get; set; }

        [JsonProperty("season3")]
        public int Season3 { get; set; }

        [JsonProperty("season4")]
        public int Season4 { get; set; }

        [JsonProperty("season5")]
        public int Season5 { get; set; }

        [JsonProperty("season6")]
        public int Season6 { get; set; }

        [JsonProperty("season7")]
        public int Season7 { get; set; }

        [JsonProperty("season8")]
        public int Season8 { get; set; }

        [JsonProperty("season9")]
        public int Season9 { get; set; }
    }

    public class Battlepass
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("history")]
        public History History { get; set; }
    }

    public class Badge
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class Global
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("toNextLevelPercent")]
        public int ToNextLevelPercent { get; set; }

        [JsonProperty("internalUpdateCount")]
        public int InternalUpdateCount { get; set; }

        [JsonProperty("bans")]
        public Bans Bans { get; set; }

        [JsonProperty("rank")]
        public Rank Rank { get; set; }

        [JsonProperty("battlepass")]
        public Battlepass Battlepass { get; set; }

        [JsonProperty("badges")]
        public List<Badge> Badges { get; set; }
    }

    public class Realtime
    {
        [JsonProperty("lobbyState")]
        public string LobbyState { get; set; }

        [JsonProperty("isOnline")]
        public int IsOnline { get; set; }

        [JsonProperty("isInGame")]
        public int IsInGame { get; set; }

        [JsonProperty("canJoin")]
        public int CanJoin { get; set; }

        [JsonProperty("partyFull")]
        public int PartyFull { get; set; }

        [JsonProperty("selectedLegend")]
        public string SelectedLegend { get; set; }
    }

    public class Datum
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("rank")]
        public Rank Rank { get; set; }
    }

    public class GameInfo
    {
        [JsonProperty("skin")]
        public string Skin { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("pose")]
        public string Pose { get; set; }

        [JsonProperty("intro")]
        public string Intro { get; set; }

        [JsonProperty("badges")]
        public List<Badge> Badges { get; set; }
    }

    public class ImgAssets
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }
    }

    public class Selected
    {
        [JsonProperty("LegendName")]
        public string LegendName { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("gameInfo")]
        public GameInfo GameInfo { get; set; }

        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Bangalore
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Bloodhound
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Lifeline
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Caustic
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Gibraltar
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Mirage
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Pathfinder
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Wraith
    {
        [JsonProperty("gameInfo")]
        public GameInfo GameInfo { get; set; }

        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Octane
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Wattson
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Crypto
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Revenant
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Loba
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Rampart
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Horizon
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class Fuse
    {
        [JsonProperty("ImgAssets")]
        public ImgAssets ImgAssets { get; set; }
    }

    public class All
    {
        [JsonProperty("Bangalore")]
        public Bangalore Bangalore { get; set; }

        [JsonProperty("Bloodhound")]
        public Bloodhound Bloodhound { get; set; }

        [JsonProperty("Lifeline")]
        public Lifeline Lifeline { get; set; }

        [JsonProperty("Caustic")]
        public Caustic Caustic { get; set; }

        [JsonProperty("Gibraltar")]
        public Gibraltar Gibraltar { get; set; }

        [JsonProperty("Mirage")]
        public Mirage Mirage { get; set; }

        [JsonProperty("Pathfinder")]
        public Pathfinder Pathfinder { get; set; }

        [JsonProperty("Wraith")]
        public Wraith Wraith { get; set; }

        [JsonProperty("Octane")]
        public Octane Octane { get; set; }

        [JsonProperty("Wattson")]
        public Wattson Wattson { get; set; }

        [JsonProperty("Crypto")]
        public Crypto Crypto { get; set; }

        [JsonProperty("Revenant")]
        public Revenant Revenant { get; set; }

        [JsonProperty("Loba")]
        public Loba Loba { get; set; }

        [JsonProperty("Rampart")]
        public Rampart Rampart { get; set; }

        [JsonProperty("Horizon")]
        public Horizon Horizon { get; set; }

        [JsonProperty("Fuse")]
        public Fuse Fuse { get; set; }
    }

    public class Legends
    {
        [JsonProperty("selected")]
        public Selected Selected { get; set; }

        [JsonProperty("all")]
        public All All { get; set; }
    }

    public class RateLimit
    {
        [JsonProperty("max_per_second")]
        public int MaxPerSecond { get; set; }

        [JsonProperty("current_req")]
        public string CurrentReq { get; set; }
    }

    public class MozambiquehereInternal
    {
        [JsonProperty("isNewToDB")]
        public bool IsNewToDB { get; set; }

        [JsonProperty("claimedBy")]
        public string ClaimedBy { get; set; }

        [JsonProperty("APIAccessType")]
        public string APIAccessType { get; set; }

        [JsonProperty("ClusterID")]
        public string ClusterID { get; set; }

        [JsonProperty("rate_limit")]
        public RateLimit RateLimit { get; set; }

        [JsonProperty("clusterSrv")]
        public string ClusterSrv { get; set; }
    }

    public class Kills
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class DistanceOnStim
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class KillsSeason7
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ShieldDamage
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class WinsSeason5
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class Kd
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Total
    {
        [JsonProperty("kills")]
        public Kills Kills { get; set; }

        [JsonProperty("distance_on_stim")]
        public DistanceOnStim DistanceOnStim { get; set; }

        [JsonProperty("kills_season_7")]
        public KillsSeason7 KillsSeason7 { get; set; }

        [JsonProperty("shield_damage")]
        public ShieldDamage ShieldDamage { get; set; }

        [JsonProperty("wins_season_5")]
        public WinsSeason5 WinsSeason5 { get; set; }

        [JsonProperty("kd")]
        public Kd Kd { get; set; }
    }

    public class ApexLegendsRoot
    {
        [JsonProperty("global")]
        public Global Global { get; set; }

        [JsonProperty("realtime")]
        public Realtime Realtime { get; set; }

        [JsonProperty("legends")]
        public Legends Legends { get; set; }

        [JsonProperty("mozambiquehere_internal")]
        public MozambiquehereInternal MozambiquehereInternal { get; set; }

        [JsonProperty("total")]
        public Total Total { get; set; }
    }


}
