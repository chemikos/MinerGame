using System;

namespace OgameData
{
    public class Production
    {
        public Resources Basis { get; set; }
        public Resources Mines { get; set; }
        public Resources PlasmaTechnology { get; set; }
        public Resources Crawlers { get; set; }
        public double FusionReactorDeuteriumDemand { get; set; }
        public double FusionReactorNextLevelDeuteriumDemand { get; set; }
        public Resources Total { get; set; }

        public Production()
        {
            Basis = new Resources(OGame.GameSpeed * GameData.BASIS_PRODUCTION[Item.METAL],
                                  OGame.GameSpeed * GameData.BASIS_PRODUCTION[Item.CRYSTAL],
                                  OGame.GameSpeed * GameData.BASIS_PRODUCTION[Item.DEUTERIUM]);
            Mines = new Resources();
            PlasmaTechnology = new Resources();
            Crawlers = new Resources();
            FusionReactorDeuteriumDemand = 0.0;
            FusionReactorNextLevelDeuteriumDemand = GameHandler.FusionReactorDeuteriumDemand(1);
            Total = new Resources(OGame.GameSpeed * GameData.BASIS_PRODUCTION[Item.METAL],
                                  OGame.GameSpeed * GameData.BASIS_PRODUCTION[Item.CRYSTAL],
                                  OGame.GameSpeed * GameData.BASIS_PRODUCTION[Item.DEUTERIUM]);


        }

        public void UpdateTotalPlanetProduction()
        {
            Total.Metal = Basis.Metal + Mines.Metal + PlasmaTechnology.Metal + Crawlers.Metal;
            Total.Crystal = Basis.Crystal + Mines.Crystal + PlasmaTechnology.Crystal + Crawlers.Crystal;
            Total.Deuterium = Basis.Deuterium + Mines.Deuterium + PlasmaTechnology.Deuterium + Crawlers.Deuterium - FusionReactorDeuteriumDemand;
            Total.Total = Total.Metal + Total.Crystal + Total.Deuterium;
        }
        
        public void Add(Production second)
        {
            Basis.Add(second.Basis);
            Mines.Add(second.Mines);
            PlasmaTechnology.Add(second.PlasmaTechnology);
            Crawlers.Add(second.Crawlers);
            FusionReactorDeuteriumDemand += second.FusionReactorDeuteriumDemand;
            FusionReactorNextLevelDeuteriumDemand += second.FusionReactorNextLevelDeuteriumDemand;
            Total.Add(second.Total);
        }
    }
}
