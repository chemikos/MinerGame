namespace OgameData.UnitModels
{
    public class Recycler : Ship
    {
        public Recycler() : base(Item.RECYCLER)
        {
            if (OGame.Researches.HyperspaceDrive.Level >= 15)
            {
                Speed = GameData.TECHNICAL_DATA[Item.RECYCLER][Item.SPEED_HYPERSPACE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_DRIVE] * OGame.Researches.HyperspaceDrive.Level);
                FuelUsage = GameData.TECHNICAL_DATA[Item.RECYCLER][Item.FUEL_USAGE_HYPERSPACE_DRIVE];
            }
            else if (OGame.Researches.ImpulseDrive.Level >= 17)
            {
                Speed = GameData.TECHNICAL_DATA[Item.RECYCLER][Item.SPEED_IMPULSE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.IMPULSE_DRIVE] * OGame.Researches.ImpulseDrive.Level);
                FuelUsage = GameData.TECHNICAL_DATA[Item.RECYCLER][Item.FUEL_USAGE_IMPULSE_DRIVE];
            }
            else
            {
                Speed = GameData.TECHNICAL_DATA[Item.RECYCLER][Item.SPEED_COMBUSTION_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.COMBUSTION_DRIVE] * OGame.Researches.CombustionDrive.Level);
                FuelUsage = GameData.TECHNICAL_DATA[Item.RECYCLER][Item.FUEL_USAGE_COMBUSTION_DRIVE];
            }
        }
    }
}
