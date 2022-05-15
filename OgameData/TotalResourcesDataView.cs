namespace OgameData
{
    public class TotalResourcesDataView
    {
        public int[] MinesLevel { get; set; }
        public int[] StorageLevel { get; set; }
        public Resources Mines { get; set; }
        public Resources Plasma { get; set; }
        public Resources Crawlers { get; set; }
        public Resources Basic { get; set; }
        public double DeuteriumFRC { get; set; }
        public TotalResourcesDataView()
        {
            MinesLevel = new int[3] { 0, 0, 0 };
            StorageLevel = new int[3] { 0, 0, 0 };
            Mines = new();
            Plasma = new();
            Crawlers = new();
            Basic = new();
            DeuteriumFRC = 0.0;
        }
    }
}
