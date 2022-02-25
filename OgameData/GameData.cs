using System;
using System.Collections.Generic;

namespace OgameData
{
    public static class GameData
    {        
        public static readonly Dictionary<Item, Dictionary<Item, double>> COST = new()
        {
            #region Buildings
            {
                Item.METAL_MINE, new()
                {
                    { Item.METAL, 60.0 },
                    { Item.CRYSTAL, 15.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 1.5 }
                }
            },
            {
                Item.CRYSTAL_MINE, new()
                {
                    { Item.METAL, 48.0 },
                    { Item.CRYSTAL, 24.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 1.6 }
                }
            },
            {
                Item.DEUTERIUM_SYNTHESIZER, new()
                {
                    { Item.METAL, 225.0 },
                    { Item.CRYSTAL, 75.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 1.5 }
                }
            },
            {
                Item.SOLAR_PLANT, new()
                {
                    { Item.METAL, 75.0 },
                    { Item.CRYSTAL, 30.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 1.5 }
                }
            },
            {
                Item.FUSION_REACTOR, new()
                {
                    { Item.METAL, 900.0 },
                    { Item.CRYSTAL, 360.0 },
                    { Item.DEUTERIUM, 180.0 },
                    { Item.FACTOR, 1.8 }
                }
            },
            {
                Item.METAL_STORAGE, new()
                {
                    { Item.METAL, 1_000.0 },
                    { Item.CRYSTAL, 0.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.CRYSTAL_STORAGE, new()
                {
                    { Item.METAL, 1_000.0 },
                    { Item.CRYSTAL, 500.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.DEUTERIUM_TANK, new()
                {
                    { Item.METAL, 1_000.0 },
                    { Item.CRYSTAL, 1_000.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.ROBOTICS_FACTORY, new()
                {
                    { Item.METAL, 400.0 },
                    { Item.CRYSTAL, 120.0 },
                    { Item.DEUTERIUM, 200.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.NANITE_FACTORY, new()
                {
                    { Item.METAL, 1_000_000.0 },
                    { Item.CRYSTAL, 500_000.0 },
                    { Item.DEUTERIUM, 100_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.SHIPYARD, new()
                {
                    { Item.METAL, 400.0 },
                    { Item.CRYSTAL, 200.0 },
                    { Item.DEUTERIUM, 100.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.RESEARCH_LAB, new()
                {
                    { Item.METAL, 200.0 },
                    { Item.CRYSTAL, 400.0 },
                    { Item.DEUTERIUM, 200.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.TERRAFORMER, new()
                {
                    { Item.METAL, 0.0 },
                    { Item.CRYSTAL, 50_000.0 },
                    { Item.DEUTERIUM, 100_000.0 },
                    { Item.FACTOR, 2.0 },
                    { Item.ENERGY, 1_000.0 },
                    { Item.ENERGY_FACTOR, 2.0 }
                }
            },
            {
                Item.MISSILE_SILO, new()
                {
                    { Item.METAL, 20_000.0 },
                    { Item.CRYSTAL, 20_000.0 },
                    { Item.DEUTERIUM, 1_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.SPACE_DOCK, new()
                {
                    { Item.METAL, 200.0 },
                    { Item.CRYSTAL, 0.0 },
                    { Item.DEUTERIUM, 50.0 },
                    { Item.FACTOR, 5.0 },
                    { Item.ENERGY, 50.0 },
                    { Item.ENERGY_FACTOR, 2.5 }
                }
            },
            {
                Item.LUNAR_BASE, new()
                {
                    { Item.METAL, 20_000.0 },
                    { Item.CRYSTAL, 40_000.0 },
                    { Item.DEUTERIUM, 20_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.SENSOR_PHALANX, new()
                {
                    { Item.METAL, 20_000.0 },
                    { Item.CRYSTAL, 40_000.0 },
                    { Item.DEUTERIUM, 20_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.JUMP_GATE, new()
                {
                    { Item.METAL, 2_000_000.0 },
                    { Item.CRYSTAL, 4_000_000.0 },
                    { Item.DEUTERIUM, 2_000_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            #endregion

            #region Research
            {
                Item.ESPIONAGE_TECHNOLOGY, new()
                {
                    { Item.METAL, 200.0 },
                    { Item.CRYSTAL, 1_000.0 },
                    { Item.DEUTERIUM, 200.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.COMPUTER_TECHNOLOGY, new()
                {
                    { Item.METAL, 0.0 },
                    { Item.CRYSTAL, 400.0 },
                    { Item.DEUTERIUM, 600.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.WEAPONS_TECHNOLOGY, new()
                {
                    { Item.METAL, 800.0 },
                    { Item.CRYSTAL, 200.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.SHIELDING_TECHNOLOGY, new()
                {
                    { Item.METAL, 200.0 },
                    { Item.CRYSTAL, 600.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.ARMOUR_TECHNOLOGY, new()
                {
                    { Item.METAL, 1_000.0 },
                    { Item.CRYSTAL, 0.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.ENERGY_TECHNOLOGY, new()
                {
                    { Item.METAL, 0.0 },
                    { Item.CRYSTAL, 800.0 },
                    { Item.DEUTERIUM, 400.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.HYPERSPACE_TECHNOLOGY, new()
                {
                    { Item.METAL, 0.0 },
                    { Item.CRYSTAL, 4_000.0 },
                    { Item.DEUTERIUM, 2_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.COMBUSTION_DRIVE, new()
                {
                    { Item.METAL, 400.0 },
                    { Item.CRYSTAL, 0.0 },
                    { Item.DEUTERIUM, 600.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.IMPULSE_DRIVE, new()
                {
                    { Item.METAL, 2_000.0 },
                    { Item.CRYSTAL, 4_000.0 },
                    { Item.DEUTERIUM, 600.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.HYPERSPACE_DRIVE, new()
                {
                    { Item.METAL, 10_000.0 },
                    { Item.CRYSTAL, 20_000.0 },
                    { Item.DEUTERIUM, 6_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.LASER_TECHNOLOGY, new()
                {
                    { Item.METAL, 200.0 },
                    { Item.CRYSTAL, 100.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.ION_TECHNOLOGY, new()
                {
                    { Item.METAL, 1_000.0 },
                    { Item.CRYSTAL, 300.0 },
                    { Item.DEUTERIUM, 100.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.PLASMA_TECHNOLOGY, new()
                {
                    { Item.METAL, 2_000.0 },
                    { Item.CRYSTAL, 4_000.0 },
                    { Item.DEUTERIUM, 1_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.IRN, new()
                {
                    { Item.METAL, 240_000.0 },
                    { Item.CRYSTAL, 400_000.0 },
                    { Item.DEUTERIUM, 160_000.0 },
                    { Item.FACTOR, 2.0 }
                }
            },
            {
                Item.ASTROPHISICS, new()
                {
                    { Item.METAL, 4_000.0 },
                    { Item.CRYSTAL, 8_000.0 },
                    { Item.DEUTERIUM, 4_000.0 },
                    { Item.FACTOR, 1.75 }
                }
            },
            {
                Item.GRAVITON_TECHNOLOGY, new()
                {
                    { Item.METAL, 0.0 },
                    { Item.CRYSTAL, 0.0 },
                    { Item.DEUTERIUM, 0.0 },
                    { Item.FACTOR, 2.0 },
                    { Item.ENERGY, 30_000.0 },
                    { Item.ENERGY_FACTOR, 2.0 }
                }
            },
            #endregion

            #region Ships
            {
                Item.SMALL_CARGO, new()
                {
                    { Item.METAL, 2_000.0 },
                    { Item.CRYSTAL, 2_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.LARGE_CARGO, new()
                {
                    { Item.METAL, 6_000.0 },
                    { Item.CRYSTAL, 6_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.COLONY_SHIP, new()
                {
                    { Item.METAL, 10_000.0 },
                    { Item.CRYSTAL, 20_000.0 },
                    { Item.DEUTERIUM, 10_000.0 }
                }
            },
            {
                Item.RECYCLER, new()
                {
                    { Item.METAL, 10_000.0 },
                    { Item.CRYSTAL, 6_000.0 },
                    { Item.DEUTERIUM, 2_000.0 }
                }
            },
            {
                Item.ESPIONAGE_PROBE, new()
                {
                    { Item.METAL, 0.0 },
                    { Item.CRYSTAL, 1_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.LIGHT_FIGHTER, new()
                {
                    { Item.METAL, 3_000.0 },
                    { Item.CRYSTAL, 1_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.HEAVY_FIGHTER, new()
                {
                    { Item.METAL, 6_000.0 },
                    { Item.CRYSTAL, 4_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.CRUISER, new()
                {
                    { Item.METAL, 20_000.0 },
                    { Item.CRYSTAL, 7_000.0 },
                    { Item.DEUTERIUM, 2_000.0 }
                }
            },
            {
                Item.BATTLESHIP, new()
                {
                    { Item.METAL, 45_000.0 },
                    { Item.CRYSTAL, 15_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.BATTLECRUISER, new()
                {
                    { Item.METAL, 30_000.0 },
                    { Item.CRYSTAL, 40_000.0 },
                    { Item.DEUTERIUM, 15_000.0 }
                }
            },
            {
                Item.BOMBER, new()
                {
                    { Item.METAL, 50_000.0 },
                    { Item.CRYSTAL, 25_000.0 },
                    { Item.DEUTERIUM, 15_000.0 }
                }
            },
            {
                Item.DESTROYER, new()
                {
                    { Item.METAL, 60_000.0 },
                    { Item.CRYSTAL, 50_000.0 },
                    { Item.DEUTERIUM, 15_000.0 }
                }
            },
            {
                Item.DEATHSTAR, new()
                {
                    { Item.METAL, 5_000_000.0 },
                    { Item.CRYSTAL, 4_000_000.0 },
                    { Item.DEUTERIUM, 1_000_000.0 }
                }
            },
            {
                Item.REAPER, new()
                {
                    { Item.METAL, 85_000.0 },
                    { Item.CRYSTAL, 55_000.0 },
                    { Item.DEUTERIUM, 20_000.0 }
                }
            },
            {
                Item.PATHFINDER, new()
                {
                    { Item.METAL, 8_000.0 },
                    { Item.CRYSTAL, 15_000.0 },
                    { Item.DEUTERIUM, 8_000.0 }
                }
            },
            #endregion

            #region Fleet but Defence
            {
                Item.SOLAR_SATELLITE, new()
                {
                    { Item.METAL, 0.0 },
                    { Item.CRYSTAL, 2_000.0 },
                    { Item.DEUTERIUM, 500.0 }
                }
            },
            {
                Item.CRAWLER, new()
                {
                    { Item.METAL, 2_000.0 },
                    { Item.CRYSTAL, 2_000.0 },
                    { Item.DEUTERIUM, 1_000.0 },
                    { Item.ENERGY, 50.0 },
                    { Item.ENERGY_FACTOR, 1.0 }
                }
            },

            #endregion

            #region Defence
            {
                Item.ROCKER_LAUNCHER, new()
                {
                    { Item.METAL, 2_000.0 },
                    { Item.CRYSTAL, 0.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.LIGHT_LASER, new()
                {
                    { Item.METAL, 1_500.0 },
                    { Item.CRYSTAL, 500.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.HEAVY_LASER, new()
                {
                    { Item.METAL, 6_000.0 },
                    { Item.CRYSTAL, 2_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.GAUSS_CANNON, new()
                {
                    { Item.METAL, 20_000.0 },
                    { Item.CRYSTAL, 15_000.0 },
                    { Item.DEUTERIUM, 2_000.0 }
                }
            },
            {
                Item.ION_CANNON, new()
                {
                    { Item.METAL, 2_000.0 },
                    { Item.CRYSTAL, 6_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.PLASMA_TURRET, new()
                {
                    { Item.METAL, 50_000.0 },
                    { Item.CRYSTAL, 50_000.0 },
                    { Item.DEUTERIUM, 10_000.0 }
                }
            },
            {
                Item.SMALL_SHIELD_DOME, new()
                {
                    { Item.METAL, 10_000.0 },
                    { Item.CRYSTAL, 10_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.LARGE_SHIELD_DOME, new()
                {
                    { Item.METAL, 50_000.0 },
                    { Item.CRYSTAL, 50_000.0 },
                    { Item.DEUTERIUM, 0.0 }
                }
            },
            {
                Item.ANTI_BALLISTIC_MISSILE, new()
                {
                    { Item.METAL, 8_000.0 },
                    { Item.CRYSTAL, 0.0 },
                    { Item.DEUTERIUM, 2_000.0 }
                }
            },
            {
                Item.INTERPLANETARY_MISSILE, new()
                {
                    { Item.METAL, 12_500.0 },
                    { Item.CRYSTAL, 2_500.0 },
                    { Item.DEUTERIUM, 10_000.0 }
                }
            }
            #endregion
        };
        
        public static readonly Dictionary<Item, string> NAME = new()
        {
            #region Buildings
            { Item.METAL_MINE, "Kopalnia metalu" },
            { Item.CRYSTAL_MINE, "Kopalnia kryształu" },
            { Item.DEUTERIUM_SYNTHESIZER, "Ekstraktor deuteru" },
            { Item.SOLAR_PLANT, "Elektrownia słoneczna" },
            { Item.FUSION_REACTOR, "Elektrownia fuzyjna" },
            { Item.METAL_STORAGE, "Magazyn metalu" },
            { Item.CRYSTAL_STORAGE, "Magazyn kryształu" },
            { Item.DEUTERIUM_TANK, "Zbiornik deuteru" },
            { Item.ROBOTICS_FACTORY, "Fabryka robotów"},
            { Item.NANITE_FACTORY, "Fabryka nanitów" },
            { Item.SHIPYARD, "Stocznia orbitalna" },
            { Item.RESEARCH_LAB, "Laboratorium badawcze" },
            { Item.TERRAFORMER, "Terraformer" },
            { Item.MISSILE_SILO, "Silos rakietowy" },
            { Item.SPACE_DOCK, "Dok kosmiczny" },
            { Item.LUNAR_BASE, "Stacja księżycowa" },
            { Item.SENSOR_PHALANX, "Falanga czujników" },
            { Item.JUMP_GATE, "Teleporter" },
            #endregion

            #region Research
            { Item.ESPIONAGE_TECHNOLOGY, "Technologia szpiegowska" },
            { Item.COMPUTER_TECHNOLOGY, "Technologia komputerowa" },
            { Item.WEAPONS_TECHNOLOGY, "Technologia bojowa" },
            { Item.SHIELDING_TECHNOLOGY, "Technologia ochronna" },
            { Item.ARMOUR_TECHNOLOGY, "Opancerzenie" },
            { Item.ENERGY_TECHNOLOGY, "Technologia energetyczna" },
            { Item.HYPERSPACE_TECHNOLOGY, "Technologia nadprzestrzenna" },
            { Item.COMBUSTION_DRIVE, "Napęd spalinowy" },
            { Item.IMPULSE_DRIVE, "Napęd impulsowy" },
            { Item.HYPERSPACE_DRIVE, "Napęd nadprzestrzenny" },
            { Item.LASER_TECHNOLOGY, "Technologia laserowa" },
            { Item.ION_TECHNOLOGY, "Technologia jonowa" },
            { Item.PLASMA_TECHNOLOGY, "Technologia plazmowa" },
            { Item.IRN, "MSBN" },
            { Item.ASTROPHISICS, "Astrofizyka" },
            { Item.GRAVITON_TECHNOLOGY, "Rozwój grawitonów" },
            #endregion

            #region Ships
            { Item.SMALL_CARGO, "Mały transporter" },
            { Item.LARGE_CARGO, "Duży transporter" },
            { Item.COLONY_SHIP, "Statek kolonizacyjny" },
            { Item.RECYCLER, "Recykler" },
            { Item.ESPIONAGE_PROBE, "Sonda szpiegowska" },
            { Item.LIGHT_FIGHTER, "Lekki myśliwiec" },
            { Item.HEAVY_FIGHTER, "Ciężki myśliwiec" },
            { Item.CRUISER, "Krążownik" },
            { Item.BATTLESHIP, "Okręt wojenny" },
            { Item.BATTLECRUISER, "Pancernik" },
            { Item.BOMBER, "Bombowiec" },
            { Item.DESTROYER, "Niszczyciel" },
            { Item.DEATHSTAR, "Gwiazda śmierci" },
            { Item.REAPER, "Rozpruwacz" },
            { Item.PATHFINDER, "Pionier" },
            #endregion

            #region Fleet but Defence
            { Item.SOLAR_SATELLITE, "Satelita słoneczny" },
            { Item.CRAWLER, "Pełzacz" },

            #endregion

            #region Defence
            { Item.ROCKER_LAUNCHER, "Wyrzutnia rakiet" },
            { Item.LIGHT_LASER, "Lekkie działo laserowe" },
            { Item.HEAVY_LASER, "Ciężkie działo laserowe" },
            { Item.GAUSS_CANNON, "Działo Gaussa" },
            { Item.ION_CANNON, "Działo jonowe" },
            { Item.PLASMA_TURRET, "Wyrzutnia plazmy" },
            { Item.SMALL_SHIELD_DOME, "Mała powłoka ochronna" },
            { Item.LARGE_SHIELD_DOME, "Duża powłoka ochronna" },
            { Item.ANTI_BALLISTIC_MISSILE, "Przeciwrakieta" },
            { Item.INTERPLANETARY_MISSILE, "Rakieta międzyplanetarna" },
            #endregion

            #region Resource
            { Item.METAL, "Metal" },
            { Item.CRYSTAL, "Kryształ" },
            { Item.DEUTERIUM, "Deuter" },
            { Item.ENERGY, "Energia" },
            #endregion

            #region Technical data
            { Item.STRUCTURAL_INTEGRITY, "Punkty strukturalne" },
            { Item.SHIELD_STRENGTH, "Siła powłoki" },
            { Item.ATTACK_STRENGTH, "Siła ataku" },
            { Item.CARGO_CAPACITY, "Ładowność" },
            { Item.SPEED_COMBUSTION_DRIVE, "Prędkość (spalinowy)" },
            { Item.FUEL_USAGE_COMBUSTION_DRIVE, "Zużycie paliwa (spalinowy)" },
            { Item.SPEED_IMPULSE_DRIVE, "Prędkość (impulsowy)" },
            { Item.FUEL_USAGE_IMPULSE_DRIVE, "Zużycie paliwa (impulsowy)" },
            { Item.SPEED_HYPERSPACE_DRIVE, "Prędkość (nadprzestrzenny)" },
            { Item.FUEL_USAGE_HYPERSPACE_DRIVE, "Zużycie paliwa (nadprzestrzenny)" },
            #endregion
        };
        
        public static readonly Dictionary<Item, double> BASIC_PRODUCTION = new()
        {
            { Item.METAL, 30.0 },
            { Item.CRYSTAL, 15.0 },
            { Item.DEUTERIUM, 5.0 }
        };
        
        public static readonly Dictionary<Item, Dictionary<Item, double>> TECHNICAL_DATA = new()
        {
            #region Fleet
            {
                Item.SMALL_CARGO, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.SMALL_CARGO][Item.METAL] + COST[Item.SMALL_CARGO][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 10.0 },
                    { Item.ATTACK_STRENGTH, 5.0 },
                    { Item.CARGO_CAPACITY, 5_000.0 },
                    { Item.SPEED_COMBUSTION_DRIVE, 5_000.0 },
                    { Item.FUEL_USAGE_COMBUSTION_DRIVE, 10.0 },
                    { Item.SPEED_IMPULSE_DRIVE, 10_000.0 },
                    { Item.FUEL_USAGE_IMPULSE_DRIVE, 20.0 }
                }
            },
            {
                Item.LARGE_CARGO, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.LARGE_CARGO][Item.METAL] + COST[Item.LARGE_CARGO][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 25.0 },
                    { Item.ATTACK_STRENGTH, 5.0 },
                    { Item.CARGO_CAPACITY, 25_000.0 },
                    { Item.SPEED_COMBUSTION_DRIVE, 7_500.0 },
                    { Item.FUEL_USAGE_COMBUSTION_DRIVE, 50.0 },
                }
            },
            {
                Item.COLONY_SHIP, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.COLONY_SHIP][Item.METAL] + COST[Item.COLONY_SHIP][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 100.0 },
                    { Item.ATTACK_STRENGTH, 50.0 },
                    { Item.CARGO_CAPACITY, 7_500.0 },
                    { Item.SPEED_IMPULSE_DRIVE, 2_500.0 },
                    { Item.FUEL_USAGE_IMPULSE_DRIVE, 1_000.0 },
                }
            },
            {
                Item.RECYCLER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.RECYCLER][Item.METAL] + COST[Item.RECYCLER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 10.0 },
                    { Item.ATTACK_STRENGTH, 1.0 },
                    { Item.CARGO_CAPACITY, 20_000.0 },
                    { Item.SPEED_COMBUSTION_DRIVE, 2_000.0 },
                    { Item.FUEL_USAGE_COMBUSTION_DRIVE, 300.0 },
                    { Item.SPEED_IMPULSE_DRIVE, 4_000.0 },
                    { Item.FUEL_USAGE_IMPULSE_DRIVE, 600.0 },
                    { Item.SPEED_HYPERSPACE_DRIVE, 6_000.0 },
                    { Item.FUEL_USAGE_HYPERSPACE_DRIVE, 900.0 }
                }
            },
            {
                Item.ESPIONAGE_PROBE, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.ESPIONAGE_PROBE][Item.METAL] + COST[Item.ESPIONAGE_PROBE][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 0.0 },
                    { Item.ATTACK_STRENGTH, 0.0 },
                    { Item.CARGO_CAPACITY, 5.0 },
                    { Item.SPEED_COMBUSTION_DRIVE, 100_000_000.0 },
                    { Item.FUEL_USAGE_COMBUSTION_DRIVE, 1.0 }
                }
            },
            {
                Item.LIGHT_FIGHTER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.LIGHT_FIGHTER][Item.METAL] + COST[Item.LIGHT_FIGHTER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 10.0 },
                    { Item.ATTACK_STRENGTH, 50.0 },
                    { Item.CARGO_CAPACITY, 50.0 },
                    { Item.SPEED_COMBUSTION_DRIVE, 12_500.0 },
                    { Item.FUEL_USAGE_COMBUSTION_DRIVE, 20.0 }
                }
            },
            {
                Item.HEAVY_FIGHTER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.HEAVY_FIGHTER][Item.METAL] + COST[Item.HEAVY_FIGHTER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 25.0 },
                    { Item.ATTACK_STRENGTH, 150.0 },
                    { Item.CARGO_CAPACITY, 100.0 },
                    { Item.SPEED_IMPULSE_DRIVE, 10_000.0 },
                    { Item.FUEL_USAGE_IMPULSE_DRIVE, 75.0 },
                }
            },
            {
                Item.CRUISER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.CRUISER][Item.METAL] + COST[Item.CRUISER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 50.0 },
                    { Item.ATTACK_STRENGTH, 400.0 },
                    { Item.CARGO_CAPACITY, 800.0 },
                    { Item.SPEED_IMPULSE_DRIVE, 15_000.0 },
                    { Item.FUEL_USAGE_IMPULSE_DRIVE, 300.0 },
                }
            },
            {
                Item.BATTLESHIP, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.BATTLESHIP][Item.METAL] + COST[Item.BATTLESHIP][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 200.0 },
                    { Item.ATTACK_STRENGTH, 1_000.0 },
                    { Item.CARGO_CAPACITY, 1_500.0 },
                    { Item.SPEED_HYPERSPACE_DRIVE, 10_000.0 },
                    { Item.FUEL_USAGE_HYPERSPACE_DRIVE, 500.0 }
                }
            },
            {
                Item.BATTLECRUISER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.BATTLECRUISER][Item.METAL] + COST[Item.BATTLECRUISER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 400.0 },
                    { Item.ATTACK_STRENGTH, 700.0 },
                    { Item.CARGO_CAPACITY, 750.0 },
                    { Item.SPEED_HYPERSPACE_DRIVE, 10_000.0 },
                    { Item.FUEL_USAGE_HYPERSPACE_DRIVE, 250.0 }
                }
            },
            {
                Item.BOMBER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.BOMBER][Item.METAL] + COST[Item.BOMBER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 500.0 },
                    { Item.ATTACK_STRENGTH, 1_000.0 },
                    { Item.CARGO_CAPACITY, 500.0 },
                    { Item.SPEED_IMPULSE_DRIVE, 4_000.0 },
                    { Item.FUEL_USAGE_IMPULSE_DRIVE, 700.0 },
                    { Item.SPEED_HYPERSPACE_DRIVE, 5_000.0 },
                    { Item.FUEL_USAGE_HYPERSPACE_DRIVE, 700.0 }
                }
            },
            {
                Item.DESTROYER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.DESTROYER][Item.METAL] + COST[Item.DESTROYER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 500.0 },
                    { Item.ATTACK_STRENGTH, 2_000.0 },
                    { Item.CARGO_CAPACITY, 2_000.0 },
                    { Item.SPEED_HYPERSPACE_DRIVE, 5_000.0 },
                    { Item.FUEL_USAGE_HYPERSPACE_DRIVE, 1_000.0 }
                }
            },
            {
                Item.DEATHSTAR, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.DEATHSTAR][Item.METAL] + COST[Item.DEATHSTAR][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 50_000.0 },
                    { Item.ATTACK_STRENGTH, 200_000.0 },
                    { Item.CARGO_CAPACITY, 1_000_000.0 },
                    { Item.SPEED_HYPERSPACE_DRIVE, 100.0 },
                    { Item.FUEL_USAGE_HYPERSPACE_DRIVE, 1.0 }
                }
            },
            {
                Item.REAPER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.REAPER][Item.METAL] + COST[Item.REAPER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 700.0 },
                    { Item.ATTACK_STRENGTH, 2_800.0 },
                    { Item.CARGO_CAPACITY, 10_000 },
                    { Item.SPEED_HYPERSPACE_DRIVE, 7_000 },
                    { Item.FUEL_USAGE_HYPERSPACE_DRIVE, 1_100.0 }
                }
            },
            {
                Item.PATHFINDER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.PATHFINDER][Item.METAL] + COST[Item.PATHFINDER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 100.0 },
                    { Item.ATTACK_STRENGTH, 200.0 },
                    { Item.CARGO_CAPACITY, 10_000 },
                    { Item.SPEED_HYPERSPACE_DRIVE, 12_000.0 },
                    { Item.FUEL_USAGE_HYPERSPACE_DRIVE, 300.0 }
                }
            },
            #endregion

            #region Fleet but Defence
            {
                Item.SOLAR_SATELLITE, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.SOLAR_SATELLITE][Item.METAL] + COST[Item.SOLAR_SATELLITE][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 1.0 },
                    { Item.ATTACK_STRENGTH, 1.0 }
                }
            },
            {
                Item.CRAWLER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.CRAWLER][Item.METAL] + COST[Item.CRAWLER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 1.0 },
                    { Item.ATTACK_STRENGTH, 1.0 }
                }
            },
            #endregion

            #region Defences
            {
                Item.ROCKER_LAUNCHER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.ROCKER_LAUNCHER][Item.METAL] + COST[Item.ROCKER_LAUNCHER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 20.0 },
                    { Item.ATTACK_STRENGTH, 80.0 }
                }
            },
            {
                Item.LIGHT_LASER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.LIGHT_LASER][Item.METAL] + COST[Item.LIGHT_LASER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 25.0 },
                    { Item.ATTACK_STRENGTH, 100.0 }
                }
            },
            {
                Item.HEAVY_LASER, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.HEAVY_LASER][Item.METAL] + COST[Item.HEAVY_LASER][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 100.0 },
                    { Item.ATTACK_STRENGTH, 250.0 }
                }
            },
            {
                Item.GAUSS_CANNON, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.GAUSS_CANNON][Item.METAL] + COST[Item.GAUSS_CANNON][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 200.0 },
                    { Item.ATTACK_STRENGTH, 1_100.0 }
                }
            },
            {
                Item.ION_CANNON, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.ION_CANNON][Item.METAL] + COST[Item.ION_CANNON][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 500.0 },
                    { Item.ATTACK_STRENGTH, 150.0 }
                }
            },
            {
                Item.PLASMA_TURRET, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.PLASMA_TURRET][Item.METAL] + COST[Item.PLASMA_TURRET][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 300.0 },
                    { Item.ATTACK_STRENGTH, 3_000.0 }
                }
            },
            {
                Item.SMALL_SHIELD_DOME, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.SMALL_SHIELD_DOME][Item.METAL] + COST[Item.SMALL_SHIELD_DOME][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 2_000.0 },
                    { Item.ATTACK_STRENGTH, 1.0 }
                }
            },
            {
                Item.LARGE_SHIELD_DOME, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.LARGE_SHIELD_DOME][Item.METAL] + COST[Item.LARGE_SHIELD_DOME][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 10_000.0 },
                    { Item.ATTACK_STRENGTH, 1.0 }
                }
            },
            {
                Item.ANTI_BALLISTIC_MISSILE, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.ANTI_BALLISTIC_MISSILE][Item.METAL] + COST[Item.ANTI_BALLISTIC_MISSILE][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 1.0 },
                    { Item.ATTACK_STRENGTH, 1.0 }
                }
            },
            {
                Item.INTERPLANETARY_MISSILE, new()
                {
                    { Item.STRUCTURAL_INTEGRITY, COST[Item.INTERPLANETARY_MISSILE][Item.METAL] + COST[Item.INTERPLANETARY_MISSILE][Item.CRYSTAL] },
                    { Item.SHIELD_STRENGTH, 1.0 },
                    { Item.ATTACK_STRENGTH, 12_000.0 }
                }
            },
            #endregion
        };
        
        public static readonly Dictionary<Item, double> RESEARCH_EFFECT = new()
        {
            { Item.ARMOUR_TECHNOLOGY, 0.1 },
            { Item.WEAPONS_TECHNOLOGY, 0.1 },
            { Item.SHIELDING_TECHNOLOGY, 0.1 },
            { Item.COMBUSTION_DRIVE, 0.1 },
            { Item.IMPULSE_DRIVE, 0.2 },
            { Item.HYPERSPACE_DRIVE, 0.3 },
            { Item.HYPERSPACE_TECHNOLOGY, 0.05 },
        };
        
        public static readonly Dictionary<Item, Dictionary<Item, int>> RAPIDFIRE = new()
        {
            {
                Item.SMALL_CARGO, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.LARGE_CARGO, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.COLONY_SHIP, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.RECYCLER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.LIGHT_FIGHTER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.HEAVY_FIGHTER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.SMALL_CARGO, 3 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.CRUISER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.LIGHT_FIGHTER, 6 },
                    { Item.ROCKER_LAUNCHER, 10 },
                    { Item.CRUISER, 5 }
                }
            },
            {
                Item.BATTLESHIP, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.PATHFINDER, 5 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.BATTLECRUISER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.HEAVY_FIGHTER, 4 },
                    { Item.CRUISER, 4 },
                    { Item.BATTLESHIP, 7 },
                    { Item.SMALL_CARGO, 3 },
                    { Item.LARGE_CARGO, 3 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.BOMBER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.ROCKER_LAUNCHER, 20 },
                    { Item.LIGHT_LASER, 20 },
                    { Item.HEAVY_LASER, 10 },
                    { Item.ION_CANNON, 10 },
                    { Item.GAUSS_CANNON, 5 },
                    { Item.PLASMA_TURRET, 5 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.DESTROYER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.LIGHT_LASER, 10 },
                    { Item.BATTLECRUISER, 2 },
                    { Item.CRAWLER, 5 }
                }
            },
            {
                Item.DEATHSTAR, new()
                {
                    { Item.ESPIONAGE_PROBE, 1250 },
                    { Item.SOLAR_SATELLITE, 1250 },
                    { Item.LIGHT_FIGHTER, 200 },
                    { Item.HEAVY_FIGHTER, 100 },
                    { Item.CRUISER, 33 },
                    { Item.BATTLESHIP, 30 },
                    { Item.BOMBER, 25 },
                    { Item.DESTROYER, 5 },
                    { Item.SMALL_CARGO, 250 },
                    { Item.LARGE_CARGO, 250 },
                    { Item.COLONY_SHIP, 250 },
                    { Item.RECYCLER, 250 },
                    { Item.ROCKER_LAUNCHER, 200 },
                    { Item.LIGHT_LASER, 200 },
                    { Item.HEAVY_LASER, 100 },
                    { Item.ION_CANNON, 100 },
                    { Item.GAUSS_CANNON, 50 },
                    { Item.BATTLECRUISER, 15 },
                    { Item.REAPER, 10 },
                    { Item.PATHFINDER, 30 },
                    { Item.CRAWLER, 1250 }
                }
            },
            {
                Item.REAPER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.CRAWLER, 5 },
                    { Item.BATTLESHIP, 7 },
                    { Item.BOMBER, 4 },
                    { Item.DESTROYER, 3 }
                }
            },
            {
                Item.PATHFINDER, new()
                {
                    { Item.ESPIONAGE_PROBE, 5 },
                    { Item.SOLAR_SATELLITE, 5 },
                    { Item.CRAWLER, 5 },
                    { Item.CRUISER, 3 },
                    { Item.LIGHT_FIGHTER, 3 },
                    { Item.HEAVY_FIGHTER, 2 }
                }
            },
            {
                Item.ION_CANNON, new()
                {
                    { Item.REAPER, 2 }
                }
            }
        };

        public static readonly Dictionary<Item, double> PLASMA_FACTOR = new()
        {
            { Item.METAL, 0.01 },
            { Item.CRYSTAL, 0.0066 },
            { Item.DEUTERIUM, 0.0033 }
        };

        public static readonly Dictionary<Item, double> CRAWLER_FACTOR = new()
        {
            { Item.METAL, 0.0002 },
            { Item.CRYSTAL, 0.0002 },
            { Item.DEUTERIUM, 0.0002 }
        };

        public static readonly Dictionary<Item, Dictionary<Item, int>> REQUIREMENTS = new()
        {
            #region Buildings
            {
                Item.FUSION_REACTOR, new()
                {
                    { Item.DEUTERIUM_SYNTHESIZER, 5 },
                    { Item.ENERGY_TECHNOLOGY, 3 }
                }
            },
            {
                Item.NANITE_FACTORY, new()
                {
                    { Item.ROBOTICS_FACTORY, 10 },
                    { Item.COMPUTER_TECHNOLOGY, 10 }
                }
            },
            {
                Item.SHIPYARD, new()
                {
                    { Item.ROBOTICS_FACTORY, 2 }
                }
            },
            {
                Item.SPACE_DOCK, new()
                {
                    { Item.SHIPYARD, 2 }
                }
            },
            {
                Item.MISSILE_SILO, new()
                {
                    { Item.SHIPYARD, 1 }
                }
            },
            {
                Item.TERRAFORMER, new()
                {
                    { Item.NANITE_FACTORY, 1 },
                    { Item.ENERGY_TECHNOLOGY, 12 }
                }
            },
            {
                Item.LUNAR_BASE, new()
                {
                    { Item.NANITE_FACTORY, 2 },
                    { Item.ENERGY_TECHNOLOGY, 14 }
                }
            },
            {
                Item.SENSOR_PHALANX, new()
                {
                    { Item.LUNAR_BASE, 1 }
                }
            },
            {
                Item.JUMP_GATE, new()
                {
                    { Item.LUNAR_BASE, 1 },
                    { Item.HYPERSPACE_TECHNOLOGY, 7 }
                }
            },
            #endregion

            #region Researches
            {
                Item.ENERGY_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 1 }
                }
            },
            {
                Item.LASER_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 1 },
                    { Item.ENERGY_TECHNOLOGY, 2 }
                }
            },
            {
                Item.ION_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 4 },
                    { Item.ENERGY_TECHNOLOGY, 4 },
                    { Item.LASER_TECHNOLOGY, 5 }
                }
            },
            {
                Item.HYPERSPACE_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 7 },
                    { Item.ENERGY_TECHNOLOGY, 5 },
                    { Item.SHIELDING_TECHNOLOGY, 5 }
                }
            },
            {
                Item.PLASMA_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 4 },
                    { Item.ENERGY_TECHNOLOGY, 8 },
                    { Item.LASER_TECHNOLOGY, 10 },
                    { Item.ION_TECHNOLOGY, 5 }
                }
            },
            {
                Item.ESPIONAGE_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 3 }
                }
            },
            {
                Item.COMPUTER_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 1 }
                }
            },
            {
                Item.ASTROPHISICS, new()
                {
                    { Item.RESEARCH_LAB, 3 },
                    { Item.ESPIONAGE_TECHNOLOGY, 4 },
                    { Item.IMPULSE_DRIVE, 3 }
                }
            },
            {
                Item.IRN, new()
                {
                    { Item.RESEARCH_LAB, 10 },
                    { Item.COMPUTER_TECHNOLOGY, 8 },
                    { Item.HYPERSPACE_TECHNOLOGY, 8 }
                }
            },
            {
                Item.GRAVITON_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 12 }
                }
            },
            {
                Item.COMBUSTION_DRIVE, new()
                {
                    { Item.RESEARCH_LAB, 1 },
                    { Item.ENERGY_TECHNOLOGY, 1 }
                }
            },
            {
                Item.IMPULSE_DRIVE, new()
                {
                    { Item.RESEARCH_LAB, 2 },
                    { Item.ENERGY_TECHNOLOGY, 1 }
                }
            },
            {
                Item.HYPERSPACE_DRIVE, new()
                {
                    { Item.RESEARCH_LAB, 7 },
                    { Item.HYPERSPACE_TECHNOLOGY, 3 }
                }
            },
            {
                Item.WEAPONS_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 4 }
                }
            },
            {
                Item.SHIELDING_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 6 },
                    { Item.ENERGY_TECHNOLOGY, 3 }
                }
            },
            {
                Item.ARMOUR_TECHNOLOGY, new()
                {
                    { Item.RESEARCH_LAB, 2 }
                }
            },
            #endregion

            #region Fleet
            {
                Item.LIGHT_FIGHTER, new()
                {
                    { Item.SHIPYARD, 1 },
                    { Item.COMBUSTION_DRIVE, 1}
                }
            },
            {
                Item.HEAVY_FIGHTER, new()
                {
                    { Item.SHIPYARD, 3 },
                    { Item.ARMOUR_TECHNOLOGY, 2 },
                    { Item.IMPULSE_DRIVE, 2 }
                }
            },
            {
                Item.CRUISER, new()
                {
                    { Item.SHIPYARD, 5 },
                    { Item.IMPULSE_DRIVE, 4 },
                    { Item.ION_TECHNOLOGY, 2 }
                }
            },
            {
                Item.BATTLESHIP, new()
                {
                    { Item.SHIPYARD, 7 },
                    { Item.HYPERSPACE_DRIVE, 4 }
                }
            },
            {
                Item.BATTLECRUISER, new()
                {
                    { Item.SHIPYARD, 8 },
                    { Item.HYPERSPACE_TECHNOLOGY, 5 },
                    { Item.HYPERSPACE_DRIVE, 5 },
                    { Item.LASER_TECHNOLOGY, 12 }
                }
            },
            {
                Item.BOMBER, new()
                {
                    { Item.SHIPYARD, 8 },
                    { Item.IMPULSE_DRIVE, 6 },
                    { Item.PLASMA_TECHNOLOGY, 5 }
                }
            },
            {
                Item.DESTROYER, new()
                {
                    { Item.SHIPYARD, 9 },
                    { Item.HYPERSPACE_TECHNOLOGY, 5 },
                    { Item.HYPERSPACE_DRIVE, 6 }
                }
            },
            {
                Item.DEATHSTAR, new()
                {
                    { Item.SHIPYARD, 12 },
                    { Item.HYPERSPACE_TECHNOLOGY, 6 },
                    { Item.HYPERSPACE_DRIVE, 7 },
                    { Item.GRAVITON_TECHNOLOGY, 1 }
                }
            },
            {
                Item.REAPER, new()
                {
                    { Item.SHIPYARD, 10 },
                    { Item.HYPERSPACE_TECHNOLOGY, 6 },
                    { Item.HYPERSPACE_DRIVE, 7 },
                    { Item.SHIELDING_TECHNOLOGY, 6 }
                }
            },
            {
                Item.PATHFINDER, new()
                {
                    { Item.SHIPYARD, 5 },
                    { Item.HYPERSPACE_DRIVE, 2 },
                    { Item.SHIELDING_TECHNOLOGY, 4 }
                }
            },
            {
                Item.SMALL_CARGO, new()
                {
                    { Item.SHIPYARD, 2 },
                    { Item.COMBUSTION_DRIVE, 2 }
                }
            },
            {
                Item.LARGE_CARGO, new()
                {
                    { Item.SHIPYARD, 4 },
                    { Item.COMBUSTION_DRIVE, 6 }
                }
            },
            {
                Item.COLONY_SHIP, new()
                {
                    { Item.SHIPYARD, 4 },
                    { Item.IMPULSE_DRIVE, 3 }
                }
            },
            {
                Item.RECYCLER, new()
                {
                    { Item.SHIPYARD, 4 },
                    { Item.COMBUSTION_DRIVE, 6 },
                    { Item.SHIELDING_TECHNOLOGY, 2 }
                }
            },
            {
                Item.ESPIONAGE_PROBE, new()
                {
                    { Item.SHIPYARD, 3 },
                    { Item.COMBUSTION_DRIVE, 3 },
                    { Item.ESPIONAGE_TECHNOLOGY, 2 }
                }
            },
            #endregion

            #region Fleebt but Defences
            {
                Item.SOLAR_SATELLITE, new()
                {
                    { Item.SHIPYARD, 1 }
                }
            },
            {
                Item.CRAWLER, new()
                {
                    { Item.SHIPYARD, 5 },
                    { Item.COMBUSTION_DRIVE, 4 },
                    { Item.ARMOUR_TECHNOLOGY, 4 },
                    { Item.LASER_TECHNOLOGY, 4 }
                }
            },
            #endregion

            #region Defences
            {
                Item.ROCKER_LAUNCHER, new()
                {
                    { Item.SHIPYARD, 1 }
                }
            },
            {
                Item.LIGHT_LASER, new()
                {
                    { Item.SHIPYARD, 2 },
                    { Item.ENERGY_TECHNOLOGY, 1 },
                    { Item.LASER_TECHNOLOGY, 3 }
                }
            },
            {
                Item.HEAVY_LASER, new()
                {
                    { Item.SHIPYARD, 4 },
                    { Item.ENERGY_TECHNOLOGY, 3 },
                    { Item.LASER_TECHNOLOGY, 6 }
                }
            },
            {
                Item.GAUSS_CANNON, new()
                {
                    { Item.SHIPYARD, 6 },
                    { Item.ENERGY_TECHNOLOGY, 6 },
                    { Item.WEAPONS_TECHNOLOGY, 3 },
                    { Item.SHIELDING_TECHNOLOGY, 1 }
                }
            },
            {
                Item.ION_CANNON, new()
                {
                    { Item.SHIPYARD, 4 },
                    { Item.ION_TECHNOLOGY, 4 }
                }
            },
            {
                Item.PLASMA_TURRET, new()
                {
                    { Item.SHIPYARD, 8 },
                    { Item.PLASMA_TECHNOLOGY, 7 }
                }
            },
            {
                Item.SMALL_SHIELD_DOME, new()
                {
                    { Item.SHIPYARD, 1 },
                    { Item.SHIELDING_TECHNOLOGY, 2 }
                }
            },
            {
                Item.LARGE_SHIELD_DOME, new()
                {
                    { Item.SHIPYARD, 6 },
                    { Item.SHIELDING_TECHNOLOGY, 6 }
                }
            },
            {
                Item.ANTI_BALLISTIC_MISSILE, new()
                {
                    { Item.SHIPYARD, 1 },
                    { Item.MISSILE_SILO, 2 }
                }
            },
            {
                Item.INTERPLANETARY_MISSILE, new()
                {
                    { Item.SHIPYARD, 1 },
                    { Item.MISSILE_SILO, 4 },
                    { Item.IMPULSE_DRIVE, 1 }
                }
            }
            #endregion
        };
    }
}
