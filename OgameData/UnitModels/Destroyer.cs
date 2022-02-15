namespace OgameData.UnitModels
{
    public class Destroyer : Ship
    {
        public Destroyer() : base(Item.DESTROYER)
        {
            Speed = GameData.TECHNICAL_DATA[Item.DESTROYER][Item.SPEED_HYPERSPACE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_DRIVE] * OGame.Researches.HyperspaceDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.DESTROYER][Item.FUEL_USAGE_HYPERSPACE_DRIVE];
        }
    }
}
