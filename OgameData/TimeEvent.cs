using System;

namespace OgameData
{
    public class TimeEvent
    {
        public DateTime ProcessStart { get; set; }
        public DateTime ProcessFinish { get; set; }
        public Item Item { get; set; }
        public int PlanetID { get; set; }
        public double UnitCount { get; set; }

        public TimeEvent(Item item, int planetID, DateTime start, DateTime finish, double unitCount = 0)
        {
            ProcessStart = start;
            ProcessFinish = finish;
            Item = item;
            PlanetID = planetID;
            UnitCount = unitCount;
        }
    }
}