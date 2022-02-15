namespace OgameData.UnitModels
{
    public class Battlecruiser : Ship
    {
        public Battlecruiser() : base(Item.BATTLECRUISER)
        {
            Speed = GameData.TECHNICAL_DATA[Item.BATTLECRUISER][Item.SPEED_HYPERSPACE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_DRIVE] * OGame.Researches.HyperspaceDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.BATTLECRUISER][Item.FUEL_USAGE_HYPERSPACE_DRIVE];
        }
    }
}
