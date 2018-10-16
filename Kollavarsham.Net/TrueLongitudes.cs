namespace Kollavarsham.Net
{
    public class TrueLongitudes
    {
        public double TrueSolarLongitude { get; }
        public double TrueLunarLongitude { get; }

        public TrueLongitudes(double trueSolarLongitude, double trueLunarLongitude)
        {
            TrueSolarLongitude = trueSolarLongitude;
            TrueLunarLongitude = trueLunarLongitude;
        }
    }
}