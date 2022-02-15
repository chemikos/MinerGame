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
        public static Researches Researches = new();

        public string GameName { get; set; }
        public Resources TotalResources { get; set; }
        public Production TotalProduction { get; set; }
        public DateTime GameStart { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<Planet> Planets { get; set; }

        public OGame(string name)
        {
            GameName = name;
            GameStart = LastUpdate = DateTime.Now;
            Planets = new List<Planet>()
            {
                new Planet("Planeta matka")
            };
            TotalResources = new Resources(500.0, 500.0, 0.0);
            TotalProduction = new Production();
        }

        public void UpdatePlanetsAndTotalResources(DateTime newUpdate)
        {
            TimeSpan duration = newUpdate - LastUpdate;
            Resources total = new();
            foreach (Planet p in Planets)
            {
                p.UpdatePlanetResources(duration);
                total.Add(p.Resources);
            }
            TotalResources = total;
            LastUpdate = newUpdate;
        }
        public void UpdateTotalProduction()
        {
            ResetTotalProduction();
            foreach(Planet p in Planets)
            {
                p.UpdatePlanetProduction();
                TotalProduction.Add(p.Production);
            }            
        }
        private void ResetTotalProduction()
        {
            TotalProduction.Basis.Reset();
            TotalProduction.Mines.Reset();
            TotalProduction.PlasmaTechnology.Reset();
            TotalProduction.Crawlers.Reset();
            TotalProduction.FusionReactorDeuteriumDemand = 0.0;
            TotalProduction.FusionReactorNextLevelDeuteriumDemand = 0.0;
        }

    }
}
