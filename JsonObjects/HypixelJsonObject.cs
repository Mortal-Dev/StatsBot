using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace StatsBot.JsonObjects
{
 
    public partial class HypixelRoot
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }
    }

    public partial class Player
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("displayname")]
        public string Displayname { get; set; }

        [JsonProperty("firstLogin")]
        public long FirstLogin { get; set; }

        [JsonProperty("knownAliases")]
        public string[] KnownAliases { get; set; }

        [JsonProperty("knownAliasesLower")]
        public string[] KnownAliasesLower { get; set; }

        [JsonProperty("lastLogin")]
        public long LastLogin { get; set; }

        [JsonProperty("playername")]
        public string Playername { get; set; }

        [JsonProperty("achievementsOneTime")]
        public string[] AchievementsOneTime { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("achievementPoints")]
        public long AchievementPoints { get; set; }

        [JsonProperty("achievements")]
        public Dictionary<string, long> Achievements { get; set; }

        [JsonProperty("lastLogout")]
        public long LastLogout { get; set; }

        [JsonProperty("achievementTracking")]
        public object[] AchievementTracking { get; set; }

        [JsonProperty("networkExp")]
        public long NetworkExp { get; set; }

        [JsonProperty("mcVersionRp")]
        public string McVersionRp { get; set; }

        [JsonProperty("challenges")]
        public Challenges Challenges { get; set; }

        [JsonProperty("karma")]
        public long Karma { get; set; }

        [JsonProperty("friendRequestsUuid")]
        public object[] FriendRequestsUuid { get; set; }

        [JsonProperty("achievementSync")]
        public AchievementSync AchievementSync { get; set; }

        [JsonProperty("parkourCheckpointBests")]
        public ParkourCheckpointBests ParkourCheckpointBests { get; set; }

        [JsonProperty("petConsumables")]
        public Dictionary<string, long> PetConsumables { get; set; }

        [JsonProperty("vanityMeta")]
        public VanityMeta VanityMeta { get; set; }

        [JsonProperty("levelingReward_0")]
        public bool LevelingReward0 { get; set; }

        [JsonProperty("levelingReward_16")]
        public bool LevelingReward16 { get; set; }

        [JsonProperty("parkourCompletions")]
        public ParkourCompletions ParkourCompletions { get; set; }

        [JsonProperty("levelingReward_1")]
        public bool LevelingReward1 { get; set; }

        [JsonProperty("housingMeta")]
        public HousingMeta HousingMeta { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("mostRecentGameType")]
        public string MostRecentGameType { get; set; }
    }

    public partial class AchievementSync
    {
        [JsonProperty("quake_tiered")]
        public long QuakeTiered { get; set; }
    }

    public partial class Challenges
    {
        [JsonProperty("all_time")]
        public Dictionary<string, long> AllTime { get; set; }

        [JsonProperty("day_l")]
        public DayL DayL { get; set; }
    }

    public partial class DayL
    {
        [JsonProperty("DUELS__teams_challenge")]
        public long DuelsTeamsChallenge { get; set; }
    }

    public partial class HousingMeta
    {
        [JsonProperty("playerSettings")]
        public PlayerSettings PlayerSettings { get; set; }

        [JsonProperty("given_cookies_105081")]
        public Guid[] GivenCookies105081 { get; set; }

        [JsonProperty("given_cookies_105098")]
        public Guid[] GivenCookies105098 { get; set; }
    }

    public partial class PlayerSettings
    {
        [JsonProperty("VISIBILITY")]
        public string Visibility { get; set; }
    }

    public partial class ParkourCheckpointBests
    {
        [JsonProperty("Duels")]
        public Dictionary<string, long> Duels { get; set; }

        [JsonProperty("Bedwars")]
        public Dictionary<string, long> Bedwars { get; set; }

        [JsonProperty("BuildBattle")]
        public Dictionary<string, long> BuildBattle { get; set; }
    }

    public partial class ParkourCompletions
    {
        [JsonProperty("Duels")]
        public Duel[] Duels { get; set; }
    }

    public partial class Duel
    {
        [JsonProperty("timeStart")]
        public long TimeStart { get; set; }

        [JsonProperty("timeTook")]
        public long TimeTook { get; set; }
    }

    public partial class Stats
    {
        [JsonProperty("Bedwars")]
        public Bedwars Bedwars { get; set; }

        [JsonProperty("MurderMystery")]
        public MurderMystery MurderMystery { get; set; }

        [JsonProperty("MCGO")]
        public Mcgo Mcgo { get; set; }

        [JsonProperty("HungerGames")]
        public HungerGames HungerGames { get; set; }

        [JsonProperty("Battleground")]
        public Battleground Battleground { get; set; }

        [JsonProperty("Arcade")]
        public Arcade Arcade { get; set; }

        [JsonProperty("Duels")]
        public Duels Duels { get; set; }

        [JsonProperty("Walls3")]
        public Walls3 Walls3 { get; set; }

        [JsonProperty("Pit")]
        public Pit Pit { get; set; }

        [JsonProperty("SuperSmash")]
        public SuperSmash SuperSmash { get; set; }

        [JsonProperty("GingerBread")]
        public GingerBread GingerBread { get; set; }

        [JsonProperty("VampireZ")]
        public VampireZ VampireZ { get; set; }

        [JsonProperty("Quake")]
        public Quake Quake { get; set; }

        [JsonProperty("Paintball")]
        public Paintball Paintball { get; set; }

        [JsonProperty("Legacy")]
        public Legacy Legacy { get; set; }

        [JsonProperty("SpeedUHC")]
        public SpeedUhc SpeedUhc { get; set; }

        [JsonProperty("UHC")]
        public Uhc Uhc { get; set; }

        [JsonProperty("BuildBattle")]
        public BuildBattle BuildBattle { get; set; }

        [JsonProperty("TNTGames")]
        public TntGames TntGames { get; set; }

        [JsonProperty("SkyBlock")]
        public SkyBlock SkyBlock { get; set; }

        [JsonProperty("SkyWars")]
        public SkyWars SkyWars { get; set; }
    }

    public partial class Arcade
    {
        [JsonProperty("basic_zombie_kills_zombies")]
        public long BasicZombieKillsZombies { get; set; }

        [JsonProperty("best_round_zombies")]
        public long BestRoundZombies { get; set; }

        [JsonProperty("best_round_zombies_deadend")]
        public long BestRoundZombiesDeadend { get; set; }

        [JsonProperty("best_round_zombies_deadend_normal")]
        public long BestRoundZombiesDeadendNormal { get; set; }

        [JsonProperty("bullets_hit_zombies")]
        public long BulletsHitZombies { get; set; }

        [JsonProperty("bullets_shot_zombies")]
        public long BulletsShotZombies { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths_zombies")]
        public long DeathsZombies { get; set; }

        [JsonProperty("deaths_zombies_deadend")]
        public long DeathsZombiesDeadend { get; set; }

        [JsonProperty("deaths_zombies_deadend_normal")]
        public long DeathsZombiesDeadendNormal { get; set; }

        [JsonProperty("headshots_zombies")]
        public long HeadshotsZombies { get; set; }

        [JsonProperty("total_rounds_survived_zombies")]
        public long TotalRoundsSurvivedZombies { get; set; }

        [JsonProperty("total_rounds_survived_zombies_deadend")]
        public long TotalRoundsSurvivedZombiesDeadend { get; set; }

        [JsonProperty("total_rounds_survived_zombies_deadend_normal")]
        public long TotalRoundsSurvivedZombiesDeadendNormal { get; set; }

        [JsonProperty("windows_repaired_zombies")]
        public long WindowsRepairedZombies { get; set; }

        [JsonProperty("windows_repaired_zombies_deadend")]
        public long WindowsRepairedZombiesDeadend { get; set; }

        [JsonProperty("windows_repaired_zombies_deadend_normal")]
        public long WindowsRepairedZombiesDeadendNormal { get; set; }

        [JsonProperty("zombie_kills_zombies")]
        public long ZombieKillsZombies { get; set; }

        [JsonProperty("zombie_kills_zombies_deadend")]
        public long ZombieKillsZombiesDeadend { get; set; }

        [JsonProperty("zombie_kills_zombies_deadend_normal")]
        public long ZombieKillsZombiesDeadendNormal { get; set; }

        [JsonProperty("headshots_dayone")]
        public long HeadshotsDayone { get; set; }

        [JsonProperty("kills_dayone")]
        public long KillsDayone { get; set; }

        [JsonProperty("wins_dayone")]
        public long WinsDayone { get; set; }

        [JsonProperty("miniwalls_activeKit")]
        public string MiniwallsActiveKit { get; set; }

        [JsonProperty("arrows_hit_mini_walls")]
        public long ArrowsHitMiniWalls { get; set; }

        [JsonProperty("arrows_shot_mini_walls")]
        public long ArrowsShotMiniWalls { get; set; }

        [JsonProperty("deaths_mini_walls")]
        public long DeathsMiniWalls { get; set; }

        [JsonProperty("kills_mini_walls")]
        public long KillsMiniWalls { get; set; }

        [JsonProperty("wither_damage_mini_walls")]
        public long WitherDamageMiniWalls { get; set; }

        [JsonProperty("final_kills_mini_walls")]
        public long FinalKillsMiniWalls { get; set; }

        [JsonProperty("wins_mini_walls")]
        public long WinsMiniWalls { get; set; }

        [JsonProperty("wither_kills_mini_walls")]
        public long WitherKillsMiniWalls { get; set; }

        [JsonProperty("items_found_scuba_simulator")]
        public long ItemsFoundScubaSimulator { get; set; }

        [JsonProperty("total_points_scuba_simulator")]
        public long TotalPointsScubaSimulator { get; set; }

        [JsonProperty("lastTourneyAd")]
        public long LastTourneyAd { get; set; }

        [JsonProperty("zombies_hideTutorials")]
        public bool ZombiesHideTutorials { get; set; }

        [JsonProperty("doors_opened_zombies")]
        public long DoorsOpenedZombies { get; set; }

        [JsonProperty("doors_opened_zombies_deadend")]
        public long DoorsOpenedZombiesDeadend { get; set; }

        [JsonProperty("doors_opened_zombies_deadend_normal")]
        public long DoorsOpenedZombiesDeadendNormal { get; set; }

        [JsonProperty("empowered_zombie_kills_zombies")]
        public long EmpoweredZombieKillsZombies { get; set; }

        [JsonProperty("fastest_time_10_zombies")]
        public long FastestTime10_Zombies { get; set; }

        [JsonProperty("fastest_time_10_zombies_deadend_normal")]
        public long FastestTime10_ZombiesDeadendNormal { get; set; }

        [JsonProperty("fire_zombie_kills_zombies")]
        public long FireZombieKillsZombies { get; set; }

        [JsonProperty("magma_cube_zombie_kills_zombies")]
        public long MagmaCubeZombieKillsZombies { get; set; }

        [JsonProperty("magma_zombie_kills_zombies")]
        public long MagmaZombieKillsZombies { get; set; }

        [JsonProperty("pig_zombie_zombie_kills_zombies")]
        public long PigZombieZombieKillsZombies { get; set; }

        [JsonProperty("times_knocked_down_zombies")]
        public long TimesKnockedDownZombies { get; set; }

        [JsonProperty("times_knocked_down_zombies_deadend")]
        public long TimesKnockedDownZombiesDeadend { get; set; }

        [JsonProperty("times_knocked_down_zombies_deadend_normal")]
        public long TimesKnockedDownZombiesDeadendNormal { get; set; }

        [JsonProperty("tnt_baby_zombie_kills_zombies")]
        public long TntBabyZombieKillsZombies { get; set; }

        [JsonProperty("tnt_zombie_kills_zombies")]
        public long TntZombieKillsZombies { get; set; }

        [JsonProperty("wolf_zombie_kills_zombies")]
        public long WolfZombieKillsZombies { get; set; }
    }

    public partial class Battleground
    {
        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("warrior_spec")]
        public string WarriorSpec { get; set; }

        [JsonProperty("mage_spec")]
        public string MageSpec { get; set; }

        [JsonProperty("chosen_class")]
        public string ChosenClass { get; set; }

        [JsonProperty("shaman_spec")]
        public string ShamanSpec { get; set; }

        [JsonProperty("selected_mount")]
        public string SelectedMount { get; set; }

        [JsonProperty("paladin_spec")]
        public string PaladinSpec { get; set; }

        [JsonProperty("play_streak")]
        public long PlayStreak { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("damage")]
        public long Damage { get; set; }

        [JsonProperty("damage_mage")]
        public long DamageMage { get; set; }

        [JsonProperty("damage_prevented")]
        public long DamagePrevented { get; set; }

        [JsonProperty("damage_prevented_mage")]
        public long DamagePreventedMage { get; set; }

        [JsonProperty("damage_prevented_pyromancer")]
        public long DamagePreventedPyromancer { get; set; }

        [JsonProperty("damage_pyromancer")]
        public long DamagePyromancer { get; set; }

        [JsonProperty("damage_taken")]
        public long DamageTaken { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("dom_point_captures")]
        public long DomPointCaptures { get; set; }

        [JsonProperty("heal")]
        public long Heal { get; set; }

        [JsonProperty("heal_mage")]
        public long HealMage { get; set; }

        [JsonProperty("heal_pyromancer")]
        public long HealPyromancer { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("losses_mage")]
        public long LossesMage { get; set; }

        [JsonProperty("losses_pyromancer")]
        public long LossesPyromancer { get; set; }

        [JsonProperty("mage_plays")]
        public long MagePlays { get; set; }

        [JsonProperty("pyromancer_plays")]
        public long PyromancerPlays { get; set; }

        [JsonProperty("total_domination_score")]
        public long TotalDominationScore { get; set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_teamdeathmatch")]
        public long KillsTeamdeathmatch { get; set; }

        [JsonProperty("powerups_collected")]
        public long PowerupsCollected { get; set; }
    }

    public partial class Bedwars
    {
        [JsonProperty("Experience")]
        public long Experience { get; set; }

        [JsonProperty("bedwars_easter_boxes")]
        public long BedwarsEasterBoxes { get; set; }

        [JsonProperty("first_join_7")]
        public bool FirstJoin7 { get; set; }

        [JsonProperty("games_played_bedwars_1")]
        public long GamesPlayedBedwars1 { get; set; }

        [JsonProperty("eight_one_winstreak")]
        public long EightOneWinstreak { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths_bedwars")]
        public long DeathsBedwars { get; set; }

        [JsonProperty("eight_one_deaths_bedwars")]
        public long EightOneDeathsBedwars { get; set; }

        [JsonProperty("eight_one_games_played_bedwars")]
        public long EightOneGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_one_losses_bedwars")]
        public long EightOneLossesBedwars { get; set; }

        [JsonProperty("eight_one_magic_deaths_bedwars")]
        public long EightOneMagicDeathsBedwars { get; set; }

        [JsonProperty("games_played_bedwars")]
        public long GamesPlayedBedwars { get; set; }

        [JsonProperty("losses_bedwars")]
        public long LossesBedwars { get; set; }

        [JsonProperty("magic_deaths_bedwars")]
        public long MagicDeathsBedwars { get; set; }

        [JsonProperty("four_four_winstreak")]
        public long FourFourWinstreak { get; set; }

        [JsonProperty("_items_purchased_bedwars")]
        public long ItemsPurchasedBedwars { get; set; }

        [JsonProperty("beds_lost_bedwars")]
        public long BedsLostBedwars { get; set; }

        [JsonProperty("emerald_resources_collected_bedwars")]
        public long EmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("entity_attack_deaths_bedwars")]
        public long EntityAttackDeathsBedwars { get; set; }

        [JsonProperty("entity_attack_final_deaths_bedwars")]
        public long EntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("entity_attack_final_kills_bedwars")]
        public long EntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("entity_attack_kills_bedwars")]
        public long EntityAttackKillsBedwars { get; set; }

        [JsonProperty("fall_kills_bedwars")]
        public long FallKillsBedwars { get; set; }

        [JsonProperty("final_deaths_bedwars")]
        public long FinalDeathsBedwars { get; set; }

        [JsonProperty("final_kills_bedwars")]
        public long FinalKillsBedwars { get; set; }

        [JsonProperty("four_four__items_purchased_bedwars")]
        public long FourFourItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_beds_lost_bedwars")]
        public long FourFourBedsLostBedwars { get; set; }

        [JsonProperty("four_four_deaths_bedwars")]
        public long FourFourDeathsBedwars { get; set; }

        [JsonProperty("four_four_emerald_resources_collected_bedwars")]
        public long FourFourEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_deaths_bedwars")]
        public long FourFourEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_final_deaths_bedwars")]
        public long FourFourEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_final_kills_bedwars")]
        public long FourFourEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_entity_attack_kills_bedwars")]
        public long FourFourEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_fall_kills_bedwars")]
        public long FourFourFallKillsBedwars { get; set; }

        [JsonProperty("four_four_final_deaths_bedwars")]
        public long FourFourFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_final_kills_bedwars")]
        public long FourFourFinalKillsBedwars { get; set; }

        [JsonProperty("four_four_games_played_bedwars")]
        public long FourFourGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_gold_resources_collected_bedwars")]
        public long FourFourGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_iron_resources_collected_bedwars")]
        public long FourFourIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_items_purchased_bedwars")]
        public long BedwarsFourFourItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_kills_bedwars")]
        public long FourFourKillsBedwars { get; set; }

        [JsonProperty("four_four_losses_bedwars")]
        public long FourFourLossesBedwars { get; set; }

        [JsonProperty("four_four_permanent _items_purchased_bedwars")]
        public long FourFourPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_resources_collected_bedwars")]
        public long FourFourResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_void_final_kills_bedwars")]
        public long FourFourVoidFinalKillsBedwars { get; set; }

        [JsonProperty("gold_resources_collected_bedwars")]
        public long GoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("iron_resources_collected_bedwars")]
        public long IronResourcesCollectedBedwars { get; set; }

        [JsonProperty("items_purchased_bedwars")]
        public long BedwarsItemsPurchasedBedwars { get; set; }

        [JsonProperty("kills_bedwars")]
        public long KillsBedwars { get; set; }

        [JsonProperty("permanent _items_purchased_bedwars")]
        public long PermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("resources_collected_bedwars")]
        public long ResourcesCollectedBedwars { get; set; }

        [JsonProperty("void_final_kills_bedwars")]
        public long VoidFinalKillsBedwars { get; set; }

        [JsonProperty("diamond_resources_collected_bedwars")]
        public long DiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_diamond_resources_collected_bedwars")]
        public long FourFourDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_void_deaths_bedwars")]
        public long FourFourVoidDeathsBedwars { get; set; }

        [JsonProperty("void_deaths_bedwars")]
        public long VoidDeathsBedwars { get; set; }

        [JsonProperty("entity_explosion_kills_bedwars")]
        public long EntityExplosionKillsBedwars { get; set; }

        [JsonProperty("four_four_entity_explosion_kills_bedwars")]
        public long FourFourEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("four_four_void_kills_bedwars")]
        public long FourFourVoidKillsBedwars { get; set; }

        [JsonProperty("void_kills_bedwars")]
        public long VoidKillsBedwars { get; set; }

        [JsonProperty("bedwars_boxes")]
        public long BedwarsBoxes { get; set; }

        [JsonProperty("eight_two_winstreak")]
        public long EightTwoWinstreak { get; set; }

        [JsonProperty("eight_two__items_purchased_bedwars")]
        public long EightTwoItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_beds_lost_bedwars")]
        public long EightTwoBedsLostBedwars { get; set; }

        [JsonProperty("eight_two_deaths_bedwars")]
        public long EightTwoDeathsBedwars { get; set; }

        [JsonProperty("eight_two_diamond_resources_collected_bedwars")]
        public long EightTwoDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_emerald_resources_collected_bedwars")]
        public long EightTwoEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_deaths_bedwars")]
        public long EightTwoEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_final_deaths_bedwars")]
        public long EightTwoEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_entity_attack_kills_bedwars")]
        public long EightTwoEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_two_final_deaths_bedwars")]
        public long EightTwoFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_games_played_bedwars")]
        public long EightTwoGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_two_gold_resources_collected_bedwars")]
        public long EightTwoGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_iron_resources_collected_bedwars")]
        public long EightTwoIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_items_purchased_bedwars")]
        public long BedwarsEightTwoItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_kills_bedwars")]
        public long EightTwoKillsBedwars { get; set; }

        [JsonProperty("eight_two_losses_bedwars")]
        public long EightTwoLossesBedwars { get; set; }

        [JsonProperty("eight_two_permanent _items_purchased_bedwars")]
        public long EightTwoPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_resources_collected_bedwars")]
        public long EightTwoResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_void_kills_bedwars")]
        public long EightTwoVoidKillsBedwars { get; set; }

        [JsonProperty("winstreak")]
        public long Winstreak { get; set; }

        [JsonProperty("eight_two_entity_attack_final_kills_bedwars")]
        public long EightTwoEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_final_kills_bedwars")]
        public long EightTwoFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_void_final_kills_bedwars")]
        public long EightTwoVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_wins_bedwars")]
        public long EightTwoWinsBedwars { get; set; }

        [JsonProperty("wins_bedwars")]
        public long WinsBedwars { get; set; }

        [JsonProperty("eight_two_void_final_deaths_bedwars")]
        public long EightTwoVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("void_final_deaths_bedwars")]
        public long VoidFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one__items_purchased_bedwars")]
        public long EightOneItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_beds_lost_bedwars")]
        public long EightOneBedsLostBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_deaths_bedwars")]
        public long EightOneEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_final_deaths_bedwars")]
        public long EightOneEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_final_deaths_bedwars")]
        public long EightOneFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_gold_resources_collected_bedwars")]
        public long EightOneGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_iron_resources_collected_bedwars")]
        public long EightOneIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_items_purchased_bedwars")]
        public long BedwarsEightOneItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_resources_collected_bedwars")]
        public long EightOneResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_diamond_resources_collected_bedwars")]
        public long EightOneDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_kills_bedwars")]
        public long EightOneEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_one_kills_bedwars")]
        public long EightOneKillsBedwars { get; set; }

        [JsonProperty("eight_one_permanent _items_purchased_bedwars")]
        public long EightOnePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_void_deaths_bedwars")]
        public long EightOneVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_one_void_kills_bedwars")]
        public long EightOneVoidKillsBedwars { get; set; }

        [JsonProperty("eight_one_emerald_resources_collected_bedwars")]
        public long EightOneEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_one_entity_attack_final_kills_bedwars")]
        public long EightOneEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_final_kills_bedwars")]
        public long EightOneFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_magic_final_deaths_bedwars")]
        public long EightOneMagicFinalDeathsBedwars { get; set; }

        [JsonProperty("magic_final_deaths_bedwars")]
        public long MagicFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_void_deaths_bedwars")]
        public long EightTwoVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_two_permanent_items_purchased_bedwars")]
        public long BedwarsEightTwoPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("permanent_items_purchased_bedwars")]
        public long BedwarsPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_permanent_items_purchased_bedwars")]
        public long BedwarsEightOnePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_one_void_final_deaths_bedwars")]
        public long EightOneVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("beds_broken_bedwars")]
        public long BedsBrokenBedwars { get; set; }

        [JsonProperty("eight_one_beds_broken_bedwars")]
        public long EightOneBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_one_void_final_kills_bedwars")]
        public long EightOneVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_fall_deaths_bedwars")]
        public long EightOneFallDeathsBedwars { get; set; }

        [JsonProperty("fall_deaths_bedwars")]
        public long FallDeathsBedwars { get; set; }

        [JsonProperty("two_four_winstreak")]
        public long TwoFourWinstreak { get; set; }

        [JsonProperty("two_four__items_purchased_bedwars")]
        public long TwoFourItemsPurchasedBedwars { get; set; }

        [JsonProperty("two_four_beds_lost_bedwars")]
        public long TwoFourBedsLostBedwars { get; set; }

        [JsonProperty("two_four_deaths_bedwars")]
        public long TwoFourDeathsBedwars { get; set; }

        [JsonProperty("two_four_emerald_resources_collected_bedwars")]
        public long TwoFourEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("two_four_entity_attack_deaths_bedwars")]
        public long TwoFourEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("two_four_final_deaths_bedwars")]
        public long TwoFourFinalDeathsBedwars { get; set; }

        [JsonProperty("two_four_games_played_bedwars")]
        public long TwoFourGamesPlayedBedwars { get; set; }

        [JsonProperty("two_four_gold_resources_collected_bedwars")]
        public long TwoFourGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("two_four_iron_resources_collected_bedwars")]
        public long TwoFourIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("two_four_items_purchased_bedwars")]
        public long BedwarsTwoFourItemsPurchasedBedwars { get; set; }

        [JsonProperty("two_four_losses_bedwars")]
        public long TwoFourLossesBedwars { get; set; }

        [JsonProperty("two_four_permanent_items_purchased_bedwars")]
        public long TwoFourPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("two_four_resources_collected_bedwars")]
        public long TwoFourResourcesCollectedBedwars { get; set; }

        [JsonProperty("two_four_void_deaths_bedwars")]
        public long TwoFourVoidDeathsBedwars { get; set; }

        [JsonProperty("two_four_void_final_deaths_bedwars")]
        public long TwoFourVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("two_four_beds_broken_bedwars")]
        public long TwoFourBedsBrokenBedwars { get; set; }

        [JsonProperty("two_four_entity_attack_final_kills_bedwars")]
        public long TwoFourEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("two_four_final_kills_bedwars")]
        public long TwoFourFinalKillsBedwars { get; set; }

        [JsonProperty("two_four_wins_bedwars")]
        public long TwoFourWinsBedwars { get; set; }

        [JsonProperty("two_four_fall_kills_bedwars")]
        public long TwoFourFallKillsBedwars { get; set; }

        [JsonProperty("two_four_kills_bedwars")]
        public long TwoFourKillsBedwars { get; set; }

        [JsonProperty("two_four_entity_attack_kills_bedwars")]
        public long TwoFourEntityAttackKillsBedwars { get; set; }

        [JsonProperty("two_four_magic_final_deaths_bedwars")]
        public long TwoFourMagicFinalDeathsBedwars { get; set; }

        [JsonProperty("two_four_void_kills_bedwars")]
        public long TwoFourVoidKillsBedwars { get; set; }

        [JsonProperty("selected_ultimate")]
        public string SelectedUltimate { get; set; }

        [JsonProperty("eight_two_ultimate_winstreak")]
        public long EightTwoUltimateWinstreak { get; set; }

        [JsonProperty("eight_two_ultimate__items_purchased_bedwars")]
        public long EightTwoUltimateItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_beds_lost_bedwars")]
        public long EightTwoUltimateBedsLostBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_final_deaths_bedwars")]
        public long EightTwoUltimateFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_games_played_bedwars")]
        public long EightTwoUltimateGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_gold_resources_collected_bedwars")]
        public long EightTwoUltimateGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_iron_resources_collected_bedwars")]
        public long EightTwoUltimateIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_items_purchased_bedwars")]
        public long BedwarsEightTwoUltimateItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_losses_bedwars")]
        public long EightTwoUltimateLossesBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_resources_collected_bedwars")]
        public long EightTwoUltimateResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_ultimate_void_final_deaths_bedwars")]
        public long EightTwoUltimateVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_fall_kills_bedwars")]
        public long EightOneFallKillsBedwars { get; set; }

        [JsonProperty("four_three_winstreak")]
        public long FourThreeWinstreak { get; set; }

        [JsonProperty("four_three__items_purchased_bedwars")]
        public long FourThreeItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_three_beds_lost_bedwars")]
        public long FourThreeBedsLostBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_final_deaths_bedwars")]
        public long FourThreeEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_kills_bedwars")]
        public long FourThreeEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_three_final_deaths_bedwars")]
        public long FourThreeFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_games_played_bedwars")]
        public long FourThreeGamesPlayedBedwars { get; set; }

        [JsonProperty("four_three_gold_resources_collected_bedwars")]
        public long FourThreeGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_iron_resources_collected_bedwars")]
        public long FourThreeIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_items_purchased_bedwars")]
        public long BedwarsFourThreeItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_three_kills_bedwars")]
        public long FourThreeKillsBedwars { get; set; }

        [JsonProperty("four_three_losses_bedwars")]
        public long FourThreeLossesBedwars { get; set; }

        [JsonProperty("four_three_permanent_items_purchased_bedwars")]
        public long FourThreePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_three_resources_collected_bedwars")]
        public long FourThreeResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_final_kills_bedwars")]
        public long FourThreeEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_final_kills_bedwars")]
        public long FourThreeFinalKillsBedwars { get; set; }

        [JsonProperty("four_three_void_kills_bedwars")]
        public long FourThreeVoidKillsBedwars { get; set; }

        [JsonProperty("four_three_wins_bedwars")]
        public long FourThreeWinsBedwars { get; set; }

        [JsonProperty("four_three_deaths_bedwars")]
        public long FourThreeDeathsBedwars { get; set; }

        [JsonProperty("four_three_entity_explosion_kills_bedwars")]
        public long FourThreeEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("four_three_void_deaths_bedwars")]
        public long FourThreeVoidDeathsBedwars { get; set; }

        [JsonProperty("two_four_entity_attack_final_deaths_bedwars")]
        public long TwoFourEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("two_four_fall_deaths_bedwars")]
        public long TwoFourFallDeathsBedwars { get; set; }

        [JsonProperty("eight_one_magic_final_kills_bedwars")]
        public long EightOneMagicFinalKillsBedwars { get; set; }

        [JsonProperty("magic_final_kills_bedwars")]
        public long MagicFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_wins_bedwars")]
        public long EightOneWinsBedwars { get; set; }

        [JsonProperty("eight_one_fall_final_deaths_bedwars")]
        public long EightOneFallFinalDeathsBedwars { get; set; }

        [JsonProperty("fall_final_deaths_bedwars")]
        public long FallFinalDeathsBedwars { get; set; }

        [JsonProperty("castle__items_purchased_bedwars")]
        public long CastleItemsPurchasedBedwars { get; set; }

        [JsonProperty("castle_beds_lost_bedwars")]
        public long CastleBedsLostBedwars { get; set; }

        [JsonProperty("castle_deaths_bedwars")]
        public long CastleDeathsBedwars { get; set; }

        [JsonProperty("castle_emerald_resources_collected_bedwars")]
        public long CastleEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_entity_attack_kills_bedwars")]
        public long CastleEntityAttackKillsBedwars { get; set; }

        [JsonProperty("castle_final_deaths_bedwars")]
        public long CastleFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_games_played_bedwars")]
        public long CastleGamesPlayedBedwars { get; set; }

        [JsonProperty("castle_gold_resources_collected_bedwars")]
        public long CastleGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_iron_resources_collected_bedwars")]
        public long CastleIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_items_purchased_bedwars")]
        public long BedwarsCastleItemsPurchasedBedwars { get; set; }

        [JsonProperty("castle_kills_bedwars")]
        public long CastleKillsBedwars { get; set; }

        [JsonProperty("castle_losses_bedwars")]
        public long CastleLossesBedwars { get; set; }

        [JsonProperty("castle_permanent_items_purchased_bedwars")]
        public long CastlePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("castle_resources_collected_bedwars")]
        public long CastleResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_void_deaths_bedwars")]
        public long CastleVoidDeathsBedwars { get; set; }

        [JsonProperty("castle_void_final_deaths_bedwars")]
        public long CastleVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_winstreak")]
        public long CastleWinstreak { get; set; }

        [JsonProperty("castle_diamond_resources_collected_bedwars")]
        public long CastleDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("castle_entity_attack_deaths_bedwars")]
        public long CastleEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("castle_fall_deaths_bedwars")]
        public long CastleFallDeathsBedwars { get; set; }

        [JsonProperty("castle_wins_bedwars")]
        public long CastleWinsBedwars { get; set; }

        [JsonProperty("castle_void_kills_bedwars")]
        public long CastleVoidKillsBedwars { get; set; }

        [JsonProperty("understands_resource_bank")]
        public bool UnderstandsResourceBank { get; set; }

        [JsonProperty("castle_entity_attack_final_deaths_bedwars")]
        public long CastleEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("castle_fall_kills_bedwars")]
        public long CastleFallKillsBedwars { get; set; }

        [JsonProperty("two_four_void_final_kills_bedwars")]
        public long TwoFourVoidFinalKillsBedwars { get; set; }

        [JsonProperty("two_four_fall_final_deaths_bedwars")]
        public long TwoFourFallFinalDeathsBedwars { get; set; }

        [JsonProperty("two_four_magic_deaths_bedwars")]
        public long TwoFourMagicDeathsBedwars { get; set; }

        [JsonProperty("eight_one_projectile_deaths_bedwars")]
        public long EightOneProjectileDeathsBedwars { get; set; }

        [JsonProperty("projectile_deaths_bedwars")]
        public long ProjectileDeathsBedwars { get; set; }

        [JsonProperty("four_four_permanent_items_purchased_bedwars")]
        public long BedwarsFourFourPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_fall_deaths_bedwars")]
        public long FourFourFallDeathsBedwars { get; set; }

        [JsonProperty("four_four_void_final_deaths_bedwars")]
        public long FourFourVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_beds_broken_bedwars")]
        public long FourFourBedsBrokenBedwars { get; set; }

        [JsonProperty("four_four_wins_bedwars")]
        public long FourFourWinsBedwars { get; set; }

        [JsonProperty("four_four_voidless_winstreak")]
        public long FourFourVoidlessWinstreak { get; set; }

        [JsonProperty("four_four_voidless__items_purchased_bedwars")]
        public long FourFourVoidlessItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_voidless_beds_lost_bedwars")]
        public long FourFourVoidlessBedsLostBedwars { get; set; }

        [JsonProperty("four_four_voidless_emerald_resources_collected_bedwars")]
        public long FourFourVoidlessEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_voidless_entity_attack_final_deaths_bedwars")]
        public long FourFourVoidlessEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_voidless_entity_attack_kills_bedwars")]
        public long FourFourVoidlessEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_voidless_final_deaths_bedwars")]
        public long FourFourVoidlessFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_voidless_games_played_bedwars")]
        public long FourFourVoidlessGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_voidless_gold_resources_collected_bedwars")]
        public long FourFourVoidlessGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_voidless_iron_resources_collected_bedwars")]
        public long FourFourVoidlessIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_voidless_items_purchased_bedwars")]
        public long BedwarsFourFourVoidlessItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_voidless_kills_bedwars")]
        public long FourFourVoidlessKillsBedwars { get; set; }

        [JsonProperty("four_four_voidless_losses_bedwars")]
        public long FourFourVoidlessLossesBedwars { get; set; }

        [JsonProperty("four_four_voidless_permanent_items_purchased_bedwars")]
        public long FourFourVoidlessPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_voidless_resources_collected_bedwars")]
        public long FourFourVoidlessResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_beds_broken_bedwars")]
        public long EightTwoBedsBrokenBedwars { get; set; }

        [JsonProperty("four_three_emerald_resources_collected_bedwars")]
        public long FourThreeEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_entity_attack_deaths_bedwars")]
        public long FourThreeEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("four_three_fall_deaths_bedwars")]
        public long FourThreeFallDeathsBedwars { get; set; }

        [JsonProperty("four_three_fall_final_deaths_bedwars")]
        public long FourThreeFallFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_fall_kills_bedwars")]
        public long FourThreeFallKillsBedwars { get; set; }

        [JsonProperty("four_four_armed_winstreak")]
        public long FourFourArmedWinstreak { get; set; }

        [JsonProperty("four_four_armed__items_purchased_bedwars")]
        public long FourFourArmedItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_armed_beds_broken_bedwars")]
        public long FourFourArmedBedsBrokenBedwars { get; set; }

        [JsonProperty("four_four_armed_beds_lost_bedwars")]
        public long FourFourArmedBedsLostBedwars { get; set; }

        [JsonProperty("four_four_armed_deaths_bedwars")]
        public long FourFourArmedDeathsBedwars { get; set; }

        [JsonProperty("four_four_armed_entity_attack_deaths_bedwars")]
        public long FourFourArmedEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("four_four_armed_entity_attack_kills_bedwars")]
        public long FourFourArmedEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_armed_final_deaths_bedwars")]
        public long FourFourArmedFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_armed_games_played_bedwars")]
        public long FourFourArmedGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_armed_gold_resources_collected_bedwars")]
        public long FourFourArmedGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_armed_iron_resources_collected_bedwars")]
        public long FourFourArmedIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_armed_items_purchased_bedwars")]
        public long BedwarsFourFourArmedItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_armed_kills_bedwars")]
        public long FourFourArmedKillsBedwars { get; set; }

        [JsonProperty("four_four_armed_losses_bedwars")]
        public long FourFourArmedLossesBedwars { get; set; }

        [JsonProperty("four_four_armed_permanent_items_purchased_bedwars")]
        public long FourFourArmedPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_armed_projectile_final_deaths_bedwars")]
        public long FourFourArmedProjectileFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_armed_projectile_kills_bedwars")]
        public long FourFourArmedProjectileKillsBedwars { get; set; }

        [JsonProperty("four_four_armed_resources_collected_bedwars")]
        public long FourFourArmedResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_fall_final_deaths_bedwars")]
        public long EightTwoFallFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_fall_deaths_bedwars")]
        public long EightTwoFallDeathsBedwars { get; set; }

        [JsonProperty("eight_two_fall_kills_bedwars")]
        public long EightTwoFallKillsBedwars { get; set; }

        [JsonProperty("eight_two_projectile_kills_bedwars")]
        public long EightTwoProjectileKillsBedwars { get; set; }

        [JsonProperty("projectile_kills_bedwars")]
        public long ProjectileKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_explosion_deaths_bedwars")]
        public long EightTwoEntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("entity_explosion_deaths_bedwars")]
        public long EntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_explosion_deaths_bedwars")]
        public long EightOneEntityExplosionDeathsBedwars { get; set; }

        [JsonProperty("four_four_projectile_kills_bedwars")]
        public long FourFourProjectileKillsBedwars { get; set; }

        [JsonProperty("four_four_magic_deaths_bedwars")]
        public long FourFourMagicDeathsBedwars { get; set; }

        [JsonProperty("eight_one_magic_kills_bedwars")]
        public long EightOneMagicKillsBedwars { get; set; }

        [JsonProperty("magic_kills_bedwars")]
        public long MagicKillsBedwars { get; set; }

        [JsonProperty("eight_one_fire_tick_deaths_bedwars")]
        public long EightOneFireTickDeathsBedwars { get; set; }

        [JsonProperty("fire_tick_deaths_bedwars")]
        public long FireTickDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_explosion_final_deaths_bedwars")]
        public long EightOneEntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("entity_explosion_final_deaths_bedwars")]
        public long EntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("fire_tick_final_deaths_bedwars")]
        public long FireTickFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_fire_tick_final_deaths_bedwars")]
        public long FourFourFireTickFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_armed_emerald_resources_collected_bedwars")]
        public long FourFourArmedEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_armed_projectile_deaths_bedwars")]
        public long FourFourArmedProjectileDeathsBedwars { get; set; }

        [JsonProperty("four_four_magic_final_deaths_bedwars")]
        public long FourFourMagicFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_fall_final_kills_bedwars")]
        public long EightOneFallFinalKillsBedwars { get; set; }

        [JsonProperty("fall_final_kills_bedwars")]
        public long FallFinalKillsBedwars { get; set; }

        [JsonProperty("eight_one_fire_tick_final_deaths_bedwars")]
        public long EightOneFireTickFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_fall_final_kills_bedwars")]
        public long EightTwoFallFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_entity_explosion_kills_bedwars")]
        public long EightTwoEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("four_three_beds_broken_bedwars")]
        public long FourThreeBedsBrokenBedwars { get; set; }

        [JsonProperty("four_three_void_final_kills_bedwars")]
        public long FourThreeVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_winstreak")]
        public long EightTwoLuckyWinstreak { get; set; }

        [JsonProperty("eight_two_lucky__items_purchased_bedwars")]
        public long EightTwoLuckyItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_beds_broken_bedwars")]
        public long EightTwoLuckyBedsBrokenBedwars { get; set; }

        [JsonProperty("eight_two_lucky_beds_lost_bedwars")]
        public long EightTwoLuckyBedsLostBedwars { get; set; }

        [JsonProperty("eight_two_lucky_deaths_bedwars")]
        public long EightTwoLuckyDeathsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_diamond_resources_collected_bedwars")]
        public long EightTwoLuckyDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_emerald_resources_collected_bedwars")]
        public long EightTwoLuckyEmeraldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_entity_attack_deaths_bedwars")]
        public long EightTwoLuckyEntityAttackDeathsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_entity_attack_final_kills_bedwars")]
        public long EightTwoLuckyEntityAttackFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_entity_attack_kills_bedwars")]
        public long EightTwoLuckyEntityAttackKillsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_fall_deaths_bedwars")]
        public long EightTwoLuckyFallDeathsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_final_kills_bedwars")]
        public long EightTwoLuckyFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_games_played_bedwars")]
        public long EightTwoLuckyGamesPlayedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_gold_resources_collected_bedwars")]
        public long EightTwoLuckyGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_iron_resources_collected_bedwars")]
        public long EightTwoLuckyIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_items_purchased_bedwars")]
        public long BedwarsEightTwoLuckyItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_kills_bedwars")]
        public long EightTwoLuckyKillsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_magic_deaths_bedwars")]
        public long EightTwoLuckyMagicDeathsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_permanent_items_purchased_bedwars")]
        public long EightTwoLuckyPermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_resources_collected_bedwars")]
        public long EightTwoLuckyResourcesCollectedBedwars { get; set; }

        [JsonProperty("eight_two_lucky_void_deaths_bedwars")]
        public long EightTwoLuckyVoidDeathsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_void_final_kills_bedwars")]
        public long EightTwoLuckyVoidFinalKillsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_void_kills_bedwars")]
        public long EightTwoLuckyVoidKillsBedwars { get; set; }

        [JsonProperty("eight_two_lucky_wins_bedwars")]
        public long EightTwoLuckyWinsBedwars { get; set; }

        [JsonProperty("eight_two_magic_final_deaths_bedwars")]
        public long EightTwoMagicFinalDeathsBedwars { get; set; }

        [JsonProperty("four_three_diamond_resources_collected_bedwars")]
        public long FourThreeDiamondResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_three_void_final_deaths_bedwars")]
        public long FourThreeVoidFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_two_magic_final_kills_bedwars")]
        public long EightTwoMagicFinalKillsBedwars { get; set; }

        [JsonProperty("bedwars_halloween_boxes")]
        public long BedwarsHalloweenBoxes { get; set; }

        [JsonProperty("four_four_entity_explosion_final_deaths_bedwars")]
        public long FourFourEntityExplosionFinalDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_explosion_final_kills_bedwars")]
        public long EightOneEntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("entity_explosion_final_kills_bedwars")]
        public long EntityExplosionFinalKillsBedwars { get; set; }

        [JsonProperty("bedwars_christmas_boxes")]
        public long BedwarsChristmasBoxes { get; set; }

        [JsonProperty("four_three_magic_deaths_bedwars")]
        public long FourThreeMagicDeathsBedwars { get; set; }

        [JsonProperty("eight_one_entity_explosion_kills_bedwars")]
        public long EightOneEntityExplosionKillsBedwars { get; set; }

        [JsonProperty("four_four_ultimate_winstreak")]
        public long FourFourUltimateWinstreak { get; set; }

        [JsonProperty("four_four_ultimate__items_purchased_bedwars")]
        public long FourFourUltimateItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_ultimate_beds_lost_bedwars")]
        public long FourFourUltimateBedsLostBedwars { get; set; }

        [JsonProperty("four_four_ultimate_entity_attack_final_deaths_bedwars")]
        public long FourFourUltimateEntityAttackFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_ultimate_final_deaths_bedwars")]
        public long FourFourUltimateFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_ultimate_games_played_bedwars")]
        public long FourFourUltimateGamesPlayedBedwars { get; set; }

        [JsonProperty("four_four_ultimate_gold_resources_collected_bedwars")]
        public long FourFourUltimateGoldResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_ultimate_iron_resources_collected_bedwars")]
        public long FourFourUltimateIronResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_ultimate_items_purchased_bedwars")]
        public long BedwarsFourFourUltimateItemsPurchasedBedwars { get; set; }

        [JsonProperty("four_four_ultimate_kills_bedwars")]
        public long FourFourUltimateKillsBedwars { get; set; }

        [JsonProperty("four_four_ultimate_losses_bedwars")]
        public long FourFourUltimateLossesBedwars { get; set; }

        [JsonProperty("four_four_ultimate_resources_collected_bedwars")]
        public long FourFourUltimateResourcesCollectedBedwars { get; set; }

        [JsonProperty("four_four_ultimate_void_kills_bedwars")]
        public long FourFourUltimateVoidKillsBedwars { get; set; }

        [JsonProperty("four_four_ultimate_entity_attack_kills_bedwars")]
        public long FourFourUltimateEntityAttackKillsBedwars { get; set; }

        [JsonProperty("four_four_ultimate_magic_final_deaths_bedwars")]
        public long FourFourUltimateMagicFinalDeathsBedwars { get; set; }

        [JsonProperty("four_four_ultimate_permanent_items_purchased_bedwars")]
        public long FourFourUltimatePermanentItemsPurchasedBedwars { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("practice")]
        public Practice Practice { get; set; }

        [JsonProperty("eight_two_magic_deaths_bedwars")]
        public long EightTwoMagicDeathsBedwars { get; set; }
    }

    public partial class Practice
    {
        [JsonProperty("selected")]
        public string Selected { get; set; }

        [JsonProperty("records")]
        public Records Records { get; set; }

        [JsonProperty("bridging")]
        public Ing Bridging { get; set; }

        [JsonProperty("mlg")]
        public Mlg Mlg { get; set; }

        [JsonProperty("fireball_jumping")]
        public Ing FireballJumping { get; set; }
    }

    public partial class Ing
    {
        [JsonProperty("successful_attempts")]
        public long SuccessfulAttempts { get; set; }

        [JsonProperty("blocks_placed")]
        public long BlocksPlaced { get; set; }

        [JsonProperty("failed_attempts")]
        public long FailedAttempts { get; set; }
    }

    public partial class Mlg
    {
        [JsonProperty("successful_attempts")]
        public long SuccessfulAttempts { get; set; }

        [JsonProperty("failed_attempts")]
        public long FailedAttempts { get; set; }
    }

    public partial class Records
    {
        [JsonProperty("bridging_distance_30:elevation_NONE:angle_STRAIGHT:")]
        public long BridgingDistance30ElevationNoneAngleStraight { get; set; }
    }

    public partial class BuildBattle
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        [JsonProperty("monthly_coins_a")]
        public long MonthlyCoinsA { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("solo_most_points")]
        public long SoloMostPoints { get; set; }

        [JsonProperty("total_votes")]
        public long TotalVotes { get; set; }

        [JsonProperty("weekly_coins_a")]
        public long WeeklyCoinsA { get; set; }

        [JsonProperty("music")]
        public bool Music { get; set; }

        [JsonProperty("votes_Lightbulb")]
        public long VotesLightbulb { get; set; }

        [JsonProperty("votes_Doughnut")]
        public long VotesDoughnut { get; set; }

        [JsonProperty("votes_School Bus")]
        public long VotesSchoolBus { get; set; }

        [JsonProperty("votes_Bee")]
        public long VotesBee { get; set; }

        [JsonProperty("votes_Tornado")]
        public long VotesTornado { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("wins_solo_normal_latest")]
        public long WinsSoloNormalLatest { get; set; }

        [JsonProperty("votes_Volcano Eruption")]
        public long VotesVolcanoEruption { get; set; }

        [JsonProperty("votes_Panda")]
        public long VotesPanda { get; set; }

        [JsonProperty("weekly_coins_b")]
        public long WeeklyCoinsB { get; set; }

        [JsonProperty("votes_Marshmallow")]
        public long VotesMarshmallow { get; set; }

        [JsonProperty("votes_Sword")]
        public long VotesSword { get; set; }

        [JsonProperty("votes_Bed")]
        public long VotesBed { get; set; }

        [JsonProperty("votes_Sad")]
        public long VotesSad { get; set; }

        [JsonProperty("monthly_coins_b")]
        public long MonthlyCoinsB { get; set; }
    }

    public partial class Duels
    {
        [JsonProperty("combo_rookie_title_prestige")]
        public long ComboRookieTitlePrestige { get; set; }

        [JsonProperty("uhc_rookie_title_prestige")]
        public long UhcRookieTitlePrestige { get; set; }

        [JsonProperty("op_rookie_title_prestige")]
        public long OpRookieTitlePrestige { get; set; }

        [JsonProperty("skywars_rookie_title_prestige")]
        public long SkywarsRookieTitlePrestige { get; set; }

        [JsonProperty("mega_walls_rookie_title_prestige")]
        public long MegaWallsRookieTitlePrestige { get; set; }

        [JsonProperty("bow_rookie_title_prestige")]
        public long BowRookieTitlePrestige { get; set; }

        [JsonProperty("classic_rookie_title_prestige")]
        public long ClassicRookieTitlePrestige { get; set; }

        [JsonProperty("tnt_games_rookie_title_prestige")]
        public long TntGamesRookieTitlePrestige { get; set; }

        [JsonProperty("no_debuff_rookie_title_prestige")]
        public long NoDebuffRookieTitlePrestige { get; set; }

        [JsonProperty("bridge_rookie_title_prestige")]
        public long BridgeRookieTitlePrestige { get; set; }

        [JsonProperty("sumo_rookie_title_prestige")]
        public long SumoRookieTitlePrestige { get; set; }

        [JsonProperty("all_modes_rookie_title_prestige")]
        public long AllModesRookieTitlePrestige { get; set; }

        [JsonProperty("blitz_rookie_title_prestige")]
        public long BlitzRookieTitlePrestige { get; set; }

        [JsonProperty("duels_recently_played2")]
        public string DuelsRecentlyPlayed2 { get; set; }

        [JsonProperty("selected_2_new")]
        public string Selected2_New { get; set; }

        [JsonProperty("selected_1_new")]
        public string Selected1_New { get; set; }

        [JsonProperty("show_lb_option")]
        public string ShowLbOption { get; set; }

        [JsonProperty("games_played_duels")]
        public long GamesPlayedDuels { get; set; }

        [JsonProperty("chat_enabled")]
        public string ChatEnabled { get; set; }

        [JsonProperty("current_winstreak_mode_sumo_duel")]
        public long CurrentWinstreakModeSumoDuel { get; set; }

        [JsonProperty("current_winstreak")]
        public long CurrentWinstreak { get; set; }

        [JsonProperty("current_sumo_winstreak")]
        public long CurrentSumoWinstreak { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("melee_hits")]
        public long MeleeHits { get; set; }

        [JsonProperty("melee_swings")]
        public long MeleeSwings { get; set; }

        [JsonProperty("rounds_played")]
        public long RoundsPlayed { get; set; }

        [JsonProperty("sumo_duel_deaths")]
        public long SumoDuelDeaths { get; set; }

        [JsonProperty("sumo_duel_losses")]
        public long SumoDuelLosses { get; set; }

        [JsonProperty("sumo_duel_melee_hits")]
        public long SumoDuelMeleeHits { get; set; }

        [JsonProperty("sumo_duel_melee_swings")]
        public long SumoDuelMeleeSwings { get; set; }

        [JsonProperty("sumo_duel_rounds_played")]
        public long SumoDuelRoundsPlayed { get; set; }

        [JsonProperty("pingPreference")]
        public long PingPreference { get; set; }

        [JsonProperty("sw_duels_kit_new3")]
        public string SwDuelsKitNew3 { get; set; }

        [JsonProperty("best_winstreak_mode_sw_duel")]
        public long BestWinstreakModeSwDuel { get; set; }

        [JsonProperty("current_skywars_winstreak")]
        public long CurrentSkywarsWinstreak { get; set; }

        [JsonProperty("maps_won_on")]
        public string[] MapsWonOn { get; set; }

        [JsonProperty("current_winstreak_mode_sw_duel")]
        public long CurrentWinstreakModeSwDuel { get; set; }

        [JsonProperty("best_overall_winstreak")]
        public long BestOverallWinstreak { get; set; }

        [JsonProperty("best_skywars_winstreak")]
        public long BestSkywarsWinstreak { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("kit_wins")]
        public long KitWins { get; set; }

        [JsonProperty("paladin_kit_wins")]
        public long PaladinKitWins { get; set; }

        [JsonProperty("sw_duel_kit_wins")]
        public long SwDuelKitWins { get; set; }

        [JsonProperty("sw_duel_paladin_kit_wins")]
        public long SwDuelPaladinKitWins { get; set; }

        [JsonProperty("sw_duel_rounds_played")]
        public long SwDuelRoundsPlayed { get; set; }

        [JsonProperty("sw_duel_wins")]
        public long SwDuelWins { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("current_winstreak_mode_classic_duel")]
        public long CurrentWinstreakModeClassicDuel { get; set; }

        [JsonProperty("current_classic_winstreak")]
        public long CurrentClassicWinstreak { get; set; }

        [JsonProperty("bow_hits")]
        public long BowHits { get; set; }

        [JsonProperty("bow_shots")]
        public long BowShots { get; set; }

        [JsonProperty("classic_duel_bow_hits")]
        public long ClassicDuelBowHits { get; set; }

        [JsonProperty("classic_duel_bow_shots")]
        public long ClassicDuelBowShots { get; set; }

        [JsonProperty("classic_duel_damage_dealt")]
        public long ClassicDuelDamageDealt { get; set; }

        [JsonProperty("classic_duel_deaths")]
        public long ClassicDuelDeaths { get; set; }

        [JsonProperty("classic_duel_health_regenerated")]
        public long ClassicDuelHealthRegenerated { get; set; }

        [JsonProperty("classic_duel_losses")]
        public long ClassicDuelLosses { get; set; }

        [JsonProperty("classic_duel_melee_hits")]
        public long ClassicDuelMeleeHits { get; set; }

        [JsonProperty("classic_duel_melee_swings")]
        public long ClassicDuelMeleeSwings { get; set; }

        [JsonProperty("classic_duel_rounds_played")]
        public long ClassicDuelRoundsPlayed { get; set; }

        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; set; }

        [JsonProperty("health_regenerated")]
        public long HealthRegenerated { get; set; }

        [JsonProperty("best_winstreak_mode_classic_duel")]
        public long BestWinstreakModeClassicDuel { get; set; }

        [JsonProperty("best_classic_winstreak")]
        public long BestClassicWinstreak { get; set; }

        [JsonProperty("classic_duel_kills")]
        public long ClassicDuelKills { get; set; }

        [JsonProperty("classic_duel_wins")]
        public long ClassicDuelWins { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("blocks_placed")]
        public long BlocksPlaced { get; set; }

        [JsonProperty("golden_apples_eaten")]
        public long GoldenApplesEaten { get; set; }

        [JsonProperty("uhc_duel_blocks_placed")]
        public long UhcDuelBlocksPlaced { get; set; }

        [JsonProperty("uhc_duel_bow_hits")]
        public long UhcDuelBowHits { get; set; }

        [JsonProperty("uhc_duel_bow_shots")]
        public long UhcDuelBowShots { get; set; }

        [JsonProperty("uhc_duel_damage_dealt")]
        public long UhcDuelDamageDealt { get; set; }

        [JsonProperty("uhc_duel_golden_apples_eaten")]
        public long UhcDuelGoldenApplesEaten { get; set; }

        [JsonProperty("uhc_duel_health_regenerated")]
        public long UhcDuelHealthRegenerated { get; set; }

        [JsonProperty("uhc_duel_melee_hits")]
        public long UhcDuelMeleeHits { get; set; }

        [JsonProperty("uhc_duel_melee_swings")]
        public long UhcDuelMeleeSwings { get; set; }

        [JsonProperty("uhc_duel_rounds_played")]
        public long UhcDuelRoundsPlayed { get; set; }

        [JsonProperty("bowspleef_duel_bow_shots")]
        public long BowspleefDuelBowShots { get; set; }

        [JsonProperty("bowspleef_duel_rounds_played")]
        public long BowspleefDuelRoundsPlayed { get; set; }

        [JsonProperty("bridge_duel_blocks_placed")]
        public long BridgeDuelBlocksPlaced { get; set; }

        [JsonProperty("bridge_duel_bow_hits")]
        public long BridgeDuelBowHits { get; set; }

        [JsonProperty("bridge_duel_bow_shots")]
        public long BridgeDuelBowShots { get; set; }

        [JsonProperty("bridge_duel_damage_dealt")]
        public long BridgeDuelDamageDealt { get; set; }

        [JsonProperty("bridge_duel_health_regenerated")]
        public long BridgeDuelHealthRegenerated { get; set; }

        [JsonProperty("bridge_duel_melee_hits")]
        public long BridgeDuelMeleeHits { get; set; }

        [JsonProperty("bridge_duel_melee_swings")]
        public long BridgeDuelMeleeSwings { get; set; }

        [JsonProperty("bridge_duel_rounds_played")]
        public long BridgeDuelRoundsPlayed { get; set; }

        [JsonProperty("current_winstreak_mode_op_duel")]
        public long CurrentWinstreakModeOpDuel { get; set; }

        [JsonProperty("current_op_winstreak")]
        public long CurrentOpWinstreak { get; set; }

        [JsonProperty("op_duel_damage_dealt")]
        public long OpDuelDamageDealt { get; set; }

        [JsonProperty("op_duel_deaths")]
        public long OpDuelDeaths { get; set; }

        [JsonProperty("op_duel_health_regenerated")]
        public long OpDuelHealthRegenerated { get; set; }

        [JsonProperty("op_duel_losses")]
        public long OpDuelLosses { get; set; }

        [JsonProperty("op_duel_melee_hits")]
        public long OpDuelMeleeHits { get; set; }

        [JsonProperty("op_duel_melee_swings")]
        public long OpDuelMeleeSwings { get; set; }

        [JsonProperty("op_duel_rounds_played")]
        public long OpDuelRoundsPlayed { get; set; }

        [JsonProperty("best_winstreak_mode_op_duel")]
        public long BestWinstreakModeOpDuel { get; set; }

        [JsonProperty("best_op_winstreak")]
        public long BestOpWinstreak { get; set; }

        [JsonProperty("op_duel_kills")]
        public long OpDuelKills { get; set; }

        [JsonProperty("op_duel_wins")]
        public long OpDuelWins { get; set; }

        [JsonProperty("current_winstreak_mode_op_doubles")]
        public long CurrentWinstreakModeOpDoubles { get; set; }

        [JsonProperty("op_doubles_damage_dealt")]
        public long OpDoublesDamageDealt { get; set; }

        [JsonProperty("op_doubles_deaths")]
        public long OpDoublesDeaths { get; set; }

        [JsonProperty("op_doubles_health_regenerated")]
        public long OpDoublesHealthRegenerated { get; set; }

        [JsonProperty("op_doubles_losses")]
        public long OpDoublesLosses { get; set; }

        [JsonProperty("op_doubles_melee_hits")]
        public long OpDoublesMeleeHits { get; set; }

        [JsonProperty("op_doubles_melee_swings")]
        public long OpDoublesMeleeSwings { get; set; }

        [JsonProperty("op_doubles_rounds_played")]
        public long OpDoublesRoundsPlayed { get; set; }

        [JsonProperty("best_winstreak_mode_uhc_duel")]
        public long BestWinstreakModeUhcDuel { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_duel")]
        public long CurrentWinstreakModeUhcDuel { get; set; }

        [JsonProperty("best_uhc_winstreak")]
        public long BestUhcWinstreak { get; set; }

        [JsonProperty("current_uhc_winstreak")]
        public long CurrentUhcWinstreak { get; set; }

        [JsonProperty("uhc_duel_kills")]
        public long UhcDuelKills { get; set; }

        [JsonProperty("uhc_duel_wins")]
        public long UhcDuelWins { get; set; }

        [JsonProperty("uhc_duel_deaths")]
        public long UhcDuelDeaths { get; set; }

        [JsonProperty("uhc_duel_losses")]
        public long UhcDuelLosses { get; set; }

        [JsonProperty("current_winstreak_mode_bridge_duel")]
        public long CurrentWinstreakModeBridgeDuel { get; set; }

        [JsonProperty("current_bridge_winstreak")]
        public long CurrentBridgeWinstreak { get; set; }

        [JsonProperty("bridge_deaths")]
        public long BridgeDeaths { get; set; }

        [JsonProperty("bridge_duel_bridge_deaths")]
        public long BridgeDuelBridgeDeaths { get; set; }

        [JsonProperty("bridge_duel_losses")]
        public long BridgeDuelLosses { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_meetup")]
        public long CurrentWinstreakModeUhcMeetup { get; set; }

        [JsonProperty("uhc_meetup_damage_dealt")]
        public long UhcMeetupDamageDealt { get; set; }

        [JsonProperty("uhc_meetup_deaths")]
        public long UhcMeetupDeaths { get; set; }

        [JsonProperty("uhc_meetup_health_regenerated")]
        public long UhcMeetupHealthRegenerated { get; set; }

        [JsonProperty("uhc_meetup_losses")]
        public long UhcMeetupLosses { get; set; }

        [JsonProperty("uhc_meetup_melee_hits")]
        public long UhcMeetupMeleeHits { get; set; }

        [JsonProperty("uhc_meetup_melee_swings")]
        public long UhcMeetupMeleeSwings { get; set; }

        [JsonProperty("uhc_meetup_rounds_played")]
        public long UhcMeetupRoundsPlayed { get; set; }

        [JsonProperty("current_winstreak_mode_bridge_doubles")]
        public long CurrentWinstreakModeBridgeDoubles { get; set; }

        [JsonProperty("bridge_doubles_blocks_placed")]
        public long BridgeDoublesBlocksPlaced { get; set; }

        [JsonProperty("bridge_doubles_bow_hits")]
        public long BridgeDoublesBowHits { get; set; }

        [JsonProperty("bridge_doubles_bow_shots")]
        public long BridgeDoublesBowShots { get; set; }

        [JsonProperty("bridge_doubles_bridge_deaths")]
        public long BridgeDoublesBridgeDeaths { get; set; }

        [JsonProperty("bridge_doubles_bridge_kills")]
        public long BridgeDoublesBridgeKills { get; set; }

        [JsonProperty("bridge_doubles_damage_dealt")]
        public long BridgeDoublesDamageDealt { get; set; }

        [JsonProperty("bridge_doubles_health_regenerated")]
        public long BridgeDoublesHealthRegenerated { get; set; }

        [JsonProperty("bridge_doubles_losses")]
        public long BridgeDoublesLosses { get; set; }

        [JsonProperty("bridge_doubles_melee_hits")]
        public long BridgeDoublesMeleeHits { get; set; }

        [JsonProperty("bridge_doubles_melee_swings")]
        public long BridgeDoublesMeleeSwings { get; set; }

        [JsonProperty("bridge_doubles_rounds_played")]
        public long BridgeDoublesRoundsPlayed { get; set; }

        [JsonProperty("bridge_kills")]
        public long BridgeKills { get; set; }

        [JsonProperty("duels_winstreak_best_op_duel")]
        public long DuelsWinstreakBestOpDuel { get; set; }

        [JsonProperty("leaderboardPage_win_streak")]
        public long LeaderboardPageWinStreak { get; set; }

        [JsonProperty("sw_duel_blocks_placed")]
        public long SwDuelBlocksPlaced { get; set; }

        [JsonProperty("sw_duel_deaths")]
        public long SwDuelDeaths { get; set; }

        [JsonProperty("sw_duel_health_regenerated")]
        public long SwDuelHealthRegenerated { get; set; }

        [JsonProperty("sw_duel_losses")]
        public long SwDuelLosses { get; set; }

        [JsonProperty("sw_duel_melee_swings")]
        public long SwDuelMeleeSwings { get; set; }

        [JsonProperty("sw_duel_damage_dealt")]
        public long SwDuelDamageDealt { get; set; }

        [JsonProperty("sw_duel_melee_hits")]
        public long SwDuelMeleeHits { get; set; }

        [JsonProperty("champion_kit_wins")]
        public long ChampionKitWins { get; set; }

        [JsonProperty("sw_duel_champion_kit_wins")]
        public long SwDuelChampionKitWins { get; set; }

        [JsonProperty("sw_duel_kills")]
        public long SwDuelKills { get; set; }

        [JsonProperty("duels_winstreak_best_uhc_duel")]
        public long DuelsWinstreakBestUhcDuel { get; set; }

        [JsonProperty("leaderboardPage_wins")]
        public long LeaderboardPageWins { get; set; }

        [JsonProperty("uhc_meetup_bow_hits")]
        public long UhcMeetupBowHits { get; set; }

        [JsonProperty("uhc_meetup_bow_shots")]
        public long UhcMeetupBowShots { get; set; }

        [JsonProperty("uhc_meetup_kills")]
        public long UhcMeetupKills { get; set; }

        [JsonProperty("uhc_meetup_blocks_placed")]
        public long UhcMeetupBlocksPlaced { get; set; }

        [JsonProperty("best_winstreak_mode_uhc_four")]
        public long BestWinstreakModeUhcFour { get; set; }

        [JsonProperty("current_winstreak_mode_uhc_four")]
        public long CurrentWinstreakModeUhcFour { get; set; }

        [JsonProperty("uhc_four_blocks_placed")]
        public long UhcFourBlocksPlaced { get; set; }

        [JsonProperty("uhc_four_bow_hits")]
        public long UhcFourBowHits { get; set; }

        [JsonProperty("uhc_four_bow_shots")]
        public long UhcFourBowShots { get; set; }

        [JsonProperty("uhc_four_damage_dealt")]
        public long UhcFourDamageDealt { get; set; }

        [JsonProperty("uhc_four_golden_apples_eaten")]
        public long UhcFourGoldenApplesEaten { get; set; }

        [JsonProperty("uhc_four_health_regenerated")]
        public long UhcFourHealthRegenerated { get; set; }

        [JsonProperty("uhc_four_kills")]
        public long UhcFourKills { get; set; }

        [JsonProperty("uhc_four_melee_hits")]
        public long UhcFourMeleeHits { get; set; }

        [JsonProperty("uhc_four_melee_swings")]
        public long UhcFourMeleeSwings { get; set; }

        [JsonProperty("uhc_four_rounds_played")]
        public long UhcFourRoundsPlayed { get; set; }

        [JsonProperty("uhc_four_wins")]
        public long UhcFourWins { get; set; }

        [JsonProperty("duels_winstreak_best_uhc_four")]
        public long DuelsWinstreakBestUhcFour { get; set; }

        [JsonProperty("best_winstreak_mode_uhc_meetup")]
        public long BestWinstreakModeUhcMeetup { get; set; }

        [JsonProperty("uhc_meetup_wins")]
        public long UhcMeetupWins { get; set; }

        [JsonProperty("duels_winstreak_best_classic_duel")]
        public long DuelsWinstreakBestClassicDuel { get; set; }

        [JsonProperty("best_winstreak_mode_op_doubles")]
        public long BestWinstreakModeOpDoubles { get; set; }

        [JsonProperty("op_doubles_kills")]
        public long OpDoublesKills { get; set; }

        [JsonProperty("op_doubles_wins")]
        public long OpDoublesWins { get; set; }

        [JsonProperty("op_iron_title_prestige")]
        public long OpIronTitlePrestige { get; set; }

        [JsonProperty("all_modes_iron_title_prestige")]
        public long AllModesIronTitlePrestige { get; set; }

        [JsonProperty("op_gold_title_prestige")]
        public long OpGoldTitlePrestige { get; set; }

        [JsonProperty("duels_winstreak_best_op_doubles")]
        public long DuelsWinstreakBestOpDoubles { get; set; }

        [JsonProperty("leaderboardPage_goals")]
        public long LeaderboardPageGoals { get; set; }

        [JsonProperty("bridge_duel_bridge_kills")]
        public long BridgeDuelBridgeKills { get; set; }

        [JsonProperty("bridge_duel_goals")]
        public long BridgeDuelGoals { get; set; }

        [JsonProperty("goals")]
        public long Goals { get; set; }

        [JsonProperty("best_bridge_winstreak")]
        public long BestBridgeWinstreak { get; set; }

        [JsonProperty("bridgeMapWins")]
        public string[] BridgeMapWins { get; set; }

        [JsonProperty("best_winstreak_mode_bridge_duel")]
        public long BestWinstreakModeBridgeDuel { get; set; }

        [JsonProperty("bridge_duel_wins")]
        public long BridgeDuelWins { get; set; }

        [JsonProperty("combo_duel_golden_apples_eaten")]
        public long ComboDuelGoldenApplesEaten { get; set; }

        [JsonProperty("combo_duel_health_regenerated")]
        public long ComboDuelHealthRegenerated { get; set; }

        [JsonProperty("combo_duel_melee_hits")]
        public long ComboDuelMeleeHits { get; set; }

        [JsonProperty("combo_duel_melee_swings")]
        public long ComboDuelMeleeSwings { get; set; }

        [JsonProperty("combo_duel_rounds_played")]
        public long ComboDuelRoundsPlayed { get; set; }

        [JsonProperty("current_winstreak_mode_sw_doubles")]
        public long CurrentWinstreakModeSwDoubles { get; set; }

        [JsonProperty("best_winstreak_mode_sw_doubles")]
        public long BestWinstreakModeSwDoubles { get; set; }

        [JsonProperty("sw_doubles_champion_kit_wins")]
        public long SwDoublesChampionKitWins { get; set; }

        [JsonProperty("sw_doubles_damage_dealt")]
        public long SwDoublesDamageDealt { get; set; }

        [JsonProperty("sw_doubles_kills")]
        public long SwDoublesKills { get; set; }

        [JsonProperty("sw_doubles_kit_wins")]
        public long SwDoublesKitWins { get; set; }

        [JsonProperty("sw_doubles_melee_hits")]
        public long SwDoublesMeleeHits { get; set; }

        [JsonProperty("sw_doubles_melee_swings")]
        public long SwDoublesMeleeSwings { get; set; }

        [JsonProperty("sw_doubles_rounds_played")]
        public long SwDoublesRoundsPlayed { get; set; }

        [JsonProperty("sw_doubles_wins")]
        public long SwDoublesWins { get; set; }

        [JsonProperty("duels_winstreak_best_sw_doubles")]
        public long DuelsWinstreakBestSwDoubles { get; set; }

        [JsonProperty("sw_doubles_blocks_placed")]
        public long SwDoublesBlocksPlaced { get; set; }

        [JsonProperty("sw_doubles_deaths")]
        public long SwDoublesDeaths { get; set; }

        [JsonProperty("sw_doubles_health_regenerated")]
        public long SwDoublesHealthRegenerated { get; set; }

        [JsonProperty("sw_doubles_losses")]
        public long SwDoublesLosses { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("progress_mode")]
        public string ProgressMode { get; set; }

        [JsonProperty("active_cosmetictitle")]
        public string ActiveCosmetictitle { get; set; }

        [JsonProperty("all_modes_gold_title_prestige")]
        public long AllModesGoldTitlePrestige { get; set; }

        [JsonProperty("best_winstreak_mode_bridge_doubles")]
        public long BestWinstreakModeBridgeDoubles { get; set; }

        [JsonProperty("bridge_doubles_goals")]
        public long BridgeDoublesGoals { get; set; }

        [JsonProperty("bridge_doubles_wins")]
        public long BridgeDoublesWins { get; set; }

        [JsonProperty("classic_iron_title_prestige")]
        public long ClassicIronTitlePrestige { get; set; }

        [JsonProperty("blitz_duels_kit")]
        public string BlitzDuelsKit { get; set; }

        [JsonProperty("blitz_duel_blocks_placed")]
        public long BlitzDuelBlocksPlaced { get; set; }

        [JsonProperty("blitz_duel_damage_dealt")]
        public long BlitzDuelDamageDealt { get; set; }

        [JsonProperty("blitz_duel_health_regenerated")]
        public long BlitzDuelHealthRegenerated { get; set; }

        [JsonProperty("blitz_duel_melee_hits")]
        public long BlitzDuelMeleeHits { get; set; }

        [JsonProperty("blitz_duel_melee_swings")]
        public long BlitzDuelMeleeSwings { get; set; }

        [JsonProperty("blitz_duel_rounds_played")]
        public long BlitzDuelRoundsPlayed { get; set; }

        [JsonProperty("mw_duels_class")]
        public string MwDuelsClass { get; set; }

        [JsonProperty("mw_duel_bow_hits")]
        public long MwDuelBowHits { get; set; }

        [JsonProperty("mw_duel_bow_shots")]
        public long MwDuelBowShots { get; set; }

        [JsonProperty("mw_duel_damage_dealt")]
        public long MwDuelDamageDealt { get; set; }

        [JsonProperty("mw_duel_health_regenerated")]
        public long MwDuelHealthRegenerated { get; set; }

        [JsonProperty("mw_duel_melee_hits")]
        public long MwDuelMeleeHits { get; set; }

        [JsonProperty("mw_duel_melee_swings")]
        public long MwDuelMeleeSwings { get; set; }

        [JsonProperty("mw_duel_rounds_played")]
        public long MwDuelRoundsPlayed { get; set; }

        [JsonProperty("duels_winstreak_best_sw_duel")]
        public long DuelsWinstreakBestSwDuel { get; set; }

        [JsonProperty("best_sumo_winstreak")]
        public long BestSumoWinstreak { get; set; }

        [JsonProperty("best_winstreak_mode_sumo_duel")]
        public long BestWinstreakModeSumoDuel { get; set; }

        [JsonProperty("sumo_duel_kills")]
        public long SumoDuelKills { get; set; }

        [JsonProperty("sumo_duel_wins")]
        public long SumoDuelWins { get; set; }

        [JsonProperty("duels_winstreak_best_sumo_duel")]
        public long DuelsWinstreakBestSumoDuel { get; set; }

        [JsonProperty("classic_gold_title_prestige")]
        public long ClassicGoldTitlePrestige { get; set; }

        [JsonProperty("op_diamond_title_prestige")]
        public long OpDiamondTitlePrestige { get; set; }

        [JsonProperty("all_modes_diamond_title_prestige")]
        public long AllModesDiamondTitlePrestige { get; set; }

        [JsonProperty("classic_diamond_title_prestige")]
        public long ClassicDiamondTitlePrestige { get; set; }

        [JsonProperty("classic_master_title_prestige")]
        public long ClassicMasterTitlePrestige { get; set; }

        [JsonProperty("sw_duel_bow_hits")]
        public long SwDuelBowHits { get; set; }

        [JsonProperty("sw_duel_bow_shots")]
        public long SwDuelBowShots { get; set; }

        [JsonProperty("all_modes_master_title_prestige")]
        public long AllModesMasterTitlePrestige { get; set; }

        [JsonProperty("mw_doubles_bow_shots")]
        public long MwDoublesBowShots { get; set; }

        [JsonProperty("mw_doubles_damage_dealt")]
        public long MwDoublesDamageDealt { get; set; }

        [JsonProperty("mw_doubles_health_regenerated")]
        public long MwDoublesHealthRegenerated { get; set; }

        [JsonProperty("mw_doubles_melee_hits")]
        public long MwDoublesMeleeHits { get; set; }

        [JsonProperty("mw_doubles_melee_swings")]
        public long MwDoublesMeleeSwings { get; set; }

        [JsonProperty("mw_doubles_rounds_played")]
        public long MwDoublesRoundsPlayed { get; set; }
    }

    public partial class GingerBread
    {
        [JsonProperty("booster_active")]
        public string BoosterActive { get; set; }

        [JsonProperty("frame_active")]
        public string FrameActive { get; set; }

        [JsonProperty("helmet_active")]
        public string HelmetActive { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("shoes_active")]
        public string ShoesActive { get; set; }

        [JsonProperty("engine_active")]
        public string EngineActive { get; set; }

        [JsonProperty("pants_active")]
        public string PantsActive { get; set; }

        [JsonProperty("skin_active")]
        public string SkinActive { get; set; }

        [JsonProperty("jacket_active")]
        public string JacketActive { get; set; }

        [JsonProperty("horn")]
        public string Horn { get; set; }

        [JsonProperty("banana_hits_received")]
        public long BananaHitsReceived { get; set; }

        [JsonProperty("box_pickups")]
        public long BoxPickups { get; set; }

        [JsonProperty("box_pickups_canyon")]
        public long BoxPickupsCanyon { get; set; }

        [JsonProperty("box_pickups_monthly_a")]
        public long BoxPickupsMonthlyA { get; set; }

        [JsonProperty("box_pickups_weekly_b")]
        public long BoxPickupsWeeklyB { get; set; }

        [JsonProperty("canyon_plays")]
        public long CanyonPlays { get; set; }

        [JsonProperty("coins_picked_up")]
        public long CoinsPickedUp { get; set; }

        [JsonProperty("laps_completed")]
        public long LapsCompleted { get; set; }

        [JsonProperty("lastTourneyAd")]
        public long LastTourneyAd { get; set; }
    }

    public partial class HungerGames
    {
        [JsonProperty("wins_teams_normal")]
        public long WinsTeamsNormal { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("wins_backup")]
        public long WinsBackup { get; set; }

        [JsonProperty("autoarmor")]
        public bool Autoarmor { get; set; }

        [JsonProperty("wins_solo_normal")]
        public long WinsSoloNormal { get; set; }

        [JsonProperty("chests_opened")]
        public long ChestsOpened { get; set; }

        [JsonProperty("chests_opened_knight")]
        public long ChestsOpenedKnight { get; set; }

        [JsonProperty("damage")]
        public long Damage { get; set; }

        [JsonProperty("damage_knight")]
        public long DamageKnight { get; set; }

        [JsonProperty("damage_taken")]
        public long DamageTaken { get; set; }

        [JsonProperty("damage_taken_knight")]
        public long DamageTakenKnight { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        [JsonProperty("games_played_knight")]
        public long GamesPlayedKnight { get; set; }

        [JsonProperty("time_played")]
        public long TimePlayed { get; set; }

        [JsonProperty("time_played_knight")]
        public long TimePlayedKnight { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("exp_knight")]
        public long ExpKnight { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_knight")]
        public long KillsKnight { get; set; }

        [JsonProperty("kills_solo_normal")]
        public long KillsSoloNormal { get; set; }

        [JsonProperty("chests_opened_rambo")]
        public long ChestsOpenedRambo { get; set; }

        [JsonProperty("damage_rambo")]
        public long DamageRambo { get; set; }

        [JsonProperty("damage_taken_rambo")]
        public long DamageTakenRambo { get; set; }

        [JsonProperty("games_played_rambo")]
        public long GamesPlayedRambo { get; set; }

        [JsonProperty("potions_drunk")]
        public long PotionsDrunk { get; set; }

        [JsonProperty("potions_drunk_rambo")]
        public long PotionsDrunkRambo { get; set; }

        [JsonProperty("time_played_rambo")]
        public long TimePlayedRambo { get; set; }

        [JsonProperty("arrows_fired")]
        public long ArrowsFired { get; set; }

        [JsonProperty("arrows_fired_archer")]
        public long ArrowsFiredArcher { get; set; }

        [JsonProperty("chests_opened_archer")]
        public long ChestsOpenedArcher { get; set; }

        [JsonProperty("damage_taken_archer")]
        public long DamageTakenArcher { get; set; }

        [JsonProperty("games_played_archer")]
        public long GamesPlayedArcher { get; set; }

        [JsonProperty("time_played_archer")]
        public long TimePlayedArcher { get; set; }

        [JsonProperty("arrows_fired_ranger")]
        public long ArrowsFiredRanger { get; set; }

        [JsonProperty("chests_opened_ranger")]
        public long ChestsOpenedRanger { get; set; }

        [JsonProperty("damage_taken_ranger")]
        public long DamageTakenRanger { get; set; }

        [JsonProperty("exp_ranger")]
        public long ExpRanger { get; set; }

        [JsonProperty("games_played_ranger")]
        public long GamesPlayedRanger { get; set; }

        [JsonProperty("time_played_ranger")]
        public long TimePlayedRanger { get; set; }

        [JsonProperty("chests_opened_hunter")]
        public long ChestsOpenedHunter { get; set; }

        [JsonProperty("damage_taken_hunter")]
        public long DamageTakenHunter { get; set; }

        [JsonProperty("games_played_hunter")]
        public long GamesPlayedHunter { get; set; }

        [JsonProperty("time_played_hunter")]
        public long TimePlayedHunter { get; set; }

        [JsonProperty("damage_hunter")]
        public long DamageHunter { get; set; }

        [JsonProperty("blitz_uses")]
        public long BlitzUses { get; set; }

        [JsonProperty("potions_drunk_knight")]
        public long PotionsDrunkKnight { get; set; }

        [JsonProperty("arrows_fired_hunter")]
        public long ArrowsFiredHunter { get; set; }

        [JsonProperty("arrows_hit")]
        public long ArrowsHit { get; set; }

        [JsonProperty("arrows_hit_archer")]
        public long ArrowsHitArcher { get; set; }

        [JsonProperty("damage_archer")]
        public long DamageArcher { get; set; }

        [JsonProperty("potions_drunk_hunter")]
        public long PotionsDrunkHunter { get; set; }

        [JsonProperty("arrows_hit_hunter")]
        public long ArrowsHitHunter { get; set; }

        [JsonProperty("potions_thrown")]
        public long PotionsThrown { get; set; }

        [JsonProperty("potions_thrown_knight")]
        public long PotionsThrownKnight { get; set; }

        [JsonProperty("lastTourneyAd")]
        public long LastTourneyAd { get; set; }
    }

    public partial class Legacy
    {
        [JsonProperty("next_tokens_seconds")]
        public long NextTokensSeconds { get; set; }

        [JsonProperty("quakecraft_tokens")]
        public long QuakecraftTokens { get; set; }

        [JsonProperty("tokens")]
        public long Tokens { get; set; }

        [JsonProperty("total_tokens")]
        public long TotalTokens { get; set; }

        [JsonProperty("gingerbread_tokens")]
        public long GingerbreadTokens { get; set; }

        [JsonProperty("paintball_tokens")]
        public long PaintballTokens { get; set; }

        [JsonProperty("vampirez_tokens")]
        public long VampirezTokens { get; set; }
    }

    public partial class Mcgo
    {
        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("game_wins_deathmatch")]
        public long GameWinsDeathmatch { get; set; }

        [JsonProperty("grenade_kills")]
        public long McgoGrenadeKills { get; set; }

        [JsonProperty("game_wins")]
        public long GameWins { get; set; }

        [JsonProperty("pocket_change")]
        public long PocketChange { get; set; }

        [JsonProperty("kills_deathmatch")]
        public long KillsDeathmatch { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("bombs_defused")]
        public long BombsDefused { get; set; }

        [JsonProperty("grenadeKills")]
        public long GrenadeKills { get; set; }

        [JsonProperty("bombs_planted")]
        public long BombsPlanted { get; set; }

        [JsonProperty("headshot_kills")]
        public long HeadshotKills { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("cop_kills")]
        public long CopKills { get; set; }

        [JsonProperty("game_plays")]
        public long GamePlays { get; set; }

        [JsonProperty("round_wins")]
        public long RoundWins { get; set; }

        [JsonProperty("shots_fired")]
        public long ShotsFired { get; set; }

        [JsonProperty("lastTourneyAd")]
        public long LastTourneyAd { get; set; }
    }

    public partial class MurderMystery
    {
        [JsonProperty("murdermystery_books")]
        public string[] MurdermysteryBooks { get; set; }

        [JsonProperty("detective_chance")]
        public long DetectiveChance { get; set; }

        [JsonProperty("murderer_chance")]
        public long MurdererChance { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("coins_pickedup")]
        public long CoinsPickedup { get; set; }

        [JsonProperty("coins_pickedup_MURDER_CLASSIC")]
        public long CoinsPickedupMurderClassic { get; set; }

        [JsonProperty("coins_pickedup_widow's_den")]
        public long CoinsPickedupWidowSDen { get; set; }

        [JsonProperty("coins_pickedup_widow's_den_MURDER_CLASSIC")]
        public long CoinsPickedupWidowSDenMurderClassic { get; set; }

        [JsonProperty("detective_wins")]
        public long DetectiveWins { get; set; }

        [JsonProperty("detective_wins_MURDER_CLASSIC")]
        public long DetectiveWinsMurderClassic { get; set; }

        [JsonProperty("detective_wins_widow's_den")]
        public long DetectiveWinsWidowSDen { get; set; }

        [JsonProperty("detective_wins_widow's_den_MURDER_CLASSIC")]
        public long DetectiveWinsWidowSDenMurderClassic { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("games_MURDER_CLASSIC")]
        public long GamesMurderClassic { get; set; }

        [JsonProperty("games_widow's_den")]
        public long GamesWidowSDen { get; set; }

        [JsonProperty("games_widow's_den_MURDER_CLASSIC")]
        public long GamesWidowSDenMurderClassic { get; set; }

        [JsonProperty("quickest_detective_win_time_seconds")]
        public long QuickestDetectiveWinTimeSeconds { get; set; }

        [JsonProperty("quickest_detective_win_time_seconds_MURDER_CLASSIC")]
        public long QuickestDetectiveWinTimeSecondsMurderClassic { get; set; }

        [JsonProperty("quickest_detective_win_time_seconds_widow's_den")]
        public long QuickestDetectiveWinTimeSecondsWidowSDen { get; set; }

        [JsonProperty("quickest_detective_win_time_seconds_widow's_den_MURDER_CLASSIC")]
        public long QuickestDetectiveWinTimeSecondsWidowSDenMurderClassic { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("wins_MURDER_CLASSIC")]
        public long WinsMurderClassic { get; set; }

        [JsonProperty("wins_widow's_den")]
        public long WinsWidowSDen { get; set; }

        [JsonProperty("wins_widow's_den_MURDER_CLASSIC")]
        public long WinsWidowSDenMurderClassic { get; set; }
    }

    public partial class Paintball
    {
        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("killstreaks")]
        public long Killstreaks { get; set; }

        [JsonProperty("shots_fired")]
        public long ShotsFired { get; set; }

        [JsonProperty("showKillPrefix")]
        public bool ShowKillPrefix { get; set; }
    }

    public partial class Pit
    {
        [JsonProperty("profile")]
        public PitProfile Profile { get; set; }

        [JsonProperty("pit_stats_ptl")]
        public Dictionary<string, long> PitStatsPtl { get; set; }
    }

    public partial class PitProfile
    {
        [JsonProperty("moved_achievements_1")]
        public bool MovedAchievements1 { get; set; }

        [JsonProperty("outgoing_offers")]
        public object[] OutgoingOffers { get; set; }

        [JsonProperty("moved_achievements_2")]
        public bool MovedAchievements2 { get; set; }

        [JsonProperty("items_last_buy")]
        public ItemsLastBuy ItemsLastBuy { get; set; }

        [JsonProperty("leaderboard_stats")]
        public LeaderboardStats LeaderboardStats { get; set; }

        [JsonProperty("last_save")]
        public long LastSave { get; set; }

        [JsonProperty("king_quest")]
        public KingQuest KingQuest { get; set; }

        [JsonProperty("inv_armor")]
        public InvArmor InvArmor { get; set; }

        [JsonProperty("login_messages")]
        public object[] LoginMessages { get; set; }

        [JsonProperty("spire_stash_inv")]
        public InvArmor SpireStashInv { get; set; }

        [JsonProperty("xp")]
        public long Xp { get; set; }

        [JsonProperty("inv_contents")]
        public InvArmor InvContents { get; set; }

        [JsonProperty("zero_point_three_gold_transfer")]
        public bool ZeroPointThreeGoldTransfer { get; set; }

        [JsonProperty("bounties")]
        public object[] Bounties { get; set; }

        [JsonProperty("spire_stash_armor")]
        public InvArmor SpireStashArmor { get; set; }

        [JsonProperty("cash")]
        public double Cash { get; set; }

        [JsonProperty("cash_during_prestige_0")]
        public double CashDuringPrestige0 { get; set; }
    }

    public partial class InvArmor
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("data")]
        public long[] Data { get; set; }
    }

    public partial class ItemsLastBuy
    {
        [JsonProperty("diamond_sword")]
        public long DiamondSword { get; set; }
    }

    public partial class KingQuest
    {
        [JsonProperty("kills")]
        public long Kills { get; set; }
    }

    public partial class LeaderboardStats
    {
    }

    public partial class Quake
    {
        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("enable_sound")]
        public bool EnableSound { get; set; }

        [JsonProperty("compass_selected")]
        public bool CompassSelected { get; set; }

        [JsonProperty("alternative_gun_cooldown_indicator")]
        public bool AlternativeGunCooldownIndicator { get; set; }

        [JsonProperty("messageYour Deaths")]
        public bool MessageYourDeaths { get; set; }

        [JsonProperty("instantRespawn")]
        public bool InstantRespawn { get; set; }

        [JsonProperty("messageOthers' Kills/deaths")]
        public bool MessageOthersKillsDeaths { get; set; }

        [JsonProperty("messageYour Kills")]
        public bool MessageYourKills { get; set; }

        [JsonProperty("messageCoin")]
        public bool MessageCoin { get; set; }

        [JsonProperty("highest_killstreak")]
        public long HighestKillstreak { get; set; }

        [JsonProperty("messageKillstreaks")]
        public bool MessageKillstreaks { get; set; }

        [JsonProperty("messageMulti-kills")]
        public bool MessageMultiKills { get; set; }

        [JsonProperty("messagePowerup Collections")]
        public bool MessagePowerupCollections { get; set; }

        [JsonProperty("showDashCooldown")]
        public bool ShowDashCooldown { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("distance_travelled")]
        public long DistanceTravelled { get; set; }

        [JsonProperty("shots_fired")]
        public long ShotsFired { get; set; }

        [JsonProperty("kills_since_update_feb_2017")]
        public long KillsSinceUpdateFeb2017 { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("headshots")]
        public long Headshots { get; set; }

        [JsonProperty("killstreaks")]
        public long Killstreaks { get; set; }

        [JsonProperty("showKillPrefix")]
        public bool ShowKillPrefix { get; set; }

        [JsonProperty("kills_teams")]
        public long KillsTeams { get; set; }

        [JsonProperty("kills_timeattack")]
        public long KillsTimeattack { get; set; }

        [JsonProperty("kills_dm")]
        public long KillsDm { get; set; }

        [JsonProperty("kills_dm_teams")]
        public long KillsDmTeams { get; set; }

        [JsonProperty("kills_solo_tourney")]
        public long KillsSoloTourney { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }
    }

    public partial class SkyBlock
    {
        [JsonProperty("profiles")]
        public Dictionary<string, ProfileValue> Profiles { get; set; }
    }

    public partial class ProfileValue
    {
        [JsonProperty("profile_id")]
        public string ProfileId { get; set; }

        [JsonProperty("cute_name")]
        public string CuteName { get; set; }
    }

    public partial class SkyWars
    {
        [JsonProperty("levelFormatted")]
        public string LevelFormatted { get; set; }

        [JsonProperty("souls")]
        public long Souls { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("activeKit_SOLO")]
        public string ActiveKitSolo { get; set; }

        [JsonProperty("activeKit_SOLO_random")]
        public bool ActiveKitSoloRandom { get; set; }

        [JsonProperty("games_played_skywars")]
        public long GamesPlayedSkywars { get; set; }

        [JsonProperty("blocks_placed")]
        public long BlocksPlaced { get; set; }

        [JsonProperty("chests_opened")]
        public long ChestsOpened { get; set; }

        [JsonProperty("chests_opened_kit_basic_solo_default")]
        public long ChestsOpenedKitBasicSoloDefault { get; set; }

        [JsonProperty("chests_opened_solo")]
        public long ChestsOpenedSolo { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("deaths_kit_basic_solo_default")]
        public long DeathsKitBasicSoloDefault { get; set; }

        [JsonProperty("deaths_solo")]
        public long DeathsSolo { get; set; }

        [JsonProperty("deaths_solo_normal")]
        public long DeathsSoloNormal { get; set; }

        [JsonProperty("lastMode")]
        public string LastMode { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("losses_kit_basic_solo_default")]
        public long LossesKitBasicSoloDefault { get; set; }

        [JsonProperty("losses_solo")]
        public long LossesSolo { get; set; }

        [JsonProperty("losses_solo_normal")]
        public long LossesSoloNormal { get; set; }

        [JsonProperty("quits")]
        public long Quits { get; set; }

        [JsonProperty("survived_players")]
        public long SurvivedPlayers { get; set; }

        [JsonProperty("survived_players_kit_basic_solo_default")]
        public long SurvivedPlayersKitBasicSoloDefault { get; set; }

        [JsonProperty("survived_players_solo")]
        public long SurvivedPlayersSolo { get; set; }

        [JsonProperty("time_played")]
        public long TimePlayed { get; set; }

        [JsonProperty("time_played_kit_basic_solo_default")]
        public long TimePlayedKitBasicSoloDefault { get; set; }

        [JsonProperty("time_played_solo")]
        public long TimePlayedSolo { get; set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_kit_basic_solo_default")]
        public long KillsKitBasicSoloDefault { get; set; }

        [JsonProperty("kills_monthly_a")]
        public long KillsMonthlyA { get; set; }

        [JsonProperty("kills_solo")]
        public long KillsSolo { get; set; }

        [JsonProperty("kills_solo_normal")]
        public long KillsSoloNormal { get; set; }

        [JsonProperty("kills_weekly_a")]
        public long KillsWeeklyA { get; set; }

        [JsonProperty("longest_bow_kill")]
        public long LongestBowKill { get; set; }

        [JsonProperty("longest_bow_kill_kit_basic_solo_default")]
        public long LongestBowKillKitBasicSoloDefault { get; set; }

        [JsonProperty("longest_bow_kill_solo")]
        public long LongestBowKillSolo { get; set; }

        [JsonProperty("melee_kills")]
        public long MeleeKills { get; set; }

        [JsonProperty("melee_kills_kit_basic_solo_default")]
        public long MeleeKillsKitBasicSoloDefault { get; set; }

        [JsonProperty("melee_kills_solo")]
        public long MeleeKillsSolo { get; set; }

        [JsonProperty("most_kills_game")]
        public long MostKillsGame { get; set; }

        [JsonProperty("most_kills_game_kit_basic_solo_default")]
        public long MostKillsGameKitBasicSoloDefault { get; set; }

        [JsonProperty("most_kills_game_solo")]
        public long MostKillsGameSolo { get; set; }

        [JsonProperty("souls_gathered")]
        public long SoulsGathered { get; set; }

        [JsonProperty("skywars_experience")]
        public long SkywarsExperience { get; set; }

        [JsonProperty("egg_thrown")]
        public long EggThrown { get; set; }

        [JsonProperty("fastest_win")]
        public long FastestWin { get; set; }

        [JsonProperty("fastest_win_kit_basic_solo_default")]
        public long FastestWinKitBasicSoloDefault { get; set; }

        [JsonProperty("fastest_win_solo")]
        public long FastestWinSolo { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("games_kit_basic_solo_default")]
        public long GamesKitBasicSoloDefault { get; set; }

        [JsonProperty("games_solo")]
        public long GamesSolo { get; set; }

        [JsonProperty("killstreak")]
        public long Killstreak { get; set; }

        [JsonProperty("killstreak_kit_basic_solo_default")]
        public long KillstreakKitBasicSoloDefault { get; set; }

        [JsonProperty("killstreak_solo")]
        public long KillstreakSolo { get; set; }

        [JsonProperty("void_kills")]
        public long VoidKills { get; set; }

        [JsonProperty("void_kills_kit_basic_solo_default")]
        public long VoidKillsKitBasicSoloDefault { get; set; }

        [JsonProperty("void_kills_solo")]
        public long VoidKillsSolo { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("wins_kit_basic_solo_default")]
        public long WinsKitBasicSoloDefault { get; set; }

        [JsonProperty("wins_solo")]
        public long WinsSolo { get; set; }

        [JsonProperty("wins_solo_normal")]
        public long WinsSoloNormal { get; set; }

        [JsonProperty("arrows_shot")]
        public long ArrowsShot { get; set; }

        [JsonProperty("arrows_shot_kit_basic_solo_default")]
        public long ArrowsShotKitBasicSoloDefault { get; set; }

        [JsonProperty("arrows_shot_solo")]
        public long ArrowsShotSolo { get; set; }

        [JsonProperty("arrows_hit")]
        public long ArrowsHit { get; set; }

        [JsonProperty("arrows_hit_kit_basic_solo_default")]
        public long ArrowsHitKitBasicSoloDefault { get; set; }

        [JsonProperty("arrows_hit_solo")]
        public long ArrowsHitSolo { get; set; }

        [JsonProperty("longest_bow_shot")]
        public long LongestBowShot { get; set; }

        [JsonProperty("longest_bow_shot_kit_basic_solo_default")]
        public long LongestBowShotKitBasicSoloDefault { get; set; }

        [JsonProperty("longest_bow_shot_solo")]
        public long LongestBowShotSolo { get; set; }

        [JsonProperty("chests_opened_kit_mining_team_default")]
        public long ChestsOpenedKitMiningTeamDefault { get; set; }

        [JsonProperty("deaths_kit_mining_team_default")]
        public long DeathsKitMiningTeamDefault { get; set; }

        [JsonProperty("deaths_solo_insane")]
        public long DeathsSoloInsane { get; set; }

        [JsonProperty("games_kit_mining_team_default")]
        public long GamesKitMiningTeamDefault { get; set; }

        [JsonProperty("losses_kit_mining_team_default")]
        public long LossesKitMiningTeamDefault { get; set; }

        [JsonProperty("losses_solo_insane")]
        public long LossesSoloInsane { get; set; }

        [JsonProperty("survived_players_kit_mining_team_default")]
        public long SurvivedPlayersKitMiningTeamDefault { get; set; }

        [JsonProperty("time_played_kit_mining_team_default")]
        public long TimePlayedKitMiningTeamDefault { get; set; }

        [JsonProperty("arrows_shot_kit_mining_team_default")]
        public long ArrowsShotKitMiningTeamDefault { get; set; }

        [JsonProperty("arrows_hit_kit_mining_team_default")]
        public long ArrowsHitKitMiningTeamDefault { get; set; }

        [JsonProperty("kills_kit_mining_team_default")]
        public long KillsKitMiningTeamDefault { get; set; }

        [JsonProperty("kills_solo_insane")]
        public long KillsSoloInsane { get; set; }

        [JsonProperty("longest_bow_shot_kit_mining_team_default")]
        public long LongestBowShotKitMiningTeamDefault { get; set; }

        [JsonProperty("most_kills_game_kit_mining_team_default")]
        public long MostKillsGameKitMiningTeamDefault { get; set; }

        [JsonProperty("void_kills_kit_mining_team_default")]
        public long VoidKillsKitMiningTeamDefault { get; set; }

        [JsonProperty("blocks_broken")]
        public long BlocksBroken { get; set; }

        [JsonProperty("enderpearls_thrown")]
        public long EnderpearlsThrown { get; set; }

        [JsonProperty("kills_monthly_b")]
        public long KillsMonthlyB { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("assists_kit_basic_solo_default")]
        public long AssistsKitBasicSoloDefault { get; set; }

        [JsonProperty("assists_solo")]
        public long AssistsSolo { get; set; }

        [JsonProperty("activeKit_TEAMS_random")]
        public bool ActiveKitTeamsRandom { get; set; }

        [JsonProperty("activeKit_TEAMS")]
        public string ActiveKitTeams { get; set; }

        [JsonProperty("chests_opened_team")]
        public long ChestsOpenedTeam { get; set; }

        [JsonProperty("deaths_team")]
        public long DeathsTeam { get; set; }

        [JsonProperty("deaths_team_insane")]
        public long DeathsTeamInsane { get; set; }

        [JsonProperty("losses_team")]
        public long LossesTeam { get; set; }

        [JsonProperty("losses_team_insane")]
        public long LossesTeamInsane { get; set; }

        [JsonProperty("time_played_team")]
        public long TimePlayedTeam { get; set; }

        [JsonProperty("assists_team")]
        public long AssistsTeam { get; set; }

        [JsonProperty("deaths_team_normal")]
        public long DeathsTeamNormal { get; set; }

        [JsonProperty("kills_team")]
        public long KillsTeam { get; set; }

        [JsonProperty("kills_team_normal")]
        public long KillsTeamNormal { get; set; }

        [JsonProperty("losses_team_normal")]
        public long LossesTeamNormal { get; set; }

        [JsonProperty("survived_players_team")]
        public long SurvivedPlayersTeam { get; set; }

        [JsonProperty("void_kills_team")]
        public long VoidKillsTeam { get; set; }

        [JsonProperty("usedSoulWell")]
        public bool UsedSoulWell { get; set; }

        [JsonProperty("soul_well")]
        public long SoulWell { get; set; }

        [JsonProperty("team_ender_mastery")]
        public long TeamEnderMastery { get; set; }

        [JsonProperty("chests_opened_kit_attacking_team_grenade")]
        public long ChestsOpenedKitAttackingTeamGrenade { get; set; }

        [JsonProperty("deaths_kit_attacking_team_grenade")]
        public long DeathsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("losses_kit_attacking_team_grenade")]
        public long LossesKitAttackingTeamGrenade { get; set; }

        [JsonProperty("survived_players_kit_attacking_team_grenade")]
        public long SurvivedPlayersKitAttackingTeamGrenade { get; set; }

        [JsonProperty("time_played_kit_attacking_team_grenade")]
        public long TimePlayedKitAttackingTeamGrenade { get; set; }

        [JsonProperty("kills_weekly_b")]
        public long KillsWeeklyB { get; set; }

        [JsonProperty("mega_lucky_charm")]
        public long MegaLuckyCharm { get; set; }

        [JsonProperty("chests_opened_kit_supporting_team_healer")]
        public long ChestsOpenedKitSupportingTeamHealer { get; set; }

        [JsonProperty("deaths_kit_supporting_team_healer")]
        public long DeathsKitSupportingTeamHealer { get; set; }

        [JsonProperty("games_kit_supporting_team_healer")]
        public long GamesKitSupportingTeamHealer { get; set; }

        [JsonProperty("kills_kit_supporting_team_healer")]
        public long KillsKitSupportingTeamHealer { get; set; }

        [JsonProperty("losses_kit_supporting_team_healer")]
        public long LossesKitSupportingTeamHealer { get; set; }

        [JsonProperty("most_kills_game_kit_supporting_team_healer")]
        public long MostKillsGameKitSupportingTeamHealer { get; set; }

        [JsonProperty("survived_players_kit_supporting_team_healer")]
        public long SurvivedPlayersKitSupportingTeamHealer { get; set; }

        [JsonProperty("time_played_kit_supporting_team_healer")]
        public long TimePlayedKitSupportingTeamHealer { get; set; }

        [JsonProperty("void_kills_kit_supporting_team_healer")]
        public long VoidKillsKitSupportingTeamHealer { get; set; }

        [JsonProperty("heads")]
        public long Heads { get; set; }

        [JsonProperty("heads_eww")]
        public long HeadsEww { get; set; }

        [JsonProperty("heads_eww_kit_mining_team_default")]
        public long HeadsEwwKitMiningTeamDefault { get; set; }

        [JsonProperty("heads_eww_solo")]
        public long HeadsEwwSolo { get; set; }

        [JsonProperty("heads_kit_mining_team_default")]
        public long HeadsKitMiningTeamDefault { get; set; }

        [JsonProperty("heads_solo")]
        public long HeadsSolo { get; set; }

        [JsonProperty("head_collection")]
        public HeadCollection HeadCollection { get; set; }

        [JsonProperty("assists_kit_mining_team_default")]
        public long AssistsKitMiningTeamDefault { get; set; }

        [JsonProperty("heads_meh")]
        public long HeadsMeh { get; set; }

        [JsonProperty("heads_meh_kit_mining_team_default")]
        public long HeadsMehKitMiningTeamDefault { get; set; }

        [JsonProperty("heads_meh_solo")]
        public long HeadsMehSolo { get; set; }

        [JsonProperty("inGamePresentsCap_2020_27")]
        public long InGamePresentsCap2020_27 { get; set; }

        [JsonProperty("kills_kit_attacking_team_grenade")]
        public long KillsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("longest_bow_kill_kit_attacking_team_grenade")]
        public long LongestBowKillKitAttackingTeamGrenade { get; set; }

        [JsonProperty("melee_kills_kit_attacking_team_grenade")]
        public long MeleeKillsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("most_kills_game_kit_attacking_team_grenade")]
        public long MostKillsGameKitAttackingTeamGrenade { get; set; }

        [JsonProperty("assists_kit_attacking_team_grenade")]
        public long AssistsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("games_kit_attacking_team_grenade")]
        public long GamesKitAttackingTeamGrenade { get; set; }

        [JsonProperty("heads_kit_attacking_team_grenade")]
        public long HeadsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("heads_meh_kit_attacking_team_grenade")]
        public long HeadsMehKitAttackingTeamGrenade { get; set; }

        [JsonProperty("heads_tasty")]
        public long HeadsTasty { get; set; }

        [JsonProperty("heads_tasty_kit_attacking_team_grenade")]
        public long HeadsTastyKitAttackingTeamGrenade { get; set; }

        [JsonProperty("heads_tasty_solo")]
        public long HeadsTastySolo { get; set; }

        [JsonProperty("items_enchanted")]
        public long ItemsEnchanted { get; set; }

        [JsonProperty("void_kills_kit_attacking_team_grenade")]
        public long VoidKillsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("arrows_shot_kit_attacking_team_grenade")]
        public long ArrowsShotKitAttackingTeamGrenade { get; set; }

        [JsonProperty("arrows_hit_kit_attacking_team_grenade")]
        public long ArrowsHitKitAttackingTeamGrenade { get; set; }

        [JsonProperty("longest_bow_shot_kit_attacking_team_grenade")]
        public long LongestBowShotKitAttackingTeamGrenade { get; set; }

        [JsonProperty("bow_kills")]
        public long BowKills { get; set; }

        [JsonProperty("bow_kills_kit_attacking_team_grenade")]
        public long BowKillsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("bow_kills_solo")]
        public long BowKillsSolo { get; set; }

        [JsonProperty("inGamePresentsCap_2020_31")]
        public long InGamePresentsCap2020_31 { get; set; }

        [JsonProperty("arrows_hit_kit_supporting_team_healer")]
        public long ArrowsHitKitSupportingTeamHealer { get; set; }

        [JsonProperty("arrows_shot_kit_supporting_team_healer")]
        public long ArrowsShotKitSupportingTeamHealer { get; set; }

        [JsonProperty("longest_bow_shot_kit_supporting_team_healer")]
        public long LongestBowShotKitSupportingTeamHealer { get; set; }

        [JsonProperty("inGamePresentsCap_2021_8")]
        public long InGamePresentsCap2021_8 { get; set; }

        [JsonProperty("fastest_win_kit_attacking_team_grenade")]
        public long FastestWinKitAttackingTeamGrenade { get; set; }

        [JsonProperty("killstreak_kit_attacking_team_grenade")]
        public long KillstreakKitAttackingTeamGrenade { get; set; }

        [JsonProperty("wins_kit_attacking_team_grenade")]
        public long WinsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("wins_solo_insane")]
        public long WinsSoloInsane { get; set; }

        [JsonProperty("fall_kills")]
        public long FallKills { get; set; }

        [JsonProperty("fall_kills_kit_attacking_team_grenade")]
        public long FallKillsKitAttackingTeamGrenade { get; set; }

        [JsonProperty("fall_kills_solo")]
        public long FallKillsSolo { get; set; }

        [JsonProperty("inGamePresentsCap_2021_10")]
        public long InGamePresentsCap2021_10 { get; set; }

        [JsonProperty("refill_chest_destroy")]
        public long RefillChestDestroy { get; set; }

        [JsonProperty("assists_kit_supporting_team_healer")]
        public long AssistsKitSupportingTeamHealer { get; set; }

        [JsonProperty("longest_bow_kill_kit_supporting_team_healer")]
        public long LongestBowKillKitSupportingTeamHealer { get; set; }

        [JsonProperty("melee_kills_kit_supporting_team_healer")]
        public long MeleeKillsKitSupportingTeamHealer { get; set; }

        [JsonProperty("solo_knowledge")]
        public long SoloKnowledge { get; set; }

        [JsonProperty("soul_well_rares")]
        public long SoulWellRares { get; set; }

        [JsonProperty("mega_bridger")]
        public long MegaBridger { get; set; }

        [JsonProperty("arrows_hit_kit_enderchest_solo_enderchest")]
        public long ArrowsHitKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("arrows_shot_kit_enderchest_solo_enderchest")]
        public long ArrowsShotKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("bow_kills_kit_enderchest_solo_enderchest")]
        public long BowKillsKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("chests_opened_kit_enderchest_solo_enderchest")]
        public long ChestsOpenedKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("deaths_kit_enderchest_solo_enderchest")]
        public long DeathsKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("kills_kit_enderchest_solo_enderchest")]
        public long KillsKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("longest_bow_kill_kit_enderchest_solo_enderchest")]
        public long LongestBowKillKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("longest_bow_shot_kit_enderchest_solo_enderchest")]
        public long LongestBowShotKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("losses_kit_enderchest_solo_enderchest")]
        public long LossesKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("melee_kills_kit_enderchest_solo_enderchest")]
        public long MeleeKillsKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("most_kills_game_kit_enderchest_solo_enderchest")]
        public long MostKillsGameKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("survived_players_kit_enderchest_solo_enderchest")]
        public long SurvivedPlayersKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("time_played_kit_enderchest_solo_enderchest")]
        public long TimePlayedKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("void_kills_kit_enderchest_solo_enderchest")]
        public long VoidKillsKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("games_kit_enderchest_solo_enderchest")]
        public long GamesKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("arrows_hit_team")]
        public long ArrowsHitTeam { get; set; }

        [JsonProperty("arrows_shot_team")]
        public long ArrowsShotTeam { get; set; }

        [JsonProperty("games_team")]
        public long GamesTeam { get; set; }

        [JsonProperty("assists_kit_enderchest_solo_enderchest")]
        public long AssistsKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("melee_kills_team")]
        public long MeleeKillsTeam { get; set; }

        [JsonProperty("fastest_win_kit_enderchest_solo_enderchest")]
        public long FastestWinKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("killstreak_kit_enderchest_solo_enderchest")]
        public long KillstreakKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("wins_kit_enderchest_solo_enderchest")]
        public long WinsKitEnderchestSoloEnderchest { get; set; }

        [JsonProperty("chests_opened_kit_advanced_solo_knight")]
        public long ChestsOpenedKitAdvancedSoloKnight { get; set; }

        [JsonProperty("deaths_kit_advanced_solo_knight")]
        public long DeathsKitAdvancedSoloKnight { get; set; }

        [JsonProperty("games_kit_advanced_solo_knight")]
        public long GamesKitAdvancedSoloKnight { get; set; }

        [JsonProperty("losses_kit_advanced_solo_knight")]
        public long LossesKitAdvancedSoloKnight { get; set; }

        [JsonProperty("time_played_kit_advanced_solo_knight")]
        public long TimePlayedKitAdvancedSoloKnight { get; set; }

        [JsonProperty("chests_opened_kit_supporting_team_rookie")]
        public long ChestsOpenedKitSupportingTeamRookie { get; set; }

        [JsonProperty("deaths_kit_supporting_team_rookie")]
        public long DeathsKitSupportingTeamRookie { get; set; }

        [JsonProperty("losses_kit_supporting_team_rookie")]
        public long LossesKitSupportingTeamRookie { get; set; }

        [JsonProperty("survived_players_kit_supporting_team_rookie")]
        public long SurvivedPlayersKitSupportingTeamRookie { get; set; }

        [JsonProperty("time_played_kit_supporting_team_rookie")]
        public long TimePlayedKitSupportingTeamRookie { get; set; }

        [JsonProperty("arrows_hit_kit_supporting_team_rookie")]
        public long ArrowsHitKitSupportingTeamRookie { get; set; }

        [JsonProperty("arrows_shot_kit_supporting_team_rookie")]
        public long ArrowsShotKitSupportingTeamRookie { get; set; }

        [JsonProperty("fastest_win_kit_supporting_team_rookie")]
        public long FastestWinKitSupportingTeamRookie { get; set; }

        [JsonProperty("games_kit_supporting_team_rookie")]
        public long GamesKitSupportingTeamRookie { get; set; }

        [JsonProperty("kills_kit_supporting_team_rookie")]
        public long KillsKitSupportingTeamRookie { get; set; }

        [JsonProperty("killstreak_kit_supporting_team_rookie")]
        public long KillstreakKitSupportingTeamRookie { get; set; }

        [JsonProperty("longest_bow_kill_kit_supporting_team_rookie")]
        public long LongestBowKillKitSupportingTeamRookie { get; set; }

        [JsonProperty("longest_bow_shot_kit_supporting_team_rookie")]
        public long LongestBowShotKitSupportingTeamRookie { get; set; }

        [JsonProperty("melee_kills_kit_supporting_team_rookie")]
        public long MeleeKillsKitSupportingTeamRookie { get; set; }

        [JsonProperty("most_kills_game_kit_supporting_team_rookie")]
        public long MostKillsGameKitSupportingTeamRookie { get; set; }

        [JsonProperty("void_kills_kit_supporting_team_rookie")]
        public long VoidKillsKitSupportingTeamRookie { get; set; }

        [JsonProperty("wins_kit_supporting_team_rookie")]
        public long WinsKitSupportingTeamRookie { get; set; }

        [JsonProperty("assists_kit_supporting_team_rookie")]
        public long AssistsKitSupportingTeamRookie { get; set; }

        [JsonProperty("assists_kit_defending_team_frog")]
        public long AssistsKitDefendingTeamFrog { get; set; }

        [JsonProperty("chests_opened_kit_defending_team_frog")]
        public long ChestsOpenedKitDefendingTeamFrog { get; set; }

        [JsonProperty("deaths_kit_defending_team_frog")]
        public long DeathsKitDefendingTeamFrog { get; set; }

        [JsonProperty("losses_kit_defending_team_frog")]
        public long LossesKitDefendingTeamFrog { get; set; }

        [JsonProperty("survived_players_kit_defending_team_frog")]
        public long SurvivedPlayersKitDefendingTeamFrog { get; set; }

        [JsonProperty("time_played_kit_defending_team_frog")]
        public long TimePlayedKitDefendingTeamFrog { get; set; }

        [JsonProperty("arrows_shot_kit_defending_team_frog")]
        public long ArrowsShotKitDefendingTeamFrog { get; set; }
    }

    public partial class HeadCollection
    {
        [JsonProperty("recent")]
        public Prestigious[] Recent { get; set; }

        [JsonProperty("prestigious")]
        public Prestigious[] Prestigious { get; set; }
    }

    public partial class Prestigious
    {
        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("sacrifice")]
        public string Sacrifice { get; set; }
    }

    public partial class SpeedUhc
    {
        [JsonProperty("killstreak")]
        public long Killstreak { get; set; }

        [JsonProperty("activeKit_NORMAL")]
        public string ActiveKitNormal { get; set; }

        [JsonProperty("blocks_broken")]
        public long BlocksBroken { get; set; }

        [JsonProperty("blocks_placed")]
        public long BlocksPlaced { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("deaths_kit_basic_normal_default")]
        public long DeathsKitBasicNormalDefault { get; set; }

        [JsonProperty("deaths_mastery_wild_specialist")]
        public long DeathsMasteryWildSpecialist { get; set; }

        [JsonProperty("deaths_normal")]
        public long DeathsNormal { get; set; }

        [JsonProperty("deaths_solo")]
        public long DeathsSolo { get; set; }

        [JsonProperty("deaths_solo_normal")]
        public long DeathsSoloNormal { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("losses_kit_basic_normal_default")]
        public long LossesKitBasicNormalDefault { get; set; }

        [JsonProperty("losses_mastery_wild_specialist")]
        public long LossesMasteryWildSpecialist { get; set; }

        [JsonProperty("losses_normal")]
        public long LossesNormal { get; set; }

        [JsonProperty("losses_solo")]
        public long LossesSolo { get; set; }

        [JsonProperty("losses_solo_normal")]
        public long LossesSoloNormal { get; set; }

        [JsonProperty("quits")]
        public long Quits { get; set; }

        [JsonProperty("survived_players")]
        public long SurvivedPlayers { get; set; }

        [JsonProperty("survived_players_kit_basic_normal_default")]
        public long SurvivedPlayersKitBasicNormalDefault { get; set; }

        [JsonProperty("survived_players_normal")]
        public long SurvivedPlayersNormal { get; set; }

        [JsonProperty("survived_players_solo")]
        public long SurvivedPlayersSolo { get; set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; set; }

        [JsonProperty("highestKillstreak")]
        public long HighestKillstreak { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("games_kit_basic_normal_default")]
        public long GamesKitBasicNormalDefault { get; set; }

        [JsonProperty("games_normal")]
        public long GamesNormal { get; set; }

        [JsonProperty("games_solo")]
        public long GamesSolo { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_kit_basic_normal_default")]
        public long KillsKitBasicNormalDefault { get; set; }

        [JsonProperty("kills_mastery_wild_specialist")]
        public long KillsMasteryWildSpecialist { get; set; }

        [JsonProperty("kills_monthly_b")]
        public long KillsMonthlyB { get; set; }

        [JsonProperty("kills_normal")]
        public long KillsNormal { get; set; }

        [JsonProperty("kills_solo")]
        public long KillsSolo { get; set; }

        [JsonProperty("kills_solo_normal")]
        public long KillsSoloNormal { get; set; }

        [JsonProperty("kills_weekly_a")]
        public long KillsWeeklyA { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("score_kit_basic_normal_default")]
        public long ScoreKitBasicNormalDefault { get; set; }

        [JsonProperty("score_normal")]
        public long ScoreNormal { get; set; }

        [JsonProperty("score_solo")]
        public long ScoreSolo { get; set; }
    }

    public partial class SuperSmash
    {
        [JsonProperty("lastLevel_THE_BULK")]
        public long LastLevelTheBulk { get; set; }

        [JsonProperty("active_class")]
        public string ActiveClass { get; set; }

        [JsonProperty("class_stats")]
        public ClassStats ClassStats { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; set; }

        [JsonProperty("damage_dealt_teams")]
        public long DamageDealtTeams { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("deaths_teams")]
        public long DeathsTeams { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("games_teams")]
        public long GamesTeams { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("losses_teams")]
        public long LossesTeams { get; set; }

        [JsonProperty("smashed")]
        public long Smashed { get; set; }

        [JsonProperty("smashed_teams")]
        public long SmashedTeams { get; set; }

        [JsonProperty("win_streak")]
        public long WinStreak { get; set; }

        [JsonProperty("lastLevel_BOTMUN")]
        public long LastLevelBotmun { get; set; }
    }

    public partial class ClassStats
    {
        [JsonProperty("BOTMUN")]
        public Botmun Botmun { get; set; }
    }

    public partial class Botmun
    {
        [JsonProperty("batarang")]
        public Batarang Batarang { get; set; }

        [JsonProperty("botmubile")]
        public Batarang Botmubile { get; set; }

        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; set; }

        [JsonProperty("damage_dealt_teams")]
        public long DamageDealtTeams { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("deaths_teams")]
        public long DeathsTeams { get; set; }

        [JsonProperty("flaming_desert_eagle")]
        public FlamingDesertEagle FlamingDesertEagle { get; set; }

        [JsonProperty("games")]
        public long Games { get; set; }

        [JsonProperty("games_teams")]
        public long GamesTeams { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("losses_teams")]
        public long LossesTeams { get; set; }

        [JsonProperty("smashed")]
        public long Smashed { get; set; }

        [JsonProperty("smashed_teams")]
        public long SmashedTeams { get; set; }
    }

    public partial class Batarang
    {
        [JsonProperty("damage_dealt")]
        public long DamageDealt { get; set; }

        [JsonProperty("damage_dealt_teams")]
        public long DamageDealtTeams { get; set; }
    }

    public partial class FlamingDesertEagle
    {
        [JsonProperty("smashed")]
        public long Smashed { get; set; }

        [JsonProperty("smashed_teams")]
        public long SmashedTeams { get; set; }
    }

    public partial class TntGames
    {
        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("new_pvprun_double_jumps")]
        public long NewPvprunDoubleJumps { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("new_spleef_repulsor")]
        public long NewSpleefRepulsor { get; set; }

        [JsonProperty("new_witherwizard_explode")]
        public long NewWitherwizardExplode { get; set; }

        [JsonProperty("new_tntrun_double_jumps")]
        public long NewTntrunDoubleJumps { get; set; }

        [JsonProperty("new_witherwizard_regen")]
        public long NewWitherwizardRegen { get; set; }

        [JsonProperty("new_tntag_speedy")]
        public long NewTntagSpeedy { get; set; }

        [JsonProperty("new_icewizard_regen")]
        public long NewIcewizardRegen { get; set; }

        [JsonProperty("new_kineticwizard_explode")]
        public long NewKineticwizardExplode { get; set; }

        [JsonProperty("new_kineticwizard_regen")]
        public long NewKineticwizardRegen { get; set; }

        [JsonProperty("new_icewizard_explode")]
        public long NewIcewizardExplode { get; set; }

        [JsonProperty("new_firewizard_regen")]
        public long NewFirewizardRegen { get; set; }

        [JsonProperty("new_firewizard_explode")]
        public long NewFirewizardExplode { get; set; }

        [JsonProperty("new_bloodwizard_regen")]
        public long NewBloodwizardRegen { get; set; }

        [JsonProperty("new_spleef_double_jumps")]
        public long NewSpleefDoubleJumps { get; set; }

        [JsonProperty("new_bloodwizard_explode")]
        public long NewBloodwizardExplode { get; set; }

        [JsonProperty("new_spleef_tripleshot")]
        public long NewSpleefTripleshot { get; set; }

        [JsonProperty("run_potions_splashed_on_players")]
        public long RunPotionsSplashedOnPlayers { get; set; }

        [JsonProperty("record_pvprun")]
        public long RecordPvprun { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths_pvprun")]
        public long DeathsPvprun { get; set; }

        [JsonProperty("winstreak")]
        public long Winstreak { get; set; }

        [JsonProperty("record_tntrun")]
        public long RecordTntrun { get; set; }

        [JsonProperty("deaths_tntrun")]
        public long DeathsTntrun { get; set; }

        [JsonProperty("kills_tntag")]
        public long KillsTntag { get; set; }
    }

    public partial class Uhc
    {
        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("saved_stats")]
        public bool SavedStats { get; set; }

        [JsonProperty("clearup_achievement")]
        public bool ClearupAchievement { get; set; }

        [JsonProperty("deaths_solo")]
        public long DeathsSolo { get; set; }
    }

    public partial class VampireZ
    {
        [JsonProperty("updated_stats")]
        public bool UpdatedStats { get; set; }

        [JsonProperty("most_vampire_kills_new")]
        public long MostVampireKillsNew { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("human_deaths")]
        public long HumanDeaths { get; set; }

        [JsonProperty("vampire_kills")]
        public long VampireKills { get; set; }

        [JsonProperty("zombie_kills")]
        public long ZombieKills { get; set; }
    }

    public partial class Walls3
    {
        [JsonProperty("classes")]
        public Classes Classes { get; set; }

        [JsonProperty("packages")]
        public string[] Packages { get; set; }

        [JsonProperty("activations")]
        public long Activations { get; set; }

        [JsonProperty("activations_standard")]
        public long ActivationsStandard { get; set; }

        [JsonProperty("arrows_fired")]
        public long ArrowsFired { get; set; }

        [JsonProperty("arrows_fired_standard")]
        public long ArrowsFiredStandard { get; set; }

        [JsonProperty("arrows_hit")]
        public long ArrowsHit { get; set; }

        [JsonProperty("arrows_hit_standard")]
        public long ArrowsHitStandard { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("assists_standard")]
        public long AssistsStandard { get; set; }

        [JsonProperty("blocks_broken")]
        public long BlocksBroken { get; set; }

        [JsonProperty("blocks_broken_standard")]
        public long BlocksBrokenStandard { get; set; }

        [JsonProperty("blocks_placed")]
        public long BlocksPlaced { get; set; }

        [JsonProperty("blocks_placed_preparation")]
        public long BlocksPlacedPreparation { get; set; }

        [JsonProperty("blocks_placed_preparation_standard")]
        public long BlocksPlacedPreparationStandard { get; set; }

        [JsonProperty("blocks_placed_standard")]
        public long BlocksPlacedStandard { get; set; }

        [JsonProperty("coins")]
        public long Coins { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("deaths_standard")]
        public long DeathsStandard { get; set; }

        [JsonProperty("defender_assists")]
        public long DefenderAssists { get; set; }

        [JsonProperty("defender_assists_standard")]
        public long DefenderAssistsStandard { get; set; }

        [JsonProperty("defender_kills")]
        public long DefenderKills { get; set; }

        [JsonProperty("defender_kills_standard")]
        public long DefenderKillsStandard { get; set; }

        [JsonProperty("enemies_hit")]
        public long EnemiesHit { get; set; }

        [JsonProperty("enemies_hit_standard")]
        public long EnemiesHitStandard { get; set; }

        [JsonProperty("final_deaths")]
        public long FinalDeaths { get; set; }

        [JsonProperty("final_deaths_standard")]
        public long FinalDeathsStandard { get; set; }

        [JsonProperty("food_eaten")]
        public long FoodEaten { get; set; }

        [JsonProperty("food_eaten_standard")]
        public long FoodEatenStandard { get; set; }

        [JsonProperty("games_played")]
        public long GamesPlayed { get; set; }

        [JsonProperty("games_played_standard")]
        public long GamesPlayedStandard { get; set; }

        [JsonProperty("golden_apples_eaten")]
        public long GoldenApplesEaten { get; set; }

        [JsonProperty("golden_apples_eaten_standard")]
        public long GoldenApplesEatenStandard { get; set; }

        [JsonProperty("hunter_a_activations")]
        public long HunterAActivations { get; set; }

        [JsonProperty("hunter_a_activations_standard")]
        public long HunterAActivationsStandard { get; set; }

        [JsonProperty("hunter_activations")]
        public long HunterActivations { get; set; }

        [JsonProperty("hunter_activations_standard")]
        public long HunterActivationsStandard { get; set; }

        [JsonProperty("hunter_arrows_fired")]
        public long HunterArrowsFired { get; set; }

        [JsonProperty("hunter_arrows_fired_standard")]
        public long HunterArrowsFiredStandard { get; set; }

        [JsonProperty("hunter_arrows_hit")]
        public long HunterArrowsHit { get; set; }

        [JsonProperty("hunter_arrows_hit_standard")]
        public long HunterArrowsHitStandard { get; set; }

        [JsonProperty("hunter_assists")]
        public long HunterAssists { get; set; }

        [JsonProperty("hunter_assists_standard")]
        public long HunterAssistsStandard { get; set; }

        [JsonProperty("hunter_b_assists")]
        public long HunterBAssists { get; set; }

        [JsonProperty("hunter_b_assists_standard")]
        public long HunterBAssistsStandard { get; set; }

        [JsonProperty("hunter_b_defender_assists")]
        public long HunterBDefenderAssists { get; set; }

        [JsonProperty("hunter_b_defender_assists_standard")]
        public long HunterBDefenderAssistsStandard { get; set; }

        [JsonProperty("hunter_b_enemies_hit")]
        public long HunterBEnemiesHit { get; set; }

        [JsonProperty("hunter_b_enemies_hit_standard")]
        public long HunterBEnemiesHitStandard { get; set; }

        [JsonProperty("hunter_b_total_kills")]
        public long HunterBTotalKills { get; set; }

        [JsonProperty("hunter_b_total_kills_standard")]
        public long HunterBTotalKillsStandard { get; set; }

        [JsonProperty("hunter_blocks_broken")]
        public long HunterBlocksBroken { get; set; }

        [JsonProperty("hunter_blocks_broken_standard")]
        public long HunterBlocksBrokenStandard { get; set; }

        [JsonProperty("hunter_blocks_placed")]
        public long HunterBlocksPlaced { get; set; }

        [JsonProperty("hunter_blocks_placed_preparation")]
        public long HunterBlocksPlacedPreparation { get; set; }

        [JsonProperty("hunter_blocks_placed_preparation_standard")]
        public long HunterBlocksPlacedPreparationStandard { get; set; }

        [JsonProperty("hunter_blocks_placed_standard")]
        public long HunterBlocksPlacedStandard { get; set; }

        [JsonProperty("hunter_deaths")]
        public long HunterDeaths { get; set; }

        [JsonProperty("hunter_deaths_standard")]
        public long HunterDeathsStandard { get; set; }

        [JsonProperty("hunter_defender_assists")]
        public long HunterDefenderAssists { get; set; }

        [JsonProperty("hunter_defender_assists_standard")]
        public long HunterDefenderAssistsStandard { get; set; }

        [JsonProperty("hunter_defender_kills")]
        public long HunterDefenderKills { get; set; }

        [JsonProperty("hunter_defender_kills_standard")]
        public long HunterDefenderKillsStandard { get; set; }

        [JsonProperty("hunter_enemies_hit")]
        public long HunterEnemiesHit { get; set; }

        [JsonProperty("hunter_enemies_hit_standard")]
        public long HunterEnemiesHitStandard { get; set; }

        [JsonProperty("hunter_final_deaths")]
        public long HunterFinalDeaths { get; set; }

        [JsonProperty("hunter_final_deaths_standard")]
        public long HunterFinalDeathsStandard { get; set; }

        [JsonProperty("hunter_food_eaten")]
        public long HunterFoodEaten { get; set; }

        [JsonProperty("hunter_food_eaten_standard")]
        public long HunterFoodEatenStandard { get; set; }

        [JsonProperty("hunter_g_activations")]
        public long HunterGActivations { get; set; }

        [JsonProperty("hunter_g_activations_standard")]
        public long HunterGActivationsStandard { get; set; }

        [JsonProperty("hunter_games_played")]
        public long HunterGamesPlayed { get; set; }

        [JsonProperty("hunter_games_played_standard")]
        public long HunterGamesPlayedStandard { get; set; }

        [JsonProperty("hunter_golden_apples_eaten")]
        public long HunterGoldenApplesEaten { get; set; }

        [JsonProperty("hunter_golden_apples_eaten_standard")]
        public long HunterGoldenApplesEatenStandard { get; set; }

        [JsonProperty("hunter_iron_ore_broken")]
        public long HunterIronOreBroken { get; set; }

        [JsonProperty("hunter_iron_ore_broken_standard")]
        public long HunterIronOreBrokenStandard { get; set; }

        [JsonProperty("hunter_kills")]
        public long HunterKills { get; set; }

        [JsonProperty("hunter_kills_melee")]
        public long HunterKillsMelee { get; set; }

        [JsonProperty("hunter_kills_melee_standard")]
        public long HunterKillsMeleeStandard { get; set; }

        [JsonProperty("hunter_kills_standard")]
        public long HunterKillsStandard { get; set; }

        [JsonProperty("hunter_losses")]
        public long HunterLosses { get; set; }

        [JsonProperty("hunter_losses_standard")]
        public long HunterLossesStandard { get; set; }

        [JsonProperty("hunter_meters_fallen")]
        public long HunterMetersFallen { get; set; }

        [JsonProperty("hunter_meters_fallen_standard")]
        public long HunterMetersFallenStandard { get; set; }

        [JsonProperty("hunter_meters_walked")]
        public long HunterMetersWalked { get; set; }

        [JsonProperty("hunter_meters_walked_speed")]
        public long HunterMetersWalkedSpeed { get; set; }

        [JsonProperty("hunter_meters_walked_speed_standard")]
        public long HunterMetersWalkedSpeedStandard { get; set; }

        [JsonProperty("hunter_meters_walked_standard")]
        public long HunterMetersWalkedStandard { get; set; }

        [JsonProperty("hunter_time_played")]
        public long HunterTimePlayed { get; set; }

        [JsonProperty("hunter_time_played_standard")]
        public long HunterTimePlayedStandard { get; set; }

        [JsonProperty("hunter_total_deaths")]
        public long HunterTotalDeaths { get; set; }

        [JsonProperty("hunter_total_deaths_standard")]
        public long HunterTotalDeathsStandard { get; set; }

        [JsonProperty("hunter_total_kills")]
        public long HunterTotalKills { get; set; }

        [JsonProperty("hunter_total_kills_standard")]
        public long HunterTotalKillsStandard { get; set; }

        [JsonProperty("hunter_treasures_found")]
        public long HunterTreasuresFound { get; set; }

        [JsonProperty("hunter_treasures_found_standard")]
        public long HunterTreasuresFoundStandard { get; set; }

        [JsonProperty("hunter_wither_damage")]
        public long HunterWitherDamage { get; set; }

        [JsonProperty("hunter_wither_damage_standard")]
        public long HunterWitherDamageStandard { get; set; }

        [JsonProperty("hunter_wood_chopped")]
        public long HunterWoodChopped { get; set; }

        [JsonProperty("hunter_wood_chopped_standard")]
        public long HunterWoodChoppedStandard { get; set; }

        [JsonProperty("iron_ore_broken")]
        public long IronOreBroken { get; set; }

        [JsonProperty("iron_ore_broken_standard")]
        public long IronOreBrokenStandard { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_melee")]
        public long KillsMelee { get; set; }

        [JsonProperty("kills_melee_standard")]
        public long KillsMeleeStandard { get; set; }

        [JsonProperty("kills_standard")]
        public long KillsStandard { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("losses_standard")]
        public long LossesStandard { get; set; }

        [JsonProperty("meters_fallen")]
        public long MetersFallen { get; set; }

        [JsonProperty("meters_fallen_standard")]
        public long MetersFallenStandard { get; set; }

        [JsonProperty("meters_walked")]
        public long MetersWalked { get; set; }

        [JsonProperty("meters_walked_speed")]
        public long MetersWalkedSpeed { get; set; }

        [JsonProperty("meters_walked_speed_standard")]
        public long MetersWalkedSpeedStandard { get; set; }

        [JsonProperty("meters_walked_standard")]
        public long MetersWalkedStandard { get; set; }

        [JsonProperty("time_played")]
        public long TimePlayed { get; set; }

        [JsonProperty("time_played_standard")]
        public long TimePlayedStandard { get; set; }

        [JsonProperty("total_deaths")]
        public long TotalDeaths { get; set; }

        [JsonProperty("total_deaths_standard")]
        public long TotalDeathsStandard { get; set; }

        [JsonProperty("total_kills")]
        public long TotalKills { get; set; }

        [JsonProperty("total_kills_standard")]
        public long TotalKillsStandard { get; set; }

        [JsonProperty("treasures_found")]
        public long TreasuresFound { get; set; }

        [JsonProperty("treasures_found_standard")]
        public long TreasuresFoundStandard { get; set; }

        [JsonProperty("wither_damage")]
        public long WitherDamage { get; set; }

        [JsonProperty("wither_damage_standard")]
        public long WitherDamageStandard { get; set; }

        [JsonProperty("wood_chopped")]
        public long WoodChopped { get; set; }

        [JsonProperty("wood_chopped_standard")]
        public long WoodChoppedStandard { get; set; }
    }

    public partial class Classes
    {
        [JsonProperty("herobrine")]
        public Enderman Herobrine { get; set; }

        [JsonProperty("skeleton")]
        public Enderman Skeleton { get; set; }

        [JsonProperty("enderman")]
        public Enderman Enderman { get; set; }

        [JsonProperty("zombie")]
        public Enderman Zombie { get; set; }
    }

    public partial class Enderman
    {
        [JsonProperty("skill_level_d")]
        public long SkillLevelD { get; set; }

        [JsonProperty("skill_level_dChecked5")]
        public bool SkillLevelDChecked5 { get; set; }

        [JsonProperty("unlocked")]
        public bool Unlocked { get; set; }

        [JsonProperty("checked4")]
        public bool Checked4 { get; set; }
    }

    public partial class VanityMeta
    {
        [JsonProperty("packages")]
        public string[] Packages { get; set; }
    }
}

