using OgameData.UnitModels;
using System.Collections.Generic;

namespace OgameData
{
    public class Fleet
    {
        public List<SmallCargo> SmallCargos { get; set; }
        public List<LargeCargo> LargeCargos { get; set; }
        public List<ColonyShip> ColonyShips { get; set; }
        public List<Recycler> Recyclers { get; set; }
        public List<EspionageProbe> EspionageProbes { get; set; }
        public List<LightFighter> LightFighters { get; set; }
        public List<HeavyFighter> HeavyFighters { get; set; }
        public List<Cruiser> Cruisers { get; set; }
        public List<Battleship> Battleships { get; set; }
        public List<Battlecruiser> Battlecruisers { get; set; }
        public List<Bomber> Bombers { get; set; }
        public List<Destroyer> Destroyers { get; set; }
        public List<Deathstar> Deathstars { get; set; }
        public List<Reaper> Reapers { get; set; }
        public List<Pathfinder> Pathfinders { get; set; }
        
        public Fleet()
        {
            SmallCargos = new List<SmallCargo>();
            LargeCargos = new List<LargeCargo>();
            ColonyShips = new List<ColonyShip>();
            Recyclers = new List<Recycler>();
            EspionageProbes = new List<EspionageProbe>();
            LightFighters = new List<LightFighter>();
            HeavyFighters = new List<HeavyFighter>();
            Cruisers = new List<Cruiser>();
            Battleships = new List<Battleship>();
            Battlecruisers = new List<Battlecruiser>();
            Bombers = new List<Bomber>();
            Destroyers = new List<Destroyer>();
            Deathstars = new List<Deathstar>();
            Reapers = new List<Reaper>();
            Pathfinders = new List<Pathfinder>();
        }
    }
}