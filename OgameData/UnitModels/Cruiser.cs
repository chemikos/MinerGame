namespace OgameData.UnitModels
{
    public class Cruiser : Ship
    {
        public Cruiser() : base(Item.CRUISER)
        {
            Speed = GameData.TECHNICAL_DATA[Item.CRUISER][Item.SPEED_IMPULSE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.IMPULSE_DRIVE] * OGame.Researches.ImpulseDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.CRUISER][Item.FUEL_USAGE_IMPULSE_DRIVE];
        }
    }
}
