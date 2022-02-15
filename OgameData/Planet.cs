using Newtonsoft.Json;
using System;

namespace OgameData
{
    public class Planet
    {
        public string PlanetName { get; set; }
        public int Temperature { get; set; }
        public int Diameter { get; set; }
        public Buildings Buildings { get; set; }
        public Fleet Fleet { get; set; }
        public Defences Defences { get; set; }
        public Resources Resources { get; set; }
        public Production Production { get; set; }
        public Energy Energy { get; set; }
        public Fields Fields { get; set; }
        
        public Planet(string name = "Kolonia")
        {
            PlanetName = name;
            Temperature = GameHandler.RandomTemperature();
            Diameter = GameHandler.RandomPlanetSize();
            Buildings = new Buildings();
            Fleet = new Fleet();
            Defences = new Defences();
            Resources = new Resources(500.0, 500.0, 0.0);
            Production = new Production();
            Energy = new Energy();
            Fields = new Fields(Diameter, 0);
        }
        
        public void UpdatePlanetFields()
        {
            Fields.Demand++;
            Fields.Available = GameHandler.PlanetFields(Diameter, Buildings.Terraformer.Level);
            Fields.Over = Fields.Available - Fields.Demand;
        }
        
        public void UpdatePlanetEnergy()
        {
            Energy.SolarPlantProduction = GameHandler.SolarPlantProduction(Buildings.SolarPlant.Level);
            Energy.FusionReactorProduction = GameHandler.FusionReactorProduction(Buildings.FusionReactor.Level, OGame.Researches.EnergyTechnology.Level);
            Energy.Available = Energy.SolarPlantProduction + Energy.FusionReactorProduction;

            Energy.MetalMineDemand = GameHandler.MetalMineEnergyDemand(Buildings.MetalMine.Level);
            Energy.CrystalMineDemand = GameHandler.CrystalMineEnergyDemand(Buildings.CrystalMine.Level);
            Energy.DeuteriumSynthesizerDemand = GameHandler.DeuteriumSynthesizerEnergyDemand(Buildings.DeuteriumSynthesizer.Level);
            Energy.TotalDemand = Energy.MetalMineDemand + Energy.CrystalMineDemand + Energy.DeuteriumSynthesizerDemand;

            Energy.Over = Energy.Available - Energy.TotalDemand;
        }
        
        private void UpdatePlanetMetalProduction()
        {
            Production.Mines.Metal = GameHandler.MetalMineProduction(Buildings.MetalMine.Level, OGame.GameSpeed);
            Production.PlasmaTechnology.Metal = GameHandler.PlasmaProduction(Production.Mines.Metal, Item.METAL, OGame.Researches.PlasmaTechnology.Level);
            Production.Crawlers.Metal = GameHandler.CrawlersProduction(Production.Mines.Metal, Item.METAL, Defences.Crawlers.Count);
        }

        private void UpdatePlanetCrystalProduction()
        {
            Production.Mines.Crystal = GameHandler.CrystalMineProduction(Buildings.CrystalMine.Level, OGame.GameSpeed);
            Production.PlasmaTechnology.Crystal = GameHandler.PlasmaProduction(Production.Mines.Crystal, Item.CRYSTAL, OGame.Researches.PlasmaTechnology.Level);
            Production.Crawlers.Crystal = GameHandler.CrawlersProduction(Production.Mines.Crystal, Item.CRYSTAL, Defences.Crawlers.Count);
        }

        private void UpdatePlanetDeuteriumProduction()
        {
            Production.Mines.Deuterium = GameHandler.DeuteriumSynthesizerProduction(Buildings.DeuteriumSynthesizer.Level, Temperature, OGame.GameSpeed);
            Production.PlasmaTechnology.Deuterium = GameHandler.PlasmaProduction(Production.Mines.Deuterium, Item.DEUTERIUM, OGame.Researches.PlasmaTechnology.Level);
            Production.Crawlers.Deuterium = GameHandler.CrawlersProduction(Production.Mines.Deuterium, Item.METAL, Defences.Crawlers.Count);
        }

        private void UpdateFusionReactorDeuteriumDemand()
        {
            Production.FusionReactorDeuteriumDemand = GameHandler.FusionReactorDeuteriumDemand(Buildings.FusionReactor.Level);
            Production.FusionReactorNextLevelDeuteriumDemand = GameHandler.FusionReactorDeuteriumDemand(Buildings.FusionReactor.Level + 1);
        }

        public void UpdatePlanetProduction()
        {
            UpdatePlanetMetalProduction();
            UpdatePlanetCrystalProduction();
            UpdatePlanetDeuteriumProduction();
            UpdateFusionReactorDeuteriumDemand();

            Production.UpdateTotalPlanetProduction();
        }
        
        public void UpdatePlanetResources(TimeSpan duration)
        {
            Resources.Metal += GameHandler.UpdateResources(duration, Production.Total.Metal);
            Resources.Crystal += GameHandler.UpdateResources(duration, Production.Total.Crystal);
            Resources.Deuterium += GameHandler.UpdateResources(duration, Production.Total.Deuterium);
            Resources.Total = Resources.Metal + Resources.Crystal + Resources.Deuterium;

        }

    }
}
