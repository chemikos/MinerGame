namespace OgameData.UnitModels
{
    public class HeavyFighter : Ship
    {
        public HeavyFighter() : base(Item.HEAVY_FIGHTER)
        {
            Speed = GameData.TECHNICAL_DATA[Item.HEAVY_FIGHTER][Item.SPEED_IMPULSE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.IMPULSE_DRIVE] * OGame.Researches.ImpulseDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.HEAVY_FIGHTER][Item.FUEL_USAGE_IMPULSE_DRIVE];
        }
    }
}
