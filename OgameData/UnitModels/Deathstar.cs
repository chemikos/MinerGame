namespace OgameData.UnitModels
{
    public class Deathstar : Ship
    {
        public Deathstar() : base(Item.DEATHSTAR)
        {
            Speed = GameData.TECHNICAL_DATA[Item.DEATHSTAR][Item.SPEED_HYPERSPACE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_DRIVE] * OGame.Researches.HyperspaceDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.DEATHSTAR][Item.FUEL_USAGE_HYPERSPACE_DRIVE];
        }
    }
}
