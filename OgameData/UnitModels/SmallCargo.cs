namespace OgameData.UnitModels
{
    public class SmallCargo : Ship
    {
        public SmallCargo() : base(Item.SMALL_CARGO)
        {
            if (OGame.Researches.ImpulseDrive.Level >= 5)
            {
                Speed = GameData.TECHNICAL_DATA[Item.SMALL_CARGO][Item.SPEED_IMPULSE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.IMPULSE_DRIVE] * OGame.Researches.ImpulseDrive.Level);
                FuelUsage = GameData.TECHNICAL_DATA[Item.SMALL_CARGO][Item.FUEL_USAGE_IMPULSE_DRIVE];
            }
            else
            {
                Speed = GameData.TECHNICAL_DATA[Item.SMALL_CARGO][Item.SPEED_COMBUSTION_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.COMBUSTION_DRIVE] * OGame.Researches.CombustionDrive.Level);
                FuelUsage = GameData.TECHNICAL_DATA[Item.SMALL_CARGO][Item.FUEL_USAGE_COMBUSTION_DRIVE];
            }
        }
    }
}
