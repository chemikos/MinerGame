using System;

namespace OgameData
{
    public class Research
    {
        public Item Item { get; set; }
        public int Level { get; set; }
        public Resources TotalCost { get; set; }
        public Resources NextLevelCost { get; set; }
        public TimeSpan ResearchTime { get; set; }
        
        public Research(Item item)
        {
            Item = item;
            Level = 0;
            TotalCost = new Resources();
            NextLevelCost = GameHandler.UpgradeCost(Item, 1);
            ResearchTime = GameHandler.ResearchTime(NextLevelCost, 0, 0, OGame.GameSpeed);
        }
        
        public void Upgrade(int lablvl, int graviton)
        {
            Level++;
            TotalCost.Add(NextLevelCost);
            NextLevelCost = GameHandler.UpgradeCost(Item, Level + 1);
            ResearchTime = GameHandler.ResearchTime(NextLevelCost, lablvl, graviton, OGame.GameSpeed);
        }
    }
}
