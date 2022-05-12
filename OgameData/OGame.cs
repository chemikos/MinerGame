using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OgameData
{
    public class OGame
    {
        [JsonProperty("GameSpeed")]
        public static int GameSpeed = 1;

        [JsonProperty("Researches")]
        public static Dictionary<Item, Research> Researches = new()
        {
            { Item.COMBUSTION_DRIVE, new Research() },
            { Item.IMPULSE_DRIVE, new Research() },
            { Item.HYPERSPACE_DRIVE, new Research() },

            { Item.WEAPONS_TECHNOLOGY, new Research() },
            { Item.SHIELDING_TECHNOLOGY, new Research() },
            { Item.ARMOUR_TECHNOLOGY, new Research() },

            { Item.ENERGY_TECHNOLOGY, new Research() },
            { Item.LASER_TECHNOLOGY, new Research() },
            { Item.ION_TECHNOLOGY, new Research() },
            { Item.HYPERSPACE_TECHNOLOGY, new Research() },
            { Item.PLASMA_TECHNOLOGY, new Research() },

            { Item.ESPIONAGE_TECHNOLOGY, new Research() },
            { Item.COMPUTER_TECHNOLOGY, new Research() },
            { Item.ASTROPHISICS, new Research() },
            { Item.IRN, new Research() },

            { Item.GRAVITON_TECHNOLOGY, new Research() }
        };

        [JsonProperty("Positions")]
        public static List<Position> Positions = new();

        [JsonProperty("TimeEvents")]
        public static List<TimeEvent> TimeEvents = new();

        public string GameName { get; set; }
        public DateTime GameStart { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<Planet> Planets { get; set; }

        public OGame(string name)
        {
            GameName = name;
            GameStart = LastUpdate = DateTime.Now;
            Planets = new List<Planet>()
            {
                new Planet(1, "P1")
            };
        }

        public static void UpgradeResearch(Item item)
        {
            Resources nextLevel = GameHandler.UpgradeCost(item, Researches[item].Level + 1);
            Researches[item].Level++;
            Researches[item].TotalCost.Add(nextLevel);
            Researches[item].IsProcessing = false;
        }

        #region Resource Update
        public void UpdateResources(DateTime newLastUpdate)
        {
            TimeSpan duration = newLastUpdate - LastUpdate;

            foreach (Planet p in Planets)
            {
                UpdateResourcesStorageLimit(p, duration);
            }

            LastUpdate = newLastUpdate;
        }

        private void UpdateResourcesStorageLimit(Planet p, TimeSpan duration)
        {
            // zakomentowany kod służy do ograniczenia wydobycia do pojemności magazynów
            // wyłączyłem to, bo tak

            Resources production = GameHandler.PlanetProduction(p);
            production.Multiply(duration.TotalSeconds / 3600);

            double metalStorage = GameHandler.StorageCapacity(p.Buildings[Item.METAL_STORAGE].Level);
            if (p.Resources.Metal < metalStorage)
            {
                p.Resources.Metal += production.Metal;
                if (p.Resources.Metal > metalStorage)
                {
                    p.Resources.Metal = metalStorage;
                }
            }

            double crystalStorage = GameHandler.StorageCapacity(p.Buildings[Item.CRYSTAL_STORAGE].Level);
            if (p.Resources.Crystal < crystalStorage)
            {
                p.Resources.Crystal += production.Crystal;
                if (p.Resources.Crystal > crystalStorage)
                {
                    p.Resources.Crystal = crystalStorage;
                }
            }

            double deuteriumStorage = GameHandler.StorageCapacity(p.Buildings[Item.DEUTERIUM_TANK].Level);
            if (p.Resources.Deuterium < deuteriumStorage)
            {
                p.Resources.Deuterium += production.Deuterium;
                if (p.Resources.Deuterium > deuteriumStorage)
                {
                    p.Resources.Deuterium = deuteriumStorage;
                }
            }
        }
        #endregion


    }
}
