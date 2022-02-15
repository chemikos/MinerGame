namespace OgameData.UnitModels
{
    public class Battleship : Ship
    {
        public Battleship() : base(Item.BATTLESHIP)
        {
            Speed = GameData.TECHNICAL_DATA[Item.BATTLESHIP][Item.SPEED_HYPERSPACE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_DRIVE] * OGame.Researches.HyperspaceDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.BATTLESHIP][Item.FUEL_USAGE_HYPERSPACE_DRIVE];
        }
    }
}
