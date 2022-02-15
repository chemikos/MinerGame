namespace OgameData
{
    public class Resources
    {
        public double Metal { get; set; }
        public double Crystal { get; set; }
        public double Deuterium { get; set; }
        public double Total { get; set; }
        
        public Resources(double metal = 0.0, double crystal = 0.0, double deuterium = 0.0)
        {
            Metal = metal;
            Crystal = crystal;
            Deuterium = deuterium;
            Total = Metal + Crystal + Deuterium;
        }
        
        public void Add(Resources second)
        {
            Metal += second.Metal;
            Crystal += second.Crystal;
            Deuterium += second.Deuterium;
            Total = Metal + Crystal + Deuterium;
        }
        public void Reset()
        {
            Metal = 0.0;
            Crystal = 0.0;
            Deuterium = 0.0;
            Total = 0.0;
        }
    }
}
