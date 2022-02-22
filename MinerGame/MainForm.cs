using Newtonsoft.Json;
using OgameData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinerGame
{
    public partial class MainForm : Form
    {
        #region Private Fields
        private OGame ogame;
        private Planet activePlanet;

        private Dictionary<Item, Label> NameLabelList;

        private Dictionary<Item, Label> ResearchLevelLabelList;
        private Dictionary<Item, Label> BuildingLevelLabelList;

        private Dictionary<Item, Label[]> ResearchCostLabelsList;
        private Dictionary<Item, Label[]> BuildingCostLabelsList;

        private Dictionary<Item, Label> ResearchDurationLabelList;
        private Dictionary<Item, Label> BuildingDurationLabelList;

        private Dictionary<Item, Button> ResearchUpgradeButtonList;
        private Dictionary<Item, Button> BuildingUpgradeButtonList;

        private Dictionary<Item, Label> BuildingTimeRemainLabelList;
        private Dictionary<Item, Label> ResearchTimeRemainLabelList;

        // flota i obrona, do zrobienia w formularzu
        //private Dictionary<Item, Label> CountLabelList;
        //private Dictionary<Item, Label[]> UnitCostLabelList;
        //private Dictionary<Item, Label> UnitConstructDurationLabelList;
        //private Dictionary<Item, Button> ConstructButtonList;
        //private Dictionary<Item, Label> ConstructTimeRemainLabelList;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            InitLists();
        }

        #region Events
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string ogameSerialized = JsonConvert.SerializeObject(ogame);

            saveFileDialog.Filter = "json files (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new(saveFileDialog.FileName);
                sw.WriteLine(ogameSerialized);
            }
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            OGame.GameSpeed = GetFactorSpeed(tbEcoSpeed.Text);
            ogame = new OGame(GetGameName());

            tbNewGameName.Text = "";
            tbEcoSpeed.Text = "";

            // kod do testu
            StarterPack();
            ///

            CreatePlanetsList();
            activePlanet = ogame.Planets[0];

            FillInfoPanel();
            FillTabs();
            EnableUpgradeButtons();

            EnableSaveUpdateButtons();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog.FileName;
                    string deserializedOgame = File.ReadAllText(filePath);
                    ogame = JsonConvert.DeserializeObject<OGame>(deserializedOgame);

                    CreatePlanetsList();
                    activePlanet = ogame.Planets[0];

                    FillInfoPanel();
                    FillTabs();
                    EnableUpgradeButtons();

                    EnableSaveUpdateButtons();
                }
                catch
                {
                    MessageBox.Show("Jakas errora");
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ogame.UpdateResources(UpdateTimeEventList());

            FillInfoPanel();
            FillTabs();
            EnableUpgradeButtons();
        }

        private void CbPlanetSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ((ComboBox)sender).SelectedIndex;

            activePlanet = ogame.Planets[index];

            FillInfoPanel();
            FillTabs();
            EnableUpgradeButtons();
        }

        private void BtnDeletePlanet_Click(object sender, EventArgs e)
        {
            string MessageBoxTitle = "Usuwanie planety";
            string MessageBoxContent = $"Czy napewno chcesz usunąć planetę {activePlanet.PlanetName}?\nTego nie można cofnąć.";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ogame.Planets.Remove(activePlanet);
                OGame.Positions.Remove(activePlanet.Position);

                RemoveTimeEventsAfterRemovePlanet();

                ogame.UpdateResources(DateTime.Now);

                CreatePlanetsList();
                activePlanet = ogame.Planets[0];

                pProductionGeneratedContent.Controls.Clear();

                FillInfoPanel();
                FillTabs();
                EnableUpgradeButtons();
            }
        }

        private void BtnNewPlanet_Click(object sender, EventArgs e)
        {
            ogame.UpdateResources(DateTime.Now);

            //activePlanet.Fleet[Item.COLONY_SHIP]--;

            int id = FindPlanetID();

            ogame.Planets.Add(new Planet(id));
            Planet p = ogame.Planets.ElementAt(ogame.Planets.Count - 1);
            cbPlanetSelect.Items.Add($"{p.PlanetName} {p.Position}");

            pProductionGeneratedContent.Controls.Clear();

            FillInfoPanel();
            FillTabs();
        }

        private void BtnUpgradeBuilding_Click(object sender, EventArgs e)
        {
            ogame.UpdateResources(DateTime.Now);

            Item item = BuildingUpgradeButtonList.Where(btn => btn.Value == (Button)sender).Select(btn => btn.Key).ToList().ElementAt(0);
            Resources cost = GameHandler.UpgradeCost(item, activePlanet.Buildings[item].Level + 1);
            activePlanet.Resources.Subtract(cost);
            activePlanet.Buildings[item].IsProcessing = true;            

            TimeSpan duration = GameHandler.BuildingTime(cost, activePlanet.Buildings[Item.ROBOTICS_FACTORY].Level, activePlanet.Buildings[Item.NANITE_FACTORY].Level);

            OGame.TimeEvents.Add(new TimeEvent(item, activePlanet.PlanetID, ogame.LastUpdate.Add(duration)));
            OGame.TimeEvents = OGame.TimeEvents.OrderBy(te => te.ProcessFinish).ToList();

            FillInfoPanel();
            FillTabs();
            EnableUpgradeButtons();
        }

        private void BtnResearchUpgrade_Click(object sender, EventArgs e)
        {
            ogame.UpdateResources(DateTime.Now);

            Item item = ResearchUpgradeButtonList.Where(btn => btn.Value == (Button)sender).Select(btn => btn.Key).ToList().ElementAt(0);
            Resources cost = GameHandler.UpgradeCost(item, OGame.Researches[item].Level + 1);
            activePlanet.Resources.Subtract(cost);
            OGame.Researches[item].IsProcessing = true;
            
            int lablvl = GameHandler.LabLevel(activePlanet, ogame.Planets, OGame.Researches[Item.IRN].Level, GameData.REQUIREMENTS[item][Item.RESEARCH_LAB]);
            TimeSpan duration = GameHandler.ResearchTime(cost, lablvl, OGame.Researches[Item.GRAVITON_TECHNOLOGY].Level);

            OGame.TimeEvents.Add(new TimeEvent(item, activePlanet.PlanetID, ogame.LastUpdate.Add(duration)));
            OGame.TimeEvents = OGame.TimeEvents.OrderBy(te => te.ProcessFinish).ToList();

            FillInfoPanel();
            FillTabs();
            EnableUpgradeButtons();
        }

        private void BtnGravitonTechnologyUpgrade_Click(object sender, EventArgs e)
        {
            ogame.UpdateResources(DateTime.Now);
            OGame.Researches[Item.GRAVITON_TECHNOLOGY].Level++;

            FillInfoPanel();
            FillTabs();
            EnableUpgradeButtons();
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                if (tb.Name.Equals(tbNewGameName.Name))
                {
                    tb.Text = "Nazwa gry";
                }

                if (tb.Name.Equals(tbEcoSpeed.Name))
                {
                    tb.Text = "Prędkość symulacji";
                }
            }
        }

        private void BtnChangePlanetName_Click(object sender, EventArgs e)
        {
            if (tbNewPlanetName.Text.Length != 0)
            {
                activePlanet.PlanetName = tbNewPlanetName.Text;
            }

            FillInfoPanel();
            FillTabs();
        }
        #endregion

        #region Lists initializers
        private void InitLists()
        {
            InitNameLabelList();

            InitResearchLevelLabelList();
            InitBuildingLevelLabelList();

            InitResearchCostLabelList();
            InitBuildingCostLabelList();

            InitResearchDurationLabelList();
            InitBuildingDurationLabelList();

            InitResearchUpgradeButtonList();
            InitBuildingUpgradeButtonList();

            InitBuildingTimeRemainLabelList();
            InitResearchTimeRemainLabelList();
        }

        private void InitNameLabelList()
        {
            NameLabelList = new Dictionary<Item, Label>()
            {
                #region Buildings
                { Item.METAL_MINE, lblMetalMine },
                { Item.CRYSTAL_MINE, lblCrystalMine },
                { Item.DEUTERIUM_SYNTHESIZER, lblDeuteriumSynthesizer },
                { Item.SOLAR_PLANT, lblSolarPlant },
                { Item.FUSION_REACTOR, lblFusionReactor },
                { Item.METAL_STORAGE, lblMetalStorage },
                { Item.CRYSTAL_STORAGE, lblCrystalStorage },
                { Item.DEUTERIUM_TANK, lblDeuteriumTank },

                { Item.ROBOTICS_FACTORY, lblRoboticsFactory },
                { Item.NANITE_FACTORY, lblNaniteFactory },
                { Item.SHIPYARD, lblShipyard },
                { Item.RESEARCH_LAB, lblResearchLab },
                { Item.MISSILE_SILO, lblMissileSilo },
                { Item.TERRAFORMER, lblTerraformer },
                { Item.SPACE_DOCK, lblSpaceDock },

                { Item.LUNAR_BASE, lblLunarBase },
                { Item.SENSOR_PHALANX, lblSensorPhalanx },
                { Item.JUMP_GATE, lblJumpGate },
                #endregion

                #region Research
                { Item.ESPIONAGE_TECHNOLOGY, lblEspionageTechnology },
                { Item.COMPUTER_TECHNOLOGY, lblComputerTechnology },
                { Item.COMBUSTION_DRIVE, lblCombustionDrive },
                { Item.IMPULSE_DRIVE, lblImpulseDrive },
                { Item.HYPERSPACE_DRIVE, lblHyperspaceDrive },
                { Item.WEAPONS_TECHNOLOGY, lblWeapeonsTechnology },
                { Item.SHIELDING_TECHNOLOGY, lblShieldingTechnology },
                { Item.ARMOUR_TECHNOLOGY, lblArmourTechnology },
                { Item.ENERGY_TECHNOLOGY, lblEnergyTechnology },
                { Item.LASER_TECHNOLOGY, lblLaserTechnology },
                { Item.ION_TECHNOLOGY, lblIonTechnology },
                { Item.HYPERSPACE_TECHNOLOGY, lblHyperspaceTechnology },
                { Item.PLASMA_TECHNOLOGY, lblPlasmaTechnology },
                { Item.ASTROPHISICS, lblAstrophisics },
                { Item.IRN, lblIrn },
                { Item.GRAVITON_TECHNOLOGY, lblGravitonTechnology },
                #endregion

                #region Defences

                #endregion

                #region Fleet but Defences

                #endregion

                #region Fleet

                #endregion

            };
        }

        private void InitResearchLevelLabelList()
        {
            ResearchLevelLabelList = new Dictionary<Item, Label>()
            {
                { Item.ESPIONAGE_TECHNOLOGY, lblEspionageTechnologyLevel },
                { Item.COMPUTER_TECHNOLOGY, lblComputerTechnologyLevel },
                { Item.COMBUSTION_DRIVE, lblCombustionDriveLevel },
                { Item.IMPULSE_DRIVE, lblImpulseDriveLevel },
                { Item.HYPERSPACE_DRIVE, lblHyperspaceDriveLevel },
                { Item.WEAPONS_TECHNOLOGY, lblWeapeonsTechnologyLevel },
                { Item.SHIELDING_TECHNOLOGY, lblShieldingTechnologyLevel },
                { Item.ARMOUR_TECHNOLOGY, lblArmourTechnologyLevel },
                { Item.ENERGY_TECHNOLOGY, lblEnergyTechnologyLevel },
                { Item.LASER_TECHNOLOGY, lblLaserTechnologyLevel },
                { Item.ION_TECHNOLOGY, lblIonTechnologyLevel },
                { Item.HYPERSPACE_TECHNOLOGY, lblHyperspaceTechnologyLevel },
                { Item.PLASMA_TECHNOLOGY, lblPlasmaTechnologyLevel },
                { Item.ASTROPHISICS, lblAstrophisicsLevel },
                { Item.IRN, lblIrnLevel },
                { Item.GRAVITON_TECHNOLOGY, lblGravitonTechnologyLevel }
            };
        }

        private void InitBuildingLevelLabelList()
        {
            BuildingLevelLabelList = new Dictionary<Item, Label>()
            {
                { Item.METAL_MINE, lblMetalMineLevel },
                { Item.CRYSTAL_MINE, lblCrystalMineLevel },
                { Item.DEUTERIUM_SYNTHESIZER, lblDeuteriumSynthesizerLevel },
                { Item.SOLAR_PLANT, lblSolarPlantLevel },
                { Item.FUSION_REACTOR, lblFusionReactorLevel },
                { Item.METAL_STORAGE, lblMetalStorageLevel },
                { Item.CRYSTAL_STORAGE, lblCrystalStorageLevel },
                { Item.DEUTERIUM_TANK, lblDeuteriumTankLevel },

                { Item.ROBOTICS_FACTORY, lblRoboticsFactoryLevel },
                { Item.NANITE_FACTORY, lblNaniteFactoryLevel },
                { Item.SHIPYARD, lblShipyardLevel },
                { Item.RESEARCH_LAB, lblResearchLabLevel },
                { Item.MISSILE_SILO, lblMissileSiloLevel },
                { Item.TERRAFORMER, lblTerraformerLevel },
                { Item.SPACE_DOCK, lblSpaceDockLevel },

                { Item.LUNAR_BASE, lblLunarBaseLevel },
                { Item.SENSOR_PHALANX, lblSensorPhalanxLevel },
                { Item.JUMP_GATE, lblJumpGateLevel }
            };
        }

        private void InitResearchCostLabelList()
        {
            ResearchCostLabelsList = new Dictionary<Item, Label[]>()
            {
                { Item.ESPIONAGE_TECHNOLOGY, new Label[] { lblEspionageTechnologyMetalCost, lblEspionageTechnologyCrystalCost, lblEspionageTechnologyDeuteriumCost } },
                { Item.COMPUTER_TECHNOLOGY, new Label[] { lblComputerTechnologyMetalCost, lblComputerTechnologyCrystalCost, lblComputerTechnologyDeuteriumCost } },
                { Item.COMBUSTION_DRIVE, new Label[] { lblCombustionDriveMetalCost, lblCombustionDriveCrystalCost, lblCombustionDriveDeuteriumCost } },
                { Item.IMPULSE_DRIVE, new Label[] { lblImpulseDriveMetalCost, lblImpulseDriveCrystalCost, lblImpulseDriveDeuteriumCost } },
                { Item.HYPERSPACE_DRIVE, new Label[] { lblHyperspaceDriveMetalCost, lblHyperspaceDriveCrystalCost, lblHyperspaceDriveDeuteriumCost } },
                { Item.WEAPONS_TECHNOLOGY, new Label[] { lblWeapeonsTechnologyMetalCost, lblWeapeonsTechnologyCrystalCost, lblWeapeonsTechnologyDeuteriumCost } },
                { Item.SHIELDING_TECHNOLOGY, new Label[] { lblShieldingTechnologyMetalCost, lblShieldingTechnologyCrystalCost, lblShieldingTechnologyDeuteriumCost } },
                { Item.ARMOUR_TECHNOLOGY, new Label[] { lblArmourTechnologyMetalCost, lblArmourTechnologyCrystalCost, lblArmourTechnologyDeuteriumCost } },
                { Item.ENERGY_TECHNOLOGY, new Label[] { lblEnergyTechnologyMetalCost, lblEnergyTechnologyCrystalCost, lblEnergyTechnologyDeuteriumCost } },
                { Item.LASER_TECHNOLOGY, new Label[] { lblLaserTechnologyMetalCost, lblLaserTechnologyCrystalCost, lblLaserTechnologyDeuteriumCost } },
                { Item.ION_TECHNOLOGY, new Label[] { lblIonTechnologyMetalCost, lblIonTechnologyCrystalCost, lblIonTechnologyDeuteriumCost } },
                { Item.HYPERSPACE_TECHNOLOGY, new Label[] { lblHyperspaceTechnologyMetalCost, lblHyperspaceTechnologyCrystalCost, lblHyperspaceTechnologyDeuteriumCost } },
                { Item.PLASMA_TECHNOLOGY, new Label[] { lblPlasmaTechnologyMetalCost, lblPlasmaTechnologyCrystalCost, lblPlasmaTechnologyDeuteriumCost } },
                { Item.ASTROPHISICS, new Label[] { lblAstrophisicsMetalCost, lblAstrophisicsCrystalCost, lblAstrophisicsDeuteriumCost } },
                { Item.IRN, new Label[] { lblIrnMetalCost, lblIrnCrystalCost, lblIrnDeuteriumCost } },
                { Item.GRAVITON_TECHNOLOGY, new Label[] { lblGravitonTechnologyMetalCost, lblGravitonTechnologyCrystalCost, lblGravitonTechnologyDeuteriumCost } }

            };
        }

        private void InitBuildingCostLabelList()
        {
            BuildingCostLabelsList = new Dictionary<Item, Label[]>()
            {
                { Item.METAL_MINE, new Label[] { lblMetalMineMetalCost, lblMetalMineCrystalCost, lblMetalMineDeuteriumCost } },
                { Item.CRYSTAL_MINE, new Label[] { lblCrystalMineMetalCost, lblCrystalMineCrystalCost, lblCrystalMineDeuteriumCost } },
                { Item.DEUTERIUM_SYNTHESIZER, new Label[] { lblDeuteriumSynthesizerMetalCost, lblDeuteriumSynthesizerCrystalCost, lblDeuteriumSynthesizerDeuteriumCost } },
                { Item.SOLAR_PLANT, new Label[] { lblSolarPlantMetalCost, lblSolarPlantCrystalCost, lblSolarPlantDeuteriumCost } },
                { Item.FUSION_REACTOR, new Label[] { lblFusionReactorMetalCost, lblFusionReactorCrystalCost, lblFusionReactorDeuteriumCost } },
                { Item.METAL_STORAGE, new Label[] { lblMetalStorageMetalCost, lblMetalStorageCrystalCost, lblMetalStorageDeuteriumCost } },
                { Item.CRYSTAL_STORAGE, new Label[] { lblCrystalStorageMetalCost, lblCrystalStorageCrystalCost, lblCrystalStorageDeuteriumCost } },
                { Item.DEUTERIUM_TANK, new Label[] { lblDeuteriumTankMetalCost, lblDeuteriumTankCrystalCost, lblDeuteriumTankDeuteriumCost } },

                { Item.ROBOTICS_FACTORY, new Label[] { lblRoboticsFactoryMetalCost, lblRoboticsFactoryCrystalCost, lblRoboticsFactoryDeuteriumCost } },
                { Item.NANITE_FACTORY, new Label[] { lblNaniteFactoryMetalCost, lblNaniteFactoryCrystalCost, lblNaniteFactoryDeuteriumCost } },
                { Item.SHIPYARD, new Label[] { lblShipyardMetalCost, lblShipyardCrystalCost, lblShipyardDeuteriumCost } },
                { Item.RESEARCH_LAB, new Label[] { lblResearchLabMetalCost, lblResearchLabCrystalCost, lblResearchLabDeuteriumCost } },
                { Item.MISSILE_SILO, new Label[] { lblMissileSiloMetalCost, lblMissileSiloCrystalCost, lblMissileSiloDeuteriumCost } },
                { Item.TERRAFORMER, new Label[] { lblTerraformerMetalCost, lblTerraformerCrystalCost, lblTerraformerDeuteriumCost } },
                { Item.SPACE_DOCK, new Label[] { lblSpaceDockMetalCost, lblSpaceDockCrystalCost, lblSpaceDockDeuteriumCost } },

                { Item.LUNAR_BASE, new Label[] { lblLunarBaseMetalCost, lblLunarBaseCrystalCost, lblLunarBaseDeuteriumCost } },
                { Item.SENSOR_PHALANX, new Label[] { lblSensorPhalanxMetalCost, lblSensorPhalanxCrystalCost, lblSensorPhalanxDeuteriumCost } },
                { Item.JUMP_GATE, new Label[] { lblJumpGateMetalCost, lblJumpGateCrystalCost, lblJumpGateDeuteriumCost } }
            };
        }

        private void InitResearchDurationLabelList()
        {
            ResearchDurationLabelList = new Dictionary<Item, Label>()
            {
                { Item.ESPIONAGE_TECHNOLOGY, lblEspionageTechnologyDuration },
                { Item.COMPUTER_TECHNOLOGY, lblComputerTechnologyDuration },
                { Item.COMBUSTION_DRIVE, lblCombustionDriveDuration },
                { Item.IMPULSE_DRIVE, lblImpulseDriveDuration },
                { Item.HYPERSPACE_DRIVE, lblHyperspaceDriveDuration },
                { Item.WEAPONS_TECHNOLOGY, lblWeapeonsTechnologyDuration },
                { Item.SHIELDING_TECHNOLOGY, lblShieldingTechnologyDuration },
                { Item.ARMOUR_TECHNOLOGY, lblArmourTechnologyDuration },
                { Item.ENERGY_TECHNOLOGY, lblEnergyTechnologyDuration },
                { Item.LASER_TECHNOLOGY, lblLaserTechnologyDuration },
                { Item.ION_TECHNOLOGY, lblIonTechnologyDuration },
                { Item.HYPERSPACE_TECHNOLOGY, lblHyperspaceTechnologyDuration },
                { Item.PLASMA_TECHNOLOGY, lblPlasmaTechnologyDuration },
                { Item.ASTROPHISICS, lblAstrophisicsDuration },
                { Item.IRN, lblIrnDuration },
                { Item.GRAVITON_TECHNOLOGY, lblGravitonTechnologyDuration }
            };
        }

        private void InitBuildingDurationLabelList()
        {
            BuildingDurationLabelList = new Dictionary<Item, Label>()
            {
                { Item.METAL_MINE, lblMetalMineDuration },
                { Item.CRYSTAL_MINE, lblCrystalMineDuration },
                { Item.DEUTERIUM_SYNTHESIZER, lblDeuteriumSynthesizerDuration },
                { Item.SOLAR_PLANT, lblSolarPlantDuration },
                { Item.FUSION_REACTOR, lblFusionReactorDuration },
                { Item.METAL_STORAGE, lblMetalStorageDuration },
                { Item.CRYSTAL_STORAGE, lblCrystalStorageDuration },
                { Item.DEUTERIUM_TANK, lblDeuteriumTankDuration },

                { Item.ROBOTICS_FACTORY, lblRoboticsFactoryDuration },
                { Item.NANITE_FACTORY, lblNaniteFactoryDuration },
                { Item.SHIPYARD, lblShipyardDuration },
                { Item.RESEARCH_LAB, lblResearchLabDuration },
                { Item.MISSILE_SILO, lblMissileSiloDuration },
                { Item.TERRAFORMER, lblTerraformerDuration },
                { Item.SPACE_DOCK, lblSpaceDockDuration },

                { Item.LUNAR_BASE, lblLunarBaseDuration },
                { Item.SENSOR_PHALANX, lblSensorPhalanxDuration },
                { Item.JUMP_GATE, lblJumpGateDuration }
            };
        }

        private void InitResearchUpgradeButtonList()
        {
            ResearchUpgradeButtonList = new Dictionary<Item, Button>()
            {
                { Item.ESPIONAGE_TECHNOLOGY, btnEspionageTechnologyUpgrade },
                { Item.COMPUTER_TECHNOLOGY, btnComputerTechnologyUpgrade },
                { Item.COMBUSTION_DRIVE, btnCombustionDriveUpgrade },
                { Item.IMPULSE_DRIVE, btnImpulseDriveUpgrade },
                { Item.HYPERSPACE_DRIVE, btnHyperspaceDriveUpgrade },
                { Item.WEAPONS_TECHNOLOGY, btnWeapeonsTechnologyUpgrade },
                { Item.SHIELDING_TECHNOLOGY, btnShieldingTechnologyUpgrade },
                { Item.ARMOUR_TECHNOLOGY, btnArmourTechnologyUpgrade },
                { Item.ENERGY_TECHNOLOGY, btnEnergyTechnologyUpgrade },
                { Item.LASER_TECHNOLOGY, btnLaserTechnologyUpgrade },
                { Item.ION_TECHNOLOGY, btnIonTechnologyUpgrade },
                { Item.HYPERSPACE_TECHNOLOGY, btnHyperspaceTechnologyUpgrade },
                { Item.PLASMA_TECHNOLOGY, btnPlasmaTechnologyUpgrade },
                { Item.ASTROPHISICS, btnAstrophisicsUpgrade },
                { Item.IRN, btnIrnUpgrade },
                { Item.GRAVITON_TECHNOLOGY, btnGravitonTechnologyUpgrade }
            };
        }

        private void InitBuildingUpgradeButtonList()
        {
            BuildingUpgradeButtonList = new Dictionary<Item, Button>()
            {
                { Item.METAL_MINE, btnMetalMineUpgrade },
                { Item.CRYSTAL_MINE, btnCrystalMineUpgrade },
                { Item.DEUTERIUM_SYNTHESIZER, btnDeuteriumSynthesizerUpgrade },
                { Item.SOLAR_PLANT, btnSolarPlantUpgrade },
                { Item.FUSION_REACTOR, btnFusionReactorUpgrade },
                { Item.METAL_STORAGE, btnMetalStorageUpgrade },
                { Item.CRYSTAL_STORAGE, btnCrystalStorageUpgrade },
                { Item.DEUTERIUM_TANK, btnDeuteriumTankUpgrade },

                { Item.ROBOTICS_FACTORY, btnRoboticsFactoryUpgrade },
                { Item.NANITE_FACTORY, btnNaniteFactoryUpgrade },
                { Item.SHIPYARD, btnShipyardUpgrade },
                { Item.RESEARCH_LAB, btnResearchLabUpgrade },
                { Item.MISSILE_SILO, btnMissileSiloUpgrade },
                { Item.TERRAFORMER, btnTerraformerUpgrade },
                { Item.SPACE_DOCK, btnSpaceDockUpgrade },

                { Item.LUNAR_BASE, btnLunarBaseUpgrade },
                { Item.SENSOR_PHALANX, btnSensorPhalanxUpgrade },
                { Item.JUMP_GATE, btnJumpGateUpgrade }
            };
        }

        private void InitBuildingTimeRemainLabelList()
        {
            BuildingTimeRemainLabelList = new Dictionary<Item, Label>()
            {
                { Item.METAL_MINE, lblMetalMineTimeRemain },
                { Item.CRYSTAL_MINE, lblCrystalMineTimeRemain },
                { Item.DEUTERIUM_SYNTHESIZER, lblDeuteriumSynthesizerTimeRemain },
                { Item.SOLAR_PLANT, lblSolarPlantTimeRemain },
                { Item.FUSION_REACTOR, lblFusionReactorTimeRemain },
                { Item.METAL_STORAGE, lblMetalStorageTimeRemain },
                { Item.CRYSTAL_STORAGE, lblCrystalStorageTimeRemain },
                { Item.DEUTERIUM_TANK, lblDeuteriumTanlTimeRemain },

                { Item.ROBOTICS_FACTORY, lblRoboticsFactoryTimeRemain },
                { Item.NANITE_FACTORY, lblNaniteFactoryTimeRemain },
                { Item.SHIPYARD, lblShipyardTimeRemain },
                { Item.RESEARCH_LAB, lblResearchLabTimeRemain },
                { Item.MISSILE_SILO, lblMissileSiloTimeRemain },
                { Item.TERRAFORMER, lblTerraformerTimeRemain },
                { Item.SPACE_DOCK, lblSpaceDockTimeRemain },

                { Item.LUNAR_BASE, lblLunarBaseTimeRemain },
                { Item.SENSOR_PHALANX, lblSensorPhalanxTimeRemain },
                { Item.JUMP_GATE, lblJumpGateTimeRemain }
            };
        }

        private void InitResearchTimeRemainLabelList()
        {
            ResearchTimeRemainLabelList = new Dictionary<Item, Label>()
            {
                { Item.ESPIONAGE_TECHNOLOGY, lblEspionageTechnologyTimeRemain },
                { Item.COMPUTER_TECHNOLOGY, lblComputerTechnologyTimeRemain },
                { Item.COMBUSTION_DRIVE, lblCombustionDriveTimeRemain },
                { Item.IMPULSE_DRIVE, lblImpulseDriveTimeRemain },
                { Item.HYPERSPACE_DRIVE, lblHyperspaceDriveTimeRemain },
                { Item.WEAPONS_TECHNOLOGY, lblWeaponsTechnologyTimeRemian },
                { Item.SHIELDING_TECHNOLOGY, lblShieldingTechnologyTimeRemain },
                { Item.ARMOUR_TECHNOLOGY, lblArmourTechnologyTimeRemain },
                { Item.ENERGY_TECHNOLOGY, lblEnergyTechnologyTimeRemain },
                { Item.LASER_TECHNOLOGY, lblLaserTechnologyTimeRemain },
                { Item.ION_TECHNOLOGY, lblIonTechnologyTimeRemain },
                { Item.HYPERSPACE_TECHNOLOGY, lblHyperspaceTechnologyTimeRemain },
                { Item.PLASMA_TECHNOLOGY, lblPlasmaTechnologyTimeRemain },
                { Item.ASTROPHISICS, lblAstrophisicsTimeRemain },
                { Item.IRN, lblIrnTimeRemain }
            };
        }
        #endregion

        #region Fill Info panel
        private void FillInfoPanel()
        {
            FillGameInfoGroupBox();
            FillPlanetInfoGroupBox();
            FillPlanetEnergyInfoGroupBox();
            FillStorageInfo();
            FillResourceInfo();
            FillPlanetCountInfo();
        }

        private void FillGameInfoGroupBox()
        {
            lblGameNameValue.Text = ogame.GameName;
            lblEcoSpeedValue.Text = "Prędkość gry: " + OGame.GameSpeed.ToString();
            UpdateLastUpdate();
        }

        private void UpdateLastUpdate()
        {
            lblLastUpdate.Text = ogame.LastUpdate.ToString();
        }

        private void FillPlanetInfoGroupBox()
        {
            lblPlanetNameValue.Text = activePlanet.PlanetName;
            lblTemperatureValue.Text = activePlanet.Temperature.ToString("N0") + " \u2103";
            FillPlanetFieldsLabel();
            lblDiameterValue.Text = activePlanet.Diameter.ToString("N0") + " km";
        }

        private void FillPlanetFieldsLabel()
        {
            int total = GameHandler.PlanetFields(activePlanet);
            int demand = 0;
            foreach (Building b in activePlanet.Buildings.Values)
            {
                demand += b.Level;
            }
            lblPlanetFields.Text = demand.ToString("N0") + " / " + total.ToString("N0");
        }

        private void FillPlanetEnergyInfoGroupBox()
        {
            //double available = GameHandler.SolarPlantProduction(activePlanet.Buildings[Item.SOLAR_PLANT].Level)
            //                  + GameHandler.FusionReactorProduction(activePlanet.Buildings[Item.FUSION_REACTOR].Level, OGame.Researches[Item.ENERGY_TECHNOLOGY].Level);

            double available = GameHandler.PlanetEnergyProduction(activePlanet);
            double demand = GameHandler.MetalMineEnergyDemand(activePlanet.Buildings[Item.METAL_MINE].Level)
                          + GameHandler.CrystalMineEnergyDemand(activePlanet.Buildings[Item.CRYSTAL_MINE].Level)
                          + GameHandler.DeuteriumSynthesizerEnergyDemand(activePlanet.Buildings[Item.DEUTERIUM_SYNTHESIZER].Level);
            lblEnergyAvailableValue.Text = available.ToString("N0");
            lblEnergyDemandValue.Text = demand.ToString("N0");
            lblEnergyOverValue.Text = (available - demand).ToString("N0");
        }

        private void FillStorageInfo()
        {
            double totalMetalStorage = 0.0;
            double totalCrystalStorage = 0.0;
            double totalDeuteriumTank = 0.0;

            foreach (Planet p in ogame.Planets)
            {
                double metalStorage = GameHandler.StorageCapacity(p.Buildings[Item.METAL_STORAGE].Level);
                double crystalStorage = GameHandler.StorageCapacity(p.Buildings[Item.CRYSTAL_STORAGE].Level);
                double deuteriumTank = GameHandler.StorageCapacity(p.Buildings[Item.DEUTERIUM_TANK].Level);

                totalMetalStorage += metalStorage;
                totalCrystalStorage += crystalStorage;
                totalDeuteriumTank += deuteriumTank;

                if (p.Equals(activePlanet))
                {
                    lblStorageMetalPlanetValue.Text = metalStorage.ToString("N0");
                    lblStorageCrystalPlanetValue.Text = crystalStorage.ToString("N0");
                    lblStorageDeuteriumPlanetValue.Text = deuteriumTank.ToString("N0");
                }
            }
            lblStorageMetalTotalValue.Text = totalMetalStorage.ToString("N0");
            lblStorageCrystalTotalValue.Text = totalCrystalStorage.ToString("N0");
            lblStorageDeuteriumTotalValue.Text = totalDeuteriumTank.ToString("N0");
        }

        private void FillResourceInfo()
        {
            Resources total = new();

            foreach (Planet p in ogame.Planets)
            {
                total.Add(p.Resources);
                if (p.Equals(activePlanet))
                {
                    lblMetalPlanetValue.Text = Math.Floor(p.Resources.Metal).ToString("N0");
                    lblCrystalPlanetValue.Text = Math.Floor(p.Resources.Crystal).ToString("N0");
                    lblDeuteriumPlanetValue.Text = Math.Floor(p.Resources.Deuterium).ToString("N0");
                }
            }

            lblMetalTotalValue.Text = Math.Floor(total.Metal).ToString("N0");
            lblCrystalTotalValue.Text = Math.Floor(total.Crystal).ToString("N0");
            lblDeuteriumTotalValue.Text = Math.Floor(total.Deuterium).ToString("N0");
        }

        private void FillPlanetCountInfo()
        {
            int maxPlanets = (OGame.Researches[Item.ASTROPHISICS].Level + 1) / 2 + 1;
            int currentPlanetsCount = ogame.Planets.Count;

            lblPlanetCount.Text = currentPlanetsCount.ToString("N0") + " / " + maxPlanets.ToString("N0");

            //if (currentPlanetsCount < maxPlanets && activePlanet.Fleet[Item.COLONY_SHIP] > 0)
            if (currentPlanetsCount < maxPlanets)
            {
                btnNewPlanet.Enabled = true;
                btnNewPlanet.BackColor = Color.Lime;
            }
            else
            {
                btnNewPlanet.Enabled = false;
                btnNewPlanet.BackColor = Color.Silver;
            }

            var research = OGame.Researches.Where(r => r.Value.IsProcessing == true).ToList();
            bool researchInProgress = research.Count > 0;
            int planetID = -1;
            if (researchInProgress)
            {
                Item item = research.ElementAt(0).Key;
                planetID = OGame.TimeEvents.Where(te => te.Item == item).Select(te => te.PlanetID).ToList().ElementAt(0);
            }

            if (currentPlanetsCount > 1 && activePlanet.PlanetID != planetID)
            {
                btnDeletePlanet.Enabled = true;
                btnDeletePlanet.BackColor = Color.Lime;
            }
            else
            {
                btnDeletePlanet.Enabled = false;
                btnDeletePlanet.BackColor = Color.Silver;
            }
        }
        #endregion

        #region Fill Tabs

        private void FillTabs()
        {
            FillNameLabels();

            FillBuildingLevelLabel();
            FillResearchLevelLabel();

            FillBuildingCostAndDurationLabels();
            FillResearchCostAndDurationLabels();
            FillEnergyCost();

            FillProductionIncrease();
            FillStorageUpgrade();
            FillDemandIncerase();

            FillBuildingTimeRemainLabel();
            FillResearchTimeRemainLabel();

            FillProductionTab();
            FillPlanetTab();
        }

        private void FillNameLabels()
        {
            foreach (Item item in NameLabelList.Keys)
            {
                NameLabelList[item].Text = GameData.NAME[item];
            }
        }

        private void FillBuildingLevelLabel()
        {
            foreach (Item item in BuildingLevelLabelList.Keys)
            {
                BuildingLevelLabelList[item].Text = activePlanet.Buildings[item].Level.ToString("N0");
            }
        }

        private void FillResearchLevelLabel()
        {
            foreach (Item item in ResearchLevelLabelList.Keys)
            {
                ResearchLevelLabelList[item].Text = OGame.Researches[item].Level.ToString("N0");
            }
        }

        private void FillBuildingCostAndDurationLabels()
        {
            foreach (Item item in BuildingCostLabelsList.Keys)
            {
                Resources cost = GameHandler.UpgradeCost(item, activePlanet.Buildings[item].Level + 1);

                BuildingCostLabelsList[item].ElementAt(0).Text = cost.Metal.ToString("N0");
                BuildingCostLabelsList[item].ElementAt(1).Text = cost.Crystal.ToString("N0");
                BuildingCostLabelsList[item].ElementAt(2).Text = cost.Deuterium.ToString("N0");

                BuildingDurationLabelList[item].Text
                        = GameHandler.BuildingTime(cost, activePlanet.Buildings[Item.ROBOTICS_FACTORY].Level,
                                                   activePlanet.Buildings[Item.NANITE_FACTORY].Level)
                        .ToString("d'd 'hh'h 'mm'm 'ss's'");
            }
        }

        private void FillResearchCostAndDurationLabels()
        {
            foreach (Item item in ResearchCostLabelsList.Keys)
            {
                Resources cost = GameHandler.UpgradeCost(item, OGame.Researches[item].Level + 1);

                ResearchCostLabelsList[item].ElementAt(0).Text = cost.Metal.ToString("N0");
                ResearchCostLabelsList[item].ElementAt(1).Text = cost.Crystal.ToString("N0");
                ResearchCostLabelsList[item].ElementAt(2).Text = cost.Deuterium.ToString("N0");

                int lablvl = GameHandler.LabLevel(activePlanet, ogame.Planets, OGame.Researches[Item.IRN].Level, GameData.REQUIREMENTS[item][Item.RESEARCH_LAB]);
                ResearchDurationLabelList[item].Text
                       = GameHandler.ResearchTime(cost, lablvl, OGame.Researches[Item.GRAVITON_TECHNOLOGY].Level)
                       .ToString("d'd 'hh'h 'mm'm 'ss's'");
            }
        }

        private void FillStorageUpgrade()
        {
            lblMetalStorageNewStorage.Text = GameHandler.StorageCapacity(activePlanet.Buildings[Item.METAL_STORAGE].Level + 1).ToString("N0");
            lblCrystalStorageNewStorage.Text = GameHandler.StorageCapacity(activePlanet.Buildings[Item.CRYSTAL_STORAGE].Level + 1).ToString("N0");
            lblDeuteriumTankNewStorage.Text = GameHandler.StorageCapacity(activePlanet.Buildings[Item.DEUTERIUM_TANK].Level + 1).ToString("N0");
        }

        private void FillProductionIncrease()
        {
            lblMetalMineProductionIncrease.Text = (GameHandler.MetalMineProduction(activePlanet.Buildings[Item.METAL_MINE].Level + 1)
                                                 - GameHandler.MetalMineProduction(activePlanet.Buildings[Item.METAL_MINE].Level))
                                                  .ToString("N0");
            lblCrystalMineProductionIncrease.Text = (GameHandler.CrystalMineProduction(activePlanet.Buildings[Item.CRYSTAL_MINE].Level + 1)
                                                   - GameHandler.CrystalMineProduction(activePlanet.Buildings[Item.CRYSTAL_MINE].Level))
                                                    .ToString("N0");
            lblDeuteriumSynthesizerProductionIncrease.Text = (GameHandler.DeuteriumSynthesizerProduction(activePlanet.Buildings[Item.DEUTERIUM_SYNTHESIZER].Level + 1, activePlanet.Temperature)
                                                            - GameHandler.DeuteriumSynthesizerProduction(activePlanet.Buildings[Item.DEUTERIUM_SYNTHESIZER].Level, activePlanet.Temperature))
                                                             .ToString("N0");
            lblSolarPlantProductionIncrease.Text = (GameHandler.SolarPlantProduction(activePlanet.Buildings[Item.SOLAR_PLANT].Level + 1)
                                                  - GameHandler.SolarPlantProduction(activePlanet.Buildings[Item.SOLAR_PLANT].Level))
                                                   .ToString("N0");
            lblFusionReactorProductionIncrease.Text = (GameHandler.FusionReactorProduction(activePlanet.Buildings[Item.FUSION_REACTOR].Level + 1, OGame.Researches[Item.ENERGY_TECHNOLOGY].Level)
                                                     - GameHandler.FusionReactorProduction(activePlanet.Buildings[Item.FUSION_REACTOR].Level, OGame.Researches[Item.ENERGY_TECHNOLOGY].Level))
                                                      .ToString("N0");
        }

        private void FillDemandIncerase()
        {
            lblMetalMineEnergyDemand.Text = (GameHandler.MetalMineEnergyDemand(activePlanet.Buildings[Item.METAL_MINE].Level + 1)
                                           - GameHandler.MetalMineEnergyDemand(activePlanet.Buildings[Item.METAL_MINE].Level))
                                            .ToString("N0");
            lblCrystalMineEnergyDemand.Text = (GameHandler.CrystalMineEnergyDemand(activePlanet.Buildings[Item.CRYSTAL_MINE].Level + 1)
                                             - GameHandler.CrystalMineEnergyDemand(activePlanet.Buildings[Item.CRYSTAL_MINE].Level))
                                              .ToString("N0");
            lblDeuteriumSynthesizerEnergyDemand.Text = (GameHandler.DeuteriumSynthesizerEnergyDemand(activePlanet.Buildings[Item.DEUTERIUM_SYNTHESIZER].Level + 1)
                                                      - GameHandler.DeuteriumSynthesizerEnergyDemand(activePlanet.Buildings[Item.DEUTERIUM_SYNTHESIZER].Level))
                                                       .ToString("N0");
            lblFusionReactorDeuteriumDemand.Text = (GameHandler.FusionReactorDeuteriumDemand(activePlanet.Buildings[Item.FUSION_REACTOR].Level + 1)
                                                  - GameHandler.FusionReactorDeuteriumDemand(activePlanet.Buildings[Item.FUSION_REACTOR].Level))
                                                   .ToString("N0");
        }

        private void FillEnergyCost()
        {
            lblGravitonTechnologyEnergyCost.Text = GameHandler.EnergyCost(Item.GRAVITON_TECHNOLOGY, OGame.Researches[Item.GRAVITON_TECHNOLOGY].Level + 1).ToString("N0");
            lblTerraformerEnergyCost.Text = GameHandler.EnergyCost(Item.TERRAFORMER, activePlanet.Buildings[Item.TERRAFORMER].Level + 1).ToString("N0");
            lblSpaceDockEnergyCost.Text = GameHandler.EnergyCost(Item.SPACE_DOCK, activePlanet.Buildings[Item.SPACE_DOCK].Level + 1).ToString("N0");
        }

        private void FillBuildingTimeRemainLabel()
        {
            foreach (Item item in BuildingTimeRemainLabelList.Keys)
            {
                if (activePlanet.Buildings[item].IsProcessing)
                {
                    DateTime finishDate = OGame.TimeEvents.Where(te => te.Item == item && te.PlanetID == activePlanet.PlanetID)
                                                          .Select(pe => pe.ProcessFinish)
                                                          .ToList()
                                                          .ElementAt(0);

                    BuildingTimeRemainLabelList[item].Text = (finishDate - ogame.LastUpdate).ToString("d'd 'hh'h 'mm'm 'ss's'");
                }
                else
                {
                    BuildingTimeRemainLabelList[item].Text = "";
                }
            }
        }

        private void FillResearchTimeRemainLabel()
        {
            foreach (Item item in ResearchTimeRemainLabelList.Keys)
            {
                if (OGame.Researches[item].IsProcessing)
                {
                    DateTime finishDate = OGame.TimeEvents.Where(te => te.Item == item).Select(pe => pe.ProcessFinish).ToList().ElementAt(0);

                    ResearchTimeRemainLabelList[item].Text = (finishDate - ogame.LastUpdate).ToString("d'd 'hh'h 'mm'm 'ss's'");
                }
                else
                {
                    ResearchTimeRemainLabelList[item].Text = "";
                }
            }
        }

        #region Production tab
        private void FillProductionTab()
        {
            TotalResourcesDataView resourcesDataView = new();

            for (int i = 0; i < ogame.Planets.Count; i++)
            {
                CreatePlanetPanel(i);

                var resourcesPanel = pProductionGeneratedContent.Controls[i].Controls[1].Controls;

                for (int j = 0; j < resourcesPanel.Count; j++)
                {
                    int lvl = ogame.Planets.ElementAt(i).Buildings[(Item)(7 + j)].Level;
                    double mine = GameHandler.MetalMineProduction(lvl);
                    double plasma = GameHandler.PlasmaProduction(mine, (Item)j, OGame.Researches[Item.PLASMA_TECHNOLOGY].Level);
                    double crawlers = GameHandler.CrawlersProduction(mine, (Item)j, ogame.Planets.ElementAt(i).Defences[Item.CRAWLER]);
                    double basic = OGame.GameSpeed * GameData.BASIC_PRODUCTION[(Item)j];
                    double total = mine + plasma + crawlers + basic;

                    resourcesDataView.MinesLevel[j] += lvl;
                    resourcesDataView.Mines.Add(mine, (Item)j);
                    resourcesDataView.Plasma.Add(plasma, (Item)j);
                    resourcesDataView.Crawlers.Add(crawlers, (Item)j);
                    resourcesDataView.Basic.Add(basic, (Item)j);

                    resourcesPanel[j].Controls[0].Text = lvl.ToString("N0");
                    resourcesPanel[j].Controls[1].Text = total.ToString("N0");
                    resourcesPanel[j].Controls[2].Text = mine.ToString("N0");
                    resourcesPanel[j].Controls[3].Text = plasma.ToString("N0");
                    resourcesPanel[j].Controls[4].Text = crawlers.ToString("N0");
                    resourcesPanel[j].Controls[5].Text = basic.ToString("N0");
                    if (total == 0)
                    {
                        resourcesPanel[j].Controls[6].Text = "";
                    }
                    else
                    {
                        resourcesPanel[j].Controls[6].Text = StorageFullfill(i, (Item)j, total).ToString("d'd 'hh'h 'mm'm 'ss's'");
                    }                    
                }
            }
            FillTotalResourcesSection(resourcesDataView);
        }

        private TimeSpan StorageFullfill(int planetIndex, Item item, double production)
        {
            double resource = 0.0;

            double storage = GameHandler.StorageCapacity(ogame.Planets.ElementAt(planetIndex).Buildings[12 + item].Level);

            if (item == Item.METAL) { resource = ogame.Planets.ElementAt(planetIndex).Resources.Metal; }
            if (item == Item.CRYSTAL) { resource = ogame.Planets.ElementAt(planetIndex).Resources.Crystal; }
            if (item == Item.DEUTERIUM) { resource = ogame.Planets.ElementAt(planetIndex).Resources.Deuterium; }
            
            return TimeSpan.FromSeconds((storage - resource) / (production / 3600));
        }

        private void FillTotalResourcesSection(TotalResourcesDataView resourcesDataView)
        {
            Resources total = new();
            total.Add(resourcesDataView.Mines);
            total.Add(resourcesDataView.Plasma);
            total.Add(resourcesDataView.Crawlers);
            total.Add(resourcesDataView.Basic);

            lblTotalMetalMineLevel.Text = resourcesDataView.MinesLevel[0].ToString("N0");
            lblTotalCrystalMineLevel.Text = resourcesDataView.MinesLevel[1].ToString("N0");
            lblTotalDeuteriumSynthesizerLevel.Text = resourcesDataView.MinesLevel[2].ToString("N0");

            lblTotalMetalProduction.Text = total.Metal.ToString("N0");
            lblTotalCrystalProduction.Text = total.Crystal.ToString("N0");
            lblTotalDeuteriumProduction.Text = total.Deuterium.ToString("N0");

            lblTotalMetalProductionMine.Text = resourcesDataView.Mines.Metal.ToString("N0");
            lblTotalCrystalProductionMine.Text = resourcesDataView.Mines.Crystal.ToString("N0");
            lblTotalDeuteriumProductionMine.Text = resourcesDataView.Mines.Crystal.ToString("N0");

            lblTotalMetalProductionPlasma.Text = resourcesDataView.Plasma.Metal.ToString("N0");
            lblTotalCrystalProductionPlasma.Text = resourcesDataView.Plasma.Crystal.ToString("N0");
            lblTotalDeuteriumProductionPlasma.Text = resourcesDataView.Plasma.Deuterium.ToString("N0");

            lblTotalMetalProductionCrawlers.Text = resourcesDataView.Crawlers.Metal.ToString("N0");
            lblTotalCrystalProductionCrawlers.Text = resourcesDataView.Crawlers.Crystal.ToString("N0");
            lblTotalDeuteriumProductionCrawlers.Text = resourcesDataView.Crawlers.Deuterium.ToString("N0");

            lblTotalMetalProductionBasic.Text = resourcesDataView.Basic.Metal.ToString("N0");
            lblTotalCrystalProductionBasic.Text = resourcesDataView.Basic.Crystal.ToString("N0");
            lblTotalDeuteriumProductionBasic.Text = resourcesDataView.Basic.Deuterium.ToString("N0");
        }

        private void CreatePlanetPanel(int index)
        {
            Panel panel = new();

            pProductionGeneratedContent.Controls.Add(panel);

            panel.Controls.Add(CreatePlanetLabel(index));
            panel.Controls.Add(CreateResourcesPanel());

            panel.BackColor = index % 2 > 0 ? Color.Gold : Color.Yellow;
            panel.Location = new Point(0, 75 * index);
            panel.Size = new Size(1889, 75);
        }
        
        private Label CreatePlanetLabel(int index)
        {
            Label label = new();

            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(0, 0);
            label.Size = new Size(160, 75);
            label.Text = ogame.Planets.ElementAt(index).PlanetName;
            label.TextAlign = ContentAlignment.MiddleCenter;

            return label;
        }

        private Panel CreateResourcesPanel()
        {
            Panel panel = new();

            panel.Controls.Add(CreateResourcePanel(Item.METAL));
            panel.Controls.Add(CreateResourcePanel(Item.CRYSTAL));
            panel.Controls.Add(CreateResourcePanel(Item.DEUTERIUM));

            panel.Location = new Point(160, 0);
            panel.Size = new Size(1010, 75);

            return panel;
        }

        private Panel CreateResourcePanel(Item item)
        {
            int y = item == Item.METAL ? 0 : (item == Item.CRYSTAL ? 25 : 50);
            Color color = item == Item.METAL ? Color.Silver : (item == Item.CRYSTAL ? Color.Coral : Color.CornflowerBlue);

            Panel panel = new();
            panel.BackColor = color;

            panel.Controls.Add(CreateLevelLabel());
            panel.Controls.Add(CreateDetailLabel(50));
            panel.Controls.Add(CreateDetailLabel(210));
            panel.Controls.Add(CreateDetailLabel(370));
            panel.Controls.Add(CreateDetailLabel(530));
            panel.Controls.Add(CreateDetailLabel(690));
            panel.Controls.Add(CreateDetailLabel(850));

            panel.Location = new Point(0, y);
            panel.Size = new Size(1010, 25);

            return panel;
        }

        private Label CreateLevelLabel()
        {
            Label label = new();

            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(0, 0);
            label.Size = new Size(50, 25);
            label.TextAlign = ContentAlignment.MiddleCenter;

            return label;
        }

        private Label CreateDetailLabel(int x)
        {
            Label label = new();

            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new System.Drawing.Point(x, 0);
            label.Padding = new Padding(0, 0, 20, 0);
            label.Size = new System.Drawing.Size(160, 25);
            label.TextAlign = ContentAlignment.MiddleRight;

            return label;
        }
        #endregion

        private void FillPlanetTab()
        {
            FillTextBoxNewName();
            EnableBtnChangePlanetName();
        }

        private void EnableBtnChangePlanetName()
        {
            btnChangePlanetName.Enabled = true;
        }

        private void FillTextBoxNewName()
        {
            tbNewPlanetName.Text = activePlanet.PlanetName;
        }
        #endregion

        #region Upgrade Buttons
        private void EnableUpgradeButtons()
        {
            EnableUpgradeButtons(ResearchUpgradeButtonList);
            EnableUpgradeButtons(BuildingUpgradeButtonList);
        }

        private void EnableUpgradeButtons(Dictionary<Item, Button> buttons)
        {
            foreach (Item item in buttons.Keys)
            {
                if (AreRequirementsMet(item) && AreResourcesEnough(item) && !IsUpgradeInProgress(item))
                {
                    buttons[item].Enabled = true;
                    buttons[item].BackColor = Color.Lime;
                }
                else
                {
                    buttons[item].Enabled = false;
                    buttons[item].BackColor = Color.Silver;
                }
            }
        }

        private bool IsUpgradeInProgress(Item item)
        {
            if (OGame.Researches.ContainsKey(item)) { return IsAnyResearchInProgress() || AreAnyResearchLabInBuilding(); }
            return IsAnyBuildingInProgress();
        }

        private bool IsAnyBuildingInProgress()
        {
            foreach (Item item in activePlanet.Buildings.Keys)
            {
                if (item == Item.RESEARCH_LAB && IsAnyResearchInProgress()) { return true; }

                if (activePlanet.Buildings[item].IsProcessing) { return true; }
            }
            return false;
        }

        private bool IsAnyResearchInProgress()
        {
            return OGame.Researches.Where(r => r.Value.IsProcessing).ToList().Count > 0;
        }

        private bool AreAnyResearchLabInBuilding()
        {
            foreach (Planet p in ogame.Planets)
            {
                if (p.Buildings[Item.RESEARCH_LAB].IsProcessing) { return true; }
            }
            return false;
        }

        private bool AreResourcesEnough(Item item)
        {
            int lvl = OGame.Researches.ContainsKey(item) ? OGame.Researches[item].Level : activePlanet.Buildings[item].Level;
            Resources cost = GameHandler.UpgradeCost(item, lvl + 1);

            return activePlanet.Resources.Metal >= cost.Metal
                && activePlanet.Resources.Crystal >= cost.Crystal
                && activePlanet.Resources.Deuterium >= cost.Deuterium
                && EnergyRequirements(item);
        }

        private bool AreRequirementsMet(Item item)
        {
            if (!AreAnyRequirements(item)) { return true; }

            var requirements = GameData.REQUIREMENTS[item];
            foreach (Item it in requirements.Keys)
            {
                int lvl = OGame.Researches.ContainsKey(it) ? OGame.Researches[it].Level : activePlanet.Buildings[it].Level;
                if (lvl < requirements[it]) { return false; }
            }
            return true;
        }

        private bool EnergyRequirements(Item item)
        {
            if (item == Item.GRAVITON_TECHNOLOGY || item == Item.TERRAFORMER || item == Item.SPACE_DOCK)
            {
                int lvl = OGame.Researches.ContainsKey(item) ? OGame.Researches[item].Level : activePlanet.Buildings[item].Level;
                double energyCost = GameHandler.EnergyCost(item, lvl + 1);
                double energyAvailable = double.Parse(lblEnergyAvailableValue.Text);
                return energyAvailable >= energyCost;
            }

            if (item == Item.METAL_MINE || item == Item.CRYSTAL_MINE || item == Item.DEUTERIUM_SYNTHESIZER)
            {
                double energyOver = double.Parse(lblEnergyOverValue.Text);
                double energyDemand = 0.0;
                if (item == Item.METAL_MINE) { energyDemand = double.Parse(lblMetalMineEnergyDemand.Text); }
                if (item == Item.CRYSTAL_MINE) { energyDemand = double.Parse(lblCrystalMineEnergyDemand.Text); }
                if (item == Item.DEUTERIUM_SYNTHESIZER) { energyDemand = double.Parse(lblDeuteriumSynthesizerEnergyDemand.Text); }
                return energyOver >= energyDemand;
            }
            return true;
        }

        private bool AreAnyRequirements(Item item)
        {
            return GameData.REQUIREMENTS.ContainsKey(item);
        }
        #endregion

        #region Private Methods
        private string GetGameName()
        {
            if (tbNewGameName.Text.Length < 3)
                return "Nowa gra";
            else
                return tbNewGameName.Text;
        }

        private static int GetFactorSpeed(string factor)
        {
            if (!int.TryParse(factor, out int temp))
            {
                return 1;
            }
            return temp;
        }

        private void EnableSaveUpdateButtons()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void CreatePlanetsList()
        {
            cbPlanetSelect.Items.Clear();
            foreach (Planet p in ogame.Planets)
            {
                cbPlanetSelect.Items.Add($"{p.PlanetName} {p.Position}");
            }
            cbPlanetSelect.SelectedItem = cbPlanetSelect.Items[0];
        }

        private int FindPlanetID()
        {
            int maxPlanetID = ogame.Planets.Select(p => p.PlanetID).Max();
            return maxPlanetID + 1;
        }

        private void RemoveTimeEventsAfterRemovePlanet()
        {
            List<int> indexes = new();
            foreach (TimeEvent te in OGame.TimeEvents)
            {
                if (te.PlanetID == activePlanet.PlanetID)
                {
                    indexes.Add(OGame.TimeEvents.IndexOf(te));
                }
            }
            indexes.Reverse();

            foreach (int i in indexes)
            {
                OGame.TimeEvents.RemoveAt(i);
            }
        }

        private DateTime UpdateTimeEventList()
        {
            DateTime newLastUpdate = DateTime.Now;

            while (OGame.TimeEvents.Count != 0 && OGame.TimeEvents.ElementAt(0).ProcessFinish < newLastUpdate)
            {
                DateTime finish = OGame.TimeEvents.ElementAt(0).ProcessFinish;
                int planetID = OGame.TimeEvents.ElementAt(0).PlanetID;
                Item item = OGame.TimeEvents.ElementAt(0).Item;

                ogame.UpdateResources(finish);

                if (OGame.Researches.ContainsKey(item))
                {
                    OGame.UpgradeResearch(item);
                }
                else
                {
                    Planet planet = ogame.Planets.Where(p => p.PlanetID == planetID).ToList()[0];
                    planet.UpgradeBuilding(item);
                }
                OGame.TimeEvents.RemoveAt(0);
            }

            return newLastUpdate;
        }
        #endregion

        #region Starter Pack
        private void StarterPack()
        {
            for (int i = 0; i < 25; i++)
            {
                foreach (Item item in OGame.Researches.Keys)
                {
                    OGame.UpgradeResearch(item);
                }

                foreach (Item item in ogame.Planets.ElementAt(0).Buildings.Keys)
                {
                    ogame.Planets.ElementAt(0).UpgradeBuilding(item);
                }
            }

            ogame.Planets.Add(new Planet(2));
            ogame.Planets.Add(new Planet(3));
            ogame.Planets.Add(new Planet(4));
            ogame.Planets.Add(new Planet(5));
            ogame.Planets.Add(new Planet(6));
            //ogame.Planets.ElementAt(0).Resources = new Resources(20000.0, 20000.0, 20000.0);

            //for (int i = 0; i < 5; i++)
            //{
            //    ogame.Planets.ElementAt(0).UpgradeBuilding(Item.RESEARCH_LAB);
            //    ogame.Planets.ElementAt(0).UpgradeBuilding(Item.ROBOTICS_FACTORY);
            //}            
        }
        #endregion


    }
}
