namespace OgameData
{
    public class Energy
    {
        public double SolarPlantProduction { get; set; }
        public double FusionReactorProduction { get; set; }
        public double Available { get; set; }

        public double MetalMineDemand { get; set; }
        public double CrystalMineDemand { get; set; }
        public double DeuteriumSynthesizerDemand { get; set; }
        public double TotalDemand { get; set; }

        public double Over { get; set; }

        public double SolarPlantNextLevelProduction { get; set; }
        public double FusionReactorNextLevelProduction { get; set; }
        public double MetamMineNextLevelDemand { get; set; }
        public double CrystalMineNextLevelDemand { get; set; }
        public double DeuteriumSynthesizerNextLevelDemand { get; set; }
        
        public Energy()
        {
            SolarPlantProduction = 0.0;
            FusionReactorProduction = 0.0;
            Available = 0.0;

            MetalMineDemand = 0.0;
            CrystalMineDemand = 0.0;
            DeuteriumSynthesizerDemand = 0.0;
            TotalDemand = 0.0;

            Over = 0.0;

            SolarPlantNextLevelProduction = GameHandler.SolarPlantProduction(1);
            FusionReactorNextLevelProduction = GameHandler.FusionReactorProduction(1, 0);
            MetamMineNextLevelDemand = GameHandler.MetalMineEnergyDemand(1);
            CrystalMineNextLevelDemand = GameHandler.CrystalMineEnergyDemand(1);
            DeuteriumSynthesizerNextLevelDemand = GameHandler.DeuteriumSynthesizerEnergyDemand(1);
        }
    }
}