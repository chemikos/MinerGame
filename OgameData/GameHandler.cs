using System;
using System.Collections.Generic;
using System.Linq;

namespace OgameData
{
    public static class GameHandler
    {
        #region Miner byc moze
        //Funkcje dla Miner, nie dla OGame - hipotetyczny XD
        public static long MineProduction(Dictionary<string, double> mine, int level, int technology)
        {
            double production = mine["Production"] * level * Math.Pow(mine["ProductionFactor"] + 0.05 * technology, level);
            return (long) production;
        }
        public static long MineConsumption(Dictionary<string, double> mine, int level)
        {
            double consumption = mine["Consumption"] * level * Math.Pow(mine["ConsumptionFactor"], level);
            return (long) Math.Ceiling(consumption);
        }
        #endregion

        #region Ogame
        //production
        public static double PlasmaProduction(double mineProduction, Item resource, int plasma)
        {
            return Math.Floor(mineProduction * plasma * GameData.PLASMA_FACTOR[resource]);
        }
        
        public static double CrawlersProduction(double production, Item resource, int crawlers)
        {
            return Math.Floor(production * crawlers * GameData.CRAWLER_FACTOR[resource]);
        }
        
        public static double MetalMineProduction(int level, int speed)
        {
            const double PRODUCTION = 30.0;
            const double PRODUCTION_FACTOR = 1.1;
            return speed * Math.Floor(PRODUCTION * level * Math.Pow(PRODUCTION_FACTOR, level));
        }
        
        public static double MetalMineEnergyDemand(int level)
        {
            const double DEMAND = 10.0;
            const double DEMAND_FACTOR = 1.1;
            return Math.Ceiling(DEMAND * level * Math.Pow(DEMAND_FACTOR, level));
        }
        
        public static double CrystalMineProduction(int level, int speed)
        {
            const double PRODUCTION = 20.0;
            const double PRODUCTION_FACTOR = 1.1;
            return speed * Math.Floor(PRODUCTION * level * Math.Pow(PRODUCTION_FACTOR, level));
        }
        
        public static double CrystalMineEnergyDemand(int level)
        {
            const double DEMAND = 10.0;
            const double DEMAND_FACTOR = 1.1;
            return Math.Ceiling(DEMAND * level * Math.Pow(DEMAND_FACTOR, level));
        }
        
        public static double DeuteriumSynthesizerProduction(int level, int temperature, int speed)
        {
            const double PRODUCTION = 10.0;
            const double PRODUCTION_FACTOR = 1.1;
            return speed * Math.Floor(PRODUCTION * level * Math.Pow(PRODUCTION_FACTOR, level) * (1.44 - 0.004 * temperature));
        }
        
        public static double DeuteriumSynthesizerEnergyDemand(int level)
        {
            const double DEMAND = 20.0;
            const double DEMAND_FACTOR = 1.1;
            return Math.Ceiling(DEMAND * level * Math.Pow(DEMAND_FACTOR, level));
        }
        
        public static double SolarPlantProduction(int level)
        {
            const double PRODUCTION = 20.0;
            const double PRODUCTION_FACTOR = 1.1;
            return Math.Floor(PRODUCTION * level * Math.Pow(PRODUCTION_FACTOR, level));
        }
        
        public static double FusionReactorProduction(int level, int energyTechnology)
        {
            const double PRODUCTION = 30.0;
            const double PRODUCTION_FACTOR = 1.05;
            const double TECHNOLOGY_FACTOR = 0.01;
            return Math.Floor(PRODUCTION * level * Math.Pow(PRODUCTION_FACTOR + TECHNOLOGY_FACTOR * energyTechnology, level));
        }
        
        public static double FusionReactorDeuteriumDemand(int level)
        {
            const double DEMAND = 10.0;
            const double DEMAND_FACTOR = 1.1;
            return Math.Ceiling(DEMAND * level * Math.Pow(DEMAND_FACTOR, level));
        }
        
        public static double UpdateResources(TimeSpan duration, double production)
        {
            return (duration.TotalSeconds * production) / 3600;
        }
        public static double EnergyDemand(Item item, int level)
        {
            return Math.Ceiling(GameData.COST[item][Item.ENERGY] * Math.Pow(GameData.COST[item][Item.ENERGY_FACTOR], level - 1));
        }
        
        //upgrade cost
        public static Resources UpgradeCost(Item item, int level)
        {
            double metal = Math.Ceiling(GameData.COST[item][Item.METAL] * Math.Pow(GameData.COST[item][Item.FACTOR], level - 1));
            double crystal = Math.Ceiling(GameData.COST[item][Item.CRYSTAL] * Math.Pow(GameData.COST[item][Item.FACTOR], level - 1));
            double deuterium = Math.Ceiling(GameData.COST[item][Item.DEUTERIUM] * Math.Pow(GameData.COST[item][Item.FACTOR], level - 1));
            return new Resources(metal, crystal, deuterium);
        }
        
        //storage
        public static double StorageCapacity(int level, double basis = Math.E)
        {
            return Math.Truncate(2.5 * Math.Pow(basis, 20.0 * level / 33)) * 5000;
            //need to change 'basis' value into 4 or 5
        }

        //construct time
        public static TimeSpan BuildingTime(Resources cost, int robotics, int nanite, int speed)
        {
            //double seconds = Math.Ceiling(1.44 * (cost.Metal + cost.Crystal) / (speed * (robotics + 1) * Math.Pow(2, nanite)));
            //return TimeSpan.FromSeconds(seconds);
            return BuildingTime(cost.Metal, cost.Crystal, robotics, nanite, speed);
        }
        
        public static TimeSpan BuildingTime(double metal, double crystal, int robotics, int nanite, int speed)
        {
            double seconds = Math.Ceiling(1.44 * (metal + crystal) / (speed * (robotics + 1) * Math.Pow(2, nanite)));
            return TimeSpan.FromSeconds(seconds);
        }
        
        public static TimeSpan ConstructTime(Resources cost, int shipyard, int nanite, int speed)
        {
            //double seconds = Math.Ceiling(1.44 * (cost.Metal + cost.Crystal) / (speed * (shipyard + 1) * Math.Pow(2, nanite)));
            //return TimeSpan.FromSeconds(seconds);
            return ConstructTime(cost.Metal, cost.Crystal, shipyard, nanite, speed);
        }
        
        public static TimeSpan ConstructTime(double metal, double crystal, int shipyard, int nanite, int speed)
        {
            double seconds = Math.Ceiling(1.44 * (metal + crystal) / (speed * (shipyard + 1) * Math.Pow(2, nanite)));
            return TimeSpan.FromSeconds(seconds);
        }
        
        public static TimeSpan ResearchTime(Resources cost, int lablvl, int graviton, int speed)
        {
            //double seconds = Math.Ceiling(3.6 * (cost.Metal + cost.Crystal) / (speed * (lab + 1) * Math.Pow(2, technology)));
            //return TimeSpan.FromSeconds(seconds);
            return ResearchTime(cost.Metal, cost.Crystal, lablvl, graviton, speed);
        }
        
        public static TimeSpan ResearchTime(double metal, double crystal, int lablvl, int graviton, int speed)
        {
            double seconds = Math.Ceiling(3.6 * (metal + crystal) / (speed * (lablvl + 1) * Math.Pow(2, graviton)));
            return TimeSpan.FromSeconds(seconds);
        }
        
        //lab level
        public static int LabLevel(Planet planet, List<Planet> planets, int irn, int minLab)
        {
            int level = planet.Buildings.ResearchLab.Level;
            if (irn == 0)
            {
                return level;
            }

            var labs = planets  .Where(pl => !pl.Equals(planet))
                                .Where(pl => pl.Buildings.ResearchLab.Level >= minLab)
                                .OrderByDescending(pl => pl.Buildings.ResearchLab.Level)
                                .Select(pl => pl.Buildings.ResearchLab.Level)
                                .ToList();
            for(int i=0; i<irn && i<labs.Count; i++)
            {
                level += labs[i];
            }
            return level;
        }
        

        //planet fields
        public static int PlanetFields(Planet planet)
        {
            return (int)Math.Floor(Math.Pow(planet.Diameter / 1000.0, 2)) + (int)(5.5 * planet.Buildings.Terraformer.Level);
        }
        
        public static int PlanetFields(int diameter, int terraformer)
        {
            return (int)Math.Floor(Math.Pow(diameter / 1000.0, 2)) + (int)(5.5 * terraformer);
        }

        //temperature
        public static int RandomTemperature()
        {
            return new Random().Next(-130, -99);
        }

        //diameter
        public static int RandomPlanetSize()
        {
            return new Random().Next(14500, 16001);
        }
        #endregion
    }
}
