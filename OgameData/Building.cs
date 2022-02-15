using System;

namespace OgameData
{
    public class Building
    {
        public Item Item { get; set; }
        public int Level { get; set; }
        public Resources TotalCost { get; set; }
        public Resources NextLevelCost { get; set; }
        public TimeSpan BuildingTime { get; set; }
        
        public Building(Item item)
        {
            Item = item;
            Level = 0;
            TotalCost = new Resources();
            NextLevelCost = GameHandler.UpgradeCost(Item, 1);
            BuildingTime = GameHandler.BuildingTime(NextLevelCost, 0, 0, OGame.GameSpeed);
        }

        public void Upgrade(int robotics, int nanite)
        {
            Level++;
            TotalCost.Add(NextLevelCost);
            NextLevelCost = GameHandler.UpgradeCost(Item, Level + 1);
            BuildingTime = GameHandler.BuildingTime(NextLevelCost, robotics, nanite, OGame.GameSpeed);
        }
    }
}