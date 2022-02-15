namespace OgameData.UnitModels
{
    public class Bomber : Ship
    {
        public Bomber() : base(Item.BOMBER)
        {
            if (OGame.Researches.HyperspaceDrive.Level >= 8)
            {
                Speed = GameData.TECHNICAL_DATA[Item.BOMBER][Item.SPEED_HYPERSPACE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_DRIVE] * OGame.Researches.HyperspaceDrive.Level);
                FuelUsage = GameData.TECHNICAL_DATA[Item.BOMBER][Item.FUEL_USAGE_HYPERSPACE_DRIVE];
            }
            else
            {
                Speed = GameData.TECHNICAL_DATA[Item.BOMBER][Item.SPEED_IMPULSE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.IMPULSE_DRIVE] * OGame.Researches.ImpulseDrive.Level);
                FuelUsage = GameData.TECHNICAL_DATA[Item.BOMBER][Item.FUEL_USAGE_IMPULSE_DRIVE];
            }
        }
    }
}
