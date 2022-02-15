namespace OgameData.UnitModels
{
    public abstract class UnitModel
    {
        public Item Item { get; set; }
        public double StructuralIntegirty { get; set; }
        public double ShieldStrength { get; set; }
        public double AttackStrength { get; set; }
        public long UnitID { get; set; }
        
        public UnitModel(Item item)
        {
            Item = item;
            StructuralIntegirty = GameData.TECHNICAL_DATA[item][Item.STRUCTURAL_INTEGRITY] * (1 + GameData.RESEARCH_EFFECT[Item.ARMOUR_TECHNOLOGY] * OGame.Researches.ArmourTechnology.Level);
            ShieldStrength = GameData.TECHNICAL_DATA[item][Item.SHIELD_STRENGTH] * (1 + GameData.RESEARCH_EFFECT[Item.SHIELDING_TECHNOLOGY] * OGame.Researches.ShieldingTechnology.Level);
            AttackStrength = GameData.TECHNICAL_DATA[item][Item.ATTACK_STRENGTH] * (1 + GameData.RESEARCH_EFFECT[Item.WEAPONS_TECHNOLOGY] * OGame.Researches.WeaponsTechnology.Level);
        }
    }
}