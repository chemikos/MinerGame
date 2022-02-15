namespace OgameData.UnitModels
{
    public class LargeCargo : Ship
    {
        public LargeCargo() : base(Item.LARGE_CARGO)
        {
            Speed = GameData.TECHNICAL_DATA[Item.LARGE_CARGO][Item.SPEED_COMBUSTION_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.COMBUSTION_DRIVE] * OGame.Researches.CombustionDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.LARGE_CARGO][Item.FUEL_USAGE_COMBUSTION_DRIVE];
        }
    }
}
