namespace OgameData.UnitModels
{
    public class Pathfinder : Ship
    {
        public Pathfinder() : base(Item.PATHFINDER)
        {
            Speed = GameData.TECHNICAL_DATA[Item.PATHFINDER][Item.SPEED_HYPERSPACE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_DRIVE] * OGame.Researches.HyperspaceDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.PATHFINDER][Item.FUEL_USAGE_HYPERSPACE_DRIVE];
        }
    }
}
