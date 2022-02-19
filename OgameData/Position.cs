namespace OgameData
{
    public class Position
    {
        public int Galaxy { get; set; }
        public int SolarSystem { get; set; }
        public int PlanetNumber { get; set; }

        public Position(int[] position)
        {
            Galaxy = position[0];
            SolarSystem = position[1];
            PlanetNumber = position[2];

            OGame.Positions.Add(this);
        }
        public Position()
        {

        }

        public override string ToString()
        {
            return $"[{Galaxy + 1}:{SolarSystem + 1}:{PlanetNumber + 1}]";
        }
    }
}
