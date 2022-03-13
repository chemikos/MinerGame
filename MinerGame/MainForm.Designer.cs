
namespace MinerGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbEcoSpeed = new System.Windows.Forms.TextBox();
            this.tbNewGameName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblGameNameValue = new System.Windows.Forms.Label();
            this.lblEcoSpeedValue = new System.Windows.Forms.Label();
            this.lblMetalTotalValue = new System.Windows.Forms.Label();
            this.pContent = new System.Windows.Forms.Panel();
            this.pPlanet = new System.Windows.Forms.Panel();
            this.pPlanetStructures = new System.Windows.Forms.Panel();
            this.tcStructures = new System.Windows.Forms.TabControl();
            this.tpResources = new System.Windows.Forms.TabPage();
            this.pDeuteriumTank = new System.Windows.Forms.Panel();
            this.lblDeuteriumTanlTimeRemain = new System.Windows.Forms.Label();
            this.lblDeuteriumTankNewStorage = new System.Windows.Forms.Label();
            this.lblDeuteriumTankDuration = new System.Windows.Forms.Label();
            this.btnDeuteriumTankUpgrade = new System.Windows.Forms.Button();
            this.lblDeuteriumTankDeuteriumCost = new System.Windows.Forms.Label();
            this.lblDeuteriumTankCrystalCost = new System.Windows.Forms.Label();
            this.lblDeuteriumTankMetalCost = new System.Windows.Forms.Label();
            this.lblDeuteriumTankLevel = new System.Windows.Forms.Label();
            this.lblDeuteriumTank = new System.Windows.Forms.Label();
            this.pCrystalStorage = new System.Windows.Forms.Panel();
            this.lblCrystalStorageTimeRemain = new System.Windows.Forms.Label();
            this.lblCrystalStorageNewStorage = new System.Windows.Forms.Label();
            this.lblCrystalStorageDuration = new System.Windows.Forms.Label();
            this.btnCrystalStorageUpgrade = new System.Windows.Forms.Button();
            this.lblCrystalStorageDeuteriumCost = new System.Windows.Forms.Label();
            this.lblCrystalStorageCrystalCost = new System.Windows.Forms.Label();
            this.lblCrystalStorageMetalCost = new System.Windows.Forms.Label();
            this.lblCrystalStorageLevel = new System.Windows.Forms.Label();
            this.lblCrystalStorage = new System.Windows.Forms.Label();
            this.pMetalStorage = new System.Windows.Forms.Panel();
            this.lblMetalStorageTimeRemain = new System.Windows.Forms.Label();
            this.lblMetalStorageNewStorage = new System.Windows.Forms.Label();
            this.lblMetalStorageDuration = new System.Windows.Forms.Label();
            this.btnMetalStorageUpgrade = new System.Windows.Forms.Button();
            this.lblMetalStorageDeuteriumCost = new System.Windows.Forms.Label();
            this.lblMetalStorageCrystalCost = new System.Windows.Forms.Label();
            this.lblMetalStorageMetalCost = new System.Windows.Forms.Label();
            this.lblMetalStorageLevel = new System.Windows.Forms.Label();
            this.lblMetalStorage = new System.Windows.Forms.Label();
            this.pFusionReactor = new System.Windows.Forms.Panel();
            this.lblFusionReactorTimeRemain = new System.Windows.Forms.Label();
            this.lblFusionReactorProductionIncrease = new System.Windows.Forms.Label();
            this.lblFusionReactorDeuteriumDemand = new System.Windows.Forms.Label();
            this.lblFusionReactorDuration = new System.Windows.Forms.Label();
            this.btnFusionReactorUpgrade = new System.Windows.Forms.Button();
            this.lblFusionReactorDeuteriumCost = new System.Windows.Forms.Label();
            this.lblFusionReactorCrystalCost = new System.Windows.Forms.Label();
            this.lblFusionReactorMetalCost = new System.Windows.Forms.Label();
            this.lblFusionReactorLevel = new System.Windows.Forms.Label();
            this.lblFusionReactor = new System.Windows.Forms.Label();
            this.pSolarPlant = new System.Windows.Forms.Panel();
            this.lblSolarPlantTimeRemain = new System.Windows.Forms.Label();
            this.lblSolarPlantProductionIncrease = new System.Windows.Forms.Label();
            this.lblSolarPlantDuration = new System.Windows.Forms.Label();
            this.btnSolarPlantUpgrade = new System.Windows.Forms.Button();
            this.lblSolarPlantDeuteriumCost = new System.Windows.Forms.Label();
            this.lblSolarPlantCrystalCost = new System.Windows.Forms.Label();
            this.lblSolarPlantMetalCost = new System.Windows.Forms.Label();
            this.lblSolarPlantLevel = new System.Windows.Forms.Label();
            this.lblSolarPlant = new System.Windows.Forms.Label();
            this.pDeuteriumSynthesizer = new System.Windows.Forms.Panel();
            this.lblDeuteriumSynthesizerTimeRemain = new System.Windows.Forms.Label();
            this.lblDeuteriumSynthesizerProductionIncrease = new System.Windows.Forms.Label();
            this.lblDeuteriumSynthesizerEnergyDemand = new System.Windows.Forms.Label();
            this.lblDeuteriumSynthesizerDuration = new System.Windows.Forms.Label();
            this.btnDeuteriumSynthesizerUpgrade = new System.Windows.Forms.Button();
            this.lblDeuteriumSynthesizerDeuteriumCost = new System.Windows.Forms.Label();
            this.lblDeuteriumSynthesizerCrystalCost = new System.Windows.Forms.Label();
            this.lblDeuteriumSynthesizerMetalCost = new System.Windows.Forms.Label();
            this.lblDeuteriumSynthesizerLevel = new System.Windows.Forms.Label();
            this.lblDeuteriumSynthesizer = new System.Windows.Forms.Label();
            this.pCrystalMine = new System.Windows.Forms.Panel();
            this.lblCrystalMineTimeRemain = new System.Windows.Forms.Label();
            this.lblCrystalMineProductionIncrease = new System.Windows.Forms.Label();
            this.lblCrystalMineEnergyDemand = new System.Windows.Forms.Label();
            this.lblCrystalMineDuration = new System.Windows.Forms.Label();
            this.btnCrystalMineUpgrade = new System.Windows.Forms.Button();
            this.lblCrystalMineDeuteriumCost = new System.Windows.Forms.Label();
            this.lblCrystalMineCrystalCost = new System.Windows.Forms.Label();
            this.lblCrystalMineMetalCost = new System.Windows.Forms.Label();
            this.lblCrystalMineLevel = new System.Windows.Forms.Label();
            this.lblCrystalMine = new System.Windows.Forms.Label();
            this.pMetalMine = new System.Windows.Forms.Panel();
            this.lblMetalMineTimeRemain = new System.Windows.Forms.Label();
            this.lblMetalMineProductionIncrease = new System.Windows.Forms.Label();
            this.lblMetalMineEnergyDemand = new System.Windows.Forms.Label();
            this.lblMetalMineDuration = new System.Windows.Forms.Label();
            this.btnMetalMineUpgrade = new System.Windows.Forms.Button();
            this.lblMetalMineDeuteriumCost = new System.Windows.Forms.Label();
            this.lblMetalMineCrystalCost = new System.Windows.Forms.Label();
            this.lblMetalMineMetalCost = new System.Windows.Forms.Label();
            this.lblMetalMineLevel = new System.Windows.Forms.Label();
            this.lblMetalMine = new System.Windows.Forms.Label();
            this.tpProduction = new System.Windows.Forms.TabPage();
            this.pProductionGeneratedContent = new System.Windows.Forms.Panel();
            this.pTotalProduction = new System.Windows.Forms.Panel();
            this.pTotalProductionDetails = new System.Windows.Forms.Panel();
            this.pTotalDeuteriumProductionDetails = new System.Windows.Forms.Panel();
            this.lblStorageDeuteriumMinTime = new System.Windows.Forms.Label();
            this.lblTotalDeuteriumProductionBasic = new System.Windows.Forms.Label();
            this.lblTotalDeuteriumProductionCrawlers = new System.Windows.Forms.Label();
            this.lblTotalDeuteriumProductionPlasma = new System.Windows.Forms.Label();
            this.lblTotalDeuteriumProductionMine = new System.Windows.Forms.Label();
            this.lblTotalDeuteriumProduction = new System.Windows.Forms.Label();
            this.lblTotalDeuteriumTankLevel = new System.Windows.Forms.Label();
            this.lblTotalDeuteriumSynthesizerLevel = new System.Windows.Forms.Label();
            this.pTotalCrystalProductionDetails = new System.Windows.Forms.Panel();
            this.lblStorageCrystalMinTime = new System.Windows.Forms.Label();
            this.lblTotalCrystalProductionBasic = new System.Windows.Forms.Label();
            this.lblTotalCrystalProductionCrawlers = new System.Windows.Forms.Label();
            this.lblTotalCrystalProductionPlasma = new System.Windows.Forms.Label();
            this.lblTotalCrystalProductionMine = new System.Windows.Forms.Label();
            this.lblTotalCrystalProduction = new System.Windows.Forms.Label();
            this.lblTotalCrystalStorageLevel = new System.Windows.Forms.Label();
            this.lblTotalCrystalMineLevel = new System.Windows.Forms.Label();
            this.pTotalMetalProductionDetails = new System.Windows.Forms.Panel();
            this.lblStorageMetalMinTime = new System.Windows.Forms.Label();
            this.lblTotalMetalProductionBasic = new System.Windows.Forms.Label();
            this.lblTotalMetalProductionCrawlers = new System.Windows.Forms.Label();
            this.lblTotalMetalProductionPlasma = new System.Windows.Forms.Label();
            this.lblTotalMetalProductionMine = new System.Windows.Forms.Label();
            this.lblTotalMetalProduction = new System.Windows.Forms.Label();
            this.lblTotalMetalStorageLevel = new System.Windows.Forms.Label();
            this.lblTotalMetalMineLevel = new System.Windows.Forms.Label();
            this.lblTotalProduction = new System.Windows.Forms.Label();
            this.pTotalProductionHeader = new System.Windows.Forms.Panel();
            this.lblTimeToFillStorage = new System.Windows.Forms.Label();
            this.lblProductionBasic = new System.Windows.Forms.Label();
            this.lblProductionCrawlers = new System.Windows.Forms.Label();
            this.lblProductionPlasma = new System.Windows.Forms.Label();
            this.lblProductionMine = new System.Windows.Forms.Label();
            this.lblProductionTotal = new System.Windows.Forms.Label();
            this.lblProductionStorage = new System.Windows.Forms.Label();
            this.lblProductionLevel = new System.Windows.Forms.Label();
            this.lblProductionPlanet = new System.Windows.Forms.Label();
            this.tpStation = new System.Windows.Forms.TabPage();
            this.pJumpGate = new System.Windows.Forms.Panel();
            this.lblJumpGateTimeRemain = new System.Windows.Forms.Label();
            this.lblJumpGateDuration = new System.Windows.Forms.Label();
            this.btnJumpGateUpgrade = new System.Windows.Forms.Button();
            this.lblJumpGateDeuteriumCost = new System.Windows.Forms.Label();
            this.lblJumpGateCrystalCost = new System.Windows.Forms.Label();
            this.lblJumpGateMetalCost = new System.Windows.Forms.Label();
            this.lblJumpGateLevel = new System.Windows.Forms.Label();
            this.lblJumpGate = new System.Windows.Forms.Label();
            this.pSensorPhalanx = new System.Windows.Forms.Panel();
            this.lblSensorPhalanxTimeRemain = new System.Windows.Forms.Label();
            this.lblSensorPhalanxDuration = new System.Windows.Forms.Label();
            this.btnSensorPhalanxUpgrade = new System.Windows.Forms.Button();
            this.lblSensorPhalanxDeuteriumCost = new System.Windows.Forms.Label();
            this.lblSensorPhalanxCrystalCost = new System.Windows.Forms.Label();
            this.lblSensorPhalanxMetalCost = new System.Windows.Forms.Label();
            this.lblSensorPhalanxLevel = new System.Windows.Forms.Label();
            this.lblSensorPhalanx = new System.Windows.Forms.Label();
            this.pLunarBase = new System.Windows.Forms.Panel();
            this.lblLunarBaseTimeRemain = new System.Windows.Forms.Label();
            this.lblLunarBaseDuration = new System.Windows.Forms.Label();
            this.btnLunarBaseUpgrade = new System.Windows.Forms.Button();
            this.lblLunarBaseDeuteriumCost = new System.Windows.Forms.Label();
            this.lblLunarBaseCrystalCost = new System.Windows.Forms.Label();
            this.lblLunarBaseMetalCost = new System.Windows.Forms.Label();
            this.lblLunarBaseLevel = new System.Windows.Forms.Label();
            this.lblLunarBase = new System.Windows.Forms.Label();
            this.pSpaceDock = new System.Windows.Forms.Panel();
            this.lblSpaceDockTimeRemain = new System.Windows.Forms.Label();
            this.lblSpaceDockEnergyCost = new System.Windows.Forms.Label();
            this.lblSpaceDockDuration = new System.Windows.Forms.Label();
            this.btnSpaceDockUpgrade = new System.Windows.Forms.Button();
            this.lblSpaceDockDeuteriumCost = new System.Windows.Forms.Label();
            this.lblSpaceDockCrystalCost = new System.Windows.Forms.Label();
            this.lblSpaceDockMetalCost = new System.Windows.Forms.Label();
            this.lblSpaceDockLevel = new System.Windows.Forms.Label();
            this.lblSpaceDock = new System.Windows.Forms.Label();
            this.pTerraformer = new System.Windows.Forms.Panel();
            this.lblTerraformerTimeRemain = new System.Windows.Forms.Label();
            this.lblTerraformerEnergyCost = new System.Windows.Forms.Label();
            this.lblTerraformerDuration = new System.Windows.Forms.Label();
            this.btnTerraformerUpgrade = new System.Windows.Forms.Button();
            this.lblTerraformerDeuteriumCost = new System.Windows.Forms.Label();
            this.lblTerraformerCrystalCost = new System.Windows.Forms.Label();
            this.lblTerraformerMetalCost = new System.Windows.Forms.Label();
            this.lblTerraformerLevel = new System.Windows.Forms.Label();
            this.lblTerraformer = new System.Windows.Forms.Label();
            this.pMissileSilo = new System.Windows.Forms.Panel();
            this.lblMissileSiloTimeRemain = new System.Windows.Forms.Label();
            this.lblMissileSiloDuration = new System.Windows.Forms.Label();
            this.btnMissileSiloUpgrade = new System.Windows.Forms.Button();
            this.lblMissileSiloDeuteriumCost = new System.Windows.Forms.Label();
            this.lblMissileSiloCrystalCost = new System.Windows.Forms.Label();
            this.lblMissileSiloMetalCost = new System.Windows.Forms.Label();
            this.lblMissileSiloLevel = new System.Windows.Forms.Label();
            this.lblMissileSilo = new System.Windows.Forms.Label();
            this.pResearchLab = new System.Windows.Forms.Panel();
            this.lblResearchLabTimeRemain = new System.Windows.Forms.Label();
            this.lblResearchLabDuration = new System.Windows.Forms.Label();
            this.btnResearchLabUpgrade = new System.Windows.Forms.Button();
            this.lblResearchLabDeuteriumCost = new System.Windows.Forms.Label();
            this.lblResearchLabCrystalCost = new System.Windows.Forms.Label();
            this.lblResearchLabMetalCost = new System.Windows.Forms.Label();
            this.lblResearchLabLevel = new System.Windows.Forms.Label();
            this.lblResearchLab = new System.Windows.Forms.Label();
            this.pShipyard = new System.Windows.Forms.Panel();
            this.lblShipyardTimeRemain = new System.Windows.Forms.Label();
            this.lblShipyardDuration = new System.Windows.Forms.Label();
            this.btnShipyardUpgrade = new System.Windows.Forms.Button();
            this.lblShipyardDeuteriumCost = new System.Windows.Forms.Label();
            this.lblShipyardCrystalCost = new System.Windows.Forms.Label();
            this.lblShipyardMetalCost = new System.Windows.Forms.Label();
            this.lblShipyardLevel = new System.Windows.Forms.Label();
            this.lblShipyard = new System.Windows.Forms.Label();
            this.pNaniteFactory = new System.Windows.Forms.Panel();
            this.lblNaniteFactoryTimeRemain = new System.Windows.Forms.Label();
            this.lblNaniteFactoryDuration = new System.Windows.Forms.Label();
            this.btnNaniteFactoryUpgrade = new System.Windows.Forms.Button();
            this.lblNaniteFactoryDeuteriumCost = new System.Windows.Forms.Label();
            this.lblNaniteFactoryCrystalCost = new System.Windows.Forms.Label();
            this.lblNaniteFactoryMetalCost = new System.Windows.Forms.Label();
            this.lblNaniteFactoryLevel = new System.Windows.Forms.Label();
            this.lblNaniteFactory = new System.Windows.Forms.Label();
            this.pRoboticsFactory = new System.Windows.Forms.Panel();
            this.lblRoboticsFactoryTimeRemain = new System.Windows.Forms.Label();
            this.lblRoboticsFactoryDuration = new System.Windows.Forms.Label();
            this.btnRoboticsFactoryUpgrade = new System.Windows.Forms.Button();
            this.lblRoboticsFactoryDeuteriumCost = new System.Windows.Forms.Label();
            this.lblRoboticsFactoryCrystalCost = new System.Windows.Forms.Label();
            this.lblRoboticsFactoryMetalCost = new System.Windows.Forms.Label();
            this.lblRoboticsFactoryLevel = new System.Windows.Forms.Label();
            this.lblRoboticsFactory = new System.Windows.Forms.Label();
            this.tpResearch = new System.Windows.Forms.TabPage();
            this.pGravitonTechnology = new System.Windows.Forms.Panel();
            this.lblGravitonTechnologyEnergyCost = new System.Windows.Forms.Label();
            this.lblGravitonTechnologyDuration = new System.Windows.Forms.Label();
            this.btnGravitonTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblGravitonTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblGravitonTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblGravitonTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblGravitonTechnologyLevel = new System.Windows.Forms.Label();
            this.lblGravitonTechnology = new System.Windows.Forms.Label();
            this.pAstrophisics = new System.Windows.Forms.Panel();
            this.lblAstrophisicsTotalCost = new System.Windows.Forms.Label();
            this.lblAstrophisicsTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblAstrophisicsTimeRemain = new System.Windows.Forms.Label();
            this.lblAstrophisicsDuration = new System.Windows.Forms.Label();
            this.btnAstrophisicsUpgrade = new System.Windows.Forms.Button();
            this.lblAstrophisicsDeuteriumCost = new System.Windows.Forms.Label();
            this.lblAstrophisicsCrystalCost = new System.Windows.Forms.Label();
            this.lblAstrophisicsMetalCost = new System.Windows.Forms.Label();
            this.lblAstrophisicsLevel = new System.Windows.Forms.Label();
            this.lblAstrophisics = new System.Windows.Forms.Label();
            this.pIrn = new System.Windows.Forms.Panel();
            this.lblIrnTotalCost = new System.Windows.Forms.Label();
            this.lblIrnTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblIrnTimeRemain = new System.Windows.Forms.Label();
            this.lblIrnDuration = new System.Windows.Forms.Label();
            this.btnIrnUpgrade = new System.Windows.Forms.Button();
            this.lblIrnDeuteriumCost = new System.Windows.Forms.Label();
            this.lblIrnCrystalCost = new System.Windows.Forms.Label();
            this.lblIrnMetalCost = new System.Windows.Forms.Label();
            this.lblIrnLevel = new System.Windows.Forms.Label();
            this.lblIrn = new System.Windows.Forms.Label();
            this.pPlasmaTechnology = new System.Windows.Forms.Panel();
            this.lblPlasmaTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblPlasmaTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblPlasmaTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblPlasmaTechnologyDuration = new System.Windows.Forms.Label();
            this.btnPlasmaTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblPlasmaTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblPlasmaTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblPlasmaTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblPlasmaTechnologyLevel = new System.Windows.Forms.Label();
            this.lblPlasmaTechnology = new System.Windows.Forms.Label();
            this.pIonTechnology = new System.Windows.Forms.Panel();
            this.lblIonTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblIonTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblIonTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblIonTechnologyDuration = new System.Windows.Forms.Label();
            this.btnIonTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblIonTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblIonTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblIonTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblIonTechnologyLevel = new System.Windows.Forms.Label();
            this.lblIonTechnology = new System.Windows.Forms.Label();
            this.pLaserTechnology = new System.Windows.Forms.Panel();
            this.lblLaserTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblLaserTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblLaserTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblLaserTechnologyDuration = new System.Windows.Forms.Label();
            this.btnLaserTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblLaserTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblLaserTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblLaserTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblLaserTechnologyLevel = new System.Windows.Forms.Label();
            this.lblLaserTechnology = new System.Windows.Forms.Label();
            this.pHyperspaceTechnology = new System.Windows.Forms.Panel();
            this.lblHyperspaceTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblHyperspaceTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblHyperspaceTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblHyperspaceTechnologyDuration = new System.Windows.Forms.Label();
            this.btnHyperspaceTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblHyperspaceTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblHyperspaceTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblHyperspaceTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblHyperspaceTechnologyLevel = new System.Windows.Forms.Label();
            this.lblHyperspaceTechnology = new System.Windows.Forms.Label();
            this.pEnergyTechnology = new System.Windows.Forms.Panel();
            this.lblEnergyTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblEnergyTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblEnergyTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblEnergyTechnologyDuration = new System.Windows.Forms.Label();
            this.btnEnergyTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblEnergyTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblEnergyTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblEnergyTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblEnergyTechnologyLevel = new System.Windows.Forms.Label();
            this.lblEnergyTechnology = new System.Windows.Forms.Label();
            this.pArmourTechnology = new System.Windows.Forms.Panel();
            this.lblArmourTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblArmourTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblArmourTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblArmourTechnologyDuration = new System.Windows.Forms.Label();
            this.btnArmourTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblArmourTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblArmourTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblArmourTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblArmourTechnologyLevel = new System.Windows.Forms.Label();
            this.lblArmourTechnology = new System.Windows.Forms.Label();
            this.pShieldingTechnology = new System.Windows.Forms.Panel();
            this.lblShieldingTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblShieldingTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblShieldingTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblShieldingTechnologyDuration = new System.Windows.Forms.Label();
            this.btnShieldingTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblShieldingTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblShieldingTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblShieldingTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblShieldingTechnologyLevel = new System.Windows.Forms.Label();
            this.lblShieldingTechnology = new System.Windows.Forms.Label();
            this.pWeaponsTechnology = new System.Windows.Forms.Panel();
            this.lblWeaponsTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblWeaponsTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblWeaponsTechnologyTimeRemian = new System.Windows.Forms.Label();
            this.lblWeaponsTechnologyDuration = new System.Windows.Forms.Label();
            this.btnWeapeonsTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblWeaponsTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblWeaponsTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblWeaponsTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblWeaponsTechnologyLevel = new System.Windows.Forms.Label();
            this.lblWeaponsTechnology = new System.Windows.Forms.Label();
            this.pHyperspaceDrive = new System.Windows.Forms.Panel();
            this.lblHyperspaceDriveTotalCost = new System.Windows.Forms.Label();
            this.lblHyperspaceDriveTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblHyperspaceDriveTimeRemain = new System.Windows.Forms.Label();
            this.lblHyperspaceDriveDuration = new System.Windows.Forms.Label();
            this.btnHyperspaceDriveUpgrade = new System.Windows.Forms.Button();
            this.lblHyperspaceDriveDeuteriumCost = new System.Windows.Forms.Label();
            this.lblHyperspaceDriveCrystalCost = new System.Windows.Forms.Label();
            this.lblHyperspaceDriveMetalCost = new System.Windows.Forms.Label();
            this.lblHyperspaceDriveLevel = new System.Windows.Forms.Label();
            this.lblHyperspaceDrive = new System.Windows.Forms.Label();
            this.pImpulseDrive = new System.Windows.Forms.Panel();
            this.lblImpulseDriveTotalCost = new System.Windows.Forms.Label();
            this.lblImpulseDriveTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblImpulseDriveTimeRemain = new System.Windows.Forms.Label();
            this.lblImpulseDriveDuration = new System.Windows.Forms.Label();
            this.btnImpulseDriveUpgrade = new System.Windows.Forms.Button();
            this.lblImpulseDriveDeuteriumCost = new System.Windows.Forms.Label();
            this.lblImpulseDriveCrystalCost = new System.Windows.Forms.Label();
            this.lblImpulseDriveMetalCost = new System.Windows.Forms.Label();
            this.lblImpulseDriveLevel = new System.Windows.Forms.Label();
            this.lblImpulseDrive = new System.Windows.Forms.Label();
            this.pCombustionDrive = new System.Windows.Forms.Panel();
            this.lblCombustionDriveTotalCost = new System.Windows.Forms.Label();
            this.lblCombustionDriveTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblCombustionDriveTimeRemain = new System.Windows.Forms.Label();
            this.lblCombustionDriveDuration = new System.Windows.Forms.Label();
            this.btnCombustionDriveUpgrade = new System.Windows.Forms.Button();
            this.lblCombustionDriveDeuteriumCost = new System.Windows.Forms.Label();
            this.lblCombustionDriveCrystalCost = new System.Windows.Forms.Label();
            this.lblCombustionDriveMetalCost = new System.Windows.Forms.Label();
            this.lblCombustionDriveLevel = new System.Windows.Forms.Label();
            this.lblCombustionDrive = new System.Windows.Forms.Label();
            this.pComputerTechnology = new System.Windows.Forms.Panel();
            this.lblComputerTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblComputerTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblComputerTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblComputerTechnologyDuration = new System.Windows.Forms.Label();
            this.btnComputerTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblComputerTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblComputerTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblComputerTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblComputerTechnologyLevel = new System.Windows.Forms.Label();
            this.lblComputerTechnology = new System.Windows.Forms.Label();
            this.pEspionageTechnology = new System.Windows.Forms.Panel();
            this.lblEspionageTechnologyTotalCost = new System.Windows.Forms.Label();
            this.lblEspionageTechnologyTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblEspionageTechnologyTimeRemain = new System.Windows.Forms.Label();
            this.lblEspionageTechnologyDuration = new System.Windows.Forms.Label();
            this.btnEspionageTechnologyUpgrade = new System.Windows.Forms.Button();
            this.lblEspionageTechnologyDeuteriumCost = new System.Windows.Forms.Label();
            this.lblEspionageTechnologyCrystalCost = new System.Windows.Forms.Label();
            this.lblEspionageTechnologyMetalCost = new System.Windows.Forms.Label();
            this.lblEspionageTechnologyLevel = new System.Windows.Forms.Label();
            this.lblEspionageTechnology = new System.Windows.Forms.Label();
            this.tpShipyard = new System.Windows.Forms.TabPage();
            this.pPathfinder = new System.Windows.Forms.Panel();
            this.lblPathfinderTimeRemain = new System.Windows.Forms.Label();
            this.tbPathfinderCount = new System.Windows.Forms.TextBox();
            this.lblPathfinderShade = new System.Windows.Forms.Label();
            this.lblPathfinderDuration = new System.Windows.Forms.Label();
            this.btnPathfinderConstruct = new System.Windows.Forms.Button();
            this.lblPathfinderDeuteriumCost = new System.Windows.Forms.Label();
            this.lblPathfinderCrystalCost = new System.Windows.Forms.Label();
            this.lblPathfinderMetalCost = new System.Windows.Forms.Label();
            this.lblPathfinderCount = new System.Windows.Forms.Label();
            this.lblPathfinder = new System.Windows.Forms.Label();
            this.pReaper = new System.Windows.Forms.Panel();
            this.lblReaperTimeRemain = new System.Windows.Forms.Label();
            this.tbReaperCount = new System.Windows.Forms.TextBox();
            this.lblReaperShade = new System.Windows.Forms.Label();
            this.lblReaperDuration = new System.Windows.Forms.Label();
            this.btnReaperConstruct = new System.Windows.Forms.Button();
            this.lblReaperDeuteriumCost = new System.Windows.Forms.Label();
            this.lblReaperCrystalCost = new System.Windows.Forms.Label();
            this.lblReaperMetalCost = new System.Windows.Forms.Label();
            this.lblReaperCount = new System.Windows.Forms.Label();
            this.lblReaper = new System.Windows.Forms.Label();
            this.pDeathstar = new System.Windows.Forms.Panel();
            this.lblDeathstarTimeRemain = new System.Windows.Forms.Label();
            this.tbDeathstarCount = new System.Windows.Forms.TextBox();
            this.lblDeathstarShade = new System.Windows.Forms.Label();
            this.lblDeathstarDuration = new System.Windows.Forms.Label();
            this.btnDeathstarConstruct = new System.Windows.Forms.Button();
            this.lblDeathstarDeuteriumCost = new System.Windows.Forms.Label();
            this.lblDeathstarCrystalCost = new System.Windows.Forms.Label();
            this.lblDeathstarMetalCost = new System.Windows.Forms.Label();
            this.lblDeathstarCount = new System.Windows.Forms.Label();
            this.lblDeathstar = new System.Windows.Forms.Label();
            this.pDestroyer = new System.Windows.Forms.Panel();
            this.lblDestroyerTimeRemain = new System.Windows.Forms.Label();
            this.tbDestroyerCount = new System.Windows.Forms.TextBox();
            this.lblDestroyerShade = new System.Windows.Forms.Label();
            this.lblDestroyerDuration = new System.Windows.Forms.Label();
            this.btnDestroyerConstruct = new System.Windows.Forms.Button();
            this.lblDestroyerDeuteriumCost = new System.Windows.Forms.Label();
            this.lblDestroyerCrystalCost = new System.Windows.Forms.Label();
            this.lblDestroyerMetalCost = new System.Windows.Forms.Label();
            this.lblDestroyerCount = new System.Windows.Forms.Label();
            this.lblDestroyer = new System.Windows.Forms.Label();
            this.pBomber = new System.Windows.Forms.Panel();
            this.lblBomberTimeRemain = new System.Windows.Forms.Label();
            this.tbBomberCount = new System.Windows.Forms.TextBox();
            this.lblBomberShade = new System.Windows.Forms.Label();
            this.lblBomberDuration = new System.Windows.Forms.Label();
            this.btnBomberConstruct = new System.Windows.Forms.Button();
            this.lblBomberDeuteriumCost = new System.Windows.Forms.Label();
            this.lblBomberCrystalCost = new System.Windows.Forms.Label();
            this.lblBomberMetalCost = new System.Windows.Forms.Label();
            this.lblBomberCount = new System.Windows.Forms.Label();
            this.lblBomber = new System.Windows.Forms.Label();
            this.pBattlecruiser = new System.Windows.Forms.Panel();
            this.lblBattlecruiserTimeRemain = new System.Windows.Forms.Label();
            this.tbBattlecruiserCount = new System.Windows.Forms.TextBox();
            this.lblBattlecruiserShade = new System.Windows.Forms.Label();
            this.lblBattlecruiserDuration = new System.Windows.Forms.Label();
            this.btnBattlecruiserConstruct = new System.Windows.Forms.Button();
            this.lblBattlecruiserDeuteriumCost = new System.Windows.Forms.Label();
            this.lblBattlecruiserCrystalCost = new System.Windows.Forms.Label();
            this.lblBattlecruiserMetalCost = new System.Windows.Forms.Label();
            this.lblBattlecruiserCount = new System.Windows.Forms.Label();
            this.lblBattlecruiser = new System.Windows.Forms.Label();
            this.pBattleship = new System.Windows.Forms.Panel();
            this.lblBattleshipTimeRemain = new System.Windows.Forms.Label();
            this.tbBattleshipCount = new System.Windows.Forms.TextBox();
            this.lblBattleshipShade = new System.Windows.Forms.Label();
            this.lblBattleshipDuration = new System.Windows.Forms.Label();
            this.btnBattleshipConstruct = new System.Windows.Forms.Button();
            this.lblBattleshipDeuteriumCost = new System.Windows.Forms.Label();
            this.lblBattleshipCrystalCost = new System.Windows.Forms.Label();
            this.lblBattleshipMetalCost = new System.Windows.Forms.Label();
            this.lblBattleshipCount = new System.Windows.Forms.Label();
            this.lblBattleship = new System.Windows.Forms.Label();
            this.pCruiser = new System.Windows.Forms.Panel();
            this.lblCruiserTimeRemain = new System.Windows.Forms.Label();
            this.tbCruiserCount = new System.Windows.Forms.TextBox();
            this.lblCruiserShade = new System.Windows.Forms.Label();
            this.lblCruiserDuration = new System.Windows.Forms.Label();
            this.btnCruiserConstruct = new System.Windows.Forms.Button();
            this.lblCruiserDeuteriumCost = new System.Windows.Forms.Label();
            this.lblCruiserCrystalCost = new System.Windows.Forms.Label();
            this.lblCruiserMetalCost = new System.Windows.Forms.Label();
            this.lblCruiserCount = new System.Windows.Forms.Label();
            this.lblCruiser = new System.Windows.Forms.Label();
            this.pHeavyFighter = new System.Windows.Forms.Panel();
            this.lblHeavyFighterTimeRemain = new System.Windows.Forms.Label();
            this.tbHeavyFighterCount = new System.Windows.Forms.TextBox();
            this.lblHeavyFighterShade = new System.Windows.Forms.Label();
            this.lblHeavyFighterDuration = new System.Windows.Forms.Label();
            this.btnHeavyFighterConstruct = new System.Windows.Forms.Button();
            this.lblHeavyFighterDeuteriumCost = new System.Windows.Forms.Label();
            this.lblHeavyFighterCrystalCost = new System.Windows.Forms.Label();
            this.lblHeavyFighterMetalCost = new System.Windows.Forms.Label();
            this.lblHeavyFighterCount = new System.Windows.Forms.Label();
            this.lblHeavyFighter = new System.Windows.Forms.Label();
            this.pLightFighter = new System.Windows.Forms.Panel();
            this.lblLightFighterTimeRemain = new System.Windows.Forms.Label();
            this.tbLightFighterCount = new System.Windows.Forms.TextBox();
            this.lblLightFighterShade = new System.Windows.Forms.Label();
            this.lblLightFighterDuration = new System.Windows.Forms.Label();
            this.btnLightFighterConstruct = new System.Windows.Forms.Button();
            this.lblLightFighterDeuteriumCost = new System.Windows.Forms.Label();
            this.lblLightFighterCrystalCost = new System.Windows.Forms.Label();
            this.lblLightFighterMetalCost = new System.Windows.Forms.Label();
            this.lblLightFighterCount = new System.Windows.Forms.Label();
            this.lblLightFighter = new System.Windows.Forms.Label();
            this.pEspionageProbe = new System.Windows.Forms.Panel();
            this.lblEspionageProbeTimeRemain = new System.Windows.Forms.Label();
            this.tbEspionageProbeCount = new System.Windows.Forms.TextBox();
            this.lblEspionageProbeShade = new System.Windows.Forms.Label();
            this.lblEspionageProbeDuration = new System.Windows.Forms.Label();
            this.btnEspionageProbeConstruct = new System.Windows.Forms.Button();
            this.lblEspionageProbeDeuteriumCost = new System.Windows.Forms.Label();
            this.lblEspionageProbeCrystalCost = new System.Windows.Forms.Label();
            this.lblEspionageProbeMetalCost = new System.Windows.Forms.Label();
            this.lblEspionageProbeCount = new System.Windows.Forms.Label();
            this.lblEspionageProbe = new System.Windows.Forms.Label();
            this.pRecycler = new System.Windows.Forms.Panel();
            this.lblRecyclerTimeRemian = new System.Windows.Forms.Label();
            this.tbRecyclerCount = new System.Windows.Forms.TextBox();
            this.lblRecyclerShade = new System.Windows.Forms.Label();
            this.lblRecyclerDuration = new System.Windows.Forms.Label();
            this.btnRecyclerConstruct = new System.Windows.Forms.Button();
            this.lblRecyclerDeuteriumCost = new System.Windows.Forms.Label();
            this.lblRecyclerCrystalCost = new System.Windows.Forms.Label();
            this.lblRecyclerMetalCost = new System.Windows.Forms.Label();
            this.lblRecyclerCount = new System.Windows.Forms.Label();
            this.lblRecycler = new System.Windows.Forms.Label();
            this.pColonyShip = new System.Windows.Forms.Panel();
            this.lblColonyShipTimeRemain = new System.Windows.Forms.Label();
            this.tbColonyShipCount = new System.Windows.Forms.TextBox();
            this.lblColonyShipShade = new System.Windows.Forms.Label();
            this.lblColonyShipDuration = new System.Windows.Forms.Label();
            this.btnColonyShipConstruct = new System.Windows.Forms.Button();
            this.lblColonyShipDeuteriumCost = new System.Windows.Forms.Label();
            this.lblColonyShipCrystalCost = new System.Windows.Forms.Label();
            this.lblColonyShipMetalCost = new System.Windows.Forms.Label();
            this.lblColonyShipCount = new System.Windows.Forms.Label();
            this.lblColonyShip = new System.Windows.Forms.Label();
            this.pLargeCargo = new System.Windows.Forms.Panel();
            this.lblLargeCargoTimeRemain = new System.Windows.Forms.Label();
            this.tbLargeCargoCount = new System.Windows.Forms.TextBox();
            this.lblLargeCargoShade = new System.Windows.Forms.Label();
            this.lblLargeCargoDuration = new System.Windows.Forms.Label();
            this.btnLargeCargoConstruct = new System.Windows.Forms.Button();
            this.lblLargeCargoDeuteriumCost = new System.Windows.Forms.Label();
            this.lblLargeCargoCrystalCost = new System.Windows.Forms.Label();
            this.lblLargeCargoMetalCost = new System.Windows.Forms.Label();
            this.lblLargeCargoCount = new System.Windows.Forms.Label();
            this.lblLargeCargo = new System.Windows.Forms.Label();
            this.pSmallCargo = new System.Windows.Forms.Panel();
            this.lblSmallCargoTimeRemain = new System.Windows.Forms.Label();
            this.tbSmallCargoCount = new System.Windows.Forms.TextBox();
            this.lblSmallCargoShade = new System.Windows.Forms.Label();
            this.lblSmallCargoDuration = new System.Windows.Forms.Label();
            this.btnSmallCargoConstruct = new System.Windows.Forms.Button();
            this.lblSmallCargoDeuteriumCost = new System.Windows.Forms.Label();
            this.lblSmallCargoCrystalCost = new System.Windows.Forms.Label();
            this.lblSmallCargoMetalCost = new System.Windows.Forms.Label();
            this.lblSmallCargoCount = new System.Windows.Forms.Label();
            this.lblSmallCargo = new System.Windows.Forms.Label();
            this.tpDefence = new System.Windows.Forms.TabPage();
            this.pInterplanetaryMissile = new System.Windows.Forms.Panel();
            this.lblInterplanetaryMissileTimeRemain = new System.Windows.Forms.Label();
            this.tbInterplanetaryMissileCount = new System.Windows.Forms.TextBox();
            this.lblInterplanetaryMissileShade = new System.Windows.Forms.Label();
            this.lblInterplanetaryMissileDuration = new System.Windows.Forms.Label();
            this.btnInterplanetaryMissileConstruct = new System.Windows.Forms.Button();
            this.lblInterplanetaryMissileDeuteriumCost = new System.Windows.Forms.Label();
            this.lblInterplanetaryMissileCrystalCost = new System.Windows.Forms.Label();
            this.lblInterplanetaryMissileMetalCost = new System.Windows.Forms.Label();
            this.lblInterplanetaryMissileCount = new System.Windows.Forms.Label();
            this.lblInterplanetaryMissile = new System.Windows.Forms.Label();
            this.pAntiBallisticMissile = new System.Windows.Forms.Panel();
            this.lblAntiBallisticMissileTimeRemain = new System.Windows.Forms.Label();
            this.tbAntiBallisticMissileCount = new System.Windows.Forms.TextBox();
            this.lblAntiBallisticMissileShade = new System.Windows.Forms.Label();
            this.lblAntiBallisticMissileDuration = new System.Windows.Forms.Label();
            this.btnAntiBallisticMissileConstruct = new System.Windows.Forms.Button();
            this.lblAntiBallisticMissileDeuteriumCost = new System.Windows.Forms.Label();
            this.lblAntiBallisticMissileCrystalCost = new System.Windows.Forms.Label();
            this.lblAntiBallisticMissileMetalCost = new System.Windows.Forms.Label();
            this.lblAntiBallisticMissileCount = new System.Windows.Forms.Label();
            this.lblAntiBallisticMissile = new System.Windows.Forms.Label();
            this.pLargeShieldDome = new System.Windows.Forms.Panel();
            this.lblLargeShieldDomeTimeRemain = new System.Windows.Forms.Label();
            this.tbLargeShieldDomeCount = new System.Windows.Forms.TextBox();
            this.lblLargeShieldDomeShade = new System.Windows.Forms.Label();
            this.lblLargeShieldDomeDuration = new System.Windows.Forms.Label();
            this.btnLargeShieldDomeConstruct = new System.Windows.Forms.Button();
            this.lblLargeShieldDomeDeuteriumCost = new System.Windows.Forms.Label();
            this.lblLargeShieldDomeCrystalCost = new System.Windows.Forms.Label();
            this.lblLargeShieldDomeMetalCost = new System.Windows.Forms.Label();
            this.lblLargeShieldDomeCount = new System.Windows.Forms.Label();
            this.lblLargeShieldDome = new System.Windows.Forms.Label();
            this.pSmallShieldDome = new System.Windows.Forms.Panel();
            this.lblSmallShieldDomeTimeRemain = new System.Windows.Forms.Label();
            this.tbSmallShieldDomeCount = new System.Windows.Forms.TextBox();
            this.lblSmallShieldDomeShade = new System.Windows.Forms.Label();
            this.lblSmallShieldDomeDuration = new System.Windows.Forms.Label();
            this.btnSmallShieldDomeConstruct = new System.Windows.Forms.Button();
            this.lblSmallShieldDomeDeuteriumCost = new System.Windows.Forms.Label();
            this.lblSmallShieldDomeCrystalCost = new System.Windows.Forms.Label();
            this.lblSmallShieldDomeMetalCost = new System.Windows.Forms.Label();
            this.lblSmallShieldDomeCount = new System.Windows.Forms.Label();
            this.lblSmallShieldDome = new System.Windows.Forms.Label();
            this.pPlasmaTurret = new System.Windows.Forms.Panel();
            this.lblPlasmaTurretTimeRemain = new System.Windows.Forms.Label();
            this.tbPlasmaTurretCount = new System.Windows.Forms.TextBox();
            this.lblPlasmaTurretShade = new System.Windows.Forms.Label();
            this.lblPlasmaTurretDuration = new System.Windows.Forms.Label();
            this.btnPlasmaTurretConstruct = new System.Windows.Forms.Button();
            this.lblPlasmaTurretDeuteriumCost = new System.Windows.Forms.Label();
            this.lblPlasmaTurretCrystalCost = new System.Windows.Forms.Label();
            this.lblPlasmaTurretMetalCost = new System.Windows.Forms.Label();
            this.lblPlasmaTurretCount = new System.Windows.Forms.Label();
            this.lblPlasmaTurret = new System.Windows.Forms.Label();
            this.pIonCannon = new System.Windows.Forms.Panel();
            this.lblIonCannonTimeRemain = new System.Windows.Forms.Label();
            this.tbIonCannonCount = new System.Windows.Forms.TextBox();
            this.lblIonCannonShade = new System.Windows.Forms.Label();
            this.lblIonCannonDuration = new System.Windows.Forms.Label();
            this.btnIonCannonConstruct = new System.Windows.Forms.Button();
            this.lblIonCannonDeuteriumCost = new System.Windows.Forms.Label();
            this.lblIonCannonCrystalCost = new System.Windows.Forms.Label();
            this.lblIonCannonMetalCost = new System.Windows.Forms.Label();
            this.lblIonCannonCount = new System.Windows.Forms.Label();
            this.lblIonCannon = new System.Windows.Forms.Label();
            this.pGaussCannon = new System.Windows.Forms.Panel();
            this.lblGaussCannonTimeRemain = new System.Windows.Forms.Label();
            this.tbGaussCannonCount = new System.Windows.Forms.TextBox();
            this.lblGaussCannonShade = new System.Windows.Forms.Label();
            this.lblGaussCannonDuration = new System.Windows.Forms.Label();
            this.btnGaussCannonConstruct = new System.Windows.Forms.Button();
            this.lblGaussCannonDeuteriumCost = new System.Windows.Forms.Label();
            this.lblGaussCannonCrystalCost = new System.Windows.Forms.Label();
            this.lblGaussCannonMetalCost = new System.Windows.Forms.Label();
            this.lblGaussCannonCount = new System.Windows.Forms.Label();
            this.lblGaussCannon = new System.Windows.Forms.Label();
            this.pHeavyLaser = new System.Windows.Forms.Panel();
            this.lblHeavyLaserTimeRemain = new System.Windows.Forms.Label();
            this.tbHeavyLaserCount = new System.Windows.Forms.TextBox();
            this.lblHeavyLaserShade = new System.Windows.Forms.Label();
            this.lblHeavyLaserDuration = new System.Windows.Forms.Label();
            this.btnHeavyLaserConstruct = new System.Windows.Forms.Button();
            this.lblHeavyLaserDeuteriumCost = new System.Windows.Forms.Label();
            this.lblHeavyLaserCrystalCost = new System.Windows.Forms.Label();
            this.lblHeavyLaserMetalCost = new System.Windows.Forms.Label();
            this.lblHeavyLaserCount = new System.Windows.Forms.Label();
            this.lblHeavyLaser = new System.Windows.Forms.Label();
            this.pLightLaser = new System.Windows.Forms.Panel();
            this.lblLightLaserTimeRemain = new System.Windows.Forms.Label();
            this.tbLightLaserCount = new System.Windows.Forms.TextBox();
            this.lblLightLaserShade = new System.Windows.Forms.Label();
            this.lblLightLaserDuration = new System.Windows.Forms.Label();
            this.btnLightLaserConstruct = new System.Windows.Forms.Button();
            this.lblLightLaserDeuteriumCost = new System.Windows.Forms.Label();
            this.lblLightLaserCrystalCost = new System.Windows.Forms.Label();
            this.lblLightLaserMetalCost = new System.Windows.Forms.Label();
            this.lblLightLaserCount = new System.Windows.Forms.Label();
            this.lblLightLaser = new System.Windows.Forms.Label();
            this.pRocketLauncher = new System.Windows.Forms.Panel();
            this.lblRocketLauncherTimeRemain = new System.Windows.Forms.Label();
            this.tbRocketLauncherCount = new System.Windows.Forms.TextBox();
            this.lblRocketLauncherShade = new System.Windows.Forms.Label();
            this.lblRocketLauncherDuration = new System.Windows.Forms.Label();
            this.btnRocketLauncherConstruct = new System.Windows.Forms.Button();
            this.lblRocketLauncherDeuteriumCost = new System.Windows.Forms.Label();
            this.lblRocketLauncherCrystalCost = new System.Windows.Forms.Label();
            this.lblRocketLauncherMetalCost = new System.Windows.Forms.Label();
            this.lblRocketLauncherCount = new System.Windows.Forms.Label();
            this.lblRocketLauncher = new System.Windows.Forms.Label();
            this.pCrawler = new System.Windows.Forms.Panel();
            this.lblCrawlerTimeRemain = new System.Windows.Forms.Label();
            this.tbCrawlerCount = new System.Windows.Forms.TextBox();
            this.lblCrawlerShade = new System.Windows.Forms.Label();
            this.lblCrawlerDuration = new System.Windows.Forms.Label();
            this.btnCrawlerConstruct = new System.Windows.Forms.Button();
            this.lblCrawlerDeuteriumCost = new System.Windows.Forms.Label();
            this.lblCrawlerCrystalCost = new System.Windows.Forms.Label();
            this.lblCrawlerMetalCost = new System.Windows.Forms.Label();
            this.lblCrawlerCount = new System.Windows.Forms.Label();
            this.lblCrawler = new System.Windows.Forms.Label();
            this.pSolarSatellite = new System.Windows.Forms.Panel();
            this.lblSolarSatelliteTimeRemain = new System.Windows.Forms.Label();
            this.tbSolarSatelliteCount = new System.Windows.Forms.TextBox();
            this.lblSolarSatelliteShade = new System.Windows.Forms.Label();
            this.lblSolarSatelliteDuration = new System.Windows.Forms.Label();
            this.btnSolarSatelliteConstruct = new System.Windows.Forms.Button();
            this.lblSolarSatelliteDeuteriumCost = new System.Windows.Forms.Label();
            this.lblSolarSatelliteCrystalCost = new System.Windows.Forms.Label();
            this.lblSolarSatelliteMetalCost = new System.Windows.Forms.Label();
            this.lblSolarSatelliteCount = new System.Windows.Forms.Label();
            this.lblSolarSatellite = new System.Windows.Forms.Label();
            this.tpRequirements = new System.Windows.Forms.TabPage();
            this.tpFleet = new System.Windows.Forms.TabPage();
            this.btnAllResources = new System.Windows.Forms.Button();
            this.tbDeuteriumCargo = new System.Windows.Forms.TextBox();
            this.tbCrystalCargo = new System.Windows.Forms.TextBox();
            this.tbMetalCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendCargo = new System.Windows.Forms.Button();
            this.cbFleetTarget = new System.Windows.Forms.ComboBox();
            this.tpPoints = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblDefencesTotalCost = new System.Windows.Forms.Label();
            this.lblDefencesDeuteriumCost = new System.Windows.Forms.Label();
            this.lblDefencesCrystalCost = new System.Windows.Forms.Label();
            this.lblDefencesMetalCost = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblFleetTotalCost = new System.Windows.Forms.Label();
            this.lblFleetDeuteriumCost = new System.Windows.Forms.Label();
            this.lblFleetCrystalCost = new System.Windows.Forms.Label();
            this.lblFleetMetalCost = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblBuildingsTotalCost = new System.Windows.Forms.Label();
            this.lblBuildingsDeuteriumCost = new System.Windows.Forms.Label();
            this.lblBuildingsCrystalCost = new System.Windows.Forms.Label();
            this.lblBuildingsMetalCost = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblResearchesTotalCost = new System.Windows.Forms.Label();
            this.lblResearchesDeuteriumCost = new System.Windows.Forms.Label();
            this.lblResearchesCrystalCost = new System.Windows.Forms.Label();
            this.lblResearchesMetalCost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalTotalCost = new System.Windows.Forms.Label();
            this.lblTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblTotalCrystalCost = new System.Windows.Forms.Label();
            this.lblTotalMetalCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpPlanet = new System.Windows.Forms.TabPage();
            this.btnChangePlanetName = new System.Windows.Forms.Button();
            this.tbNewPlanetName = new System.Windows.Forms.TextBox();
            this.tpMerchant = new System.Windows.Forms.TabPage();
            this.pMerchant = new System.Windows.Forms.Panel();
            this.btnExchange = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDeuteriumMax = new System.Windows.Forms.Label();
            this.lblCrystalMax = new System.Windows.Forms.Label();
            this.lblMetalMax = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbDeuteriumAmount = new System.Windows.Forms.TextBox();
            this.tbCrystalAmount = new System.Windows.Forms.TextBox();
            this.tbMetalAmount = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDeuteriumMerchant = new System.Windows.Forms.Label();
            this.lblCrystalMerchant = new System.Windows.Forms.Label();
            this.lblMetalMerchant = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDeuteriumFactor = new System.Windows.Forms.Label();
            this.lblCrystalFactor = new System.Windows.Forms.Label();
            this.lblMetalFactor = new System.Windows.Forms.Label();
            this.gbMerchant = new System.Windows.Forms.GroupBox();
            this.rbDeuterium = new System.Windows.Forms.RadioButton();
            this.rbCrystal = new System.Windows.Forms.RadioButton();
            this.rbMetal = new System.Windows.Forms.RadioButton();
            this.pInfo = new System.Windows.Forms.Panel();
            this.gbTimeEvents = new System.Windows.Forms.GroupBox();
            this.lblTimeEvent2 = new System.Windows.Forms.Label();
            this.lblTimeEvent1 = new System.Windows.Forms.Label();
            this.lblTimeEvent0 = new System.Windows.Forms.Label();
            this.gbPlanetCountInfo = new System.Windows.Forms.GroupBox();
            this.btnDeletePlanet = new System.Windows.Forms.Button();
            this.btnNewPlanet = new System.Windows.Forms.Button();
            this.lblPlanetCount = new System.Windows.Forms.Label();
            this.gbEnergyInfo = new System.Windows.Forms.GroupBox();
            this.lblEnergyOverValue = new System.Windows.Forms.Label();
            this.lblEnergyAvailableValue = new System.Windows.Forms.Label();
            this.lblEnergyDemandValue = new System.Windows.Forms.Label();
            this.gbGameInfo = new System.Windows.Forms.GroupBox();
            this.gbStorageTotal = new System.Windows.Forms.GroupBox();
            this.lblStorageDeuteriumTotalValue = new System.Windows.Forms.Label();
            this.lblStorageMetalTotalValue = new System.Windows.Forms.Label();
            this.lblStorageCrystalTotalValue = new System.Windows.Forms.Label();
            this.gbTotalResources = new System.Windows.Forms.GroupBox();
            this.lblDeuteriumTotalValue = new System.Windows.Forms.Label();
            this.lblCrystalTotalValue = new System.Windows.Forms.Label();
            this.gbStoragePlanet = new System.Windows.Forms.GroupBox();
            this.lblStorageDeuteriumPlanetValue = new System.Windows.Forms.Label();
            this.lblStorageMetalPlanetValue = new System.Windows.Forms.Label();
            this.lblStorageCrystalPlanetValue = new System.Windows.Forms.Label();
            this.gbPlanetResources = new System.Windows.Forms.GroupBox();
            this.lblDeuteriumPlanetValue = new System.Windows.Forms.Label();
            this.lblMetalPlanetValue = new System.Windows.Forms.Label();
            this.lblCrystalPlanetValue = new System.Windows.Forms.Label();
            this.gbPlanetInfo = new System.Windows.Forms.GroupBox();
            this.lblPlanetFields = new System.Windows.Forms.Label();
            this.lblDiameterValue = new System.Windows.Forms.Label();
            this.lblTemperatureValue = new System.Windows.Forms.Label();
            this.lblPlanetNameValue = new System.Windows.Forms.Label();
            this.pPlanetSelect = new System.Windows.Forms.Panel();
            this.cbPlanetSelect = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblEspionageTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblComputerTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblCombustionDriveCollectTime = new System.Windows.Forms.Label();
            this.lblImpulseDriveCollectTime = new System.Windows.Forms.Label();
            this.lblHyperspaceDriveCollectTime = new System.Windows.Forms.Label();
            this.lblWeaponsTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblShieldingTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblArmourTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblEnergyTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblHyperspaceTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblLaserTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblIonTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblPlasmaTechnologyCollectTime = new System.Windows.Forms.Label();
            this.lblIrnCollectTime = new System.Windows.Forms.Label();
            this.lblAstrophisicsColletTime = new System.Windows.Forms.Label();
            this.lblMetalMineTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblMetalMineCollectTime = new System.Windows.Forms.Label();
            this.lblCrystalMineTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblDeuteriumSynthesizerTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblFusionReactorTotalDeuteriumCost = new System.Windows.Forms.Label();
            this.lblCrystalMineCollectTime = new System.Windows.Forms.Label();
            this.lblDeuteriumSyntesizerCollectTime = new System.Windows.Forms.Label();
            this.lblFusionReactorCollectTime = new System.Windows.Forms.Label();
            this.pContent.SuspendLayout();
            this.pPlanet.SuspendLayout();
            this.pPlanetStructures.SuspendLayout();
            this.tcStructures.SuspendLayout();
            this.tpResources.SuspendLayout();
            this.pDeuteriumTank.SuspendLayout();
            this.pCrystalStorage.SuspendLayout();
            this.pMetalStorage.SuspendLayout();
            this.pFusionReactor.SuspendLayout();
            this.pSolarPlant.SuspendLayout();
            this.pDeuteriumSynthesizer.SuspendLayout();
            this.pCrystalMine.SuspendLayout();
            this.pMetalMine.SuspendLayout();
            this.tpProduction.SuspendLayout();
            this.pTotalProduction.SuspendLayout();
            this.pTotalProductionDetails.SuspendLayout();
            this.pTotalDeuteriumProductionDetails.SuspendLayout();
            this.pTotalCrystalProductionDetails.SuspendLayout();
            this.pTotalMetalProductionDetails.SuspendLayout();
            this.pTotalProductionHeader.SuspendLayout();
            this.tpStation.SuspendLayout();
            this.pJumpGate.SuspendLayout();
            this.pSensorPhalanx.SuspendLayout();
            this.pLunarBase.SuspendLayout();
            this.pSpaceDock.SuspendLayout();
            this.pTerraformer.SuspendLayout();
            this.pMissileSilo.SuspendLayout();
            this.pResearchLab.SuspendLayout();
            this.pShipyard.SuspendLayout();
            this.pNaniteFactory.SuspendLayout();
            this.pRoboticsFactory.SuspendLayout();
            this.tpResearch.SuspendLayout();
            this.pGravitonTechnology.SuspendLayout();
            this.pAstrophisics.SuspendLayout();
            this.pIrn.SuspendLayout();
            this.pPlasmaTechnology.SuspendLayout();
            this.pIonTechnology.SuspendLayout();
            this.pLaserTechnology.SuspendLayout();
            this.pHyperspaceTechnology.SuspendLayout();
            this.pEnergyTechnology.SuspendLayout();
            this.pArmourTechnology.SuspendLayout();
            this.pShieldingTechnology.SuspendLayout();
            this.pWeaponsTechnology.SuspendLayout();
            this.pHyperspaceDrive.SuspendLayout();
            this.pImpulseDrive.SuspendLayout();
            this.pCombustionDrive.SuspendLayout();
            this.pComputerTechnology.SuspendLayout();
            this.pEspionageTechnology.SuspendLayout();
            this.tpShipyard.SuspendLayout();
            this.pPathfinder.SuspendLayout();
            this.pReaper.SuspendLayout();
            this.pDeathstar.SuspendLayout();
            this.pDestroyer.SuspendLayout();
            this.pBomber.SuspendLayout();
            this.pBattlecruiser.SuspendLayout();
            this.pBattleship.SuspendLayout();
            this.pCruiser.SuspendLayout();
            this.pHeavyFighter.SuspendLayout();
            this.pLightFighter.SuspendLayout();
            this.pEspionageProbe.SuspendLayout();
            this.pRecycler.SuspendLayout();
            this.pColonyShip.SuspendLayout();
            this.pLargeCargo.SuspendLayout();
            this.pSmallCargo.SuspendLayout();
            this.tpDefence.SuspendLayout();
            this.pInterplanetaryMissile.SuspendLayout();
            this.pAntiBallisticMissile.SuspendLayout();
            this.pLargeShieldDome.SuspendLayout();
            this.pSmallShieldDome.SuspendLayout();
            this.pPlasmaTurret.SuspendLayout();
            this.pIonCannon.SuspendLayout();
            this.pGaussCannon.SuspendLayout();
            this.pHeavyLaser.SuspendLayout();
            this.pLightLaser.SuspendLayout();
            this.pRocketLauncher.SuspendLayout();
            this.pCrawler.SuspendLayout();
            this.pSolarSatellite.SuspendLayout();
            this.tpFleet.SuspendLayout();
            this.tpPoints.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpPlanet.SuspendLayout();
            this.tpMerchant.SuspendLayout();
            this.pMerchant.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbMerchant.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.gbTimeEvents.SuspendLayout();
            this.gbPlanetCountInfo.SuspendLayout();
            this.gbEnergyInfo.SuspendLayout();
            this.gbGameInfo.SuspendLayout();
            this.gbStorageTotal.SuspendLayout();
            this.gbTotalResources.SuspendLayout();
            this.gbStoragePlanet.SuspendLayout();
            this.gbPlanetResources.SuspendLayout();
            this.gbPlanetInfo.SuspendLayout();
            this.pPlanetSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(1420, 6);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(150, 25);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Nowa gra";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(180, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 25);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Aktualizuj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(690, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbEcoSpeed
            // 
            this.tbEcoSpeed.Location = new System.Drawing.Point(1760, 6);
            this.tbEcoSpeed.Name = "tbEcoSpeed";
            this.tbEcoSpeed.Size = new System.Drawing.Size(150, 23);
            this.tbEcoSpeed.TabIndex = 2;
            this.tbEcoSpeed.Text = "Prędkość symulacji";
            this.tbEcoSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEcoSpeed.Click += new System.EventHandler(this.TextBox_Click);
            this.tbEcoSpeed.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // tbNewGameName
            // 
            this.tbNewGameName.Location = new System.Drawing.Point(1590, 6);
            this.tbNewGameName.Name = "tbNewGameName";
            this.tbNewGameName.Size = new System.Drawing.Size(150, 23);
            this.tbNewGameName.TabIndex = 1;
            this.tbNewGameName.Text = "Nazwa gry";
            this.tbNewGameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNewGameName.Click += new System.EventHandler(this.TextBox_Click);
            this.tbNewGameName.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(350, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(520, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 25);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLastUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastUpdate.Location = new System.Drawing.Point(10, 100);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(150, 30);
            this.lblLastUpdate.TabIndex = 5;
            this.lblLastUpdate.Text = "Ostatnia aktualizacja";
            this.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameNameValue
            // 
            this.lblGameNameValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblGameNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameNameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameNameValue.Location = new System.Drawing.Point(10, 20);
            this.lblGameNameValue.Name = "lblGameNameValue";
            this.lblGameNameValue.Size = new System.Drawing.Size(150, 30);
            this.lblGameNameValue.TabIndex = 4;
            this.lblGameNameValue.Text = "Nazwa gry";
            this.lblGameNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEcoSpeedValue
            // 
            this.lblEcoSpeedValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEcoSpeedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEcoSpeedValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEcoSpeedValue.Location = new System.Drawing.Point(10, 60);
            this.lblEcoSpeedValue.Name = "lblEcoSpeedValue";
            this.lblEcoSpeedValue.Size = new System.Drawing.Size(150, 30);
            this.lblEcoSpeedValue.TabIndex = 3;
            this.lblEcoSpeedValue.Text = "Prędkość symulacji";
            this.lblEcoSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalTotalValue
            // 
            this.lblMetalTotalValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMetalTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalTotalValue.Location = new System.Drawing.Point(10, 20);
            this.lblMetalTotalValue.Name = "lblMetalTotalValue";
            this.lblMetalTotalValue.Size = new System.Drawing.Size(150, 30);
            this.lblMetalTotalValue.TabIndex = 1;
            this.lblMetalTotalValue.Text = "Metal";
            this.lblMetalTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pContent.Controls.Add(this.pPlanet);
            this.pContent.Controls.Add(this.pPlanetSelect);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 0);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(1904, 1011);
            this.pContent.TabIndex = 6;
            // 
            // pPlanet
            // 
            this.pPlanet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pPlanet.Controls.Add(this.pPlanetStructures);
            this.pPlanet.Controls.Add(this.pInfo);
            this.pPlanet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlanet.Location = new System.Drawing.Point(0, 38);
            this.pPlanet.Name = "pPlanet";
            this.pPlanet.Size = new System.Drawing.Size(1904, 973);
            this.pPlanet.TabIndex = 7;
            // 
            // pPlanetStructures
            // 
            this.pPlanetStructures.BackColor = System.Drawing.Color.Transparent;
            this.pPlanetStructures.Controls.Add(this.tcStructures);
            this.pPlanetStructures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlanetStructures.Location = new System.Drawing.Point(0, 140);
            this.pPlanetStructures.Name = "pPlanetStructures";
            this.pPlanetStructures.Size = new System.Drawing.Size(1904, 833);
            this.pPlanetStructures.TabIndex = 2;
            // 
            // tcStructures
            // 
            this.tcStructures.Controls.Add(this.tpResources);
            this.tcStructures.Controls.Add(this.tpProduction);
            this.tcStructures.Controls.Add(this.tpStation);
            this.tcStructures.Controls.Add(this.tpResearch);
            this.tcStructures.Controls.Add(this.tpShipyard);
            this.tcStructures.Controls.Add(this.tpDefence);
            this.tcStructures.Controls.Add(this.tpRequirements);
            this.tcStructures.Controls.Add(this.tpFleet);
            this.tcStructures.Controls.Add(this.tpPoints);
            this.tcStructures.Controls.Add(this.tpPlanet);
            this.tcStructures.Controls.Add(this.tpMerchant);
            this.tcStructures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStructures.ItemSize = new System.Drawing.Size(100, 25);
            this.tcStructures.Location = new System.Drawing.Point(0, 0);
            this.tcStructures.Name = "tcStructures";
            this.tcStructures.SelectedIndex = 0;
            this.tcStructures.Size = new System.Drawing.Size(1904, 833);
            this.tcStructures.TabIndex = 0;
            // 
            // tpResources
            // 
            this.tpResources.BackColor = System.Drawing.Color.Silver;
            this.tpResources.Controls.Add(this.pDeuteriumTank);
            this.tpResources.Controls.Add(this.pCrystalStorage);
            this.tpResources.Controls.Add(this.pMetalStorage);
            this.tpResources.Controls.Add(this.pFusionReactor);
            this.tpResources.Controls.Add(this.pSolarPlant);
            this.tpResources.Controls.Add(this.pDeuteriumSynthesizer);
            this.tpResources.Controls.Add(this.pCrystalMine);
            this.tpResources.Controls.Add(this.pMetalMine);
            this.tpResources.Location = new System.Drawing.Point(4, 29);
            this.tpResources.Name = "tpResources";
            this.tpResources.Padding = new System.Windows.Forms.Padding(3);
            this.tpResources.Size = new System.Drawing.Size(1896, 800);
            this.tpResources.TabIndex = 0;
            this.tpResources.Text = "Surowce";
            // 
            // pDeuteriumTank
            // 
            this.pDeuteriumTank.BackColor = System.Drawing.Color.Yellow;
            this.pDeuteriumTank.Controls.Add(this.lblDeuteriumTanlTimeRemain);
            this.pDeuteriumTank.Controls.Add(this.lblDeuteriumTankNewStorage);
            this.pDeuteriumTank.Controls.Add(this.lblDeuteriumTankDuration);
            this.pDeuteriumTank.Controls.Add(this.btnDeuteriumTankUpgrade);
            this.pDeuteriumTank.Controls.Add(this.lblDeuteriumTankDeuteriumCost);
            this.pDeuteriumTank.Controls.Add(this.lblDeuteriumTankCrystalCost);
            this.pDeuteriumTank.Controls.Add(this.lblDeuteriumTankMetalCost);
            this.pDeuteriumTank.Controls.Add(this.lblDeuteriumTankLevel);
            this.pDeuteriumTank.Controls.Add(this.lblDeuteriumTank);
            this.pDeuteriumTank.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDeuteriumTank.Location = new System.Drawing.Point(3, 353);
            this.pDeuteriumTank.Name = "pDeuteriumTank";
            this.pDeuteriumTank.Size = new System.Drawing.Size(1890, 50);
            this.pDeuteriumTank.TabIndex = 8;
            // 
            // lblDeuteriumTanlTimeRemain
            // 
            this.lblDeuteriumTanlTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumTanlTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTanlTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeuteriumTanlTimeRemain.Location = new System.Drawing.Point(1360, 10);
            this.lblDeuteriumTanlTimeRemain.Name = "lblDeuteriumTanlTimeRemain";
            this.lblDeuteriumTanlTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumTanlTimeRemain.TabIndex = 23;
            this.lblDeuteriumTanlTimeRemain.Text = "czas pozostały";
            this.lblDeuteriumTanlTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumTankNewStorage
            // 
            this.lblDeuteriumTankNewStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumTankNewStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumTankNewStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTankNewStorage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeuteriumTankNewStorage.Location = new System.Drawing.Point(940, 10);
            this.lblDeuteriumTankNewStorage.Name = "lblDeuteriumTankNewStorage";
            this.lblDeuteriumTankNewStorage.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumTankNewStorage.TabIndex = 14;
            this.lblDeuteriumTankNewStorage.Text = "nowa pojemność";
            this.lblDeuteriumTankNewStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumTankDuration
            // 
            this.lblDeuteriumTankDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumTankDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumTankDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTankDuration.Location = new System.Drawing.Point(800, 10);
            this.lblDeuteriumTankDuration.Name = "lblDeuteriumTankDuration";
            this.lblDeuteriumTankDuration.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumTankDuration.TabIndex = 13;
            this.lblDeuteriumTankDuration.Text = "czas";
            this.lblDeuteriumTankDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeuteriumTankUpgrade
            // 
            this.btnDeuteriumTankUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnDeuteriumTankUpgrade.Enabled = false;
            this.btnDeuteriumTankUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeuteriumTankUpgrade.Location = new System.Drawing.Point(1220, 10);
            this.btnDeuteriumTankUpgrade.Name = "btnDeuteriumTankUpgrade";
            this.btnDeuteriumTankUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnDeuteriumTankUpgrade.TabIndex = 12;
            this.btnDeuteriumTankUpgrade.Text = "Ulepsz";
            this.btnDeuteriumTankUpgrade.UseVisualStyleBackColor = false;
            this.btnDeuteriumTankUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblDeuteriumTankDeuteriumCost
            // 
            this.lblDeuteriumTankDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumTankDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumTankDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTankDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeuteriumTankDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblDeuteriumTankDeuteriumCost.Name = "lblDeuteriumTankDeuteriumCost";
            this.lblDeuteriumTankDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumTankDeuteriumCost.TabIndex = 11;
            this.lblDeuteriumTankDeuteriumCost.Text = "deuter";
            this.lblDeuteriumTankDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumTankCrystalCost
            // 
            this.lblDeuteriumTankCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumTankCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumTankCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTankCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeuteriumTankCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblDeuteriumTankCrystalCost.Name = "lblDeuteriumTankCrystalCost";
            this.lblDeuteriumTankCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumTankCrystalCost.TabIndex = 10;
            this.lblDeuteriumTankCrystalCost.Text = "kryształ";
            this.lblDeuteriumTankCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumTankMetalCost
            // 
            this.lblDeuteriumTankMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumTankMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumTankMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTankMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeuteriumTankMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblDeuteriumTankMetalCost.Name = "lblDeuteriumTankMetalCost";
            this.lblDeuteriumTankMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumTankMetalCost.TabIndex = 9;
            this.lblDeuteriumTankMetalCost.Text = "metal";
            this.lblDeuteriumTankMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumTankLevel
            // 
            this.lblDeuteriumTankLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumTankLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumTankLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTankLevel.Location = new System.Drawing.Point(320, 10);
            this.lblDeuteriumTankLevel.Name = "lblDeuteriumTankLevel";
            this.lblDeuteriumTankLevel.Size = new System.Drawing.Size(50, 30);
            this.lblDeuteriumTankLevel.TabIndex = 8;
            this.lblDeuteriumTankLevel.Text = "level";
            this.lblDeuteriumTankLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumTank
            // 
            this.lblDeuteriumTank.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumTank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTank.Location = new System.Drawing.Point(10, 10);
            this.lblDeuteriumTank.Name = "lblDeuteriumTank";
            this.lblDeuteriumTank.Size = new System.Drawing.Size(300, 30);
            this.lblDeuteriumTank.TabIndex = 7;
            this.lblDeuteriumTank.Text = "Zbiornik deuteru";
            this.lblDeuteriumTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCrystalStorage
            // 
            this.pCrystalStorage.BackColor = System.Drawing.Color.Gold;
            this.pCrystalStorage.Controls.Add(this.lblCrystalStorageTimeRemain);
            this.pCrystalStorage.Controls.Add(this.lblCrystalStorageNewStorage);
            this.pCrystalStorage.Controls.Add(this.lblCrystalStorageDuration);
            this.pCrystalStorage.Controls.Add(this.btnCrystalStorageUpgrade);
            this.pCrystalStorage.Controls.Add(this.lblCrystalStorageDeuteriumCost);
            this.pCrystalStorage.Controls.Add(this.lblCrystalStorageCrystalCost);
            this.pCrystalStorage.Controls.Add(this.lblCrystalStorageMetalCost);
            this.pCrystalStorage.Controls.Add(this.lblCrystalStorageLevel);
            this.pCrystalStorage.Controls.Add(this.lblCrystalStorage);
            this.pCrystalStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCrystalStorage.Location = new System.Drawing.Point(3, 303);
            this.pCrystalStorage.Name = "pCrystalStorage";
            this.pCrystalStorage.Size = new System.Drawing.Size(1890, 50);
            this.pCrystalStorage.TabIndex = 7;
            // 
            // lblCrystalStorageTimeRemain
            // 
            this.lblCrystalStorageTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalStorageTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalStorageTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCrystalStorageTimeRemain.Location = new System.Drawing.Point(1360, 10);
            this.lblCrystalStorageTimeRemain.Name = "lblCrystalStorageTimeRemain";
            this.lblCrystalStorageTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalStorageTimeRemain.TabIndex = 22;
            this.lblCrystalStorageTimeRemain.Text = "czas pozostały";
            this.lblCrystalStorageTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalStorageNewStorage
            // 
            this.lblCrystalStorageNewStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalStorageNewStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalStorageNewStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalStorageNewStorage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCrystalStorageNewStorage.Location = new System.Drawing.Point(940, 10);
            this.lblCrystalStorageNewStorage.Name = "lblCrystalStorageNewStorage";
            this.lblCrystalStorageNewStorage.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalStorageNewStorage.TabIndex = 14;
            this.lblCrystalStorageNewStorage.Text = "nowa pojemność";
            this.lblCrystalStorageNewStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalStorageDuration
            // 
            this.lblCrystalStorageDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalStorageDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalStorageDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalStorageDuration.Location = new System.Drawing.Point(800, 10);
            this.lblCrystalStorageDuration.Name = "lblCrystalStorageDuration";
            this.lblCrystalStorageDuration.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalStorageDuration.TabIndex = 13;
            this.lblCrystalStorageDuration.Text = "czas";
            this.lblCrystalStorageDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrystalStorageUpgrade
            // 
            this.btnCrystalStorageUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnCrystalStorageUpgrade.Enabled = false;
            this.btnCrystalStorageUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrystalStorageUpgrade.Location = new System.Drawing.Point(1220, 10);
            this.btnCrystalStorageUpgrade.Name = "btnCrystalStorageUpgrade";
            this.btnCrystalStorageUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnCrystalStorageUpgrade.TabIndex = 12;
            this.btnCrystalStorageUpgrade.Text = "Ulepsz";
            this.btnCrystalStorageUpgrade.UseVisualStyleBackColor = false;
            this.btnCrystalStorageUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblCrystalStorageDeuteriumCost
            // 
            this.lblCrystalStorageDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalStorageDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalStorageDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalStorageDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrystalStorageDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblCrystalStorageDeuteriumCost.Name = "lblCrystalStorageDeuteriumCost";
            this.lblCrystalStorageDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalStorageDeuteriumCost.TabIndex = 11;
            this.lblCrystalStorageDeuteriumCost.Text = "deuter";
            this.lblCrystalStorageDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalStorageCrystalCost
            // 
            this.lblCrystalStorageCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalStorageCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalStorageCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalStorageCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrystalStorageCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblCrystalStorageCrystalCost.Name = "lblCrystalStorageCrystalCost";
            this.lblCrystalStorageCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalStorageCrystalCost.TabIndex = 10;
            this.lblCrystalStorageCrystalCost.Text = "kryształ";
            this.lblCrystalStorageCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalStorageMetalCost
            // 
            this.lblCrystalStorageMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalStorageMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalStorageMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalStorageMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrystalStorageMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblCrystalStorageMetalCost.Name = "lblCrystalStorageMetalCost";
            this.lblCrystalStorageMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalStorageMetalCost.TabIndex = 9;
            this.lblCrystalStorageMetalCost.Text = "metal";
            this.lblCrystalStorageMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalStorageLevel
            // 
            this.lblCrystalStorageLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalStorageLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalStorageLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalStorageLevel.Location = new System.Drawing.Point(320, 10);
            this.lblCrystalStorageLevel.Name = "lblCrystalStorageLevel";
            this.lblCrystalStorageLevel.Size = new System.Drawing.Size(50, 30);
            this.lblCrystalStorageLevel.TabIndex = 8;
            this.lblCrystalStorageLevel.Text = "level";
            this.lblCrystalStorageLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalStorage
            // 
            this.lblCrystalStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalStorage.Location = new System.Drawing.Point(10, 10);
            this.lblCrystalStorage.Name = "lblCrystalStorage";
            this.lblCrystalStorage.Size = new System.Drawing.Size(300, 30);
            this.lblCrystalStorage.TabIndex = 7;
            this.lblCrystalStorage.Text = "Magazyn kryształu";
            this.lblCrystalStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMetalStorage
            // 
            this.pMetalStorage.BackColor = System.Drawing.Color.Yellow;
            this.pMetalStorage.Controls.Add(this.lblMetalStorageTimeRemain);
            this.pMetalStorage.Controls.Add(this.lblMetalStorageNewStorage);
            this.pMetalStorage.Controls.Add(this.lblMetalStorageDuration);
            this.pMetalStorage.Controls.Add(this.btnMetalStorageUpgrade);
            this.pMetalStorage.Controls.Add(this.lblMetalStorageDeuteriumCost);
            this.pMetalStorage.Controls.Add(this.lblMetalStorageCrystalCost);
            this.pMetalStorage.Controls.Add(this.lblMetalStorageMetalCost);
            this.pMetalStorage.Controls.Add(this.lblMetalStorageLevel);
            this.pMetalStorage.Controls.Add(this.lblMetalStorage);
            this.pMetalStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMetalStorage.Location = new System.Drawing.Point(3, 253);
            this.pMetalStorage.Name = "pMetalStorage";
            this.pMetalStorage.Size = new System.Drawing.Size(1890, 50);
            this.pMetalStorage.TabIndex = 6;
            // 
            // lblMetalStorageTimeRemain
            // 
            this.lblMetalStorageTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalStorageTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalStorageTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMetalStorageTimeRemain.Location = new System.Drawing.Point(1360, 10);
            this.lblMetalStorageTimeRemain.Name = "lblMetalStorageTimeRemain";
            this.lblMetalStorageTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblMetalStorageTimeRemain.TabIndex = 21;
            this.lblMetalStorageTimeRemain.Text = "czas pozostały";
            this.lblMetalStorageTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalStorageNewStorage
            // 
            this.lblMetalStorageNewStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalStorageNewStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalStorageNewStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalStorageNewStorage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMetalStorageNewStorage.Location = new System.Drawing.Point(940, 10);
            this.lblMetalStorageNewStorage.Name = "lblMetalStorageNewStorage";
            this.lblMetalStorageNewStorage.Size = new System.Drawing.Size(130, 30);
            this.lblMetalStorageNewStorage.TabIndex = 14;
            this.lblMetalStorageNewStorage.Text = "nowa pojemność";
            this.lblMetalStorageNewStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalStorageDuration
            // 
            this.lblMetalStorageDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalStorageDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalStorageDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalStorageDuration.Location = new System.Drawing.Point(800, 10);
            this.lblMetalStorageDuration.Name = "lblMetalStorageDuration";
            this.lblMetalStorageDuration.Size = new System.Drawing.Size(130, 30);
            this.lblMetalStorageDuration.TabIndex = 13;
            this.lblMetalStorageDuration.Text = "czas";
            this.lblMetalStorageDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMetalStorageUpgrade
            // 
            this.btnMetalStorageUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnMetalStorageUpgrade.Enabled = false;
            this.btnMetalStorageUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMetalStorageUpgrade.Location = new System.Drawing.Point(1220, 10);
            this.btnMetalStorageUpgrade.Name = "btnMetalStorageUpgrade";
            this.btnMetalStorageUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnMetalStorageUpgrade.TabIndex = 12;
            this.btnMetalStorageUpgrade.Text = "Ulepsz";
            this.btnMetalStorageUpgrade.UseVisualStyleBackColor = false;
            this.btnMetalStorageUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblMetalStorageDeuteriumCost
            // 
            this.lblMetalStorageDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalStorageDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalStorageDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalStorageDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetalStorageDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblMetalStorageDeuteriumCost.Name = "lblMetalStorageDeuteriumCost";
            this.lblMetalStorageDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblMetalStorageDeuteriumCost.TabIndex = 11;
            this.lblMetalStorageDeuteriumCost.Text = "deuter";
            this.lblMetalStorageDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalStorageCrystalCost
            // 
            this.lblMetalStorageCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalStorageCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalStorageCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalStorageCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetalStorageCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblMetalStorageCrystalCost.Name = "lblMetalStorageCrystalCost";
            this.lblMetalStorageCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblMetalStorageCrystalCost.TabIndex = 10;
            this.lblMetalStorageCrystalCost.Text = "kryształ";
            this.lblMetalStorageCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalStorageMetalCost
            // 
            this.lblMetalStorageMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalStorageMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalStorageMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalStorageMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetalStorageMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblMetalStorageMetalCost.Name = "lblMetalStorageMetalCost";
            this.lblMetalStorageMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblMetalStorageMetalCost.TabIndex = 9;
            this.lblMetalStorageMetalCost.Text = "metal";
            this.lblMetalStorageMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalStorageLevel
            // 
            this.lblMetalStorageLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalStorageLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalStorageLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalStorageLevel.Location = new System.Drawing.Point(320, 10);
            this.lblMetalStorageLevel.Name = "lblMetalStorageLevel";
            this.lblMetalStorageLevel.Size = new System.Drawing.Size(50, 30);
            this.lblMetalStorageLevel.TabIndex = 8;
            this.lblMetalStorageLevel.Text = "level";
            this.lblMetalStorageLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalStorage
            // 
            this.lblMetalStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalStorage.Location = new System.Drawing.Point(10, 10);
            this.lblMetalStorage.Name = "lblMetalStorage";
            this.lblMetalStorage.Size = new System.Drawing.Size(300, 30);
            this.lblMetalStorage.TabIndex = 7;
            this.lblMetalStorage.Text = "Magazyn metalu";
            this.lblMetalStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pFusionReactor
            // 
            this.pFusionReactor.BackColor = System.Drawing.Color.Gold;
            this.pFusionReactor.Controls.Add(this.lblFusionReactorCollectTime);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorTotalDeuteriumCost);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorTimeRemain);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorProductionIncrease);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorDeuteriumDemand);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorDuration);
            this.pFusionReactor.Controls.Add(this.btnFusionReactorUpgrade);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorDeuteriumCost);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorCrystalCost);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorMetalCost);
            this.pFusionReactor.Controls.Add(this.lblFusionReactorLevel);
            this.pFusionReactor.Controls.Add(this.lblFusionReactor);
            this.pFusionReactor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFusionReactor.Location = new System.Drawing.Point(3, 203);
            this.pFusionReactor.Name = "pFusionReactor";
            this.pFusionReactor.Size = new System.Drawing.Size(1890, 50);
            this.pFusionReactor.TabIndex = 5;
            // 
            // lblFusionReactorTimeRemain
            // 
            this.lblFusionReactorTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFusionReactorTimeRemain.Location = new System.Drawing.Point(1360, 10);
            this.lblFusionReactorTimeRemain.Name = "lblFusionReactorTimeRemain";
            this.lblFusionReactorTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorTimeRemain.TabIndex = 20;
            this.lblFusionReactorTimeRemain.Text = "czas pozostały";
            this.lblFusionReactorTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactorProductionIncrease
            // 
            this.lblFusionReactorProductionIncrease.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorProductionIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorProductionIncrease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorProductionIncrease.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFusionReactorProductionIncrease.Location = new System.Drawing.Point(940, 10);
            this.lblFusionReactorProductionIncrease.Name = "lblFusionReactorProductionIncrease";
            this.lblFusionReactorProductionIncrease.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorProductionIncrease.TabIndex = 15;
            this.lblFusionReactorProductionIncrease.Text = "+energia";
            this.lblFusionReactorProductionIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactorDeuteriumDemand
            // 
            this.lblFusionReactorDeuteriumDemand.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorDeuteriumDemand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorDeuteriumDemand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorDeuteriumDemand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFusionReactorDeuteriumDemand.Location = new System.Drawing.Point(1080, 10);
            this.lblFusionReactorDeuteriumDemand.Name = "lblFusionReactorDeuteriumDemand";
            this.lblFusionReactorDeuteriumDemand.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorDeuteriumDemand.TabIndex = 14;
            this.lblFusionReactorDeuteriumDemand.Text = "-deuter";
            this.lblFusionReactorDeuteriumDemand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactorDuration
            // 
            this.lblFusionReactorDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorDuration.Location = new System.Drawing.Point(800, 10);
            this.lblFusionReactorDuration.Name = "lblFusionReactorDuration";
            this.lblFusionReactorDuration.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorDuration.TabIndex = 13;
            this.lblFusionReactorDuration.Text = "czas";
            this.lblFusionReactorDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFusionReactorUpgrade
            // 
            this.btnFusionReactorUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnFusionReactorUpgrade.Enabled = false;
            this.btnFusionReactorUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFusionReactorUpgrade.Location = new System.Drawing.Point(1220, 10);
            this.btnFusionReactorUpgrade.Name = "btnFusionReactorUpgrade";
            this.btnFusionReactorUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnFusionReactorUpgrade.TabIndex = 12;
            this.btnFusionReactorUpgrade.Text = "Ulepsz";
            this.btnFusionReactorUpgrade.UseVisualStyleBackColor = false;
            this.btnFusionReactorUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblFusionReactorDeuteriumCost
            // 
            this.lblFusionReactorDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFusionReactorDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblFusionReactorDeuteriumCost.Name = "lblFusionReactorDeuteriumCost";
            this.lblFusionReactorDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorDeuteriumCost.TabIndex = 11;
            this.lblFusionReactorDeuteriumCost.Text = "deuter";
            this.lblFusionReactorDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactorCrystalCost
            // 
            this.lblFusionReactorCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFusionReactorCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblFusionReactorCrystalCost.Name = "lblFusionReactorCrystalCost";
            this.lblFusionReactorCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorCrystalCost.TabIndex = 10;
            this.lblFusionReactorCrystalCost.Text = "kryształ";
            this.lblFusionReactorCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactorMetalCost
            // 
            this.lblFusionReactorMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFusionReactorMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblFusionReactorMetalCost.Name = "lblFusionReactorMetalCost";
            this.lblFusionReactorMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorMetalCost.TabIndex = 9;
            this.lblFusionReactorMetalCost.Text = "metal";
            this.lblFusionReactorMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactorLevel
            // 
            this.lblFusionReactorLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorLevel.Location = new System.Drawing.Point(320, 10);
            this.lblFusionReactorLevel.Name = "lblFusionReactorLevel";
            this.lblFusionReactorLevel.Size = new System.Drawing.Size(50, 30);
            this.lblFusionReactorLevel.TabIndex = 8;
            this.lblFusionReactorLevel.Text = "level";
            this.lblFusionReactorLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactor
            // 
            this.lblFusionReactor.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactor.Location = new System.Drawing.Point(10, 10);
            this.lblFusionReactor.Name = "lblFusionReactor";
            this.lblFusionReactor.Size = new System.Drawing.Size(300, 30);
            this.lblFusionReactor.TabIndex = 7;
            this.lblFusionReactor.Text = "Elektrownia fuzyjna";
            this.lblFusionReactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSolarPlant
            // 
            this.pSolarPlant.BackColor = System.Drawing.Color.Yellow;
            this.pSolarPlant.Controls.Add(this.lblSolarPlantTimeRemain);
            this.pSolarPlant.Controls.Add(this.lblSolarPlantProductionIncrease);
            this.pSolarPlant.Controls.Add(this.lblSolarPlantDuration);
            this.pSolarPlant.Controls.Add(this.btnSolarPlantUpgrade);
            this.pSolarPlant.Controls.Add(this.lblSolarPlantDeuteriumCost);
            this.pSolarPlant.Controls.Add(this.lblSolarPlantCrystalCost);
            this.pSolarPlant.Controls.Add(this.lblSolarPlantMetalCost);
            this.pSolarPlant.Controls.Add(this.lblSolarPlantLevel);
            this.pSolarPlant.Controls.Add(this.lblSolarPlant);
            this.pSolarPlant.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSolarPlant.Location = new System.Drawing.Point(3, 153);
            this.pSolarPlant.Name = "pSolarPlant";
            this.pSolarPlant.Size = new System.Drawing.Size(1890, 50);
            this.pSolarPlant.TabIndex = 4;
            // 
            // lblSolarPlantTimeRemain
            // 
            this.lblSolarPlantTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarPlantTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarPlantTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSolarPlantTimeRemain.Location = new System.Drawing.Point(1360, 10);
            this.lblSolarPlantTimeRemain.Name = "lblSolarPlantTimeRemain";
            this.lblSolarPlantTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblSolarPlantTimeRemain.TabIndex = 19;
            this.lblSolarPlantTimeRemain.Text = "czas pozostały";
            this.lblSolarPlantTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarPlantProductionIncrease
            // 
            this.lblSolarPlantProductionIncrease.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarPlantProductionIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarPlantProductionIncrease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarPlantProductionIncrease.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSolarPlantProductionIncrease.Location = new System.Drawing.Point(940, 10);
            this.lblSolarPlantProductionIncrease.Name = "lblSolarPlantProductionIncrease";
            this.lblSolarPlantProductionIncrease.Size = new System.Drawing.Size(130, 30);
            this.lblSolarPlantProductionIncrease.TabIndex = 15;
            this.lblSolarPlantProductionIncrease.Text = "+energia";
            this.lblSolarPlantProductionIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarPlantDuration
            // 
            this.lblSolarPlantDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarPlantDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarPlantDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarPlantDuration.Location = new System.Drawing.Point(800, 10);
            this.lblSolarPlantDuration.Name = "lblSolarPlantDuration";
            this.lblSolarPlantDuration.Size = new System.Drawing.Size(130, 30);
            this.lblSolarPlantDuration.TabIndex = 13;
            this.lblSolarPlantDuration.Text = "czas";
            this.lblSolarPlantDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSolarPlantUpgrade
            // 
            this.btnSolarPlantUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnSolarPlantUpgrade.Enabled = false;
            this.btnSolarPlantUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSolarPlantUpgrade.Location = new System.Drawing.Point(1220, 10);
            this.btnSolarPlantUpgrade.Name = "btnSolarPlantUpgrade";
            this.btnSolarPlantUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnSolarPlantUpgrade.TabIndex = 12;
            this.btnSolarPlantUpgrade.Text = "Ulepsz";
            this.btnSolarPlantUpgrade.UseVisualStyleBackColor = false;
            this.btnSolarPlantUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblSolarPlantDeuteriumCost
            // 
            this.lblSolarPlantDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarPlantDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarPlantDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarPlantDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSolarPlantDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblSolarPlantDeuteriumCost.Name = "lblSolarPlantDeuteriumCost";
            this.lblSolarPlantDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblSolarPlantDeuteriumCost.TabIndex = 11;
            this.lblSolarPlantDeuteriumCost.Text = "deuter";
            this.lblSolarPlantDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarPlantCrystalCost
            // 
            this.lblSolarPlantCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarPlantCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarPlantCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarPlantCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSolarPlantCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblSolarPlantCrystalCost.Name = "lblSolarPlantCrystalCost";
            this.lblSolarPlantCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSolarPlantCrystalCost.TabIndex = 10;
            this.lblSolarPlantCrystalCost.Text = "kryształ";
            this.lblSolarPlantCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarPlantMetalCost
            // 
            this.lblSolarPlantMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarPlantMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarPlantMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarPlantMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSolarPlantMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblSolarPlantMetalCost.Name = "lblSolarPlantMetalCost";
            this.lblSolarPlantMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSolarPlantMetalCost.TabIndex = 9;
            this.lblSolarPlantMetalCost.Text = "metal";
            this.lblSolarPlantMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarPlantLevel
            // 
            this.lblSolarPlantLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarPlantLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarPlantLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarPlantLevel.Location = new System.Drawing.Point(320, 10);
            this.lblSolarPlantLevel.Name = "lblSolarPlantLevel";
            this.lblSolarPlantLevel.Size = new System.Drawing.Size(50, 30);
            this.lblSolarPlantLevel.TabIndex = 8;
            this.lblSolarPlantLevel.Text = "level";
            this.lblSolarPlantLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarPlant
            // 
            this.lblSolarPlant.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarPlant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarPlant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarPlant.Location = new System.Drawing.Point(10, 10);
            this.lblSolarPlant.Name = "lblSolarPlant";
            this.lblSolarPlant.Size = new System.Drawing.Size(300, 30);
            this.lblSolarPlant.TabIndex = 7;
            this.lblSolarPlant.Text = "Elektrownia słoneczna";
            this.lblSolarPlant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pDeuteriumSynthesizer
            // 
            this.pDeuteriumSynthesizer.BackColor = System.Drawing.Color.Gold;
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSyntesizerCollectTime);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerTotalDeuteriumCost);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerTimeRemain);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerProductionIncrease);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerEnergyDemand);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerDuration);
            this.pDeuteriumSynthesizer.Controls.Add(this.btnDeuteriumSynthesizerUpgrade);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerDeuteriumCost);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerCrystalCost);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerMetalCost);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizerLevel);
            this.pDeuteriumSynthesizer.Controls.Add(this.lblDeuteriumSynthesizer);
            this.pDeuteriumSynthesizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDeuteriumSynthesizer.Location = new System.Drawing.Point(3, 103);
            this.pDeuteriumSynthesizer.Name = "pDeuteriumSynthesizer";
            this.pDeuteriumSynthesizer.Size = new System.Drawing.Size(1890, 50);
            this.pDeuteriumSynthesizer.TabIndex = 3;
            // 
            // lblDeuteriumSynthesizerTimeRemain
            // 
            this.lblDeuteriumSynthesizerTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeuteriumSynthesizerTimeRemain.Location = new System.Drawing.Point(1360, 10);
            this.lblDeuteriumSynthesizerTimeRemain.Name = "lblDeuteriumSynthesizerTimeRemain";
            this.lblDeuteriumSynthesizerTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSynthesizerTimeRemain.TabIndex = 18;
            this.lblDeuteriumSynthesizerTimeRemain.Text = "czas pozostały";
            this.lblDeuteriumSynthesizerTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSynthesizerProductionIncrease
            // 
            this.lblDeuteriumSynthesizerProductionIncrease.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerProductionIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizerProductionIncrease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerProductionIncrease.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeuteriumSynthesizerProductionIncrease.Location = new System.Drawing.Point(940, 10);
            this.lblDeuteriumSynthesizerProductionIncrease.Name = "lblDeuteriumSynthesizerProductionIncrease";
            this.lblDeuteriumSynthesizerProductionIncrease.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSynthesizerProductionIncrease.TabIndex = 15;
            this.lblDeuteriumSynthesizerProductionIncrease.Text = "+deuter";
            this.lblDeuteriumSynthesizerProductionIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSynthesizerEnergyDemand
            // 
            this.lblDeuteriumSynthesizerEnergyDemand.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerEnergyDemand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizerEnergyDemand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerEnergyDemand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeuteriumSynthesizerEnergyDemand.Location = new System.Drawing.Point(1080, 10);
            this.lblDeuteriumSynthesizerEnergyDemand.Name = "lblDeuteriumSynthesizerEnergyDemand";
            this.lblDeuteriumSynthesizerEnergyDemand.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSynthesizerEnergyDemand.TabIndex = 14;
            this.lblDeuteriumSynthesizerEnergyDemand.Text = "-energia";
            this.lblDeuteriumSynthesizerEnergyDemand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSynthesizerDuration
            // 
            this.lblDeuteriumSynthesizerDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizerDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerDuration.Location = new System.Drawing.Point(800, 10);
            this.lblDeuteriumSynthesizerDuration.Name = "lblDeuteriumSynthesizerDuration";
            this.lblDeuteriumSynthesizerDuration.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSynthesizerDuration.TabIndex = 13;
            this.lblDeuteriumSynthesizerDuration.Text = "czas";
            this.lblDeuteriumSynthesizerDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeuteriumSynthesizerUpgrade
            // 
            this.btnDeuteriumSynthesizerUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnDeuteriumSynthesizerUpgrade.Enabled = false;
            this.btnDeuteriumSynthesizerUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeuteriumSynthesizerUpgrade.Location = new System.Drawing.Point(1220, 10);
            this.btnDeuteriumSynthesizerUpgrade.Name = "btnDeuteriumSynthesizerUpgrade";
            this.btnDeuteriumSynthesizerUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnDeuteriumSynthesizerUpgrade.TabIndex = 12;
            this.btnDeuteriumSynthesizerUpgrade.Text = "Ulepsz";
            this.btnDeuteriumSynthesizerUpgrade.UseVisualStyleBackColor = false;
            this.btnDeuteriumSynthesizerUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblDeuteriumSynthesizerDeuteriumCost
            // 
            this.lblDeuteriumSynthesizerDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizerDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeuteriumSynthesizerDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblDeuteriumSynthesizerDeuteriumCost.Name = "lblDeuteriumSynthesizerDeuteriumCost";
            this.lblDeuteriumSynthesizerDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSynthesizerDeuteriumCost.TabIndex = 11;
            this.lblDeuteriumSynthesizerDeuteriumCost.Text = "deuter";
            this.lblDeuteriumSynthesizerDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSynthesizerCrystalCost
            // 
            this.lblDeuteriumSynthesizerCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizerCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeuteriumSynthesizerCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblDeuteriumSynthesizerCrystalCost.Name = "lblDeuteriumSynthesizerCrystalCost";
            this.lblDeuteriumSynthesizerCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSynthesizerCrystalCost.TabIndex = 10;
            this.lblDeuteriumSynthesizerCrystalCost.Text = "kryształ";
            this.lblDeuteriumSynthesizerCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSynthesizerMetalCost
            // 
            this.lblDeuteriumSynthesizerMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizerMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeuteriumSynthesizerMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblDeuteriumSynthesizerMetalCost.Name = "lblDeuteriumSynthesizerMetalCost";
            this.lblDeuteriumSynthesizerMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSynthesizerMetalCost.TabIndex = 9;
            this.lblDeuteriumSynthesizerMetalCost.Text = "metal";
            this.lblDeuteriumSynthesizerMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSynthesizerLevel
            // 
            this.lblDeuteriumSynthesizerLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizerLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerLevel.Location = new System.Drawing.Point(320, 10);
            this.lblDeuteriumSynthesizerLevel.Name = "lblDeuteriumSynthesizerLevel";
            this.lblDeuteriumSynthesizerLevel.Size = new System.Drawing.Size(50, 30);
            this.lblDeuteriumSynthesizerLevel.TabIndex = 8;
            this.lblDeuteriumSynthesizerLevel.Text = "level";
            this.lblDeuteriumSynthesizerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSynthesizer
            // 
            this.lblDeuteriumSynthesizer.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizer.Location = new System.Drawing.Point(10, 10);
            this.lblDeuteriumSynthesizer.Name = "lblDeuteriumSynthesizer";
            this.lblDeuteriumSynthesizer.Size = new System.Drawing.Size(300, 30);
            this.lblDeuteriumSynthesizer.TabIndex = 7;
            this.lblDeuteriumSynthesizer.Text = "Ekstraktor deuteru";
            this.lblDeuteriumSynthesizer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCrystalMine
            // 
            this.pCrystalMine.BackColor = System.Drawing.Color.Yellow;
            this.pCrystalMine.Controls.Add(this.lblCrystalMineCollectTime);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineTotalDeuteriumCost);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineTimeRemain);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineProductionIncrease);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineEnergyDemand);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineDuration);
            this.pCrystalMine.Controls.Add(this.btnCrystalMineUpgrade);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineDeuteriumCost);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineCrystalCost);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineMetalCost);
            this.pCrystalMine.Controls.Add(this.lblCrystalMineLevel);
            this.pCrystalMine.Controls.Add(this.lblCrystalMine);
            this.pCrystalMine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCrystalMine.Location = new System.Drawing.Point(3, 53);
            this.pCrystalMine.Name = "pCrystalMine";
            this.pCrystalMine.Size = new System.Drawing.Size(1890, 50);
            this.pCrystalMine.TabIndex = 2;
            // 
            // lblCrystalMineTimeRemain
            // 
            this.lblCrystalMineTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCrystalMineTimeRemain.Location = new System.Drawing.Point(1360, 10);
            this.lblCrystalMineTimeRemain.Name = "lblCrystalMineTimeRemain";
            this.lblCrystalMineTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineTimeRemain.TabIndex = 17;
            this.lblCrystalMineTimeRemain.Text = "czas pozostały";
            this.lblCrystalMineTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMineProductionIncrease
            // 
            this.lblCrystalMineProductionIncrease.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineProductionIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineProductionIncrease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineProductionIncrease.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCrystalMineProductionIncrease.Location = new System.Drawing.Point(940, 10);
            this.lblCrystalMineProductionIncrease.Name = "lblCrystalMineProductionIncrease";
            this.lblCrystalMineProductionIncrease.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineProductionIncrease.TabIndex = 15;
            this.lblCrystalMineProductionIncrease.Text = "+kryształ";
            this.lblCrystalMineProductionIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMineEnergyDemand
            // 
            this.lblCrystalMineEnergyDemand.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineEnergyDemand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineEnergyDemand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineEnergyDemand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCrystalMineEnergyDemand.Location = new System.Drawing.Point(1080, 10);
            this.lblCrystalMineEnergyDemand.Name = "lblCrystalMineEnergyDemand";
            this.lblCrystalMineEnergyDemand.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineEnergyDemand.TabIndex = 14;
            this.lblCrystalMineEnergyDemand.Text = "-energia";
            this.lblCrystalMineEnergyDemand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMineDuration
            // 
            this.lblCrystalMineDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineDuration.Location = new System.Drawing.Point(800, 10);
            this.lblCrystalMineDuration.Name = "lblCrystalMineDuration";
            this.lblCrystalMineDuration.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineDuration.TabIndex = 13;
            this.lblCrystalMineDuration.Text = "czas";
            this.lblCrystalMineDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrystalMineUpgrade
            // 
            this.btnCrystalMineUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnCrystalMineUpgrade.Enabled = false;
            this.btnCrystalMineUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrystalMineUpgrade.Location = new System.Drawing.Point(1220, 10);
            this.btnCrystalMineUpgrade.Name = "btnCrystalMineUpgrade";
            this.btnCrystalMineUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnCrystalMineUpgrade.TabIndex = 12;
            this.btnCrystalMineUpgrade.Text = "Ulepsz";
            this.btnCrystalMineUpgrade.UseVisualStyleBackColor = false;
            this.btnCrystalMineUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblCrystalMineDeuteriumCost
            // 
            this.lblCrystalMineDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrystalMineDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblCrystalMineDeuteriumCost.Name = "lblCrystalMineDeuteriumCost";
            this.lblCrystalMineDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineDeuteriumCost.TabIndex = 11;
            this.lblCrystalMineDeuteriumCost.Text = "deuter";
            this.lblCrystalMineDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMineCrystalCost
            // 
            this.lblCrystalMineCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrystalMineCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblCrystalMineCrystalCost.Name = "lblCrystalMineCrystalCost";
            this.lblCrystalMineCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineCrystalCost.TabIndex = 10;
            this.lblCrystalMineCrystalCost.Text = "kryształ";
            this.lblCrystalMineCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMineMetalCost
            // 
            this.lblCrystalMineMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrystalMineMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblCrystalMineMetalCost.Name = "lblCrystalMineMetalCost";
            this.lblCrystalMineMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineMetalCost.TabIndex = 9;
            this.lblCrystalMineMetalCost.Text = "metal";
            this.lblCrystalMineMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMineLevel
            // 
            this.lblCrystalMineLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineLevel.Location = new System.Drawing.Point(320, 10);
            this.lblCrystalMineLevel.Name = "lblCrystalMineLevel";
            this.lblCrystalMineLevel.Size = new System.Drawing.Size(50, 30);
            this.lblCrystalMineLevel.TabIndex = 8;
            this.lblCrystalMineLevel.Text = "level";
            this.lblCrystalMineLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMine
            // 
            this.lblCrystalMine.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMine.Location = new System.Drawing.Point(10, 10);
            this.lblCrystalMine.Name = "lblCrystalMine";
            this.lblCrystalMine.Size = new System.Drawing.Size(300, 30);
            this.lblCrystalMine.TabIndex = 7;
            this.lblCrystalMine.Text = "Kopalnia kryształu";
            this.lblCrystalMine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMetalMine
            // 
            this.pMetalMine.BackColor = System.Drawing.Color.Gold;
            this.pMetalMine.Controls.Add(this.lblMetalMineCollectTime);
            this.pMetalMine.Controls.Add(this.lblMetalMineTotalDeuteriumCost);
            this.pMetalMine.Controls.Add(this.lblMetalMineTimeRemain);
            this.pMetalMine.Controls.Add(this.lblMetalMineProductionIncrease);
            this.pMetalMine.Controls.Add(this.lblMetalMineEnergyDemand);
            this.pMetalMine.Controls.Add(this.lblMetalMineDuration);
            this.pMetalMine.Controls.Add(this.btnMetalMineUpgrade);
            this.pMetalMine.Controls.Add(this.lblMetalMineDeuteriumCost);
            this.pMetalMine.Controls.Add(this.lblMetalMineCrystalCost);
            this.pMetalMine.Controls.Add(this.lblMetalMineMetalCost);
            this.pMetalMine.Controls.Add(this.lblMetalMineLevel);
            this.pMetalMine.Controls.Add(this.lblMetalMine);
            this.pMetalMine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMetalMine.Location = new System.Drawing.Point(3, 3);
            this.pMetalMine.Name = "pMetalMine";
            this.pMetalMine.Size = new System.Drawing.Size(1890, 50);
            this.pMetalMine.TabIndex = 1;
            // 
            // lblMetalMineTimeRemain
            // 
            this.lblMetalMineTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMetalMineTimeRemain.Location = new System.Drawing.Point(1360, 10);
            this.lblMetalMineTimeRemain.Name = "lblMetalMineTimeRemain";
            this.lblMetalMineTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineTimeRemain.TabIndex = 16;
            this.lblMetalMineTimeRemain.Text = "czas pozostały";
            this.lblMetalMineTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMineProductionIncrease
            // 
            this.lblMetalMineProductionIncrease.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineProductionIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineProductionIncrease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineProductionIncrease.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMetalMineProductionIncrease.Location = new System.Drawing.Point(940, 10);
            this.lblMetalMineProductionIncrease.Name = "lblMetalMineProductionIncrease";
            this.lblMetalMineProductionIncrease.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineProductionIncrease.TabIndex = 15;
            this.lblMetalMineProductionIncrease.Text = "+metal";
            this.lblMetalMineProductionIncrease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMineEnergyDemand
            // 
            this.lblMetalMineEnergyDemand.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineEnergyDemand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineEnergyDemand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineEnergyDemand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMetalMineEnergyDemand.Location = new System.Drawing.Point(1080, 10);
            this.lblMetalMineEnergyDemand.Name = "lblMetalMineEnergyDemand";
            this.lblMetalMineEnergyDemand.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineEnergyDemand.TabIndex = 14;
            this.lblMetalMineEnergyDemand.Text = "-energia";
            this.lblMetalMineEnergyDemand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMineDuration
            // 
            this.lblMetalMineDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineDuration.Location = new System.Drawing.Point(800, 10);
            this.lblMetalMineDuration.Name = "lblMetalMineDuration";
            this.lblMetalMineDuration.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineDuration.TabIndex = 13;
            this.lblMetalMineDuration.Text = "czas";
            this.lblMetalMineDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMetalMineUpgrade
            // 
            this.btnMetalMineUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnMetalMineUpgrade.Enabled = false;
            this.btnMetalMineUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMetalMineUpgrade.Location = new System.Drawing.Point(1220, 10);
            this.btnMetalMineUpgrade.Name = "btnMetalMineUpgrade";
            this.btnMetalMineUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnMetalMineUpgrade.TabIndex = 12;
            this.btnMetalMineUpgrade.Text = "Ulepsz";
            this.btnMetalMineUpgrade.UseVisualStyleBackColor = false;
            this.btnMetalMineUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblMetalMineDeuteriumCost
            // 
            this.lblMetalMineDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetalMineDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblMetalMineDeuteriumCost.Name = "lblMetalMineDeuteriumCost";
            this.lblMetalMineDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineDeuteriumCost.TabIndex = 11;
            this.lblMetalMineDeuteriumCost.Text = "deuter";
            this.lblMetalMineDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMineCrystalCost
            // 
            this.lblMetalMineCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetalMineCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblMetalMineCrystalCost.Name = "lblMetalMineCrystalCost";
            this.lblMetalMineCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineCrystalCost.TabIndex = 10;
            this.lblMetalMineCrystalCost.Text = "kryształ";
            this.lblMetalMineCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMineMetalCost
            // 
            this.lblMetalMineMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMetalMineMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblMetalMineMetalCost.Name = "lblMetalMineMetalCost";
            this.lblMetalMineMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineMetalCost.TabIndex = 9;
            this.lblMetalMineMetalCost.Text = "metal";
            this.lblMetalMineMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMineLevel
            // 
            this.lblMetalMineLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineLevel.Location = new System.Drawing.Point(320, 10);
            this.lblMetalMineLevel.Name = "lblMetalMineLevel";
            this.lblMetalMineLevel.Size = new System.Drawing.Size(50, 30);
            this.lblMetalMineLevel.TabIndex = 8;
            this.lblMetalMineLevel.Text = "level";
            this.lblMetalMineLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMine
            // 
            this.lblMetalMine.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMine.Location = new System.Drawing.Point(10, 10);
            this.lblMetalMine.Name = "lblMetalMine";
            this.lblMetalMine.Size = new System.Drawing.Size(300, 30);
            this.lblMetalMine.TabIndex = 7;
            this.lblMetalMine.Text = "Kopalnia metalu";
            this.lblMetalMine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpProduction
            // 
            this.tpProduction.AutoScroll = true;
            this.tpProduction.BackColor = System.Drawing.Color.Silver;
            this.tpProduction.Controls.Add(this.pProductionGeneratedContent);
            this.tpProduction.Controls.Add(this.pTotalProduction);
            this.tpProduction.Controls.Add(this.pTotalProductionHeader);
            this.tpProduction.Location = new System.Drawing.Point(4, 29);
            this.tpProduction.Name = "tpProduction";
            this.tpProduction.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduction.Size = new System.Drawing.Size(1896, 800);
            this.tpProduction.TabIndex = 5;
            this.tpProduction.Text = "Wydobycie";
            // 
            // pProductionGeneratedContent
            // 
            this.pProductionGeneratedContent.AutoSize = true;
            this.pProductionGeneratedContent.BackColor = System.Drawing.Color.Silver;
            this.pProductionGeneratedContent.Location = new System.Drawing.Point(3, 108);
            this.pProductionGeneratedContent.Name = "pProductionGeneratedContent";
            this.pProductionGeneratedContent.Size = new System.Drawing.Size(1890, 689);
            this.pProductionGeneratedContent.TabIndex = 5;
            // 
            // pTotalProduction
            // 
            this.pTotalProduction.AutoSize = true;
            this.pTotalProduction.BackColor = System.Drawing.Color.Gold;
            this.pTotalProduction.Controls.Add(this.pTotalProductionDetails);
            this.pTotalProduction.Controls.Add(this.lblTotalProduction);
            this.pTotalProduction.Location = new System.Drawing.Point(3, 33);
            this.pTotalProduction.Name = "pTotalProduction";
            this.pTotalProduction.Size = new System.Drawing.Size(1890, 75);
            this.pTotalProduction.TabIndex = 3;
            // 
            // pTotalProductionDetails
            // 
            this.pTotalProductionDetails.Controls.Add(this.pTotalDeuteriumProductionDetails);
            this.pTotalProductionDetails.Controls.Add(this.pTotalCrystalProductionDetails);
            this.pTotalProductionDetails.Controls.Add(this.pTotalMetalProductionDetails);
            this.pTotalProductionDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.pTotalProductionDetails.Location = new System.Drawing.Point(160, 0);
            this.pTotalProductionDetails.Name = "pTotalProductionDetails";
            this.pTotalProductionDetails.Size = new System.Drawing.Size(1080, 75);
            this.pTotalProductionDetails.TabIndex = 12;
            // 
            // pTotalDeuteriumProductionDetails
            // 
            this.pTotalDeuteriumProductionDetails.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pTotalDeuteriumProductionDetails.Controls.Add(this.lblStorageDeuteriumMinTime);
            this.pTotalDeuteriumProductionDetails.Controls.Add(this.lblTotalDeuteriumProductionBasic);
            this.pTotalDeuteriumProductionDetails.Controls.Add(this.lblTotalDeuteriumProductionCrawlers);
            this.pTotalDeuteriumProductionDetails.Controls.Add(this.lblTotalDeuteriumProductionPlasma);
            this.pTotalDeuteriumProductionDetails.Controls.Add(this.lblTotalDeuteriumProductionMine);
            this.pTotalDeuteriumProductionDetails.Controls.Add(this.lblTotalDeuteriumProduction);
            this.pTotalDeuteriumProductionDetails.Controls.Add(this.lblTotalDeuteriumTankLevel);
            this.pTotalDeuteriumProductionDetails.Controls.Add(this.lblTotalDeuteriumSynthesizerLevel);
            this.pTotalDeuteriumProductionDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTotalDeuteriumProductionDetails.Location = new System.Drawing.Point(0, 50);
            this.pTotalDeuteriumProductionDetails.Name = "pTotalDeuteriumProductionDetails";
            this.pTotalDeuteriumProductionDetails.Size = new System.Drawing.Size(1080, 25);
            this.pTotalDeuteriumProductionDetails.TabIndex = 2;
            // 
            // lblStorageDeuteriumMinTime
            // 
            this.lblStorageDeuteriumMinTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStorageDeuteriumMinTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStorageDeuteriumMinTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageDeuteriumMinTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStorageDeuteriumMinTime.Location = new System.Drawing.Point(920, 0);
            this.lblStorageDeuteriumMinTime.Name = "lblStorageDeuteriumMinTime";
            this.lblStorageDeuteriumMinTime.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblStorageDeuteriumMinTime.Size = new System.Drawing.Size(160, 25);
            this.lblStorageDeuteriumMinTime.TabIndex = 17;
            this.lblStorageDeuteriumMinTime.Text = "0";
            this.lblStorageDeuteriumMinTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeuteriumProductionBasic
            // 
            this.lblTotalDeuteriumProductionBasic.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuteriumProductionBasic.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalDeuteriumProductionBasic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeuteriumProductionBasic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuteriumProductionBasic.Location = new System.Drawing.Point(760, 0);
            this.lblTotalDeuteriumProductionBasic.Name = "lblTotalDeuteriumProductionBasic";
            this.lblTotalDeuteriumProductionBasic.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalDeuteriumProductionBasic.Size = new System.Drawing.Size(160, 25);
            this.lblTotalDeuteriumProductionBasic.TabIndex = 15;
            this.lblTotalDeuteriumProductionBasic.Text = "0";
            this.lblTotalDeuteriumProductionBasic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeuteriumProductionCrawlers
            // 
            this.lblTotalDeuteriumProductionCrawlers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuteriumProductionCrawlers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalDeuteriumProductionCrawlers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeuteriumProductionCrawlers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuteriumProductionCrawlers.Location = new System.Drawing.Point(600, 0);
            this.lblTotalDeuteriumProductionCrawlers.Name = "lblTotalDeuteriumProductionCrawlers";
            this.lblTotalDeuteriumProductionCrawlers.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalDeuteriumProductionCrawlers.Size = new System.Drawing.Size(160, 25);
            this.lblTotalDeuteriumProductionCrawlers.TabIndex = 14;
            this.lblTotalDeuteriumProductionCrawlers.Text = "0";
            this.lblTotalDeuteriumProductionCrawlers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeuteriumProductionPlasma
            // 
            this.lblTotalDeuteriumProductionPlasma.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuteriumProductionPlasma.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalDeuteriumProductionPlasma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeuteriumProductionPlasma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuteriumProductionPlasma.Location = new System.Drawing.Point(440, 0);
            this.lblTotalDeuteriumProductionPlasma.Name = "lblTotalDeuteriumProductionPlasma";
            this.lblTotalDeuteriumProductionPlasma.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalDeuteriumProductionPlasma.Size = new System.Drawing.Size(160, 25);
            this.lblTotalDeuteriumProductionPlasma.TabIndex = 13;
            this.lblTotalDeuteriumProductionPlasma.Text = "0";
            this.lblTotalDeuteriumProductionPlasma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeuteriumProductionMine
            // 
            this.lblTotalDeuteriumProductionMine.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuteriumProductionMine.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalDeuteriumProductionMine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeuteriumProductionMine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuteriumProductionMine.Location = new System.Drawing.Point(280, 0);
            this.lblTotalDeuteriumProductionMine.Name = "lblTotalDeuteriumProductionMine";
            this.lblTotalDeuteriumProductionMine.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalDeuteriumProductionMine.Size = new System.Drawing.Size(160, 25);
            this.lblTotalDeuteriumProductionMine.TabIndex = 12;
            this.lblTotalDeuteriumProductionMine.Text = "0";
            this.lblTotalDeuteriumProductionMine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeuteriumProduction
            // 
            this.lblTotalDeuteriumProduction.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuteriumProduction.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalDeuteriumProduction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeuteriumProduction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuteriumProduction.Location = new System.Drawing.Point(120, 0);
            this.lblTotalDeuteriumProduction.Name = "lblTotalDeuteriumProduction";
            this.lblTotalDeuteriumProduction.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalDeuteriumProduction.Size = new System.Drawing.Size(160, 25);
            this.lblTotalDeuteriumProduction.TabIndex = 11;
            this.lblTotalDeuteriumProduction.Text = "0";
            this.lblTotalDeuteriumProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeuteriumTankLevel
            // 
            this.lblTotalDeuteriumTankLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuteriumTankLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalDeuteriumTankLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeuteriumTankLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuteriumTankLevel.Location = new System.Drawing.Point(60, 0);
            this.lblTotalDeuteriumTankLevel.Name = "lblTotalDeuteriumTankLevel";
            this.lblTotalDeuteriumTankLevel.Size = new System.Drawing.Size(60, 25);
            this.lblTotalDeuteriumTankLevel.TabIndex = 18;
            this.lblTotalDeuteriumTankLevel.Text = "0";
            this.lblTotalDeuteriumTankLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDeuteriumSynthesizerLevel
            // 
            this.lblTotalDeuteriumSynthesizerLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDeuteriumSynthesizerLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalDeuteriumSynthesizerLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeuteriumSynthesizerLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalDeuteriumSynthesizerLevel.Location = new System.Drawing.Point(0, 0);
            this.lblTotalDeuteriumSynthesizerLevel.Name = "lblTotalDeuteriumSynthesizerLevel";
            this.lblTotalDeuteriumSynthesizerLevel.Size = new System.Drawing.Size(60, 25);
            this.lblTotalDeuteriumSynthesizerLevel.TabIndex = 16;
            this.lblTotalDeuteriumSynthesizerLevel.Text = "0";
            this.lblTotalDeuteriumSynthesizerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTotalCrystalProductionDetails
            // 
            this.pTotalCrystalProductionDetails.BackColor = System.Drawing.Color.Coral;
            this.pTotalCrystalProductionDetails.Controls.Add(this.lblStorageCrystalMinTime);
            this.pTotalCrystalProductionDetails.Controls.Add(this.lblTotalCrystalProductionBasic);
            this.pTotalCrystalProductionDetails.Controls.Add(this.lblTotalCrystalProductionCrawlers);
            this.pTotalCrystalProductionDetails.Controls.Add(this.lblTotalCrystalProductionPlasma);
            this.pTotalCrystalProductionDetails.Controls.Add(this.lblTotalCrystalProductionMine);
            this.pTotalCrystalProductionDetails.Controls.Add(this.lblTotalCrystalProduction);
            this.pTotalCrystalProductionDetails.Controls.Add(this.lblTotalCrystalStorageLevel);
            this.pTotalCrystalProductionDetails.Controls.Add(this.lblTotalCrystalMineLevel);
            this.pTotalCrystalProductionDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTotalCrystalProductionDetails.Location = new System.Drawing.Point(0, 25);
            this.pTotalCrystalProductionDetails.Name = "pTotalCrystalProductionDetails";
            this.pTotalCrystalProductionDetails.Size = new System.Drawing.Size(1080, 25);
            this.pTotalCrystalProductionDetails.TabIndex = 1;
            // 
            // lblStorageCrystalMinTime
            // 
            this.lblStorageCrystalMinTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStorageCrystalMinTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStorageCrystalMinTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageCrystalMinTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStorageCrystalMinTime.Location = new System.Drawing.Point(920, 0);
            this.lblStorageCrystalMinTime.Name = "lblStorageCrystalMinTime";
            this.lblStorageCrystalMinTime.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblStorageCrystalMinTime.Size = new System.Drawing.Size(160, 25);
            this.lblStorageCrystalMinTime.TabIndex = 16;
            this.lblStorageCrystalMinTime.Text = "0";
            this.lblStorageCrystalMinTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCrystalProductionBasic
            // 
            this.lblTotalCrystalProductionBasic.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCrystalProductionBasic.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCrystalProductionBasic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCrystalProductionBasic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCrystalProductionBasic.Location = new System.Drawing.Point(760, 0);
            this.lblTotalCrystalProductionBasic.Name = "lblTotalCrystalProductionBasic";
            this.lblTotalCrystalProductionBasic.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalCrystalProductionBasic.Size = new System.Drawing.Size(160, 25);
            this.lblTotalCrystalProductionBasic.TabIndex = 14;
            this.lblTotalCrystalProductionBasic.Text = "0";
            this.lblTotalCrystalProductionBasic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCrystalProductionCrawlers
            // 
            this.lblTotalCrystalProductionCrawlers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCrystalProductionCrawlers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCrystalProductionCrawlers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCrystalProductionCrawlers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCrystalProductionCrawlers.Location = new System.Drawing.Point(600, 0);
            this.lblTotalCrystalProductionCrawlers.Name = "lblTotalCrystalProductionCrawlers";
            this.lblTotalCrystalProductionCrawlers.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalCrystalProductionCrawlers.Size = new System.Drawing.Size(160, 25);
            this.lblTotalCrystalProductionCrawlers.TabIndex = 13;
            this.lblTotalCrystalProductionCrawlers.Text = "0";
            this.lblTotalCrystalProductionCrawlers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCrystalProductionPlasma
            // 
            this.lblTotalCrystalProductionPlasma.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCrystalProductionPlasma.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCrystalProductionPlasma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCrystalProductionPlasma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCrystalProductionPlasma.Location = new System.Drawing.Point(440, 0);
            this.lblTotalCrystalProductionPlasma.Name = "lblTotalCrystalProductionPlasma";
            this.lblTotalCrystalProductionPlasma.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalCrystalProductionPlasma.Size = new System.Drawing.Size(160, 25);
            this.lblTotalCrystalProductionPlasma.TabIndex = 12;
            this.lblTotalCrystalProductionPlasma.Text = "0";
            this.lblTotalCrystalProductionPlasma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCrystalProductionMine
            // 
            this.lblTotalCrystalProductionMine.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCrystalProductionMine.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCrystalProductionMine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCrystalProductionMine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCrystalProductionMine.Location = new System.Drawing.Point(280, 0);
            this.lblTotalCrystalProductionMine.Name = "lblTotalCrystalProductionMine";
            this.lblTotalCrystalProductionMine.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalCrystalProductionMine.Size = new System.Drawing.Size(160, 25);
            this.lblTotalCrystalProductionMine.TabIndex = 11;
            this.lblTotalCrystalProductionMine.Text = "0";
            this.lblTotalCrystalProductionMine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCrystalProduction
            // 
            this.lblTotalCrystalProduction.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCrystalProduction.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCrystalProduction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCrystalProduction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCrystalProduction.Location = new System.Drawing.Point(120, 0);
            this.lblTotalCrystalProduction.Name = "lblTotalCrystalProduction";
            this.lblTotalCrystalProduction.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalCrystalProduction.Size = new System.Drawing.Size(160, 25);
            this.lblTotalCrystalProduction.TabIndex = 10;
            this.lblTotalCrystalProduction.Text = "0";
            this.lblTotalCrystalProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCrystalStorageLevel
            // 
            this.lblTotalCrystalStorageLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCrystalStorageLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCrystalStorageLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCrystalStorageLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCrystalStorageLevel.Location = new System.Drawing.Point(60, 0);
            this.lblTotalCrystalStorageLevel.Name = "lblTotalCrystalStorageLevel";
            this.lblTotalCrystalStorageLevel.Size = new System.Drawing.Size(60, 25);
            this.lblTotalCrystalStorageLevel.TabIndex = 17;
            this.lblTotalCrystalStorageLevel.Text = "0";
            this.lblTotalCrystalStorageLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCrystalMineLevel
            // 
            this.lblTotalCrystalMineLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCrystalMineLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalCrystalMineLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCrystalMineLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCrystalMineLevel.Location = new System.Drawing.Point(0, 0);
            this.lblTotalCrystalMineLevel.Name = "lblTotalCrystalMineLevel";
            this.lblTotalCrystalMineLevel.Size = new System.Drawing.Size(60, 25);
            this.lblTotalCrystalMineLevel.TabIndex = 15;
            this.lblTotalCrystalMineLevel.Text = "0";
            this.lblTotalCrystalMineLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTotalMetalProductionDetails
            // 
            this.pTotalMetalProductionDetails.BackColor = System.Drawing.Color.Silver;
            this.pTotalMetalProductionDetails.Controls.Add(this.lblStorageMetalMinTime);
            this.pTotalMetalProductionDetails.Controls.Add(this.lblTotalMetalProductionBasic);
            this.pTotalMetalProductionDetails.Controls.Add(this.lblTotalMetalProductionCrawlers);
            this.pTotalMetalProductionDetails.Controls.Add(this.lblTotalMetalProductionPlasma);
            this.pTotalMetalProductionDetails.Controls.Add(this.lblTotalMetalProductionMine);
            this.pTotalMetalProductionDetails.Controls.Add(this.lblTotalMetalProduction);
            this.pTotalMetalProductionDetails.Controls.Add(this.lblTotalMetalStorageLevel);
            this.pTotalMetalProductionDetails.Controls.Add(this.lblTotalMetalMineLevel);
            this.pTotalMetalProductionDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTotalMetalProductionDetails.Location = new System.Drawing.Point(0, 0);
            this.pTotalMetalProductionDetails.Name = "pTotalMetalProductionDetails";
            this.pTotalMetalProductionDetails.Size = new System.Drawing.Size(1080, 25);
            this.pTotalMetalProductionDetails.TabIndex = 0;
            // 
            // lblStorageMetalMinTime
            // 
            this.lblStorageMetalMinTime.BackColor = System.Drawing.Color.Transparent;
            this.lblStorageMetalMinTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStorageMetalMinTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageMetalMinTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStorageMetalMinTime.Location = new System.Drawing.Point(920, 0);
            this.lblStorageMetalMinTime.Name = "lblStorageMetalMinTime";
            this.lblStorageMetalMinTime.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblStorageMetalMinTime.Size = new System.Drawing.Size(160, 25);
            this.lblStorageMetalMinTime.TabIndex = 15;
            this.lblStorageMetalMinTime.Text = "0";
            this.lblStorageMetalMinTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMetalProductionBasic
            // 
            this.lblTotalMetalProductionBasic.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMetalProductionBasic.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMetalProductionBasic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMetalProductionBasic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalMetalProductionBasic.Location = new System.Drawing.Point(760, 0);
            this.lblTotalMetalProductionBasic.Name = "lblTotalMetalProductionBasic";
            this.lblTotalMetalProductionBasic.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalMetalProductionBasic.Size = new System.Drawing.Size(160, 25);
            this.lblTotalMetalProductionBasic.TabIndex = 13;
            this.lblTotalMetalProductionBasic.Text = "0";
            this.lblTotalMetalProductionBasic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMetalProductionCrawlers
            // 
            this.lblTotalMetalProductionCrawlers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMetalProductionCrawlers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMetalProductionCrawlers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMetalProductionCrawlers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalMetalProductionCrawlers.Location = new System.Drawing.Point(600, 0);
            this.lblTotalMetalProductionCrawlers.Name = "lblTotalMetalProductionCrawlers";
            this.lblTotalMetalProductionCrawlers.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalMetalProductionCrawlers.Size = new System.Drawing.Size(160, 25);
            this.lblTotalMetalProductionCrawlers.TabIndex = 12;
            this.lblTotalMetalProductionCrawlers.Text = "0";
            this.lblTotalMetalProductionCrawlers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMetalProductionPlasma
            // 
            this.lblTotalMetalProductionPlasma.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMetalProductionPlasma.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMetalProductionPlasma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMetalProductionPlasma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalMetalProductionPlasma.Location = new System.Drawing.Point(440, 0);
            this.lblTotalMetalProductionPlasma.Name = "lblTotalMetalProductionPlasma";
            this.lblTotalMetalProductionPlasma.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalMetalProductionPlasma.Size = new System.Drawing.Size(160, 25);
            this.lblTotalMetalProductionPlasma.TabIndex = 11;
            this.lblTotalMetalProductionPlasma.Text = "0";
            this.lblTotalMetalProductionPlasma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMetalProductionMine
            // 
            this.lblTotalMetalProductionMine.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMetalProductionMine.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMetalProductionMine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMetalProductionMine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalMetalProductionMine.Location = new System.Drawing.Point(280, 0);
            this.lblTotalMetalProductionMine.Name = "lblTotalMetalProductionMine";
            this.lblTotalMetalProductionMine.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalMetalProductionMine.Size = new System.Drawing.Size(160, 25);
            this.lblTotalMetalProductionMine.TabIndex = 10;
            this.lblTotalMetalProductionMine.Text = "0";
            this.lblTotalMetalProductionMine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMetalProduction
            // 
            this.lblTotalMetalProduction.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMetalProduction.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMetalProduction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMetalProduction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalMetalProduction.Location = new System.Drawing.Point(120, 0);
            this.lblTotalMetalProduction.Name = "lblTotalMetalProduction";
            this.lblTotalMetalProduction.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblTotalMetalProduction.Size = new System.Drawing.Size(160, 25);
            this.lblTotalMetalProduction.TabIndex = 9;
            this.lblTotalMetalProduction.Text = "0";
            this.lblTotalMetalProduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMetalStorageLevel
            // 
            this.lblTotalMetalStorageLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMetalStorageLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMetalStorageLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMetalStorageLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalMetalStorageLevel.Location = new System.Drawing.Point(60, 0);
            this.lblTotalMetalStorageLevel.Name = "lblTotalMetalStorageLevel";
            this.lblTotalMetalStorageLevel.Size = new System.Drawing.Size(60, 25);
            this.lblTotalMetalStorageLevel.TabIndex = 16;
            this.lblTotalMetalStorageLevel.Text = "0";
            this.lblTotalMetalStorageLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMetalMineLevel
            // 
            this.lblTotalMetalMineLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMetalMineLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalMetalMineLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMetalMineLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalMetalMineLevel.Location = new System.Drawing.Point(0, 0);
            this.lblTotalMetalMineLevel.Name = "lblTotalMetalMineLevel";
            this.lblTotalMetalMineLevel.Size = new System.Drawing.Size(60, 25);
            this.lblTotalMetalMineLevel.TabIndex = 14;
            this.lblTotalMetalMineLevel.Text = "0";
            this.lblTotalMetalMineLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProduction
            // 
            this.lblTotalProduction.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalProduction.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalProduction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalProduction.Location = new System.Drawing.Point(0, 0);
            this.lblTotalProduction.Name = "lblTotalProduction";
            this.lblTotalProduction.Size = new System.Drawing.Size(160, 75);
            this.lblTotalProduction.TabIndex = 7;
            this.lblTotalProduction.Text = "Razem";
            this.lblTotalProduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTotalProductionHeader
            // 
            this.pTotalProductionHeader.AutoSize = true;
            this.pTotalProductionHeader.BackColor = System.Drawing.Color.Yellow;
            this.pTotalProductionHeader.Controls.Add(this.lblTimeToFillStorage);
            this.pTotalProductionHeader.Controls.Add(this.lblProductionBasic);
            this.pTotalProductionHeader.Controls.Add(this.lblProductionCrawlers);
            this.pTotalProductionHeader.Controls.Add(this.lblProductionPlasma);
            this.pTotalProductionHeader.Controls.Add(this.lblProductionMine);
            this.pTotalProductionHeader.Controls.Add(this.lblProductionTotal);
            this.pTotalProductionHeader.Controls.Add(this.lblProductionStorage);
            this.pTotalProductionHeader.Controls.Add(this.lblProductionLevel);
            this.pTotalProductionHeader.Controls.Add(this.lblProductionPlanet);
            this.pTotalProductionHeader.Location = new System.Drawing.Point(3, 3);
            this.pTotalProductionHeader.Name = "pTotalProductionHeader";
            this.pTotalProductionHeader.Size = new System.Drawing.Size(1890, 30);
            this.pTotalProductionHeader.TabIndex = 4;
            // 
            // lblTimeToFillStorage
            // 
            this.lblTimeToFillStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeToFillStorage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimeToFillStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeToFillStorage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeToFillStorage.Location = new System.Drawing.Point(1080, 0);
            this.lblTimeToFillStorage.Name = "lblTimeToFillStorage";
            this.lblTimeToFillStorage.Size = new System.Drawing.Size(160, 30);
            this.lblTimeToFillStorage.TabIndex = 17;
            this.lblTimeToFillStorage.Text = "Wypełnienie magazynu";
            this.lblTimeToFillStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionBasic
            // 
            this.lblProductionBasic.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionBasic.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductionBasic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionBasic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductionBasic.Location = new System.Drawing.Point(920, 0);
            this.lblProductionBasic.Name = "lblProductionBasic";
            this.lblProductionBasic.Size = new System.Drawing.Size(160, 30);
            this.lblProductionBasic.TabIndex = 15;
            this.lblProductionBasic.Text = "Wydobycie podstawowe";
            this.lblProductionBasic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionCrawlers
            // 
            this.lblProductionCrawlers.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionCrawlers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductionCrawlers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionCrawlers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductionCrawlers.Location = new System.Drawing.Point(760, 0);
            this.lblProductionCrawlers.Name = "lblProductionCrawlers";
            this.lblProductionCrawlers.Size = new System.Drawing.Size(160, 30);
            this.lblProductionCrawlers.TabIndex = 14;
            this.lblProductionCrawlers.Text = "Pełzacze";
            this.lblProductionCrawlers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionPlasma
            // 
            this.lblProductionPlasma.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionPlasma.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductionPlasma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionPlasma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductionPlasma.Location = new System.Drawing.Point(600, 0);
            this.lblProductionPlasma.Name = "lblProductionPlasma";
            this.lblProductionPlasma.Size = new System.Drawing.Size(160, 30);
            this.lblProductionPlasma.TabIndex = 13;
            this.lblProductionPlasma.Text = "Technologia plazmowa";
            this.lblProductionPlasma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionMine
            // 
            this.lblProductionMine.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionMine.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductionMine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionMine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductionMine.Location = new System.Drawing.Point(440, 0);
            this.lblProductionMine.Name = "lblProductionMine";
            this.lblProductionMine.Size = new System.Drawing.Size(160, 30);
            this.lblProductionMine.TabIndex = 12;
            this.lblProductionMine.Text = "Kopalnia";
            this.lblProductionMine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionTotal
            // 
            this.lblProductionTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductionTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductionTotal.Location = new System.Drawing.Point(280, 0);
            this.lblProductionTotal.Name = "lblProductionTotal";
            this.lblProductionTotal.Size = new System.Drawing.Size(160, 30);
            this.lblProductionTotal.TabIndex = 11;
            this.lblProductionTotal.Text = "Razem";
            this.lblProductionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionStorage
            // 
            this.lblProductionStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionStorage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductionStorage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionStorage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductionStorage.Location = new System.Drawing.Point(220, 0);
            this.lblProductionStorage.Name = "lblProductionStorage";
            this.lblProductionStorage.Size = new System.Drawing.Size(60, 30);
            this.lblProductionStorage.TabIndex = 18;
            this.lblProductionStorage.Text = "Magazyn";
            this.lblProductionStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionLevel
            // 
            this.lblProductionLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductionLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductionLevel.Location = new System.Drawing.Point(160, 0);
            this.lblProductionLevel.Name = "lblProductionLevel";
            this.lblProductionLevel.Size = new System.Drawing.Size(60, 30);
            this.lblProductionLevel.TabIndex = 16;
            this.lblProductionLevel.Text = "Poziom";
            this.lblProductionLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionPlanet
            // 
            this.lblProductionPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionPlanet.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProductionPlanet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductionPlanet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductionPlanet.Location = new System.Drawing.Point(0, 0);
            this.lblProductionPlanet.Name = "lblProductionPlanet";
            this.lblProductionPlanet.Size = new System.Drawing.Size(160, 30);
            this.lblProductionPlanet.TabIndex = 10;
            this.lblProductionPlanet.Text = "Planeta";
            this.lblProductionPlanet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpStation
            // 
            this.tpStation.BackColor = System.Drawing.Color.Silver;
            this.tpStation.Controls.Add(this.pJumpGate);
            this.tpStation.Controls.Add(this.pSensorPhalanx);
            this.tpStation.Controls.Add(this.pLunarBase);
            this.tpStation.Controls.Add(this.pSpaceDock);
            this.tpStation.Controls.Add(this.pTerraformer);
            this.tpStation.Controls.Add(this.pMissileSilo);
            this.tpStation.Controls.Add(this.pResearchLab);
            this.tpStation.Controls.Add(this.pShipyard);
            this.tpStation.Controls.Add(this.pNaniteFactory);
            this.tpStation.Controls.Add(this.pRoboticsFactory);
            this.tpStation.Location = new System.Drawing.Point(4, 29);
            this.tpStation.Name = "tpStation";
            this.tpStation.Padding = new System.Windows.Forms.Padding(3);
            this.tpStation.Size = new System.Drawing.Size(1896, 800);
            this.tpStation.TabIndex = 1;
            this.tpStation.Text = "Stacja";
            // 
            // pJumpGate
            // 
            this.pJumpGate.BackColor = System.Drawing.Color.Yellow;
            this.pJumpGate.Controls.Add(this.lblJumpGateTimeRemain);
            this.pJumpGate.Controls.Add(this.lblJumpGateDuration);
            this.pJumpGate.Controls.Add(this.btnJumpGateUpgrade);
            this.pJumpGate.Controls.Add(this.lblJumpGateDeuteriumCost);
            this.pJumpGate.Controls.Add(this.lblJumpGateCrystalCost);
            this.pJumpGate.Controls.Add(this.lblJumpGateMetalCost);
            this.pJumpGate.Controls.Add(this.lblJumpGateLevel);
            this.pJumpGate.Controls.Add(this.lblJumpGate);
            this.pJumpGate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pJumpGate.Location = new System.Drawing.Point(3, 453);
            this.pJumpGate.Name = "pJumpGate";
            this.pJumpGate.Size = new System.Drawing.Size(1890, 50);
            this.pJumpGate.TabIndex = 11;
            // 
            // lblJumpGateTimeRemain
            // 
            this.lblJumpGateTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblJumpGateTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJumpGateTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJumpGateTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblJumpGateTimeRemain.Name = "lblJumpGateTimeRemain";
            this.lblJumpGateTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblJumpGateTimeRemain.TabIndex = 26;
            this.lblJumpGateTimeRemain.Text = "czas pozostały";
            this.lblJumpGateTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJumpGateDuration
            // 
            this.lblJumpGateDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblJumpGateDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumpGateDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJumpGateDuration.Location = new System.Drawing.Point(800, 10);
            this.lblJumpGateDuration.Name = "lblJumpGateDuration";
            this.lblJumpGateDuration.Size = new System.Drawing.Size(130, 30);
            this.lblJumpGateDuration.TabIndex = 13;
            this.lblJumpGateDuration.Text = "czas";
            this.lblJumpGateDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJumpGateUpgrade
            // 
            this.btnJumpGateUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnJumpGateUpgrade.Enabled = false;
            this.btnJumpGateUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJumpGateUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnJumpGateUpgrade.Name = "btnJumpGateUpgrade";
            this.btnJumpGateUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnJumpGateUpgrade.TabIndex = 12;
            this.btnJumpGateUpgrade.Text = "Ulepsz";
            this.btnJumpGateUpgrade.UseVisualStyleBackColor = false;
            this.btnJumpGateUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblJumpGateDeuteriumCost
            // 
            this.lblJumpGateDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblJumpGateDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumpGateDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJumpGateDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJumpGateDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblJumpGateDeuteriumCost.Name = "lblJumpGateDeuteriumCost";
            this.lblJumpGateDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblJumpGateDeuteriumCost.TabIndex = 11;
            this.lblJumpGateDeuteriumCost.Text = "deuter";
            this.lblJumpGateDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJumpGateCrystalCost
            // 
            this.lblJumpGateCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblJumpGateCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumpGateCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJumpGateCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJumpGateCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblJumpGateCrystalCost.Name = "lblJumpGateCrystalCost";
            this.lblJumpGateCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblJumpGateCrystalCost.TabIndex = 10;
            this.lblJumpGateCrystalCost.Text = "kryształ";
            this.lblJumpGateCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJumpGateMetalCost
            // 
            this.lblJumpGateMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblJumpGateMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumpGateMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJumpGateMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblJumpGateMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblJumpGateMetalCost.Name = "lblJumpGateMetalCost";
            this.lblJumpGateMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblJumpGateMetalCost.TabIndex = 9;
            this.lblJumpGateMetalCost.Text = "metal";
            this.lblJumpGateMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJumpGateLevel
            // 
            this.lblJumpGateLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblJumpGateLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumpGateLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJumpGateLevel.Location = new System.Drawing.Point(320, 10);
            this.lblJumpGateLevel.Name = "lblJumpGateLevel";
            this.lblJumpGateLevel.Size = new System.Drawing.Size(50, 30);
            this.lblJumpGateLevel.TabIndex = 8;
            this.lblJumpGateLevel.Text = "level";
            this.lblJumpGateLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJumpGate
            // 
            this.lblJumpGate.BackColor = System.Drawing.Color.Transparent;
            this.lblJumpGate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJumpGate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJumpGate.Location = new System.Drawing.Point(10, 10);
            this.lblJumpGate.Name = "lblJumpGate";
            this.lblJumpGate.Size = new System.Drawing.Size(300, 30);
            this.lblJumpGate.TabIndex = 7;
            this.lblJumpGate.Text = "Teleporter";
            this.lblJumpGate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSensorPhalanx
            // 
            this.pSensorPhalanx.BackColor = System.Drawing.Color.Gold;
            this.pSensorPhalanx.Controls.Add(this.lblSensorPhalanxTimeRemain);
            this.pSensorPhalanx.Controls.Add(this.lblSensorPhalanxDuration);
            this.pSensorPhalanx.Controls.Add(this.btnSensorPhalanxUpgrade);
            this.pSensorPhalanx.Controls.Add(this.lblSensorPhalanxDeuteriumCost);
            this.pSensorPhalanx.Controls.Add(this.lblSensorPhalanxCrystalCost);
            this.pSensorPhalanx.Controls.Add(this.lblSensorPhalanxMetalCost);
            this.pSensorPhalanx.Controls.Add(this.lblSensorPhalanxLevel);
            this.pSensorPhalanx.Controls.Add(this.lblSensorPhalanx);
            this.pSensorPhalanx.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSensorPhalanx.Location = new System.Drawing.Point(3, 403);
            this.pSensorPhalanx.Name = "pSensorPhalanx";
            this.pSensorPhalanx.Size = new System.Drawing.Size(1890, 50);
            this.pSensorPhalanx.TabIndex = 10;
            // 
            // lblSensorPhalanxTimeRemain
            // 
            this.lblSensorPhalanxTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblSensorPhalanxTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSensorPhalanxTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSensorPhalanxTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblSensorPhalanxTimeRemain.Name = "lblSensorPhalanxTimeRemain";
            this.lblSensorPhalanxTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblSensorPhalanxTimeRemain.TabIndex = 25;
            this.lblSensorPhalanxTimeRemain.Text = "czas pozostały";
            this.lblSensorPhalanxTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSensorPhalanxDuration
            // 
            this.lblSensorPhalanxDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblSensorPhalanxDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSensorPhalanxDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSensorPhalanxDuration.Location = new System.Drawing.Point(800, 10);
            this.lblSensorPhalanxDuration.Name = "lblSensorPhalanxDuration";
            this.lblSensorPhalanxDuration.Size = new System.Drawing.Size(130, 30);
            this.lblSensorPhalanxDuration.TabIndex = 13;
            this.lblSensorPhalanxDuration.Text = "czas";
            this.lblSensorPhalanxDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSensorPhalanxUpgrade
            // 
            this.btnSensorPhalanxUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnSensorPhalanxUpgrade.Enabled = false;
            this.btnSensorPhalanxUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSensorPhalanxUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnSensorPhalanxUpgrade.Name = "btnSensorPhalanxUpgrade";
            this.btnSensorPhalanxUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnSensorPhalanxUpgrade.TabIndex = 12;
            this.btnSensorPhalanxUpgrade.Text = "Ulepsz";
            this.btnSensorPhalanxUpgrade.UseVisualStyleBackColor = false;
            this.btnSensorPhalanxUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblSensorPhalanxDeuteriumCost
            // 
            this.lblSensorPhalanxDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSensorPhalanxDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSensorPhalanxDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSensorPhalanxDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSensorPhalanxDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblSensorPhalanxDeuteriumCost.Name = "lblSensorPhalanxDeuteriumCost";
            this.lblSensorPhalanxDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblSensorPhalanxDeuteriumCost.TabIndex = 11;
            this.lblSensorPhalanxDeuteriumCost.Text = "deuter";
            this.lblSensorPhalanxDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSensorPhalanxCrystalCost
            // 
            this.lblSensorPhalanxCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSensorPhalanxCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSensorPhalanxCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSensorPhalanxCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSensorPhalanxCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblSensorPhalanxCrystalCost.Name = "lblSensorPhalanxCrystalCost";
            this.lblSensorPhalanxCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSensorPhalanxCrystalCost.TabIndex = 10;
            this.lblSensorPhalanxCrystalCost.Text = "kryształ";
            this.lblSensorPhalanxCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSensorPhalanxMetalCost
            // 
            this.lblSensorPhalanxMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSensorPhalanxMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSensorPhalanxMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSensorPhalanxMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSensorPhalanxMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblSensorPhalanxMetalCost.Name = "lblSensorPhalanxMetalCost";
            this.lblSensorPhalanxMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSensorPhalanxMetalCost.TabIndex = 9;
            this.lblSensorPhalanxMetalCost.Text = "metal";
            this.lblSensorPhalanxMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSensorPhalanxLevel
            // 
            this.lblSensorPhalanxLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblSensorPhalanxLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSensorPhalanxLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSensorPhalanxLevel.Location = new System.Drawing.Point(320, 10);
            this.lblSensorPhalanxLevel.Name = "lblSensorPhalanxLevel";
            this.lblSensorPhalanxLevel.Size = new System.Drawing.Size(50, 30);
            this.lblSensorPhalanxLevel.TabIndex = 8;
            this.lblSensorPhalanxLevel.Text = "level";
            this.lblSensorPhalanxLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSensorPhalanx
            // 
            this.lblSensorPhalanx.BackColor = System.Drawing.Color.Transparent;
            this.lblSensorPhalanx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSensorPhalanx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSensorPhalanx.Location = new System.Drawing.Point(10, 10);
            this.lblSensorPhalanx.Name = "lblSensorPhalanx";
            this.lblSensorPhalanx.Size = new System.Drawing.Size(300, 30);
            this.lblSensorPhalanx.TabIndex = 7;
            this.lblSensorPhalanx.Text = "Falanga czujników";
            this.lblSensorPhalanx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLunarBase
            // 
            this.pLunarBase.BackColor = System.Drawing.Color.Yellow;
            this.pLunarBase.Controls.Add(this.lblLunarBaseTimeRemain);
            this.pLunarBase.Controls.Add(this.lblLunarBaseDuration);
            this.pLunarBase.Controls.Add(this.btnLunarBaseUpgrade);
            this.pLunarBase.Controls.Add(this.lblLunarBaseDeuteriumCost);
            this.pLunarBase.Controls.Add(this.lblLunarBaseCrystalCost);
            this.pLunarBase.Controls.Add(this.lblLunarBaseMetalCost);
            this.pLunarBase.Controls.Add(this.lblLunarBaseLevel);
            this.pLunarBase.Controls.Add(this.lblLunarBase);
            this.pLunarBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLunarBase.Location = new System.Drawing.Point(3, 353);
            this.pLunarBase.Name = "pLunarBase";
            this.pLunarBase.Size = new System.Drawing.Size(1890, 50);
            this.pLunarBase.TabIndex = 9;
            // 
            // lblLunarBaseTimeRemain
            // 
            this.lblLunarBaseTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblLunarBaseTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLunarBaseTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLunarBaseTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblLunarBaseTimeRemain.Name = "lblLunarBaseTimeRemain";
            this.lblLunarBaseTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblLunarBaseTimeRemain.TabIndex = 24;
            this.lblLunarBaseTimeRemain.Text = "czas pozostały";
            this.lblLunarBaseTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLunarBaseDuration
            // 
            this.lblLunarBaseDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblLunarBaseDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLunarBaseDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLunarBaseDuration.Location = new System.Drawing.Point(800, 10);
            this.lblLunarBaseDuration.Name = "lblLunarBaseDuration";
            this.lblLunarBaseDuration.Size = new System.Drawing.Size(130, 30);
            this.lblLunarBaseDuration.TabIndex = 13;
            this.lblLunarBaseDuration.Text = "czas";
            this.lblLunarBaseDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLunarBaseUpgrade
            // 
            this.btnLunarBaseUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnLunarBaseUpgrade.Enabled = false;
            this.btnLunarBaseUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLunarBaseUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnLunarBaseUpgrade.Name = "btnLunarBaseUpgrade";
            this.btnLunarBaseUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnLunarBaseUpgrade.TabIndex = 12;
            this.btnLunarBaseUpgrade.Text = "Ulepsz";
            this.btnLunarBaseUpgrade.UseVisualStyleBackColor = false;
            this.btnLunarBaseUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblLunarBaseDeuteriumCost
            // 
            this.lblLunarBaseDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLunarBaseDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLunarBaseDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLunarBaseDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLunarBaseDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblLunarBaseDeuteriumCost.Name = "lblLunarBaseDeuteriumCost";
            this.lblLunarBaseDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblLunarBaseDeuteriumCost.TabIndex = 11;
            this.lblLunarBaseDeuteriumCost.Text = "deuter";
            this.lblLunarBaseDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLunarBaseCrystalCost
            // 
            this.lblLunarBaseCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLunarBaseCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLunarBaseCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLunarBaseCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLunarBaseCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblLunarBaseCrystalCost.Name = "lblLunarBaseCrystalCost";
            this.lblLunarBaseCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLunarBaseCrystalCost.TabIndex = 10;
            this.lblLunarBaseCrystalCost.Text = "kryształ";
            this.lblLunarBaseCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLunarBaseMetalCost
            // 
            this.lblLunarBaseMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLunarBaseMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLunarBaseMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLunarBaseMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLunarBaseMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblLunarBaseMetalCost.Name = "lblLunarBaseMetalCost";
            this.lblLunarBaseMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLunarBaseMetalCost.TabIndex = 9;
            this.lblLunarBaseMetalCost.Text = "metal";
            this.lblLunarBaseMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLunarBaseLevel
            // 
            this.lblLunarBaseLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLunarBaseLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLunarBaseLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLunarBaseLevel.Location = new System.Drawing.Point(320, 10);
            this.lblLunarBaseLevel.Name = "lblLunarBaseLevel";
            this.lblLunarBaseLevel.Size = new System.Drawing.Size(50, 30);
            this.lblLunarBaseLevel.TabIndex = 8;
            this.lblLunarBaseLevel.Text = "level";
            this.lblLunarBaseLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLunarBase
            // 
            this.lblLunarBase.BackColor = System.Drawing.Color.Transparent;
            this.lblLunarBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLunarBase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLunarBase.Location = new System.Drawing.Point(10, 10);
            this.lblLunarBase.Name = "lblLunarBase";
            this.lblLunarBase.Size = new System.Drawing.Size(300, 30);
            this.lblLunarBase.TabIndex = 7;
            this.lblLunarBase.Text = "Stacja księżycowa";
            this.lblLunarBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSpaceDock
            // 
            this.pSpaceDock.BackColor = System.Drawing.Color.Gold;
            this.pSpaceDock.Controls.Add(this.lblSpaceDockTimeRemain);
            this.pSpaceDock.Controls.Add(this.lblSpaceDockEnergyCost);
            this.pSpaceDock.Controls.Add(this.lblSpaceDockDuration);
            this.pSpaceDock.Controls.Add(this.btnSpaceDockUpgrade);
            this.pSpaceDock.Controls.Add(this.lblSpaceDockDeuteriumCost);
            this.pSpaceDock.Controls.Add(this.lblSpaceDockCrystalCost);
            this.pSpaceDock.Controls.Add(this.lblSpaceDockMetalCost);
            this.pSpaceDock.Controls.Add(this.lblSpaceDockLevel);
            this.pSpaceDock.Controls.Add(this.lblSpaceDock);
            this.pSpaceDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSpaceDock.Location = new System.Drawing.Point(3, 303);
            this.pSpaceDock.Name = "pSpaceDock";
            this.pSpaceDock.Size = new System.Drawing.Size(1890, 50);
            this.pSpaceDock.TabIndex = 8;
            // 
            // lblSpaceDockTimeRemain
            // 
            this.lblSpaceDockTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDockTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpaceDockTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSpaceDockTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblSpaceDockTimeRemain.Name = "lblSpaceDockTimeRemain";
            this.lblSpaceDockTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblSpaceDockTimeRemain.TabIndex = 23;
            this.lblSpaceDockTimeRemain.Text = "czas pozostały";
            this.lblSpaceDockTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpaceDockEnergyCost
            // 
            this.lblSpaceDockEnergyCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDockEnergyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpaceDockEnergyCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpaceDockEnergyCost.Location = new System.Drawing.Point(940, 10);
            this.lblSpaceDockEnergyCost.Name = "lblSpaceDockEnergyCost";
            this.lblSpaceDockEnergyCost.Size = new System.Drawing.Size(130, 30);
            this.lblSpaceDockEnergyCost.TabIndex = 14;
            this.lblSpaceDockEnergyCost.Text = "energia";
            this.lblSpaceDockEnergyCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpaceDockDuration
            // 
            this.lblSpaceDockDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDockDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpaceDockDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpaceDockDuration.Location = new System.Drawing.Point(800, 10);
            this.lblSpaceDockDuration.Name = "lblSpaceDockDuration";
            this.lblSpaceDockDuration.Size = new System.Drawing.Size(130, 30);
            this.lblSpaceDockDuration.TabIndex = 13;
            this.lblSpaceDockDuration.Text = "czas";
            this.lblSpaceDockDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSpaceDockUpgrade
            // 
            this.btnSpaceDockUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnSpaceDockUpgrade.Enabled = false;
            this.btnSpaceDockUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSpaceDockUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnSpaceDockUpgrade.Name = "btnSpaceDockUpgrade";
            this.btnSpaceDockUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnSpaceDockUpgrade.TabIndex = 12;
            this.btnSpaceDockUpgrade.Text = "Ulepsz";
            this.btnSpaceDockUpgrade.UseVisualStyleBackColor = false;
            this.btnSpaceDockUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblSpaceDockDeuteriumCost
            // 
            this.lblSpaceDockDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDockDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpaceDockDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpaceDockDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSpaceDockDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblSpaceDockDeuteriumCost.Name = "lblSpaceDockDeuteriumCost";
            this.lblSpaceDockDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblSpaceDockDeuteriumCost.TabIndex = 11;
            this.lblSpaceDockDeuteriumCost.Text = "deuter";
            this.lblSpaceDockDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpaceDockCrystalCost
            // 
            this.lblSpaceDockCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDockCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpaceDockCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpaceDockCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSpaceDockCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblSpaceDockCrystalCost.Name = "lblSpaceDockCrystalCost";
            this.lblSpaceDockCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSpaceDockCrystalCost.TabIndex = 10;
            this.lblSpaceDockCrystalCost.Text = "kryształ";
            this.lblSpaceDockCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpaceDockMetalCost
            // 
            this.lblSpaceDockMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDockMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpaceDockMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpaceDockMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSpaceDockMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblSpaceDockMetalCost.Name = "lblSpaceDockMetalCost";
            this.lblSpaceDockMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSpaceDockMetalCost.TabIndex = 9;
            this.lblSpaceDockMetalCost.Text = "metal";
            this.lblSpaceDockMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpaceDockLevel
            // 
            this.lblSpaceDockLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDockLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpaceDockLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpaceDockLevel.Location = new System.Drawing.Point(320, 10);
            this.lblSpaceDockLevel.Name = "lblSpaceDockLevel";
            this.lblSpaceDockLevel.Size = new System.Drawing.Size(50, 30);
            this.lblSpaceDockLevel.TabIndex = 8;
            this.lblSpaceDockLevel.Text = "level";
            this.lblSpaceDockLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpaceDock
            // 
            this.lblSpaceDock.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceDock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpaceDock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpaceDock.Location = new System.Drawing.Point(10, 10);
            this.lblSpaceDock.Name = "lblSpaceDock";
            this.lblSpaceDock.Size = new System.Drawing.Size(300, 30);
            this.lblSpaceDock.TabIndex = 7;
            this.lblSpaceDock.Text = "Dok kosminczny";
            this.lblSpaceDock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTerraformer
            // 
            this.pTerraformer.BackColor = System.Drawing.Color.Yellow;
            this.pTerraformer.Controls.Add(this.lblTerraformerTimeRemain);
            this.pTerraformer.Controls.Add(this.lblTerraformerEnergyCost);
            this.pTerraformer.Controls.Add(this.lblTerraformerDuration);
            this.pTerraformer.Controls.Add(this.btnTerraformerUpgrade);
            this.pTerraformer.Controls.Add(this.lblTerraformerDeuteriumCost);
            this.pTerraformer.Controls.Add(this.lblTerraformerCrystalCost);
            this.pTerraformer.Controls.Add(this.lblTerraformerMetalCost);
            this.pTerraformer.Controls.Add(this.lblTerraformerLevel);
            this.pTerraformer.Controls.Add(this.lblTerraformer);
            this.pTerraformer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTerraformer.Location = new System.Drawing.Point(3, 253);
            this.pTerraformer.Name = "pTerraformer";
            this.pTerraformer.Size = new System.Drawing.Size(1890, 50);
            this.pTerraformer.TabIndex = 7;
            // 
            // lblTerraformerTimeRemain
            // 
            this.lblTerraformerTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblTerraformerTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerraformerTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTerraformerTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblTerraformerTimeRemain.Name = "lblTerraformerTimeRemain";
            this.lblTerraformerTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblTerraformerTimeRemain.TabIndex = 22;
            this.lblTerraformerTimeRemain.Text = "czas pozostały";
            this.lblTerraformerTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerraformerEnergyCost
            // 
            this.lblTerraformerEnergyCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTerraformerEnergyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerraformerEnergyCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerraformerEnergyCost.Location = new System.Drawing.Point(940, 10);
            this.lblTerraformerEnergyCost.Name = "lblTerraformerEnergyCost";
            this.lblTerraformerEnergyCost.Size = new System.Drawing.Size(130, 30);
            this.lblTerraformerEnergyCost.TabIndex = 14;
            this.lblTerraformerEnergyCost.Text = "energia";
            this.lblTerraformerEnergyCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerraformerDuration
            // 
            this.lblTerraformerDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblTerraformerDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerraformerDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerraformerDuration.Location = new System.Drawing.Point(800, 10);
            this.lblTerraformerDuration.Name = "lblTerraformerDuration";
            this.lblTerraformerDuration.Size = new System.Drawing.Size(130, 30);
            this.lblTerraformerDuration.TabIndex = 13;
            this.lblTerraformerDuration.Text = "czas";
            this.lblTerraformerDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTerraformerUpgrade
            // 
            this.btnTerraformerUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnTerraformerUpgrade.Enabled = false;
            this.btnTerraformerUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTerraformerUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnTerraformerUpgrade.Name = "btnTerraformerUpgrade";
            this.btnTerraformerUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnTerraformerUpgrade.TabIndex = 12;
            this.btnTerraformerUpgrade.Text = "Ulepsz";
            this.btnTerraformerUpgrade.UseVisualStyleBackColor = false;
            this.btnTerraformerUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblTerraformerDeuteriumCost
            // 
            this.lblTerraformerDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTerraformerDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerraformerDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerraformerDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerraformerDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblTerraformerDeuteriumCost.Name = "lblTerraformerDeuteriumCost";
            this.lblTerraformerDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblTerraformerDeuteriumCost.TabIndex = 11;
            this.lblTerraformerDeuteriumCost.Text = "deuter";
            this.lblTerraformerDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerraformerCrystalCost
            // 
            this.lblTerraformerCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTerraformerCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerraformerCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerraformerCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerraformerCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblTerraformerCrystalCost.Name = "lblTerraformerCrystalCost";
            this.lblTerraformerCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblTerraformerCrystalCost.TabIndex = 10;
            this.lblTerraformerCrystalCost.Text = "kryształ";
            this.lblTerraformerCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerraformerMetalCost
            // 
            this.lblTerraformerMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTerraformerMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerraformerMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerraformerMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerraformerMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblTerraformerMetalCost.Name = "lblTerraformerMetalCost";
            this.lblTerraformerMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblTerraformerMetalCost.TabIndex = 9;
            this.lblTerraformerMetalCost.Text = "metal";
            this.lblTerraformerMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerraformerLevel
            // 
            this.lblTerraformerLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblTerraformerLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerraformerLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerraformerLevel.Location = new System.Drawing.Point(320, 10);
            this.lblTerraformerLevel.Name = "lblTerraformerLevel";
            this.lblTerraformerLevel.Size = new System.Drawing.Size(50, 30);
            this.lblTerraformerLevel.TabIndex = 8;
            this.lblTerraformerLevel.Text = "level";
            this.lblTerraformerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerraformer
            // 
            this.lblTerraformer.BackColor = System.Drawing.Color.Transparent;
            this.lblTerraformer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerraformer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerraformer.Location = new System.Drawing.Point(10, 10);
            this.lblTerraformer.Name = "lblTerraformer";
            this.lblTerraformer.Size = new System.Drawing.Size(300, 30);
            this.lblTerraformer.TabIndex = 7;
            this.lblTerraformer.Text = "Terraformer";
            this.lblTerraformer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMissileSilo
            // 
            this.pMissileSilo.BackColor = System.Drawing.Color.Gold;
            this.pMissileSilo.Controls.Add(this.lblMissileSiloTimeRemain);
            this.pMissileSilo.Controls.Add(this.lblMissileSiloDuration);
            this.pMissileSilo.Controls.Add(this.btnMissileSiloUpgrade);
            this.pMissileSilo.Controls.Add(this.lblMissileSiloDeuteriumCost);
            this.pMissileSilo.Controls.Add(this.lblMissileSiloCrystalCost);
            this.pMissileSilo.Controls.Add(this.lblMissileSiloMetalCost);
            this.pMissileSilo.Controls.Add(this.lblMissileSiloLevel);
            this.pMissileSilo.Controls.Add(this.lblMissileSilo);
            this.pMissileSilo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMissileSilo.Location = new System.Drawing.Point(3, 203);
            this.pMissileSilo.Name = "pMissileSilo";
            this.pMissileSilo.Size = new System.Drawing.Size(1890, 50);
            this.pMissileSilo.TabIndex = 6;
            // 
            // lblMissileSiloTimeRemain
            // 
            this.lblMissileSiloTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblMissileSiloTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissileSiloTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMissileSiloTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblMissileSiloTimeRemain.Name = "lblMissileSiloTimeRemain";
            this.lblMissileSiloTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblMissileSiloTimeRemain.TabIndex = 21;
            this.lblMissileSiloTimeRemain.Text = "czas pozostały";
            this.lblMissileSiloTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMissileSiloDuration
            // 
            this.lblMissileSiloDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblMissileSiloDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMissileSiloDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissileSiloDuration.Location = new System.Drawing.Point(800, 10);
            this.lblMissileSiloDuration.Name = "lblMissileSiloDuration";
            this.lblMissileSiloDuration.Size = new System.Drawing.Size(130, 30);
            this.lblMissileSiloDuration.TabIndex = 13;
            this.lblMissileSiloDuration.Text = "czas";
            this.lblMissileSiloDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMissileSiloUpgrade
            // 
            this.btnMissileSiloUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnMissileSiloUpgrade.Enabled = false;
            this.btnMissileSiloUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMissileSiloUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnMissileSiloUpgrade.Name = "btnMissileSiloUpgrade";
            this.btnMissileSiloUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnMissileSiloUpgrade.TabIndex = 12;
            this.btnMissileSiloUpgrade.Text = "Ulepsz";
            this.btnMissileSiloUpgrade.UseVisualStyleBackColor = false;
            this.btnMissileSiloUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblMissileSiloDeuteriumCost
            // 
            this.lblMissileSiloDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMissileSiloDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMissileSiloDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissileSiloDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMissileSiloDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblMissileSiloDeuteriumCost.Name = "lblMissileSiloDeuteriumCost";
            this.lblMissileSiloDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblMissileSiloDeuteriumCost.TabIndex = 11;
            this.lblMissileSiloDeuteriumCost.Text = "deuter";
            this.lblMissileSiloDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMissileSiloCrystalCost
            // 
            this.lblMissileSiloCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMissileSiloCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMissileSiloCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissileSiloCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMissileSiloCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblMissileSiloCrystalCost.Name = "lblMissileSiloCrystalCost";
            this.lblMissileSiloCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblMissileSiloCrystalCost.TabIndex = 10;
            this.lblMissileSiloCrystalCost.Text = "kryształ";
            this.lblMissileSiloCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMissileSiloMetalCost
            // 
            this.lblMissileSiloMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMissileSiloMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMissileSiloMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissileSiloMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMissileSiloMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblMissileSiloMetalCost.Name = "lblMissileSiloMetalCost";
            this.lblMissileSiloMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblMissileSiloMetalCost.TabIndex = 9;
            this.lblMissileSiloMetalCost.Text = "metal";
            this.lblMissileSiloMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMissileSiloLevel
            // 
            this.lblMissileSiloLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblMissileSiloLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMissileSiloLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissileSiloLevel.Location = new System.Drawing.Point(320, 10);
            this.lblMissileSiloLevel.Name = "lblMissileSiloLevel";
            this.lblMissileSiloLevel.Size = new System.Drawing.Size(50, 30);
            this.lblMissileSiloLevel.TabIndex = 8;
            this.lblMissileSiloLevel.Text = "level";
            this.lblMissileSiloLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMissileSilo
            // 
            this.lblMissileSilo.BackColor = System.Drawing.Color.Transparent;
            this.lblMissileSilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMissileSilo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMissileSilo.Location = new System.Drawing.Point(10, 10);
            this.lblMissileSilo.Name = "lblMissileSilo";
            this.lblMissileSilo.Size = new System.Drawing.Size(300, 30);
            this.lblMissileSilo.TabIndex = 7;
            this.lblMissileSilo.Text = "Silos rakietowy";
            this.lblMissileSilo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pResearchLab
            // 
            this.pResearchLab.BackColor = System.Drawing.Color.Yellow;
            this.pResearchLab.Controls.Add(this.lblResearchLabTimeRemain);
            this.pResearchLab.Controls.Add(this.lblResearchLabDuration);
            this.pResearchLab.Controls.Add(this.btnResearchLabUpgrade);
            this.pResearchLab.Controls.Add(this.lblResearchLabDeuteriumCost);
            this.pResearchLab.Controls.Add(this.lblResearchLabCrystalCost);
            this.pResearchLab.Controls.Add(this.lblResearchLabMetalCost);
            this.pResearchLab.Controls.Add(this.lblResearchLabLevel);
            this.pResearchLab.Controls.Add(this.lblResearchLab);
            this.pResearchLab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pResearchLab.Location = new System.Drawing.Point(3, 153);
            this.pResearchLab.Name = "pResearchLab";
            this.pResearchLab.Size = new System.Drawing.Size(1890, 50);
            this.pResearchLab.TabIndex = 5;
            // 
            // lblResearchLabTimeRemain
            // 
            this.lblResearchLabTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblResearchLabTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchLabTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResearchLabTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblResearchLabTimeRemain.Name = "lblResearchLabTimeRemain";
            this.lblResearchLabTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblResearchLabTimeRemain.TabIndex = 20;
            this.lblResearchLabTimeRemain.Text = "czas pozostały";
            this.lblResearchLabTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResearchLabDuration
            // 
            this.lblResearchLabDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblResearchLabDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchLabDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchLabDuration.Location = new System.Drawing.Point(800, 10);
            this.lblResearchLabDuration.Name = "lblResearchLabDuration";
            this.lblResearchLabDuration.Size = new System.Drawing.Size(130, 30);
            this.lblResearchLabDuration.TabIndex = 13;
            this.lblResearchLabDuration.Text = "czas";
            this.lblResearchLabDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResearchLabUpgrade
            // 
            this.btnResearchLabUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnResearchLabUpgrade.Enabled = false;
            this.btnResearchLabUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResearchLabUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnResearchLabUpgrade.Name = "btnResearchLabUpgrade";
            this.btnResearchLabUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnResearchLabUpgrade.TabIndex = 12;
            this.btnResearchLabUpgrade.Text = "Ulepsz";
            this.btnResearchLabUpgrade.UseVisualStyleBackColor = false;
            this.btnResearchLabUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblResearchLabDeuteriumCost
            // 
            this.lblResearchLabDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblResearchLabDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchLabDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchLabDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResearchLabDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblResearchLabDeuteriumCost.Name = "lblResearchLabDeuteriumCost";
            this.lblResearchLabDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblResearchLabDeuteriumCost.TabIndex = 11;
            this.lblResearchLabDeuteriumCost.Text = "deuter";
            this.lblResearchLabDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResearchLabCrystalCost
            // 
            this.lblResearchLabCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblResearchLabCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchLabCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchLabCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResearchLabCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblResearchLabCrystalCost.Name = "lblResearchLabCrystalCost";
            this.lblResearchLabCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblResearchLabCrystalCost.TabIndex = 10;
            this.lblResearchLabCrystalCost.Text = "kryształ";
            this.lblResearchLabCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResearchLabMetalCost
            // 
            this.lblResearchLabMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblResearchLabMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchLabMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchLabMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblResearchLabMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblResearchLabMetalCost.Name = "lblResearchLabMetalCost";
            this.lblResearchLabMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblResearchLabMetalCost.TabIndex = 9;
            this.lblResearchLabMetalCost.Text = "metal";
            this.lblResearchLabMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResearchLabLevel
            // 
            this.lblResearchLabLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblResearchLabLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchLabLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchLabLevel.Location = new System.Drawing.Point(320, 10);
            this.lblResearchLabLevel.Name = "lblResearchLabLevel";
            this.lblResearchLabLevel.Size = new System.Drawing.Size(50, 30);
            this.lblResearchLabLevel.TabIndex = 8;
            this.lblResearchLabLevel.Text = "level";
            this.lblResearchLabLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResearchLab
            // 
            this.lblResearchLab.BackColor = System.Drawing.Color.Transparent;
            this.lblResearchLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchLab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchLab.Location = new System.Drawing.Point(10, 10);
            this.lblResearchLab.Name = "lblResearchLab";
            this.lblResearchLab.Size = new System.Drawing.Size(300, 30);
            this.lblResearchLab.TabIndex = 7;
            this.lblResearchLab.Text = "Laboratorium badawcze";
            this.lblResearchLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pShipyard
            // 
            this.pShipyard.BackColor = System.Drawing.Color.Gold;
            this.pShipyard.Controls.Add(this.lblShipyardTimeRemain);
            this.pShipyard.Controls.Add(this.lblShipyardDuration);
            this.pShipyard.Controls.Add(this.btnShipyardUpgrade);
            this.pShipyard.Controls.Add(this.lblShipyardDeuteriumCost);
            this.pShipyard.Controls.Add(this.lblShipyardCrystalCost);
            this.pShipyard.Controls.Add(this.lblShipyardMetalCost);
            this.pShipyard.Controls.Add(this.lblShipyardLevel);
            this.pShipyard.Controls.Add(this.lblShipyard);
            this.pShipyard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pShipyard.Location = new System.Drawing.Point(3, 103);
            this.pShipyard.Name = "pShipyard";
            this.pShipyard.Size = new System.Drawing.Size(1890, 50);
            this.pShipyard.TabIndex = 4;
            // 
            // lblShipyardTimeRemain
            // 
            this.lblShipyardTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblShipyardTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipyardTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShipyardTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblShipyardTimeRemain.Name = "lblShipyardTimeRemain";
            this.lblShipyardTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblShipyardTimeRemain.TabIndex = 19;
            this.lblShipyardTimeRemain.Text = "czas pozostały";
            this.lblShipyardTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipyardDuration
            // 
            this.lblShipyardDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblShipyardDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipyardDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipyardDuration.Location = new System.Drawing.Point(800, 10);
            this.lblShipyardDuration.Name = "lblShipyardDuration";
            this.lblShipyardDuration.Size = new System.Drawing.Size(130, 30);
            this.lblShipyardDuration.TabIndex = 13;
            this.lblShipyardDuration.Text = "czas";
            this.lblShipyardDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShipyardUpgrade
            // 
            this.btnShipyardUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnShipyardUpgrade.Enabled = false;
            this.btnShipyardUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShipyardUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnShipyardUpgrade.Name = "btnShipyardUpgrade";
            this.btnShipyardUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnShipyardUpgrade.TabIndex = 12;
            this.btnShipyardUpgrade.Text = "Ulepsz";
            this.btnShipyardUpgrade.UseVisualStyleBackColor = false;
            this.btnShipyardUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblShipyardDeuteriumCost
            // 
            this.lblShipyardDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblShipyardDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipyardDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipyardDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShipyardDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblShipyardDeuteriumCost.Name = "lblShipyardDeuteriumCost";
            this.lblShipyardDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblShipyardDeuteriumCost.TabIndex = 11;
            this.lblShipyardDeuteriumCost.Text = "deuter";
            this.lblShipyardDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipyardCrystalCost
            // 
            this.lblShipyardCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblShipyardCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipyardCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipyardCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShipyardCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblShipyardCrystalCost.Name = "lblShipyardCrystalCost";
            this.lblShipyardCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblShipyardCrystalCost.TabIndex = 10;
            this.lblShipyardCrystalCost.Text = "kryształ";
            this.lblShipyardCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipyardMetalCost
            // 
            this.lblShipyardMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblShipyardMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipyardMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipyardMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShipyardMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblShipyardMetalCost.Name = "lblShipyardMetalCost";
            this.lblShipyardMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblShipyardMetalCost.TabIndex = 9;
            this.lblShipyardMetalCost.Text = "metal";
            this.lblShipyardMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipyardLevel
            // 
            this.lblShipyardLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblShipyardLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipyardLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipyardLevel.Location = new System.Drawing.Point(320, 10);
            this.lblShipyardLevel.Name = "lblShipyardLevel";
            this.lblShipyardLevel.Size = new System.Drawing.Size(50, 30);
            this.lblShipyardLevel.TabIndex = 8;
            this.lblShipyardLevel.Text = "level";
            this.lblShipyardLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShipyard
            // 
            this.lblShipyard.BackColor = System.Drawing.Color.Transparent;
            this.lblShipyard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipyard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipyard.Location = new System.Drawing.Point(10, 10);
            this.lblShipyard.Name = "lblShipyard";
            this.lblShipyard.Size = new System.Drawing.Size(300, 30);
            this.lblShipyard.TabIndex = 7;
            this.lblShipyard.Text = "Stocznia orbitalna";
            this.lblShipyard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pNaniteFactory
            // 
            this.pNaniteFactory.BackColor = System.Drawing.Color.Yellow;
            this.pNaniteFactory.Controls.Add(this.lblNaniteFactoryTimeRemain);
            this.pNaniteFactory.Controls.Add(this.lblNaniteFactoryDuration);
            this.pNaniteFactory.Controls.Add(this.btnNaniteFactoryUpgrade);
            this.pNaniteFactory.Controls.Add(this.lblNaniteFactoryDeuteriumCost);
            this.pNaniteFactory.Controls.Add(this.lblNaniteFactoryCrystalCost);
            this.pNaniteFactory.Controls.Add(this.lblNaniteFactoryMetalCost);
            this.pNaniteFactory.Controls.Add(this.lblNaniteFactoryLevel);
            this.pNaniteFactory.Controls.Add(this.lblNaniteFactory);
            this.pNaniteFactory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNaniteFactory.Location = new System.Drawing.Point(3, 53);
            this.pNaniteFactory.Name = "pNaniteFactory";
            this.pNaniteFactory.Size = new System.Drawing.Size(1890, 50);
            this.pNaniteFactory.TabIndex = 3;
            // 
            // lblNaniteFactoryTimeRemain
            // 
            this.lblNaniteFactoryTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblNaniteFactoryTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaniteFactoryTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNaniteFactoryTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblNaniteFactoryTimeRemain.Name = "lblNaniteFactoryTimeRemain";
            this.lblNaniteFactoryTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblNaniteFactoryTimeRemain.TabIndex = 18;
            this.lblNaniteFactoryTimeRemain.Text = "czas pozostały";
            this.lblNaniteFactoryTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNaniteFactoryDuration
            // 
            this.lblNaniteFactoryDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblNaniteFactoryDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaniteFactoryDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaniteFactoryDuration.Location = new System.Drawing.Point(800, 10);
            this.lblNaniteFactoryDuration.Name = "lblNaniteFactoryDuration";
            this.lblNaniteFactoryDuration.Size = new System.Drawing.Size(130, 30);
            this.lblNaniteFactoryDuration.TabIndex = 13;
            this.lblNaniteFactoryDuration.Text = "czas";
            this.lblNaniteFactoryDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNaniteFactoryUpgrade
            // 
            this.btnNaniteFactoryUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnNaniteFactoryUpgrade.Enabled = false;
            this.btnNaniteFactoryUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNaniteFactoryUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnNaniteFactoryUpgrade.Name = "btnNaniteFactoryUpgrade";
            this.btnNaniteFactoryUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnNaniteFactoryUpgrade.TabIndex = 12;
            this.btnNaniteFactoryUpgrade.Text = "Ulepsz";
            this.btnNaniteFactoryUpgrade.UseVisualStyleBackColor = false;
            this.btnNaniteFactoryUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblNaniteFactoryDeuteriumCost
            // 
            this.lblNaniteFactoryDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblNaniteFactoryDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaniteFactoryDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaniteFactoryDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaniteFactoryDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblNaniteFactoryDeuteriumCost.Name = "lblNaniteFactoryDeuteriumCost";
            this.lblNaniteFactoryDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblNaniteFactoryDeuteriumCost.TabIndex = 11;
            this.lblNaniteFactoryDeuteriumCost.Text = "deuter";
            this.lblNaniteFactoryDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNaniteFactoryCrystalCost
            // 
            this.lblNaniteFactoryCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblNaniteFactoryCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaniteFactoryCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaniteFactoryCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaniteFactoryCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblNaniteFactoryCrystalCost.Name = "lblNaniteFactoryCrystalCost";
            this.lblNaniteFactoryCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblNaniteFactoryCrystalCost.TabIndex = 10;
            this.lblNaniteFactoryCrystalCost.Text = "kryształ";
            this.lblNaniteFactoryCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNaniteFactoryMetalCost
            // 
            this.lblNaniteFactoryMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblNaniteFactoryMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaniteFactoryMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaniteFactoryMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaniteFactoryMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblNaniteFactoryMetalCost.Name = "lblNaniteFactoryMetalCost";
            this.lblNaniteFactoryMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblNaniteFactoryMetalCost.TabIndex = 9;
            this.lblNaniteFactoryMetalCost.Text = "metal";
            this.lblNaniteFactoryMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNaniteFactoryLevel
            // 
            this.lblNaniteFactoryLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblNaniteFactoryLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaniteFactoryLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaniteFactoryLevel.Location = new System.Drawing.Point(320, 10);
            this.lblNaniteFactoryLevel.Name = "lblNaniteFactoryLevel";
            this.lblNaniteFactoryLevel.Size = new System.Drawing.Size(50, 30);
            this.lblNaniteFactoryLevel.TabIndex = 8;
            this.lblNaniteFactoryLevel.Text = "level";
            this.lblNaniteFactoryLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNaniteFactory
            // 
            this.lblNaniteFactory.BackColor = System.Drawing.Color.Transparent;
            this.lblNaniteFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaniteFactory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaniteFactory.Location = new System.Drawing.Point(10, 10);
            this.lblNaniteFactory.Name = "lblNaniteFactory";
            this.lblNaniteFactory.Size = new System.Drawing.Size(300, 30);
            this.lblNaniteFactory.TabIndex = 7;
            this.lblNaniteFactory.Text = "Fabryka nanitów";
            this.lblNaniteFactory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pRoboticsFactory
            // 
            this.pRoboticsFactory.BackColor = System.Drawing.Color.Gold;
            this.pRoboticsFactory.Controls.Add(this.lblRoboticsFactoryTimeRemain);
            this.pRoboticsFactory.Controls.Add(this.lblRoboticsFactoryDuration);
            this.pRoboticsFactory.Controls.Add(this.btnRoboticsFactoryUpgrade);
            this.pRoboticsFactory.Controls.Add(this.lblRoboticsFactoryDeuteriumCost);
            this.pRoboticsFactory.Controls.Add(this.lblRoboticsFactoryCrystalCost);
            this.pRoboticsFactory.Controls.Add(this.lblRoboticsFactoryMetalCost);
            this.pRoboticsFactory.Controls.Add(this.lblRoboticsFactoryLevel);
            this.pRoboticsFactory.Controls.Add(this.lblRoboticsFactory);
            this.pRoboticsFactory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRoboticsFactory.Location = new System.Drawing.Point(3, 3);
            this.pRoboticsFactory.Name = "pRoboticsFactory";
            this.pRoboticsFactory.Size = new System.Drawing.Size(1890, 50);
            this.pRoboticsFactory.TabIndex = 2;
            // 
            // lblRoboticsFactoryTimeRemain
            // 
            this.lblRoboticsFactoryTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboticsFactoryTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboticsFactoryTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRoboticsFactoryTimeRemain.Location = new System.Drawing.Point(1220, 10);
            this.lblRoboticsFactoryTimeRemain.Name = "lblRoboticsFactoryTimeRemain";
            this.lblRoboticsFactoryTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblRoboticsFactoryTimeRemain.TabIndex = 17;
            this.lblRoboticsFactoryTimeRemain.Text = "czas pozostały";
            this.lblRoboticsFactoryTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoboticsFactoryDuration
            // 
            this.lblRoboticsFactoryDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboticsFactoryDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoboticsFactoryDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboticsFactoryDuration.Location = new System.Drawing.Point(800, 10);
            this.lblRoboticsFactoryDuration.Name = "lblRoboticsFactoryDuration";
            this.lblRoboticsFactoryDuration.Size = new System.Drawing.Size(130, 30);
            this.lblRoboticsFactoryDuration.TabIndex = 13;
            this.lblRoboticsFactoryDuration.Text = "czas";
            this.lblRoboticsFactoryDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRoboticsFactoryUpgrade
            // 
            this.btnRoboticsFactoryUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnRoboticsFactoryUpgrade.Enabled = false;
            this.btnRoboticsFactoryUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoboticsFactoryUpgrade.Location = new System.Drawing.Point(1080, 10);
            this.btnRoboticsFactoryUpgrade.Name = "btnRoboticsFactoryUpgrade";
            this.btnRoboticsFactoryUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnRoboticsFactoryUpgrade.TabIndex = 12;
            this.btnRoboticsFactoryUpgrade.Text = "Ulepsz";
            this.btnRoboticsFactoryUpgrade.UseVisualStyleBackColor = false;
            this.btnRoboticsFactoryUpgrade.Click += new System.EventHandler(this.BtnUpgradeBuilding_Click);
            // 
            // lblRoboticsFactoryDeuteriumCost
            // 
            this.lblRoboticsFactoryDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboticsFactoryDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoboticsFactoryDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboticsFactoryDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoboticsFactoryDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblRoboticsFactoryDeuteriumCost.Name = "lblRoboticsFactoryDeuteriumCost";
            this.lblRoboticsFactoryDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblRoboticsFactoryDeuteriumCost.TabIndex = 11;
            this.lblRoboticsFactoryDeuteriumCost.Text = "deuter";
            this.lblRoboticsFactoryDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoboticsFactoryCrystalCost
            // 
            this.lblRoboticsFactoryCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboticsFactoryCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoboticsFactoryCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboticsFactoryCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoboticsFactoryCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblRoboticsFactoryCrystalCost.Name = "lblRoboticsFactoryCrystalCost";
            this.lblRoboticsFactoryCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblRoboticsFactoryCrystalCost.TabIndex = 10;
            this.lblRoboticsFactoryCrystalCost.Text = "kryształ";
            this.lblRoboticsFactoryCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoboticsFactoryMetalCost
            // 
            this.lblRoboticsFactoryMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboticsFactoryMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoboticsFactoryMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboticsFactoryMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoboticsFactoryMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblRoboticsFactoryMetalCost.Name = "lblRoboticsFactoryMetalCost";
            this.lblRoboticsFactoryMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblRoboticsFactoryMetalCost.TabIndex = 9;
            this.lblRoboticsFactoryMetalCost.Text = "metal";
            this.lblRoboticsFactoryMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoboticsFactoryLevel
            // 
            this.lblRoboticsFactoryLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboticsFactoryLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoboticsFactoryLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboticsFactoryLevel.Location = new System.Drawing.Point(320, 10);
            this.lblRoboticsFactoryLevel.Name = "lblRoboticsFactoryLevel";
            this.lblRoboticsFactoryLevel.Size = new System.Drawing.Size(50, 30);
            this.lblRoboticsFactoryLevel.TabIndex = 8;
            this.lblRoboticsFactoryLevel.Text = "level";
            this.lblRoboticsFactoryLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRoboticsFactory
            // 
            this.lblRoboticsFactory.BackColor = System.Drawing.Color.Transparent;
            this.lblRoboticsFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoboticsFactory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoboticsFactory.Location = new System.Drawing.Point(10, 10);
            this.lblRoboticsFactory.Name = "lblRoboticsFactory";
            this.lblRoboticsFactory.Size = new System.Drawing.Size(300, 30);
            this.lblRoboticsFactory.TabIndex = 7;
            this.lblRoboticsFactory.Text = "Fabryka robotów";
            this.lblRoboticsFactory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpResearch
            // 
            this.tpResearch.BackColor = System.Drawing.Color.Silver;
            this.tpResearch.Controls.Add(this.pGravitonTechnology);
            this.tpResearch.Controls.Add(this.pAstrophisics);
            this.tpResearch.Controls.Add(this.pIrn);
            this.tpResearch.Controls.Add(this.pPlasmaTechnology);
            this.tpResearch.Controls.Add(this.pIonTechnology);
            this.tpResearch.Controls.Add(this.pLaserTechnology);
            this.tpResearch.Controls.Add(this.pHyperspaceTechnology);
            this.tpResearch.Controls.Add(this.pEnergyTechnology);
            this.tpResearch.Controls.Add(this.pArmourTechnology);
            this.tpResearch.Controls.Add(this.pShieldingTechnology);
            this.tpResearch.Controls.Add(this.pWeaponsTechnology);
            this.tpResearch.Controls.Add(this.pHyperspaceDrive);
            this.tpResearch.Controls.Add(this.pImpulseDrive);
            this.tpResearch.Controls.Add(this.pCombustionDrive);
            this.tpResearch.Controls.Add(this.pComputerTechnology);
            this.tpResearch.Controls.Add(this.pEspionageTechnology);
            this.tpResearch.Location = new System.Drawing.Point(4, 29);
            this.tpResearch.Name = "tpResearch";
            this.tpResearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpResearch.Size = new System.Drawing.Size(1896, 800);
            this.tpResearch.TabIndex = 4;
            this.tpResearch.Text = "Badania";
            // 
            // pGravitonTechnology
            // 
            this.pGravitonTechnology.BackColor = System.Drawing.Color.Yellow;
            this.pGravitonTechnology.Controls.Add(this.lblGravitonTechnologyEnergyCost);
            this.pGravitonTechnology.Controls.Add(this.lblGravitonTechnologyDuration);
            this.pGravitonTechnology.Controls.Add(this.btnGravitonTechnologyUpgrade);
            this.pGravitonTechnology.Controls.Add(this.lblGravitonTechnologyDeuteriumCost);
            this.pGravitonTechnology.Controls.Add(this.lblGravitonTechnologyCrystalCost);
            this.pGravitonTechnology.Controls.Add(this.lblGravitonTechnologyMetalCost);
            this.pGravitonTechnology.Controls.Add(this.lblGravitonTechnologyLevel);
            this.pGravitonTechnology.Controls.Add(this.lblGravitonTechnology);
            this.pGravitonTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGravitonTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pGravitonTechnology.Location = new System.Drawing.Point(3, 753);
            this.pGravitonTechnology.Name = "pGravitonTechnology";
            this.pGravitonTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pGravitonTechnology.TabIndex = 16;
            // 
            // lblGravitonTechnologyEnergyCost
            // 
            this.lblGravitonTechnologyEnergyCost.BackColor = System.Drawing.Color.Transparent;
            this.lblGravitonTechnologyEnergyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGravitonTechnologyEnergyCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGravitonTechnologyEnergyCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGravitonTechnologyEnergyCost.Location = new System.Drawing.Point(1080, 10);
            this.lblGravitonTechnologyEnergyCost.Name = "lblGravitonTechnologyEnergyCost";
            this.lblGravitonTechnologyEnergyCost.Size = new System.Drawing.Size(130, 30);
            this.lblGravitonTechnologyEnergyCost.TabIndex = 14;
            this.lblGravitonTechnologyEnergyCost.Text = "energia";
            this.lblGravitonTechnologyEnergyCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGravitonTechnologyDuration
            // 
            this.lblGravitonTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblGravitonTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGravitonTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGravitonTechnologyDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGravitonTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblGravitonTechnologyDuration.Name = "lblGravitonTechnologyDuration";
            this.lblGravitonTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblGravitonTechnologyDuration.TabIndex = 13;
            this.lblGravitonTechnologyDuration.Text = "0s";
            this.lblGravitonTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGravitonTechnologyUpgrade
            // 
            this.btnGravitonTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnGravitonTechnologyUpgrade.Enabled = false;
            this.btnGravitonTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGravitonTechnologyUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGravitonTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnGravitonTechnologyUpgrade.Name = "btnGravitonTechnologyUpgrade";
            this.btnGravitonTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnGravitonTechnologyUpgrade.TabIndex = 12;
            this.btnGravitonTechnologyUpgrade.Text = "Ulepsz";
            this.btnGravitonTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnGravitonTechnologyUpgrade.Click += new System.EventHandler(this.BtnGravitonTechnologyUpgrade_Click);
            // 
            // lblGravitonTechnologyDeuteriumCost
            // 
            this.lblGravitonTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblGravitonTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGravitonTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGravitonTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGravitonTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblGravitonTechnologyDeuteriumCost.Name = "lblGravitonTechnologyDeuteriumCost";
            this.lblGravitonTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblGravitonTechnologyDeuteriumCost.TabIndex = 11;
            this.lblGravitonTechnologyDeuteriumCost.Text = "0";
            this.lblGravitonTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGravitonTechnologyCrystalCost
            // 
            this.lblGravitonTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblGravitonTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGravitonTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGravitonTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGravitonTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblGravitonTechnologyCrystalCost.Name = "lblGravitonTechnologyCrystalCost";
            this.lblGravitonTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblGravitonTechnologyCrystalCost.TabIndex = 10;
            this.lblGravitonTechnologyCrystalCost.Text = "0";
            this.lblGravitonTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGravitonTechnologyMetalCost
            // 
            this.lblGravitonTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblGravitonTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGravitonTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGravitonTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGravitonTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblGravitonTechnologyMetalCost.Name = "lblGravitonTechnologyMetalCost";
            this.lblGravitonTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblGravitonTechnologyMetalCost.TabIndex = 9;
            this.lblGravitonTechnologyMetalCost.Text = "0";
            this.lblGravitonTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGravitonTechnologyLevel
            // 
            this.lblGravitonTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblGravitonTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGravitonTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGravitonTechnologyLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGravitonTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblGravitonTechnologyLevel.Name = "lblGravitonTechnologyLevel";
            this.lblGravitonTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblGravitonTechnologyLevel.TabIndex = 8;
            this.lblGravitonTechnologyLevel.Text = "level";
            this.lblGravitonTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGravitonTechnology
            // 
            this.lblGravitonTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblGravitonTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGravitonTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGravitonTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGravitonTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblGravitonTechnology.Name = "lblGravitonTechnology";
            this.lblGravitonTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblGravitonTechnology.TabIndex = 7;
            this.lblGravitonTechnology.Text = "Rozwój grawitonów";
            this.lblGravitonTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pAstrophisics
            // 
            this.pAstrophisics.BackColor = System.Drawing.Color.Gold;
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsColletTime);
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsTotalCost);
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsTotalDeuteriumCost);
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsTimeRemain);
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsDuration);
            this.pAstrophisics.Controls.Add(this.btnAstrophisicsUpgrade);
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsDeuteriumCost);
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsCrystalCost);
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsMetalCost);
            this.pAstrophisics.Controls.Add(this.lblAstrophisicsLevel);
            this.pAstrophisics.Controls.Add(this.lblAstrophisics);
            this.pAstrophisics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAstrophisics.Location = new System.Drawing.Point(3, 703);
            this.pAstrophisics.Name = "pAstrophisics";
            this.pAstrophisics.Size = new System.Drawing.Size(1890, 50);
            this.pAstrophisics.TabIndex = 15;
            // 
            // lblAstrophisicsTotalCost
            // 
            this.lblAstrophisicsTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisicsTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblAstrophisicsTotalCost.Name = "lblAstrophisicsTotalCost";
            this.lblAstrophisicsTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblAstrophisicsTotalCost.TabIndex = 43;
            this.lblAstrophisicsTotalCost.Text = "surowce razem";
            this.lblAstrophisicsTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstrophisicsTotalDeuteriumCost
            // 
            this.lblAstrophisicsTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisicsTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblAstrophisicsTotalDeuteriumCost.Name = "lblAstrophisicsTotalDeuteriumCost";
            this.lblAstrophisicsTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblAstrophisicsTotalDeuteriumCost.TabIndex = 42;
            this.lblAstrophisicsTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblAstrophisicsTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstrophisicsTimeRemain
            // 
            this.lblAstrophisicsTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAstrophisicsTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblAstrophisicsTimeRemain.Name = "lblAstrophisicsTimeRemain";
            this.lblAstrophisicsTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblAstrophisicsTimeRemain.TabIndex = 41;
            this.lblAstrophisicsTimeRemain.Text = "czas pozostały";
            this.lblAstrophisicsTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstrophisicsDuration
            // 
            this.lblAstrophisicsDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisicsDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsDuration.Location = new System.Drawing.Point(800, 10);
            this.lblAstrophisicsDuration.Name = "lblAstrophisicsDuration";
            this.lblAstrophisicsDuration.Size = new System.Drawing.Size(130, 30);
            this.lblAstrophisicsDuration.TabIndex = 13;
            this.lblAstrophisicsDuration.Text = "czas";
            this.lblAstrophisicsDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAstrophisicsUpgrade
            // 
            this.btnAstrophisicsUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnAstrophisicsUpgrade.Enabled = false;
            this.btnAstrophisicsUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAstrophisicsUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnAstrophisicsUpgrade.Name = "btnAstrophisicsUpgrade";
            this.btnAstrophisicsUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnAstrophisicsUpgrade.TabIndex = 12;
            this.btnAstrophisicsUpgrade.Text = "Ulepsz";
            this.btnAstrophisicsUpgrade.UseVisualStyleBackColor = false;
            this.btnAstrophisicsUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblAstrophisicsDeuteriumCost
            // 
            this.lblAstrophisicsDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisicsDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAstrophisicsDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblAstrophisicsDeuteriumCost.Name = "lblAstrophisicsDeuteriumCost";
            this.lblAstrophisicsDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblAstrophisicsDeuteriumCost.TabIndex = 11;
            this.lblAstrophisicsDeuteriumCost.Text = "deuter";
            this.lblAstrophisicsDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstrophisicsCrystalCost
            // 
            this.lblAstrophisicsCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisicsCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAstrophisicsCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblAstrophisicsCrystalCost.Name = "lblAstrophisicsCrystalCost";
            this.lblAstrophisicsCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblAstrophisicsCrystalCost.TabIndex = 10;
            this.lblAstrophisicsCrystalCost.Text = "kryształ";
            this.lblAstrophisicsCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstrophisicsMetalCost
            // 
            this.lblAstrophisicsMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisicsMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAstrophisicsMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblAstrophisicsMetalCost.Name = "lblAstrophisicsMetalCost";
            this.lblAstrophisicsMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblAstrophisicsMetalCost.TabIndex = 9;
            this.lblAstrophisicsMetalCost.Text = "metal";
            this.lblAstrophisicsMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstrophisicsLevel
            // 
            this.lblAstrophisicsLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisicsLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsLevel.Location = new System.Drawing.Point(320, 10);
            this.lblAstrophisicsLevel.Name = "lblAstrophisicsLevel";
            this.lblAstrophisicsLevel.Size = new System.Drawing.Size(50, 30);
            this.lblAstrophisicsLevel.TabIndex = 8;
            this.lblAstrophisicsLevel.Text = "level";
            this.lblAstrophisicsLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstrophisics
            // 
            this.lblAstrophisics.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisics.Location = new System.Drawing.Point(10, 10);
            this.lblAstrophisics.Name = "lblAstrophisics";
            this.lblAstrophisics.Size = new System.Drawing.Size(300, 30);
            this.lblAstrophisics.TabIndex = 7;
            this.lblAstrophisics.Text = "Astrofizyka";
            this.lblAstrophisics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pIrn
            // 
            this.pIrn.BackColor = System.Drawing.Color.Yellow;
            this.pIrn.Controls.Add(this.lblIrnCollectTime);
            this.pIrn.Controls.Add(this.lblIrnTotalCost);
            this.pIrn.Controls.Add(this.lblIrnTotalDeuteriumCost);
            this.pIrn.Controls.Add(this.lblIrnTimeRemain);
            this.pIrn.Controls.Add(this.lblIrnDuration);
            this.pIrn.Controls.Add(this.btnIrnUpgrade);
            this.pIrn.Controls.Add(this.lblIrnDeuteriumCost);
            this.pIrn.Controls.Add(this.lblIrnCrystalCost);
            this.pIrn.Controls.Add(this.lblIrnMetalCost);
            this.pIrn.Controls.Add(this.lblIrnLevel);
            this.pIrn.Controls.Add(this.lblIrn);
            this.pIrn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pIrn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pIrn.Location = new System.Drawing.Point(3, 653);
            this.pIrn.Name = "pIrn";
            this.pIrn.Size = new System.Drawing.Size(1890, 50);
            this.pIrn.TabIndex = 14;
            // 
            // lblIrnTotalCost
            // 
            this.lblIrnTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrnTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblIrnTotalCost.Name = "lblIrnTotalCost";
            this.lblIrnTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblIrnTotalCost.TabIndex = 42;
            this.lblIrnTotalCost.Text = "surowce razem";
            this.lblIrnTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrnTotalDeuteriumCost
            // 
            this.lblIrnTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrnTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblIrnTotalDeuteriumCost.Name = "lblIrnTotalDeuteriumCost";
            this.lblIrnTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblIrnTotalDeuteriumCost.TabIndex = 41;
            this.lblIrnTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblIrnTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrnTimeRemain
            // 
            this.lblIrnTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIrnTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblIrnTimeRemain.Name = "lblIrnTimeRemain";
            this.lblIrnTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblIrnTimeRemain.TabIndex = 40;
            this.lblIrnTimeRemain.Text = "czas pozostały";
            this.lblIrnTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrnDuration
            // 
            this.lblIrnDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrnDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIrnDuration.Location = new System.Drawing.Point(800, 10);
            this.lblIrnDuration.Name = "lblIrnDuration";
            this.lblIrnDuration.Size = new System.Drawing.Size(130, 30);
            this.lblIrnDuration.TabIndex = 13;
            this.lblIrnDuration.Text = "czas";
            this.lblIrnDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIrnUpgrade
            // 
            this.btnIrnUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnIrnUpgrade.Enabled = false;
            this.btnIrnUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIrnUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIrnUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnIrnUpgrade.Name = "btnIrnUpgrade";
            this.btnIrnUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnIrnUpgrade.TabIndex = 12;
            this.btnIrnUpgrade.Text = "Ulepsz";
            this.btnIrnUpgrade.UseVisualStyleBackColor = false;
            this.btnIrnUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblIrnDeuteriumCost
            // 
            this.lblIrnDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrnDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIrnDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblIrnDeuteriumCost.Name = "lblIrnDeuteriumCost";
            this.lblIrnDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblIrnDeuteriumCost.TabIndex = 11;
            this.lblIrnDeuteriumCost.Text = "deuter";
            this.lblIrnDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrnCrystalCost
            // 
            this.lblIrnCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrnCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIrnCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblIrnCrystalCost.Name = "lblIrnCrystalCost";
            this.lblIrnCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblIrnCrystalCost.TabIndex = 10;
            this.lblIrnCrystalCost.Text = "kryształ";
            this.lblIrnCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrnMetalCost
            // 
            this.lblIrnMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrnMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIrnMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblIrnMetalCost.Name = "lblIrnMetalCost";
            this.lblIrnMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblIrnMetalCost.TabIndex = 9;
            this.lblIrnMetalCost.Text = "metal";
            this.lblIrnMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrnLevel
            // 
            this.lblIrnLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrnLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIrnLevel.Location = new System.Drawing.Point(320, 10);
            this.lblIrnLevel.Name = "lblIrnLevel";
            this.lblIrnLevel.Size = new System.Drawing.Size(50, 30);
            this.lblIrnLevel.TabIndex = 8;
            this.lblIrnLevel.Text = "level";
            this.lblIrnLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrn
            // 
            this.lblIrn.BackColor = System.Drawing.Color.Transparent;
            this.lblIrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIrn.Location = new System.Drawing.Point(10, 10);
            this.lblIrn.Name = "lblIrn";
            this.lblIrn.Size = new System.Drawing.Size(300, 30);
            this.lblIrn.TabIndex = 7;
            this.lblIrn.Text = "Międzygalaktyczna Sieć Badań Naukowych";
            this.lblIrn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPlasmaTechnology
            // 
            this.pPlasmaTechnology.BackColor = System.Drawing.Color.Gold;
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyCollectTime);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyTotalCost);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyTotalDeuteriumCost);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyTimeRemain);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyDuration);
            this.pPlasmaTechnology.Controls.Add(this.btnPlasmaTechnologyUpgrade);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyDeuteriumCost);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyCrystalCost);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyMetalCost);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnologyLevel);
            this.pPlasmaTechnology.Controls.Add(this.lblPlasmaTechnology);
            this.pPlasmaTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPlasmaTechnology.Location = new System.Drawing.Point(3, 603);
            this.pPlasmaTechnology.Name = "pPlasmaTechnology";
            this.pPlasmaTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pPlasmaTechnology.TabIndex = 13;
            // 
            // lblPlasmaTechnologyTotalCost
            // 
            this.lblPlasmaTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblPlasmaTechnologyTotalCost.Name = "lblPlasmaTechnologyTotalCost";
            this.lblPlasmaTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTechnologyTotalCost.TabIndex = 41;
            this.lblPlasmaTechnologyTotalCost.Text = "surowce razem";
            this.lblPlasmaTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTechnologyTotalDeuteriumCost
            // 
            this.lblPlasmaTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblPlasmaTechnologyTotalDeuteriumCost.Name = "lblPlasmaTechnologyTotalDeuteriumCost";
            this.lblPlasmaTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTechnologyTotalDeuteriumCost.TabIndex = 40;
            this.lblPlasmaTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblPlasmaTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTechnologyTimeRemain
            // 
            this.lblPlasmaTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlasmaTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblPlasmaTechnologyTimeRemain.Name = "lblPlasmaTechnologyTimeRemain";
            this.lblPlasmaTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTechnologyTimeRemain.TabIndex = 39;
            this.lblPlasmaTechnologyTimeRemain.Text = "czas pozostały";
            this.lblPlasmaTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTechnologyDuration
            // 
            this.lblPlasmaTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblPlasmaTechnologyDuration.Name = "lblPlasmaTechnologyDuration";
            this.lblPlasmaTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTechnologyDuration.TabIndex = 13;
            this.lblPlasmaTechnologyDuration.Text = "czas";
            this.lblPlasmaTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlasmaTechnologyUpgrade
            // 
            this.btnPlasmaTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnPlasmaTechnologyUpgrade.Enabled = false;
            this.btnPlasmaTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlasmaTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnPlasmaTechnologyUpgrade.Name = "btnPlasmaTechnologyUpgrade";
            this.btnPlasmaTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnPlasmaTechnologyUpgrade.TabIndex = 12;
            this.btnPlasmaTechnologyUpgrade.Text = "Ulepsz";
            this.btnPlasmaTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnPlasmaTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblPlasmaTechnologyDeuteriumCost
            // 
            this.lblPlasmaTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlasmaTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblPlasmaTechnologyDeuteriumCost.Name = "lblPlasmaTechnologyDeuteriumCost";
            this.lblPlasmaTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTechnologyDeuteriumCost.TabIndex = 11;
            this.lblPlasmaTechnologyDeuteriumCost.Text = "deuter";
            this.lblPlasmaTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTechnologyCrystalCost
            // 
            this.lblPlasmaTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlasmaTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblPlasmaTechnologyCrystalCost.Name = "lblPlasmaTechnologyCrystalCost";
            this.lblPlasmaTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTechnologyCrystalCost.TabIndex = 10;
            this.lblPlasmaTechnologyCrystalCost.Text = "kryształ";
            this.lblPlasmaTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTechnologyMetalCost
            // 
            this.lblPlasmaTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlasmaTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblPlasmaTechnologyMetalCost.Name = "lblPlasmaTechnologyMetalCost";
            this.lblPlasmaTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTechnologyMetalCost.TabIndex = 9;
            this.lblPlasmaTechnologyMetalCost.Text = "metal";
            this.lblPlasmaTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTechnologyLevel
            // 
            this.lblPlasmaTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblPlasmaTechnologyLevel.Name = "lblPlasmaTechnologyLevel";
            this.lblPlasmaTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblPlasmaTechnologyLevel.TabIndex = 8;
            this.lblPlasmaTechnologyLevel.Text = "level";
            this.lblPlasmaTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTechnology
            // 
            this.lblPlasmaTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblPlasmaTechnology.Name = "lblPlasmaTechnology";
            this.lblPlasmaTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblPlasmaTechnology.TabIndex = 7;
            this.lblPlasmaTechnology.Text = "Technologia plazmowa";
            this.lblPlasmaTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pIonTechnology
            // 
            this.pIonTechnology.BackColor = System.Drawing.Color.Yellow;
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyCollectTime);
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyTotalCost);
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyTotalDeuteriumCost);
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyTimeRemain);
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyDuration);
            this.pIonTechnology.Controls.Add(this.btnIonTechnologyUpgrade);
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyDeuteriumCost);
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyCrystalCost);
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyMetalCost);
            this.pIonTechnology.Controls.Add(this.lblIonTechnologyLevel);
            this.pIonTechnology.Controls.Add(this.lblIonTechnology);
            this.pIonTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pIonTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pIonTechnology.Location = new System.Drawing.Point(3, 553);
            this.pIonTechnology.Name = "pIonTechnology";
            this.pIonTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pIonTechnology.TabIndex = 12;
            // 
            // lblIonTechnologyTotalCost
            // 
            this.lblIonTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblIonTechnologyTotalCost.Name = "lblIonTechnologyTotalCost";
            this.lblIonTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblIonTechnologyTotalCost.TabIndex = 40;
            this.lblIonTechnologyTotalCost.Text = "surowce razem";
            this.lblIonTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonTechnologyTotalDeuteriumCost
            // 
            this.lblIonTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblIonTechnologyTotalDeuteriumCost.Name = "lblIonTechnologyTotalDeuteriumCost";
            this.lblIonTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblIonTechnologyTotalDeuteriumCost.TabIndex = 39;
            this.lblIonTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblIonTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonTechnologyTimeRemain
            // 
            this.lblIonTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIonTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblIonTechnologyTimeRemain.Name = "lblIonTechnologyTimeRemain";
            this.lblIonTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblIonTechnologyTimeRemain.TabIndex = 38;
            this.lblIonTechnologyTimeRemain.Text = "czas pozostały";
            this.lblIonTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonTechnologyDuration
            // 
            this.lblIonTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIonTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblIonTechnologyDuration.Name = "lblIonTechnologyDuration";
            this.lblIonTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblIonTechnologyDuration.TabIndex = 13;
            this.lblIonTechnologyDuration.Text = "czas";
            this.lblIonTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIonTechnologyUpgrade
            // 
            this.btnIonTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnIonTechnologyUpgrade.Enabled = false;
            this.btnIonTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIonTechnologyUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIonTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnIonTechnologyUpgrade.Name = "btnIonTechnologyUpgrade";
            this.btnIonTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnIonTechnologyUpgrade.TabIndex = 12;
            this.btnIonTechnologyUpgrade.Text = "Ulepsz";
            this.btnIonTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnIonTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblIonTechnologyDeuteriumCost
            // 
            this.lblIonTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIonTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblIonTechnologyDeuteriumCost.Name = "lblIonTechnologyDeuteriumCost";
            this.lblIonTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblIonTechnologyDeuteriumCost.TabIndex = 11;
            this.lblIonTechnologyDeuteriumCost.Text = "deuter";
            this.lblIonTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonTechnologyCrystalCost
            // 
            this.lblIonTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIonTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblIonTechnologyCrystalCost.Name = "lblIonTechnologyCrystalCost";
            this.lblIonTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblIonTechnologyCrystalCost.TabIndex = 10;
            this.lblIonTechnologyCrystalCost.Text = "kryształ";
            this.lblIonTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonTechnologyMetalCost
            // 
            this.lblIonTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIonTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblIonTechnologyMetalCost.Name = "lblIonTechnologyMetalCost";
            this.lblIonTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblIonTechnologyMetalCost.TabIndex = 9;
            this.lblIonTechnologyMetalCost.Text = "metal";
            this.lblIonTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonTechnologyLevel
            // 
            this.lblIonTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIonTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblIonTechnologyLevel.Name = "lblIonTechnologyLevel";
            this.lblIonTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblIonTechnologyLevel.TabIndex = 8;
            this.lblIonTechnologyLevel.Text = "level";
            this.lblIonTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonTechnology
            // 
            this.lblIonTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIonTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblIonTechnology.Name = "lblIonTechnology";
            this.lblIonTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblIonTechnology.TabIndex = 7;
            this.lblIonTechnology.Text = "Technologia jonowa";
            this.lblIonTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLaserTechnology
            // 
            this.pLaserTechnology.BackColor = System.Drawing.Color.Gold;
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyCollectTime);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyTotalCost);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyTotalDeuteriumCost);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyTimeRemain);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyDuration);
            this.pLaserTechnology.Controls.Add(this.btnLaserTechnologyUpgrade);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyDeuteriumCost);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyCrystalCost);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyMetalCost);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnologyLevel);
            this.pLaserTechnology.Controls.Add(this.lblLaserTechnology);
            this.pLaserTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLaserTechnology.Location = new System.Drawing.Point(3, 503);
            this.pLaserTechnology.Name = "pLaserTechnology";
            this.pLaserTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pLaserTechnology.TabIndex = 11;
            // 
            // lblLaserTechnologyTotalCost
            // 
            this.lblLaserTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblLaserTechnologyTotalCost.Name = "lblLaserTechnologyTotalCost";
            this.lblLaserTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLaserTechnologyTotalCost.TabIndex = 39;
            this.lblLaserTechnologyTotalCost.Text = "surowce razem";
            this.lblLaserTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserTechnologyTotalDeuteriumCost
            // 
            this.lblLaserTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblLaserTechnologyTotalDeuteriumCost.Name = "lblLaserTechnologyTotalDeuteriumCost";
            this.lblLaserTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblLaserTechnologyTotalDeuteriumCost.TabIndex = 38;
            this.lblLaserTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblLaserTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserTechnologyTimeRemain
            // 
            this.lblLaserTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLaserTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblLaserTechnologyTimeRemain.Name = "lblLaserTechnologyTimeRemain";
            this.lblLaserTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblLaserTechnologyTimeRemain.TabIndex = 37;
            this.lblLaserTechnologyTimeRemain.Text = "czas pozostały";
            this.lblLaserTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserTechnologyDuration
            // 
            this.lblLaserTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblLaserTechnologyDuration.Name = "lblLaserTechnologyDuration";
            this.lblLaserTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblLaserTechnologyDuration.TabIndex = 13;
            this.lblLaserTechnologyDuration.Text = "czas";
            this.lblLaserTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLaserTechnologyUpgrade
            // 
            this.btnLaserTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnLaserTechnologyUpgrade.Enabled = false;
            this.btnLaserTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLaserTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnLaserTechnologyUpgrade.Name = "btnLaserTechnologyUpgrade";
            this.btnLaserTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnLaserTechnologyUpgrade.TabIndex = 12;
            this.btnLaserTechnologyUpgrade.Text = "Ulepsz";
            this.btnLaserTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnLaserTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblLaserTechnologyDeuteriumCost
            // 
            this.lblLaserTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLaserTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblLaserTechnologyDeuteriumCost.Name = "lblLaserTechnologyDeuteriumCost";
            this.lblLaserTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblLaserTechnologyDeuteriumCost.TabIndex = 11;
            this.lblLaserTechnologyDeuteriumCost.Text = "deuter";
            this.lblLaserTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserTechnologyCrystalCost
            // 
            this.lblLaserTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLaserTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblLaserTechnologyCrystalCost.Name = "lblLaserTechnologyCrystalCost";
            this.lblLaserTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLaserTechnologyCrystalCost.TabIndex = 10;
            this.lblLaserTechnologyCrystalCost.Text = "kryształ";
            this.lblLaserTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserTechnologyMetalCost
            // 
            this.lblLaserTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLaserTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblLaserTechnologyMetalCost.Name = "lblLaserTechnologyMetalCost";
            this.lblLaserTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLaserTechnologyMetalCost.TabIndex = 9;
            this.lblLaserTechnologyMetalCost.Text = "metal";
            this.lblLaserTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserTechnologyLevel
            // 
            this.lblLaserTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblLaserTechnologyLevel.Name = "lblLaserTechnologyLevel";
            this.lblLaserTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblLaserTechnologyLevel.TabIndex = 8;
            this.lblLaserTechnologyLevel.Text = "level";
            this.lblLaserTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserTechnology
            // 
            this.lblLaserTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblLaserTechnology.Name = "lblLaserTechnology";
            this.lblLaserTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblLaserTechnology.TabIndex = 7;
            this.lblLaserTechnology.Text = "Technologia laserowa";
            this.lblLaserTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHyperspaceTechnology
            // 
            this.pHyperspaceTechnology.BackColor = System.Drawing.Color.Yellow;
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyCollectTime);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyTotalCost);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyTotalDeuteriumCost);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyTimeRemain);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyDuration);
            this.pHyperspaceTechnology.Controls.Add(this.btnHyperspaceTechnologyUpgrade);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyDeuteriumCost);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyCrystalCost);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyMetalCost);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnologyLevel);
            this.pHyperspaceTechnology.Controls.Add(this.lblHyperspaceTechnology);
            this.pHyperspaceTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHyperspaceTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pHyperspaceTechnology.Location = new System.Drawing.Point(3, 453);
            this.pHyperspaceTechnology.Name = "pHyperspaceTechnology";
            this.pHyperspaceTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pHyperspaceTechnology.TabIndex = 10;
            // 
            // lblHyperspaceTechnologyTotalCost
            // 
            this.lblHyperspaceTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblHyperspaceTechnologyTotalCost.Name = "lblHyperspaceTechnologyTotalCost";
            this.lblHyperspaceTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceTechnologyTotalCost.TabIndex = 38;
            this.lblHyperspaceTechnologyTotalCost.Text = "surowce razem";
            this.lblHyperspaceTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceTechnologyTotalDeuteriumCost
            // 
            this.lblHyperspaceTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblHyperspaceTechnologyTotalDeuteriumCost.Name = "lblHyperspaceTechnologyTotalDeuteriumCost";
            this.lblHyperspaceTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceTechnologyTotalDeuteriumCost.TabIndex = 37;
            this.lblHyperspaceTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblHyperspaceTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceTechnologyTimeRemain
            // 
            this.lblHyperspaceTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHyperspaceTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblHyperspaceTechnologyTimeRemain.Name = "lblHyperspaceTechnologyTimeRemain";
            this.lblHyperspaceTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceTechnologyTimeRemain.TabIndex = 36;
            this.lblHyperspaceTechnologyTimeRemain.Text = "czas pozostały";
            this.lblHyperspaceTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceTechnologyDuration
            // 
            this.lblHyperspaceTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHyperspaceTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblHyperspaceTechnologyDuration.Name = "lblHyperspaceTechnologyDuration";
            this.lblHyperspaceTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceTechnologyDuration.TabIndex = 13;
            this.lblHyperspaceTechnologyDuration.Text = "czas";
            this.lblHyperspaceTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHyperspaceTechnologyUpgrade
            // 
            this.btnHyperspaceTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnHyperspaceTechnologyUpgrade.Enabled = false;
            this.btnHyperspaceTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHyperspaceTechnologyUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHyperspaceTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnHyperspaceTechnologyUpgrade.Name = "btnHyperspaceTechnologyUpgrade";
            this.btnHyperspaceTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnHyperspaceTechnologyUpgrade.TabIndex = 12;
            this.btnHyperspaceTechnologyUpgrade.Text = "Ulepsz";
            this.btnHyperspaceTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnHyperspaceTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblHyperspaceTechnologyDeuteriumCost
            // 
            this.lblHyperspaceTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHyperspaceTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblHyperspaceTechnologyDeuteriumCost.Name = "lblHyperspaceTechnologyDeuteriumCost";
            this.lblHyperspaceTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceTechnologyDeuteriumCost.TabIndex = 11;
            this.lblHyperspaceTechnologyDeuteriumCost.Text = "deuter";
            this.lblHyperspaceTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceTechnologyCrystalCost
            // 
            this.lblHyperspaceTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHyperspaceTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblHyperspaceTechnologyCrystalCost.Name = "lblHyperspaceTechnologyCrystalCost";
            this.lblHyperspaceTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceTechnologyCrystalCost.TabIndex = 10;
            this.lblHyperspaceTechnologyCrystalCost.Text = "kryształ";
            this.lblHyperspaceTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceTechnologyMetalCost
            // 
            this.lblHyperspaceTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHyperspaceTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblHyperspaceTechnologyMetalCost.Name = "lblHyperspaceTechnologyMetalCost";
            this.lblHyperspaceTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceTechnologyMetalCost.TabIndex = 9;
            this.lblHyperspaceTechnologyMetalCost.Text = "metal";
            this.lblHyperspaceTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceTechnologyLevel
            // 
            this.lblHyperspaceTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHyperspaceTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblHyperspaceTechnologyLevel.Name = "lblHyperspaceTechnologyLevel";
            this.lblHyperspaceTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblHyperspaceTechnologyLevel.TabIndex = 8;
            this.lblHyperspaceTechnologyLevel.Text = "level";
            this.lblHyperspaceTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceTechnology
            // 
            this.lblHyperspaceTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHyperspaceTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblHyperspaceTechnology.Name = "lblHyperspaceTechnology";
            this.lblHyperspaceTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblHyperspaceTechnology.TabIndex = 7;
            this.lblHyperspaceTechnology.Text = "Technologia nadprzestrzenna";
            this.lblHyperspaceTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEnergyTechnology
            // 
            this.pEnergyTechnology.BackColor = System.Drawing.Color.Gold;
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyCollectTime);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyTotalCost);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyTotalDeuteriumCost);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyTimeRemain);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyDuration);
            this.pEnergyTechnology.Controls.Add(this.btnEnergyTechnologyUpgrade);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyDeuteriumCost);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyCrystalCost);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyMetalCost);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnologyLevel);
            this.pEnergyTechnology.Controls.Add(this.lblEnergyTechnology);
            this.pEnergyTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEnergyTechnology.Location = new System.Drawing.Point(3, 403);
            this.pEnergyTechnology.Name = "pEnergyTechnology";
            this.pEnergyTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pEnergyTechnology.TabIndex = 9;
            // 
            // lblEnergyTechnologyTotalCost
            // 
            this.lblEnergyTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblEnergyTechnologyTotalCost.Name = "lblEnergyTechnologyTotalCost";
            this.lblEnergyTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblEnergyTechnologyTotalCost.TabIndex = 37;
            this.lblEnergyTechnologyTotalCost.Text = "surowce razem";
            this.lblEnergyTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyTechnologyTotalDeuteriumCost
            // 
            this.lblEnergyTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblEnergyTechnologyTotalDeuteriumCost.Name = "lblEnergyTechnologyTotalDeuteriumCost";
            this.lblEnergyTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblEnergyTechnologyTotalDeuteriumCost.TabIndex = 36;
            this.lblEnergyTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblEnergyTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyTechnologyTimeRemain
            // 
            this.lblEnergyTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnergyTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblEnergyTechnologyTimeRemain.Name = "lblEnergyTechnologyTimeRemain";
            this.lblEnergyTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblEnergyTechnologyTimeRemain.TabIndex = 35;
            this.lblEnergyTechnologyTimeRemain.Text = "czas pozostały";
            this.lblEnergyTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyTechnologyDuration
            // 
            this.lblEnergyTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblEnergyTechnologyDuration.Name = "lblEnergyTechnologyDuration";
            this.lblEnergyTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblEnergyTechnologyDuration.TabIndex = 13;
            this.lblEnergyTechnologyDuration.Text = "czas";
            this.lblEnergyTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnergyTechnologyUpgrade
            // 
            this.btnEnergyTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnEnergyTechnologyUpgrade.Enabled = false;
            this.btnEnergyTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnergyTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnEnergyTechnologyUpgrade.Name = "btnEnergyTechnologyUpgrade";
            this.btnEnergyTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnEnergyTechnologyUpgrade.TabIndex = 12;
            this.btnEnergyTechnologyUpgrade.Text = "Ulepsz";
            this.btnEnergyTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnEnergyTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblEnergyTechnologyDeuteriumCost
            // 
            this.lblEnergyTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEnergyTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblEnergyTechnologyDeuteriumCost.Name = "lblEnergyTechnologyDeuteriumCost";
            this.lblEnergyTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblEnergyTechnologyDeuteriumCost.TabIndex = 11;
            this.lblEnergyTechnologyDeuteriumCost.Text = "deuter";
            this.lblEnergyTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyTechnologyCrystalCost
            // 
            this.lblEnergyTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEnergyTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblEnergyTechnologyCrystalCost.Name = "lblEnergyTechnologyCrystalCost";
            this.lblEnergyTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblEnergyTechnologyCrystalCost.TabIndex = 10;
            this.lblEnergyTechnologyCrystalCost.Text = "kryształ";
            this.lblEnergyTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyTechnologyMetalCost
            // 
            this.lblEnergyTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEnergyTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblEnergyTechnologyMetalCost.Name = "lblEnergyTechnologyMetalCost";
            this.lblEnergyTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblEnergyTechnologyMetalCost.TabIndex = 9;
            this.lblEnergyTechnologyMetalCost.Text = "metal";
            this.lblEnergyTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyTechnologyLevel
            // 
            this.lblEnergyTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblEnergyTechnologyLevel.Name = "lblEnergyTechnologyLevel";
            this.lblEnergyTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblEnergyTechnologyLevel.TabIndex = 8;
            this.lblEnergyTechnologyLevel.Text = "level";
            this.lblEnergyTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyTechnology
            // 
            this.lblEnergyTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblEnergyTechnology.Name = "lblEnergyTechnology";
            this.lblEnergyTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblEnergyTechnology.TabIndex = 7;
            this.lblEnergyTechnology.Text = "Technologia energetyczna";
            this.lblEnergyTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pArmourTechnology
            // 
            this.pArmourTechnology.BackColor = System.Drawing.Color.Yellow;
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyCollectTime);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyTotalCost);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyTotalDeuteriumCost);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyTimeRemain);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyDuration);
            this.pArmourTechnology.Controls.Add(this.btnArmourTechnologyUpgrade);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyDeuteriumCost);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyCrystalCost);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyMetalCost);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnologyLevel);
            this.pArmourTechnology.Controls.Add(this.lblArmourTechnology);
            this.pArmourTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pArmourTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pArmourTechnology.Location = new System.Drawing.Point(3, 353);
            this.pArmourTechnology.Name = "pArmourTechnology";
            this.pArmourTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pArmourTechnology.TabIndex = 8;
            // 
            // lblArmourTechnologyTotalCost
            // 
            this.lblArmourTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblArmourTechnologyTotalCost.Name = "lblArmourTechnologyTotalCost";
            this.lblArmourTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblArmourTechnologyTotalCost.TabIndex = 36;
            this.lblArmourTechnologyTotalCost.Text = "surowce razem";
            this.lblArmourTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmourTechnologyTotalDeuteriumCost
            // 
            this.lblArmourTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblArmourTechnologyTotalDeuteriumCost.Name = "lblArmourTechnologyTotalDeuteriumCost";
            this.lblArmourTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblArmourTechnologyTotalDeuteriumCost.TabIndex = 35;
            this.lblArmourTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblArmourTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmourTechnologyTimeRemain
            // 
            this.lblArmourTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArmourTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblArmourTechnologyTimeRemain.Name = "lblArmourTechnologyTimeRemain";
            this.lblArmourTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblArmourTechnologyTimeRemain.TabIndex = 34;
            this.lblArmourTechnologyTimeRemain.Text = "czas pozostały";
            this.lblArmourTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmourTechnologyDuration
            // 
            this.lblArmourTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArmourTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblArmourTechnologyDuration.Name = "lblArmourTechnologyDuration";
            this.lblArmourTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblArmourTechnologyDuration.TabIndex = 13;
            this.lblArmourTechnologyDuration.Text = "czas";
            this.lblArmourTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArmourTechnologyUpgrade
            // 
            this.btnArmourTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnArmourTechnologyUpgrade.Enabled = false;
            this.btnArmourTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArmourTechnologyUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArmourTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnArmourTechnologyUpgrade.Name = "btnArmourTechnologyUpgrade";
            this.btnArmourTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnArmourTechnologyUpgrade.TabIndex = 12;
            this.btnArmourTechnologyUpgrade.Text = "Ulepsz";
            this.btnArmourTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnArmourTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblArmourTechnologyDeuteriumCost
            // 
            this.lblArmourTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblArmourTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblArmourTechnologyDeuteriumCost.Name = "lblArmourTechnologyDeuteriumCost";
            this.lblArmourTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblArmourTechnologyDeuteriumCost.TabIndex = 11;
            this.lblArmourTechnologyDeuteriumCost.Text = "deuter";
            this.lblArmourTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmourTechnologyCrystalCost
            // 
            this.lblArmourTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblArmourTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblArmourTechnologyCrystalCost.Name = "lblArmourTechnologyCrystalCost";
            this.lblArmourTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblArmourTechnologyCrystalCost.TabIndex = 10;
            this.lblArmourTechnologyCrystalCost.Text = "kryształ";
            this.lblArmourTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmourTechnologyMetalCost
            // 
            this.lblArmourTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblArmourTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblArmourTechnologyMetalCost.Name = "lblArmourTechnologyMetalCost";
            this.lblArmourTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblArmourTechnologyMetalCost.TabIndex = 9;
            this.lblArmourTechnologyMetalCost.Text = "metal";
            this.lblArmourTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmourTechnologyLevel
            // 
            this.lblArmourTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArmourTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblArmourTechnologyLevel.Name = "lblArmourTechnologyLevel";
            this.lblArmourTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblArmourTechnologyLevel.TabIndex = 8;
            this.lblArmourTechnologyLevel.Text = "level";
            this.lblArmourTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmourTechnology
            // 
            this.lblArmourTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArmourTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblArmourTechnology.Name = "lblArmourTechnology";
            this.lblArmourTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblArmourTechnology.TabIndex = 7;
            this.lblArmourTechnology.Text = "Opancerzenie";
            this.lblArmourTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pShieldingTechnology
            // 
            this.pShieldingTechnology.BackColor = System.Drawing.Color.Gold;
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyCollectTime);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyTotalCost);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyTotalDeuteriumCost);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyTimeRemain);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyDuration);
            this.pShieldingTechnology.Controls.Add(this.btnShieldingTechnologyUpgrade);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyDeuteriumCost);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyCrystalCost);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyMetalCost);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnologyLevel);
            this.pShieldingTechnology.Controls.Add(this.lblShieldingTechnology);
            this.pShieldingTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pShieldingTechnology.Location = new System.Drawing.Point(3, 303);
            this.pShieldingTechnology.Name = "pShieldingTechnology";
            this.pShieldingTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pShieldingTechnology.TabIndex = 7;
            // 
            // lblShieldingTechnologyTotalCost
            // 
            this.lblShieldingTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblShieldingTechnologyTotalCost.Name = "lblShieldingTechnologyTotalCost";
            this.lblShieldingTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblShieldingTechnologyTotalCost.TabIndex = 35;
            this.lblShieldingTechnologyTotalCost.Text = "surowce razem";
            this.lblShieldingTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShieldingTechnologyTotalDeuteriumCost
            // 
            this.lblShieldingTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblShieldingTechnologyTotalDeuteriumCost.Name = "lblShieldingTechnologyTotalDeuteriumCost";
            this.lblShieldingTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblShieldingTechnologyTotalDeuteriumCost.TabIndex = 34;
            this.lblShieldingTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblShieldingTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShieldingTechnologyTimeRemain
            // 
            this.lblShieldingTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShieldingTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblShieldingTechnologyTimeRemain.Name = "lblShieldingTechnologyTimeRemain";
            this.lblShieldingTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblShieldingTechnologyTimeRemain.TabIndex = 33;
            this.lblShieldingTechnologyTimeRemain.Text = "czas pozostały";
            this.lblShieldingTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShieldingTechnologyDuration
            // 
            this.lblShieldingTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblShieldingTechnologyDuration.Name = "lblShieldingTechnologyDuration";
            this.lblShieldingTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblShieldingTechnologyDuration.TabIndex = 13;
            this.lblShieldingTechnologyDuration.Text = "czas";
            this.lblShieldingTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShieldingTechnologyUpgrade
            // 
            this.btnShieldingTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnShieldingTechnologyUpgrade.Enabled = false;
            this.btnShieldingTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShieldingTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnShieldingTechnologyUpgrade.Name = "btnShieldingTechnologyUpgrade";
            this.btnShieldingTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnShieldingTechnologyUpgrade.TabIndex = 12;
            this.btnShieldingTechnologyUpgrade.Text = "Ulepsz";
            this.btnShieldingTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnShieldingTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblShieldingTechnologyDeuteriumCost
            // 
            this.lblShieldingTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShieldingTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblShieldingTechnologyDeuteriumCost.Name = "lblShieldingTechnologyDeuteriumCost";
            this.lblShieldingTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblShieldingTechnologyDeuteriumCost.TabIndex = 11;
            this.lblShieldingTechnologyDeuteriumCost.Text = "deuter";
            this.lblShieldingTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShieldingTechnologyCrystalCost
            // 
            this.lblShieldingTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShieldingTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblShieldingTechnologyCrystalCost.Name = "lblShieldingTechnologyCrystalCost";
            this.lblShieldingTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblShieldingTechnologyCrystalCost.TabIndex = 10;
            this.lblShieldingTechnologyCrystalCost.Text = "kryształ";
            this.lblShieldingTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShieldingTechnologyMetalCost
            // 
            this.lblShieldingTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShieldingTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblShieldingTechnologyMetalCost.Name = "lblShieldingTechnologyMetalCost";
            this.lblShieldingTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblShieldingTechnologyMetalCost.TabIndex = 9;
            this.lblShieldingTechnologyMetalCost.Text = "metal";
            this.lblShieldingTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShieldingTechnologyLevel
            // 
            this.lblShieldingTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblShieldingTechnologyLevel.Name = "lblShieldingTechnologyLevel";
            this.lblShieldingTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblShieldingTechnologyLevel.TabIndex = 8;
            this.lblShieldingTechnologyLevel.Text = "level";
            this.lblShieldingTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShieldingTechnology
            // 
            this.lblShieldingTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblShieldingTechnology.Name = "lblShieldingTechnology";
            this.lblShieldingTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblShieldingTechnology.TabIndex = 7;
            this.lblShieldingTechnology.Text = "Technologia ochronna";
            this.lblShieldingTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pWeaponsTechnology
            // 
            this.pWeaponsTechnology.BackColor = System.Drawing.Color.Yellow;
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyCollectTime);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyTotalCost);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyTotalDeuteriumCost);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyTimeRemian);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyDuration);
            this.pWeaponsTechnology.Controls.Add(this.btnWeapeonsTechnologyUpgrade);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyDeuteriumCost);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyCrystalCost);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyMetalCost);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnologyLevel);
            this.pWeaponsTechnology.Controls.Add(this.lblWeaponsTechnology);
            this.pWeaponsTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pWeaponsTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pWeaponsTechnology.Location = new System.Drawing.Point(3, 253);
            this.pWeaponsTechnology.Name = "pWeaponsTechnology";
            this.pWeaponsTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pWeaponsTechnology.TabIndex = 6;
            // 
            // lblWeaponsTechnologyTotalCost
            // 
            this.lblWeaponsTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblWeaponsTechnologyTotalCost.Name = "lblWeaponsTechnologyTotalCost";
            this.lblWeaponsTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblWeaponsTechnologyTotalCost.TabIndex = 34;
            this.lblWeaponsTechnologyTotalCost.Text = "surowce razem";
            this.lblWeaponsTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeaponsTechnologyTotalDeuteriumCost
            // 
            this.lblWeaponsTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblWeaponsTechnologyTotalDeuteriumCost.Name = "lblWeaponsTechnologyTotalDeuteriumCost";
            this.lblWeaponsTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblWeaponsTechnologyTotalDeuteriumCost.TabIndex = 33;
            this.lblWeaponsTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblWeaponsTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeaponsTechnologyTimeRemian
            // 
            this.lblWeaponsTechnologyTimeRemian.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyTimeRemian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyTimeRemian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeaponsTechnologyTimeRemian.Location = new System.Drawing.Point(1080, 10);
            this.lblWeaponsTechnologyTimeRemian.Name = "lblWeaponsTechnologyTimeRemian";
            this.lblWeaponsTechnologyTimeRemian.Size = new System.Drawing.Size(130, 30);
            this.lblWeaponsTechnologyTimeRemian.TabIndex = 32;
            this.lblWeaponsTechnologyTimeRemian.Text = "czas pozostały";
            this.lblWeaponsTechnologyTimeRemian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeapeonsTechnologyDuration
            // 
            this.lblWeaponsTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeaponsTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblWeaponsTechnologyDuration.Name = "lblWeapeonsTechnologyDuration";
            this.lblWeaponsTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblWeaponsTechnologyDuration.TabIndex = 13;
            this.lblWeaponsTechnologyDuration.Text = "czas";
            this.lblWeaponsTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWeapeonsTechnologyUpgrade
            // 
            this.btnWeapeonsTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnWeapeonsTechnologyUpgrade.Enabled = false;
            this.btnWeapeonsTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWeapeonsTechnologyUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWeapeonsTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnWeapeonsTechnologyUpgrade.Name = "btnWeapeonsTechnologyUpgrade";
            this.btnWeapeonsTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnWeapeonsTechnologyUpgrade.TabIndex = 12;
            this.btnWeapeonsTechnologyUpgrade.Text = "Ulepsz";
            this.btnWeapeonsTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnWeapeonsTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblWeapeonsTechnologyDeuteriumCost
            // 
            this.lblWeaponsTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWeaponsTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblWeaponsTechnologyDeuteriumCost.Name = "lblWeapeonsTechnologyDeuteriumCost";
            this.lblWeaponsTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblWeaponsTechnologyDeuteriumCost.TabIndex = 11;
            this.lblWeaponsTechnologyDeuteriumCost.Text = "deuter";
            this.lblWeaponsTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeapeonsTechnologyCrystalCost
            // 
            this.lblWeaponsTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWeaponsTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblWeaponsTechnologyCrystalCost.Name = "lblWeapeonsTechnologyCrystalCost";
            this.lblWeaponsTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblWeaponsTechnologyCrystalCost.TabIndex = 10;
            this.lblWeaponsTechnologyCrystalCost.Text = "kryształ";
            this.lblWeaponsTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeapeonsTechnologyMetalCost
            // 
            this.lblWeaponsTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWeaponsTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblWeaponsTechnologyMetalCost.Name = "lblWeapeonsTechnologyMetalCost";
            this.lblWeaponsTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblWeaponsTechnologyMetalCost.TabIndex = 9;
            this.lblWeaponsTechnologyMetalCost.Text = "metal";
            this.lblWeaponsTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeapeonsTechnologyLevel
            // 
            this.lblWeaponsTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeaponsTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblWeaponsTechnologyLevel.Name = "lblWeapeonsTechnologyLevel";
            this.lblWeaponsTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblWeaponsTechnologyLevel.TabIndex = 8;
            this.lblWeaponsTechnologyLevel.Text = "level";
            this.lblWeaponsTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeapeonsTechnology
            // 
            this.lblWeaponsTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWeaponsTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblWeaponsTechnology.Name = "lblWeapeonsTechnology";
            this.lblWeaponsTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblWeaponsTechnology.TabIndex = 7;
            this.lblWeaponsTechnology.Text = "Technologia bojowa";
            this.lblWeaponsTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHyperspaceDrive
            // 
            this.pHyperspaceDrive.BackColor = System.Drawing.Color.Gold;
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveCollectTime);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveTotalCost);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveTotalDeuteriumCost);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveTimeRemain);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveDuration);
            this.pHyperspaceDrive.Controls.Add(this.btnHyperspaceDriveUpgrade);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveDeuteriumCost);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveCrystalCost);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveMetalCost);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDriveLevel);
            this.pHyperspaceDrive.Controls.Add(this.lblHyperspaceDrive);
            this.pHyperspaceDrive.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHyperspaceDrive.Location = new System.Drawing.Point(3, 203);
            this.pHyperspaceDrive.Name = "pHyperspaceDrive";
            this.pHyperspaceDrive.Size = new System.Drawing.Size(1890, 50);
            this.pHyperspaceDrive.TabIndex = 5;
            // 
            // lblHyperspaceDriveTotalCost
            // 
            this.lblHyperspaceDriveTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDriveTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblHyperspaceDriveTotalCost.Name = "lblHyperspaceDriveTotalCost";
            this.lblHyperspaceDriveTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceDriveTotalCost.TabIndex = 33;
            this.lblHyperspaceDriveTotalCost.Text = "surowce razem";
            this.lblHyperspaceDriveTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceDriveTotalDeuteriumCost
            // 
            this.lblHyperspaceDriveTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDriveTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblHyperspaceDriveTotalDeuteriumCost.Name = "lblHyperspaceDriveTotalDeuteriumCost";
            this.lblHyperspaceDriveTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceDriveTotalDeuteriumCost.TabIndex = 32;
            this.lblHyperspaceDriveTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblHyperspaceDriveTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceDriveTimeRemain
            // 
            this.lblHyperspaceDriveTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHyperspaceDriveTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblHyperspaceDriveTimeRemain.Name = "lblHyperspaceDriveTimeRemain";
            this.lblHyperspaceDriveTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceDriveTimeRemain.TabIndex = 31;
            this.lblHyperspaceDriveTimeRemain.Text = "czas pozostały";
            this.lblHyperspaceDriveTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceDriveDuration
            // 
            this.lblHyperspaceDriveDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDriveDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveDuration.Location = new System.Drawing.Point(800, 10);
            this.lblHyperspaceDriveDuration.Name = "lblHyperspaceDriveDuration";
            this.lblHyperspaceDriveDuration.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceDriveDuration.TabIndex = 13;
            this.lblHyperspaceDriveDuration.Text = "czas";
            this.lblHyperspaceDriveDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHyperspaceDriveUpgrade
            // 
            this.btnHyperspaceDriveUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnHyperspaceDriveUpgrade.Enabled = false;
            this.btnHyperspaceDriveUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHyperspaceDriveUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnHyperspaceDriveUpgrade.Name = "btnHyperspaceDriveUpgrade";
            this.btnHyperspaceDriveUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnHyperspaceDriveUpgrade.TabIndex = 12;
            this.btnHyperspaceDriveUpgrade.Text = "Ulepsz";
            this.btnHyperspaceDriveUpgrade.UseVisualStyleBackColor = false;
            this.btnHyperspaceDriveUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblHyperspaceDriveDeuteriumCost
            // 
            this.lblHyperspaceDriveDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDriveDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHyperspaceDriveDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblHyperspaceDriveDeuteriumCost.Name = "lblHyperspaceDriveDeuteriumCost";
            this.lblHyperspaceDriveDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceDriveDeuteriumCost.TabIndex = 11;
            this.lblHyperspaceDriveDeuteriumCost.Text = "deuter";
            this.lblHyperspaceDriveDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceDriveCrystalCost
            // 
            this.lblHyperspaceDriveCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDriveCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHyperspaceDriveCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblHyperspaceDriveCrystalCost.Name = "lblHyperspaceDriveCrystalCost";
            this.lblHyperspaceDriveCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceDriveCrystalCost.TabIndex = 10;
            this.lblHyperspaceDriveCrystalCost.Text = "kryształ";
            this.lblHyperspaceDriveCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceDriveMetalCost
            // 
            this.lblHyperspaceDriveMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDriveMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHyperspaceDriveMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblHyperspaceDriveMetalCost.Name = "lblHyperspaceDriveMetalCost";
            this.lblHyperspaceDriveMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceDriveMetalCost.TabIndex = 9;
            this.lblHyperspaceDriveMetalCost.Text = "metal";
            this.lblHyperspaceDriveMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceDriveLevel
            // 
            this.lblHyperspaceDriveLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDriveLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveLevel.Location = new System.Drawing.Point(320, 10);
            this.lblHyperspaceDriveLevel.Name = "lblHyperspaceDriveLevel";
            this.lblHyperspaceDriveLevel.Size = new System.Drawing.Size(50, 30);
            this.lblHyperspaceDriveLevel.TabIndex = 8;
            this.lblHyperspaceDriveLevel.Text = "level";
            this.lblHyperspaceDriveLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceDrive
            // 
            this.lblHyperspaceDrive.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDrive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDrive.Location = new System.Drawing.Point(10, 10);
            this.lblHyperspaceDrive.Name = "lblHyperspaceDrive";
            this.lblHyperspaceDrive.Size = new System.Drawing.Size(300, 30);
            this.lblHyperspaceDrive.TabIndex = 7;
            this.lblHyperspaceDrive.Text = "Napęd nadprzestrzenny";
            this.lblHyperspaceDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pImpulseDrive
            // 
            this.pImpulseDrive.BackColor = System.Drawing.Color.Yellow;
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveCollectTime);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveTotalCost);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveTotalDeuteriumCost);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveTimeRemain);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveDuration);
            this.pImpulseDrive.Controls.Add(this.btnImpulseDriveUpgrade);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveDeuteriumCost);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveCrystalCost);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveMetalCost);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDriveLevel);
            this.pImpulseDrive.Controls.Add(this.lblImpulseDrive);
            this.pImpulseDrive.Dock = System.Windows.Forms.DockStyle.Top;
            this.pImpulseDrive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pImpulseDrive.Location = new System.Drawing.Point(3, 153);
            this.pImpulseDrive.Name = "pImpulseDrive";
            this.pImpulseDrive.Size = new System.Drawing.Size(1890, 50);
            this.pImpulseDrive.TabIndex = 4;
            // 
            // lblImpulseDriveTotalCost
            // 
            this.lblImpulseDriveTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDriveTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblImpulseDriveTotalCost.Name = "lblImpulseDriveTotalCost";
            this.lblImpulseDriveTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblImpulseDriveTotalCost.TabIndex = 32;
            this.lblImpulseDriveTotalCost.Text = "surowce razem";
            this.lblImpulseDriveTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpulseDriveTotalDeuteriumCost
            // 
            this.lblImpulseDriveTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDriveTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblImpulseDriveTotalDeuteriumCost.Name = "lblImpulseDriveTotalDeuteriumCost";
            this.lblImpulseDriveTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblImpulseDriveTotalDeuteriumCost.TabIndex = 31;
            this.lblImpulseDriveTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblImpulseDriveTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpulseDriveTimeRemain
            // 
            this.lblImpulseDriveTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImpulseDriveTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblImpulseDriveTimeRemain.Name = "lblImpulseDriveTimeRemain";
            this.lblImpulseDriveTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblImpulseDriveTimeRemain.TabIndex = 30;
            this.lblImpulseDriveTimeRemain.Text = "czas pozostały";
            this.lblImpulseDriveTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpulseDriveDuration
            // 
            this.lblImpulseDriveDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDriveDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImpulseDriveDuration.Location = new System.Drawing.Point(800, 10);
            this.lblImpulseDriveDuration.Name = "lblImpulseDriveDuration";
            this.lblImpulseDriveDuration.Size = new System.Drawing.Size(130, 30);
            this.lblImpulseDriveDuration.TabIndex = 13;
            this.lblImpulseDriveDuration.Text = "czas";
            this.lblImpulseDriveDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImpulseDriveUpgrade
            // 
            this.btnImpulseDriveUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnImpulseDriveUpgrade.Enabled = false;
            this.btnImpulseDriveUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImpulseDriveUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImpulseDriveUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnImpulseDriveUpgrade.Name = "btnImpulseDriveUpgrade";
            this.btnImpulseDriveUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnImpulseDriveUpgrade.TabIndex = 12;
            this.btnImpulseDriveUpgrade.Text = "Ulepsz";
            this.btnImpulseDriveUpgrade.UseVisualStyleBackColor = false;
            this.btnImpulseDriveUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblImpulseDriveDeuteriumCost
            // 
            this.lblImpulseDriveDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDriveDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblImpulseDriveDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblImpulseDriveDeuteriumCost.Name = "lblImpulseDriveDeuteriumCost";
            this.lblImpulseDriveDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblImpulseDriveDeuteriumCost.TabIndex = 11;
            this.lblImpulseDriveDeuteriumCost.Text = "deuter";
            this.lblImpulseDriveDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpulseDriveCrystalCost
            // 
            this.lblImpulseDriveCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDriveCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblImpulseDriveCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblImpulseDriveCrystalCost.Name = "lblImpulseDriveCrystalCost";
            this.lblImpulseDriveCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblImpulseDriveCrystalCost.TabIndex = 10;
            this.lblImpulseDriveCrystalCost.Text = "kryształ";
            this.lblImpulseDriveCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpulseDriveMetalCost
            // 
            this.lblImpulseDriveMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDriveMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblImpulseDriveMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblImpulseDriveMetalCost.Name = "lblImpulseDriveMetalCost";
            this.lblImpulseDriveMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblImpulseDriveMetalCost.TabIndex = 9;
            this.lblImpulseDriveMetalCost.Text = "metal";
            this.lblImpulseDriveMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpulseDriveLevel
            // 
            this.lblImpulseDriveLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDriveLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImpulseDriveLevel.Location = new System.Drawing.Point(320, 10);
            this.lblImpulseDriveLevel.Name = "lblImpulseDriveLevel";
            this.lblImpulseDriveLevel.Size = new System.Drawing.Size(50, 30);
            this.lblImpulseDriveLevel.TabIndex = 8;
            this.lblImpulseDriveLevel.Text = "level";
            this.lblImpulseDriveLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpulseDrive
            // 
            this.lblImpulseDrive.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDrive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDrive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImpulseDrive.Location = new System.Drawing.Point(10, 10);
            this.lblImpulseDrive.Name = "lblImpulseDrive";
            this.lblImpulseDrive.Size = new System.Drawing.Size(300, 30);
            this.lblImpulseDrive.TabIndex = 7;
            this.lblImpulseDrive.Text = "Napęd impulsowy";
            this.lblImpulseDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCombustionDrive
            // 
            this.pCombustionDrive.BackColor = System.Drawing.Color.Gold;
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveCollectTime);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveTotalCost);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveTotalDeuteriumCost);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveTimeRemain);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveDuration);
            this.pCombustionDrive.Controls.Add(this.btnCombustionDriveUpgrade);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveDeuteriumCost);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveCrystalCost);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveMetalCost);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDriveLevel);
            this.pCombustionDrive.Controls.Add(this.lblCombustionDrive);
            this.pCombustionDrive.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCombustionDrive.Location = new System.Drawing.Point(3, 103);
            this.pCombustionDrive.Name = "pCombustionDrive";
            this.pCombustionDrive.Size = new System.Drawing.Size(1890, 50);
            this.pCombustionDrive.TabIndex = 3;
            // 
            // lblCombustionDriveTotalCost
            // 
            this.lblCombustionDriveTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDriveTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblCombustionDriveTotalCost.Name = "lblCombustionDriveTotalCost";
            this.lblCombustionDriveTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCombustionDriveTotalCost.TabIndex = 31;
            this.lblCombustionDriveTotalCost.Text = "surowce razem";
            this.lblCombustionDriveTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombustionDriveTotalDeuteriumCost
            // 
            this.lblCombustionDriveTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDriveTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblCombustionDriveTotalDeuteriumCost.Name = "lblCombustionDriveTotalDeuteriumCost";
            this.lblCombustionDriveTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblCombustionDriveTotalDeuteriumCost.TabIndex = 30;
            this.lblCombustionDriveTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblCombustionDriveTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombustionDriveTimeRemain
            // 
            this.lblCombustionDriveTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCombustionDriveTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblCombustionDriveTimeRemain.Name = "lblCombustionDriveTimeRemain";
            this.lblCombustionDriveTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblCombustionDriveTimeRemain.TabIndex = 29;
            this.lblCombustionDriveTimeRemain.Text = "czas pozostały";
            this.lblCombustionDriveTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombustionDriveDuration
            // 
            this.lblCombustionDriveDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDriveDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveDuration.Location = new System.Drawing.Point(800, 10);
            this.lblCombustionDriveDuration.Name = "lblCombustionDriveDuration";
            this.lblCombustionDriveDuration.Size = new System.Drawing.Size(130, 30);
            this.lblCombustionDriveDuration.TabIndex = 13;
            this.lblCombustionDriveDuration.Text = "czas";
            this.lblCombustionDriveDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCombustionDriveUpgrade
            // 
            this.btnCombustionDriveUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnCombustionDriveUpgrade.Enabled = false;
            this.btnCombustionDriveUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCombustionDriveUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnCombustionDriveUpgrade.Name = "btnCombustionDriveUpgrade";
            this.btnCombustionDriveUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnCombustionDriveUpgrade.TabIndex = 12;
            this.btnCombustionDriveUpgrade.Text = "Ulepsz";
            this.btnCombustionDriveUpgrade.UseVisualStyleBackColor = false;
            this.btnCombustionDriveUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblCombustionDriveDeuteriumCost
            // 
            this.lblCombustionDriveDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDriveDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCombustionDriveDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblCombustionDriveDeuteriumCost.Name = "lblCombustionDriveDeuteriumCost";
            this.lblCombustionDriveDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblCombustionDriveDeuteriumCost.TabIndex = 11;
            this.lblCombustionDriveDeuteriumCost.Text = "deuter";
            this.lblCombustionDriveDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombustionDriveCrystalCost
            // 
            this.lblCombustionDriveCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDriveCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCombustionDriveCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblCombustionDriveCrystalCost.Name = "lblCombustionDriveCrystalCost";
            this.lblCombustionDriveCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCombustionDriveCrystalCost.TabIndex = 10;
            this.lblCombustionDriveCrystalCost.Text = "kryształ";
            this.lblCombustionDriveCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombustionDriveMetalCost
            // 
            this.lblCombustionDriveMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDriveMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCombustionDriveMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblCombustionDriveMetalCost.Name = "lblCombustionDriveMetalCost";
            this.lblCombustionDriveMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCombustionDriveMetalCost.TabIndex = 9;
            this.lblCombustionDriveMetalCost.Text = "metal";
            this.lblCombustionDriveMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombustionDriveLevel
            // 
            this.lblCombustionDriveLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDriveLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveLevel.Location = new System.Drawing.Point(320, 10);
            this.lblCombustionDriveLevel.Name = "lblCombustionDriveLevel";
            this.lblCombustionDriveLevel.Size = new System.Drawing.Size(50, 30);
            this.lblCombustionDriveLevel.TabIndex = 8;
            this.lblCombustionDriveLevel.Text = "level";
            this.lblCombustionDriveLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombustionDrive
            // 
            this.lblCombustionDrive.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDrive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDrive.Location = new System.Drawing.Point(10, 10);
            this.lblCombustionDrive.Name = "lblCombustionDrive";
            this.lblCombustionDrive.Size = new System.Drawing.Size(300, 30);
            this.lblCombustionDrive.TabIndex = 7;
            this.lblCombustionDrive.Text = "Napęd spalinowy";
            this.lblCombustionDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pComputerTechnology
            // 
            this.pComputerTechnology.BackColor = System.Drawing.Color.Yellow;
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyCollectTime);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyTotalCost);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyTotalDeuteriumCost);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyTimeRemain);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyDuration);
            this.pComputerTechnology.Controls.Add(this.btnComputerTechnologyUpgrade);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyDeuteriumCost);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyCrystalCost);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyMetalCost);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnologyLevel);
            this.pComputerTechnology.Controls.Add(this.lblComputerTechnology);
            this.pComputerTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pComputerTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pComputerTechnology.Location = new System.Drawing.Point(3, 53);
            this.pComputerTechnology.Name = "pComputerTechnology";
            this.pComputerTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pComputerTechnology.TabIndex = 2;
            // 
            // lblComputerTechnologyTotalCost
            // 
            this.lblComputerTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblComputerTechnologyTotalCost.Name = "lblComputerTechnologyTotalCost";
            this.lblComputerTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblComputerTechnologyTotalCost.TabIndex = 30;
            this.lblComputerTechnologyTotalCost.Text = "surowce razem";
            this.lblComputerTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerTechnologyTotalDeuteriumCost
            // 
            this.lblComputerTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblComputerTechnologyTotalDeuteriumCost.Name = "lblComputerTechnologyTotalDeuteriumCost";
            this.lblComputerTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblComputerTechnologyTotalDeuteriumCost.TabIndex = 29;
            this.lblComputerTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblComputerTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerTechnologyTimeRemain
            // 
            this.lblComputerTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComputerTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblComputerTechnologyTimeRemain.Name = "lblComputerTechnologyTimeRemain";
            this.lblComputerTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblComputerTechnologyTimeRemain.TabIndex = 28;
            this.lblComputerTechnologyTimeRemain.Text = "czas pozostały";
            this.lblComputerTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerTechnologyDuration
            // 
            this.lblComputerTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComputerTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblComputerTechnologyDuration.Name = "lblComputerTechnologyDuration";
            this.lblComputerTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblComputerTechnologyDuration.TabIndex = 13;
            this.lblComputerTechnologyDuration.Text = "czas";
            this.lblComputerTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComputerTechnologyUpgrade
            // 
            this.btnComputerTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnComputerTechnologyUpgrade.Enabled = false;
            this.btnComputerTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComputerTechnologyUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComputerTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnComputerTechnologyUpgrade.Name = "btnComputerTechnologyUpgrade";
            this.btnComputerTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnComputerTechnologyUpgrade.TabIndex = 12;
            this.btnComputerTechnologyUpgrade.Text = "Ulepsz";
            this.btnComputerTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnComputerTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblComputerTechnologyDeuteriumCost
            // 
            this.lblComputerTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblComputerTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblComputerTechnologyDeuteriumCost.Name = "lblComputerTechnologyDeuteriumCost";
            this.lblComputerTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblComputerTechnologyDeuteriumCost.TabIndex = 11;
            this.lblComputerTechnologyDeuteriumCost.Text = "deuter";
            this.lblComputerTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerTechnologyCrystalCost
            // 
            this.lblComputerTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblComputerTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblComputerTechnologyCrystalCost.Name = "lblComputerTechnologyCrystalCost";
            this.lblComputerTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblComputerTechnologyCrystalCost.TabIndex = 10;
            this.lblComputerTechnologyCrystalCost.Text = "kryształ";
            this.lblComputerTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerTechnologyMetalCost
            // 
            this.lblComputerTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblComputerTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblComputerTechnologyMetalCost.Name = "lblComputerTechnologyMetalCost";
            this.lblComputerTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblComputerTechnologyMetalCost.TabIndex = 9;
            this.lblComputerTechnologyMetalCost.Text = "metal";
            this.lblComputerTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerTechnologyLevel
            // 
            this.lblComputerTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComputerTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblComputerTechnologyLevel.Name = "lblComputerTechnologyLevel";
            this.lblComputerTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblComputerTechnologyLevel.TabIndex = 8;
            this.lblComputerTechnologyLevel.Text = "level";
            this.lblComputerTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerTechnology
            // 
            this.lblComputerTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComputerTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblComputerTechnology.Name = "lblComputerTechnology";
            this.lblComputerTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblComputerTechnology.TabIndex = 7;
            this.lblComputerTechnology.Text = "Technologia komputerowa";
            this.lblComputerTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEspionageTechnology
            // 
            this.pEspionageTechnology.BackColor = System.Drawing.Color.Gold;
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyCollectTime);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyTotalCost);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyTotalDeuteriumCost);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyTimeRemain);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyDuration);
            this.pEspionageTechnology.Controls.Add(this.btnEspionageTechnologyUpgrade);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyDeuteriumCost);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyCrystalCost);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyMetalCost);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnologyLevel);
            this.pEspionageTechnology.Controls.Add(this.lblEspionageTechnology);
            this.pEspionageTechnology.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEspionageTechnology.Location = new System.Drawing.Point(3, 3);
            this.pEspionageTechnology.Name = "pEspionageTechnology";
            this.pEspionageTechnology.Size = new System.Drawing.Size(1890, 50);
            this.pEspionageTechnology.TabIndex = 0;
            // 
            // lblEspionageTechnologyTotalCost
            // 
            this.lblEspionageTechnologyTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnologyTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyTotalCost.Location = new System.Drawing.Point(1220, 10);
            this.lblEspionageTechnologyTotalCost.Name = "lblEspionageTechnologyTotalCost";
            this.lblEspionageTechnologyTotalCost.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageTechnologyTotalCost.TabIndex = 29;
            this.lblEspionageTechnologyTotalCost.Text = "surowce razem";
            this.lblEspionageTechnologyTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageTechnologyTotalDeuteriumCost
            // 
            this.lblEspionageTechnologyTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnologyTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyTotalDeuteriumCost.Location = new System.Drawing.Point(1360, 10);
            this.lblEspionageTechnologyTotalDeuteriumCost.Name = "lblEspionageTechnologyTotalDeuteriumCost";
            this.lblEspionageTechnologyTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageTechnologyTotalDeuteriumCost.TabIndex = 28;
            this.lblEspionageTechnologyTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblEspionageTechnologyTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageTechnologyTimeRemain
            // 
            this.lblEspionageTechnologyTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyTimeRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEspionageTechnologyTimeRemain.Location = new System.Drawing.Point(1080, 10);
            this.lblEspionageTechnologyTimeRemain.Name = "lblEspionageTechnologyTimeRemain";
            this.lblEspionageTechnologyTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageTechnologyTimeRemain.TabIndex = 27;
            this.lblEspionageTechnologyTimeRemain.Text = "czas pozostały";
            this.lblEspionageTechnologyTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageTechnologyDuration
            // 
            this.lblEspionageTechnologyDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnologyDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyDuration.Location = new System.Drawing.Point(800, 10);
            this.lblEspionageTechnologyDuration.Name = "lblEspionageTechnologyDuration";
            this.lblEspionageTechnologyDuration.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageTechnologyDuration.TabIndex = 13;
            this.lblEspionageTechnologyDuration.Text = "czas";
            this.lblEspionageTechnologyDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEspionageTechnologyUpgrade
            // 
            this.btnEspionageTechnologyUpgrade.BackColor = System.Drawing.Color.Silver;
            this.btnEspionageTechnologyUpgrade.Enabled = false;
            this.btnEspionageTechnologyUpgrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEspionageTechnologyUpgrade.Location = new System.Drawing.Point(940, 10);
            this.btnEspionageTechnologyUpgrade.Name = "btnEspionageTechnologyUpgrade";
            this.btnEspionageTechnologyUpgrade.Size = new System.Drawing.Size(130, 30);
            this.btnEspionageTechnologyUpgrade.TabIndex = 12;
            this.btnEspionageTechnologyUpgrade.Text = "Ulepsz";
            this.btnEspionageTechnologyUpgrade.UseVisualStyleBackColor = false;
            this.btnEspionageTechnologyUpgrade.Click += new System.EventHandler(this.BtnResearchUpgrade_Click);
            // 
            // lblEspionageTechnologyDeuteriumCost
            // 
            this.lblEspionageTechnologyDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnologyDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEspionageTechnologyDeuteriumCost.Location = new System.Drawing.Point(660, 10);
            this.lblEspionageTechnologyDeuteriumCost.Name = "lblEspionageTechnologyDeuteriumCost";
            this.lblEspionageTechnologyDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageTechnologyDeuteriumCost.TabIndex = 11;
            this.lblEspionageTechnologyDeuteriumCost.Text = "deuter";
            this.lblEspionageTechnologyDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageTechnologyCrystalCost
            // 
            this.lblEspionageTechnologyCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnologyCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEspionageTechnologyCrystalCost.Location = new System.Drawing.Point(520, 10);
            this.lblEspionageTechnologyCrystalCost.Name = "lblEspionageTechnologyCrystalCost";
            this.lblEspionageTechnologyCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageTechnologyCrystalCost.TabIndex = 10;
            this.lblEspionageTechnologyCrystalCost.Text = "kryształ";
            this.lblEspionageTechnologyCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageTechnologyMetalCost
            // 
            this.lblEspionageTechnologyMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnologyMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEspionageTechnologyMetalCost.Location = new System.Drawing.Point(380, 10);
            this.lblEspionageTechnologyMetalCost.Name = "lblEspionageTechnologyMetalCost";
            this.lblEspionageTechnologyMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageTechnologyMetalCost.TabIndex = 9;
            this.lblEspionageTechnologyMetalCost.Text = "metal";
            this.lblEspionageTechnologyMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageTechnologyLevel
            // 
            this.lblEspionageTechnologyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnologyLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyLevel.Location = new System.Drawing.Point(320, 10);
            this.lblEspionageTechnologyLevel.Name = "lblEspionageTechnologyLevel";
            this.lblEspionageTechnologyLevel.Size = new System.Drawing.Size(50, 30);
            this.lblEspionageTechnologyLevel.TabIndex = 8;
            this.lblEspionageTechnologyLevel.Text = "level";
            this.lblEspionageTechnologyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageTechnology
            // 
            this.lblEspionageTechnology.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnology.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnology.Location = new System.Drawing.Point(10, 10);
            this.lblEspionageTechnology.Name = "lblEspionageTechnology";
            this.lblEspionageTechnology.Size = new System.Drawing.Size(300, 30);
            this.lblEspionageTechnology.TabIndex = 7;
            this.lblEspionageTechnology.Text = "Technologia szpiegowska";
            this.lblEspionageTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpShipyard
            // 
            this.tpShipyard.BackColor = System.Drawing.Color.Silver;
            this.tpShipyard.Controls.Add(this.pPathfinder);
            this.tpShipyard.Controls.Add(this.pReaper);
            this.tpShipyard.Controls.Add(this.pDeathstar);
            this.tpShipyard.Controls.Add(this.pDestroyer);
            this.tpShipyard.Controls.Add(this.pBomber);
            this.tpShipyard.Controls.Add(this.pBattlecruiser);
            this.tpShipyard.Controls.Add(this.pBattleship);
            this.tpShipyard.Controls.Add(this.pCruiser);
            this.tpShipyard.Controls.Add(this.pHeavyFighter);
            this.tpShipyard.Controls.Add(this.pLightFighter);
            this.tpShipyard.Controls.Add(this.pEspionageProbe);
            this.tpShipyard.Controls.Add(this.pRecycler);
            this.tpShipyard.Controls.Add(this.pColonyShip);
            this.tpShipyard.Controls.Add(this.pLargeCargo);
            this.tpShipyard.Controls.Add(this.pSmallCargo);
            this.tpShipyard.Location = new System.Drawing.Point(4, 29);
            this.tpShipyard.Name = "tpShipyard";
            this.tpShipyard.Padding = new System.Windows.Forms.Padding(3);
            this.tpShipyard.Size = new System.Drawing.Size(1896, 800);
            this.tpShipyard.TabIndex = 2;
            this.tpShipyard.Text = "Stocznia";
            // 
            // pPathfinder
            // 
            this.pPathfinder.BackColor = System.Drawing.Color.Gold;
            this.pPathfinder.Controls.Add(this.lblPathfinderTimeRemain);
            this.pPathfinder.Controls.Add(this.tbPathfinderCount);
            this.pPathfinder.Controls.Add(this.lblPathfinderShade);
            this.pPathfinder.Controls.Add(this.lblPathfinderDuration);
            this.pPathfinder.Controls.Add(this.btnPathfinderConstruct);
            this.pPathfinder.Controls.Add(this.lblPathfinderDeuteriumCost);
            this.pPathfinder.Controls.Add(this.lblPathfinderCrystalCost);
            this.pPathfinder.Controls.Add(this.lblPathfinderMetalCost);
            this.pPathfinder.Controls.Add(this.lblPathfinderCount);
            this.pPathfinder.Controls.Add(this.lblPathfinder);
            this.pPathfinder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPathfinder.Location = new System.Drawing.Point(3, 703);
            this.pPathfinder.Name = "pPathfinder";
            this.pPathfinder.Size = new System.Drawing.Size(1890, 50);
            this.pPathfinder.TabIndex = 17;
            // 
            // lblPathfinderTimeRemain
            // 
            this.lblPathfinderTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblPathfinderTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPathfinderTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblPathfinderTimeRemain.Name = "lblPathfinderTimeRemain";
            this.lblPathfinderTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblPathfinderTimeRemain.TabIndex = 15;
            this.lblPathfinderTimeRemain.Text = "czas pozostały";
            this.lblPathfinderTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPathfinderCount
            // 
            this.tbPathfinderCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPathfinderCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPathfinderCount.Location = new System.Drawing.Point(1161, 17);
            this.tbPathfinderCount.Name = "tbPathfinderCount";
            this.tbPathfinderCount.Size = new System.Drawing.Size(129, 16);
            this.tbPathfinderCount.TabIndex = 4;
            this.tbPathfinderCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPathfinderShade
            // 
            this.lblPathfinderShade.BackColor = System.Drawing.Color.White;
            this.lblPathfinderShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPathfinderShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPathfinderShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPathfinderShade.Location = new System.Drawing.Point(1160, 10);
            this.lblPathfinderShade.Name = "lblPathfinderShade";
            this.lblPathfinderShade.Size = new System.Drawing.Size(130, 30);
            this.lblPathfinderShade.TabIndex = 14;
            this.lblPathfinderShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPathfinderDuration
            // 
            this.lblPathfinderDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblPathfinderDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPathfinderDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPathfinderDuration.Location = new System.Drawing.Point(880, 10);
            this.lblPathfinderDuration.Name = "lblPathfinderDuration";
            this.lblPathfinderDuration.Size = new System.Drawing.Size(130, 30);
            this.lblPathfinderDuration.TabIndex = 13;
            this.lblPathfinderDuration.Text = "czas";
            this.lblPathfinderDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPathfinderConstruct
            // 
            this.btnPathfinderConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnPathfinderConstruct.Enabled = false;
            this.btnPathfinderConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPathfinderConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnPathfinderConstruct.Name = "btnPathfinderConstruct";
            this.btnPathfinderConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnPathfinderConstruct.TabIndex = 12;
            this.btnPathfinderConstruct.Text = "Zbuduj";
            this.btnPathfinderConstruct.UseVisualStyleBackColor = false;
            this.btnPathfinderConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblPathfinderDeuteriumCost
            // 
            this.lblPathfinderDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPathfinderDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPathfinderDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPathfinderDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPathfinderDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblPathfinderDeuteriumCost.Name = "lblPathfinderDeuteriumCost";
            this.lblPathfinderDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblPathfinderDeuteriumCost.TabIndex = 11;
            this.lblPathfinderDeuteriumCost.Text = "deuter";
            this.lblPathfinderDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPathfinderCrystalCost
            // 
            this.lblPathfinderCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPathfinderCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPathfinderCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPathfinderCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPathfinderCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblPathfinderCrystalCost.Name = "lblPathfinderCrystalCost";
            this.lblPathfinderCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblPathfinderCrystalCost.TabIndex = 10;
            this.lblPathfinderCrystalCost.Text = "kryształ";
            this.lblPathfinderCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPathfinderMetalCost
            // 
            this.lblPathfinderMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPathfinderMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPathfinderMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPathfinderMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPathfinderMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblPathfinderMetalCost.Name = "lblPathfinderMetalCost";
            this.lblPathfinderMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblPathfinderMetalCost.TabIndex = 9;
            this.lblPathfinderMetalCost.Text = "metal";
            this.lblPathfinderMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPathfinderCount
            // 
            this.lblPathfinderCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPathfinderCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPathfinderCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPathfinderCount.Location = new System.Drawing.Point(320, 10);
            this.lblPathfinderCount.Name = "lblPathfinderCount";
            this.lblPathfinderCount.Size = new System.Drawing.Size(130, 30);
            this.lblPathfinderCount.TabIndex = 8;
            this.lblPathfinderCount.Text = "Ilość";
            this.lblPathfinderCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPathfinder
            // 
            this.lblPathfinder.BackColor = System.Drawing.Color.Transparent;
            this.lblPathfinder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPathfinder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPathfinder.Location = new System.Drawing.Point(10, 10);
            this.lblPathfinder.Name = "lblPathfinder";
            this.lblPathfinder.Size = new System.Drawing.Size(300, 30);
            this.lblPathfinder.TabIndex = 7;
            this.lblPathfinder.Text = "Pionier";
            this.lblPathfinder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pReaper
            // 
            this.pReaper.BackColor = System.Drawing.Color.Yellow;
            this.pReaper.Controls.Add(this.lblReaperTimeRemain);
            this.pReaper.Controls.Add(this.tbReaperCount);
            this.pReaper.Controls.Add(this.lblReaperShade);
            this.pReaper.Controls.Add(this.lblReaperDuration);
            this.pReaper.Controls.Add(this.btnReaperConstruct);
            this.pReaper.Controls.Add(this.lblReaperDeuteriumCost);
            this.pReaper.Controls.Add(this.lblReaperCrystalCost);
            this.pReaper.Controls.Add(this.lblReaperMetalCost);
            this.pReaper.Controls.Add(this.lblReaperCount);
            this.pReaper.Controls.Add(this.lblReaper);
            this.pReaper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pReaper.Location = new System.Drawing.Point(3, 653);
            this.pReaper.Name = "pReaper";
            this.pReaper.Size = new System.Drawing.Size(1890, 50);
            this.pReaper.TabIndex = 16;
            // 
            // lblReaperTimeRemain
            // 
            this.lblReaperTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblReaperTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaperTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblReaperTimeRemain.Name = "lblReaperTimeRemain";
            this.lblReaperTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblReaperTimeRemain.TabIndex = 15;
            this.lblReaperTimeRemain.Text = "czas pozostały";
            this.lblReaperTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbReaperCount
            // 
            this.tbReaperCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbReaperCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbReaperCount.Location = new System.Drawing.Point(1161, 17);
            this.tbReaperCount.Name = "tbReaperCount";
            this.tbReaperCount.Size = new System.Drawing.Size(129, 16);
            this.tbReaperCount.TabIndex = 4;
            this.tbReaperCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReaperShade
            // 
            this.lblReaperShade.BackColor = System.Drawing.Color.White;
            this.lblReaperShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReaperShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaperShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReaperShade.Location = new System.Drawing.Point(1160, 10);
            this.lblReaperShade.Name = "lblReaperShade";
            this.lblReaperShade.Size = new System.Drawing.Size(130, 30);
            this.lblReaperShade.TabIndex = 14;
            this.lblReaperShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReaperDuration
            // 
            this.lblReaperDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblReaperDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReaperDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaperDuration.Location = new System.Drawing.Point(880, 10);
            this.lblReaperDuration.Name = "lblReaperDuration";
            this.lblReaperDuration.Size = new System.Drawing.Size(130, 30);
            this.lblReaperDuration.TabIndex = 13;
            this.lblReaperDuration.Text = "czas";
            this.lblReaperDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReaperConstruct
            // 
            this.btnReaperConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnReaperConstruct.Enabled = false;
            this.btnReaperConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReaperConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnReaperConstruct.Name = "btnReaperConstruct";
            this.btnReaperConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnReaperConstruct.TabIndex = 12;
            this.btnReaperConstruct.Text = "Zbuduj";
            this.btnReaperConstruct.UseVisualStyleBackColor = false;
            this.btnReaperConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblReaperDeuteriumCost
            // 
            this.lblReaperDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblReaperDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReaperDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaperDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReaperDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblReaperDeuteriumCost.Name = "lblReaperDeuteriumCost";
            this.lblReaperDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblReaperDeuteriumCost.TabIndex = 11;
            this.lblReaperDeuteriumCost.Text = "deuter";
            this.lblReaperDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReaperCrystalCost
            // 
            this.lblReaperCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblReaperCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReaperCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaperCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReaperCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblReaperCrystalCost.Name = "lblReaperCrystalCost";
            this.lblReaperCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblReaperCrystalCost.TabIndex = 10;
            this.lblReaperCrystalCost.Text = "kryształ";
            this.lblReaperCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReaperMetalCost
            // 
            this.lblReaperMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblReaperMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReaperMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaperMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblReaperMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblReaperMetalCost.Name = "lblReaperMetalCost";
            this.lblReaperMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblReaperMetalCost.TabIndex = 9;
            this.lblReaperMetalCost.Text = "metal";
            this.lblReaperMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReaperCount
            // 
            this.lblReaperCount.BackColor = System.Drawing.Color.Transparent;
            this.lblReaperCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReaperCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaperCount.Location = new System.Drawing.Point(320, 10);
            this.lblReaperCount.Name = "lblReaperCount";
            this.lblReaperCount.Size = new System.Drawing.Size(130, 30);
            this.lblReaperCount.TabIndex = 8;
            this.lblReaperCount.Text = "Ilość";
            this.lblReaperCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReaper
            // 
            this.lblReaper.BackColor = System.Drawing.Color.Transparent;
            this.lblReaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReaper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReaper.Location = new System.Drawing.Point(10, 10);
            this.lblReaper.Name = "lblReaper";
            this.lblReaper.Size = new System.Drawing.Size(300, 30);
            this.lblReaper.TabIndex = 7;
            this.lblReaper.Text = "Rozpruwacz";
            this.lblReaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pDeathstar
            // 
            this.pDeathstar.BackColor = System.Drawing.Color.Gold;
            this.pDeathstar.Controls.Add(this.lblDeathstarTimeRemain);
            this.pDeathstar.Controls.Add(this.tbDeathstarCount);
            this.pDeathstar.Controls.Add(this.lblDeathstarShade);
            this.pDeathstar.Controls.Add(this.lblDeathstarDuration);
            this.pDeathstar.Controls.Add(this.btnDeathstarConstruct);
            this.pDeathstar.Controls.Add(this.lblDeathstarDeuteriumCost);
            this.pDeathstar.Controls.Add(this.lblDeathstarCrystalCost);
            this.pDeathstar.Controls.Add(this.lblDeathstarMetalCost);
            this.pDeathstar.Controls.Add(this.lblDeathstarCount);
            this.pDeathstar.Controls.Add(this.lblDeathstar);
            this.pDeathstar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDeathstar.Location = new System.Drawing.Point(3, 603);
            this.pDeathstar.Name = "pDeathstar";
            this.pDeathstar.Size = new System.Drawing.Size(1890, 50);
            this.pDeathstar.TabIndex = 16;
            // 
            // lblDeathstarTimeRemain
            // 
            this.lblDeathstarTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblDeathstarTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeathstarTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblDeathstarTimeRemain.Name = "lblDeathstarTimeRemain";
            this.lblDeathstarTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblDeathstarTimeRemain.TabIndex = 15;
            this.lblDeathstarTimeRemain.Text = "czas pozostały";
            this.lblDeathstarTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDeathstarCount
            // 
            this.tbDeathstarCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDeathstarCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDeathstarCount.Location = new System.Drawing.Point(1161, 17);
            this.tbDeathstarCount.Name = "tbDeathstarCount";
            this.tbDeathstarCount.Size = new System.Drawing.Size(129, 16);
            this.tbDeathstarCount.TabIndex = 4;
            this.tbDeathstarCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDeathstarShade
            // 
            this.lblDeathstarShade.BackColor = System.Drawing.Color.White;
            this.lblDeathstarShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeathstarShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeathstarShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeathstarShade.Location = new System.Drawing.Point(1160, 10);
            this.lblDeathstarShade.Name = "lblDeathstarShade";
            this.lblDeathstarShade.Size = new System.Drawing.Size(130, 30);
            this.lblDeathstarShade.TabIndex = 14;
            this.lblDeathstarShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeathstarDuration
            // 
            this.lblDeathstarDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDeathstarDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeathstarDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeathstarDuration.Location = new System.Drawing.Point(880, 10);
            this.lblDeathstarDuration.Name = "lblDeathstarDuration";
            this.lblDeathstarDuration.Size = new System.Drawing.Size(130, 30);
            this.lblDeathstarDuration.TabIndex = 13;
            this.lblDeathstarDuration.Text = "czas";
            this.lblDeathstarDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeathstarConstruct
            // 
            this.btnDeathstarConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnDeathstarConstruct.Enabled = false;
            this.btnDeathstarConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeathstarConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnDeathstarConstruct.Name = "btnDeathstarConstruct";
            this.btnDeathstarConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnDeathstarConstruct.TabIndex = 12;
            this.btnDeathstarConstruct.Text = "Zbuduj";
            this.btnDeathstarConstruct.UseVisualStyleBackColor = false;
            this.btnDeathstarConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblDeathstarDeuteriumCost
            // 
            this.lblDeathstarDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeathstarDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeathstarDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeathstarDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeathstarDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblDeathstarDeuteriumCost.Name = "lblDeathstarDeuteriumCost";
            this.lblDeathstarDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeathstarDeuteriumCost.TabIndex = 11;
            this.lblDeathstarDeuteriumCost.Text = "deuter";
            this.lblDeathstarDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeathstarCrystalCost
            // 
            this.lblDeathstarCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeathstarCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeathstarCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeathstarCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeathstarCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblDeathstarCrystalCost.Name = "lblDeathstarCrystalCost";
            this.lblDeathstarCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeathstarCrystalCost.TabIndex = 10;
            this.lblDeathstarCrystalCost.Text = "kryształ";
            this.lblDeathstarCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeathstarMetalCost
            // 
            this.lblDeathstarMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeathstarMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeathstarMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeathstarMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeathstarMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblDeathstarMetalCost.Name = "lblDeathstarMetalCost";
            this.lblDeathstarMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeathstarMetalCost.TabIndex = 9;
            this.lblDeathstarMetalCost.Text = "metal";
            this.lblDeathstarMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeathstarCount
            // 
            this.lblDeathstarCount.BackColor = System.Drawing.Color.Transparent;
            this.lblDeathstarCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeathstarCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeathstarCount.Location = new System.Drawing.Point(320, 10);
            this.lblDeathstarCount.Name = "lblDeathstarCount";
            this.lblDeathstarCount.Size = new System.Drawing.Size(130, 30);
            this.lblDeathstarCount.TabIndex = 8;
            this.lblDeathstarCount.Text = "Ilość";
            this.lblDeathstarCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeathstar
            // 
            this.lblDeathstar.BackColor = System.Drawing.Color.Transparent;
            this.lblDeathstar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeathstar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeathstar.Location = new System.Drawing.Point(10, 10);
            this.lblDeathstar.Name = "lblDeathstar";
            this.lblDeathstar.Size = new System.Drawing.Size(300, 30);
            this.lblDeathstar.TabIndex = 7;
            this.lblDeathstar.Text = "Gwiazda śmierci";
            this.lblDeathstar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pDestroyer
            // 
            this.pDestroyer.BackColor = System.Drawing.Color.Yellow;
            this.pDestroyer.Controls.Add(this.lblDestroyerTimeRemain);
            this.pDestroyer.Controls.Add(this.tbDestroyerCount);
            this.pDestroyer.Controls.Add(this.lblDestroyerShade);
            this.pDestroyer.Controls.Add(this.lblDestroyerDuration);
            this.pDestroyer.Controls.Add(this.btnDestroyerConstruct);
            this.pDestroyer.Controls.Add(this.lblDestroyerDeuteriumCost);
            this.pDestroyer.Controls.Add(this.lblDestroyerCrystalCost);
            this.pDestroyer.Controls.Add(this.lblDestroyerMetalCost);
            this.pDestroyer.Controls.Add(this.lblDestroyerCount);
            this.pDestroyer.Controls.Add(this.lblDestroyer);
            this.pDestroyer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDestroyer.Location = new System.Drawing.Point(3, 553);
            this.pDestroyer.Name = "pDestroyer";
            this.pDestroyer.Size = new System.Drawing.Size(1890, 50);
            this.pDestroyer.TabIndex = 14;
            // 
            // lblDestroyerTimeRemain
            // 
            this.lblDestroyerTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblDestroyerTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestroyerTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblDestroyerTimeRemain.Name = "lblDestroyerTimeRemain";
            this.lblDestroyerTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblDestroyerTimeRemain.TabIndex = 15;
            this.lblDestroyerTimeRemain.Text = "czas pozostały";
            this.lblDestroyerTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDestroyerCount
            // 
            this.tbDestroyerCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbDestroyerCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestroyerCount.Location = new System.Drawing.Point(1161, 17);
            this.tbDestroyerCount.Name = "tbDestroyerCount";
            this.tbDestroyerCount.Size = new System.Drawing.Size(129, 16);
            this.tbDestroyerCount.TabIndex = 4;
            this.tbDestroyerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDestroyerShade
            // 
            this.lblDestroyerShade.BackColor = System.Drawing.Color.White;
            this.lblDestroyerShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestroyerShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestroyerShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDestroyerShade.Location = new System.Drawing.Point(1160, 10);
            this.lblDestroyerShade.Name = "lblDestroyerShade";
            this.lblDestroyerShade.Size = new System.Drawing.Size(130, 30);
            this.lblDestroyerShade.TabIndex = 14;
            this.lblDestroyerShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestroyerDuration
            // 
            this.lblDestroyerDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDestroyerDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestroyerDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestroyerDuration.Location = new System.Drawing.Point(880, 10);
            this.lblDestroyerDuration.Name = "lblDestroyerDuration";
            this.lblDestroyerDuration.Size = new System.Drawing.Size(130, 30);
            this.lblDestroyerDuration.TabIndex = 13;
            this.lblDestroyerDuration.Text = "czas";
            this.lblDestroyerDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDestroyerConstruct
            // 
            this.btnDestroyerConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnDestroyerConstruct.Enabled = false;
            this.btnDestroyerConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDestroyerConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnDestroyerConstruct.Name = "btnDestroyerConstruct";
            this.btnDestroyerConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnDestroyerConstruct.TabIndex = 12;
            this.btnDestroyerConstruct.Text = "Zbuduj";
            this.btnDestroyerConstruct.UseVisualStyleBackColor = false;
            this.btnDestroyerConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblDestroyerDeuteriumCost
            // 
            this.lblDestroyerDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDestroyerDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestroyerDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestroyerDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDestroyerDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblDestroyerDeuteriumCost.Name = "lblDestroyerDeuteriumCost";
            this.lblDestroyerDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblDestroyerDeuteriumCost.TabIndex = 11;
            this.lblDestroyerDeuteriumCost.Text = "deuter";
            this.lblDestroyerDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestroyerCrystalCost
            // 
            this.lblDestroyerCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDestroyerCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestroyerCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestroyerCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDestroyerCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblDestroyerCrystalCost.Name = "lblDestroyerCrystalCost";
            this.lblDestroyerCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblDestroyerCrystalCost.TabIndex = 10;
            this.lblDestroyerCrystalCost.Text = "kryształ";
            this.lblDestroyerCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestroyerMetalCost
            // 
            this.lblDestroyerMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDestroyerMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestroyerMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestroyerMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDestroyerMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblDestroyerMetalCost.Name = "lblDestroyerMetalCost";
            this.lblDestroyerMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblDestroyerMetalCost.TabIndex = 9;
            this.lblDestroyerMetalCost.Text = "metal";
            this.lblDestroyerMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestroyerCount
            // 
            this.lblDestroyerCount.BackColor = System.Drawing.Color.Transparent;
            this.lblDestroyerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestroyerCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestroyerCount.Location = new System.Drawing.Point(320, 10);
            this.lblDestroyerCount.Name = "lblDestroyerCount";
            this.lblDestroyerCount.Size = new System.Drawing.Size(130, 30);
            this.lblDestroyerCount.TabIndex = 8;
            this.lblDestroyerCount.Text = "Ilość";
            this.lblDestroyerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestroyer
            // 
            this.lblDestroyer.BackColor = System.Drawing.Color.Transparent;
            this.lblDestroyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestroyer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestroyer.Location = new System.Drawing.Point(10, 10);
            this.lblDestroyer.Name = "lblDestroyer";
            this.lblDestroyer.Size = new System.Drawing.Size(300, 30);
            this.lblDestroyer.TabIndex = 7;
            this.lblDestroyer.Text = "Niszczyciel";
            this.lblDestroyer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBomber
            // 
            this.pBomber.BackColor = System.Drawing.Color.Gold;
            this.pBomber.Controls.Add(this.lblBomberTimeRemain);
            this.pBomber.Controls.Add(this.tbBomberCount);
            this.pBomber.Controls.Add(this.lblBomberShade);
            this.pBomber.Controls.Add(this.lblBomberDuration);
            this.pBomber.Controls.Add(this.btnBomberConstruct);
            this.pBomber.Controls.Add(this.lblBomberDeuteriumCost);
            this.pBomber.Controls.Add(this.lblBomberCrystalCost);
            this.pBomber.Controls.Add(this.lblBomberMetalCost);
            this.pBomber.Controls.Add(this.lblBomberCount);
            this.pBomber.Controls.Add(this.lblBomber);
            this.pBomber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBomber.Location = new System.Drawing.Point(3, 503);
            this.pBomber.Name = "pBomber";
            this.pBomber.Size = new System.Drawing.Size(1890, 50);
            this.pBomber.TabIndex = 13;
            // 
            // lblBomberTimeRemain
            // 
            this.lblBomberTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblBomberTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBomberTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblBomberTimeRemain.Name = "lblBomberTimeRemain";
            this.lblBomberTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblBomberTimeRemain.TabIndex = 15;
            this.lblBomberTimeRemain.Text = "czas pozostały";
            this.lblBomberTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBomberCount
            // 
            this.tbBomberCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbBomberCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBomberCount.Location = new System.Drawing.Point(1161, 17);
            this.tbBomberCount.Name = "tbBomberCount";
            this.tbBomberCount.Size = new System.Drawing.Size(129, 16);
            this.tbBomberCount.TabIndex = 4;
            this.tbBomberCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBomberShade
            // 
            this.lblBomberShade.BackColor = System.Drawing.Color.White;
            this.lblBomberShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBomberShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBomberShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBomberShade.Location = new System.Drawing.Point(1160, 10);
            this.lblBomberShade.Name = "lblBomberShade";
            this.lblBomberShade.Size = new System.Drawing.Size(130, 30);
            this.lblBomberShade.TabIndex = 14;
            this.lblBomberShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBomberDuration
            // 
            this.lblBomberDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblBomberDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBomberDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBomberDuration.Location = new System.Drawing.Point(880, 10);
            this.lblBomberDuration.Name = "lblBomberDuration";
            this.lblBomberDuration.Size = new System.Drawing.Size(130, 30);
            this.lblBomberDuration.TabIndex = 13;
            this.lblBomberDuration.Text = "czas";
            this.lblBomberDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBomberConstruct
            // 
            this.btnBomberConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnBomberConstruct.Enabled = false;
            this.btnBomberConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBomberConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnBomberConstruct.Name = "btnBomberConstruct";
            this.btnBomberConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnBomberConstruct.TabIndex = 12;
            this.btnBomberConstruct.Text = "Zbuduj";
            this.btnBomberConstruct.UseVisualStyleBackColor = false;
            this.btnBomberConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblBomberDeuteriumCost
            // 
            this.lblBomberDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBomberDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBomberDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBomberDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBomberDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblBomberDeuteriumCost.Name = "lblBomberDeuteriumCost";
            this.lblBomberDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblBomberDeuteriumCost.TabIndex = 11;
            this.lblBomberDeuteriumCost.Text = "deuter";
            this.lblBomberDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBomberCrystalCost
            // 
            this.lblBomberCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBomberCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBomberCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBomberCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBomberCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblBomberCrystalCost.Name = "lblBomberCrystalCost";
            this.lblBomberCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblBomberCrystalCost.TabIndex = 10;
            this.lblBomberCrystalCost.Text = "kryształ";
            this.lblBomberCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBomberMetalCost
            // 
            this.lblBomberMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBomberMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBomberMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBomberMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBomberMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblBomberMetalCost.Name = "lblBomberMetalCost";
            this.lblBomberMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblBomberMetalCost.TabIndex = 9;
            this.lblBomberMetalCost.Text = "metal";
            this.lblBomberMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBomberCount
            // 
            this.lblBomberCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBomberCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBomberCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBomberCount.Location = new System.Drawing.Point(320, 10);
            this.lblBomberCount.Name = "lblBomberCount";
            this.lblBomberCount.Size = new System.Drawing.Size(130, 30);
            this.lblBomberCount.TabIndex = 8;
            this.lblBomberCount.Text = "Ilość";
            this.lblBomberCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBomber
            // 
            this.lblBomber.BackColor = System.Drawing.Color.Transparent;
            this.lblBomber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBomber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBomber.Location = new System.Drawing.Point(10, 10);
            this.lblBomber.Name = "lblBomber";
            this.lblBomber.Size = new System.Drawing.Size(300, 30);
            this.lblBomber.TabIndex = 7;
            this.lblBomber.Text = "Bombowiec";
            this.lblBomber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBattlecruiser
            // 
            this.pBattlecruiser.BackColor = System.Drawing.Color.Yellow;
            this.pBattlecruiser.Controls.Add(this.lblBattlecruiserTimeRemain);
            this.pBattlecruiser.Controls.Add(this.tbBattlecruiserCount);
            this.pBattlecruiser.Controls.Add(this.lblBattlecruiserShade);
            this.pBattlecruiser.Controls.Add(this.lblBattlecruiserDuration);
            this.pBattlecruiser.Controls.Add(this.btnBattlecruiserConstruct);
            this.pBattlecruiser.Controls.Add(this.lblBattlecruiserDeuteriumCost);
            this.pBattlecruiser.Controls.Add(this.lblBattlecruiserCrystalCost);
            this.pBattlecruiser.Controls.Add(this.lblBattlecruiserMetalCost);
            this.pBattlecruiser.Controls.Add(this.lblBattlecruiserCount);
            this.pBattlecruiser.Controls.Add(this.lblBattlecruiser);
            this.pBattlecruiser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBattlecruiser.Location = new System.Drawing.Point(3, 453);
            this.pBattlecruiser.Name = "pBattlecruiser";
            this.pBattlecruiser.Size = new System.Drawing.Size(1890, 50);
            this.pBattlecruiser.TabIndex = 12;
            // 
            // lblBattlecruiserTimeRemain
            // 
            this.lblBattlecruiserTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblBattlecruiserTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattlecruiserTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblBattlecruiserTimeRemain.Name = "lblBattlecruiserTimeRemain";
            this.lblBattlecruiserTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblBattlecruiserTimeRemain.TabIndex = 15;
            this.lblBattlecruiserTimeRemain.Text = "czas pozostały";
            this.lblBattlecruiserTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBattlecruiserCount
            // 
            this.tbBattlecruiserCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbBattlecruiserCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBattlecruiserCount.Location = new System.Drawing.Point(1161, 17);
            this.tbBattlecruiserCount.Name = "tbBattlecruiserCount";
            this.tbBattlecruiserCount.Size = new System.Drawing.Size(129, 16);
            this.tbBattlecruiserCount.TabIndex = 4;
            this.tbBattlecruiserCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBattlecruiserShade
            // 
            this.lblBattlecruiserShade.BackColor = System.Drawing.Color.White;
            this.lblBattlecruiserShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBattlecruiserShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattlecruiserShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBattlecruiserShade.Location = new System.Drawing.Point(1160, 10);
            this.lblBattlecruiserShade.Name = "lblBattlecruiserShade";
            this.lblBattlecruiserShade.Size = new System.Drawing.Size(130, 30);
            this.lblBattlecruiserShade.TabIndex = 14;
            this.lblBattlecruiserShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattlecruiserDuration
            // 
            this.lblBattlecruiserDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblBattlecruiserDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattlecruiserDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattlecruiserDuration.Location = new System.Drawing.Point(880, 10);
            this.lblBattlecruiserDuration.Name = "lblBattlecruiserDuration";
            this.lblBattlecruiserDuration.Size = new System.Drawing.Size(130, 30);
            this.lblBattlecruiserDuration.TabIndex = 13;
            this.lblBattlecruiserDuration.Text = "czas";
            this.lblBattlecruiserDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBattlecruiserConstruct
            // 
            this.btnBattlecruiserConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnBattlecruiserConstruct.Enabled = false;
            this.btnBattlecruiserConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBattlecruiserConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnBattlecruiserConstruct.Name = "btnBattlecruiserConstruct";
            this.btnBattlecruiserConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnBattlecruiserConstruct.TabIndex = 12;
            this.btnBattlecruiserConstruct.Text = "Zbuduj";
            this.btnBattlecruiserConstruct.UseVisualStyleBackColor = false;
            this.btnBattlecruiserConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblBattlecruiserDeuteriumCost
            // 
            this.lblBattlecruiserDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBattlecruiserDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattlecruiserDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattlecruiserDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBattlecruiserDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblBattlecruiserDeuteriumCost.Name = "lblBattlecruiserDeuteriumCost";
            this.lblBattlecruiserDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblBattlecruiserDeuteriumCost.TabIndex = 11;
            this.lblBattlecruiserDeuteriumCost.Text = "deuter";
            this.lblBattlecruiserDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattlecruiserCrystalCost
            // 
            this.lblBattlecruiserCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBattlecruiserCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattlecruiserCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattlecruiserCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBattlecruiserCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblBattlecruiserCrystalCost.Name = "lblBattlecruiserCrystalCost";
            this.lblBattlecruiserCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblBattlecruiserCrystalCost.TabIndex = 10;
            this.lblBattlecruiserCrystalCost.Text = "kryształ";
            this.lblBattlecruiserCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattlecruiserMetalCost
            // 
            this.lblBattlecruiserMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBattlecruiserMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattlecruiserMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattlecruiserMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBattlecruiserMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblBattlecruiserMetalCost.Name = "lblBattlecruiserMetalCost";
            this.lblBattlecruiserMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblBattlecruiserMetalCost.TabIndex = 9;
            this.lblBattlecruiserMetalCost.Text = "metal";
            this.lblBattlecruiserMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattlecruiserCount
            // 
            this.lblBattlecruiserCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBattlecruiserCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattlecruiserCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattlecruiserCount.Location = new System.Drawing.Point(320, 10);
            this.lblBattlecruiserCount.Name = "lblBattlecruiserCount";
            this.lblBattlecruiserCount.Size = new System.Drawing.Size(130, 30);
            this.lblBattlecruiserCount.TabIndex = 8;
            this.lblBattlecruiserCount.Text = "Ilość";
            this.lblBattlecruiserCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattlecruiser
            // 
            this.lblBattlecruiser.BackColor = System.Drawing.Color.Transparent;
            this.lblBattlecruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattlecruiser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattlecruiser.Location = new System.Drawing.Point(10, 10);
            this.lblBattlecruiser.Name = "lblBattlecruiser";
            this.lblBattlecruiser.Size = new System.Drawing.Size(300, 30);
            this.lblBattlecruiser.TabIndex = 7;
            this.lblBattlecruiser.Text = "Pancernik";
            this.lblBattlecruiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBattleship
            // 
            this.pBattleship.BackColor = System.Drawing.Color.Gold;
            this.pBattleship.Controls.Add(this.lblBattleshipTimeRemain);
            this.pBattleship.Controls.Add(this.tbBattleshipCount);
            this.pBattleship.Controls.Add(this.lblBattleshipShade);
            this.pBattleship.Controls.Add(this.lblBattleshipDuration);
            this.pBattleship.Controls.Add(this.btnBattleshipConstruct);
            this.pBattleship.Controls.Add(this.lblBattleshipDeuteriumCost);
            this.pBattleship.Controls.Add(this.lblBattleshipCrystalCost);
            this.pBattleship.Controls.Add(this.lblBattleshipMetalCost);
            this.pBattleship.Controls.Add(this.lblBattleshipCount);
            this.pBattleship.Controls.Add(this.lblBattleship);
            this.pBattleship.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBattleship.Location = new System.Drawing.Point(3, 403);
            this.pBattleship.Name = "pBattleship";
            this.pBattleship.Size = new System.Drawing.Size(1890, 50);
            this.pBattleship.TabIndex = 11;
            // 
            // lblBattleshipTimeRemain
            // 
            this.lblBattleshipTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleshipTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattleshipTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblBattleshipTimeRemain.Name = "lblBattleshipTimeRemain";
            this.lblBattleshipTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblBattleshipTimeRemain.TabIndex = 15;
            this.lblBattleshipTimeRemain.Text = "czas pozostały";
            this.lblBattleshipTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBattleshipCount
            // 
            this.tbBattleshipCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbBattleshipCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBattleshipCount.Location = new System.Drawing.Point(1161, 17);
            this.tbBattleshipCount.Name = "tbBattleshipCount";
            this.tbBattleshipCount.Size = new System.Drawing.Size(129, 16);
            this.tbBattleshipCount.TabIndex = 4;
            this.tbBattleshipCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBattleshipShade
            // 
            this.lblBattleshipShade.BackColor = System.Drawing.Color.White;
            this.lblBattleshipShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBattleshipShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattleshipShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBattleshipShade.Location = new System.Drawing.Point(1160, 10);
            this.lblBattleshipShade.Name = "lblBattleshipShade";
            this.lblBattleshipShade.Size = new System.Drawing.Size(130, 30);
            this.lblBattleshipShade.TabIndex = 14;
            this.lblBattleshipShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattleshipDuration
            // 
            this.lblBattleshipDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleshipDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattleshipDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattleshipDuration.Location = new System.Drawing.Point(880, 10);
            this.lblBattleshipDuration.Name = "lblBattleshipDuration";
            this.lblBattleshipDuration.Size = new System.Drawing.Size(130, 30);
            this.lblBattleshipDuration.TabIndex = 13;
            this.lblBattleshipDuration.Text = "czas";
            this.lblBattleshipDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBattleshipConstruct
            // 
            this.btnBattleshipConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnBattleshipConstruct.Enabled = false;
            this.btnBattleshipConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBattleshipConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnBattleshipConstruct.Name = "btnBattleshipConstruct";
            this.btnBattleshipConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnBattleshipConstruct.TabIndex = 12;
            this.btnBattleshipConstruct.Text = "Zbuduj";
            this.btnBattleshipConstruct.UseVisualStyleBackColor = false;
            this.btnBattleshipConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblBattleshipDeuteriumCost
            // 
            this.lblBattleshipDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleshipDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattleshipDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattleshipDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBattleshipDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblBattleshipDeuteriumCost.Name = "lblBattleshipDeuteriumCost";
            this.lblBattleshipDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblBattleshipDeuteriumCost.TabIndex = 11;
            this.lblBattleshipDeuteriumCost.Text = "deuter";
            this.lblBattleshipDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattleshipCrystalCost
            // 
            this.lblBattleshipCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleshipCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattleshipCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattleshipCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBattleshipCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblBattleshipCrystalCost.Name = "lblBattleshipCrystalCost";
            this.lblBattleshipCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblBattleshipCrystalCost.TabIndex = 10;
            this.lblBattleshipCrystalCost.Text = "kryształ";
            this.lblBattleshipCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattleshipMetalCost
            // 
            this.lblBattleshipMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleshipMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattleshipMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattleshipMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBattleshipMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblBattleshipMetalCost.Name = "lblBattleshipMetalCost";
            this.lblBattleshipMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblBattleshipMetalCost.TabIndex = 9;
            this.lblBattleshipMetalCost.Text = "metal";
            this.lblBattleshipMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattleshipCount
            // 
            this.lblBattleshipCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleshipCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattleshipCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattleshipCount.Location = new System.Drawing.Point(320, 10);
            this.lblBattleshipCount.Name = "lblBattleshipCount";
            this.lblBattleshipCount.Size = new System.Drawing.Size(130, 30);
            this.lblBattleshipCount.TabIndex = 8;
            this.lblBattleshipCount.Text = "Ilość";
            this.lblBattleshipCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBattleship
            // 
            this.lblBattleship.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleship.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBattleship.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBattleship.Location = new System.Drawing.Point(10, 10);
            this.lblBattleship.Name = "lblBattleship";
            this.lblBattleship.Size = new System.Drawing.Size(300, 30);
            this.lblBattleship.TabIndex = 7;
            this.lblBattleship.Text = "Okręt wojenny";
            this.lblBattleship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCruiser
            // 
            this.pCruiser.BackColor = System.Drawing.Color.Yellow;
            this.pCruiser.Controls.Add(this.lblCruiserTimeRemain);
            this.pCruiser.Controls.Add(this.tbCruiserCount);
            this.pCruiser.Controls.Add(this.lblCruiserShade);
            this.pCruiser.Controls.Add(this.lblCruiserDuration);
            this.pCruiser.Controls.Add(this.btnCruiserConstruct);
            this.pCruiser.Controls.Add(this.lblCruiserDeuteriumCost);
            this.pCruiser.Controls.Add(this.lblCruiserCrystalCost);
            this.pCruiser.Controls.Add(this.lblCruiserMetalCost);
            this.pCruiser.Controls.Add(this.lblCruiserCount);
            this.pCruiser.Controls.Add(this.lblCruiser);
            this.pCruiser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCruiser.Location = new System.Drawing.Point(3, 353);
            this.pCruiser.Name = "pCruiser";
            this.pCruiser.Size = new System.Drawing.Size(1890, 50);
            this.pCruiser.TabIndex = 10;
            // 
            // lblCruiserTimeRemain
            // 
            this.lblCruiserTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblCruiserTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCruiserTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblCruiserTimeRemain.Name = "lblCruiserTimeRemain";
            this.lblCruiserTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblCruiserTimeRemain.TabIndex = 15;
            this.lblCruiserTimeRemain.Text = "czas pozostały";
            this.lblCruiserTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCruiserCount
            // 
            this.tbCruiserCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbCruiserCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCruiserCount.Location = new System.Drawing.Point(1161, 17);
            this.tbCruiserCount.Name = "tbCruiserCount";
            this.tbCruiserCount.Size = new System.Drawing.Size(129, 16);
            this.tbCruiserCount.TabIndex = 4;
            this.tbCruiserCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCruiserShade
            // 
            this.lblCruiserShade.BackColor = System.Drawing.Color.White;
            this.lblCruiserShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCruiserShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCruiserShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCruiserShade.Location = new System.Drawing.Point(1160, 10);
            this.lblCruiserShade.Name = "lblCruiserShade";
            this.lblCruiserShade.Size = new System.Drawing.Size(130, 30);
            this.lblCruiserShade.TabIndex = 14;
            this.lblCruiserShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCruiserDuration
            // 
            this.lblCruiserDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblCruiserDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCruiserDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCruiserDuration.Location = new System.Drawing.Point(880, 10);
            this.lblCruiserDuration.Name = "lblCruiserDuration";
            this.lblCruiserDuration.Size = new System.Drawing.Size(130, 30);
            this.lblCruiserDuration.TabIndex = 13;
            this.lblCruiserDuration.Text = "czas";
            this.lblCruiserDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCruiserConstruct
            // 
            this.btnCruiserConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnCruiserConstruct.Enabled = false;
            this.btnCruiserConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCruiserConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnCruiserConstruct.Name = "btnCruiserConstruct";
            this.btnCruiserConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnCruiserConstruct.TabIndex = 12;
            this.btnCruiserConstruct.Text = "Zbuduj";
            this.btnCruiserConstruct.UseVisualStyleBackColor = false;
            this.btnCruiserConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblCruiserDeuteriumCost
            // 
            this.lblCruiserDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCruiserDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCruiserDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCruiserDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCruiserDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblCruiserDeuteriumCost.Name = "lblCruiserDeuteriumCost";
            this.lblCruiserDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblCruiserDeuteriumCost.TabIndex = 11;
            this.lblCruiserDeuteriumCost.Text = "deuter";
            this.lblCruiserDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCruiserCrystalCost
            // 
            this.lblCruiserCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCruiserCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCruiserCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCruiserCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCruiserCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblCruiserCrystalCost.Name = "lblCruiserCrystalCost";
            this.lblCruiserCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCruiserCrystalCost.TabIndex = 10;
            this.lblCruiserCrystalCost.Text = "kryształ";
            this.lblCruiserCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCruiserMetalCost
            // 
            this.lblCruiserMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCruiserMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCruiserMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCruiserMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCruiserMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblCruiserMetalCost.Name = "lblCruiserMetalCost";
            this.lblCruiserMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCruiserMetalCost.TabIndex = 9;
            this.lblCruiserMetalCost.Text = "metal";
            this.lblCruiserMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCruiserCount
            // 
            this.lblCruiserCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCruiserCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCruiserCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCruiserCount.Location = new System.Drawing.Point(320, 10);
            this.lblCruiserCount.Name = "lblCruiserCount";
            this.lblCruiserCount.Size = new System.Drawing.Size(130, 30);
            this.lblCruiserCount.TabIndex = 8;
            this.lblCruiserCount.Text = "Ilość";
            this.lblCruiserCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCruiser
            // 
            this.lblCruiser.BackColor = System.Drawing.Color.Transparent;
            this.lblCruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCruiser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCruiser.Location = new System.Drawing.Point(10, 10);
            this.lblCruiser.Name = "lblCruiser";
            this.lblCruiser.Size = new System.Drawing.Size(300, 30);
            this.lblCruiser.TabIndex = 7;
            this.lblCruiser.Text = "Krążkownik";
            this.lblCruiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHeavyFighter
            // 
            this.pHeavyFighter.BackColor = System.Drawing.Color.Gold;
            this.pHeavyFighter.Controls.Add(this.lblHeavyFighterTimeRemain);
            this.pHeavyFighter.Controls.Add(this.tbHeavyFighterCount);
            this.pHeavyFighter.Controls.Add(this.lblHeavyFighterShade);
            this.pHeavyFighter.Controls.Add(this.lblHeavyFighterDuration);
            this.pHeavyFighter.Controls.Add(this.btnHeavyFighterConstruct);
            this.pHeavyFighter.Controls.Add(this.lblHeavyFighterDeuteriumCost);
            this.pHeavyFighter.Controls.Add(this.lblHeavyFighterCrystalCost);
            this.pHeavyFighter.Controls.Add(this.lblHeavyFighterMetalCost);
            this.pHeavyFighter.Controls.Add(this.lblHeavyFighterCount);
            this.pHeavyFighter.Controls.Add(this.lblHeavyFighter);
            this.pHeavyFighter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeavyFighter.Location = new System.Drawing.Point(3, 303);
            this.pHeavyFighter.Name = "pHeavyFighter";
            this.pHeavyFighter.Size = new System.Drawing.Size(1890, 50);
            this.pHeavyFighter.TabIndex = 9;
            // 
            // lblHeavyFighterTimeRemain
            // 
            this.lblHeavyFighterTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyFighterTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyFighterTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblHeavyFighterTimeRemain.Name = "lblHeavyFighterTimeRemain";
            this.lblHeavyFighterTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyFighterTimeRemain.TabIndex = 15;
            this.lblHeavyFighterTimeRemain.Text = "czas pozostały";
            this.lblHeavyFighterTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHeavyFighterCount
            // 
            this.tbHeavyFighterCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbHeavyFighterCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHeavyFighterCount.Location = new System.Drawing.Point(1161, 17);
            this.tbHeavyFighterCount.Name = "tbHeavyFighterCount";
            this.tbHeavyFighterCount.Size = new System.Drawing.Size(129, 16);
            this.tbHeavyFighterCount.TabIndex = 4;
            this.tbHeavyFighterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHeavyFighterShade
            // 
            this.lblHeavyFighterShade.BackColor = System.Drawing.Color.White;
            this.lblHeavyFighterShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeavyFighterShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyFighterShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeavyFighterShade.Location = new System.Drawing.Point(1160, 10);
            this.lblHeavyFighterShade.Name = "lblHeavyFighterShade";
            this.lblHeavyFighterShade.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyFighterShade.TabIndex = 14;
            this.lblHeavyFighterShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyFighterDuration
            // 
            this.lblHeavyFighterDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyFighterDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyFighterDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyFighterDuration.Location = new System.Drawing.Point(880, 10);
            this.lblHeavyFighterDuration.Name = "lblHeavyFighterDuration";
            this.lblHeavyFighterDuration.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyFighterDuration.TabIndex = 13;
            this.lblHeavyFighterDuration.Text = "czas";
            this.lblHeavyFighterDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHeavyFighterConstruct
            // 
            this.btnHeavyFighterConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnHeavyFighterConstruct.Enabled = false;
            this.btnHeavyFighterConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeavyFighterConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnHeavyFighterConstruct.Name = "btnHeavyFighterConstruct";
            this.btnHeavyFighterConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnHeavyFighterConstruct.TabIndex = 12;
            this.btnHeavyFighterConstruct.Text = "Zbuduj";
            this.btnHeavyFighterConstruct.UseVisualStyleBackColor = false;
            this.btnHeavyFighterConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblHeavyFighterDeuteriumCost
            // 
            this.lblHeavyFighterDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyFighterDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyFighterDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyFighterDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeavyFighterDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblHeavyFighterDeuteriumCost.Name = "lblHeavyFighterDeuteriumCost";
            this.lblHeavyFighterDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyFighterDeuteriumCost.TabIndex = 11;
            this.lblHeavyFighterDeuteriumCost.Text = "deuter";
            this.lblHeavyFighterDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyFighterCrystalCost
            // 
            this.lblHeavyFighterCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyFighterCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyFighterCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyFighterCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeavyFighterCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblHeavyFighterCrystalCost.Name = "lblHeavyFighterCrystalCost";
            this.lblHeavyFighterCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyFighterCrystalCost.TabIndex = 10;
            this.lblHeavyFighterCrystalCost.Text = "kryształ";
            this.lblHeavyFighterCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyFighterMetalCost
            // 
            this.lblHeavyFighterMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyFighterMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyFighterMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyFighterMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeavyFighterMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblHeavyFighterMetalCost.Name = "lblHeavyFighterMetalCost";
            this.lblHeavyFighterMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyFighterMetalCost.TabIndex = 9;
            this.lblHeavyFighterMetalCost.Text = "metal";
            this.lblHeavyFighterMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyFighterCount
            // 
            this.lblHeavyFighterCount.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyFighterCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyFighterCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyFighterCount.Location = new System.Drawing.Point(320, 10);
            this.lblHeavyFighterCount.Name = "lblHeavyFighterCount";
            this.lblHeavyFighterCount.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyFighterCount.TabIndex = 8;
            this.lblHeavyFighterCount.Text = "Ilość";
            this.lblHeavyFighterCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyFighter
            // 
            this.lblHeavyFighter.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyFighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyFighter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyFighter.Location = new System.Drawing.Point(10, 10);
            this.lblHeavyFighter.Name = "lblHeavyFighter";
            this.lblHeavyFighter.Size = new System.Drawing.Size(300, 30);
            this.lblHeavyFighter.TabIndex = 7;
            this.lblHeavyFighter.Text = "Ciężki myśliwiec";
            this.lblHeavyFighter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLightFighter
            // 
            this.pLightFighter.BackColor = System.Drawing.Color.Yellow;
            this.pLightFighter.Controls.Add(this.lblLightFighterTimeRemain);
            this.pLightFighter.Controls.Add(this.tbLightFighterCount);
            this.pLightFighter.Controls.Add(this.lblLightFighterShade);
            this.pLightFighter.Controls.Add(this.lblLightFighterDuration);
            this.pLightFighter.Controls.Add(this.btnLightFighterConstruct);
            this.pLightFighter.Controls.Add(this.lblLightFighterDeuteriumCost);
            this.pLightFighter.Controls.Add(this.lblLightFighterCrystalCost);
            this.pLightFighter.Controls.Add(this.lblLightFighterMetalCost);
            this.pLightFighter.Controls.Add(this.lblLightFighterCount);
            this.pLightFighter.Controls.Add(this.lblLightFighter);
            this.pLightFighter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLightFighter.Location = new System.Drawing.Point(3, 253);
            this.pLightFighter.Name = "pLightFighter";
            this.pLightFighter.Size = new System.Drawing.Size(1890, 50);
            this.pLightFighter.TabIndex = 8;
            // 
            // lblLightFighterTimeRemain
            // 
            this.lblLightFighterTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblLightFighterTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightFighterTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblLightFighterTimeRemain.Name = "lblLightFighterTimeRemain";
            this.lblLightFighterTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblLightFighterTimeRemain.TabIndex = 15;
            this.lblLightFighterTimeRemain.Text = "czas pozostały";
            this.lblLightFighterTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLightFighterCount
            // 
            this.tbLightFighterCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLightFighterCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLightFighterCount.Location = new System.Drawing.Point(1161, 17);
            this.tbLightFighterCount.Name = "tbLightFighterCount";
            this.tbLightFighterCount.Size = new System.Drawing.Size(129, 16);
            this.tbLightFighterCount.TabIndex = 4;
            this.tbLightFighterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLightFighterShade
            // 
            this.lblLightFighterShade.BackColor = System.Drawing.Color.White;
            this.lblLightFighterShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLightFighterShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightFighterShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLightFighterShade.Location = new System.Drawing.Point(1160, 10);
            this.lblLightFighterShade.Name = "lblLightFighterShade";
            this.lblLightFighterShade.Size = new System.Drawing.Size(130, 30);
            this.lblLightFighterShade.TabIndex = 14;
            this.lblLightFighterShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightFighterDuration
            // 
            this.lblLightFighterDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblLightFighterDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightFighterDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightFighterDuration.Location = new System.Drawing.Point(880, 10);
            this.lblLightFighterDuration.Name = "lblLightFighterDuration";
            this.lblLightFighterDuration.Size = new System.Drawing.Size(130, 30);
            this.lblLightFighterDuration.TabIndex = 13;
            this.lblLightFighterDuration.Text = "czas";
            this.lblLightFighterDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLightFighterConstruct
            // 
            this.btnLightFighterConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnLightFighterConstruct.Enabled = false;
            this.btnLightFighterConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLightFighterConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnLightFighterConstruct.Name = "btnLightFighterConstruct";
            this.btnLightFighterConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnLightFighterConstruct.TabIndex = 12;
            this.btnLightFighterConstruct.Text = "Zbuduj";
            this.btnLightFighterConstruct.UseVisualStyleBackColor = false;
            this.btnLightFighterConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblLightFighterDeuteriumCost
            // 
            this.lblLightFighterDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLightFighterDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightFighterDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightFighterDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLightFighterDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblLightFighterDeuteriumCost.Name = "lblLightFighterDeuteriumCost";
            this.lblLightFighterDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblLightFighterDeuteriumCost.TabIndex = 11;
            this.lblLightFighterDeuteriumCost.Text = "deuter";
            this.lblLightFighterDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightFighterCrystalCost
            // 
            this.lblLightFighterCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLightFighterCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightFighterCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightFighterCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLightFighterCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblLightFighterCrystalCost.Name = "lblLightFighterCrystalCost";
            this.lblLightFighterCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLightFighterCrystalCost.TabIndex = 10;
            this.lblLightFighterCrystalCost.Text = "kryształ";
            this.lblLightFighterCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightFighterMetalCost
            // 
            this.lblLightFighterMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLightFighterMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightFighterMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightFighterMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLightFighterMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblLightFighterMetalCost.Name = "lblLightFighterMetalCost";
            this.lblLightFighterMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLightFighterMetalCost.TabIndex = 9;
            this.lblLightFighterMetalCost.Text = "metal";
            this.lblLightFighterMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightFighterCount
            // 
            this.lblLightFighterCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLightFighterCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightFighterCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightFighterCount.Location = new System.Drawing.Point(320, 10);
            this.lblLightFighterCount.Name = "lblLightFighterCount";
            this.lblLightFighterCount.Size = new System.Drawing.Size(130, 30);
            this.lblLightFighterCount.TabIndex = 8;
            this.lblLightFighterCount.Text = "Ilość";
            this.lblLightFighterCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightFighter
            // 
            this.lblLightFighter.BackColor = System.Drawing.Color.Transparent;
            this.lblLightFighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightFighter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightFighter.Location = new System.Drawing.Point(10, 10);
            this.lblLightFighter.Name = "lblLightFighter";
            this.lblLightFighter.Size = new System.Drawing.Size(300, 30);
            this.lblLightFighter.TabIndex = 7;
            this.lblLightFighter.Text = "Lekki myśliwiec";
            this.lblLightFighter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pEspionageProbe
            // 
            this.pEspionageProbe.BackColor = System.Drawing.Color.Gold;
            this.pEspionageProbe.Controls.Add(this.lblEspionageProbeTimeRemain);
            this.pEspionageProbe.Controls.Add(this.tbEspionageProbeCount);
            this.pEspionageProbe.Controls.Add(this.lblEspionageProbeShade);
            this.pEspionageProbe.Controls.Add(this.lblEspionageProbeDuration);
            this.pEspionageProbe.Controls.Add(this.btnEspionageProbeConstruct);
            this.pEspionageProbe.Controls.Add(this.lblEspionageProbeDeuteriumCost);
            this.pEspionageProbe.Controls.Add(this.lblEspionageProbeCrystalCost);
            this.pEspionageProbe.Controls.Add(this.lblEspionageProbeMetalCost);
            this.pEspionageProbe.Controls.Add(this.lblEspionageProbeCount);
            this.pEspionageProbe.Controls.Add(this.lblEspionageProbe);
            this.pEspionageProbe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pEspionageProbe.Location = new System.Drawing.Point(3, 203);
            this.pEspionageProbe.Name = "pEspionageProbe";
            this.pEspionageProbe.Size = new System.Drawing.Size(1890, 50);
            this.pEspionageProbe.TabIndex = 7;
            // 
            // lblEspionageProbeTimeRemain
            // 
            this.lblEspionageProbeTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageProbeTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageProbeTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblEspionageProbeTimeRemain.Name = "lblEspionageProbeTimeRemain";
            this.lblEspionageProbeTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageProbeTimeRemain.TabIndex = 15;
            this.lblEspionageProbeTimeRemain.Text = "czas pozostały";
            this.lblEspionageProbeTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEspionageProbeCount
            // 
            this.tbEspionageProbeCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbEspionageProbeCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEspionageProbeCount.Location = new System.Drawing.Point(1161, 17);
            this.tbEspionageProbeCount.Name = "tbEspionageProbeCount";
            this.tbEspionageProbeCount.Size = new System.Drawing.Size(129, 16);
            this.tbEspionageProbeCount.TabIndex = 4;
            this.tbEspionageProbeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEspionageProbeShade
            // 
            this.lblEspionageProbeShade.BackColor = System.Drawing.Color.White;
            this.lblEspionageProbeShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEspionageProbeShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageProbeShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEspionageProbeShade.Location = new System.Drawing.Point(1160, 10);
            this.lblEspionageProbeShade.Name = "lblEspionageProbeShade";
            this.lblEspionageProbeShade.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageProbeShade.TabIndex = 14;
            this.lblEspionageProbeShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageProbeDuration
            // 
            this.lblEspionageProbeDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageProbeDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageProbeDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageProbeDuration.Location = new System.Drawing.Point(880, 10);
            this.lblEspionageProbeDuration.Name = "lblEspionageProbeDuration";
            this.lblEspionageProbeDuration.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageProbeDuration.TabIndex = 13;
            this.lblEspionageProbeDuration.Text = "czas";
            this.lblEspionageProbeDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEspionageProbeConstruct
            // 
            this.btnEspionageProbeConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnEspionageProbeConstruct.Enabled = false;
            this.btnEspionageProbeConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEspionageProbeConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnEspionageProbeConstruct.Name = "btnEspionageProbeConstruct";
            this.btnEspionageProbeConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnEspionageProbeConstruct.TabIndex = 12;
            this.btnEspionageProbeConstruct.Text = "Zbuduj";
            this.btnEspionageProbeConstruct.UseVisualStyleBackColor = false;
            this.btnEspionageProbeConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblEspionageProbeDeuteriumCost
            // 
            this.lblEspionageProbeDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageProbeDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageProbeDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageProbeDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEspionageProbeDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblEspionageProbeDeuteriumCost.Name = "lblEspionageProbeDeuteriumCost";
            this.lblEspionageProbeDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageProbeDeuteriumCost.TabIndex = 11;
            this.lblEspionageProbeDeuteriumCost.Text = "deuter";
            this.lblEspionageProbeDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageProbeCrystalCost
            // 
            this.lblEspionageProbeCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageProbeCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageProbeCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageProbeCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEspionageProbeCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblEspionageProbeCrystalCost.Name = "lblEspionageProbeCrystalCost";
            this.lblEspionageProbeCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageProbeCrystalCost.TabIndex = 10;
            this.lblEspionageProbeCrystalCost.Text = "kryształ";
            this.lblEspionageProbeCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageProbeMetalCost
            // 
            this.lblEspionageProbeMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageProbeMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageProbeMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageProbeMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEspionageProbeMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblEspionageProbeMetalCost.Name = "lblEspionageProbeMetalCost";
            this.lblEspionageProbeMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageProbeMetalCost.TabIndex = 9;
            this.lblEspionageProbeMetalCost.Text = "metal";
            this.lblEspionageProbeMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageProbeCount
            // 
            this.lblEspionageProbeCount.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageProbeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageProbeCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageProbeCount.Location = new System.Drawing.Point(320, 10);
            this.lblEspionageProbeCount.Name = "lblEspionageProbeCount";
            this.lblEspionageProbeCount.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageProbeCount.TabIndex = 8;
            this.lblEspionageProbeCount.Text = "Ilość";
            this.lblEspionageProbeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspionageProbe
            // 
            this.lblEspionageProbe.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageProbe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageProbe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageProbe.Location = new System.Drawing.Point(10, 10);
            this.lblEspionageProbe.Name = "lblEspionageProbe";
            this.lblEspionageProbe.Size = new System.Drawing.Size(300, 30);
            this.lblEspionageProbe.TabIndex = 7;
            this.lblEspionageProbe.Text = "Sonda szpiegowska";
            this.lblEspionageProbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pRecycler
            // 
            this.pRecycler.BackColor = System.Drawing.Color.Yellow;
            this.pRecycler.Controls.Add(this.lblRecyclerTimeRemian);
            this.pRecycler.Controls.Add(this.tbRecyclerCount);
            this.pRecycler.Controls.Add(this.lblRecyclerShade);
            this.pRecycler.Controls.Add(this.lblRecyclerDuration);
            this.pRecycler.Controls.Add(this.btnRecyclerConstruct);
            this.pRecycler.Controls.Add(this.lblRecyclerDeuteriumCost);
            this.pRecycler.Controls.Add(this.lblRecyclerCrystalCost);
            this.pRecycler.Controls.Add(this.lblRecyclerMetalCost);
            this.pRecycler.Controls.Add(this.lblRecyclerCount);
            this.pRecycler.Controls.Add(this.lblRecycler);
            this.pRecycler.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRecycler.Location = new System.Drawing.Point(3, 153);
            this.pRecycler.Name = "pRecycler";
            this.pRecycler.Size = new System.Drawing.Size(1890, 50);
            this.pRecycler.TabIndex = 6;
            // 
            // lblRecyclerTimeRemian
            // 
            this.lblRecyclerTimeRemian.BackColor = System.Drawing.Color.Transparent;
            this.lblRecyclerTimeRemian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecyclerTimeRemian.Location = new System.Drawing.Point(1300, 10);
            this.lblRecyclerTimeRemian.Name = "lblRecyclerTimeRemian";
            this.lblRecyclerTimeRemian.Size = new System.Drawing.Size(130, 30);
            this.lblRecyclerTimeRemian.TabIndex = 15;
            this.lblRecyclerTimeRemian.Text = "czas pozostały";
            this.lblRecyclerTimeRemian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRecyclerCount
            // 
            this.tbRecyclerCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbRecyclerCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRecyclerCount.Location = new System.Drawing.Point(1161, 17);
            this.tbRecyclerCount.Name = "tbRecyclerCount";
            this.tbRecyclerCount.Size = new System.Drawing.Size(129, 16);
            this.tbRecyclerCount.TabIndex = 4;
            this.tbRecyclerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRecyclerShade
            // 
            this.lblRecyclerShade.BackColor = System.Drawing.Color.White;
            this.lblRecyclerShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecyclerShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecyclerShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecyclerShade.Location = new System.Drawing.Point(1160, 10);
            this.lblRecyclerShade.Name = "lblRecyclerShade";
            this.lblRecyclerShade.Size = new System.Drawing.Size(130, 30);
            this.lblRecyclerShade.TabIndex = 14;
            this.lblRecyclerShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecyclerDuration
            // 
            this.lblRecyclerDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblRecyclerDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecyclerDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecyclerDuration.Location = new System.Drawing.Point(880, 10);
            this.lblRecyclerDuration.Name = "lblRecyclerDuration";
            this.lblRecyclerDuration.Size = new System.Drawing.Size(130, 30);
            this.lblRecyclerDuration.TabIndex = 13;
            this.lblRecyclerDuration.Text = "czas";
            this.lblRecyclerDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRecyclerConstruct
            // 
            this.btnRecyclerConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnRecyclerConstruct.Enabled = false;
            this.btnRecyclerConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecyclerConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnRecyclerConstruct.Name = "btnRecyclerConstruct";
            this.btnRecyclerConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnRecyclerConstruct.TabIndex = 12;
            this.btnRecyclerConstruct.Text = "Zbuduj";
            this.btnRecyclerConstruct.UseVisualStyleBackColor = false;
            this.btnRecyclerConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblRecyclerDeuteriumCost
            // 
            this.lblRecyclerDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRecyclerDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecyclerDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecyclerDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecyclerDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblRecyclerDeuteriumCost.Name = "lblRecyclerDeuteriumCost";
            this.lblRecyclerDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblRecyclerDeuteriumCost.TabIndex = 11;
            this.lblRecyclerDeuteriumCost.Text = "deuter";
            this.lblRecyclerDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecyclerCrystalCost
            // 
            this.lblRecyclerCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRecyclerCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecyclerCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecyclerCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecyclerCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblRecyclerCrystalCost.Name = "lblRecyclerCrystalCost";
            this.lblRecyclerCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblRecyclerCrystalCost.TabIndex = 10;
            this.lblRecyclerCrystalCost.Text = "kryształ";
            this.lblRecyclerCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecyclerMetalCost
            // 
            this.lblRecyclerMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRecyclerMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecyclerMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecyclerMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecyclerMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblRecyclerMetalCost.Name = "lblRecyclerMetalCost";
            this.lblRecyclerMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblRecyclerMetalCost.TabIndex = 9;
            this.lblRecyclerMetalCost.Text = "metal";
            this.lblRecyclerMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecyclerCount
            // 
            this.lblRecyclerCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecyclerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecyclerCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecyclerCount.Location = new System.Drawing.Point(320, 10);
            this.lblRecyclerCount.Name = "lblRecyclerCount";
            this.lblRecyclerCount.Size = new System.Drawing.Size(130, 30);
            this.lblRecyclerCount.TabIndex = 8;
            this.lblRecyclerCount.Text = "Ilość";
            this.lblRecyclerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecycler
            // 
            this.lblRecycler.BackColor = System.Drawing.Color.Transparent;
            this.lblRecycler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecycler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecycler.Location = new System.Drawing.Point(10, 10);
            this.lblRecycler.Name = "lblRecycler";
            this.lblRecycler.Size = new System.Drawing.Size(300, 30);
            this.lblRecycler.TabIndex = 7;
            this.lblRecycler.Text = "Recycler";
            this.lblRecycler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pColonyShip
            // 
            this.pColonyShip.BackColor = System.Drawing.Color.Gold;
            this.pColonyShip.Controls.Add(this.lblColonyShipTimeRemain);
            this.pColonyShip.Controls.Add(this.tbColonyShipCount);
            this.pColonyShip.Controls.Add(this.lblColonyShipShade);
            this.pColonyShip.Controls.Add(this.lblColonyShipDuration);
            this.pColonyShip.Controls.Add(this.btnColonyShipConstruct);
            this.pColonyShip.Controls.Add(this.lblColonyShipDeuteriumCost);
            this.pColonyShip.Controls.Add(this.lblColonyShipCrystalCost);
            this.pColonyShip.Controls.Add(this.lblColonyShipMetalCost);
            this.pColonyShip.Controls.Add(this.lblColonyShipCount);
            this.pColonyShip.Controls.Add(this.lblColonyShip);
            this.pColonyShip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pColonyShip.Location = new System.Drawing.Point(3, 103);
            this.pColonyShip.Name = "pColonyShip";
            this.pColonyShip.Size = new System.Drawing.Size(1890, 50);
            this.pColonyShip.TabIndex = 5;
            // 
            // lblColonyShipTimeRemain
            // 
            this.lblColonyShipTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblColonyShipTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColonyShipTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblColonyShipTimeRemain.Name = "lblColonyShipTimeRemain";
            this.lblColonyShipTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblColonyShipTimeRemain.TabIndex = 15;
            this.lblColonyShipTimeRemain.Text = "czas pozostały";
            this.lblColonyShipTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbColonyShipCount
            // 
            this.tbColonyShipCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbColonyShipCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbColonyShipCount.Location = new System.Drawing.Point(1161, 17);
            this.tbColonyShipCount.Name = "tbColonyShipCount";
            this.tbColonyShipCount.Size = new System.Drawing.Size(129, 16);
            this.tbColonyShipCount.TabIndex = 4;
            this.tbColonyShipCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblColonyShipShade
            // 
            this.lblColonyShipShade.BackColor = System.Drawing.Color.White;
            this.lblColonyShipShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColonyShipShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColonyShipShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblColonyShipShade.Location = new System.Drawing.Point(1160, 10);
            this.lblColonyShipShade.Name = "lblColonyShipShade";
            this.lblColonyShipShade.Size = new System.Drawing.Size(130, 30);
            this.lblColonyShipShade.TabIndex = 14;
            this.lblColonyShipShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColonyShipDuration
            // 
            this.lblColonyShipDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblColonyShipDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColonyShipDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColonyShipDuration.Location = new System.Drawing.Point(880, 10);
            this.lblColonyShipDuration.Name = "lblColonyShipDuration";
            this.lblColonyShipDuration.Size = new System.Drawing.Size(130, 30);
            this.lblColonyShipDuration.TabIndex = 13;
            this.lblColonyShipDuration.Text = "czas";
            this.lblColonyShipDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnColonyShipConstruct
            // 
            this.btnColonyShipConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnColonyShipConstruct.Enabled = false;
            this.btnColonyShipConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnColonyShipConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnColonyShipConstruct.Name = "btnColonyShipConstruct";
            this.btnColonyShipConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnColonyShipConstruct.TabIndex = 12;
            this.btnColonyShipConstruct.Text = "Zbuduj";
            this.btnColonyShipConstruct.UseVisualStyleBackColor = false;
            this.btnColonyShipConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblColonyShipDeuteriumCost
            // 
            this.lblColonyShipDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblColonyShipDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColonyShipDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColonyShipDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblColonyShipDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblColonyShipDeuteriumCost.Name = "lblColonyShipDeuteriumCost";
            this.lblColonyShipDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblColonyShipDeuteriumCost.TabIndex = 11;
            this.lblColonyShipDeuteriumCost.Text = "deuter";
            this.lblColonyShipDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColonyShipCrystalCost
            // 
            this.lblColonyShipCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblColonyShipCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColonyShipCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColonyShipCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblColonyShipCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblColonyShipCrystalCost.Name = "lblColonyShipCrystalCost";
            this.lblColonyShipCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblColonyShipCrystalCost.TabIndex = 10;
            this.lblColonyShipCrystalCost.Text = "kryształ";
            this.lblColonyShipCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColonyShipMetalCost
            // 
            this.lblColonyShipMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblColonyShipMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColonyShipMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColonyShipMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblColonyShipMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblColonyShipMetalCost.Name = "lblColonyShipMetalCost";
            this.lblColonyShipMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblColonyShipMetalCost.TabIndex = 9;
            this.lblColonyShipMetalCost.Text = "metal";
            this.lblColonyShipMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColonyShipCount
            // 
            this.lblColonyShipCount.BackColor = System.Drawing.Color.Transparent;
            this.lblColonyShipCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColonyShipCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColonyShipCount.Location = new System.Drawing.Point(320, 10);
            this.lblColonyShipCount.Name = "lblColonyShipCount";
            this.lblColonyShipCount.Size = new System.Drawing.Size(130, 30);
            this.lblColonyShipCount.TabIndex = 8;
            this.lblColonyShipCount.Text = "Ilość";
            this.lblColonyShipCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColonyShip
            // 
            this.lblColonyShip.BackColor = System.Drawing.Color.Transparent;
            this.lblColonyShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColonyShip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColonyShip.Location = new System.Drawing.Point(10, 10);
            this.lblColonyShip.Name = "lblColonyShip";
            this.lblColonyShip.Size = new System.Drawing.Size(300, 30);
            this.lblColonyShip.TabIndex = 7;
            this.lblColonyShip.Text = "Statek kolonizacyjny";
            this.lblColonyShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLargeCargo
            // 
            this.pLargeCargo.BackColor = System.Drawing.Color.Yellow;
            this.pLargeCargo.Controls.Add(this.lblLargeCargoTimeRemain);
            this.pLargeCargo.Controls.Add(this.tbLargeCargoCount);
            this.pLargeCargo.Controls.Add(this.lblLargeCargoShade);
            this.pLargeCargo.Controls.Add(this.lblLargeCargoDuration);
            this.pLargeCargo.Controls.Add(this.btnLargeCargoConstruct);
            this.pLargeCargo.Controls.Add(this.lblLargeCargoDeuteriumCost);
            this.pLargeCargo.Controls.Add(this.lblLargeCargoCrystalCost);
            this.pLargeCargo.Controls.Add(this.lblLargeCargoMetalCost);
            this.pLargeCargo.Controls.Add(this.lblLargeCargoCount);
            this.pLargeCargo.Controls.Add(this.lblLargeCargo);
            this.pLargeCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLargeCargo.Location = new System.Drawing.Point(3, 53);
            this.pLargeCargo.Name = "pLargeCargo";
            this.pLargeCargo.Size = new System.Drawing.Size(1890, 50);
            this.pLargeCargo.TabIndex = 4;
            // 
            // lblLargeCargoTimeRemain
            // 
            this.lblLargeCargoTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeCargoTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeCargoTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblLargeCargoTimeRemain.Name = "lblLargeCargoTimeRemain";
            this.lblLargeCargoTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblLargeCargoTimeRemain.TabIndex = 15;
            this.lblLargeCargoTimeRemain.Text = "czas pozostały";
            this.lblLargeCargoTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLargeCargoCount
            // 
            this.tbLargeCargoCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLargeCargoCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLargeCargoCount.Location = new System.Drawing.Point(1161, 17);
            this.tbLargeCargoCount.Name = "tbLargeCargoCount";
            this.tbLargeCargoCount.Size = new System.Drawing.Size(129, 16);
            this.tbLargeCargoCount.TabIndex = 4;
            this.tbLargeCargoCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLargeCargoShade
            // 
            this.lblLargeCargoShade.BackColor = System.Drawing.Color.White;
            this.lblLargeCargoShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLargeCargoShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeCargoShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLargeCargoShade.Location = new System.Drawing.Point(1160, 10);
            this.lblLargeCargoShade.Name = "lblLargeCargoShade";
            this.lblLargeCargoShade.Size = new System.Drawing.Size(130, 30);
            this.lblLargeCargoShade.TabIndex = 14;
            this.lblLargeCargoShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeCargoDuration
            // 
            this.lblLargeCargoDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeCargoDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeCargoDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeCargoDuration.Location = new System.Drawing.Point(880, 10);
            this.lblLargeCargoDuration.Name = "lblLargeCargoDuration";
            this.lblLargeCargoDuration.Size = new System.Drawing.Size(130, 30);
            this.lblLargeCargoDuration.TabIndex = 13;
            this.lblLargeCargoDuration.Text = "czas";
            this.lblLargeCargoDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLargeCargoConstruct
            // 
            this.btnLargeCargoConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnLargeCargoConstruct.Enabled = false;
            this.btnLargeCargoConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLargeCargoConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnLargeCargoConstruct.Name = "btnLargeCargoConstruct";
            this.btnLargeCargoConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnLargeCargoConstruct.TabIndex = 12;
            this.btnLargeCargoConstruct.Text = "Zbuduj";
            this.btnLargeCargoConstruct.UseVisualStyleBackColor = false;
            this.btnLargeCargoConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblLargeCargoDeuteriumCost
            // 
            this.lblLargeCargoDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeCargoDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeCargoDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeCargoDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLargeCargoDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblLargeCargoDeuteriumCost.Name = "lblLargeCargoDeuteriumCost";
            this.lblLargeCargoDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblLargeCargoDeuteriumCost.TabIndex = 11;
            this.lblLargeCargoDeuteriumCost.Text = "deuter";
            this.lblLargeCargoDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeCargoCrystalCost
            // 
            this.lblLargeCargoCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeCargoCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeCargoCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeCargoCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLargeCargoCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblLargeCargoCrystalCost.Name = "lblLargeCargoCrystalCost";
            this.lblLargeCargoCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLargeCargoCrystalCost.TabIndex = 10;
            this.lblLargeCargoCrystalCost.Text = "kryształ";
            this.lblLargeCargoCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeCargoMetalCost
            // 
            this.lblLargeCargoMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeCargoMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeCargoMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeCargoMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLargeCargoMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblLargeCargoMetalCost.Name = "lblLargeCargoMetalCost";
            this.lblLargeCargoMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLargeCargoMetalCost.TabIndex = 9;
            this.lblLargeCargoMetalCost.Text = "metal";
            this.lblLargeCargoMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeCargoCount
            // 
            this.lblLargeCargoCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeCargoCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeCargoCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeCargoCount.Location = new System.Drawing.Point(320, 10);
            this.lblLargeCargoCount.Name = "lblLargeCargoCount";
            this.lblLargeCargoCount.Size = new System.Drawing.Size(130, 30);
            this.lblLargeCargoCount.TabIndex = 8;
            this.lblLargeCargoCount.Text = "Ilość";
            this.lblLargeCargoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeCargo
            // 
            this.lblLargeCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeCargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeCargo.Location = new System.Drawing.Point(10, 10);
            this.lblLargeCargo.Name = "lblLargeCargo";
            this.lblLargeCargo.Size = new System.Drawing.Size(300, 30);
            this.lblLargeCargo.TabIndex = 7;
            this.lblLargeCargo.Text = "Duży transporter";
            this.lblLargeCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSmallCargo
            // 
            this.pSmallCargo.BackColor = System.Drawing.Color.Gold;
            this.pSmallCargo.Controls.Add(this.lblSmallCargoTimeRemain);
            this.pSmallCargo.Controls.Add(this.tbSmallCargoCount);
            this.pSmallCargo.Controls.Add(this.lblSmallCargoShade);
            this.pSmallCargo.Controls.Add(this.lblSmallCargoDuration);
            this.pSmallCargo.Controls.Add(this.btnSmallCargoConstruct);
            this.pSmallCargo.Controls.Add(this.lblSmallCargoDeuteriumCost);
            this.pSmallCargo.Controls.Add(this.lblSmallCargoCrystalCost);
            this.pSmallCargo.Controls.Add(this.lblSmallCargoMetalCost);
            this.pSmallCargo.Controls.Add(this.lblSmallCargoCount);
            this.pSmallCargo.Controls.Add(this.lblSmallCargo);
            this.pSmallCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSmallCargo.Location = new System.Drawing.Point(3, 3);
            this.pSmallCargo.Name = "pSmallCargo";
            this.pSmallCargo.Size = new System.Drawing.Size(1890, 50);
            this.pSmallCargo.TabIndex = 3;
            // 
            // lblSmallCargoTimeRemain
            // 
            this.lblSmallCargoTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallCargoTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallCargoTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblSmallCargoTimeRemain.Name = "lblSmallCargoTimeRemain";
            this.lblSmallCargoTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblSmallCargoTimeRemain.TabIndex = 15;
            this.lblSmallCargoTimeRemain.Text = "czas pozostały";
            this.lblSmallCargoTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSmallCargoCount
            // 
            this.tbSmallCargoCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbSmallCargoCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSmallCargoCount.Location = new System.Drawing.Point(1161, 17);
            this.tbSmallCargoCount.Name = "tbSmallCargoCount";
            this.tbSmallCargoCount.Size = new System.Drawing.Size(129, 16);
            this.tbSmallCargoCount.TabIndex = 4;
            this.tbSmallCargoCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSmallCargoShade
            // 
            this.lblSmallCargoShade.BackColor = System.Drawing.Color.White;
            this.lblSmallCargoShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSmallCargoShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallCargoShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSmallCargoShade.Location = new System.Drawing.Point(1160, 10);
            this.lblSmallCargoShade.Name = "lblSmallCargoShade";
            this.lblSmallCargoShade.Size = new System.Drawing.Size(130, 30);
            this.lblSmallCargoShade.TabIndex = 14;
            this.lblSmallCargoShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallCargoDuration
            // 
            this.lblSmallCargoDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallCargoDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallCargoDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallCargoDuration.Location = new System.Drawing.Point(880, 10);
            this.lblSmallCargoDuration.Name = "lblSmallCargoDuration";
            this.lblSmallCargoDuration.Size = new System.Drawing.Size(130, 30);
            this.lblSmallCargoDuration.TabIndex = 13;
            this.lblSmallCargoDuration.Text = "czas";
            this.lblSmallCargoDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSmallCargoConstruct
            // 
            this.btnSmallCargoConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnSmallCargoConstruct.Enabled = false;
            this.btnSmallCargoConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSmallCargoConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnSmallCargoConstruct.Name = "btnSmallCargoConstruct";
            this.btnSmallCargoConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnSmallCargoConstruct.TabIndex = 12;
            this.btnSmallCargoConstruct.Text = "Zbuduj";
            this.btnSmallCargoConstruct.UseVisualStyleBackColor = false;
            this.btnSmallCargoConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblSmallCargoDeuteriumCost
            // 
            this.lblSmallCargoDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallCargoDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallCargoDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallCargoDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSmallCargoDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblSmallCargoDeuteriumCost.Name = "lblSmallCargoDeuteriumCost";
            this.lblSmallCargoDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblSmallCargoDeuteriumCost.TabIndex = 11;
            this.lblSmallCargoDeuteriumCost.Text = "deuter";
            this.lblSmallCargoDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallCargoCrystalCost
            // 
            this.lblSmallCargoCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallCargoCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallCargoCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallCargoCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSmallCargoCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblSmallCargoCrystalCost.Name = "lblSmallCargoCrystalCost";
            this.lblSmallCargoCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSmallCargoCrystalCost.TabIndex = 10;
            this.lblSmallCargoCrystalCost.Text = "kryształ";
            this.lblSmallCargoCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallCargoMetalCost
            // 
            this.lblSmallCargoMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallCargoMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallCargoMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallCargoMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSmallCargoMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblSmallCargoMetalCost.Name = "lblSmallCargoMetalCost";
            this.lblSmallCargoMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSmallCargoMetalCost.TabIndex = 9;
            this.lblSmallCargoMetalCost.Text = "metal";
            this.lblSmallCargoMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallCargoCount
            // 
            this.lblSmallCargoCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallCargoCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallCargoCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallCargoCount.Location = new System.Drawing.Point(320, 10);
            this.lblSmallCargoCount.Name = "lblSmallCargoCount";
            this.lblSmallCargoCount.Size = new System.Drawing.Size(130, 30);
            this.lblSmallCargoCount.TabIndex = 8;
            this.lblSmallCargoCount.Text = "Ilość";
            this.lblSmallCargoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallCargo
            // 
            this.lblSmallCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallCargo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallCargo.Location = new System.Drawing.Point(10, 10);
            this.lblSmallCargo.Name = "lblSmallCargo";
            this.lblSmallCargo.Size = new System.Drawing.Size(300, 30);
            this.lblSmallCargo.TabIndex = 7;
            this.lblSmallCargo.Text = "Mały transporter";
            this.lblSmallCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpDefence
            // 
            this.tpDefence.BackColor = System.Drawing.Color.Silver;
            this.tpDefence.Controls.Add(this.pInterplanetaryMissile);
            this.tpDefence.Controls.Add(this.pAntiBallisticMissile);
            this.tpDefence.Controls.Add(this.pLargeShieldDome);
            this.tpDefence.Controls.Add(this.pSmallShieldDome);
            this.tpDefence.Controls.Add(this.pPlasmaTurret);
            this.tpDefence.Controls.Add(this.pIonCannon);
            this.tpDefence.Controls.Add(this.pGaussCannon);
            this.tpDefence.Controls.Add(this.pHeavyLaser);
            this.tpDefence.Controls.Add(this.pLightLaser);
            this.tpDefence.Controls.Add(this.pRocketLauncher);
            this.tpDefence.Controls.Add(this.pCrawler);
            this.tpDefence.Controls.Add(this.pSolarSatellite);
            this.tpDefence.Location = new System.Drawing.Point(4, 29);
            this.tpDefence.Name = "tpDefence";
            this.tpDefence.Padding = new System.Windows.Forms.Padding(3);
            this.tpDefence.Size = new System.Drawing.Size(1896, 800);
            this.tpDefence.TabIndex = 3;
            this.tpDefence.Text = "Obrona";
            // 
            // pInterplanetaryMissile
            // 
            this.pInterplanetaryMissile.BackColor = System.Drawing.Color.Yellow;
            this.pInterplanetaryMissile.Controls.Add(this.lblInterplanetaryMissileTimeRemain);
            this.pInterplanetaryMissile.Controls.Add(this.tbInterplanetaryMissileCount);
            this.pInterplanetaryMissile.Controls.Add(this.lblInterplanetaryMissileShade);
            this.pInterplanetaryMissile.Controls.Add(this.lblInterplanetaryMissileDuration);
            this.pInterplanetaryMissile.Controls.Add(this.btnInterplanetaryMissileConstruct);
            this.pInterplanetaryMissile.Controls.Add(this.lblInterplanetaryMissileDeuteriumCost);
            this.pInterplanetaryMissile.Controls.Add(this.lblInterplanetaryMissileCrystalCost);
            this.pInterplanetaryMissile.Controls.Add(this.lblInterplanetaryMissileMetalCost);
            this.pInterplanetaryMissile.Controls.Add(this.lblInterplanetaryMissileCount);
            this.pInterplanetaryMissile.Controls.Add(this.lblInterplanetaryMissile);
            this.pInterplanetaryMissile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInterplanetaryMissile.Location = new System.Drawing.Point(3, 553);
            this.pInterplanetaryMissile.Name = "pInterplanetaryMissile";
            this.pInterplanetaryMissile.Size = new System.Drawing.Size(1890, 50);
            this.pInterplanetaryMissile.TabIndex = 15;
            // 
            // lblInterplanetaryMissileTimeRemain
            // 
            this.lblInterplanetaryMissileTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblInterplanetaryMissileTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterplanetaryMissileTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblInterplanetaryMissileTimeRemain.Name = "lblInterplanetaryMissileTimeRemain";
            this.lblInterplanetaryMissileTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblInterplanetaryMissileTimeRemain.TabIndex = 15;
            this.lblInterplanetaryMissileTimeRemain.Text = "czas pozostały";
            this.lblInterplanetaryMissileTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInterplanetaryMissileCount
            // 
            this.tbInterplanetaryMissileCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbInterplanetaryMissileCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInterplanetaryMissileCount.Location = new System.Drawing.Point(1161, 17);
            this.tbInterplanetaryMissileCount.Name = "tbInterplanetaryMissileCount";
            this.tbInterplanetaryMissileCount.Size = new System.Drawing.Size(129, 16);
            this.tbInterplanetaryMissileCount.TabIndex = 4;
            this.tbInterplanetaryMissileCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInterplanetaryMissileShade
            // 
            this.lblInterplanetaryMissileShade.BackColor = System.Drawing.Color.White;
            this.lblInterplanetaryMissileShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInterplanetaryMissileShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterplanetaryMissileShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInterplanetaryMissileShade.Location = new System.Drawing.Point(1160, 10);
            this.lblInterplanetaryMissileShade.Name = "lblInterplanetaryMissileShade";
            this.lblInterplanetaryMissileShade.Size = new System.Drawing.Size(130, 30);
            this.lblInterplanetaryMissileShade.TabIndex = 14;
            this.lblInterplanetaryMissileShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterplanetaryMissileDuration
            // 
            this.lblInterplanetaryMissileDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblInterplanetaryMissileDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInterplanetaryMissileDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterplanetaryMissileDuration.Location = new System.Drawing.Point(880, 10);
            this.lblInterplanetaryMissileDuration.Name = "lblInterplanetaryMissileDuration";
            this.lblInterplanetaryMissileDuration.Size = new System.Drawing.Size(130, 30);
            this.lblInterplanetaryMissileDuration.TabIndex = 13;
            this.lblInterplanetaryMissileDuration.Text = "czas";
            this.lblInterplanetaryMissileDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInterplanetaryMissileConstruct
            // 
            this.btnInterplanetaryMissileConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnInterplanetaryMissileConstruct.Enabled = false;
            this.btnInterplanetaryMissileConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInterplanetaryMissileConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnInterplanetaryMissileConstruct.Name = "btnInterplanetaryMissileConstruct";
            this.btnInterplanetaryMissileConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnInterplanetaryMissileConstruct.TabIndex = 12;
            this.btnInterplanetaryMissileConstruct.Text = "Zbuduj";
            this.btnInterplanetaryMissileConstruct.UseVisualStyleBackColor = false;
            this.btnInterplanetaryMissileConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblInterplanetaryMissileDeuteriumCost
            // 
            this.lblInterplanetaryMissileDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblInterplanetaryMissileDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInterplanetaryMissileDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterplanetaryMissileDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInterplanetaryMissileDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblInterplanetaryMissileDeuteriumCost.Name = "lblInterplanetaryMissileDeuteriumCost";
            this.lblInterplanetaryMissileDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblInterplanetaryMissileDeuteriumCost.TabIndex = 11;
            this.lblInterplanetaryMissileDeuteriumCost.Text = "deuter";
            this.lblInterplanetaryMissileDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterplanetaryMissileCrystalCost
            // 
            this.lblInterplanetaryMissileCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblInterplanetaryMissileCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInterplanetaryMissileCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterplanetaryMissileCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInterplanetaryMissileCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblInterplanetaryMissileCrystalCost.Name = "lblInterplanetaryMissileCrystalCost";
            this.lblInterplanetaryMissileCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblInterplanetaryMissileCrystalCost.TabIndex = 10;
            this.lblInterplanetaryMissileCrystalCost.Text = "kryształ";
            this.lblInterplanetaryMissileCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterplanetaryMissileMetalCost
            // 
            this.lblInterplanetaryMissileMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblInterplanetaryMissileMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInterplanetaryMissileMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterplanetaryMissileMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInterplanetaryMissileMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblInterplanetaryMissileMetalCost.Name = "lblInterplanetaryMissileMetalCost";
            this.lblInterplanetaryMissileMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblInterplanetaryMissileMetalCost.TabIndex = 9;
            this.lblInterplanetaryMissileMetalCost.Text = "metal";
            this.lblInterplanetaryMissileMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterplanetaryMissileCount
            // 
            this.lblInterplanetaryMissileCount.BackColor = System.Drawing.Color.Transparent;
            this.lblInterplanetaryMissileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInterplanetaryMissileCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterplanetaryMissileCount.Location = new System.Drawing.Point(320, 10);
            this.lblInterplanetaryMissileCount.Name = "lblInterplanetaryMissileCount";
            this.lblInterplanetaryMissileCount.Size = new System.Drawing.Size(130, 30);
            this.lblInterplanetaryMissileCount.TabIndex = 8;
            this.lblInterplanetaryMissileCount.Text = "Ilość";
            this.lblInterplanetaryMissileCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInterplanetaryMissile
            // 
            this.lblInterplanetaryMissile.BackColor = System.Drawing.Color.Transparent;
            this.lblInterplanetaryMissile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInterplanetaryMissile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInterplanetaryMissile.Location = new System.Drawing.Point(10, 10);
            this.lblInterplanetaryMissile.Name = "lblInterplanetaryMissile";
            this.lblInterplanetaryMissile.Size = new System.Drawing.Size(300, 30);
            this.lblInterplanetaryMissile.TabIndex = 7;
            this.lblInterplanetaryMissile.Text = "Rakieta międzyplanetarna";
            this.lblInterplanetaryMissile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pAntiBallisticMissile
            // 
            this.pAntiBallisticMissile.BackColor = System.Drawing.Color.Gold;
            this.pAntiBallisticMissile.Controls.Add(this.lblAntiBallisticMissileTimeRemain);
            this.pAntiBallisticMissile.Controls.Add(this.tbAntiBallisticMissileCount);
            this.pAntiBallisticMissile.Controls.Add(this.lblAntiBallisticMissileShade);
            this.pAntiBallisticMissile.Controls.Add(this.lblAntiBallisticMissileDuration);
            this.pAntiBallisticMissile.Controls.Add(this.btnAntiBallisticMissileConstruct);
            this.pAntiBallisticMissile.Controls.Add(this.lblAntiBallisticMissileDeuteriumCost);
            this.pAntiBallisticMissile.Controls.Add(this.lblAntiBallisticMissileCrystalCost);
            this.pAntiBallisticMissile.Controls.Add(this.lblAntiBallisticMissileMetalCost);
            this.pAntiBallisticMissile.Controls.Add(this.lblAntiBallisticMissileCount);
            this.pAntiBallisticMissile.Controls.Add(this.lblAntiBallisticMissile);
            this.pAntiBallisticMissile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAntiBallisticMissile.Location = new System.Drawing.Point(3, 503);
            this.pAntiBallisticMissile.Name = "pAntiBallisticMissile";
            this.pAntiBallisticMissile.Size = new System.Drawing.Size(1890, 50);
            this.pAntiBallisticMissile.TabIndex = 14;
            // 
            // lblAntiBallisticMissileTimeRemain
            // 
            this.lblAntiBallisticMissileTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblAntiBallisticMissileTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAntiBallisticMissileTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblAntiBallisticMissileTimeRemain.Name = "lblAntiBallisticMissileTimeRemain";
            this.lblAntiBallisticMissileTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblAntiBallisticMissileTimeRemain.TabIndex = 15;
            this.lblAntiBallisticMissileTimeRemain.Text = "czas pozostały";
            this.lblAntiBallisticMissileTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAntiBallisticMissileCount
            // 
            this.tbAntiBallisticMissileCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbAntiBallisticMissileCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAntiBallisticMissileCount.Location = new System.Drawing.Point(1161, 17);
            this.tbAntiBallisticMissileCount.Name = "tbAntiBallisticMissileCount";
            this.tbAntiBallisticMissileCount.Size = new System.Drawing.Size(129, 16);
            this.tbAntiBallisticMissileCount.TabIndex = 4;
            this.tbAntiBallisticMissileCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAntiBallisticMissileShade
            // 
            this.lblAntiBallisticMissileShade.BackColor = System.Drawing.Color.White;
            this.lblAntiBallisticMissileShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAntiBallisticMissileShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAntiBallisticMissileShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAntiBallisticMissileShade.Location = new System.Drawing.Point(1160, 10);
            this.lblAntiBallisticMissileShade.Name = "lblAntiBallisticMissileShade";
            this.lblAntiBallisticMissileShade.Size = new System.Drawing.Size(130, 30);
            this.lblAntiBallisticMissileShade.TabIndex = 14;
            this.lblAntiBallisticMissileShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAntiBallisticMissileDuration
            // 
            this.lblAntiBallisticMissileDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblAntiBallisticMissileDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAntiBallisticMissileDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAntiBallisticMissileDuration.Location = new System.Drawing.Point(880, 10);
            this.lblAntiBallisticMissileDuration.Name = "lblAntiBallisticMissileDuration";
            this.lblAntiBallisticMissileDuration.Size = new System.Drawing.Size(130, 30);
            this.lblAntiBallisticMissileDuration.TabIndex = 13;
            this.lblAntiBallisticMissileDuration.Text = "czas";
            this.lblAntiBallisticMissileDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAntiBallisticMissileConstruct
            // 
            this.btnAntiBallisticMissileConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnAntiBallisticMissileConstruct.Enabled = false;
            this.btnAntiBallisticMissileConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAntiBallisticMissileConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnAntiBallisticMissileConstruct.Name = "btnAntiBallisticMissileConstruct";
            this.btnAntiBallisticMissileConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnAntiBallisticMissileConstruct.TabIndex = 12;
            this.btnAntiBallisticMissileConstruct.Text = "Zbuduj";
            this.btnAntiBallisticMissileConstruct.UseVisualStyleBackColor = false;
            this.btnAntiBallisticMissileConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblAntiBallisticMissileDeuteriumCost
            // 
            this.lblAntiBallisticMissileDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblAntiBallisticMissileDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAntiBallisticMissileDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAntiBallisticMissileDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAntiBallisticMissileDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblAntiBallisticMissileDeuteriumCost.Name = "lblAntiBallisticMissileDeuteriumCost";
            this.lblAntiBallisticMissileDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblAntiBallisticMissileDeuteriumCost.TabIndex = 11;
            this.lblAntiBallisticMissileDeuteriumCost.Text = "deuter";
            this.lblAntiBallisticMissileDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAntiBallisticMissileCrystalCost
            // 
            this.lblAntiBallisticMissileCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblAntiBallisticMissileCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAntiBallisticMissileCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAntiBallisticMissileCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAntiBallisticMissileCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblAntiBallisticMissileCrystalCost.Name = "lblAntiBallisticMissileCrystalCost";
            this.lblAntiBallisticMissileCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblAntiBallisticMissileCrystalCost.TabIndex = 10;
            this.lblAntiBallisticMissileCrystalCost.Text = "kryształ";
            this.lblAntiBallisticMissileCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAntiBallisticMissileMetalCost
            // 
            this.lblAntiBallisticMissileMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblAntiBallisticMissileMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAntiBallisticMissileMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAntiBallisticMissileMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAntiBallisticMissileMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblAntiBallisticMissileMetalCost.Name = "lblAntiBallisticMissileMetalCost";
            this.lblAntiBallisticMissileMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblAntiBallisticMissileMetalCost.TabIndex = 9;
            this.lblAntiBallisticMissileMetalCost.Text = "metal";
            this.lblAntiBallisticMissileMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAntiBallisticMissileCount
            // 
            this.lblAntiBallisticMissileCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAntiBallisticMissileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAntiBallisticMissileCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAntiBallisticMissileCount.Location = new System.Drawing.Point(320, 10);
            this.lblAntiBallisticMissileCount.Name = "lblAntiBallisticMissileCount";
            this.lblAntiBallisticMissileCount.Size = new System.Drawing.Size(130, 30);
            this.lblAntiBallisticMissileCount.TabIndex = 8;
            this.lblAntiBallisticMissileCount.Text = "Ilość";
            this.lblAntiBallisticMissileCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAntiBallisticMissile
            // 
            this.lblAntiBallisticMissile.BackColor = System.Drawing.Color.Transparent;
            this.lblAntiBallisticMissile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAntiBallisticMissile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAntiBallisticMissile.Location = new System.Drawing.Point(10, 10);
            this.lblAntiBallisticMissile.Name = "lblAntiBallisticMissile";
            this.lblAntiBallisticMissile.Size = new System.Drawing.Size(300, 30);
            this.lblAntiBallisticMissile.TabIndex = 7;
            this.lblAntiBallisticMissile.Text = "Przeciwrakieta";
            this.lblAntiBallisticMissile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLargeShieldDome
            // 
            this.pLargeShieldDome.BackColor = System.Drawing.Color.Yellow;
            this.pLargeShieldDome.Controls.Add(this.lblLargeShieldDomeTimeRemain);
            this.pLargeShieldDome.Controls.Add(this.tbLargeShieldDomeCount);
            this.pLargeShieldDome.Controls.Add(this.lblLargeShieldDomeShade);
            this.pLargeShieldDome.Controls.Add(this.lblLargeShieldDomeDuration);
            this.pLargeShieldDome.Controls.Add(this.btnLargeShieldDomeConstruct);
            this.pLargeShieldDome.Controls.Add(this.lblLargeShieldDomeDeuteriumCost);
            this.pLargeShieldDome.Controls.Add(this.lblLargeShieldDomeCrystalCost);
            this.pLargeShieldDome.Controls.Add(this.lblLargeShieldDomeMetalCost);
            this.pLargeShieldDome.Controls.Add(this.lblLargeShieldDomeCount);
            this.pLargeShieldDome.Controls.Add(this.lblLargeShieldDome);
            this.pLargeShieldDome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLargeShieldDome.Location = new System.Drawing.Point(3, 453);
            this.pLargeShieldDome.Name = "pLargeShieldDome";
            this.pLargeShieldDome.Size = new System.Drawing.Size(1890, 50);
            this.pLargeShieldDome.TabIndex = 13;
            // 
            // lblLargeShieldDomeTimeRemain
            // 
            this.lblLargeShieldDomeTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeShieldDomeTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeShieldDomeTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblLargeShieldDomeTimeRemain.Name = "lblLargeShieldDomeTimeRemain";
            this.lblLargeShieldDomeTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblLargeShieldDomeTimeRemain.TabIndex = 15;
            this.lblLargeShieldDomeTimeRemain.Text = "czas pozostały";
            this.lblLargeShieldDomeTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLargeShieldDomeCount
            // 
            this.tbLargeShieldDomeCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLargeShieldDomeCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLargeShieldDomeCount.Location = new System.Drawing.Point(1161, 17);
            this.tbLargeShieldDomeCount.Name = "tbLargeShieldDomeCount";
            this.tbLargeShieldDomeCount.Size = new System.Drawing.Size(129, 16);
            this.tbLargeShieldDomeCount.TabIndex = 4;
            this.tbLargeShieldDomeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLargeShieldDomeShade
            // 
            this.lblLargeShieldDomeShade.BackColor = System.Drawing.Color.White;
            this.lblLargeShieldDomeShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLargeShieldDomeShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeShieldDomeShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLargeShieldDomeShade.Location = new System.Drawing.Point(1160, 10);
            this.lblLargeShieldDomeShade.Name = "lblLargeShieldDomeShade";
            this.lblLargeShieldDomeShade.Size = new System.Drawing.Size(130, 30);
            this.lblLargeShieldDomeShade.TabIndex = 14;
            this.lblLargeShieldDomeShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeShieldDomeDuration
            // 
            this.lblLargeShieldDomeDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeShieldDomeDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeShieldDomeDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeShieldDomeDuration.Location = new System.Drawing.Point(880, 10);
            this.lblLargeShieldDomeDuration.Name = "lblLargeShieldDomeDuration";
            this.lblLargeShieldDomeDuration.Size = new System.Drawing.Size(130, 30);
            this.lblLargeShieldDomeDuration.TabIndex = 13;
            this.lblLargeShieldDomeDuration.Text = "czas";
            this.lblLargeShieldDomeDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLargeShieldDomeConstruct
            // 
            this.btnLargeShieldDomeConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnLargeShieldDomeConstruct.Enabled = false;
            this.btnLargeShieldDomeConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLargeShieldDomeConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnLargeShieldDomeConstruct.Name = "btnLargeShieldDomeConstruct";
            this.btnLargeShieldDomeConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnLargeShieldDomeConstruct.TabIndex = 12;
            this.btnLargeShieldDomeConstruct.Text = "Zbuduj";
            this.btnLargeShieldDomeConstruct.UseVisualStyleBackColor = false;
            this.btnLargeShieldDomeConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblLargeShieldDomeDeuteriumCost
            // 
            this.lblLargeShieldDomeDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeShieldDomeDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeShieldDomeDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeShieldDomeDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLargeShieldDomeDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblLargeShieldDomeDeuteriumCost.Name = "lblLargeShieldDomeDeuteriumCost";
            this.lblLargeShieldDomeDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblLargeShieldDomeDeuteriumCost.TabIndex = 11;
            this.lblLargeShieldDomeDeuteriumCost.Text = "deuter";
            this.lblLargeShieldDomeDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeShieldDomeCrystalCost
            // 
            this.lblLargeShieldDomeCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeShieldDomeCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeShieldDomeCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeShieldDomeCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLargeShieldDomeCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblLargeShieldDomeCrystalCost.Name = "lblLargeShieldDomeCrystalCost";
            this.lblLargeShieldDomeCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLargeShieldDomeCrystalCost.TabIndex = 10;
            this.lblLargeShieldDomeCrystalCost.Text = "kryształ";
            this.lblLargeShieldDomeCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeShieldDomeMetalCost
            // 
            this.lblLargeShieldDomeMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeShieldDomeMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeShieldDomeMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeShieldDomeMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLargeShieldDomeMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblLargeShieldDomeMetalCost.Name = "lblLargeShieldDomeMetalCost";
            this.lblLargeShieldDomeMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLargeShieldDomeMetalCost.TabIndex = 9;
            this.lblLargeShieldDomeMetalCost.Text = "metal";
            this.lblLargeShieldDomeMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeShieldDomeCount
            // 
            this.lblLargeShieldDomeCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeShieldDomeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeShieldDomeCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeShieldDomeCount.Location = new System.Drawing.Point(320, 10);
            this.lblLargeShieldDomeCount.Name = "lblLargeShieldDomeCount";
            this.lblLargeShieldDomeCount.Size = new System.Drawing.Size(130, 30);
            this.lblLargeShieldDomeCount.TabIndex = 8;
            this.lblLargeShieldDomeCount.Text = "Ilość";
            this.lblLargeShieldDomeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLargeShieldDome
            // 
            this.lblLargeShieldDome.BackColor = System.Drawing.Color.Transparent;
            this.lblLargeShieldDome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLargeShieldDome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLargeShieldDome.Location = new System.Drawing.Point(10, 10);
            this.lblLargeShieldDome.Name = "lblLargeShieldDome";
            this.lblLargeShieldDome.Size = new System.Drawing.Size(300, 30);
            this.lblLargeShieldDome.TabIndex = 7;
            this.lblLargeShieldDome.Text = "Duża powłoka ochronna";
            this.lblLargeShieldDome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSmallShieldDome
            // 
            this.pSmallShieldDome.BackColor = System.Drawing.Color.Gold;
            this.pSmallShieldDome.Controls.Add(this.lblSmallShieldDomeTimeRemain);
            this.pSmallShieldDome.Controls.Add(this.tbSmallShieldDomeCount);
            this.pSmallShieldDome.Controls.Add(this.lblSmallShieldDomeShade);
            this.pSmallShieldDome.Controls.Add(this.lblSmallShieldDomeDuration);
            this.pSmallShieldDome.Controls.Add(this.btnSmallShieldDomeConstruct);
            this.pSmallShieldDome.Controls.Add(this.lblSmallShieldDomeDeuteriumCost);
            this.pSmallShieldDome.Controls.Add(this.lblSmallShieldDomeCrystalCost);
            this.pSmallShieldDome.Controls.Add(this.lblSmallShieldDomeMetalCost);
            this.pSmallShieldDome.Controls.Add(this.lblSmallShieldDomeCount);
            this.pSmallShieldDome.Controls.Add(this.lblSmallShieldDome);
            this.pSmallShieldDome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSmallShieldDome.Location = new System.Drawing.Point(3, 403);
            this.pSmallShieldDome.Name = "pSmallShieldDome";
            this.pSmallShieldDome.Size = new System.Drawing.Size(1890, 50);
            this.pSmallShieldDome.TabIndex = 12;
            // 
            // lblSmallShieldDomeTimeRemain
            // 
            this.lblSmallShieldDomeTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallShieldDomeTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallShieldDomeTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblSmallShieldDomeTimeRemain.Name = "lblSmallShieldDomeTimeRemain";
            this.lblSmallShieldDomeTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblSmallShieldDomeTimeRemain.TabIndex = 15;
            this.lblSmallShieldDomeTimeRemain.Text = "czas pozostały";
            this.lblSmallShieldDomeTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSmallShieldDomeCount
            // 
            this.tbSmallShieldDomeCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbSmallShieldDomeCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSmallShieldDomeCount.Location = new System.Drawing.Point(1161, 17);
            this.tbSmallShieldDomeCount.Name = "tbSmallShieldDomeCount";
            this.tbSmallShieldDomeCount.Size = new System.Drawing.Size(129, 16);
            this.tbSmallShieldDomeCount.TabIndex = 4;
            this.tbSmallShieldDomeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSmallShieldDomeShade
            // 
            this.lblSmallShieldDomeShade.BackColor = System.Drawing.Color.White;
            this.lblSmallShieldDomeShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSmallShieldDomeShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallShieldDomeShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSmallShieldDomeShade.Location = new System.Drawing.Point(1160, 10);
            this.lblSmallShieldDomeShade.Name = "lblSmallShieldDomeShade";
            this.lblSmallShieldDomeShade.Size = new System.Drawing.Size(130, 30);
            this.lblSmallShieldDomeShade.TabIndex = 14;
            this.lblSmallShieldDomeShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallShieldDomeDuration
            // 
            this.lblSmallShieldDomeDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallShieldDomeDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallShieldDomeDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallShieldDomeDuration.Location = new System.Drawing.Point(880, 10);
            this.lblSmallShieldDomeDuration.Name = "lblSmallShieldDomeDuration";
            this.lblSmallShieldDomeDuration.Size = new System.Drawing.Size(130, 30);
            this.lblSmallShieldDomeDuration.TabIndex = 13;
            this.lblSmallShieldDomeDuration.Text = "czas";
            this.lblSmallShieldDomeDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSmallShieldDomeConstruct
            // 
            this.btnSmallShieldDomeConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnSmallShieldDomeConstruct.Enabled = false;
            this.btnSmallShieldDomeConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSmallShieldDomeConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnSmallShieldDomeConstruct.Name = "btnSmallShieldDomeConstruct";
            this.btnSmallShieldDomeConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnSmallShieldDomeConstruct.TabIndex = 12;
            this.btnSmallShieldDomeConstruct.Text = "Zbuduj";
            this.btnSmallShieldDomeConstruct.UseVisualStyleBackColor = false;
            this.btnSmallShieldDomeConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblSmallShieldDomeDeuteriumCost
            // 
            this.lblSmallShieldDomeDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallShieldDomeDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallShieldDomeDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallShieldDomeDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSmallShieldDomeDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblSmallShieldDomeDeuteriumCost.Name = "lblSmallShieldDomeDeuteriumCost";
            this.lblSmallShieldDomeDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblSmallShieldDomeDeuteriumCost.TabIndex = 11;
            this.lblSmallShieldDomeDeuteriumCost.Text = "deuter";
            this.lblSmallShieldDomeDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallShieldDomeCrystalCost
            // 
            this.lblSmallShieldDomeCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallShieldDomeCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallShieldDomeCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallShieldDomeCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSmallShieldDomeCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblSmallShieldDomeCrystalCost.Name = "lblSmallShieldDomeCrystalCost";
            this.lblSmallShieldDomeCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSmallShieldDomeCrystalCost.TabIndex = 10;
            this.lblSmallShieldDomeCrystalCost.Text = "kryształ";
            this.lblSmallShieldDomeCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallShieldDomeMetalCost
            // 
            this.lblSmallShieldDomeMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallShieldDomeMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallShieldDomeMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallShieldDomeMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSmallShieldDomeMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblSmallShieldDomeMetalCost.Name = "lblSmallShieldDomeMetalCost";
            this.lblSmallShieldDomeMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSmallShieldDomeMetalCost.TabIndex = 9;
            this.lblSmallShieldDomeMetalCost.Text = "metal";
            this.lblSmallShieldDomeMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallShieldDomeCount
            // 
            this.lblSmallShieldDomeCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallShieldDomeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallShieldDomeCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallShieldDomeCount.Location = new System.Drawing.Point(320, 10);
            this.lblSmallShieldDomeCount.Name = "lblSmallShieldDomeCount";
            this.lblSmallShieldDomeCount.Size = new System.Drawing.Size(130, 30);
            this.lblSmallShieldDomeCount.TabIndex = 8;
            this.lblSmallShieldDomeCount.Text = "Ilość";
            this.lblSmallShieldDomeCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmallShieldDome
            // 
            this.lblSmallShieldDome.BackColor = System.Drawing.Color.Transparent;
            this.lblSmallShieldDome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSmallShieldDome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSmallShieldDome.Location = new System.Drawing.Point(10, 10);
            this.lblSmallShieldDome.Name = "lblSmallShieldDome";
            this.lblSmallShieldDome.Size = new System.Drawing.Size(300, 30);
            this.lblSmallShieldDome.TabIndex = 7;
            this.lblSmallShieldDome.Text = "Mała powłoka ochronna";
            this.lblSmallShieldDome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPlasmaTurret
            // 
            this.pPlasmaTurret.BackColor = System.Drawing.Color.Yellow;
            this.pPlasmaTurret.Controls.Add(this.lblPlasmaTurretTimeRemain);
            this.pPlasmaTurret.Controls.Add(this.tbPlasmaTurretCount);
            this.pPlasmaTurret.Controls.Add(this.lblPlasmaTurretShade);
            this.pPlasmaTurret.Controls.Add(this.lblPlasmaTurretDuration);
            this.pPlasmaTurret.Controls.Add(this.btnPlasmaTurretConstruct);
            this.pPlasmaTurret.Controls.Add(this.lblPlasmaTurretDeuteriumCost);
            this.pPlasmaTurret.Controls.Add(this.lblPlasmaTurretCrystalCost);
            this.pPlasmaTurret.Controls.Add(this.lblPlasmaTurretMetalCost);
            this.pPlasmaTurret.Controls.Add(this.lblPlasmaTurretCount);
            this.pPlasmaTurret.Controls.Add(this.lblPlasmaTurret);
            this.pPlasmaTurret.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPlasmaTurret.Location = new System.Drawing.Point(3, 353);
            this.pPlasmaTurret.Name = "pPlasmaTurret";
            this.pPlasmaTurret.Size = new System.Drawing.Size(1890, 50);
            this.pPlasmaTurret.TabIndex = 11;
            // 
            // lblPlasmaTurretTimeRemain
            // 
            this.lblPlasmaTurretTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTurretTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTurretTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblPlasmaTurretTimeRemain.Name = "lblPlasmaTurretTimeRemain";
            this.lblPlasmaTurretTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTurretTimeRemain.TabIndex = 15;
            this.lblPlasmaTurretTimeRemain.Text = "czas pozostały";
            this.lblPlasmaTurretTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPlasmaTurretCount
            // 
            this.tbPlasmaTurretCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPlasmaTurretCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPlasmaTurretCount.Location = new System.Drawing.Point(1161, 17);
            this.tbPlasmaTurretCount.Name = "tbPlasmaTurretCount";
            this.tbPlasmaTurretCount.Size = new System.Drawing.Size(129, 16);
            this.tbPlasmaTurretCount.TabIndex = 4;
            this.tbPlasmaTurretCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlasmaTurretShade
            // 
            this.lblPlasmaTurretShade.BackColor = System.Drawing.Color.White;
            this.lblPlasmaTurretShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlasmaTurretShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTurretShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlasmaTurretShade.Location = new System.Drawing.Point(1160, 10);
            this.lblPlasmaTurretShade.Name = "lblPlasmaTurretShade";
            this.lblPlasmaTurretShade.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTurretShade.TabIndex = 14;
            this.lblPlasmaTurretShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTurretDuration
            // 
            this.lblPlasmaTurretDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTurretDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTurretDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTurretDuration.Location = new System.Drawing.Point(880, 10);
            this.lblPlasmaTurretDuration.Name = "lblPlasmaTurretDuration";
            this.lblPlasmaTurretDuration.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTurretDuration.TabIndex = 13;
            this.lblPlasmaTurretDuration.Text = "czas";
            this.lblPlasmaTurretDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlasmaTurretConstruct
            // 
            this.btnPlasmaTurretConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnPlasmaTurretConstruct.Enabled = false;
            this.btnPlasmaTurretConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlasmaTurretConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnPlasmaTurretConstruct.Name = "btnPlasmaTurretConstruct";
            this.btnPlasmaTurretConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnPlasmaTurretConstruct.TabIndex = 12;
            this.btnPlasmaTurretConstruct.Text = "Zbuduj";
            this.btnPlasmaTurretConstruct.UseVisualStyleBackColor = false;
            this.btnPlasmaTurretConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblPlasmaTurretDeuteriumCost
            // 
            this.lblPlasmaTurretDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTurretDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTurretDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTurretDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlasmaTurretDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblPlasmaTurretDeuteriumCost.Name = "lblPlasmaTurretDeuteriumCost";
            this.lblPlasmaTurretDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTurretDeuteriumCost.TabIndex = 11;
            this.lblPlasmaTurretDeuteriumCost.Text = "deuter";
            this.lblPlasmaTurretDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTurretCrystalCost
            // 
            this.lblPlasmaTurretCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTurretCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTurretCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTurretCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlasmaTurretCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblPlasmaTurretCrystalCost.Name = "lblPlasmaTurretCrystalCost";
            this.lblPlasmaTurretCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTurretCrystalCost.TabIndex = 10;
            this.lblPlasmaTurretCrystalCost.Text = "kryształ";
            this.lblPlasmaTurretCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTurretMetalCost
            // 
            this.lblPlasmaTurretMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTurretMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTurretMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTurretMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPlasmaTurretMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblPlasmaTurretMetalCost.Name = "lblPlasmaTurretMetalCost";
            this.lblPlasmaTurretMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTurretMetalCost.TabIndex = 9;
            this.lblPlasmaTurretMetalCost.Text = "metal";
            this.lblPlasmaTurretMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTurretCount
            // 
            this.lblPlasmaTurretCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTurretCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTurretCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTurretCount.Location = new System.Drawing.Point(320, 10);
            this.lblPlasmaTurretCount.Name = "lblPlasmaTurretCount";
            this.lblPlasmaTurretCount.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTurretCount.TabIndex = 8;
            this.lblPlasmaTurretCount.Text = "Ilość";
            this.lblPlasmaTurretCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTurret
            // 
            this.lblPlasmaTurret.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTurret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTurret.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTurret.Location = new System.Drawing.Point(10, 10);
            this.lblPlasmaTurret.Name = "lblPlasmaTurret";
            this.lblPlasmaTurret.Size = new System.Drawing.Size(300, 30);
            this.lblPlasmaTurret.TabIndex = 7;
            this.lblPlasmaTurret.Text = "Wyrzutnia plazmy";
            this.lblPlasmaTurret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pIonCannon
            // 
            this.pIonCannon.BackColor = System.Drawing.Color.Gold;
            this.pIonCannon.Controls.Add(this.lblIonCannonTimeRemain);
            this.pIonCannon.Controls.Add(this.tbIonCannonCount);
            this.pIonCannon.Controls.Add(this.lblIonCannonShade);
            this.pIonCannon.Controls.Add(this.lblIonCannonDuration);
            this.pIonCannon.Controls.Add(this.btnIonCannonConstruct);
            this.pIonCannon.Controls.Add(this.lblIonCannonDeuteriumCost);
            this.pIonCannon.Controls.Add(this.lblIonCannonCrystalCost);
            this.pIonCannon.Controls.Add(this.lblIonCannonMetalCost);
            this.pIonCannon.Controls.Add(this.lblIonCannonCount);
            this.pIonCannon.Controls.Add(this.lblIonCannon);
            this.pIonCannon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pIonCannon.Location = new System.Drawing.Point(3, 303);
            this.pIonCannon.Name = "pIonCannon";
            this.pIonCannon.Size = new System.Drawing.Size(1890, 50);
            this.pIonCannon.TabIndex = 10;
            // 
            // lblIonCannonTimeRemain
            // 
            this.lblIonCannonTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblIonCannonTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonCannonTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblIonCannonTimeRemain.Name = "lblIonCannonTimeRemain";
            this.lblIonCannonTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblIonCannonTimeRemain.TabIndex = 15;
            this.lblIonCannonTimeRemain.Text = "czas pozostały";
            this.lblIonCannonTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIonCannonCount
            // 
            this.tbIonCannonCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbIonCannonCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIonCannonCount.Location = new System.Drawing.Point(1161, 17);
            this.tbIonCannonCount.Name = "tbIonCannonCount";
            this.tbIonCannonCount.Size = new System.Drawing.Size(129, 16);
            this.tbIonCannonCount.TabIndex = 4;
            this.tbIonCannonCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIonCannonShade
            // 
            this.lblIonCannonShade.BackColor = System.Drawing.Color.White;
            this.lblIonCannonShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIonCannonShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonCannonShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIonCannonShade.Location = new System.Drawing.Point(1160, 10);
            this.lblIonCannonShade.Name = "lblIonCannonShade";
            this.lblIonCannonShade.Size = new System.Drawing.Size(130, 30);
            this.lblIonCannonShade.TabIndex = 14;
            this.lblIonCannonShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonCannonDuration
            // 
            this.lblIonCannonDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblIonCannonDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonCannonDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonCannonDuration.Location = new System.Drawing.Point(880, 10);
            this.lblIonCannonDuration.Name = "lblIonCannonDuration";
            this.lblIonCannonDuration.Size = new System.Drawing.Size(130, 30);
            this.lblIonCannonDuration.TabIndex = 13;
            this.lblIonCannonDuration.Text = "czas";
            this.lblIonCannonDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIonCannonConstruct
            // 
            this.btnIonCannonConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnIonCannonConstruct.Enabled = false;
            this.btnIonCannonConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIonCannonConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnIonCannonConstruct.Name = "btnIonCannonConstruct";
            this.btnIonCannonConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnIonCannonConstruct.TabIndex = 12;
            this.btnIonCannonConstruct.Text = "Zbuduj";
            this.btnIonCannonConstruct.UseVisualStyleBackColor = false;
            this.btnIonCannonConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblIonCannonDeuteriumCost
            // 
            this.lblIonCannonDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIonCannonDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonCannonDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonCannonDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIonCannonDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblIonCannonDeuteriumCost.Name = "lblIonCannonDeuteriumCost";
            this.lblIonCannonDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblIonCannonDeuteriumCost.TabIndex = 11;
            this.lblIonCannonDeuteriumCost.Text = "deuter";
            this.lblIonCannonDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonCannonCrystalCost
            // 
            this.lblIonCannonCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIonCannonCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonCannonCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonCannonCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIonCannonCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblIonCannonCrystalCost.Name = "lblIonCannonCrystalCost";
            this.lblIonCannonCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblIonCannonCrystalCost.TabIndex = 10;
            this.lblIonCannonCrystalCost.Text = "kryształ";
            this.lblIonCannonCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonCannonMetalCost
            // 
            this.lblIonCannonMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIonCannonMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonCannonMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonCannonMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIonCannonMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblIonCannonMetalCost.Name = "lblIonCannonMetalCost";
            this.lblIonCannonMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblIonCannonMetalCost.TabIndex = 9;
            this.lblIonCannonMetalCost.Text = "metal";
            this.lblIonCannonMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonCannonCount
            // 
            this.lblIonCannonCount.BackColor = System.Drawing.Color.Transparent;
            this.lblIonCannonCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonCannonCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonCannonCount.Location = new System.Drawing.Point(320, 10);
            this.lblIonCannonCount.Name = "lblIonCannonCount";
            this.lblIonCannonCount.Size = new System.Drawing.Size(130, 30);
            this.lblIonCannonCount.TabIndex = 8;
            this.lblIonCannonCount.Text = "Ilość";
            this.lblIonCannonCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonCannon
            // 
            this.lblIonCannon.BackColor = System.Drawing.Color.Transparent;
            this.lblIonCannon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonCannon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonCannon.Location = new System.Drawing.Point(10, 10);
            this.lblIonCannon.Name = "lblIonCannon";
            this.lblIonCannon.Size = new System.Drawing.Size(300, 30);
            this.lblIonCannon.TabIndex = 7;
            this.lblIonCannon.Text = "Działo jonowe";
            this.lblIonCannon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pGaussCannon
            // 
            this.pGaussCannon.BackColor = System.Drawing.Color.Yellow;
            this.pGaussCannon.Controls.Add(this.lblGaussCannonTimeRemain);
            this.pGaussCannon.Controls.Add(this.tbGaussCannonCount);
            this.pGaussCannon.Controls.Add(this.lblGaussCannonShade);
            this.pGaussCannon.Controls.Add(this.lblGaussCannonDuration);
            this.pGaussCannon.Controls.Add(this.btnGaussCannonConstruct);
            this.pGaussCannon.Controls.Add(this.lblGaussCannonDeuteriumCost);
            this.pGaussCannon.Controls.Add(this.lblGaussCannonCrystalCost);
            this.pGaussCannon.Controls.Add(this.lblGaussCannonMetalCost);
            this.pGaussCannon.Controls.Add(this.lblGaussCannonCount);
            this.pGaussCannon.Controls.Add(this.lblGaussCannon);
            this.pGaussCannon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGaussCannon.Location = new System.Drawing.Point(3, 253);
            this.pGaussCannon.Name = "pGaussCannon";
            this.pGaussCannon.Size = new System.Drawing.Size(1890, 50);
            this.pGaussCannon.TabIndex = 9;
            // 
            // lblGaussCannonTimeRemain
            // 
            this.lblGaussCannonTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblGaussCannonTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGaussCannonTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblGaussCannonTimeRemain.Name = "lblGaussCannonTimeRemain";
            this.lblGaussCannonTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblGaussCannonTimeRemain.TabIndex = 15;
            this.lblGaussCannonTimeRemain.Text = "czas pozostały";
            this.lblGaussCannonTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGaussCannonCount
            // 
            this.tbGaussCannonCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbGaussCannonCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGaussCannonCount.Location = new System.Drawing.Point(1161, 17);
            this.tbGaussCannonCount.Name = "tbGaussCannonCount";
            this.tbGaussCannonCount.Size = new System.Drawing.Size(129, 16);
            this.tbGaussCannonCount.TabIndex = 4;
            this.tbGaussCannonCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGaussCannonShade
            // 
            this.lblGaussCannonShade.BackColor = System.Drawing.Color.White;
            this.lblGaussCannonShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGaussCannonShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGaussCannonShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGaussCannonShade.Location = new System.Drawing.Point(1160, 10);
            this.lblGaussCannonShade.Name = "lblGaussCannonShade";
            this.lblGaussCannonShade.Size = new System.Drawing.Size(130, 30);
            this.lblGaussCannonShade.TabIndex = 14;
            this.lblGaussCannonShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGaussCannonDuration
            // 
            this.lblGaussCannonDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblGaussCannonDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGaussCannonDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGaussCannonDuration.Location = new System.Drawing.Point(880, 10);
            this.lblGaussCannonDuration.Name = "lblGaussCannonDuration";
            this.lblGaussCannonDuration.Size = new System.Drawing.Size(130, 30);
            this.lblGaussCannonDuration.TabIndex = 13;
            this.lblGaussCannonDuration.Text = "czas";
            this.lblGaussCannonDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGaussCannonConstruct
            // 
            this.btnGaussCannonConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnGaussCannonConstruct.Enabled = false;
            this.btnGaussCannonConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGaussCannonConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnGaussCannonConstruct.Name = "btnGaussCannonConstruct";
            this.btnGaussCannonConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnGaussCannonConstruct.TabIndex = 12;
            this.btnGaussCannonConstruct.Text = "Zbuduj";
            this.btnGaussCannonConstruct.UseVisualStyleBackColor = false;
            this.btnGaussCannonConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblGaussCannonDeuteriumCost
            // 
            this.lblGaussCannonDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblGaussCannonDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGaussCannonDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGaussCannonDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGaussCannonDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblGaussCannonDeuteriumCost.Name = "lblGaussCannonDeuteriumCost";
            this.lblGaussCannonDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblGaussCannonDeuteriumCost.TabIndex = 11;
            this.lblGaussCannonDeuteriumCost.Text = "deuter";
            this.lblGaussCannonDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGaussCannonCrystalCost
            // 
            this.lblGaussCannonCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblGaussCannonCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGaussCannonCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGaussCannonCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGaussCannonCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblGaussCannonCrystalCost.Name = "lblGaussCannonCrystalCost";
            this.lblGaussCannonCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblGaussCannonCrystalCost.TabIndex = 10;
            this.lblGaussCannonCrystalCost.Text = "kryształ";
            this.lblGaussCannonCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGaussCannonMetalCost
            // 
            this.lblGaussCannonMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblGaussCannonMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGaussCannonMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGaussCannonMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGaussCannonMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblGaussCannonMetalCost.Name = "lblGaussCannonMetalCost";
            this.lblGaussCannonMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblGaussCannonMetalCost.TabIndex = 9;
            this.lblGaussCannonMetalCost.Text = "metal";
            this.lblGaussCannonMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGaussCannonCount
            // 
            this.lblGaussCannonCount.BackColor = System.Drawing.Color.Transparent;
            this.lblGaussCannonCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGaussCannonCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGaussCannonCount.Location = new System.Drawing.Point(320, 10);
            this.lblGaussCannonCount.Name = "lblGaussCannonCount";
            this.lblGaussCannonCount.Size = new System.Drawing.Size(130, 30);
            this.lblGaussCannonCount.TabIndex = 8;
            this.lblGaussCannonCount.Text = "Ilość";
            this.lblGaussCannonCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGaussCannon
            // 
            this.lblGaussCannon.BackColor = System.Drawing.Color.Transparent;
            this.lblGaussCannon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGaussCannon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGaussCannon.Location = new System.Drawing.Point(10, 10);
            this.lblGaussCannon.Name = "lblGaussCannon";
            this.lblGaussCannon.Size = new System.Drawing.Size(300, 30);
            this.lblGaussCannon.TabIndex = 7;
            this.lblGaussCannon.Text = "Działo Gaussa";
            this.lblGaussCannon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHeavyLaser
            // 
            this.pHeavyLaser.BackColor = System.Drawing.Color.Gold;
            this.pHeavyLaser.Controls.Add(this.lblHeavyLaserTimeRemain);
            this.pHeavyLaser.Controls.Add(this.tbHeavyLaserCount);
            this.pHeavyLaser.Controls.Add(this.lblHeavyLaserShade);
            this.pHeavyLaser.Controls.Add(this.lblHeavyLaserDuration);
            this.pHeavyLaser.Controls.Add(this.btnHeavyLaserConstruct);
            this.pHeavyLaser.Controls.Add(this.lblHeavyLaserDeuteriumCost);
            this.pHeavyLaser.Controls.Add(this.lblHeavyLaserCrystalCost);
            this.pHeavyLaser.Controls.Add(this.lblHeavyLaserMetalCost);
            this.pHeavyLaser.Controls.Add(this.lblHeavyLaserCount);
            this.pHeavyLaser.Controls.Add(this.lblHeavyLaser);
            this.pHeavyLaser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeavyLaser.Location = new System.Drawing.Point(3, 203);
            this.pHeavyLaser.Name = "pHeavyLaser";
            this.pHeavyLaser.Size = new System.Drawing.Size(1890, 50);
            this.pHeavyLaser.TabIndex = 8;
            // 
            // lblHeavyLaserTimeRemain
            // 
            this.lblHeavyLaserTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyLaserTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyLaserTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblHeavyLaserTimeRemain.Name = "lblHeavyLaserTimeRemain";
            this.lblHeavyLaserTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyLaserTimeRemain.TabIndex = 15;
            this.lblHeavyLaserTimeRemain.Text = "czas pozostały";
            this.lblHeavyLaserTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHeavyLaserCount
            // 
            this.tbHeavyLaserCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbHeavyLaserCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHeavyLaserCount.Location = new System.Drawing.Point(1161, 17);
            this.tbHeavyLaserCount.Name = "tbHeavyLaserCount";
            this.tbHeavyLaserCount.Size = new System.Drawing.Size(129, 16);
            this.tbHeavyLaserCount.TabIndex = 4;
            this.tbHeavyLaserCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHeavyLaserShade
            // 
            this.lblHeavyLaserShade.BackColor = System.Drawing.Color.White;
            this.lblHeavyLaserShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeavyLaserShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyLaserShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeavyLaserShade.Location = new System.Drawing.Point(1160, 10);
            this.lblHeavyLaserShade.Name = "lblHeavyLaserShade";
            this.lblHeavyLaserShade.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyLaserShade.TabIndex = 14;
            this.lblHeavyLaserShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyLaserDuration
            // 
            this.lblHeavyLaserDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyLaserDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyLaserDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyLaserDuration.Location = new System.Drawing.Point(880, 10);
            this.lblHeavyLaserDuration.Name = "lblHeavyLaserDuration";
            this.lblHeavyLaserDuration.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyLaserDuration.TabIndex = 13;
            this.lblHeavyLaserDuration.Text = "czas";
            this.lblHeavyLaserDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHeavyLaserConstruct
            // 
            this.btnHeavyLaserConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnHeavyLaserConstruct.Enabled = false;
            this.btnHeavyLaserConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeavyLaserConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnHeavyLaserConstruct.Name = "btnHeavyLaserConstruct";
            this.btnHeavyLaserConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnHeavyLaserConstruct.TabIndex = 12;
            this.btnHeavyLaserConstruct.Text = "Zbuduj";
            this.btnHeavyLaserConstruct.UseVisualStyleBackColor = false;
            this.btnHeavyLaserConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblHeavyLaserDeuteriumCost
            // 
            this.lblHeavyLaserDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyLaserDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyLaserDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyLaserDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeavyLaserDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblHeavyLaserDeuteriumCost.Name = "lblHeavyLaserDeuteriumCost";
            this.lblHeavyLaserDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyLaserDeuteriumCost.TabIndex = 11;
            this.lblHeavyLaserDeuteriumCost.Text = "deuter";
            this.lblHeavyLaserDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyLaserCrystalCost
            // 
            this.lblHeavyLaserCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyLaserCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyLaserCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyLaserCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeavyLaserCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblHeavyLaserCrystalCost.Name = "lblHeavyLaserCrystalCost";
            this.lblHeavyLaserCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyLaserCrystalCost.TabIndex = 10;
            this.lblHeavyLaserCrystalCost.Text = "kryształ";
            this.lblHeavyLaserCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyLaserMetalCost
            // 
            this.lblHeavyLaserMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyLaserMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyLaserMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyLaserMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeavyLaserMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblHeavyLaserMetalCost.Name = "lblHeavyLaserMetalCost";
            this.lblHeavyLaserMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyLaserMetalCost.TabIndex = 9;
            this.lblHeavyLaserMetalCost.Text = "metal";
            this.lblHeavyLaserMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyLaserCount
            // 
            this.lblHeavyLaserCount.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyLaserCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyLaserCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyLaserCount.Location = new System.Drawing.Point(320, 10);
            this.lblHeavyLaserCount.Name = "lblHeavyLaserCount";
            this.lblHeavyLaserCount.Size = new System.Drawing.Size(130, 30);
            this.lblHeavyLaserCount.TabIndex = 8;
            this.lblHeavyLaserCount.Text = "Ilość";
            this.lblHeavyLaserCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeavyLaser
            // 
            this.lblHeavyLaser.BackColor = System.Drawing.Color.Transparent;
            this.lblHeavyLaser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeavyLaser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeavyLaser.Location = new System.Drawing.Point(10, 10);
            this.lblHeavyLaser.Name = "lblHeavyLaser";
            this.lblHeavyLaser.Size = new System.Drawing.Size(300, 30);
            this.lblHeavyLaser.TabIndex = 7;
            this.lblHeavyLaser.Text = "Ciężkie działo laserowe";
            this.lblHeavyLaser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLightLaser
            // 
            this.pLightLaser.BackColor = System.Drawing.Color.Yellow;
            this.pLightLaser.Controls.Add(this.lblLightLaserTimeRemain);
            this.pLightLaser.Controls.Add(this.tbLightLaserCount);
            this.pLightLaser.Controls.Add(this.lblLightLaserShade);
            this.pLightLaser.Controls.Add(this.lblLightLaserDuration);
            this.pLightLaser.Controls.Add(this.btnLightLaserConstruct);
            this.pLightLaser.Controls.Add(this.lblLightLaserDeuteriumCost);
            this.pLightLaser.Controls.Add(this.lblLightLaserCrystalCost);
            this.pLightLaser.Controls.Add(this.lblLightLaserMetalCost);
            this.pLightLaser.Controls.Add(this.lblLightLaserCount);
            this.pLightLaser.Controls.Add(this.lblLightLaser);
            this.pLightLaser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLightLaser.Location = new System.Drawing.Point(3, 153);
            this.pLightLaser.Name = "pLightLaser";
            this.pLightLaser.Size = new System.Drawing.Size(1890, 50);
            this.pLightLaser.TabIndex = 7;
            // 
            // lblLightLaserTimeRemain
            // 
            this.lblLightLaserTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblLightLaserTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightLaserTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblLightLaserTimeRemain.Name = "lblLightLaserTimeRemain";
            this.lblLightLaserTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblLightLaserTimeRemain.TabIndex = 15;
            this.lblLightLaserTimeRemain.Text = "czas pozostały";
            this.lblLightLaserTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLightLaserCount
            // 
            this.tbLightLaserCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbLightLaserCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLightLaserCount.Location = new System.Drawing.Point(1161, 17);
            this.tbLightLaserCount.Name = "tbLightLaserCount";
            this.tbLightLaserCount.Size = new System.Drawing.Size(129, 16);
            this.tbLightLaserCount.TabIndex = 4;
            this.tbLightLaserCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLightLaserShade
            // 
            this.lblLightLaserShade.BackColor = System.Drawing.Color.White;
            this.lblLightLaserShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLightLaserShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightLaserShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLightLaserShade.Location = new System.Drawing.Point(1160, 10);
            this.lblLightLaserShade.Name = "lblLightLaserShade";
            this.lblLightLaserShade.Size = new System.Drawing.Size(130, 30);
            this.lblLightLaserShade.TabIndex = 14;
            this.lblLightLaserShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightLaserDuration
            // 
            this.lblLightLaserDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblLightLaserDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightLaserDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightLaserDuration.Location = new System.Drawing.Point(880, 10);
            this.lblLightLaserDuration.Name = "lblLightLaserDuration";
            this.lblLightLaserDuration.Size = new System.Drawing.Size(130, 30);
            this.lblLightLaserDuration.TabIndex = 13;
            this.lblLightLaserDuration.Text = "czas";
            this.lblLightLaserDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLightLaserConstruct
            // 
            this.btnLightLaserConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnLightLaserConstruct.Enabled = false;
            this.btnLightLaserConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLightLaserConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnLightLaserConstruct.Name = "btnLightLaserConstruct";
            this.btnLightLaserConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnLightLaserConstruct.TabIndex = 12;
            this.btnLightLaserConstruct.Text = "Zbuduj";
            this.btnLightLaserConstruct.UseVisualStyleBackColor = false;
            this.btnLightLaserConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblLightLaserDeuteriumCost
            // 
            this.lblLightLaserDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLightLaserDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightLaserDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightLaserDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLightLaserDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblLightLaserDeuteriumCost.Name = "lblLightLaserDeuteriumCost";
            this.lblLightLaserDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblLightLaserDeuteriumCost.TabIndex = 11;
            this.lblLightLaserDeuteriumCost.Text = "deuter";
            this.lblLightLaserDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightLaserCrystalCost
            // 
            this.lblLightLaserCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLightLaserCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightLaserCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightLaserCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLightLaserCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblLightLaserCrystalCost.Name = "lblLightLaserCrystalCost";
            this.lblLightLaserCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLightLaserCrystalCost.TabIndex = 10;
            this.lblLightLaserCrystalCost.Text = "kryształ";
            this.lblLightLaserCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightLaserMetalCost
            // 
            this.lblLightLaserMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblLightLaserMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightLaserMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightLaserMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLightLaserMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblLightLaserMetalCost.Name = "lblLightLaserMetalCost";
            this.lblLightLaserMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblLightLaserMetalCost.TabIndex = 9;
            this.lblLightLaserMetalCost.Text = "metal";
            this.lblLightLaserMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightLaserCount
            // 
            this.lblLightLaserCount.BackColor = System.Drawing.Color.Transparent;
            this.lblLightLaserCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightLaserCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightLaserCount.Location = new System.Drawing.Point(320, 10);
            this.lblLightLaserCount.Name = "lblLightLaserCount";
            this.lblLightLaserCount.Size = new System.Drawing.Size(130, 30);
            this.lblLightLaserCount.TabIndex = 8;
            this.lblLightLaserCount.Text = "Ilość";
            this.lblLightLaserCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLightLaser
            // 
            this.lblLightLaser.BackColor = System.Drawing.Color.Transparent;
            this.lblLightLaser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLightLaser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLightLaser.Location = new System.Drawing.Point(10, 10);
            this.lblLightLaser.Name = "lblLightLaser";
            this.lblLightLaser.Size = new System.Drawing.Size(300, 30);
            this.lblLightLaser.TabIndex = 7;
            this.lblLightLaser.Text = "Lekkie działo laserowe";
            this.lblLightLaser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pRocketLauncher
            // 
            this.pRocketLauncher.BackColor = System.Drawing.Color.Gold;
            this.pRocketLauncher.Controls.Add(this.lblRocketLauncherTimeRemain);
            this.pRocketLauncher.Controls.Add(this.tbRocketLauncherCount);
            this.pRocketLauncher.Controls.Add(this.lblRocketLauncherShade);
            this.pRocketLauncher.Controls.Add(this.lblRocketLauncherDuration);
            this.pRocketLauncher.Controls.Add(this.btnRocketLauncherConstruct);
            this.pRocketLauncher.Controls.Add(this.lblRocketLauncherDeuteriumCost);
            this.pRocketLauncher.Controls.Add(this.lblRocketLauncherCrystalCost);
            this.pRocketLauncher.Controls.Add(this.lblRocketLauncherMetalCost);
            this.pRocketLauncher.Controls.Add(this.lblRocketLauncherCount);
            this.pRocketLauncher.Controls.Add(this.lblRocketLauncher);
            this.pRocketLauncher.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRocketLauncher.Location = new System.Drawing.Point(3, 103);
            this.pRocketLauncher.Name = "pRocketLauncher";
            this.pRocketLauncher.Size = new System.Drawing.Size(1890, 50);
            this.pRocketLauncher.TabIndex = 6;
            // 
            // lblRocketLauncherTimeRemain
            // 
            this.lblRocketLauncherTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketLauncherTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRocketLauncherTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblRocketLauncherTimeRemain.Name = "lblRocketLauncherTimeRemain";
            this.lblRocketLauncherTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblRocketLauncherTimeRemain.TabIndex = 15;
            this.lblRocketLauncherTimeRemain.Text = "czas pozostały";
            this.lblRocketLauncherTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRocketLauncherCount
            // 
            this.tbRocketLauncherCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbRocketLauncherCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRocketLauncherCount.Location = new System.Drawing.Point(1161, 17);
            this.tbRocketLauncherCount.Name = "tbRocketLauncherCount";
            this.tbRocketLauncherCount.Size = new System.Drawing.Size(129, 16);
            this.tbRocketLauncherCount.TabIndex = 4;
            this.tbRocketLauncherCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRocketLauncherShade
            // 
            this.lblRocketLauncherShade.BackColor = System.Drawing.Color.White;
            this.lblRocketLauncherShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRocketLauncherShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRocketLauncherShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRocketLauncherShade.Location = new System.Drawing.Point(1160, 10);
            this.lblRocketLauncherShade.Name = "lblRocketLauncherShade";
            this.lblRocketLauncherShade.Size = new System.Drawing.Size(130, 30);
            this.lblRocketLauncherShade.TabIndex = 14;
            this.lblRocketLauncherShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRocketLauncherDuration
            // 
            this.lblRocketLauncherDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketLauncherDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRocketLauncherDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRocketLauncherDuration.Location = new System.Drawing.Point(880, 10);
            this.lblRocketLauncherDuration.Name = "lblRocketLauncherDuration";
            this.lblRocketLauncherDuration.Size = new System.Drawing.Size(130, 30);
            this.lblRocketLauncherDuration.TabIndex = 13;
            this.lblRocketLauncherDuration.Text = "czas";
            this.lblRocketLauncherDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRocketLauncherConstruct
            // 
            this.btnRocketLauncherConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnRocketLauncherConstruct.Enabled = false;
            this.btnRocketLauncherConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRocketLauncherConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnRocketLauncherConstruct.Name = "btnRocketLauncherConstruct";
            this.btnRocketLauncherConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnRocketLauncherConstruct.TabIndex = 12;
            this.btnRocketLauncherConstruct.Text = "Zbuduj";
            this.btnRocketLauncherConstruct.UseVisualStyleBackColor = false;
            this.btnRocketLauncherConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblRocketLauncherDeuteriumCost
            // 
            this.lblRocketLauncherDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketLauncherDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRocketLauncherDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRocketLauncherDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRocketLauncherDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblRocketLauncherDeuteriumCost.Name = "lblRocketLauncherDeuteriumCost";
            this.lblRocketLauncherDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblRocketLauncherDeuteriumCost.TabIndex = 11;
            this.lblRocketLauncherDeuteriumCost.Text = "deuter";
            this.lblRocketLauncherDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRocketLauncherCrystalCost
            // 
            this.lblRocketLauncherCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketLauncherCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRocketLauncherCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRocketLauncherCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRocketLauncherCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblRocketLauncherCrystalCost.Name = "lblRocketLauncherCrystalCost";
            this.lblRocketLauncherCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblRocketLauncherCrystalCost.TabIndex = 10;
            this.lblRocketLauncherCrystalCost.Text = "kryształ";
            this.lblRocketLauncherCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRocketLauncherMetalCost
            // 
            this.lblRocketLauncherMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketLauncherMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRocketLauncherMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRocketLauncherMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRocketLauncherMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblRocketLauncherMetalCost.Name = "lblRocketLauncherMetalCost";
            this.lblRocketLauncherMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblRocketLauncherMetalCost.TabIndex = 9;
            this.lblRocketLauncherMetalCost.Text = "metal";
            this.lblRocketLauncherMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRocketLauncherCount
            // 
            this.lblRocketLauncherCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketLauncherCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRocketLauncherCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRocketLauncherCount.Location = new System.Drawing.Point(320, 10);
            this.lblRocketLauncherCount.Name = "lblRocketLauncherCount";
            this.lblRocketLauncherCount.Size = new System.Drawing.Size(130, 30);
            this.lblRocketLauncherCount.TabIndex = 8;
            this.lblRocketLauncherCount.Text = "Ilość";
            this.lblRocketLauncherCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRocketLauncher
            // 
            this.lblRocketLauncher.BackColor = System.Drawing.Color.Transparent;
            this.lblRocketLauncher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRocketLauncher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRocketLauncher.Location = new System.Drawing.Point(10, 10);
            this.lblRocketLauncher.Name = "lblRocketLauncher";
            this.lblRocketLauncher.Size = new System.Drawing.Size(300, 30);
            this.lblRocketLauncher.TabIndex = 7;
            this.lblRocketLauncher.Text = "Wyrzutnia rakiet";
            this.lblRocketLauncher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCrawler
            // 
            this.pCrawler.BackColor = System.Drawing.Color.Yellow;
            this.pCrawler.Controls.Add(this.lblCrawlerTimeRemain);
            this.pCrawler.Controls.Add(this.tbCrawlerCount);
            this.pCrawler.Controls.Add(this.lblCrawlerShade);
            this.pCrawler.Controls.Add(this.lblCrawlerDuration);
            this.pCrawler.Controls.Add(this.btnCrawlerConstruct);
            this.pCrawler.Controls.Add(this.lblCrawlerDeuteriumCost);
            this.pCrawler.Controls.Add(this.lblCrawlerCrystalCost);
            this.pCrawler.Controls.Add(this.lblCrawlerMetalCost);
            this.pCrawler.Controls.Add(this.lblCrawlerCount);
            this.pCrawler.Controls.Add(this.lblCrawler);
            this.pCrawler.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCrawler.Location = new System.Drawing.Point(3, 53);
            this.pCrawler.Name = "pCrawler";
            this.pCrawler.Size = new System.Drawing.Size(1890, 50);
            this.pCrawler.TabIndex = 5;
            // 
            // lblCrawlerTimeRemain
            // 
            this.lblCrawlerTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblCrawlerTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrawlerTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblCrawlerTimeRemain.Name = "lblCrawlerTimeRemain";
            this.lblCrawlerTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblCrawlerTimeRemain.TabIndex = 15;
            this.lblCrawlerTimeRemain.Text = "czas pozostały";
            this.lblCrawlerTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCrawlerCount
            // 
            this.tbCrawlerCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbCrawlerCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCrawlerCount.Location = new System.Drawing.Point(1161, 17);
            this.tbCrawlerCount.Name = "tbCrawlerCount";
            this.tbCrawlerCount.Size = new System.Drawing.Size(129, 16);
            this.tbCrawlerCount.TabIndex = 4;
            this.tbCrawlerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCrawlerShade
            // 
            this.lblCrawlerShade.BackColor = System.Drawing.Color.White;
            this.lblCrawlerShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCrawlerShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrawlerShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCrawlerShade.Location = new System.Drawing.Point(1160, 10);
            this.lblCrawlerShade.Name = "lblCrawlerShade";
            this.lblCrawlerShade.Size = new System.Drawing.Size(130, 30);
            this.lblCrawlerShade.TabIndex = 14;
            this.lblCrawlerShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrawlerDuration
            // 
            this.lblCrawlerDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblCrawlerDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrawlerDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrawlerDuration.Location = new System.Drawing.Point(880, 10);
            this.lblCrawlerDuration.Name = "lblCrawlerDuration";
            this.lblCrawlerDuration.Size = new System.Drawing.Size(130, 30);
            this.lblCrawlerDuration.TabIndex = 13;
            this.lblCrawlerDuration.Text = "czas";
            this.lblCrawlerDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrawlerConstruct
            // 
            this.btnCrawlerConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnCrawlerConstruct.Enabled = false;
            this.btnCrawlerConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrawlerConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnCrawlerConstruct.Name = "btnCrawlerConstruct";
            this.btnCrawlerConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnCrawlerConstruct.TabIndex = 12;
            this.btnCrawlerConstruct.Text = "Zbuduj";
            this.btnCrawlerConstruct.UseVisualStyleBackColor = false;
            this.btnCrawlerConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblCrawlerDeuteriumCost
            // 
            this.lblCrawlerDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrawlerDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrawlerDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrawlerDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrawlerDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblCrawlerDeuteriumCost.Name = "lblCrawlerDeuteriumCost";
            this.lblCrawlerDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrawlerDeuteriumCost.TabIndex = 11;
            this.lblCrawlerDeuteriumCost.Text = "deuter";
            this.lblCrawlerDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrawlerCrystalCost
            // 
            this.lblCrawlerCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrawlerCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrawlerCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrawlerCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrawlerCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblCrawlerCrystalCost.Name = "lblCrawlerCrystalCost";
            this.lblCrawlerCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrawlerCrystalCost.TabIndex = 10;
            this.lblCrawlerCrystalCost.Text = "kryształ";
            this.lblCrawlerCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrawlerMetalCost
            // 
            this.lblCrawlerMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrawlerMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrawlerMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrawlerMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCrawlerMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblCrawlerMetalCost.Name = "lblCrawlerMetalCost";
            this.lblCrawlerMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrawlerMetalCost.TabIndex = 9;
            this.lblCrawlerMetalCost.Text = "metal";
            this.lblCrawlerMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrawlerCount
            // 
            this.lblCrawlerCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCrawlerCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrawlerCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrawlerCount.Location = new System.Drawing.Point(320, 10);
            this.lblCrawlerCount.Name = "lblCrawlerCount";
            this.lblCrawlerCount.Size = new System.Drawing.Size(130, 30);
            this.lblCrawlerCount.TabIndex = 8;
            this.lblCrawlerCount.Text = "Ilość";
            this.lblCrawlerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrawler
            // 
            this.lblCrawler.BackColor = System.Drawing.Color.Transparent;
            this.lblCrawler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrawler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrawler.Location = new System.Drawing.Point(10, 10);
            this.lblCrawler.Name = "lblCrawler";
            this.lblCrawler.Size = new System.Drawing.Size(300, 30);
            this.lblCrawler.TabIndex = 7;
            this.lblCrawler.Text = "Pełzacz";
            this.lblCrawler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSolarSatellite
            // 
            this.pSolarSatellite.BackColor = System.Drawing.Color.Gold;
            this.pSolarSatellite.Controls.Add(this.lblSolarSatelliteTimeRemain);
            this.pSolarSatellite.Controls.Add(this.tbSolarSatelliteCount);
            this.pSolarSatellite.Controls.Add(this.lblSolarSatelliteShade);
            this.pSolarSatellite.Controls.Add(this.lblSolarSatelliteDuration);
            this.pSolarSatellite.Controls.Add(this.btnSolarSatelliteConstruct);
            this.pSolarSatellite.Controls.Add(this.lblSolarSatelliteDeuteriumCost);
            this.pSolarSatellite.Controls.Add(this.lblSolarSatelliteCrystalCost);
            this.pSolarSatellite.Controls.Add(this.lblSolarSatelliteMetalCost);
            this.pSolarSatellite.Controls.Add(this.lblSolarSatelliteCount);
            this.pSolarSatellite.Controls.Add(this.lblSolarSatellite);
            this.pSolarSatellite.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSolarSatellite.Location = new System.Drawing.Point(3, 3);
            this.pSolarSatellite.Name = "pSolarSatellite";
            this.pSolarSatellite.Size = new System.Drawing.Size(1890, 50);
            this.pSolarSatellite.TabIndex = 4;
            // 
            // lblSolarSatelliteTimeRemain
            // 
            this.lblSolarSatelliteTimeRemain.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarSatelliteTimeRemain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarSatelliteTimeRemain.Location = new System.Drawing.Point(1300, 10);
            this.lblSolarSatelliteTimeRemain.Name = "lblSolarSatelliteTimeRemain";
            this.lblSolarSatelliteTimeRemain.Size = new System.Drawing.Size(130, 30);
            this.lblSolarSatelliteTimeRemain.TabIndex = 15;
            this.lblSolarSatelliteTimeRemain.Text = "czas pozostały";
            this.lblSolarSatelliteTimeRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSolarSatelliteCount
            // 
            this.tbSolarSatelliteCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbSolarSatelliteCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSolarSatelliteCount.Location = new System.Drawing.Point(1161, 17);
            this.tbSolarSatelliteCount.Name = "tbSolarSatelliteCount";
            this.tbSolarSatelliteCount.Size = new System.Drawing.Size(129, 16);
            this.tbSolarSatelliteCount.TabIndex = 4;
            this.tbSolarSatelliteCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSolarSatelliteShade
            // 
            this.lblSolarSatelliteShade.BackColor = System.Drawing.Color.White;
            this.lblSolarSatelliteShade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSolarSatelliteShade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarSatelliteShade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSolarSatelliteShade.Location = new System.Drawing.Point(1160, 10);
            this.lblSolarSatelliteShade.Name = "lblSolarSatelliteShade";
            this.lblSolarSatelliteShade.Size = new System.Drawing.Size(130, 30);
            this.lblSolarSatelliteShade.TabIndex = 14;
            this.lblSolarSatelliteShade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarSatelliteDuration
            // 
            this.lblSolarSatelliteDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarSatelliteDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarSatelliteDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarSatelliteDuration.Location = new System.Drawing.Point(880, 10);
            this.lblSolarSatelliteDuration.Name = "lblSolarSatelliteDuration";
            this.lblSolarSatelliteDuration.Size = new System.Drawing.Size(130, 30);
            this.lblSolarSatelliteDuration.TabIndex = 13;
            this.lblSolarSatelliteDuration.Text = "czas";
            this.lblSolarSatelliteDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSolarSatelliteConstruct
            // 
            this.btnSolarSatelliteConstruct.BackColor = System.Drawing.Color.Silver;
            this.btnSolarSatelliteConstruct.Enabled = false;
            this.btnSolarSatelliteConstruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSolarSatelliteConstruct.Location = new System.Drawing.Point(1020, 10);
            this.btnSolarSatelliteConstruct.Name = "btnSolarSatelliteConstruct";
            this.btnSolarSatelliteConstruct.Size = new System.Drawing.Size(130, 30);
            this.btnSolarSatelliteConstruct.TabIndex = 12;
            this.btnSolarSatelliteConstruct.Text = "Zbuduj";
            this.btnSolarSatelliteConstruct.UseVisualStyleBackColor = false;
            this.btnSolarSatelliteConstruct.Click += new System.EventHandler(this.BtnConstruct_Click);
            // 
            // lblSolarSatelliteDeuteriumCost
            // 
            this.lblSolarSatelliteDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarSatelliteDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarSatelliteDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarSatelliteDeuteriumCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSolarSatelliteDeuteriumCost.Location = new System.Drawing.Point(740, 10);
            this.lblSolarSatelliteDeuteriumCost.Name = "lblSolarSatelliteDeuteriumCost";
            this.lblSolarSatelliteDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblSolarSatelliteDeuteriumCost.TabIndex = 11;
            this.lblSolarSatelliteDeuteriumCost.Text = "deuter";
            this.lblSolarSatelliteDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarSatelliteCrystalCost
            // 
            this.lblSolarSatelliteCrystalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarSatelliteCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarSatelliteCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarSatelliteCrystalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSolarSatelliteCrystalCost.Location = new System.Drawing.Point(600, 10);
            this.lblSolarSatelliteCrystalCost.Name = "lblSolarSatelliteCrystalCost";
            this.lblSolarSatelliteCrystalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSolarSatelliteCrystalCost.TabIndex = 10;
            this.lblSolarSatelliteCrystalCost.Text = "kryształ";
            this.lblSolarSatelliteCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarSatelliteMetalCost
            // 
            this.lblSolarSatelliteMetalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarSatelliteMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarSatelliteMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarSatelliteMetalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSolarSatelliteMetalCost.Location = new System.Drawing.Point(460, 10);
            this.lblSolarSatelliteMetalCost.Name = "lblSolarSatelliteMetalCost";
            this.lblSolarSatelliteMetalCost.Size = new System.Drawing.Size(130, 30);
            this.lblSolarSatelliteMetalCost.TabIndex = 9;
            this.lblSolarSatelliteMetalCost.Text = "metal";
            this.lblSolarSatelliteMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarSatelliteCount
            // 
            this.lblSolarSatelliteCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarSatelliteCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarSatelliteCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarSatelliteCount.Location = new System.Drawing.Point(320, 10);
            this.lblSolarSatelliteCount.Name = "lblSolarSatelliteCount";
            this.lblSolarSatelliteCount.Size = new System.Drawing.Size(130, 30);
            this.lblSolarSatelliteCount.TabIndex = 8;
            this.lblSolarSatelliteCount.Text = "Ilość";
            this.lblSolarSatelliteCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolarSatellite
            // 
            this.lblSolarSatellite.BackColor = System.Drawing.Color.Transparent;
            this.lblSolarSatellite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSolarSatellite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSolarSatellite.Location = new System.Drawing.Point(10, 10);
            this.lblSolarSatellite.Name = "lblSolarSatellite";
            this.lblSolarSatellite.Size = new System.Drawing.Size(300, 30);
            this.lblSolarSatellite.TabIndex = 7;
            this.lblSolarSatellite.Text = "Satelita słoneczny";
            this.lblSolarSatellite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpRequirements
            // 
            this.tpRequirements.BackColor = System.Drawing.Color.Silver;
            this.tpRequirements.Location = new System.Drawing.Point(4, 29);
            this.tpRequirements.Name = "tpRequirements";
            this.tpRequirements.Padding = new System.Windows.Forms.Padding(3);
            this.tpRequirements.Size = new System.Drawing.Size(1896, 800);
            this.tpRequirements.TabIndex = 6;
            this.tpRequirements.Text = "Wymagania";
            // 
            // tpFleet
            // 
            this.tpFleet.BackColor = System.Drawing.Color.Gold;
            this.tpFleet.Controls.Add(this.btnAllResources);
            this.tpFleet.Controls.Add(this.tbDeuteriumCargo);
            this.tpFleet.Controls.Add(this.tbCrystalCargo);
            this.tpFleet.Controls.Add(this.tbMetalCargo);
            this.tpFleet.Controls.Add(this.label3);
            this.tpFleet.Controls.Add(this.label2);
            this.tpFleet.Controls.Add(this.label1);
            this.tpFleet.Controls.Add(this.btnSendCargo);
            this.tpFleet.Controls.Add(this.cbFleetTarget);
            this.tpFleet.Location = new System.Drawing.Point(4, 29);
            this.tpFleet.Name = "tpFleet";
            this.tpFleet.Padding = new System.Windows.Forms.Padding(3);
            this.tpFleet.Size = new System.Drawing.Size(1896, 800);
            this.tpFleet.TabIndex = 7;
            this.tpFleet.Text = "Flota";
            // 
            // btnAllResources
            // 
            this.btnAllResources.Enabled = false;
            this.btnAllResources.Location = new System.Drawing.Point(365, 207);
            this.btnAllResources.Name = "btnAllResources";
            this.btnAllResources.Size = new System.Drawing.Size(150, 25);
            this.btnAllResources.TabIndex = 16;
            this.btnAllResources.Text = "Wszystkie";
            this.btnAllResources.UseVisualStyleBackColor = true;
            this.btnAllResources.Click += new System.EventHandler(this.BtnAllResources_Click);
            // 
            // tbDeuteriumCargo
            // 
            this.tbDeuteriumCargo.Enabled = false;
            this.tbDeuteriumCargo.Location = new System.Drawing.Point(365, 152);
            this.tbDeuteriumCargo.Name = "tbDeuteriumCargo";
            this.tbDeuteriumCargo.Size = new System.Drawing.Size(150, 23);
            this.tbDeuteriumCargo.TabIndex = 15;
            this.tbDeuteriumCargo.Text = "0";
            this.tbDeuteriumCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDeuteriumCargo.TextChanged += new System.EventHandler(this.TbDeuteriumCargo_TextChanged);
            // 
            // tbCrystalCargo
            // 
            this.tbCrystalCargo.Enabled = false;
            this.tbCrystalCargo.Location = new System.Drawing.Point(365, 94);
            this.tbCrystalCargo.Name = "tbCrystalCargo";
            this.tbCrystalCargo.Size = new System.Drawing.Size(150, 23);
            this.tbCrystalCargo.TabIndex = 14;
            this.tbCrystalCargo.Text = "0";
            this.tbCrystalCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCrystalCargo.TextChanged += new System.EventHandler(this.TbCrystalCargo_TextChanged);
            // 
            // tbMetalCargo
            // 
            this.tbMetalCargo.Enabled = false;
            this.tbMetalCargo.Location = new System.Drawing.Point(365, 38);
            this.tbMetalCargo.Name = "tbMetalCargo";
            this.tbMetalCargo.Size = new System.Drawing.Size(150, 23);
            this.tbMetalCargo.TabIndex = 13;
            this.tbMetalCargo.Text = "0";
            this.tbMetalCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMetalCargo.TextChanged += new System.EventHandler(this.TbMetalCargo_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(176, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Deuter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(176, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kryształ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Metal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendCargo
            // 
            this.btnSendCargo.Enabled = false;
            this.btnSendCargo.Location = new System.Drawing.Point(744, 92);
            this.btnSendCargo.Name = "btnSendCargo";
            this.btnSendCargo.Size = new System.Drawing.Size(150, 25);
            this.btnSendCargo.TabIndex = 6;
            this.btnSendCargo.Text = "Wyślij";
            this.btnSendCargo.UseVisualStyleBackColor = true;
            this.btnSendCargo.Click += new System.EventHandler(this.BtnSendCargo_Click);
            // 
            // cbFleetTarget
            // 
            this.cbFleetTarget.Enabled = false;
            this.cbFleetTarget.FormattingEnabled = true;
            this.cbFleetTarget.Location = new System.Drawing.Point(566, 94);
            this.cbFleetTarget.Name = "cbFleetTarget";
            this.cbFleetTarget.Size = new System.Drawing.Size(150, 23);
            this.cbFleetTarget.TabIndex = 5;
            this.cbFleetTarget.SelectedIndexChanged += new System.EventHandler(this.CbFleetTarget_SelectedIndexChanged);
            // 
            // tpPoints
            // 
            this.tpPoints.BackColor = System.Drawing.Color.Gold;
            this.tpPoints.Controls.Add(this.panel10);
            this.tpPoints.Controls.Add(this.panel9);
            this.tpPoints.Controls.Add(this.panel8);
            this.tpPoints.Controls.Add(this.panel7);
            this.tpPoints.Controls.Add(this.panel1);
            this.tpPoints.Location = new System.Drawing.Point(4, 29);
            this.tpPoints.Name = "tpPoints";
            this.tpPoints.Padding = new System.Windows.Forms.Padding(3);
            this.tpPoints.Size = new System.Drawing.Size(1896, 800);
            this.tpPoints.TabIndex = 8;
            this.tpPoints.Text = "Punkty";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lblDefencesTotalCost);
            this.panel10.Controls.Add(this.lblDefencesDeuteriumCost);
            this.panel10.Controls.Add(this.lblDefencesCrystalCost);
            this.panel10.Controls.Add(this.lblDefencesMetalCost);
            this.panel10.Controls.Add(this.label23);
            this.panel10.Location = new System.Drawing.Point(900, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 200);
            this.panel10.TabIndex = 4;
            // 
            // lblDefencesTotalCost
            // 
            this.lblDefencesTotalCost.BackColor = System.Drawing.Color.Gold;
            this.lblDefencesTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDefencesTotalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDefencesTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDefencesTotalCost.Location = new System.Drawing.Point(0, 160);
            this.lblDefencesTotalCost.Name = "lblDefencesTotalCost";
            this.lblDefencesTotalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblDefencesTotalCost.Size = new System.Drawing.Size(200, 40);
            this.lblDefencesTotalCost.TabIndex = 8;
            this.lblDefencesTotalCost.Text = "0";
            this.lblDefencesTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefencesDeuteriumCost
            // 
            this.lblDefencesDeuteriumCost.BackColor = System.Drawing.Color.Gold;
            this.lblDefencesDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDefencesDeuteriumCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDefencesDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDefencesDeuteriumCost.Location = new System.Drawing.Point(0, 120);
            this.lblDefencesDeuteriumCost.Name = "lblDefencesDeuteriumCost";
            this.lblDefencesDeuteriumCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblDefencesDeuteriumCost.Size = new System.Drawing.Size(200, 40);
            this.lblDefencesDeuteriumCost.TabIndex = 7;
            this.lblDefencesDeuteriumCost.Text = "0";
            this.lblDefencesDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefencesCrystalCost
            // 
            this.lblDefencesCrystalCost.BackColor = System.Drawing.Color.Gold;
            this.lblDefencesCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDefencesCrystalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDefencesCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDefencesCrystalCost.Location = new System.Drawing.Point(0, 80);
            this.lblDefencesCrystalCost.Name = "lblDefencesCrystalCost";
            this.lblDefencesCrystalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblDefencesCrystalCost.Size = new System.Drawing.Size(200, 40);
            this.lblDefencesCrystalCost.TabIndex = 6;
            this.lblDefencesCrystalCost.Text = "0";
            this.lblDefencesCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefencesMetalCost
            // 
            this.lblDefencesMetalCost.BackColor = System.Drawing.Color.Gold;
            this.lblDefencesMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDefencesMetalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDefencesMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDefencesMetalCost.Location = new System.Drawing.Point(0, 40);
            this.lblDefencesMetalCost.Name = "lblDefencesMetalCost";
            this.lblDefencesMetalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblDefencesMetalCost.Size = new System.Drawing.Size(200, 40);
            this.lblDefencesMetalCost.TabIndex = 5;
            this.lblDefencesMetalCost.Text = "0";
            this.lblDefencesMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Gold;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 40);
            this.label23.TabIndex = 4;
            this.label23.Text = "Obrona";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lblFleetTotalCost);
            this.panel9.Controls.Add(this.lblFleetDeuteriumCost);
            this.panel9.Controls.Add(this.lblFleetCrystalCost);
            this.panel9.Controls.Add(this.lblFleetMetalCost);
            this.panel9.Controls.Add(this.label19);
            this.panel9.Location = new System.Drawing.Point(680, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 200);
            this.panel9.TabIndex = 3;
            // 
            // lblFleetTotalCost
            // 
            this.lblFleetTotalCost.BackColor = System.Drawing.Color.Gold;
            this.lblFleetTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFleetTotalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFleetTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFleetTotalCost.Location = new System.Drawing.Point(0, 160);
            this.lblFleetTotalCost.Name = "lblFleetTotalCost";
            this.lblFleetTotalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblFleetTotalCost.Size = new System.Drawing.Size(200, 40);
            this.lblFleetTotalCost.TabIndex = 8;
            this.lblFleetTotalCost.Text = "0";
            this.lblFleetTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFleetDeuteriumCost
            // 
            this.lblFleetDeuteriumCost.BackColor = System.Drawing.Color.Gold;
            this.lblFleetDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFleetDeuteriumCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFleetDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFleetDeuteriumCost.Location = new System.Drawing.Point(0, 120);
            this.lblFleetDeuteriumCost.Name = "lblFleetDeuteriumCost";
            this.lblFleetDeuteriumCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblFleetDeuteriumCost.Size = new System.Drawing.Size(200, 40);
            this.lblFleetDeuteriumCost.TabIndex = 7;
            this.lblFleetDeuteriumCost.Text = "0";
            this.lblFleetDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFleetCrystalCost
            // 
            this.lblFleetCrystalCost.BackColor = System.Drawing.Color.Gold;
            this.lblFleetCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFleetCrystalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFleetCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFleetCrystalCost.Location = new System.Drawing.Point(0, 80);
            this.lblFleetCrystalCost.Name = "lblFleetCrystalCost";
            this.lblFleetCrystalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblFleetCrystalCost.Size = new System.Drawing.Size(200, 40);
            this.lblFleetCrystalCost.TabIndex = 6;
            this.lblFleetCrystalCost.Text = "0";
            this.lblFleetCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFleetMetalCost
            // 
            this.lblFleetMetalCost.BackColor = System.Drawing.Color.Gold;
            this.lblFleetMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFleetMetalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFleetMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFleetMetalCost.Location = new System.Drawing.Point(0, 40);
            this.lblFleetMetalCost.Name = "lblFleetMetalCost";
            this.lblFleetMetalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblFleetMetalCost.Size = new System.Drawing.Size(200, 40);
            this.lblFleetMetalCost.TabIndex = 5;
            this.lblFleetMetalCost.Text = "0";
            this.lblFleetMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Gold;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(200, 40);
            this.label19.TabIndex = 4;
            this.label19.Text = "Flota";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblBuildingsTotalCost);
            this.panel8.Controls.Add(this.lblBuildingsDeuteriumCost);
            this.panel8.Controls.Add(this.lblBuildingsCrystalCost);
            this.panel8.Controls.Add(this.lblBuildingsMetalCost);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(460, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 200);
            this.panel8.TabIndex = 2;
            // 
            // lblBuildingsTotalCost
            // 
            this.lblBuildingsTotalCost.BackColor = System.Drawing.Color.Gold;
            this.lblBuildingsTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuildingsTotalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBuildingsTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingsTotalCost.Location = new System.Drawing.Point(0, 160);
            this.lblBuildingsTotalCost.Name = "lblBuildingsTotalCost";
            this.lblBuildingsTotalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblBuildingsTotalCost.Size = new System.Drawing.Size(200, 40);
            this.lblBuildingsTotalCost.TabIndex = 8;
            this.lblBuildingsTotalCost.Text = "0";
            this.lblBuildingsTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuildingsDeuteriumCost
            // 
            this.lblBuildingsDeuteriumCost.BackColor = System.Drawing.Color.Gold;
            this.lblBuildingsDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuildingsDeuteriumCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBuildingsDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingsDeuteriumCost.Location = new System.Drawing.Point(0, 120);
            this.lblBuildingsDeuteriumCost.Name = "lblBuildingsDeuteriumCost";
            this.lblBuildingsDeuteriumCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblBuildingsDeuteriumCost.Size = new System.Drawing.Size(200, 40);
            this.lblBuildingsDeuteriumCost.TabIndex = 7;
            this.lblBuildingsDeuteriumCost.Text = "0";
            this.lblBuildingsDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuildingsCrystalCost
            // 
            this.lblBuildingsCrystalCost.BackColor = System.Drawing.Color.Gold;
            this.lblBuildingsCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuildingsCrystalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBuildingsCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingsCrystalCost.Location = new System.Drawing.Point(0, 80);
            this.lblBuildingsCrystalCost.Name = "lblBuildingsCrystalCost";
            this.lblBuildingsCrystalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblBuildingsCrystalCost.Size = new System.Drawing.Size(200, 40);
            this.lblBuildingsCrystalCost.TabIndex = 6;
            this.lblBuildingsCrystalCost.Text = "0";
            this.lblBuildingsCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBuildingsMetalCost
            // 
            this.lblBuildingsMetalCost.BackColor = System.Drawing.Color.Gold;
            this.lblBuildingsMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuildingsMetalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBuildingsMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingsMetalCost.Location = new System.Drawing.Point(0, 40);
            this.lblBuildingsMetalCost.Name = "lblBuildingsMetalCost";
            this.lblBuildingsMetalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblBuildingsMetalCost.Size = new System.Drawing.Size(200, 40);
            this.lblBuildingsMetalCost.TabIndex = 5;
            this.lblBuildingsMetalCost.Text = "0";
            this.lblBuildingsMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gold;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 40);
            this.label15.TabIndex = 4;
            this.label15.Text = "Budynki";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblResearchesTotalCost);
            this.panel7.Controls.Add(this.lblResearchesDeuteriumCost);
            this.panel7.Controls.Add(this.lblResearchesCrystalCost);
            this.panel7.Controls.Add(this.lblResearchesMetalCost);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(240, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 200);
            this.panel7.TabIndex = 1;
            // 
            // lblResearchesTotalCost
            // 
            this.lblResearchesTotalCost.BackColor = System.Drawing.Color.Gold;
            this.lblResearchesTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchesTotalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResearchesTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchesTotalCost.Location = new System.Drawing.Point(0, 160);
            this.lblResearchesTotalCost.Name = "lblResearchesTotalCost";
            this.lblResearchesTotalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblResearchesTotalCost.Size = new System.Drawing.Size(200, 40);
            this.lblResearchesTotalCost.TabIndex = 8;
            this.lblResearchesTotalCost.Text = "0";
            this.lblResearchesTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResearchesDeuteriumCost
            // 
            this.lblResearchesDeuteriumCost.BackColor = System.Drawing.Color.Gold;
            this.lblResearchesDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchesDeuteriumCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResearchesDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchesDeuteriumCost.Location = new System.Drawing.Point(0, 120);
            this.lblResearchesDeuteriumCost.Name = "lblResearchesDeuteriumCost";
            this.lblResearchesDeuteriumCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblResearchesDeuteriumCost.Size = new System.Drawing.Size(200, 40);
            this.lblResearchesDeuteriumCost.TabIndex = 7;
            this.lblResearchesDeuteriumCost.Text = "0";
            this.lblResearchesDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResearchesCrystalCost
            // 
            this.lblResearchesCrystalCost.BackColor = System.Drawing.Color.Gold;
            this.lblResearchesCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchesCrystalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResearchesCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchesCrystalCost.Location = new System.Drawing.Point(0, 80);
            this.lblResearchesCrystalCost.Name = "lblResearchesCrystalCost";
            this.lblResearchesCrystalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblResearchesCrystalCost.Size = new System.Drawing.Size(200, 40);
            this.lblResearchesCrystalCost.TabIndex = 6;
            this.lblResearchesCrystalCost.Text = "0";
            this.lblResearchesCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResearchesMetalCost
            // 
            this.lblResearchesMetalCost.BackColor = System.Drawing.Color.Gold;
            this.lblResearchesMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResearchesMetalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResearchesMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResearchesMetalCost.Location = new System.Drawing.Point(0, 40);
            this.lblResearchesMetalCost.Name = "lblResearchesMetalCost";
            this.lblResearchesMetalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblResearchesMetalCost.Size = new System.Drawing.Size(200, 40);
            this.lblResearchesMetalCost.TabIndex = 5;
            this.lblResearchesMetalCost.Text = "0";
            this.lblResearchesMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gold;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 40);
            this.label11.TabIndex = 4;
            this.label11.Text = "Badania";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalTotalCost);
            this.panel1.Controls.Add(this.lblTotalDeuteriumCost);
            this.panel1.Controls.Add(this.lblTotalCrystalCost);
            this.panel1.Controls.Add(this.lblTotalMetalCost);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalTotalCost
            // 
            this.lblTotalTotalCost.BackColor = System.Drawing.Color.Gold;
            this.lblTotalTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalTotalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalTotalCost.Location = new System.Drawing.Point(0, 160);
            this.lblTotalTotalCost.Name = "lblTotalTotalCost";
            this.lblTotalTotalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTotalTotalCost.Size = new System.Drawing.Size(200, 40);
            this.lblTotalTotalCost.TabIndex = 8;
            this.lblTotalTotalCost.Text = "0";
            this.lblTotalTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDeuteriumCost
            // 
            this.lblTotalDeuteriumCost.BackColor = System.Drawing.Color.Gold;
            this.lblTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDeuteriumCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDeuteriumCost.Location = new System.Drawing.Point(0, 120);
            this.lblTotalDeuteriumCost.Name = "lblTotalDeuteriumCost";
            this.lblTotalDeuteriumCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTotalDeuteriumCost.Size = new System.Drawing.Size(200, 40);
            this.lblTotalDeuteriumCost.TabIndex = 7;
            this.lblTotalDeuteriumCost.Text = "0";
            this.lblTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCrystalCost
            // 
            this.lblTotalCrystalCost.BackColor = System.Drawing.Color.Gold;
            this.lblTotalCrystalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCrystalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalCrystalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCrystalCost.Location = new System.Drawing.Point(0, 80);
            this.lblTotalCrystalCost.Name = "lblTotalCrystalCost";
            this.lblTotalCrystalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTotalCrystalCost.Size = new System.Drawing.Size(200, 40);
            this.lblTotalCrystalCost.TabIndex = 6;
            this.lblTotalCrystalCost.Text = "0";
            this.lblTotalCrystalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMetalCost
            // 
            this.lblTotalMetalCost.BackColor = System.Drawing.Color.Gold;
            this.lblTotalMetalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalMetalCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalMetalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMetalCost.Location = new System.Drawing.Point(0, 40);
            this.lblTotalMetalCost.Name = "lblTotalMetalCost";
            this.lblTotalMetalCost.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblTotalMetalCost.Size = new System.Drawing.Size(200, 40);
            this.lblTotalMetalCost.TabIndex = 5;
            this.lblTotalMetalCost.Text = "0";
            this.lblTotalMetalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Razem";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpPlanet
            // 
            this.tpPlanet.BackColor = System.Drawing.Color.Silver;
            this.tpPlanet.Controls.Add(this.btnChangePlanetName);
            this.tpPlanet.Controls.Add(this.tbNewPlanetName);
            this.tpPlanet.Location = new System.Drawing.Point(4, 29);
            this.tpPlanet.Name = "tpPlanet";
            this.tpPlanet.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlanet.Size = new System.Drawing.Size(1896, 800);
            this.tpPlanet.TabIndex = 9;
            this.tpPlanet.Text = "Planeta";
            // 
            // btnChangePlanetName
            // 
            this.btnChangePlanetName.Enabled = false;
            this.btnChangePlanetName.Location = new System.Drawing.Point(166, 15);
            this.btnChangePlanetName.Name = "btnChangePlanetName";
            this.btnChangePlanetName.Size = new System.Drawing.Size(130, 25);
            this.btnChangePlanetName.TabIndex = 3;
            this.btnChangePlanetName.Text = "Zmień nazwę";
            this.btnChangePlanetName.UseVisualStyleBackColor = true;
            this.btnChangePlanetName.Click += new System.EventHandler(this.BtnChangePlanetName_Click);
            // 
            // tbNewPlanetName
            // 
            this.tbNewPlanetName.Location = new System.Drawing.Point(16, 15);
            this.tbNewPlanetName.Name = "tbNewPlanetName";
            this.tbNewPlanetName.Size = new System.Drawing.Size(130, 23);
            this.tbNewPlanetName.TabIndex = 2;
            this.tbNewPlanetName.Text = "Nazwa planety";
            this.tbNewPlanetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpMerchant
            // 
            this.tpMerchant.BackColor = System.Drawing.Color.Gold;
            this.tpMerchant.Controls.Add(this.pMerchant);
            this.tpMerchant.Location = new System.Drawing.Point(4, 29);
            this.tpMerchant.Name = "tpMerchant";
            this.tpMerchant.Padding = new System.Windows.Forms.Padding(3);
            this.tpMerchant.Size = new System.Drawing.Size(1896, 800);
            this.tpMerchant.TabIndex = 10;
            this.tpMerchant.Text = "Handlarz";
            // 
            // pMerchant
            // 
            this.pMerchant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMerchant.Controls.Add(this.btnExchange);
            this.pMerchant.Controls.Add(this.panel2);
            this.pMerchant.Controls.Add(this.gbMerchant);
            this.pMerchant.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMerchant.Location = new System.Drawing.Point(3, 3);
            this.pMerchant.Name = "pMerchant";
            this.pMerchant.Size = new System.Drawing.Size(1890, 150);
            this.pMerchant.TabIndex = 1;
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.Color.Silver;
            this.btnExchange.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExchange.Enabled = false;
            this.btnExchange.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExchange.Location = new System.Drawing.Point(650, 0);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(215, 148);
            this.btnExchange.TabIndex = 2;
            this.btnExchange.Text = "Handluj";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.BtnExchange_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 148);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblDeuteriumMax);
            this.panel6.Controls.Add(this.lblCrystalMax);
            this.panel6.Controls.Add(this.lblMetalMax);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(450, 42);
            this.panel6.TabIndex = 3;
            // 
            // lblDeuteriumMax
            // 
            this.lblDeuteriumMax.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDeuteriumMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumMax.Location = new System.Drawing.Point(300, 0);
            this.lblDeuteriumMax.Name = "lblDeuteriumMax";
            this.lblDeuteriumMax.Size = new System.Drawing.Size(150, 42);
            this.lblDeuteriumMax.TabIndex = 21;
            this.lblDeuteriumMax.Text = "max";
            this.lblDeuteriumMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrystalMax
            // 
            this.lblCrystalMax.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCrystalMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMax.Location = new System.Drawing.Point(150, 0);
            this.lblCrystalMax.Name = "lblCrystalMax";
            this.lblCrystalMax.Size = new System.Drawing.Size(150, 42);
            this.lblCrystalMax.TabIndex = 20;
            this.lblCrystalMax.Text = "max";
            this.lblCrystalMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMetalMax
            // 
            this.lblMetalMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMetalMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMax.Location = new System.Drawing.Point(0, 0);
            this.lblMetalMax.Name = "lblMetalMax";
            this.lblMetalMax.Size = new System.Drawing.Size(150, 42);
            this.lblMetalMax.TabIndex = 19;
            this.lblMetalMax.Text = "max";
            this.lblMetalMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbDeuteriumAmount);
            this.panel5.Controls.Add(this.tbCrystalAmount);
            this.panel5.Controls.Add(this.tbMetalAmount);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 23);
            this.panel5.TabIndex = 2;
            // 
            // tbDeuteriumAmount
            // 
            this.tbDeuteriumAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbDeuteriumAmount.Enabled = false;
            this.tbDeuteriumAmount.Location = new System.Drawing.Point(300, 0);
            this.tbDeuteriumAmount.Name = "tbDeuteriumAmount";
            this.tbDeuteriumAmount.Size = new System.Drawing.Size(150, 23);
            this.tbDeuteriumAmount.TabIndex = 2;
            this.tbDeuteriumAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDeuteriumAmount.TextChanged += new System.EventHandler(this.TbAmount_TextChanged);
            // 
            // tbCrystalAmount
            // 
            this.tbCrystalAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbCrystalAmount.Enabled = false;
            this.tbCrystalAmount.Location = new System.Drawing.Point(150, 0);
            this.tbCrystalAmount.Name = "tbCrystalAmount";
            this.tbCrystalAmount.Size = new System.Drawing.Size(150, 23);
            this.tbCrystalAmount.TabIndex = 1;
            this.tbCrystalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCrystalAmount.TextChanged += new System.EventHandler(this.TbAmount_TextChanged);
            // 
            // tbMetalAmount
            // 
            this.tbMetalAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMetalAmount.Enabled = false;
            this.tbMetalAmount.Location = new System.Drawing.Point(0, 0);
            this.tbMetalAmount.Name = "tbMetalAmount";
            this.tbMetalAmount.Size = new System.Drawing.Size(150, 23);
            this.tbMetalAmount.TabIndex = 0;
            this.tbMetalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMetalAmount.TextChanged += new System.EventHandler(this.TbAmount_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDeuteriumMerchant);
            this.panel4.Controls.Add(this.lblCrystalMerchant);
            this.panel4.Controls.Add(this.lblMetalMerchant);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 42);
            this.panel4.TabIndex = 1;
            // 
            // lblDeuteriumMerchant
            // 
            this.lblDeuteriumMerchant.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumMerchant.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDeuteriumMerchant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumMerchant.Location = new System.Drawing.Point(300, 0);
            this.lblDeuteriumMerchant.Name = "lblDeuteriumMerchant";
            this.lblDeuteriumMerchant.Size = new System.Drawing.Size(150, 42);
            this.lblDeuteriumMerchant.TabIndex = 21;
            this.lblDeuteriumMerchant.Text = "Deuter";
            this.lblDeuteriumMerchant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMerchant
            // 
            this.lblCrystalMerchant.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMerchant.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCrystalMerchant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMerchant.Location = new System.Drawing.Point(150, 0);
            this.lblCrystalMerchant.Name = "lblCrystalMerchant";
            this.lblCrystalMerchant.Size = new System.Drawing.Size(150, 42);
            this.lblCrystalMerchant.TabIndex = 20;
            this.lblCrystalMerchant.Text = "Kryształ";
            this.lblCrystalMerchant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMerchant
            // 
            this.lblMetalMerchant.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMerchant.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMetalMerchant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMerchant.Location = new System.Drawing.Point(0, 0);
            this.lblMetalMerchant.Name = "lblMetalMerchant";
            this.lblMetalMerchant.Size = new System.Drawing.Size(150, 42);
            this.lblMetalMerchant.TabIndex = 19;
            this.lblMetalMerchant.Text = "Metal";
            this.lblMetalMerchant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDeuteriumFactor);
            this.panel3.Controls.Add(this.lblCrystalFactor);
            this.panel3.Controls.Add(this.lblMetalFactor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 43);
            this.panel3.TabIndex = 0;
            // 
            // lblDeuteriumFactor
            // 
            this.lblDeuteriumFactor.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDeuteriumFactor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumFactor.Location = new System.Drawing.Point(300, 0);
            this.lblDeuteriumFactor.Name = "lblDeuteriumFactor";
            this.lblDeuteriumFactor.Size = new System.Drawing.Size(150, 43);
            this.lblDeuteriumFactor.TabIndex = 20;
            this.lblDeuteriumFactor.Text = "1,00";
            this.lblDeuteriumFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalFactor
            // 
            this.lblCrystalFactor.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCrystalFactor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalFactor.Location = new System.Drawing.Point(150, 0);
            this.lblCrystalFactor.Name = "lblCrystalFactor";
            this.lblCrystalFactor.Size = new System.Drawing.Size(150, 43);
            this.lblCrystalFactor.TabIndex = 19;
            this.lblCrystalFactor.Text = "2,00";
            this.lblCrystalFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalFactor
            // 
            this.lblMetalFactor.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMetalFactor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalFactor.Location = new System.Drawing.Point(0, 0);
            this.lblMetalFactor.Name = "lblMetalFactor";
            this.lblMetalFactor.Size = new System.Drawing.Size(150, 43);
            this.lblMetalFactor.TabIndex = 18;
            this.lblMetalFactor.Text = "3,00";
            this.lblMetalFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMerchant
            // 
            this.gbMerchant.BackColor = System.Drawing.Color.Gold;
            this.gbMerchant.Controls.Add(this.rbDeuterium);
            this.gbMerchant.Controls.Add(this.rbCrystal);
            this.gbMerchant.Controls.Add(this.rbMetal);
            this.gbMerchant.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbMerchant.Location = new System.Drawing.Point(0, 0);
            this.gbMerchant.Name = "gbMerchant";
            this.gbMerchant.Size = new System.Drawing.Size(200, 148);
            this.gbMerchant.TabIndex = 0;
            this.gbMerchant.TabStop = false;
            this.gbMerchant.Text = "Wybierz co chcesz sprzedać";
            // 
            // rbDeuterium
            // 
            this.rbDeuterium.Enabled = false;
            this.rbDeuterium.Location = new System.Drawing.Point(20, 105);
            this.rbDeuterium.Name = "rbDeuterium";
            this.rbDeuterium.Size = new System.Drawing.Size(150, 30);
            this.rbDeuterium.TabIndex = 2;
            this.rbDeuterium.Text = "Sprzedaj deuter";
            this.rbDeuterium.UseVisualStyleBackColor = true;
            this.rbDeuterium.CheckedChanged += new System.EventHandler(this.RbCheckedChanged);
            // 
            // rbCrystal
            // 
            this.rbCrystal.Enabled = false;
            this.rbCrystal.Location = new System.Drawing.Point(20, 65);
            this.rbCrystal.Name = "rbCrystal";
            this.rbCrystal.Size = new System.Drawing.Size(150, 30);
            this.rbCrystal.TabIndex = 1;
            this.rbCrystal.Text = "Sprzedaj kryształ";
            this.rbCrystal.UseVisualStyleBackColor = true;
            this.rbCrystal.CheckedChanged += new System.EventHandler(this.RbCheckedChanged);
            // 
            // rbMetal
            // 
            this.rbMetal.Enabled = false;
            this.rbMetal.Location = new System.Drawing.Point(20, 25);
            this.rbMetal.Name = "rbMetal";
            this.rbMetal.Size = new System.Drawing.Size(150, 30);
            this.rbMetal.TabIndex = 0;
            this.rbMetal.Text = "Sprzedaj metal";
            this.rbMetal.UseVisualStyleBackColor = true;
            this.rbMetal.CheckedChanged += new System.EventHandler(this.RbCheckedChanged);
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.Color.Silver;
            this.pInfo.Controls.Add(this.gbTimeEvents);
            this.pInfo.Controls.Add(this.gbPlanetCountInfo);
            this.pInfo.Controls.Add(this.gbEnergyInfo);
            this.pInfo.Controls.Add(this.gbGameInfo);
            this.pInfo.Controls.Add(this.gbStorageTotal);
            this.pInfo.Controls.Add(this.gbTotalResources);
            this.pInfo.Controls.Add(this.gbStoragePlanet);
            this.pInfo.Controls.Add(this.gbPlanetResources);
            this.pInfo.Controls.Add(this.gbPlanetInfo);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInfo.Location = new System.Drawing.Point(0, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(1904, 140);
            this.pInfo.TabIndex = 1;
            // 
            // gbTimeEvents
            // 
            this.gbTimeEvents.Controls.Add(this.lblTimeEvent2);
            this.gbTimeEvents.Controls.Add(this.lblTimeEvent1);
            this.gbTimeEvents.Controls.Add(this.lblTimeEvent0);
            this.gbTimeEvents.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTimeEvents.Location = new System.Drawing.Point(1190, 0);
            this.gbTimeEvents.Name = "gbTimeEvents";
            this.gbTimeEvents.Size = new System.Drawing.Size(420, 140);
            this.gbTimeEvents.TabIndex = 12;
            this.gbTimeEvents.TabStop = false;
            this.gbTimeEvents.Text = "W trakcie realizacji";
            // 
            // lblTimeEvent2
            // 
            this.lblTimeEvent2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTimeEvent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeEvent2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeEvent2.Location = new System.Drawing.Point(10, 100);
            this.lblTimeEvent2.Name = "lblTimeEvent2";
            this.lblTimeEvent2.Size = new System.Drawing.Size(400, 30);
            this.lblTimeEvent2.TabIndex = 21;
            this.lblTimeEvent2.Text = "0";
            this.lblTimeEvent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeEvent1
            // 
            this.lblTimeEvent1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTimeEvent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeEvent1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeEvent1.Location = new System.Drawing.Point(10, 60);
            this.lblTimeEvent1.Name = "lblTimeEvent1";
            this.lblTimeEvent1.Size = new System.Drawing.Size(400, 30);
            this.lblTimeEvent1.TabIndex = 20;
            this.lblTimeEvent1.Text = "0";
            this.lblTimeEvent1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimeEvent0
            // 
            this.lblTimeEvent0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTimeEvent0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeEvent0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimeEvent0.Location = new System.Drawing.Point(10, 20);
            this.lblTimeEvent0.Name = "lblTimeEvent0";
            this.lblTimeEvent0.Size = new System.Drawing.Size(400, 30);
            this.lblTimeEvent0.TabIndex = 19;
            this.lblTimeEvent0.Text = "0";
            this.lblTimeEvent0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPlanetCountInfo
            // 
            this.gbPlanetCountInfo.Controls.Add(this.btnDeletePlanet);
            this.gbPlanetCountInfo.Controls.Add(this.btnNewPlanet);
            this.gbPlanetCountInfo.Controls.Add(this.lblPlanetCount);
            this.gbPlanetCountInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPlanetCountInfo.Location = new System.Drawing.Point(1020, 0);
            this.gbPlanetCountInfo.Name = "gbPlanetCountInfo";
            this.gbPlanetCountInfo.Size = new System.Drawing.Size(170, 140);
            this.gbPlanetCountInfo.TabIndex = 11;
            this.gbPlanetCountInfo.TabStop = false;
            this.gbPlanetCountInfo.Text = "Ilość planet";
            // 
            // btnDeletePlanet
            // 
            this.btnDeletePlanet.BackColor = System.Drawing.Color.Silver;
            this.btnDeletePlanet.Enabled = false;
            this.btnDeletePlanet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePlanet.Location = new System.Drawing.Point(10, 100);
            this.btnDeletePlanet.Name = "btnDeletePlanet";
            this.btnDeletePlanet.Size = new System.Drawing.Size(150, 30);
            this.btnDeletePlanet.TabIndex = 21;
            this.btnDeletePlanet.Text = "Usuń planetę";
            this.btnDeletePlanet.UseVisualStyleBackColor = false;
            this.btnDeletePlanet.Click += new System.EventHandler(this.BtnDeletePlanet_Click);
            // 
            // btnNewPlanet
            // 
            this.btnNewPlanet.BackColor = System.Drawing.Color.Silver;
            this.btnNewPlanet.Enabled = false;
            this.btnNewPlanet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewPlanet.Location = new System.Drawing.Point(10, 60);
            this.btnNewPlanet.Name = "btnNewPlanet";
            this.btnNewPlanet.Size = new System.Drawing.Size(150, 30);
            this.btnNewPlanet.TabIndex = 20;
            this.btnNewPlanet.Text = "Nowa planeta";
            this.btnNewPlanet.UseVisualStyleBackColor = false;
            this.btnNewPlanet.Click += new System.EventHandler(this.BtnNewPlanet_Click);
            // 
            // lblPlanetCount
            // 
            this.lblPlanetCount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlanetCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlanetCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlanetCount.Location = new System.Drawing.Point(10, 20);
            this.lblPlanetCount.Name = "lblPlanetCount";
            this.lblPlanetCount.Size = new System.Drawing.Size(150, 30);
            this.lblPlanetCount.TabIndex = 19;
            this.lblPlanetCount.Text = "1 / 1";
            this.lblPlanetCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbEnergyInfo
            // 
            this.gbEnergyInfo.Controls.Add(this.lblEnergyOverValue);
            this.gbEnergyInfo.Controls.Add(this.lblEnergyAvailableValue);
            this.gbEnergyInfo.Controls.Add(this.lblEnergyDemandValue);
            this.gbEnergyInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbEnergyInfo.Location = new System.Drawing.Point(850, 0);
            this.gbEnergyInfo.Name = "gbEnergyInfo";
            this.gbEnergyInfo.Size = new System.Drawing.Size(170, 140);
            this.gbEnergyInfo.TabIndex = 9;
            this.gbEnergyInfo.TabStop = false;
            this.gbEnergyInfo.Text = "Energia na planecie";
            // 
            // lblEnergyOverValue
            // 
            this.lblEnergyOverValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEnergyOverValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyOverValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyOverValue.Location = new System.Drawing.Point(10, 100);
            this.lblEnergyOverValue.Name = "lblEnergyOverValue";
            this.lblEnergyOverValue.Size = new System.Drawing.Size(150, 30);
            this.lblEnergyOverValue.TabIndex = 17;
            this.lblEnergyOverValue.Text = "Nadmiar";
            this.lblEnergyOverValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyAvailableValue
            // 
            this.lblEnergyAvailableValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEnergyAvailableValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyAvailableValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyAvailableValue.Location = new System.Drawing.Point(10, 20);
            this.lblEnergyAvailableValue.Name = "lblEnergyAvailableValue";
            this.lblEnergyAvailableValue.Size = new System.Drawing.Size(150, 30);
            this.lblEnergyAvailableValue.TabIndex = 13;
            this.lblEnergyAvailableValue.Text = "Dostępna";
            this.lblEnergyAvailableValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyDemandValue
            // 
            this.lblEnergyDemandValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEnergyDemandValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyDemandValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyDemandValue.Location = new System.Drawing.Point(10, 60);
            this.lblEnergyDemandValue.Name = "lblEnergyDemandValue";
            this.lblEnergyDemandValue.Size = new System.Drawing.Size(150, 30);
            this.lblEnergyDemandValue.TabIndex = 15;
            this.lblEnergyDemandValue.Text = "Zapotrzebowanie";
            this.lblEnergyDemandValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbGameInfo
            // 
            this.gbGameInfo.BackColor = System.Drawing.Color.DarkGray;
            this.gbGameInfo.Controls.Add(this.lblLastUpdate);
            this.gbGameInfo.Controls.Add(this.lblGameNameValue);
            this.gbGameInfo.Controls.Add(this.lblEcoSpeedValue);
            this.gbGameInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbGameInfo.Location = new System.Drawing.Point(1734, 0);
            this.gbGameInfo.Name = "gbGameInfo";
            this.gbGameInfo.Size = new System.Drawing.Size(170, 140);
            this.gbGameInfo.TabIndex = 8;
            this.gbGameInfo.TabStop = false;
            this.gbGameInfo.Text = "Informacje o grze";
            // 
            // gbStorageTotal
            // 
            this.gbStorageTotal.BackColor = System.Drawing.Color.Silver;
            this.gbStorageTotal.Controls.Add(this.lblStorageDeuteriumTotalValue);
            this.gbStorageTotal.Controls.Add(this.lblStorageMetalTotalValue);
            this.gbStorageTotal.Controls.Add(this.lblStorageCrystalTotalValue);
            this.gbStorageTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbStorageTotal.Location = new System.Drawing.Point(680, 0);
            this.gbStorageTotal.Name = "gbStorageTotal";
            this.gbStorageTotal.Size = new System.Drawing.Size(170, 140);
            this.gbStorageTotal.TabIndex = 7;
            this.gbStorageTotal.TabStop = false;
            this.gbStorageTotal.Text = "Magazyn łącznie";
            // 
            // lblStorageDeuteriumTotalValue
            // 
            this.lblStorageDeuteriumTotalValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStorageDeuteriumTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStorageDeuteriumTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageDeuteriumTotalValue.Location = new System.Drawing.Point(10, 100);
            this.lblStorageDeuteriumTotalValue.Name = "lblStorageDeuteriumTotalValue";
            this.lblStorageDeuteriumTotalValue.Size = new System.Drawing.Size(150, 30);
            this.lblStorageDeuteriumTotalValue.TabIndex = 8;
            this.lblStorageDeuteriumTotalValue.Text = "Zbiornik deuteru";
            this.lblStorageDeuteriumTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStorageMetalTotalValue
            // 
            this.lblStorageMetalTotalValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStorageMetalTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStorageMetalTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageMetalTotalValue.Location = new System.Drawing.Point(10, 20);
            this.lblStorageMetalTotalValue.Name = "lblStorageMetalTotalValue";
            this.lblStorageMetalTotalValue.Size = new System.Drawing.Size(150, 30);
            this.lblStorageMetalTotalValue.TabIndex = 6;
            this.lblStorageMetalTotalValue.Text = "Magazyn metalu";
            this.lblStorageMetalTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStorageCrystalTotalValue
            // 
            this.lblStorageCrystalTotalValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStorageCrystalTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStorageCrystalTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageCrystalTotalValue.Location = new System.Drawing.Point(10, 60);
            this.lblStorageCrystalTotalValue.Name = "lblStorageCrystalTotalValue";
            this.lblStorageCrystalTotalValue.Size = new System.Drawing.Size(150, 30);
            this.lblStorageCrystalTotalValue.TabIndex = 7;
            this.lblStorageCrystalTotalValue.Text = "Magazyn kryształu";
            this.lblStorageCrystalTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTotalResources
            // 
            this.gbTotalResources.Controls.Add(this.lblDeuteriumTotalValue);
            this.gbTotalResources.Controls.Add(this.lblMetalTotalValue);
            this.gbTotalResources.Controls.Add(this.lblCrystalTotalValue);
            this.gbTotalResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTotalResources.Location = new System.Drawing.Point(510, 0);
            this.gbTotalResources.Name = "gbTotalResources";
            this.gbTotalResources.Size = new System.Drawing.Size(170, 140);
            this.gbTotalResources.TabIndex = 6;
            this.gbTotalResources.TabStop = false;
            this.gbTotalResources.Text = "Zasoby łączne";
            // 
            // lblDeuteriumTotalValue
            // 
            this.lblDeuteriumTotalValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDeuteriumTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumTotalValue.Location = new System.Drawing.Point(10, 100);
            this.lblDeuteriumTotalValue.Name = "lblDeuteriumTotalValue";
            this.lblDeuteriumTotalValue.Size = new System.Drawing.Size(150, 30);
            this.lblDeuteriumTotalValue.TabIndex = 5;
            this.lblDeuteriumTotalValue.Text = "Deuter";
            this.lblDeuteriumTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalTotalValue
            // 
            this.lblCrystalTotalValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCrystalTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalTotalValue.Location = new System.Drawing.Point(10, 60);
            this.lblCrystalTotalValue.Name = "lblCrystalTotalValue";
            this.lblCrystalTotalValue.Size = new System.Drawing.Size(150, 30);
            this.lblCrystalTotalValue.TabIndex = 3;
            this.lblCrystalTotalValue.Text = "Kryształ";
            this.lblCrystalTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbStoragePlanet
            // 
            this.gbStoragePlanet.BackColor = System.Drawing.Color.Silver;
            this.gbStoragePlanet.Controls.Add(this.lblStorageDeuteriumPlanetValue);
            this.gbStoragePlanet.Controls.Add(this.lblStorageMetalPlanetValue);
            this.gbStoragePlanet.Controls.Add(this.lblStorageCrystalPlanetValue);
            this.gbStoragePlanet.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbStoragePlanet.Location = new System.Drawing.Point(340, 0);
            this.gbStoragePlanet.Name = "gbStoragePlanet";
            this.gbStoragePlanet.Size = new System.Drawing.Size(170, 140);
            this.gbStoragePlanet.TabIndex = 4;
            this.gbStoragePlanet.TabStop = false;
            this.gbStoragePlanet.Text = "Magazyn na planecie";
            // 
            // lblStorageDeuteriumPlanetValue
            // 
            this.lblStorageDeuteriumPlanetValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStorageDeuteriumPlanetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStorageDeuteriumPlanetValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageDeuteriumPlanetValue.Location = new System.Drawing.Point(10, 100);
            this.lblStorageDeuteriumPlanetValue.Name = "lblStorageDeuteriumPlanetValue";
            this.lblStorageDeuteriumPlanetValue.Size = new System.Drawing.Size(150, 30);
            this.lblStorageDeuteriumPlanetValue.TabIndex = 8;
            this.lblStorageDeuteriumPlanetValue.Text = "Zbiornik deuteru";
            this.lblStorageDeuteriumPlanetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStorageMetalPlanetValue
            // 
            this.lblStorageMetalPlanetValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStorageMetalPlanetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStorageMetalPlanetValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageMetalPlanetValue.Location = new System.Drawing.Point(10, 20);
            this.lblStorageMetalPlanetValue.Name = "lblStorageMetalPlanetValue";
            this.lblStorageMetalPlanetValue.Size = new System.Drawing.Size(150, 30);
            this.lblStorageMetalPlanetValue.TabIndex = 6;
            this.lblStorageMetalPlanetValue.Text = "Magazyn metalu";
            this.lblStorageMetalPlanetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStorageCrystalPlanetValue
            // 
            this.lblStorageCrystalPlanetValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblStorageCrystalPlanetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStorageCrystalPlanetValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStorageCrystalPlanetValue.Location = new System.Drawing.Point(10, 60);
            this.lblStorageCrystalPlanetValue.Name = "lblStorageCrystalPlanetValue";
            this.lblStorageCrystalPlanetValue.Size = new System.Drawing.Size(150, 30);
            this.lblStorageCrystalPlanetValue.TabIndex = 7;
            this.lblStorageCrystalPlanetValue.Text = "Magazyn kryształu";
            this.lblStorageCrystalPlanetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPlanetResources
            // 
            this.gbPlanetResources.BackColor = System.Drawing.Color.Silver;
            this.gbPlanetResources.Controls.Add(this.lblDeuteriumPlanetValue);
            this.gbPlanetResources.Controls.Add(this.lblMetalPlanetValue);
            this.gbPlanetResources.Controls.Add(this.lblCrystalPlanetValue);
            this.gbPlanetResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPlanetResources.Location = new System.Drawing.Point(170, 0);
            this.gbPlanetResources.Name = "gbPlanetResources";
            this.gbPlanetResources.Size = new System.Drawing.Size(170, 140);
            this.gbPlanetResources.TabIndex = 3;
            this.gbPlanetResources.TabStop = false;
            this.gbPlanetResources.Text = " Zasoby na planecie";
            // 
            // lblDeuteriumPlanetValue
            // 
            this.lblDeuteriumPlanetValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDeuteriumPlanetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumPlanetValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumPlanetValue.Location = new System.Drawing.Point(10, 100);
            this.lblDeuteriumPlanetValue.Name = "lblDeuteriumPlanetValue";
            this.lblDeuteriumPlanetValue.Size = new System.Drawing.Size(150, 30);
            this.lblDeuteriumPlanetValue.TabIndex = 11;
            this.lblDeuteriumPlanetValue.Text = "Deuter";
            this.lblDeuteriumPlanetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalPlanetValue
            // 
            this.lblMetalPlanetValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMetalPlanetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalPlanetValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalPlanetValue.Location = new System.Drawing.Point(10, 20);
            this.lblMetalPlanetValue.Name = "lblMetalPlanetValue";
            this.lblMetalPlanetValue.Size = new System.Drawing.Size(150, 30);
            this.lblMetalPlanetValue.TabIndex = 7;
            this.lblMetalPlanetValue.Text = "Metal";
            this.lblMetalPlanetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalPlanetValue
            // 
            this.lblCrystalPlanetValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCrystalPlanetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalPlanetValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalPlanetValue.Location = new System.Drawing.Point(10, 60);
            this.lblCrystalPlanetValue.Name = "lblCrystalPlanetValue";
            this.lblCrystalPlanetValue.Size = new System.Drawing.Size(150, 30);
            this.lblCrystalPlanetValue.TabIndex = 9;
            this.lblCrystalPlanetValue.Text = "Kryształ";
            this.lblCrystalPlanetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPlanetInfo
            // 
            this.gbPlanetInfo.BackColor = System.Drawing.Color.Silver;
            this.gbPlanetInfo.Controls.Add(this.lblPlanetFields);
            this.gbPlanetInfo.Controls.Add(this.lblDiameterValue);
            this.gbPlanetInfo.Controls.Add(this.lblTemperatureValue);
            this.gbPlanetInfo.Controls.Add(this.lblPlanetNameValue);
            this.gbPlanetInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPlanetInfo.Location = new System.Drawing.Point(0, 0);
            this.gbPlanetInfo.Name = "gbPlanetInfo";
            this.gbPlanetInfo.Size = new System.Drawing.Size(170, 140);
            this.gbPlanetInfo.TabIndex = 5;
            this.gbPlanetInfo.TabStop = false;
            this.gbPlanetInfo.Text = "Informacje o planecie";
            // 
            // lblPlanetFields
            // 
            this.lblPlanetFields.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlanetFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlanetFields.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlanetFields.Location = new System.Drawing.Point(80, 60);
            this.lblPlanetFields.Name = "lblPlanetFields";
            this.lblPlanetFields.Size = new System.Drawing.Size(80, 30);
            this.lblPlanetFields.TabIndex = 8;
            this.lblPlanetFields.Text = "Pola";
            this.lblPlanetFields.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiameterValue
            // 
            this.lblDiameterValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDiameterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiameterValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiameterValue.Location = new System.Drawing.Point(10, 100);
            this.lblDiameterValue.Name = "lblDiameterValue";
            this.lblDiameterValue.Size = new System.Drawing.Size(150, 30);
            this.lblDiameterValue.TabIndex = 7;
            this.lblDiameterValue.Text = "Średnica [km]";
            this.lblDiameterValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperatureValue
            // 
            this.lblTemperatureValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTemperatureValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemperatureValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTemperatureValue.Location = new System.Drawing.Point(10, 60);
            this.lblTemperatureValue.Name = "lblTemperatureValue";
            this.lblTemperatureValue.Size = new System.Drawing.Size(60, 30);
            this.lblTemperatureValue.TabIndex = 5;
            this.lblTemperatureValue.Text = "T [℃]";
            this.lblTemperatureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanetNameValue
            // 
            this.lblPlanetNameValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlanetNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlanetNameValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlanetNameValue.Location = new System.Drawing.Point(10, 20);
            this.lblPlanetNameValue.Name = "lblPlanetNameValue";
            this.lblPlanetNameValue.Size = new System.Drawing.Size(150, 30);
            this.lblPlanetNameValue.TabIndex = 3;
            this.lblPlanetNameValue.Text = "Nazwa planety";
            this.lblPlanetNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPlanetSelect
            // 
            this.pPlanetSelect.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pPlanetSelect.Controls.Add(this.tbEcoSpeed);
            this.pPlanetSelect.Controls.Add(this.btnLoad);
            this.pPlanetSelect.Controls.Add(this.tbNewGameName);
            this.pPlanetSelect.Controls.Add(this.btnClose);
            this.pPlanetSelect.Controls.Add(this.btnNewGame);
            this.pPlanetSelect.Controls.Add(this.btnSave);
            this.pPlanetSelect.Controls.Add(this.cbPlanetSelect);
            this.pPlanetSelect.Controls.Add(this.btnUpdate);
            this.pPlanetSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPlanetSelect.Location = new System.Drawing.Point(0, 0);
            this.pPlanetSelect.Name = "pPlanetSelect";
            this.pPlanetSelect.Size = new System.Drawing.Size(1904, 38);
            this.pPlanetSelect.TabIndex = 6;
            // 
            // cbPlanetSelect
            // 
            this.cbPlanetSelect.FormattingEnabled = true;
            this.cbPlanetSelect.Location = new System.Drawing.Point(6, 8);
            this.cbPlanetSelect.Name = "cbPlanetSelect";
            this.cbPlanetSelect.Size = new System.Drawing.Size(150, 23);
            this.cbPlanetSelect.TabIndex = 4;
            this.cbPlanetSelect.SelectedIndexChanged += new System.EventHandler(this.CbPlanetSelect_SelectedIndexChanged);
            // 
            // lblEspionageTechnologyCollectTime
            // 
            this.lblEspionageTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEspionageTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEspionageTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEspionageTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblEspionageTechnologyCollectTime.Name = "lblEspionageTechnologyCollectTime";
            this.lblEspionageTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblEspionageTechnologyCollectTime.TabIndex = 30;
            this.lblEspionageTechnologyCollectTime.Text = "czas na uzbieranie";
            this.lblEspionageTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerTechnologyCollectTime
            // 
            this.lblComputerTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComputerTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComputerTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblComputerTechnologyCollectTime.Name = "lblComputerTechnologyCollectTime";
            this.lblComputerTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblComputerTechnologyCollectTime.TabIndex = 31;
            this.lblComputerTechnologyCollectTime.Text = "czas na uzbieranie";
            this.lblComputerTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCombustionDriveCollectTime
            // 
            this.lblCombustionDriveCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCombustionDriveCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCombustionDriveCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCombustionDriveCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblCombustionDriveCollectTime.Name = "lblCombustionDriveCollectTime";
            this.lblCombustionDriveCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblCombustionDriveCollectTime.TabIndex = 32;
            this.lblCombustionDriveCollectTime.Text = "czas na uzbieranie";
            this.lblCombustionDriveCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpulseDriveCollectTime
            // 
            this.lblImpulseDriveCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblImpulseDriveCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpulseDriveCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImpulseDriveCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblImpulseDriveCollectTime.Name = "lblImpulseDriveCollectTime";
            this.lblImpulseDriveCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblImpulseDriveCollectTime.TabIndex = 33;
            this.lblImpulseDriveCollectTime.Text = "czas na uzbieranie";
            this.lblImpulseDriveCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceDriveCollectTime
            // 
            this.lblHyperspaceDriveCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceDriveCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceDriveCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceDriveCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblHyperspaceDriveCollectTime.Name = "lblHyperspaceDriveCollectTime";
            this.lblHyperspaceDriveCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceDriveCollectTime.TabIndex = 34;
            this.lblHyperspaceDriveCollectTime.Text = "czas na uzbieranie";
            this.lblHyperspaceDriveCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeaponsTechnologyCollectTime
            // 
            this.lblWeaponsTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponsTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeaponsTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeaponsTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblWeaponsTechnologyCollectTime.Name = "lblWeaponsTechnologyCollectTime";
            this.lblWeaponsTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblWeaponsTechnologyCollectTime.TabIndex = 35;
            this.lblWeaponsTechnologyCollectTime.Text = "czas na uzbieranie";
            this.lblWeaponsTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShieldingTechnologyCollectTime
            // 
            this.lblShieldingTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShieldingTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShieldingTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShieldingTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblShieldingTechnologyCollectTime.Name = "lblShieldingTechnologyCollectTime";
            this.lblShieldingTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblShieldingTechnologyCollectTime.TabIndex = 36;
            this.lblShieldingTechnologyCollectTime.Text = "czas na uzbieranie";
            this.lblShieldingTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArmourTechnologyCollectTime
            // 
            this.lblArmourTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblArmourTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArmourTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArmourTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblArmourTechnologyCollectTime.Name = "lblArmourTechnologyCollectTime";
            this.lblArmourTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblArmourTechnologyCollectTime.TabIndex = 37;
            this.lblArmourTechnologyCollectTime.Text = "czas na uzbieranie";
            this.lblArmourTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyTechnologyCollectTime
            // 
            this.lblEnergyTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergyTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnergyTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnergyTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblEnergyTechnologyCollectTime.Name = "lblEnergyTechnologyCollectTime";
            this.lblEnergyTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblEnergyTechnologyCollectTime.TabIndex = 38;
            this.lblEnergyTechnologyCollectTime.Text = "czas na uzbieranie";
            this.lblEnergyTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHyperspaceTechnologyCollectTime
            // 
            this.lblHyperspaceTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblHyperspaceTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHyperspaceTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHyperspaceTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblHyperspaceTechnologyCollectTime.Name = "lblHyperspaceTechnologyCollectTime";
            this.lblHyperspaceTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblHyperspaceTechnologyCollectTime.TabIndex = 39;
            this.lblHyperspaceTechnologyCollectTime.Text = "czas na uzbieranie";
            this.lblHyperspaceTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLaserTechnologyCollectTime
            // 
            this.lblLaserTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLaserTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaserTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaserTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblLaserTechnologyCollectTime.Name = "lblLaserTechnologyCollectTime";
            this.lblLaserTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblLaserTechnologyCollectTime.TabIndex = 40;
            this.lblLaserTechnologyCollectTime.Text = "czas na uzbieranie";
            this.lblLaserTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIonTechnologyCollectTime
            // 
            this.lblIonTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblIonTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIonTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIonTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblIonTechnologyCollectTime.Name = "lblIonTechnologyCollectTime";
            this.lblIonTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblIonTechnologyCollectTime.TabIndex = 41;
            this.lblIonTechnologyCollectTime.Text = "koszt w deuterze";
            this.lblIonTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlasmaTechnologyCollectTime
            // 
            this.lblPlasmaTechnologyCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblPlasmaTechnologyCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlasmaTechnologyCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlasmaTechnologyCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblPlasmaTechnologyCollectTime.Name = "lblPlasmaTechnologyCollectTime";
            this.lblPlasmaTechnologyCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblPlasmaTechnologyCollectTime.TabIndex = 42;
            this.lblPlasmaTechnologyCollectTime.Text = "koszt w deuterze";
            this.lblPlasmaTechnologyCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrnCollectTime
            // 
            this.lblIrnCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblIrnCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIrnCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIrnCollectTime.Location = new System.Drawing.Point(1500, 10);
            this.lblIrnCollectTime.Name = "lblIrnCollectTime";
            this.lblIrnCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblIrnCollectTime.TabIndex = 43;
            this.lblIrnCollectTime.Text = "koszt w deuterze";
            this.lblIrnCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAstrophisicsColletTime
            // 
            this.lblAstrophisicsColletTime.BackColor = System.Drawing.Color.Transparent;
            this.lblAstrophisicsColletTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAstrophisicsColletTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrophisicsColletTime.Location = new System.Drawing.Point(1500, 10);
            this.lblAstrophisicsColletTime.Name = "lblAstrophisicsColletTime";
            this.lblAstrophisicsColletTime.Size = new System.Drawing.Size(130, 30);
            this.lblAstrophisicsColletTime.TabIndex = 44;
            this.lblAstrophisicsColletTime.Text = "koszt w deuterze";
            this.lblAstrophisicsColletTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMineTotalDeuteriumCost
            // 
            this.lblMetalMineTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineTotalDeuteriumCost.Location = new System.Drawing.Point(1500, 10);
            this.lblMetalMineTotalDeuteriumCost.Name = "lblMetalMineTotalDeuteriumCost";
            this.lblMetalMineTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineTotalDeuteriumCost.TabIndex = 30;
            this.lblMetalMineTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblMetalMineTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetalMineCollectTime
            // 
            this.lblMetalMineCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblMetalMineCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMetalMineCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetalMineCollectTime.Location = new System.Drawing.Point(1640, 10);
            this.lblMetalMineCollectTime.Name = "lblMetalMineCollectTime";
            this.lblMetalMineCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblMetalMineCollectTime.TabIndex = 31;
            this.lblMetalMineCollectTime.Text = "czas na uzbieranie";
            this.lblMetalMineCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMineTotalDeuteriumCost
            // 
            this.lblCrystalMineTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineTotalDeuteriumCost.Location = new System.Drawing.Point(1500, 10);
            this.lblCrystalMineTotalDeuteriumCost.Name = "lblCrystalMineTotalDeuteriumCost";
            this.lblCrystalMineTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineTotalDeuteriumCost.TabIndex = 31;
            this.lblCrystalMineTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblCrystalMineTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSynthesizerTotalDeuteriumCost
            // 
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.Location = new System.Drawing.Point(1500, 10);
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.Name = "lblDeuteriumSynthesizerTotalDeuteriumCost";
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.TabIndex = 31;
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblDeuteriumSynthesizerTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactorTotalDeuteriumCost
            // 
            this.lblFusionReactorTotalDeuteriumCost.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorTotalDeuteriumCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorTotalDeuteriumCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorTotalDeuteriumCost.Location = new System.Drawing.Point(1500, 10);
            this.lblFusionReactorTotalDeuteriumCost.Name = "lblFusionReactorTotalDeuteriumCost";
            this.lblFusionReactorTotalDeuteriumCost.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorTotalDeuteriumCost.TabIndex = 31;
            this.lblFusionReactorTotalDeuteriumCost.Text = "koszt w deuterze";
            this.lblFusionReactorTotalDeuteriumCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCrystalMineCollectTime
            // 
            this.lblCrystalMineCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCrystalMineCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCrystalMineCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrystalMineCollectTime.Location = new System.Drawing.Point(1640, 10);
            this.lblCrystalMineCollectTime.Name = "lblCrystalMineCollectTime";
            this.lblCrystalMineCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblCrystalMineCollectTime.TabIndex = 32;
            this.lblCrystalMineCollectTime.Text = "czas na uzbieranie";
            this.lblCrystalMineCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeuteriumSyntesizerCollectTime
            // 
            this.lblDeuteriumSyntesizerCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDeuteriumSyntesizerCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuteriumSyntesizerCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeuteriumSyntesizerCollectTime.Location = new System.Drawing.Point(1640, 10);
            this.lblDeuteriumSyntesizerCollectTime.Name = "lblDeuteriumSyntesizerCollectTime";
            this.lblDeuteriumSyntesizerCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblDeuteriumSyntesizerCollectTime.TabIndex = 32;
            this.lblDeuteriumSyntesizerCollectTime.Text = "czas na uzbieranie";
            this.lblDeuteriumSyntesizerCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFusionReactorCollectTime
            // 
            this.lblFusionReactorCollectTime.BackColor = System.Drawing.Color.Transparent;
            this.lblFusionReactorCollectTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFusionReactorCollectTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFusionReactorCollectTime.Location = new System.Drawing.Point(1640, 10);
            this.lblFusionReactorCollectTime.Name = "lblFusionReactorCollectTime";
            this.lblFusionReactorCollectTime.Size = new System.Drawing.Size(130, 30);
            this.lblFusionReactorCollectTime.TabIndex = 32;
            this.lblFusionReactorCollectTime.Text = "czas na uzbieranie";
            this.lblFusionReactorCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1904, 1011);
            this.Controls.Add(this.pContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miner Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pContent.ResumeLayout(false);
            this.pPlanet.ResumeLayout(false);
            this.pPlanetStructures.ResumeLayout(false);
            this.tcStructures.ResumeLayout(false);
            this.tpResources.ResumeLayout(false);
            this.pDeuteriumTank.ResumeLayout(false);
            this.pCrystalStorage.ResumeLayout(false);
            this.pMetalStorage.ResumeLayout(false);
            this.pFusionReactor.ResumeLayout(false);
            this.pSolarPlant.ResumeLayout(false);
            this.pDeuteriumSynthesizer.ResumeLayout(false);
            this.pCrystalMine.ResumeLayout(false);
            this.pMetalMine.ResumeLayout(false);
            this.tpProduction.ResumeLayout(false);
            this.tpProduction.PerformLayout();
            this.pTotalProduction.ResumeLayout(false);
            this.pTotalProductionDetails.ResumeLayout(false);
            this.pTotalDeuteriumProductionDetails.ResumeLayout(false);
            this.pTotalCrystalProductionDetails.ResumeLayout(false);
            this.pTotalMetalProductionDetails.ResumeLayout(false);
            this.pTotalProductionHeader.ResumeLayout(false);
            this.tpStation.ResumeLayout(false);
            this.pJumpGate.ResumeLayout(false);
            this.pSensorPhalanx.ResumeLayout(false);
            this.pLunarBase.ResumeLayout(false);
            this.pSpaceDock.ResumeLayout(false);
            this.pTerraformer.ResumeLayout(false);
            this.pMissileSilo.ResumeLayout(false);
            this.pResearchLab.ResumeLayout(false);
            this.pShipyard.ResumeLayout(false);
            this.pNaniteFactory.ResumeLayout(false);
            this.pRoboticsFactory.ResumeLayout(false);
            this.tpResearch.ResumeLayout(false);
            this.pGravitonTechnology.ResumeLayout(false);
            this.pAstrophisics.ResumeLayout(false);
            this.pIrn.ResumeLayout(false);
            this.pPlasmaTechnology.ResumeLayout(false);
            this.pIonTechnology.ResumeLayout(false);
            this.pLaserTechnology.ResumeLayout(false);
            this.pHyperspaceTechnology.ResumeLayout(false);
            this.pEnergyTechnology.ResumeLayout(false);
            this.pArmourTechnology.ResumeLayout(false);
            this.pShieldingTechnology.ResumeLayout(false);
            this.pWeaponsTechnology.ResumeLayout(false);
            this.pHyperspaceDrive.ResumeLayout(false);
            this.pImpulseDrive.ResumeLayout(false);
            this.pCombustionDrive.ResumeLayout(false);
            this.pComputerTechnology.ResumeLayout(false);
            this.pEspionageTechnology.ResumeLayout(false);
            this.tpShipyard.ResumeLayout(false);
            this.pPathfinder.ResumeLayout(false);
            this.pPathfinder.PerformLayout();
            this.pReaper.ResumeLayout(false);
            this.pReaper.PerformLayout();
            this.pDeathstar.ResumeLayout(false);
            this.pDeathstar.PerformLayout();
            this.pDestroyer.ResumeLayout(false);
            this.pDestroyer.PerformLayout();
            this.pBomber.ResumeLayout(false);
            this.pBomber.PerformLayout();
            this.pBattlecruiser.ResumeLayout(false);
            this.pBattlecruiser.PerformLayout();
            this.pBattleship.ResumeLayout(false);
            this.pBattleship.PerformLayout();
            this.pCruiser.ResumeLayout(false);
            this.pCruiser.PerformLayout();
            this.pHeavyFighter.ResumeLayout(false);
            this.pHeavyFighter.PerformLayout();
            this.pLightFighter.ResumeLayout(false);
            this.pLightFighter.PerformLayout();
            this.pEspionageProbe.ResumeLayout(false);
            this.pEspionageProbe.PerformLayout();
            this.pRecycler.ResumeLayout(false);
            this.pRecycler.PerformLayout();
            this.pColonyShip.ResumeLayout(false);
            this.pColonyShip.PerformLayout();
            this.pLargeCargo.ResumeLayout(false);
            this.pLargeCargo.PerformLayout();
            this.pSmallCargo.ResumeLayout(false);
            this.pSmallCargo.PerformLayout();
            this.tpDefence.ResumeLayout(false);
            this.pInterplanetaryMissile.ResumeLayout(false);
            this.pInterplanetaryMissile.PerformLayout();
            this.pAntiBallisticMissile.ResumeLayout(false);
            this.pAntiBallisticMissile.PerformLayout();
            this.pLargeShieldDome.ResumeLayout(false);
            this.pLargeShieldDome.PerformLayout();
            this.pSmallShieldDome.ResumeLayout(false);
            this.pSmallShieldDome.PerformLayout();
            this.pPlasmaTurret.ResumeLayout(false);
            this.pPlasmaTurret.PerformLayout();
            this.pIonCannon.ResumeLayout(false);
            this.pIonCannon.PerformLayout();
            this.pGaussCannon.ResumeLayout(false);
            this.pGaussCannon.PerformLayout();
            this.pHeavyLaser.ResumeLayout(false);
            this.pHeavyLaser.PerformLayout();
            this.pLightLaser.ResumeLayout(false);
            this.pLightLaser.PerformLayout();
            this.pRocketLauncher.ResumeLayout(false);
            this.pRocketLauncher.PerformLayout();
            this.pCrawler.ResumeLayout(false);
            this.pCrawler.PerformLayout();
            this.pSolarSatellite.ResumeLayout(false);
            this.pSolarSatellite.PerformLayout();
            this.tpFleet.ResumeLayout(false);
            this.tpFleet.PerformLayout();
            this.tpPoints.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpPlanet.ResumeLayout(false);
            this.tpPlanet.PerformLayout();
            this.tpMerchant.ResumeLayout(false);
            this.pMerchant.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbMerchant.ResumeLayout(false);
            this.pInfo.ResumeLayout(false);
            this.gbTimeEvents.ResumeLayout(false);
            this.gbPlanetCountInfo.ResumeLayout(false);
            this.gbEnergyInfo.ResumeLayout(false);
            this.gbGameInfo.ResumeLayout(false);
            this.gbStorageTotal.ResumeLayout(false);
            this.gbTotalResources.ResumeLayout(false);
            this.gbStoragePlanet.ResumeLayout(false);
            this.gbPlanetResources.ResumeLayout(false);
            this.gbPlanetInfo.ResumeLayout(false);
            this.pPlanetSelect.ResumeLayout(false);
            this.pPlanetSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMetalTotalValue;
        private System.Windows.Forms.TextBox tbEcoSpeed;
        private System.Windows.Forms.TextBox tbNewGameName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblEcoSpeedValue;
        private System.Windows.Forms.Label lblGameNameValue;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.GroupBox gbPlanetResources;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblCrystalTotalValue;
        private System.Windows.Forms.ComboBox cbPlanetSelect;
        private System.Windows.Forms.Panel pPlanet;
        private System.Windows.Forms.Panel pPlanetSelect;
        private System.Windows.Forms.Panel pPlanetStructures;
        private System.Windows.Forms.TabControl tcStructures;
        private System.Windows.Forms.TabPage tpResources;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.TabPage tpShipyard;
        private System.Windows.Forms.TabPage tpDefence;
        private System.Windows.Forms.TabPage tpResearch;
        private System.Windows.Forms.GroupBox gbStoragePlanet;
        private System.Windows.Forms.GroupBox gbPlanetInfo;
        private System.Windows.Forms.Label lblDeuteriumTotalValue;
        private System.Windows.Forms.Label lblDeuteriumPlanetValue;
        private System.Windows.Forms.Label lblMetalPlanetValue;
        private System.Windows.Forms.Label lblCrystalPlanetValue;
        private System.Windows.Forms.Label lblDiameterValue;
        private System.Windows.Forms.Label lblTemperatureValue;
        private System.Windows.Forms.Label lblPlanetNameValue;
        private System.Windows.Forms.Panel pEspionageTechnology;
        private System.Windows.Forms.Label lblEspionageTechnologyLevel;
        private System.Windows.Forms.Label lblEspionageTechnology;
        private System.Windows.Forms.Label lblEspionageTechnologyDuration;
        private System.Windows.Forms.Button btnEspionageTechnologyUpgrade;
        private System.Windows.Forms.Label lblEspionageTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblEspionageTechnologyCrystalCost;
        private System.Windows.Forms.Label lblEspionageTechnologyMetalCost;
        private System.Windows.Forms.GroupBox gbTotalResources;
        private System.Windows.Forms.GroupBox gbStorageTotal;
        private System.Windows.Forms.Label lblStorageDeuteriumPlanetValue;
        private System.Windows.Forms.Label lblStorageMetalPlanetValue;
        private System.Windows.Forms.Label lblStorageCrystalPlanetValue;
        private System.Windows.Forms.GroupBox gbGameInfo;
        private System.Windows.Forms.Label lblStorageDeuteriumTotalValue;
        private System.Windows.Forms.Label lblStorageMetalTotalValue;
        private System.Windows.Forms.Label lblStorageCrystalTotalValue;
        private System.Windows.Forms.Panel pComputerTechnology;
        private System.Windows.Forms.Label lblComputerTechnologyDuration;
        private System.Windows.Forms.Button btnComputerTechnologyUpgrade;
        private System.Windows.Forms.Label lblComputerTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblComputerTechnologyCrystalCost;
        private System.Windows.Forms.Label lblComputerTechnologyMetalCost;
        private System.Windows.Forms.Label lblComputerTechnologyLevel;
        private System.Windows.Forms.Label lblComputerTechnology;
        private System.Windows.Forms.Panel pHyperspaceDrive;
        private System.Windows.Forms.Label lblHyperspaceDriveDuration;
        private System.Windows.Forms.Button btnHyperspaceDriveUpgrade;
        private System.Windows.Forms.Label lblHyperspaceDriveDeuteriumCost;
        private System.Windows.Forms.Label lblHyperspaceDriveCrystalCost;
        private System.Windows.Forms.Label lblHyperspaceDriveMetalCost;
        private System.Windows.Forms.Label lblHyperspaceDriveLevel;
        private System.Windows.Forms.Label lblHyperspaceDrive;
        private System.Windows.Forms.Panel pImpulseDrive;
        private System.Windows.Forms.Label lblImpulseDriveDuration;
        private System.Windows.Forms.Button btnImpulseDriveUpgrade;
        private System.Windows.Forms.Label lblImpulseDriveDeuteriumCost;
        private System.Windows.Forms.Label lblImpulseDriveCrystalCost;
        private System.Windows.Forms.Label lblImpulseDriveMetalCost;
        private System.Windows.Forms.Label lblImpulseDriveLevel;
        private System.Windows.Forms.Label lblImpulseDrive;
        private System.Windows.Forms.Panel pCombustionDrive;
        private System.Windows.Forms.Label lblCombustionDriveDuration;
        private System.Windows.Forms.Button btnCombustionDriveUpgrade;
        private System.Windows.Forms.Label lblCombustionDriveDeuteriumCost;
        private System.Windows.Forms.Label lblCombustionDriveCrystalCost;
        private System.Windows.Forms.Label lblCombustionDriveMetalCost;
        private System.Windows.Forms.Label lblCombustionDriveLevel;
        private System.Windows.Forms.Label lblCombustionDrive;
        private System.Windows.Forms.Panel pWeaponsTechnology;
        private System.Windows.Forms.Label lblWeaponsTechnologyDuration;
        private System.Windows.Forms.Button btnWeapeonsTechnologyUpgrade;
        private System.Windows.Forms.Label lblWeaponsTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblWeaponsTechnologyCrystalCost;
        private System.Windows.Forms.Label lblWeaponsTechnologyMetalCost;
        private System.Windows.Forms.Label lblWeaponsTechnologyLevel;
        private System.Windows.Forms.Label lblWeaponsTechnology;
        private System.Windows.Forms.Panel pShieldingTechnology;
        private System.Windows.Forms.Label lblShieldingTechnologyDuration;
        private System.Windows.Forms.Button btnShieldingTechnologyUpgrade;
        private System.Windows.Forms.Label lblShieldingTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblShieldingTechnologyCrystalCost;
        private System.Windows.Forms.Label lblShieldingTechnologyMetalCost;
        private System.Windows.Forms.Label lblShieldingTechnologyLevel;
        private System.Windows.Forms.Label lblShieldingTechnology;
        private System.Windows.Forms.Panel pArmourTechnology;
        private System.Windows.Forms.Label lblArmourTechnologyDuration;
        private System.Windows.Forms.Button btnArmourTechnologyUpgrade;
        private System.Windows.Forms.Label lblArmourTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblArmourTechnologyCrystalCost;
        private System.Windows.Forms.Label lblArmourTechnologyMetalCost;
        private System.Windows.Forms.Label lblArmourTechnologyLevel;
        private System.Windows.Forms.Label lblArmourTechnology;
        private System.Windows.Forms.Panel pEnergyTechnology;
        private System.Windows.Forms.Label lblEnergyTechnologyDuration;
        private System.Windows.Forms.Button btnEnergyTechnologyUpgrade;
        private System.Windows.Forms.Label lblEnergyTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblEnergyTechnologyCrystalCost;
        private System.Windows.Forms.Label lblEnergyTechnologyMetalCost;
        private System.Windows.Forms.Label lblEnergyTechnologyLevel;
        private System.Windows.Forms.Label lblEnergyTechnology;
        private System.Windows.Forms.Panel pHyperspaceTechnology;
        private System.Windows.Forms.Label lblHyperspaceTechnologyDuration;
        private System.Windows.Forms.Button btnHyperspaceTechnologyUpgrade;
        private System.Windows.Forms.Label lblHyperspaceTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblHyperspaceTechnologyCrystalCost;
        private System.Windows.Forms.Label lblHyperspaceTechnologyMetalCost;
        private System.Windows.Forms.Label lblHyperspaceTechnologyLevel;
        private System.Windows.Forms.Label lblHyperspaceTechnology;
        private System.Windows.Forms.Panel pIonTechnology;
        private System.Windows.Forms.Label lblIonTechnologyDuration;
        private System.Windows.Forms.Button btnIonTechnologyUpgrade;
        private System.Windows.Forms.Label lblIonTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblIonTechnologyCrystalCost;
        private System.Windows.Forms.Label lblIonTechnologyMetalCost;
        private System.Windows.Forms.Label lblIonTechnologyLevel;
        private System.Windows.Forms.Label lblIonTechnology;
        private System.Windows.Forms.Panel pLaserTechnology;
        private System.Windows.Forms.Label lblLaserTechnologyDuration;
        private System.Windows.Forms.Button btnLaserTechnologyUpgrade;
        private System.Windows.Forms.Label lblLaserTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblLaserTechnologyCrystalCost;
        private System.Windows.Forms.Label lblLaserTechnologyMetalCost;
        private System.Windows.Forms.Label lblLaserTechnologyLevel;
        private System.Windows.Forms.Label lblLaserTechnology;
        private System.Windows.Forms.Panel pPlasmaTechnology;
        private System.Windows.Forms.Label lblPlasmaTechnologyDuration;
        private System.Windows.Forms.Button btnPlasmaTechnologyUpgrade;
        private System.Windows.Forms.Label lblPlasmaTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblPlasmaTechnologyCrystalCost;
        private System.Windows.Forms.Label lblPlasmaTechnologyMetalCost;
        private System.Windows.Forms.Label lblPlasmaTechnologyLevel;
        private System.Windows.Forms.Label lblPlasmaTechnology;
        private System.Windows.Forms.Panel pIrn;
        private System.Windows.Forms.Label lblIrnDuration;
        private System.Windows.Forms.Button btnIrnUpgrade;
        private System.Windows.Forms.Label lblIrnDeuteriumCost;
        private System.Windows.Forms.Label lblIrnCrystalCost;
        private System.Windows.Forms.Label lblIrnMetalCost;
        private System.Windows.Forms.Label lblIrnLevel;
        private System.Windows.Forms.Label lblIrn;
        private System.Windows.Forms.Panel pAstrophisics;
        private System.Windows.Forms.Label lblAstrophisicsDuration;
        private System.Windows.Forms.Button btnAstrophisicsUpgrade;
        private System.Windows.Forms.Label lblAstrophisicsDeuteriumCost;
        private System.Windows.Forms.Label lblAstrophisicsCrystalCost;
        private System.Windows.Forms.Label lblAstrophisicsMetalCost;
        private System.Windows.Forms.Label lblAstrophisicsLevel;
        private System.Windows.Forms.Label lblAstrophisics;
        private System.Windows.Forms.Panel pGravitonTechnology;
        private System.Windows.Forms.Label lblGravitonTechnologyDuration;
        private System.Windows.Forms.Button btnGravitonTechnologyUpgrade;
        private System.Windows.Forms.Label lblGravitonTechnologyDeuteriumCost;
        private System.Windows.Forms.Label lblGravitonTechnologyCrystalCost;
        private System.Windows.Forms.Label lblGravitonTechnologyMetalCost;
        private System.Windows.Forms.Label lblGravitonTechnologyLevel;
        private System.Windows.Forms.Label lblGravitonTechnology;
        private System.Windows.Forms.Panel pMetalMine;
        private System.Windows.Forms.Label lblMetalMineDuration;
        private System.Windows.Forms.Button btnMetalMineUpgrade;
        private System.Windows.Forms.Label lblMetalMineDeuteriumCost;
        private System.Windows.Forms.Label lblMetalMineCrystalCost;
        private System.Windows.Forms.Label lblMetalMineMetalCost;
        private System.Windows.Forms.Label lblMetalMineLevel;
        private System.Windows.Forms.Label lblMetalMine;
        private System.Windows.Forms.Label lblGravitonTechnologyEnergyCost;
        private System.Windows.Forms.Panel pCrystalMine;
        private System.Windows.Forms.Label lblCrystalMineProductionIncrease;
        private System.Windows.Forms.Label lblCrystalMineEnergyDemand;
        private System.Windows.Forms.Label lblCrystalMineDuration;
        private System.Windows.Forms.Button btnCrystalMineUpgrade;
        private System.Windows.Forms.Label lblCrystalMineDeuteriumCost;
        private System.Windows.Forms.Label lblCrystalMineCrystalCost;
        private System.Windows.Forms.Label lblCrystalMineMetalCost;
        private System.Windows.Forms.Label lblCrystalMineLevel;
        private System.Windows.Forms.Label lblCrystalMine;
        private System.Windows.Forms.Label lblMetalMineProductionIncrease;
        private System.Windows.Forms.Label lblMetalMineEnergyDemand;
        private System.Windows.Forms.Panel pFusionReactor;
        private System.Windows.Forms.Label lblFusionReactorProductionIncrease;
        private System.Windows.Forms.Label lblFusionReactorDeuteriumDemand;
        private System.Windows.Forms.Label lblFusionReactorDuration;
        private System.Windows.Forms.Button btnFusionReactorUpgrade;
        private System.Windows.Forms.Label lblFusionReactorDeuteriumCost;
        private System.Windows.Forms.Label lblFusionReactorCrystalCost;
        private System.Windows.Forms.Label lblFusionReactorMetalCost;
        private System.Windows.Forms.Label lblFusionReactorLevel;
        private System.Windows.Forms.Label lblFusionReactor;
        private System.Windows.Forms.Panel pSolarPlant;
        private System.Windows.Forms.Label lblSolarPlantProductionIncrease;
        private System.Windows.Forms.Label lblSolarPlantDuration;
        private System.Windows.Forms.Button btnSolarPlantUpgrade;
        private System.Windows.Forms.Label lblSolarPlantDeuteriumCost;
        private System.Windows.Forms.Label lblSolarPlantCrystalCost;
        private System.Windows.Forms.Label lblSolarPlantMetalCost;
        private System.Windows.Forms.Label lblSolarPlantLevel;
        private System.Windows.Forms.Label lblSolarPlant;
        private System.Windows.Forms.Panel pDeuteriumSynthesizer;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerProductionIncrease;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerEnergyDemand;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerDuration;
        private System.Windows.Forms.Button btnDeuteriumSynthesizerUpgrade;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerDeuteriumCost;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerCrystalCost;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerMetalCost;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerLevel;
        private System.Windows.Forms.Label lblDeuteriumSynthesizer;
        private System.Windows.Forms.Panel pDeuteriumTank;
        private System.Windows.Forms.Label lblDeuteriumTankNewStorage;
        private System.Windows.Forms.Label lblDeuteriumTankDuration;
        private System.Windows.Forms.Button btnDeuteriumTankUpgrade;
        private System.Windows.Forms.Label lblDeuteriumTankDeuteriumCost;
        private System.Windows.Forms.Label lblDeuteriumTankCrystalCost;
        private System.Windows.Forms.Label lblDeuteriumTankMetalCost;
        private System.Windows.Forms.Label lblDeuteriumTankLevel;
        private System.Windows.Forms.Label lblDeuteriumTank;
        private System.Windows.Forms.Panel pCrystalStorage;
        private System.Windows.Forms.Label lblCrystalStorageNewStorage;
        private System.Windows.Forms.Label lblCrystalStorageDuration;
        private System.Windows.Forms.Button btnCrystalStorageUpgrade;
        private System.Windows.Forms.Label lblCrystalStorageDeuteriumCost;
        private System.Windows.Forms.Label lblCrystalStorageCrystalCost;
        private System.Windows.Forms.Label lblCrystalStorageMetalCost;
        private System.Windows.Forms.Label lblCrystalStorageLevel;
        private System.Windows.Forms.Label lblCrystalStorage;
        private System.Windows.Forms.Panel pMetalStorage;
        private System.Windows.Forms.Label lblMetalStorageNewStorage;
        private System.Windows.Forms.Label lblMetalStorageDuration;
        private System.Windows.Forms.Button btnMetalStorageUpgrade;
        private System.Windows.Forms.Label lblMetalStorageDeuteriumCost;
        private System.Windows.Forms.Label lblMetalStorageCrystalCost;
        private System.Windows.Forms.Label lblMetalStorageMetalCost;
        private System.Windows.Forms.Label lblMetalStorageLevel;
        private System.Windows.Forms.Label lblMetalStorage;
        private System.Windows.Forms.Panel pSmallCargo;
        private System.Windows.Forms.Label lblSmallCargoDuration;
        private System.Windows.Forms.Button btnSmallCargoConstruct;
        private System.Windows.Forms.Label lblSmallCargoDeuteriumCost;
        private System.Windows.Forms.Label lblSmallCargoCrystalCost;
        private System.Windows.Forms.Label lblSmallCargoMetalCost;
        private System.Windows.Forms.Label lblSmallCargoCount;
        private System.Windows.Forms.Label lblSmallCargo;
        private System.Windows.Forms.TextBox tbSmallCargoCount;
        private System.Windows.Forms.Label lblSmallCargoShade;
        private System.Windows.Forms.GroupBox gbPlanetCountInfo;
        private System.Windows.Forms.GroupBox gbEnergyInfo;
        private System.Windows.Forms.Label lblEnergyOverValue;
        private System.Windows.Forms.Label lblEnergyAvailableValue;
        private System.Windows.Forms.Label lblEnergyDemandValue;
        private System.Windows.Forms.TabPage tpProduction;
        private System.Windows.Forms.TabPage tpRequirements;
        private System.Windows.Forms.TabPage tpFleet;
        private System.Windows.Forms.Label lblPlanetCount;
        private System.Windows.Forms.TabPage tpStation;
        private System.Windows.Forms.Panel pJumpGate;
        private System.Windows.Forms.Panel pSensorPhalanx;
        private System.Windows.Forms.Panel pLunarBase;
        private System.Windows.Forms.Panel pSpaceDock;
        private System.Windows.Forms.Panel pTerraformer;
        private System.Windows.Forms.Panel pMissileSilo;
        private System.Windows.Forms.Panel pResearchLab;
        private System.Windows.Forms.Panel pShipyard;
        private System.Windows.Forms.Panel pNaniteFactory;
        private System.Windows.Forms.Panel pRoboticsFactory;
        private System.Windows.Forms.Label lblRoboticsFactory;
        private System.Windows.Forms.Label lblRoboticsFactoryLevel;
        private System.Windows.Forms.Label lblRoboticsFactoryMetalCost;
        private System.Windows.Forms.Label lblRoboticsFactoryCrystalCost;
        private System.Windows.Forms.Label lblRoboticsFactoryDeuteriumCost;
        private System.Windows.Forms.Button btnRoboticsFactoryUpgrade;
        private System.Windows.Forms.Label lblRoboticsFactoryDuration;
        private System.Windows.Forms.Label lblNaniteFactory;
        private System.Windows.Forms.Label lblNaniteFactoryLevel;
        private System.Windows.Forms.Label lblNaniteFactoryMetalCost;
        private System.Windows.Forms.Label lblNaniteFactoryCrystalCost;
        private System.Windows.Forms.Label lblNaniteFactoryDeuteriumCost;
        private System.Windows.Forms.Button btnNaniteFactoryUpgrade;
        private System.Windows.Forms.Label lblNaniteFactoryDuration;
        private System.Windows.Forms.Label lblShipyard;
        private System.Windows.Forms.Label lblShipyardLevel;
        private System.Windows.Forms.Label lblShipyardMetalCost;
        private System.Windows.Forms.Label lblShipyardCrystalCost;
        private System.Windows.Forms.Label lblShipyardDeuteriumCost;
        private System.Windows.Forms.Button btnShipyardUpgrade;
        private System.Windows.Forms.Label lblShipyardDuration;
        private System.Windows.Forms.Label lblResearchLab;
        private System.Windows.Forms.Label lblResearchLabLevel;
        private System.Windows.Forms.Label lblResearchLabMetalCost;
        private System.Windows.Forms.Label lblResearchLabCrystalCost;
        private System.Windows.Forms.Label lblResearchLabDeuteriumCost;
        private System.Windows.Forms.Button btnResearchLabUpgrade;
        private System.Windows.Forms.Label lblResearchLabDuration;
        private System.Windows.Forms.Label lblMissileSilo;
        private System.Windows.Forms.Label lblMissileSiloLevel;
        private System.Windows.Forms.Label lblMissileSiloMetalCost;
        private System.Windows.Forms.Label lblMissileSiloCrystalCost;
        private System.Windows.Forms.Label lblMissileSiloDeuteriumCost;
        private System.Windows.Forms.Button btnMissileSiloUpgrade;
        private System.Windows.Forms.Label lblMissileSiloDuration;
        private System.Windows.Forms.Label lblTerraformer;
        private System.Windows.Forms.Label lblTerraformerLevel;
        private System.Windows.Forms.Label lblTerraformerMetalCost;
        private System.Windows.Forms.Label lblTerraformerCrystalCost;
        private System.Windows.Forms.Label lblTerraformerDeuteriumCost;
        private System.Windows.Forms.Button btnTerraformerUpgrade;
        private System.Windows.Forms.Label lblTerraformerDuration;
        private System.Windows.Forms.Label lblTerraformerEnergyCost;
        private System.Windows.Forms.Label lblSpaceDock;
        private System.Windows.Forms.Label lblSpaceDockLevel;
        private System.Windows.Forms.Label lblSpaceDockMetalCost;
        private System.Windows.Forms.Label lblSpaceDockCrystalCost;
        private System.Windows.Forms.Label lblSpaceDockDeuteriumCost;
        private System.Windows.Forms.Button btnSpaceDockUpgrade;
        private System.Windows.Forms.Label lblSpaceDockDuration;
        private System.Windows.Forms.Label lblSpaceDockEnergyCost;
        private System.Windows.Forms.Label lblLunarBase;
        private System.Windows.Forms.Label lblLunarBaseLevel;
        private System.Windows.Forms.Label lblLunarBaseMetalCost;
        private System.Windows.Forms.Label lblLunarBaseCrystalCost;
        private System.Windows.Forms.Label lblLunarBaseDeuteriumCost;
        private System.Windows.Forms.Button btnLunarBaseUpgrade;
        private System.Windows.Forms.Label lblLunarBaseDuration;
        private System.Windows.Forms.Label lblSensorPhalanx;
        private System.Windows.Forms.Label lblSensorPhalanxLevel;
        private System.Windows.Forms.Label lblSensorPhalanxMetalCost;
        private System.Windows.Forms.Label lblSensorPhalanxCrystalCost;
        private System.Windows.Forms.Label lblSensorPhalanxDeuteriumCost;
        private System.Windows.Forms.Button btnSensorPhalanxUpgrade;
        private System.Windows.Forms.Label lblSensorPhalanxDuration;
        private System.Windows.Forms.Label lblJumpGate;
        private System.Windows.Forms.Label lblJumpGateLevel;
        private System.Windows.Forms.Label lblJumpGateMetalCost;
        private System.Windows.Forms.Label lblJumpGateCrystalCost;
        private System.Windows.Forms.Label lblJumpGateDeuteriumCost;
        private System.Windows.Forms.Button btnJumpGateUpgrade;
        private System.Windows.Forms.Label lblJumpGateDuration;
        private System.Windows.Forms.Label lblPlanetFields;
        private System.Windows.Forms.Button btnDeletePlanet;
        private System.Windows.Forms.Button btnNewPlanet;
        private System.Windows.Forms.Label lblCrystalStorageTimeRemain;
        private System.Windows.Forms.Label lblMetalStorageTimeRemain;
        private System.Windows.Forms.Label lblFusionReactorTimeRemain;
        private System.Windows.Forms.Label lblSolarPlantTimeRemain;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerTimeRemain;
        private System.Windows.Forms.Label lblCrystalMineTimeRemain;
        private System.Windows.Forms.Label lblMetalMineTimeRemain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblDeuteriumTanlTimeRemain;
        private System.Windows.Forms.Label lblJumpGateTimeRemain;
        private System.Windows.Forms.Label lblSensorPhalanxTimeRemain;
        private System.Windows.Forms.Label lblLunarBaseTimeRemain;
        private System.Windows.Forms.Label lblSpaceDockTimeRemain;
        private System.Windows.Forms.Label lblTerraformerTimeRemain;
        private System.Windows.Forms.Label lblMissileSiloTimeRemain;
        private System.Windows.Forms.Label lblResearchLabTimeRemain;
        private System.Windows.Forms.Label lblShipyardTimeRemain;
        private System.Windows.Forms.Label lblNaniteFactoryTimeRemain;
        private System.Windows.Forms.Label lblRoboticsFactoryTimeRemain;
        private System.Windows.Forms.Label lblAstrophisicsTimeRemain;
        private System.Windows.Forms.Label lblIrnTimeRemain;
        private System.Windows.Forms.Label lblPlasmaTechnologyTimeRemain;
        private System.Windows.Forms.Label lblIonTechnologyTimeRemain;
        private System.Windows.Forms.Label lblLaserTechnologyTimeRemain;
        private System.Windows.Forms.Label lblHyperspaceTechnologyTimeRemain;
        private System.Windows.Forms.Label lblEnergyTechnologyTimeRemain;
        private System.Windows.Forms.Label lblArmourTechnologyTimeRemain;
        private System.Windows.Forms.Label lblShieldingTechnologyTimeRemain;
        private System.Windows.Forms.Label lblWeaponsTechnologyTimeRemian;
        private System.Windows.Forms.Label lblHyperspaceDriveTimeRemain;
        private System.Windows.Forms.Label lblImpulseDriveTimeRemain;
        private System.Windows.Forms.Label lblCombustionDriveTimeRemain;
        private System.Windows.Forms.Label lblComputerTechnologyTimeRemain;
        private System.Windows.Forms.Label lblEspionageTechnologyTimeRemain;
        private System.Windows.Forms.Panel pTotalProduction;
        private System.Windows.Forms.Label lblTotalDeuteriumProduction;
        private System.Windows.Forms.Label lblTotalCrystalProduction;
        private System.Windows.Forms.Label lblTotalMetalProduction;
        private System.Windows.Forms.Label lblTotalProduction;
        private System.Windows.Forms.Panel pTotalProductionDetails;
        private System.Windows.Forms.Panel pTotalDeuteriumProductionDetails;
        private System.Windows.Forms.Panel pTotalCrystalProductionDetails;
        private System.Windows.Forms.Panel pTotalMetalProductionDetails;
        private System.Windows.Forms.Label lblTotalMetalProductionBasic;
        private System.Windows.Forms.Label lblTotalMetalProductionCrawlers;
        private System.Windows.Forms.Label lblTotalMetalProductionPlasma;
        private System.Windows.Forms.Label lblTotalMetalProductionMine;
        private System.Windows.Forms.Panel pTotalProductionHeader;
        private System.Windows.Forms.Label lblProductionBasic;
        private System.Windows.Forms.Label lblProductionCrawlers;
        private System.Windows.Forms.Label lblProductionPlasma;
        private System.Windows.Forms.Label lblProductionMine;
        private System.Windows.Forms.Label lblProductionTotal;
        private System.Windows.Forms.Label lblProductionPlanet;
        private System.Windows.Forms.Label lblTotalCrystalProductionBasic;
        private System.Windows.Forms.Label lblTotalCrystalProductionCrawlers;
        private System.Windows.Forms.Label lblTotalCrystalProductionPlasma;
        private System.Windows.Forms.Label lblTotalCrystalProductionMine;
        private System.Windows.Forms.Label lblTotalDeuteriumProductionBasic;
        private System.Windows.Forms.Label lblTotalDeuteriumProductionCrawlers;
        private System.Windows.Forms.Label lblTotalDeuteriumProductionPlasma;
        private System.Windows.Forms.Label lblTotalDeuteriumProductionMine;
        private System.Windows.Forms.Label lblTotalDeuteriumSynthesizerLevel;
        private System.Windows.Forms.Label lblTotalCrystalMineLevel;
        private System.Windows.Forms.Label lblTotalMetalMineLevel;
        private System.Windows.Forms.Label lblProductionLevel;
        private System.Windows.Forms.Label lblTimeToFillStorage;
        private System.Windows.Forms.Panel pProductionGeneratedContent;
        private System.Windows.Forms.TabPage tpPoints;
        private System.Windows.Forms.TabPage tpPlanet;
        private System.Windows.Forms.Button btnChangePlanetName;
        private System.Windows.Forms.TextBox tbNewPlanetName;
        private System.Windows.Forms.Label lblSmallCargoTimeRemain;
        private System.Windows.Forms.Panel pLargeCargo;
        private System.Windows.Forms.Label lblLargeCargoTimeRemain;
        private System.Windows.Forms.TextBox tbLargeCargoCount;
        private System.Windows.Forms.Label lblLargeCargoShade;
        private System.Windows.Forms.Label lblLargeCargoDuration;
        private System.Windows.Forms.Button btnLargeCargoConstruct;
        private System.Windows.Forms.Label lblLargeCargoDeuteriumCost;
        private System.Windows.Forms.Label lblLargeCargoCrystalCost;
        private System.Windows.Forms.Label lblLargeCargoMetalCost;
        private System.Windows.Forms.Label lblLargeCargoCount;
        private System.Windows.Forms.Label lblLargeCargo;
        private System.Windows.Forms.Panel pRecycler;
        private System.Windows.Forms.Label lblRecyclerTimeRemian;
        private System.Windows.Forms.TextBox tbRecyclerCount;
        private System.Windows.Forms.Label lblRecyclerShade;
        private System.Windows.Forms.Label lblRecyclerDuration;
        private System.Windows.Forms.Button btnRecyclerConstruct;
        private System.Windows.Forms.Label lblRecyclerDeuteriumCost;
        private System.Windows.Forms.Label lblRecyclerCrystalCost;
        private System.Windows.Forms.Label lblRecyclerMetalCost;
        private System.Windows.Forms.Label lblRecyclerCount;
        private System.Windows.Forms.Label lblRecycler;
        private System.Windows.Forms.Panel pColonyShip;
        private System.Windows.Forms.Label lblColonyShipTimeRemain;
        private System.Windows.Forms.TextBox tbColonyShipCount;
        private System.Windows.Forms.Label lblColonyShipShade;
        private System.Windows.Forms.Label lblColonyShipDuration;
        private System.Windows.Forms.Button btnColonyShipConstruct;
        private System.Windows.Forms.Label lblColonyShipDeuteriumCost;
        private System.Windows.Forms.Label lblColonyShipCrystalCost;
        private System.Windows.Forms.Label lblColonyShipMetalCost;
        private System.Windows.Forms.Label lblColonyShipCount;
        private System.Windows.Forms.Label lblColonyShip;
        private System.Windows.Forms.Panel pEspionageProbe;
        private System.Windows.Forms.Label lblEspionageProbeTimeRemain;
        private System.Windows.Forms.TextBox tbEspionageProbeCount;
        private System.Windows.Forms.Label lblEspionageProbeShade;
        private System.Windows.Forms.Label lblEspionageProbeDuration;
        private System.Windows.Forms.Button btnEspionageProbeConstruct;
        private System.Windows.Forms.Label lblEspionageProbeDeuteriumCost;
        private System.Windows.Forms.Label lblEspionageProbeCrystalCost;
        private System.Windows.Forms.Label lblEspionageProbeMetalCost;
        private System.Windows.Forms.Label lblEspionageProbeCount;
        private System.Windows.Forms.Label lblEspionageProbe;
        private System.Windows.Forms.Panel pLightFighter;
        private System.Windows.Forms.Label lblLightFighterTimeRemain;
        private System.Windows.Forms.TextBox tbLightFighterCount;
        private System.Windows.Forms.Label lblLightFighterShade;
        private System.Windows.Forms.Label lblLightFighterDuration;
        private System.Windows.Forms.Button btnLightFighterConstruct;
        private System.Windows.Forms.Label lblLightFighterDeuteriumCost;
        private System.Windows.Forms.Label lblLightFighterCrystalCost;
        private System.Windows.Forms.Label lblLightFighterMetalCost;
        private System.Windows.Forms.Label lblLightFighterCount;
        private System.Windows.Forms.Label lblLightFighter;
        private System.Windows.Forms.Label lblStorageDeuteriumMinTime;
        private System.Windows.Forms.Label lblStorageCrystalMinTime;
        private System.Windows.Forms.Label lblStorageMetalMinTime;
        private System.Windows.Forms.TabPage tpMerchant;
        private System.Windows.Forms.Panel pDestroyer;
        private System.Windows.Forms.Label lblDestroyerTimeRemain;
        private System.Windows.Forms.TextBox tbDestroyerCount;
        private System.Windows.Forms.Label lblDestroyerShade;
        private System.Windows.Forms.Label lblDestroyerDuration;
        private System.Windows.Forms.Button btnDestroyerConstruct;
        private System.Windows.Forms.Label lblDestroyerDeuteriumCost;
        private System.Windows.Forms.Label lblDestroyerCrystalCost;
        private System.Windows.Forms.Label lblDestroyerMetalCost;
        private System.Windows.Forms.Label lblDestroyerCount;
        private System.Windows.Forms.Label lblDestroyer;
        private System.Windows.Forms.Panel pBomber;
        private System.Windows.Forms.Label lblBomberTimeRemain;
        private System.Windows.Forms.TextBox tbBomberCount;
        private System.Windows.Forms.Label lblBomberShade;
        private System.Windows.Forms.Label lblBomberDuration;
        private System.Windows.Forms.Button btnBomberConstruct;
        private System.Windows.Forms.Label lblBomberDeuteriumCost;
        private System.Windows.Forms.Label lblBomberCrystalCost;
        private System.Windows.Forms.Label lblBomberMetalCost;
        private System.Windows.Forms.Label lblBomberCount;
        private System.Windows.Forms.Label lblBomber;
        private System.Windows.Forms.Panel pBattlecruiser;
        private System.Windows.Forms.Label lblBattlecruiserTimeRemain;
        private System.Windows.Forms.TextBox tbBattlecruiserCount;
        private System.Windows.Forms.Label lblBattlecruiserShade;
        private System.Windows.Forms.Label lblBattlecruiserDuration;
        private System.Windows.Forms.Button btnBattlecruiserConstruct;
        private System.Windows.Forms.Label lblBattlecruiserDeuteriumCost;
        private System.Windows.Forms.Label lblBattlecruiserCrystalCost;
        private System.Windows.Forms.Label lblBattlecruiserMetalCost;
        private System.Windows.Forms.Label lblBattlecruiserCount;
        private System.Windows.Forms.Label lblBattlecruiser;
        private System.Windows.Forms.Panel pBattleship;
        private System.Windows.Forms.Label lblBattleshipTimeRemain;
        private System.Windows.Forms.TextBox tbBattleshipCount;
        private System.Windows.Forms.Label lblBattleshipShade;
        private System.Windows.Forms.Label lblBattleshipDuration;
        private System.Windows.Forms.Button btnBattleshipConstruct;
        private System.Windows.Forms.Label lblBattleshipDeuteriumCost;
        private System.Windows.Forms.Label lblBattleshipCrystalCost;
        private System.Windows.Forms.Label lblBattleshipMetalCost;
        private System.Windows.Forms.Label lblBattleshipCount;
        private System.Windows.Forms.Label lblBattleship;
        private System.Windows.Forms.Panel pCruiser;
        private System.Windows.Forms.Label lblCruiserTimeRemain;
        private System.Windows.Forms.TextBox tbCruiserCount;
        private System.Windows.Forms.Label lblCruiserShade;
        private System.Windows.Forms.Label lblCruiserDuration;
        private System.Windows.Forms.Button btnCruiserConstruct;
        private System.Windows.Forms.Label lblCruiserDeuteriumCost;
        private System.Windows.Forms.Label lblCruiserCrystalCost;
        private System.Windows.Forms.Label lblCruiserMetalCost;
        private System.Windows.Forms.Label lblCruiserCount;
        private System.Windows.Forms.Label lblCruiser;
        private System.Windows.Forms.Panel pHeavyFighter;
        private System.Windows.Forms.Label lblHeavyFighterTimeRemain;
        private System.Windows.Forms.TextBox tbHeavyFighterCount;
        private System.Windows.Forms.Label lblHeavyFighterShade;
        private System.Windows.Forms.Label lblHeavyFighterDuration;
        private System.Windows.Forms.Button btnHeavyFighterConstruct;
        private System.Windows.Forms.Label lblHeavyFighterDeuteriumCost;
        private System.Windows.Forms.Label lblHeavyFighterCrystalCost;
        private System.Windows.Forms.Label lblHeavyFighterMetalCost;
        private System.Windows.Forms.Label lblHeavyFighterCount;
        private System.Windows.Forms.Label lblHeavyFighter;
        private System.Windows.Forms.Panel pReaper;
        private System.Windows.Forms.Label lblReaperTimeRemain;
        private System.Windows.Forms.TextBox tbReaperCount;
        private System.Windows.Forms.Label lblReaperShade;
        private System.Windows.Forms.Label lblReaperDuration;
        private System.Windows.Forms.Button btnReaperConstruct;
        private System.Windows.Forms.Label lblReaperDeuteriumCost;
        private System.Windows.Forms.Label lblReaperCrystalCost;
        private System.Windows.Forms.Label lblReaperMetalCost;
        private System.Windows.Forms.Label lblReaperCount;
        private System.Windows.Forms.Label lblReaper;
        private System.Windows.Forms.Panel pDeathstar;
        private System.Windows.Forms.Label lblDeathstarTimeRemain;
        private System.Windows.Forms.TextBox tbDeathstarCount;
        private System.Windows.Forms.Label lblDeathstarShade;
        private System.Windows.Forms.Label lblDeathstarDuration;
        private System.Windows.Forms.Button btnDeathstarConstruct;
        private System.Windows.Forms.Label lblDeathstarDeuteriumCost;
        private System.Windows.Forms.Label lblDeathstarCrystalCost;
        private System.Windows.Forms.Label lblDeathstarMetalCost;
        private System.Windows.Forms.Label lblDeathstarCount;
        private System.Windows.Forms.Label lblDeathstar;
        private System.Windows.Forms.Panel pPathfinder;
        private System.Windows.Forms.Label lblPathfinderTimeRemain;
        private System.Windows.Forms.TextBox tbPathfinderCount;
        private System.Windows.Forms.Label lblPathfinderShade;
        private System.Windows.Forms.Label lblPathfinderDuration;
        private System.Windows.Forms.Button btnPathfinderConstruct;
        private System.Windows.Forms.Label lblPathfinderDeuteriumCost;
        private System.Windows.Forms.Label lblPathfinderCrystalCost;
        private System.Windows.Forms.Label lblPathfinderMetalCost;
        private System.Windows.Forms.Label lblPathfinderCount;
        private System.Windows.Forms.Label lblPathfinder;
        private System.Windows.Forms.Panel pGaussCannon;
        private System.Windows.Forms.Label lblGaussCannonTimeRemain;
        private System.Windows.Forms.TextBox tbGaussCannonCount;
        private System.Windows.Forms.Label lblGaussCannonShade;
        private System.Windows.Forms.Label lblGaussCannonDuration;
        private System.Windows.Forms.Button btnGaussCannonConstruct;
        private System.Windows.Forms.Label lblGaussCannonDeuteriumCost;
        private System.Windows.Forms.Label lblGaussCannonCrystalCost;
        private System.Windows.Forms.Label lblGaussCannonMetalCost;
        private System.Windows.Forms.Label lblGaussCannonCount;
        private System.Windows.Forms.Label lblGaussCannon;
        private System.Windows.Forms.Panel pHeavyLaser;
        private System.Windows.Forms.Label lblHeavyLaserTimeRemain;
        private System.Windows.Forms.TextBox tbHeavyLaserCount;
        private System.Windows.Forms.Label lblHeavyLaserShade;
        private System.Windows.Forms.Label lblHeavyLaserDuration;
        private System.Windows.Forms.Button btnHeavyLaserConstruct;
        private System.Windows.Forms.Label lblHeavyLaserDeuteriumCost;
        private System.Windows.Forms.Label lblHeavyLaserCrystalCost;
        private System.Windows.Forms.Label lblHeavyLaserMetalCost;
        private System.Windows.Forms.Label lblHeavyLaserCount;
        private System.Windows.Forms.Label lblHeavyLaser;
        private System.Windows.Forms.Panel pLightLaser;
        private System.Windows.Forms.Label lblLightLaserTimeRemain;
        private System.Windows.Forms.TextBox tbLightLaserCount;
        private System.Windows.Forms.Label lblLightLaserShade;
        private System.Windows.Forms.Label lblLightLaserDuration;
        private System.Windows.Forms.Button btnLightLaserConstruct;
        private System.Windows.Forms.Label lblLightLaserDeuteriumCost;
        private System.Windows.Forms.Label lblLightLaserCrystalCost;
        private System.Windows.Forms.Label lblLightLaserMetalCost;
        private System.Windows.Forms.Label lblLightLaserCount;
        private System.Windows.Forms.Label lblLightLaser;
        private System.Windows.Forms.Panel pRocketLauncher;
        private System.Windows.Forms.Label lblRocketLauncherTimeRemain;
        private System.Windows.Forms.TextBox tbRocketLauncherCount;
        private System.Windows.Forms.Label lblRocketLauncherShade;
        private System.Windows.Forms.Label lblRocketLauncherDuration;
        private System.Windows.Forms.Button btnRocketLauncherConstruct;
        private System.Windows.Forms.Label lblRocketLauncherDeuteriumCost;
        private System.Windows.Forms.Label lblRocketLauncherCrystalCost;
        private System.Windows.Forms.Label lblRocketLauncherMetalCost;
        private System.Windows.Forms.Label lblRocketLauncherCount;
        private System.Windows.Forms.Label lblRocketLauncher;
        private System.Windows.Forms.Panel pCrawler;
        private System.Windows.Forms.Label lblCrawlerTimeRemain;
        private System.Windows.Forms.TextBox tbCrawlerCount;
        private System.Windows.Forms.Label lblCrawlerShade;
        private System.Windows.Forms.Label lblCrawlerDuration;
        private System.Windows.Forms.Button btnCrawlerConstruct;
        private System.Windows.Forms.Label lblCrawlerDeuteriumCost;
        private System.Windows.Forms.Label lblCrawlerCrystalCost;
        private System.Windows.Forms.Label lblCrawlerMetalCost;
        private System.Windows.Forms.Label lblCrawlerCount;
        private System.Windows.Forms.Label lblCrawler;
        private System.Windows.Forms.Panel pSolarSatellite;
        private System.Windows.Forms.Label lblSolarSatelliteTimeRemain;
        private System.Windows.Forms.TextBox tbSolarSatelliteCount;
        private System.Windows.Forms.Label lblSolarSatelliteShade;
        private System.Windows.Forms.Label lblSolarSatelliteDuration;
        private System.Windows.Forms.Button btnSolarSatelliteConstruct;
        private System.Windows.Forms.Label lblSolarSatelliteDeuteriumCost;
        private System.Windows.Forms.Label lblSolarSatelliteCrystalCost;
        private System.Windows.Forms.Label lblSolarSatelliteMetalCost;
        private System.Windows.Forms.Label lblSolarSatelliteCount;
        private System.Windows.Forms.Label lblSolarSatellite;
        private System.Windows.Forms.Panel pPlasmaTurret;
        private System.Windows.Forms.Label lblPlasmaTurretTimeRemain;
        private System.Windows.Forms.TextBox tbPlasmaTurretCount;
        private System.Windows.Forms.Label lblPlasmaTurretShade;
        private System.Windows.Forms.Label lblPlasmaTurretDuration;
        private System.Windows.Forms.Button btnPlasmaTurretConstruct;
        private System.Windows.Forms.Label lblPlasmaTurretDeuteriumCost;
        private System.Windows.Forms.Label lblPlasmaTurretCrystalCost;
        private System.Windows.Forms.Label lblPlasmaTurretMetalCost;
        private System.Windows.Forms.Label lblPlasmaTurretCount;
        private System.Windows.Forms.Label lblPlasmaTurret;
        private System.Windows.Forms.Panel pIonCannon;
        private System.Windows.Forms.Label lblIonCannonTimeRemain;
        private System.Windows.Forms.TextBox tbIonCannonCount;
        private System.Windows.Forms.Label lblIonCannonShade;
        private System.Windows.Forms.Label lblIonCannonDuration;
        private System.Windows.Forms.Button btnIonCannonConstruct;
        private System.Windows.Forms.Label lblIonCannonDeuteriumCost;
        private System.Windows.Forms.Label lblIonCannonCrystalCost;
        private System.Windows.Forms.Label lblIonCannonMetalCost;
        private System.Windows.Forms.Label lblIonCannonCount;
        private System.Windows.Forms.Label lblIonCannon;
        private System.Windows.Forms.Panel pLargeShieldDome;
        private System.Windows.Forms.Label lblLargeShieldDomeTimeRemain;
        private System.Windows.Forms.TextBox tbLargeShieldDomeCount;
        private System.Windows.Forms.Label lblLargeShieldDomeShade;
        private System.Windows.Forms.Label lblLargeShieldDomeDuration;
        private System.Windows.Forms.Button btnLargeShieldDomeConstruct;
        private System.Windows.Forms.Label lblLargeShieldDomeDeuteriumCost;
        private System.Windows.Forms.Label lblLargeShieldDomeCrystalCost;
        private System.Windows.Forms.Label lblLargeShieldDomeMetalCost;
        private System.Windows.Forms.Label lblLargeShieldDomeCount;
        private System.Windows.Forms.Label lblLargeShieldDome;
        private System.Windows.Forms.Panel pSmallShieldDome;
        private System.Windows.Forms.Label lblSmallShieldDomeTimeRemain;
        private System.Windows.Forms.TextBox tbSmallShieldDomeCount;
        private System.Windows.Forms.Label lblSmallShieldDomeShade;
        private System.Windows.Forms.Label lblSmallShieldDomeDuration;
        private System.Windows.Forms.Button btnSmallShieldDomeConstruct;
        private System.Windows.Forms.Label lblSmallShieldDomeDeuteriumCost;
        private System.Windows.Forms.Label lblSmallShieldDomeCrystalCost;
        private System.Windows.Forms.Label lblSmallShieldDomeMetalCost;
        private System.Windows.Forms.Label lblSmallShieldDomeCount;
        private System.Windows.Forms.Label lblSmallShieldDome;
        private System.Windows.Forms.Panel pAntiBallisticMissile;
        private System.Windows.Forms.Label lblAntiBallisticMissileTimeRemain;
        private System.Windows.Forms.TextBox tbAntiBallisticMissileCount;
        private System.Windows.Forms.Label lblAntiBallisticMissileShade;
        private System.Windows.Forms.Label lblAntiBallisticMissileDuration;
        private System.Windows.Forms.Button btnAntiBallisticMissileConstruct;
        private System.Windows.Forms.Label lblAntiBallisticMissileDeuteriumCost;
        private System.Windows.Forms.Label lblAntiBallisticMissileCrystalCost;
        private System.Windows.Forms.Label lblAntiBallisticMissileMetalCost;
        private System.Windows.Forms.Label lblAntiBallisticMissileCount;
        private System.Windows.Forms.Label lblAntiBallisticMissile;
        private System.Windows.Forms.Panel pInterplanetaryMissile;
        private System.Windows.Forms.Label lblInterplanetaryMissileTimeRemain;
        private System.Windows.Forms.TextBox tbInterplanetaryMissileCount;
        private System.Windows.Forms.Label lblInterplanetaryMissileShade;
        private System.Windows.Forms.Label lblInterplanetaryMissileDuration;
        private System.Windows.Forms.Button btnInterplanetaryMissileConstruct;
        private System.Windows.Forms.Label lblInterplanetaryMissileDeuteriumCost;
        private System.Windows.Forms.Label lblInterplanetaryMissileCrystalCost;
        private System.Windows.Forms.Label lblInterplanetaryMissileMetalCost;
        private System.Windows.Forms.Label lblInterplanetaryMissileCount;
        private System.Windows.Forms.Label lblInterplanetaryMissile;
        private System.Windows.Forms.GroupBox gbMerchant;
        private System.Windows.Forms.RadioButton rbDeuterium;
        private System.Windows.Forms.RadioButton rbCrystal;
        private System.Windows.Forms.RadioButton rbMetal;
        private System.Windows.Forms.Panel pMerchant;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDeuteriumMax;
        private System.Windows.Forms.Label lblCrystalMax;
        private System.Windows.Forms.Label lblMetalMax;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbDeuteriumAmount;
        private System.Windows.Forms.TextBox tbCrystalAmount;
        private System.Windows.Forms.TextBox tbMetalAmount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDeuteriumMerchant;
        private System.Windows.Forms.Label lblCrystalMerchant;
        private System.Windows.Forms.Label lblMetalMerchant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDeuteriumFactor;
        private System.Windows.Forms.Label lblCrystalFactor;
        private System.Windows.Forms.Label lblMetalFactor;
        private System.Windows.Forms.ComboBox cbFleetTarget;
        private System.Windows.Forms.Button btnSendCargo;
        private System.Windows.Forms.TextBox tbDeuteriumCargo;
        private System.Windows.Forms.TextBox tbCrystalCargo;
        private System.Windows.Forms.TextBox tbMetalCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblDefencesTotalCost;
        private System.Windows.Forms.Label lblDefencesDeuteriumCost;
        private System.Windows.Forms.Label lblDefencesCrystalCost;
        private System.Windows.Forms.Label lblDefencesMetalCost;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblFleetTotalCost;
        private System.Windows.Forms.Label lblFleetDeuteriumCost;
        private System.Windows.Forms.Label lblFleetCrystalCost;
        private System.Windows.Forms.Label lblFleetMetalCost;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblBuildingsTotalCost;
        private System.Windows.Forms.Label lblBuildingsDeuteriumCost;
        private System.Windows.Forms.Label lblBuildingsCrystalCost;
        private System.Windows.Forms.Label lblBuildingsMetalCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblResearchesTotalCost;
        private System.Windows.Forms.Label lblResearchesDeuteriumCost;
        private System.Windows.Forms.Label lblResearchesCrystalCost;
        private System.Windows.Forms.Label lblResearchesMetalCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalTotalCost;
        private System.Windows.Forms.Label lblTotalDeuteriumCost;
        private System.Windows.Forms.Label lblTotalCrystalCost;
        private System.Windows.Forms.Label lblTotalMetalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAllResources;
        private System.Windows.Forms.Label lblProductionStorage;
        private System.Windows.Forms.Label lblTotalDeuteriumTankLevel;
        private System.Windows.Forms.Label lblTotalCrystalStorageLevel;
        private System.Windows.Forms.Label lblTotalMetalStorageLevel;
        private System.Windows.Forms.GroupBox gbTimeEvents;
        private System.Windows.Forms.Label lblTimeEvent2;
        private System.Windows.Forms.Label lblTimeEvent1;
        private System.Windows.Forms.Label lblTimeEvent0;
        private System.Windows.Forms.Label lblAstrophisicsTotalCost;
        private System.Windows.Forms.Label lblAstrophisicsTotalDeuteriumCost;
        private System.Windows.Forms.Label lblIrnTotalCost;
        private System.Windows.Forms.Label lblIrnTotalDeuteriumCost;
        private System.Windows.Forms.Label lblPlasmaTechnologyTotalCost;
        private System.Windows.Forms.Label lblPlasmaTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblIonTechnologyTotalCost;
        private System.Windows.Forms.Label lblIonTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblLaserTechnologyTotalCost;
        private System.Windows.Forms.Label lblLaserTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblHyperspaceTechnologyTotalCost;
        private System.Windows.Forms.Label lblHyperspaceTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblEnergyTechnologyTotalCost;
        private System.Windows.Forms.Label lblEnergyTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblArmourTechnologyTotalCost;
        private System.Windows.Forms.Label lblArmourTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblShieldingTechnologyTotalCost;
        private System.Windows.Forms.Label lblShieldingTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblWeaponsTechnologyTotalCost;
        private System.Windows.Forms.Label lblWeaponsTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblHyperspaceDriveTotalCost;
        private System.Windows.Forms.Label lblHyperspaceDriveTotalDeuteriumCost;
        private System.Windows.Forms.Label lblImpulseDriveTotalCost;
        private System.Windows.Forms.Label lblImpulseDriveTotalDeuteriumCost;
        private System.Windows.Forms.Label lblCombustionDriveTotalCost;
        private System.Windows.Forms.Label lblCombustionDriveTotalDeuteriumCost;
        private System.Windows.Forms.Label lblComputerTechnologyTotalCost;
        private System.Windows.Forms.Label lblComputerTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblEspionageTechnologyTotalCost;
        private System.Windows.Forms.Label lblEspionageTechnologyTotalDeuteriumCost;
        private System.Windows.Forms.Label lblFusionReactorCollectTime;
        private System.Windows.Forms.Label lblFusionReactorTotalDeuteriumCost;
        private System.Windows.Forms.Label lblDeuteriumSyntesizerCollectTime;
        private System.Windows.Forms.Label lblDeuteriumSynthesizerTotalDeuteriumCost;
        private System.Windows.Forms.Label lblCrystalMineCollectTime;
        private System.Windows.Forms.Label lblCrystalMineTotalDeuteriumCost;
        private System.Windows.Forms.Label lblMetalMineCollectTime;
        private System.Windows.Forms.Label lblMetalMineTotalDeuteriumCost;
        private System.Windows.Forms.Label lblAstrophisicsColletTime;
        private System.Windows.Forms.Label lblIrnCollectTime;
        private System.Windows.Forms.Label lblPlasmaTechnologyCollectTime;
        private System.Windows.Forms.Label lblIonTechnologyCollectTime;
        private System.Windows.Forms.Label lblLaserTechnologyCollectTime;
        private System.Windows.Forms.Label lblHyperspaceTechnologyCollectTime;
        private System.Windows.Forms.Label lblEnergyTechnologyCollectTime;
        private System.Windows.Forms.Label lblArmourTechnologyCollectTime;
        private System.Windows.Forms.Label lblShieldingTechnologyCollectTime;
        private System.Windows.Forms.Label lblWeaponsTechnologyCollectTime;
        private System.Windows.Forms.Label lblHyperspaceDriveCollectTime;
        private System.Windows.Forms.Label lblImpulseDriveCollectTime;
        private System.Windows.Forms.Label lblCombustionDriveCollectTime;
        private System.Windows.Forms.Label lblComputerTechnologyCollectTime;
        private System.Windows.Forms.Label lblEspionageTechnologyCollectTime;
    }
}

