namespace OgameData
{
    public class Buildings
    {
        public Building MetalMine { get; set; }
        public Building CrystalMine { get; set; }
        public Building DeuteriumSynthesizer { get; set; }
        public Building SolarPlant { get; set; }
        public Building FusionReactor { get; set; }
        public Building MetalStorage { get; set; }
        public Building CrystalStorage { get; set; }
        public Building DeuteriumTank { get; set; }
        public Building RoboticsFactory { get; set; }
        public Building NaniteFactory { get; set; }
        public Building Shipyard { get; set; }
        public Building ResearchLab { get; set; }
        public Building Terraformer { get; set; }
        public Building MissileSilo { get; set; }
        public Building SpaceDock { get; set; }
        public Building LunarBase { get; set; }
        public Building SensorPhalanx { get; set; }
        public Building JumpGate { get; set; }
        
        public Buildings()
        {
            MetalMine = new Building(Item.METAL_MINE);
            CrystalMine = new Building(Item.CRYSTAL_MINE);
            DeuteriumSynthesizer = new Building(Item.DEUTERIUM_SYNTHESIZER);
            SolarPlant = new Building(Item.SOLAR_PLANT);
            FusionReactor = new Building(Item.FUSION_REACTOR);
            MetalStorage = new Building(Item.METAL_STORAGE);
            CrystalStorage = new Building(Item.CRYSTAL_STORAGE);
            DeuteriumTank = new Building(Item.DEUTERIUM_TANK);
            RoboticsFactory = new Building(Item.ROBOTICS_FACTORY);
            NaniteFactory = new Building(Item.NANITE_FACTORY);
            Shipyard = new Building(Item.SHIPYARD);
            ResearchLab = new Building(Item.RESEARCH_LAB);
            Terraformer = new Building(Item.TERRAFORMER);
            MissileSilo = new Building(Item.MISSILE_SILO);
            SpaceDock = new Building(Item.SPACE_DOCK);
            LunarBase = new Building(Item.LUNAR_BASE);
            SensorPhalanx = new Building(Item.SENSOR_PHALANX);
            JumpGate = new Building(Item.JUMP_GATE);
        }
    }
}
