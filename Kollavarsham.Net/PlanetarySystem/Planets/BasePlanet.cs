namespace Kollavarsham.Net.PlanetarySystem.Planets
{
    public abstract class BasePlanet
    {
        protected BasePlanet(Planet type)
        {
            Type = type;
        }

        protected virtual Planet Type { get; }

        public int YugaRotation { get; set; }
        public int Rotation { get; set; }
        public int Sighra { get; set; }
        public int MeanPosition { get; set; }
        public double Apogee { get; set; }
        public double MandaCircumference { get; set; }
        public double SighraCircumference { get; set; }
    }
}