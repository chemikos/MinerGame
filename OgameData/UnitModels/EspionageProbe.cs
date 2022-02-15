namespace OgameData.UnitModels
{
    public class EspionageProbe : Ship
    {
        public EspionageProbe() : base(Item.ESPIONAGE_PROBE)
        {
            Speed = GameData.TECHNICAL_DATA[Item.ESPIONAGE_PROBE][Item.SPEED_COMBUSTION_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.COMBUSTION_DRIVE] * OGame.Researches.CombustionDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.ESPIONAGE_PROBE][Item.FUEL_USAGE_COMBUSTION_DRIVE];
        }
    }
}
