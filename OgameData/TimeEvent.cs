using System;

namespace OgameData
{
    public class TimeEvent
    {
        public DateTime ProcessFinish { get; set; }
        public Item Item { get; set; }
        public int PlanetID { get; set; }

        public TimeEvent(Item item, int planetID, DateTime finish)
        {
            ProcessFinish = finish;
            Item = item;
            PlanetID = planetID;
        }
    }
}