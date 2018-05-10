namespace Kollavarsham.Net.PlanetarySystem
{
    public class Yuga
    {
        public long CivilDays { get; set; }
        public int SynodicMonth { get; set; }
        public int Adhimasa { get; set; }
        public int Tithi { get; set; }
        public long Ksayadina { get; set; }

        public void InitializeYuga(Planets.Planets planets)
        {
            var sunYugaRotation = planets.Sun.YugaRotation;

            CivilDays = planets.Star.YugaRotation - sunYugaRotation;
            SynodicMonth = planets.Moon.YugaRotation - sunYugaRotation;

            Adhimasa = SynodicMonth - 12 * sunYugaRotation;

            Tithi = 30 * SynodicMonth;
            Ksayadina = Tithi - CivilDays;
        }
    }
    
}