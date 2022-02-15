namespace OgameData.UnitModels
{
    public class LightFighter : Ship
    {
        public LightFighter() : base(Item.LIGHT_FIGHTER)
        {
            Speed = GameData.TECHNICAL_DATA[Item.LIGHT_FIGHTER][Item.SPEED_COMBUSTION_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.COMBUSTION_DRIVE] * OGame.Researches.CombustionDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.LIGHT_FIGHTER][Item.FUEL_USAGE_COMBUSTION_DRIVE];
        }
    }
}
