namespace OgameData.UnitModels
{
    public class Reaper : Ship
    {
        public Reaper() : base(Item.REAPER)
        {
            Speed = GameData.TECHNICAL_DATA[Item.REAPER][Item.SPEED_HYPERSPACE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_DRIVE] * OGame.Researches.HyperspaceDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.REAPER][Item.FUEL_USAGE_HYPERSPACE_DRIVE];
        }
    }
}
