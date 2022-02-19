using System;

namespace OgameData
{
    public class Research
    {
        public int Level { get; set; }
        public Resources TotalCost { get; set; }
        public bool IsProcessing { get; set; }

        public Research()
        {
            Level = 0;
            TotalCost = new Resources();
            IsProcessing = false;
        }
    }
}
