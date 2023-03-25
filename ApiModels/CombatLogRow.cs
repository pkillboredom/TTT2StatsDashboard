namespace TTT2StatsApi.Models
{
    public class CombatLogRow
    {
        public long DamageTime { get; set; }
        public string AttackerName { get; set; }
        public string AttackerSteamId { get; set; }
        public string VictimName { get; set; }
        public string VictimSteamId { get; set; }
        public double DamageDealt { get; set; }
        public double HealthRemaining { get; set; }
        public string Weapon { get; set; }
    }
}
