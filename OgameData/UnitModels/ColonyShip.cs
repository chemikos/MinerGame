namespace OgameData.UnitModels
{
    public class ColonyShip : Ship
    {
        public ColonyShip() : base(Item.COLONY_SHIP)
        {
            Speed = GameData.TECHNICAL_DATA[Item.COLONY_SHIP][Item.SPEED_IMPULSE_DRIVE] * (1 + GameData.RESEARCH_EFFECT[Item.IMPULSE_DRIVE] * OGame.Researches.ImpulseDrive.Level);
            FuelUsage = GameData.TECHNICAL_DATA[Item.COLONY_SHIP][Item.FUEL_USAGE_IMPULSE_DRIVE];
        }
    }
}
