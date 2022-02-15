namespace OgameData
{
    public class Fields
    {
        public int Available { get; set; }
        public int Demand { get; set; }
        public int Over { get; set; }
        
        public Fields(int diameter, int terraformer)
        {
            Available = GameHandler.PlanetFields(diameter, terraformer);
            Demand = 0;
            Over = Available;
        }

    }
}
