namespace OgameData
{
    public class Researches
    {
        public Research EspionageTechnology { get; set; }
        public Research ComputerTechnology { get; set; }
        public Research WeaponsTechnology { get; set; }
        public Research ShieldingTechnology { get; set; }
        public Research ArmourTechnology { get; set; }
        public Research EnergyTechnology { get; set; }
        public Research HyperspaceTechnology { get; set; }
        public Research CombustionDrive { get; set; }
        public Research ImpulseDrive { get; set; }
        public Research HyperspaceDrive { get; set; }
        public Research LaserTechnology { get; set; }
        public Research IonTechnology { get; set; }
        public Research PlasmaTechnology { get; set; }
        public Research Irn { get; set; }
        public Research Astrophisics { get; set; }
        public Research GravitonTechnology { get; set; }
        
        public Researches()
        {
            EspionageTechnology = new Research(Item.ESPIONAGE_TECHNOLOGY);
            ComputerTechnology = new Research(Item.COMPUTER_TECHNOLOGY);
            WeaponsTechnology = new Research(Item.WEAPONS_TECHNOLOGY);
            ShieldingTechnology = new Research(Item.SHIELDING_TECHNOLOGY);
            ArmourTechnology = new Research(Item.ARMOUR_TECHNOLOGY);
            EnergyTechnology = new Research(Item.ENERGY_TECHNOLOGY);
            HyperspaceTechnology = new Research(Item.HYPERSPACE_TECHNOLOGY);
            CombustionDrive = new Research(Item.COMBUSTION_DRIVE);
            ImpulseDrive = new Research(Item.IMPULSE_DRIVE);
            HyperspaceDrive = new Research(Item.HYPERSPACE_DRIVE);
            LaserTechnology = new Research(Item.LASER_TECHNOLOGY);
            IonTechnology = new Research(Item.ION_TECHNOLOGY);
            PlasmaTechnology = new Research(Item.PLASMA_TECHNOLOGY);
            Irn = new Research(Item.IRN);
            Astrophisics = new Research(Item.ASTROPHISICS);
            GravitonTechnology = new Research(Item.GRAVITON_TECHNOLOGY);
        }
    }
}
