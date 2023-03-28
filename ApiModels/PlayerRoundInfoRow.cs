namespace TTT2StatsApi.Models
{
    public class PlayerRoundInfoRow
    {
        public long RoundId { get; set; }
        public string SteamId { get; set; }
        public string FriendlyName { get; set; }
        public string PlayerRole { get; set; }
        public double StartingKarma { get; set; }
        public double EndingKarma { get; set; }
        public bool PlayerDied { get; set; }
        public string? DeathCause { get; set; }
        public bool? AirborneDeath { get; set; }
        public bool? HeadshotDeath { get; set; }
        public long? DeathTime { get; set; }
    }
}
