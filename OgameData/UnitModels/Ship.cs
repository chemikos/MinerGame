using System;

namespace OgameData.UnitModels
{
    public abstract class Ship : UnitModel
    {
        public double CargoCapacity { get; set; }
        public double Speed { get; set; }
        public double FuelUsage { get; set; }
        
        public Ship(Item item) : base(item)
        {
            CargoCapacity = Math.Floor(GameData.TECHNICAL_DATA[item][Item.CARGO_CAPACITY] * (1 + GameData.RESEARCH_EFFECT[Item.HYPERSPACE_TECHNOLOGY] * OGame.Researches.HyperspaceTechnology.Level));
        }
    }
}