using System;
using System.Collections.Generic;
using System.Linq;

namespace OgameData
{
    public static class GameHandler
    {
        # region Production
        public static Resources PlanetProduction(Planet p)
        {
            return PlanetProduction(p.Buildings[Item.METAL_MINE].Level, p.Buildings[Item.CRYSTAL_MINE].Level,
                                    p.Buildings[Item.DEUTERIUM_SYNTHESIZER].Level, p.Defences[Item.CRAWLER],
                                    p.Temperature, p.Buildings[Item.FUSION_REACTOR].Level);
        }
        
        public static Resources PlanetProduction(int metalMineLevel, int crystalMineLevel, int deuteriumSynthesizerLevel,
                                                 double crawlers, int temperature, int fusionReactorLevel)
        {
            double metal = MetalProduction(metalMineLevel, crawlers);
            double crystal = CrystalProduction(crystalMineLevel, crawlers);
            double deuterium = DeuteriumProduction(deuteriumSynthesizerLevel, crawlers, temperature, fusionReactorLevel);

            return new Resources(metal, crystal, deuterium);
        }

        public static double MetalProduction(int level, double crawlers)
        {
            double mineProduction = MetalMineProduction(level);
            double plasmaProduction = PlasmaProduction(mineProduction, Item.METAL, OGame.Researches[Item.PLASMA_TECHNOLOGY].Level);
            double crawlersProduction = CrawlersProduction(mineProduction, Item.METAL, crawlers);
            double basicProduction = OGame.GameSpeed * GameData.BASIC_PRODUCTION[Item.METAL];

            return mineProduction + plasmaProduction + crawlersProduction + basicProduction;
        }

        public static double CrystalProduction(int level, double crawlers)
        {
            double mineProduction = CrystalMineProduction(level);
            double plasmaProduction = PlasmaProduction(mineProduction, Item.CRYSTAL, OGame.Researches[Item.PLASMA_TECHNOLOGY].Level);
            double crawlersProduction = CrawlersProduction(mineProduction, Item.CRYSTAL, crawlers);
            double basicProduction = OGame.GameSpeed * GameData.BASIC_PRODUCTION[Item.CRYSTAL];

            return mineProduction + plasmaProduction + crawlersProduction + basicProduction;
        }

        public static double DeuteriumProduction(int level, double crawlers, int temperature, int fusionReactor)
        {
            double mineProduction = DeuteriumSynthesizerProduction(level, temperature);
            double plasmaProduction = PlasmaProduction(mineProduction, Item.DEUTERIUM, OGame.Researches[Item.PLASMA_TECHNOLOGY].Level);
            double crawlersProduction = CrawlersProduction(mineProduction, Item.DEUTERIUM, crawlers);
            double fusionReactorDemand = FusionReactorDeuteriumDemand(fusionReactor);
            double basicProduction = OGame.GameSpeed * GameData.BASIC_PRODUCTION[Item.DEUTERIUM];

            return mineProduction + plasmaProduction + crawlersProduction - fusionReactorDemand + basicProduction;
        }

        public static double PlasmaProduction(double mineProduction, Item resource, int plasma)
        {
            return Math.Floor(mineProduction * plasma * GameData.PLASMA_FACTOR[resource]);
        }
        
        public static double CrawlersProduction(double mineProduction, Item resource, double crawlers)
        {
            return Math.Floor(mineProduction * crawlers * GameData.CRAWLER_FACTOR[resource]);
        }
        
        public static double MetalMineProduction(int level)
        {
            const double PRODUCTION = 30.0;
            const double PRODUCTION_FACTOR = 1.1;
            return OGame.GameSpeed * Math.Floor(PRODUCTION * level * Math.Pow(PRODUCTION_FACTOR, level));
        }
        
        public static double MetalMineEnergyDemand(int level)
        {
            const double DEMAND = 10.0;
            const double DEMAND_FACTOR = 1.1;
            return Math.Ceiling(DEMAND * level * Math.Pow(DEMAND_FACTOR, level));
        }
        
        public static double CrystalMineProduction(int level)
        {
            const double PRODUCTION = 20.0;
            const double PRODUCTION_FACTOR = 1.1;
            return OGame.GameSpeed * Math.Floor(PRODUCTION * level * Math.Pow(PRODUCTION_FACTOR, level));
        }
        
        public static double CrystalMineEnergyDemand(int level)
        {
            const double DEMAND = 10.0;
            const double DEMAND_FACTOR = 1.1;
            return Math.Ceiling(DEMAND * level * Math.Pow(DEMAND_FACTOR, level));
        }
        
        public static double DeuteriumSynthesizerProduction(int level, int temperature)
        {
            const double PRODUCTION = 10.0;
            const double PRODUCTION_FACTOR = 1.1;
            return OGame.GameSpeed * Math.Floor(PRODUCTION * level * Math.Pow(PRODUCTION_FACTOR, level) * (1.44 - 0.004 * temperature));
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
            const double PRODUCTION_FACTOR = 1.1;
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
        
        public static double EnergyCost(Item item, int level)
        {
            return Math.Ceiling(GameData.COST[item][Item.ENERGY] * Math.Pow(GameData.COST[item][Item.ENERGY_FACTOR], level - 1));
        }
        
        public static double SolarSatelitteEnergy(int temperature, double solarSatelliteis = 1)
        {
            return solarSatelliteis * Math.Floor((temperature + 140) / 6.0); ;
        }
        
        public static double PlanetEnergyProduction(Planet p)
        {
            return PlanetEnergyProduction(p.Buildings[Item.SOLAR_PLANT].Level, p.Buildings[Item.FUSION_REACTOR].Level,
                                          OGame.Researches[Item.ENERGY_TECHNOLOGY].Level, p.Temperature, p.Defences[Item.SOLAR_SATELLITE]);
        }

        public static double PlanetEnergyProduction(int solarPlantLevel,int fusionReactorLevel,int energyTechnologyLevel, int temperature, double satellities)
        {
            double solarPlant = SolarPlantProduction(solarPlantLevel);
            double fusionReactor = FusionReactorProduction(fusionReactorLevel, energyTechnologyLevel);
            double satellites = SolarSatelitteEnergy(temperature, satellities);

            return solarPlant + fusionReactor + satellites;
        }
        #endregion
        
        //upgrade cost
        public static Resources UpgradeCost(Item item, int level)
        {
            double metal = Math.Ceiling(GameData.COST[item][Item.METAL] * Math.Pow(GameData.COST[item][Item.FACTOR], level - 1));
            double crystal = Math.Ceiling(GameData.COST[item][Item.CRYSTAL] * Math.Pow(GameData.COST[item][Item.FACTOR], level - 1));
            double deuterium = Math.Ceiling(GameData.COST[item][Item.DEUTERIUM] * Math.Pow(GameData.COST[item][Item.FACTOR], level - 1));

            if (item == Item.ASTROPHISICS)
            {
                metal = Math.Ceiling(metal / 100) * 100;
                crystal = Math.Ceiling(crystal / 100) * 100;
                deuterium = Math.Ceiling(deuterium / 100) * 100;
            }
            return new Resources(metal, crystal, deuterium);
        }
        
        //storage
        public static double StorageCapacity(int level, double basis = 6.0)
        {
            return Math.Truncate(2.5 * Math.Pow(basis, 20.0 * level / 33)) * 5000;
            // original basis is Math.E
            // Math.PI my first basis for speed 100
            // maybe change 'basis' into 10.0 / 3 for 1000
            // 4 for 10_000
            // 6 for speed 1_000_000
        }

        #region Time
        public static TimeSpan BuildingTime(Resources cost, int robotics, int nanite)
        {
            return BuildingTime(cost.Metal, cost.Crystal, robotics, nanite);
        }
        
        public static TimeSpan BuildingTime(double metal, double crystal, int robotics, int nanite)
        {
            double seconds = Math.Ceiling(1.44 * (metal + crystal) / (OGame.GameSpeed * (robotics + 1) * Math.Pow(2, nanite)));
            return TimeSpan.FromSeconds(seconds);
        }
        
        public static TimeSpan ConstructTime(Resources cost, int shipyard, int nanite)
        {
            return ConstructTime(cost.Metal, cost.Crystal, shipyard, nanite);
        }
        
        public static TimeSpan ConstructTime(double metal, double crystal, int shipyard, int nanite)
        {
            double seconds = Math.Ceiling(1.44 * (metal + crystal) / (OGame.GameSpeed * (shipyard + 1) * Math.Pow(2, nanite)));
            return TimeSpan.FromSeconds(seconds);
        }
        
        public static TimeSpan ConstructTime(Item item, int shipyard, int nanite)
        {
            return ConstructTime(GameData.COST[item][Item.METAL], GameData.COST[item][Item.CRYSTAL], shipyard, nanite);
        }

        public static TimeSpan ResearchTime(Resources cost, int lablvl, int graviton)
        {
            return ResearchTime(cost.Metal, cost.Crystal, lablvl, graviton);
        }
        
        public static TimeSpan ResearchTime(double metal, double crystal, int lablvl, int graviton)
        {
            double seconds = Math.Ceiling(3.6 * (metal + crystal) / (OGame.GameSpeed * (lablvl + 1) * Math.Pow(2, graviton)));
            return TimeSpan.FromSeconds(seconds);
        }
        #endregion
        
        //lab level
        public static int LabLevel(Planet planet, List<Planet> planets, int irn, int minLab)
        {
            int level = planet.Buildings[Item.RESEARCH_LAB].Level;
            if (irn == 0) { return level; }

            var labs = planets  .Where(pl => !pl.Equals(planet))
                                .Where(pl => pl.Buildings[Item.RESEARCH_LAB].Level >= minLab)
                                .OrderByDescending(pl => pl.Buildings[Item.RESEARCH_LAB].Level)
                                .Select(pl => pl.Buildings[Item.RESEARCH_LAB].Level)
                                .ToList();
            for(int i=0; i<irn && i<labs.Count; i++)
            {
                level += labs[i];
            }
            return level;
        }

        #region PlanetFields
        public static int PlanetFields(Planet planet)
        {
            return (int)Math.Floor(Math.Pow(planet.Diameter / 1000.0, 2)) + (int)(5.5 * planet.Buildings[Item.TERRAFORMER].Level);
        }
        
        public static int PlanetFields(int diameter, int terraformer)
        {
            return (int)Math.Floor(Math.Pow(diameter / 1000.0, 2)) + (int)(5.5 * terraformer);
        }
        #endregion

        //temperature
        public static int RandomTemperature()
        {
            //return new Random().Next(-130, -99);
            return -130;
        }

        //diameter
        public static int RandomPlanetSize()
        {
            //return new Random().Next(14500, 16001);
            return 20000;
        }

        //position
        public static int[] GeneratePosition()
        {
            int solar;
            int planet;
            int galaxy;

            do {
                galaxy = new Random().Next(0, 9);
                solar = new Random().Next(0, 99);
                planet = new Random().Next(0, 9);
            } while (IsPositionTaken(galaxy, solar, planet));

            return new int[] { galaxy, solar, planet };
        }
        
        public static bool IsPositionTaken(int galaxy, int solar, int planet)
        {
            foreach(Position p in OGame.Positions)
            {
                if (p.Galaxy == galaxy && p.SolarSystem == solar && p.PlanetNumber == planet) { return true; }
            }
            return false;
        }

        public static double MaxUnits(Item item, Planet planet)
        {
            double metalMin = GameData.COST[item][Item.METAL] == 0.0 ? double.PositiveInfinity : Math.Floor(planet.Resources.Metal / GameData.COST[item][Item.METAL]);
            double crystalMin = GameData.COST[item][Item.CRYSTAL] == 0.0 ? double.PositiveInfinity : Math.Floor(planet.Resources.Crystal / GameData.COST[item][Item.CRYSTAL]);
            double deuteriumMin = GameData.COST[item][Item.DEUTERIUM] == 0.0 ? double.PositiveInfinity : Math.Floor(planet.Resources.Deuterium / GameData.COST[item][Item.DEUTERIUM]);

            if (item == Item.ANTI_BALLISTIC_MISSILE)
            {
                double anti = planet.Buildings[Item.MISSILE_SILO].Level * 10 - planet.Defences[item] - planet.Defences[item + 1] * 2;
                return Math.Min(anti, Math.Min(metalMin, Math.Min(crystalMin, deuteriumMin)));
            }

            if (item == Item.INTERPLANETARY_MISSILE)
            {
                double inter = planet.Buildings[Item.MISSILE_SILO].Level * 5 - Math.Floor((planet.Defences[item - 1] + 1) / 2) - planet.Defences[item];
                return Math.Min(inter, Math.Min(metalMin, Math.Min(crystalMin, deuteriumMin)));
            }

            if (item == Item.CRAWLER)
            {
                double crawler = Math.Truncate((MetalMineEnergyDemand(planet.Buildings[Item.METAL_MINE].Level)
                                              + CrystalMineEnergyDemand(planet.Buildings[Item.CRYSTAL_MINE].Level)
                                              + DeuteriumSynthesizerEnergyDemand(planet.Buildings[Item.DEUTERIUM_SYNTHESIZER].Level)
                                              - GameData.COST[item][Item.ENERGY] * planet.Defences[item])
                                              / GameData.COST[item][Item.ENERGY]);

                return Math.Min(crawler, Math.Min(metalMin, Math.Min(crystalMin, deuteriumMin)));
            }


            return Math.Min(metalMin, Math.Min(crystalMin, deuteriumMin));
        }
    }
}
