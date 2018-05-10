namespace Kollavarsham.Net.PlanetarySystem
{
    public class PlanetarySystem
    {
        public System System { get; }

        public Yuga Yuga { get; } = new Yuga();

        public Planets.Planets Planets { get; } = new Planets.Planets();

        public PlanetarySystem(System system = System.SuryaSiddhanta)
        {
            System = system == System.Pancasiddhantika ? system : System.SuryaSiddhanta;

            Planets.InitializeYugaRotations(System);
            
            Yuga.InitializeYuga(Planets);
        }

    }
}