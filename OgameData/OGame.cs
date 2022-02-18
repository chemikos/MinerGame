using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OgameData
{
    public class OGame
    {
        [JsonProperty("GameSpeed")]
        public static int GameSpeed = 1;

        [JsonProperty("Researches")]
        public static Dictionary<Item, Upgradeable> Researches = new()
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
        public static bool[,,] Positions = new bool[9, 99, 9];

        public string GameName { get; set; }
        public DateTime GameStart { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<Planet> Planets { get; set; }
        public bool IsResearchInProgress { get; set; }
        public OGame(string name)
        {
            GameName = name;
            GameStart = LastUpdate = DateTime.Now;
            Planets = new List<Planet>()
            {
                new Planet("Planeta matka"),
                new Planet(),
                new Planet(),
                new Planet()
            };
            IsResearchInProgress = false;
        }

        #region Private methods
        public static void UpgradeResearch(Item item)
        {
            Resources nextLevel = GameHandler.UpgradeCost(item, Researches[item].Level + 1);
            Researches[item].Level++;
            Researches[item].TotalCost.Add(nextLevel);
        }
        #endregion

        #region Resource Update
        public void UpdateResources(DateTime newLastUpdate)
        {
            TimeSpan duration = newLastUpdate - LastUpdate;

            foreach (Planet p in Planets)
            {
                Resources production = GameHandler.PlanetProduction(p);
                production.Multiply(duration.TotalSeconds / 3600);

                p.Resources.Add(production);
            }
        }
        #endregion


    }
}
