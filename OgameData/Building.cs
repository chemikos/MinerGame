using System;

namespace OgameData
{
    public class Building
    {
        public int Level { get; set; }
        public Resources TotalCost { get; set; }
        
        public Building()
        {
            Level = 0;
            TotalCost = new Resources();
        }
    }
}