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
        private OGame ogame;
        private Planet activePlanet;
        public MainForm()
        {
            InitializeComponent();
        }

        #region Events
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            OGame.GameSpeed = GetFactorSpeed(tbEcoSpeed.Text);
            OGame.Researches = new Researches();
            ogame = new OGame(GetGameName());

            UpdateNewAndLoadGame();

            FillResourceTab();
            FillResearchTab();

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

                    UpdateNewAndLoadGame();

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
            ogame.UpdatePlanetsAndTotalResources(DateTime.Now);

            UpdateResourceInfo();
            UpdateLastUpdate();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string ogameSerialized = JsonConvert.SerializeObject(ogame);
            File.WriteAllText($@"c:\jsons\{ogame.GameName} x{OGame.GameSpeed}.json", ogameSerialized);
        }

        private void CbPlanetSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ((ComboBox)sender).SelectedIndex;
            activePlanet = ogame.Planets[index];
            UpdatePlanetDetails(activePlanet);

            UpdateResourceInfo();
            UpdateLastUpdate();
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

        private int GetFactorSpeed(string factor)
        {
            if (!int.TryParse(factor, out int temp))
            {
                return 1;
            }
            return temp;
        }

        private void UpdateGameInfo()
        {
            lblGameNameValue.Text = ogame.GameName;
            lblEcoSpeedValue.Text = OGame.GameSpeed.ToString();
        }

        private void UpdateResourceInfo()
        {
            UpdateTotalResourceInfo();
            UpdatePlanetRecourceInfo(activePlanet);
        }

        private void UpdateLastUpdate()
        {
            lblLastUpdate.Text = ogame.LastUpdate.ToString();
        }

        private void CreatePlanetsList()
        {
            cbPlanetSelect.Items.Clear();
            foreach (Planet p in ogame.Planets)
            {
                cbPlanetSelect.Items.Add(p.PlanetName);
            }
            cbPlanetSelect.SelectedItem = cbPlanetSelect.Items[0];
        }

        private void UpdateTotalResourceInfo()
        {
            lblMetalTotalValue.Text = Math.Truncate(ogame.TotalResources.Metal).ToString("N0");
            lblCrystalTotalValue.Text = Math.Truncate(ogame.TotalResources.Crystal).ToString("N0");
            lblDeuteriumTotalValue.Text = Math.Truncate(ogame.TotalResources.Deuterium).ToString("N0");
        }
        
        private void UpdatePlanetRecourceInfo(Planet planet)
        {
            lblMetalPlanetValue.Text = Math.Truncate(planet.Resources.Metal).ToString("N0");
            lblCrystalPlanetValue.Text = Math.Truncate(planet.Resources.Crystal).ToString("N0");
            lblDeuteriumPlanetValue.Text = Math.Truncate(planet.Resources.Deuterium).ToString("N0");
        }
        
        private void UpdatePlanetDetails(Planet planet)
        {
            lblPlanetNameValue.Text = planet.PlanetName;
            lblTemperatureValue.Text = planet.Temperature.ToString("N0");
            lblDiameterValue.Text = planet.Diameter.ToString("N0") + " km";
        }
        
        private void UpdateNewAndLoadGame()
        {
            UpdateGameInfo();

            CreatePlanetsList();
            activePlanet = ogame.Planets[0];
            UpdatePlanetDetails(activePlanet);

            UpdateResourceInfo();
            UpdateLastUpdate();
        }
        
        private void EnableSaveUpdateButtons()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void FillResearchTab()
        {
            lblEspionageTechnology.Text = GameData.NAME[Item.ESPIONAGE_TECHNOLOGY];
            lblEspionageTechnologyLevel.Text = OGame.Researches.EspionageTechnology.Level.ToString("N0");
            lblEspionageTechnologyMetalValue.Text = OGame.Researches.EspionageTechnology.NextLevelCost.Metal.ToString("N0");
            lblEspionageTechnologyCrystalValue.Text = OGame.Researches.EspionageTechnology.NextLevelCost.Crystal.ToString("N0");
            lblEspionageTechnologyDeuteriumValue.Text = OGame.Researches.EspionageTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblEspionageTechnologyDuration.Text = OGame.Researches.EspionageTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblComputerTechnology.Text = GameData.NAME[Item.COMPUTER_TECHNOLOGY];
            lblComputerTechnologyLevel.Text = OGame.Researches.ComputerTechnology.Level.ToString("N0");
            lblComputerTechnologyMetalValue.Text = OGame.Researches.ComputerTechnology.NextLevelCost.Metal.ToString("N0");
            lblComputerTechnologyCrystalValue.Text = OGame.Researches.ComputerTechnology.NextLevelCost.Crystal.ToString("N0");
            lblComputerTechnologyDeuteriumValue.Text = OGame.Researches.ComputerTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblComputerTechnologyDuration.Text = OGame.Researches.ComputerTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblCombustionDrive.Text = GameData.NAME[Item.COMBUSTION_DRIVE];
            lblCombustionDriveLevel.Text = OGame.Researches.CombustionDrive.Level.ToString("N0");
            lblCombustionDriveMetalValue.Text = OGame.Researches.CombustionDrive.NextLevelCost.Metal.ToString("N0");
            lblCombustionDriveCrystalValue.Text = OGame.Researches.CombustionDrive.NextLevelCost.Crystal.ToString("N0");
            lblCombustionDriveDeuteriumValue.Text = OGame.Researches.CombustionDrive.NextLevelCost.Deuterium.ToString("N0");
            lblCombustionDriveDuration.Text = OGame.Researches.CombustionDrive.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblImpulseDrive.Text = GameData.NAME[Item.IMPULSE_DRIVE];
            lblImpulseDriveLevel.Text = OGame.Researches.ImpulseDrive.Level.ToString("N0");
            lblImpulseDriveMetalValue.Text = OGame.Researches.ImpulseDrive.NextLevelCost.Metal.ToString("N0");
            lblImpulseDriveCrystalValue.Text = OGame.Researches.ImpulseDrive.NextLevelCost.Crystal.ToString("N0");
            lblImpulseDriveDeuteriumValue.Text = OGame.Researches.ImpulseDrive.NextLevelCost.Deuterium.ToString("N0");
            lblImpulseDriveDuration.Text = OGame.Researches.ImpulseDrive.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblHyperspaceDrive.Text = GameData.NAME[Item.HYPERSPACE_DRIVE];
            lblHyperspaceDriveLevel.Text = OGame.Researches.HyperspaceDrive.Level.ToString("N0");
            lblHyperspaceDriveMetalValue.Text = OGame.Researches.HyperspaceDrive.NextLevelCost.Metal.ToString("N0");
            lblHyperspaceDriveCrystalValue.Text = OGame.Researches.HyperspaceDrive.NextLevelCost.Crystal.ToString("N0");
            lblHyperspaceDriveDeuteriumValue.Text = OGame.Researches.HyperspaceDrive.NextLevelCost.Deuterium.ToString("N0");
            lblHyperspaceDriveDuration.Text = OGame.Researches.HyperspaceDrive.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblWeapeonsTechnology.Text = GameData.NAME[Item.WEAPONS_TECHNOLOGY];
            lblWeapeonsTechnologyLevel.Text = OGame.Researches.WeaponsTechnology.Level.ToString("N0");
            lblWeapeonsTechnologyMetalValue.Text = OGame.Researches.WeaponsTechnology.NextLevelCost.Metal.ToString("N0");
            lblWeapeonsTechnologyCrystalValue.Text = OGame.Researches.WeaponsTechnology.NextLevelCost.Crystal.ToString("N0");
            lblWeapeonsTechnologyDeuteriumValue.Text = OGame.Researches.WeaponsTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblWeapeonsTechnologyDuration.Text = OGame.Researches.WeaponsTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblShieldingTechnology.Text = GameData.NAME[Item.SHIELDING_TECHNOLOGY];
            lblShieldingTechnologyLevel.Text = OGame.Researches.ShieldingTechnology.Level.ToString("N0");
            lblShieldingTechnologyMetalValue.Text = OGame.Researches.ShieldingTechnology.NextLevelCost.Metal.ToString("N0");
            lblShieldingTechnologyCrystalValue.Text = OGame.Researches.ShieldingTechnology.NextLevelCost.Crystal.ToString("N0");
            lblShieldingTechnologyDeuteriumValue.Text = OGame.Researches.ShieldingTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblShieldingTechnologyDuration.Text = OGame.Researches.ShieldingTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblArmourTechnology.Text = GameData.NAME[Item.ARMOUR_TECHNOLOGY];
            lblArmourTechnologyLevel.Text = OGame.Researches.ArmourTechnology.Level.ToString("N0");
            lblArmourTechnologyMetalValue.Text = OGame.Researches.ArmourTechnology.NextLevelCost.Metal.ToString("N0");
            lblArmourTechnologyCrystalValue.Text = OGame.Researches.ArmourTechnology.NextLevelCost.Crystal.ToString("N0");
            lblArmourTechnologyDeuteriumValue.Text = OGame.Researches.ArmourTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblArmourTechnologyDuration.Text = OGame.Researches.ArmourTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblEnergyTechnology.Text = GameData.NAME[Item.ENERGY_TECHNOLOGY];
            lblEnergyTechnologyLevel.Text = OGame.Researches.EnergyTechnology.Level.ToString("N0");
            lblEnergyTechnologyMetalValue.Text = OGame.Researches.EnergyTechnology.NextLevelCost.Metal.ToString("N0");
            lblEnergyTechnologyCrystalValue.Text = OGame.Researches.EnergyTechnology.NextLevelCost.Crystal.ToString("N0");
            lblEnergyTechnologyDeuteriumValue.Text = OGame.Researches.EnergyTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblEnergyTechnologyDuration.Text = OGame.Researches.EnergyTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblHyperspaceTechnology.Text = GameData.NAME[Item.HYPERSPACE_TECHNOLOGY];
            lblHyperspaceTechnologyLevel.Text = OGame.Researches.HyperspaceTechnology.Level.ToString("N0");
            lblHyperspaceTechnologyMetalValue.Text = OGame.Researches.HyperspaceTechnology.NextLevelCost.Metal.ToString("N0");
            lblHyperspaceTechnologyCrystalValue.Text = OGame.Researches.HyperspaceTechnology.NextLevelCost.Crystal.ToString("N0");
            lblHyperspaceTechnologyDeuteriumValue.Text = OGame.Researches.HyperspaceTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblHyperspaceTechnologyDuration.Text = OGame.Researches.HyperspaceTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblLaserTechnology.Text = GameData.NAME[Item.LASER_TECHNOLOGY];
            lblLaserTechnologyLevel.Text = OGame.Researches.LaserTechnology.Level.ToString("N0");
            lblLaserTechnologyMetalValue.Text = OGame.Researches.LaserTechnology.NextLevelCost.Metal.ToString("N0");
            lblLaserTechnologyCrystalValue.Text = OGame.Researches.LaserTechnology.NextLevelCost.Crystal.ToString("N0");
            lblLaserTechnologyDeuteriumValue.Text = OGame.Researches.LaserTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblLaserTechnologyDuration.Text = OGame.Researches.LaserTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblIonTechnology.Text = GameData.NAME[Item.ION_TECHNOLOGY];
            lblIonTechnologyLevel.Text = OGame.Researches.IonTechnology.Level.ToString("N0");
            lblIonTechnologyMetalValue.Text = OGame.Researches.IonTechnology.NextLevelCost.Metal.ToString("N0");
            lblIonTechnologyCrystalValue.Text = OGame.Researches.IonTechnology.NextLevelCost.Crystal.ToString("N0");
            lblIonTechnologyDeuteriumValue.Text = OGame.Researches.IonTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblIonTechnologyDuration.Text = OGame.Researches.IonTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblPlasmaTechnology.Text = GameData.NAME[Item.PLASMA_TECHNOLOGY];
            lblPlasmaTechnologyLevel.Text = OGame.Researches.PlasmaTechnology.Level.ToString("N0");
            lblPlasmaTechnologyMetalValue.Text = OGame.Researches.PlasmaTechnology.NextLevelCost.Metal.ToString("N0");
            lblPlasmaTechnologyCrystalValue.Text = OGame.Researches.PlasmaTechnology.NextLevelCost.Crystal.ToString("N0");
            lblPlasmaTechnologyDeuteriumValue.Text = OGame.Researches.PlasmaTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblPlasmaTechnologyDuration.Text = OGame.Researches.PlasmaTechnology.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblIrn.Text = GameData.NAME[Item.IRN];
            lblIrnLevel.Text = OGame.Researches.Irn.Level.ToString("N0");
            lblIrnMetalValue.Text = OGame.Researches.Irn.NextLevelCost.Metal.ToString("N0");
            lblIrnCrystalValue.Text = OGame.Researches.Irn.NextLevelCost.Crystal.ToString("N0");
            lblIrnDeuteriumValue.Text = OGame.Researches.Irn.NextLevelCost.Deuterium.ToString("N0");
            lblIrnDuration.Text = OGame.Researches.Irn.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblAstrophisics.Text = GameData.NAME[Item.ASTROPHISICS];
            lblAstrophisicsLevel.Text = OGame.Researches.Astrophisics.Level.ToString("N0");
            lblAstrophisicsMetalValue.Text = OGame.Researches.Astrophisics.NextLevelCost.Metal.ToString("N0");
            lblAstrophisicsCrystalValue.Text = OGame.Researches.Astrophisics.NextLevelCost.Crystal.ToString("N0");
            lblAstrophisicsDeuteriumValue.Text = OGame.Researches.Astrophisics.NextLevelCost.Deuterium.ToString("N0");
            lblAstrophisicsDuration.Text = OGame.Researches.Astrophisics.ResearchTime.ToString("d'd 'hh'h 'mm'm 'ss's'");

            lblGravitonTechnology.Text = GameData.NAME[Item.GRAVITON_TECHNOLOGY];
            lblGravitonTechnologyLevel.Text = OGame.Researches.GravitonTechnology.Level.ToString("N0");
            lblGravitonTechnologyMetalValue.Text = OGame.Researches.GravitonTechnology.NextLevelCost.Metal.ToString("N0");
            lblGravitonTechnologyCrystalValue.Text = OGame.Researches.GravitonTechnology.NextLevelCost.Crystal.ToString("N0");
            lblGravitonTechnologyDeuteriumValue.Text = OGame.Researches.GravitonTechnology.NextLevelCost.Deuterium.ToString("N0");
            lblGravitonTechnologyDuration.Text = OGame.Researches.GravitonTechnology.ResearchTime.Add(TimeSpan.FromSeconds(1)).ToString("d'd 'hh'h 'mm'm 'ss's'");
            lblGravitonTechnologyEnergyDemand.Text = GameHandler.EnergyDemand(Item.GRAVITON_TECHNOLOGY, OGame.Researches.GravitonTechnology.Level + 1).ToString("N0");
        }
        
        private void FillResourceTab()
        {
            lblMetalMine.Text = GameData.NAME[Item.METAL_MINE];
            lblMetalMineLevel.Text = activePlanet.Buildings.MetalMine.Level.ToString("N0");
            lblMetalMineMetalValue.Text = activePlanet.Buildings.MetalMine.NextLevelCost.Metal.ToString("N0");
            lblMetalMineCrystalValue.Text = activePlanet.Buildings.MetalMine.NextLevelCost.Crystal.ToString("N0");
            lblMetalMineDeuteriumValue.Text = activePlanet.Buildings.MetalMine.NextLevelCost.Deuterium.ToString("N0");
            lblMetalMineDuration.Text = activePlanet.Buildings.MetalMine.BuildingTime.ToString("d'd 'hh'h 'mm'm 'ss's'");
            lblMetalMineEnergyDemand.Text = (activePlanet.Energy.DeuteriumSynthesizerNextLevelDemand - activePlanet.Energy.MetalMineDemand).ToString("N0");
            lblMetalMineProductionIncrease = (activePlanet.Production);
        }
        #endregion


    }
}
