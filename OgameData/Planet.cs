using System.Collections.Generic;

namespace OgameData
{
    public class Planet
    {
        #region Properties
        public string PlanetName { get; set; }
        public int PlanetID { get; set; }
        public Position Position { get; set; }
        public int Temperature { get; set; }
        public int Diameter { get; set; }
        public Resources Resources { get; set; }
        public Dictionary<Item, Building> Buildings { get; set; }
        public Dictionary<Item, int> Fleet { get; set; }
        public Dictionary<Item, int> Defences { get; set; }
        #endregion

        public Planet(int id = 0, string name = "Kolonia")
        {
            PlanetName = name;
            PlanetID = id;
            Position = new Position(GameHandler.GeneratePosition());
            Temperature = GameHandler.RandomTemperature();
            Diameter = GameHandler.RandomPlanetSize();
            Resources = new Resources(500.0, 500.0, 0.0);

            Buildings = new Dictionary<Item, Building>()
            {
                { Item.METAL_MINE, new Building() },
                { Item.CRYSTAL_MINE, new Building() },
                { Item.DEUTERIUM_SYNTHESIZER, new Building() },
                { Item.SOLAR_PLANT, new Building() },
                { Item.FUSION_REACTOR, new Building() },
                { Item.METAL_STORAGE, new Building() },
                { Item.CRYSTAL_STORAGE, new Building() },
                { Item.DEUTERIUM_TANK, new Building() },
                { Item.ROBOTICS_FACTORY, new Building() },
                { Item.NANITE_FACTORY, new Building() },
                { Item.SHIPYARD, new Building() },
                { Item.RESEARCH_LAB, new Building() },
                { Item.TERRAFORMER, new Building() },
                { Item.MISSILE_SILO, new Building() },
                { Item.SPACE_DOCK, new Building() },
                { Item.LUNAR_BASE, new Building() },
                { Item.SENSOR_PHALANX, new Building() },
                { Item.JUMP_GATE, new Building() }
            };
            Fleet = new Dictionary<Item, int>()
            {
                { Item.SMALL_CARGO, 0 },
                { Item.LARGE_CARGO, 0 },
                { Item.COLONY_SHIP, 0 },
                { Item.RECYCLER, 0 },
                { Item.ESPIONAGE_PROBE, 0 },

                { Item.LIGHT_FIGHTER, 0 },
                { Item.HEAVY_FIGHTER, 0 },
                { Item.CRUISER, 0 },
                { Item.BATTLESHIP, 0 },
                { Item.BATTLECRUISER, 0 },
                { Item.BOMBER, 0 },
                { Item.DESTROYER, 0 },
                { Item.DEATHSTAR, 0 },

                { Item.REAPER, 0 },
                { Item.PATHFINDER, 0 }
            };
            Defences = new Dictionary<Item, int>()
            {
                { Item.ROCKER_LAUNCHER, 0 },
                { Item.LIGHT_LASER, 0 },
                { Item.HEAVY_FIGHTER, 0 },
                { Item.GAUSS_CANNON, 0 },
                { Item.ION_CANNON, 0 },
                { Item.PLASMA_TURRET, 0 },

                { Item.SMALL_SHIELD_DOME, 0 },
                { Item.LARGE_SHIELD_DOME, 0 },

                { Item.ANTI_BALLISTIC_MISSILE, 0 },
                { Item.INTERPLANETARY_MISSILE, 0 },

                { Item.SOLAR_SATELLITE, 0 },
                { Item.CRAWLER, 0 }
            };
        }

        #region Methods
        public void UpgradeBuilding(Item item)
        {
            Resources nextLevel = GameHandler.UpgradeCost(item, Buildings[item].Level + 1);
            Buildings[item].Level++;
            Buildings[item].TotalCost.Add(nextLevel);
            Buildings[item].IsProcessing = false;
        }
        #endregion
    }
}
