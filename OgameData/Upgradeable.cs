using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameData
{
    public class Upgradeable
    {
        public int Level { get; set; }
        public Resources TotalCost { get; set; }

        public Upgradeable()
        {
            Level = 0;
            TotalCost = new Resources();
        }
    }
}
