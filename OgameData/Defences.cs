using OgameData.UnitModels;
using System.Collections.Generic;

namespace OgameData
{
    public class Defences
    {
        public List<RocketLauncher> RocketLaunchers { get; set; }
        public List<LightLaser> LightLasers { get; set; }
        public List<HeavyLaser> HeavyLasers { get; set; }
        public List<GaussCannon> GaussCannons { get; set; }
        public List<IonCannon> IonCannons { get; set; }
        public List<PlasmaTurret> PlasmaTurrets { get; set; }
        public List<SmallShieldDome> SmallShieldDomes { get; set; }
        public List<LargeShieldDome> LargeShieldDomes { get; set; }
        public List<AntiBallisticMissile> AntiBallisticMissiles { get; set; }
        public List<InterplanetaryMissile> InterplanetaryMissiles { get; set; }
        public List<SolarSatellite> SolarSatellites { get; set; }
        public List<Crawler> Crawlers { get; set; }
        
        public Defences()
        {
            RocketLaunchers = new List<RocketLauncher>();
            LightLasers = new List<LightLaser>();
            HeavyLasers = new List<HeavyLaser>();
            GaussCannons = new List<GaussCannon>();
            IonCannons = new List<IonCannon>();
            PlasmaTurrets = new List<PlasmaTurret>();
            SmallShieldDomes = new List<SmallShieldDome>();
            LargeShieldDomes = new List<LargeShieldDome>();
            AntiBallisticMissiles = new List<AntiBallisticMissile>();
            InterplanetaryMissiles = new List<InterplanetaryMissile>();
            SolarSatellites = new List<SolarSatellite>();
            Crawlers = new List<Crawler>();
        }
    }
}