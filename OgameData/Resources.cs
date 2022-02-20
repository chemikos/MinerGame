namespace OgameData
{
    public class Resources
    {
        public double Metal { get; set; }
        public double Crystal { get; set; }
        public double Deuterium { get; set; }
        
        public Resources(double metal = 0.0, double crystal = 0.0, double deuterium = 0.0)
        {
            Metal = metal;
            Crystal = crystal;
            Deuterium = deuterium;
        }
        
        public void Add(Resources second)
        {
            Metal += second.Metal;
            Crystal += second.Crystal;
            Deuterium += second.Deuterium;
        }

        public void Subtract(Resources second)
        {
            Metal -= second.Metal;
            Crystal -= second.Crystal;
            Deuterium -= second.Deuterium;
        }

        public void Multiply(double factor)
        {
            Metal *= factor;
            Crystal *= factor;
            Deuterium *= factor;
        }
    }
}
