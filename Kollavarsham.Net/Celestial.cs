using System;
using Kollavarsham.Net.PlanetarySystem;
using Kollavarsham.Net.PlanetarySystem.Planets;

namespace Kollavarsham.Net
{
    public class Celestial
    {
        private Planets Planets { get; }
        private Yuga Yuga { get; }

        private double BackLastConjunctionAhargana { get; set; } = -1;
        private double BackNextConjunctionAhargana { get; set; } = -1;
        private double BackLastConjunctionLongitude { get; set; } = -1;
        private double BackNextConjunctionLongitude { get; set; } = -1;

        public Celestial(System system = System.SuryaSiddhanta)
        {
            var planetarySystem = new PlanetarySystem.PlanetarySystem(system);
            Planets = planetarySystem.Planets;
            Yuga = planetarySystem.Yuga;
        }

        public static int ThreeRelation(double left, double center, double right)
        {
            if (left < center && center < right)
            {
                return 1;
            }

            if (right < center && center < left)
            {
                return -1;
            }

            return 0;
        }

        public static double Declination(double longitude)
        {
            // https://en.wikipedia.org/wiki/Declination
            return Math.Asin(Math.Sin(longitude / MathHelper.RadianInDegrees) *
                             Math.Sin(24 / MathHelper.RadianInDegrees)) *
                   MathHelper.RadianInDegrees;
        }

        public static SunriseTime GetSunriseTime(double time, double equationOfTime)
        {
            var sunriseTime = (time - equationOfTime) * 24;
            var sunriseHour = MathHelper.Truncate(sunriseTime);
            var sunriseMinute = MathHelper.Truncate(60 * MathHelper.Fractional(sunriseTime));

            return new SunriseTime {Hour = sunriseHour, Minute = sunriseMinute};
        }

        public static double GetTithi(double trueSolarLongitude, double trueLunarLongitude)
        {
            var eclipticLongitude = trueLunarLongitude - trueSolarLongitude;
            eclipticLongitude = MathHelper.Zero360(eclipticLongitude);

            return eclipticLongitude / 12;
        }

        public TrueLongitudes SetPlanetaryPositions(double ahargana)
        {
            // Lunar apogee and node at sunrise
            Planets[Planet.Candrocca].MeanPosition =
                MathHelper.Zero360(GetMeanLongitude(ahargana, Planets[Planet.Candrocca].YugaRotation) + 90);
            Planets[Planet.Rahu].MeanPosition =
                MathHelper.Zero360(GetMeanLongitude(ahargana, Planets[Planet.Rahu].YugaRotation) + 180);

            // mean and true sun at sunrise
            var meanSolarLongitude = GetMeanLongitude(ahargana, Planets[Planet.Sun].YugaRotation);
            Planets[Planet.Sun].MeanPosition = meanSolarLongitude;

            var trueSolarLongitude = MathHelper.Zero360(meanSolarLongitude -
                                                        GetMandaEquation(
                                                            meanSolarLongitude - Planets[Planet.Sun].Apogee,
                                                            Planet.Sun));

            // mean and true moon at sunrise
            var meanLunarLongitude = GetMeanLongitude(ahargana, Planets[Planet.Moon].YugaRotation);
            Planets[Planet.Moon].MeanPosition = meanLunarLongitude;

            Planets[Planet.Moon].Apogee = Planets[Planet.Candrocca].MeanPosition;

            var trueLunarLongitude = MathHelper.Zero360(meanLunarLongitude -
                                                        GetMandaEquation(
                                                            meanLunarLongitude - Planets[Planet.Moon].Apogee,
                                                            Planet.Moon));

            // The below was a separate method named calculations.planetary (ported from planetary_calculations in perl)
            var planetNames = new[] {Planet.Mercury, Planet.Venus, Planet.Mars, Planet.Jupiter, Planet.Saturn};
            foreach (var planetName in planetNames)
            {
                Planets[planetName].MeanPosition = GetMeanLongitude(ahargana, Planets[planetName].Rotation);
            }

            return new TrueLongitudes(trueSolarLongitude, trueLunarLongitude);
        }

        public double GetMeanLongitude(double ahargana, int rotation)
        {
            // https://en.wikipedia.org/wiki/Mean_longitude
            // https://en.wikipedia.org/wiki/Ecliptic_coordinate_system#Spherical_coordinates
            return 360 * MathHelper.Fractional(rotation * ahargana / Yuga.CivilDays);
        }

        public double GetDaylightEquation(int year, double latitude, double ahargana)
        {
            // Good read - http://en.wikipedia.org/wiki/Equation_of_time#Calculating_the_equation_of_time
            var meanSolarLongitude = GetMeanLongitude(ahargana, Planets[Planet.Sun].YugaRotation);

            // Sayana Solar Longitude and Declination
            var sayanaMeanSolarLongitude = meanSolarLongitude + 54.0 / 3600 * (year - 499);
            var sayanaDeclination = Declination(sayanaMeanSolarLongitude); // See Sewell, p.10

            // Equation of day light by Analemma (https://en.wikipedia.org/wiki/Analemma)
            var x = Math.Tan(latitude / MathHelper.RadianInDegrees) *
                    Math.Tan(sayanaDeclination / MathHelper.RadianInDegrees);

            return 0.5 * Math.Asin(x) / Math.PI;
        }

        public double GetMandaEquation(double argument, Planet planet)
        {
            return Math.Asin(Planets[planet].MandaCircumference / 360 *
                             Math.Sin(argument / MathHelper.RadianInDegrees)) *
                   MathHelper.RadianInDegrees;
        }

        public double GetTrueLunarLongitude(double ahargana)
        {
            var meanLunarLongitude = GetMeanLongitude(ahargana, Planets[Planet.Moon].YugaRotation);
            var apogee = GetMeanLongitude(ahargana, Planets[Planet.Candrocca].YugaRotation) + 90;
            return MathHelper.Zero360(meanLunarLongitude - GetMandaEquation(meanLunarLongitude - apogee, Planet.Moon));
        }

        public double GetTrueSolarLongitude(double ahargana)
        {
            var meanSolarLongitude = GetMeanLongitude(ahargana, Planets[Planet.Sun].YugaRotation);
            return MathHelper.Zero360(meanSolarLongitude -
                                      GetMandaEquation(meanSolarLongitude - Planets[Planet.Sun].Apogee, Planet.Sun));
        }

        public double GetEclipticLongitude(double ahargana)
        {
            var eclipticLongitude = Math.Abs(GetTrueLunarLongitude(ahargana) - GetTrueSolarLongitude(ahargana));
            if (eclipticLongitude >= 180)
            {
                eclipticLongitude = 360 - eclipticLongitude;
            }

            return eclipticLongitude;
        }

        private double FindConjunction(double leftX, double leftY, double rightX, double rightY)
        {
            var width = (rightX - leftX) / 2;
            var centreX = (rightX + leftX) / 2;
            if (width < MathHelper.Epsilon)
            {
                return GetTrueSolarLongitude(centreX);
            }

            var centreY = GetEclipticLongitude(centreX);
            var relation = ThreeRelation(leftY, centreY, rightY);
            if (relation < 0)
            {
                rightX += width;
                rightY = GetEclipticLongitude(rightX);
                return FindConjunction(centreX, centreY, rightX, rightY);
            }

            if (relation > 0)
            {
                leftX -= width;
                leftY = GetEclipticLongitude(leftX);
                return FindConjunction(leftX, leftY, centreX, centreY);
            }

            leftX += width / 2;
            leftY = GetEclipticLongitude(leftX);
            rightX -= width / 2;
            rightY = GetEclipticLongitude(rightX);
            return FindConjunction(leftX, leftY, rightX, rightY);
        }

        public double GetConjunction(double ahargana)
        {
            var leftX = ahargana - 2;
            var leftY = GetEclipticLongitude(leftX);
            var rightX = ahargana + 2;
            var rightY = GetEclipticLongitude(rightX);
            return FindConjunction(leftX, leftY, rightX, rightY);
        }

        public double GetLastConjunctionLongitude(double ahargana, double tithi)
        {
            var newNew = (double) Yuga.CivilDays / (Planets[Planet.Moon].YugaRotation - Planets[Planet.Sun].YugaRotation);
            ahargana -= tithi * (newNew / 30);

            if (Math.Abs(ahargana - BackLastConjunctionAhargana) < 1)
            {
                return BackLastConjunctionLongitude;
            }

            if (Math.Abs(ahargana - BackNextConjunctionAhargana) < 1)
            {
                BackLastConjunctionAhargana = BackNextConjunctionAhargana;
                BackLastConjunctionLongitude = BackNextConjunctionLongitude;
                return BackNextConjunctionLongitude;
            }

            BackLastConjunctionAhargana = ahargana;
            BackLastConjunctionLongitude = GetConjunction(ahargana);
            return BackLastConjunctionLongitude;
        }

        public double GetNextConjunctionLongitude(double ahargana, double tithi)
        {
            var newNew = (double) Yuga.CivilDays / (Planets[Planet.Moon].YugaRotation - Planets[Planet.Sun].YugaRotation);
            ahargana += (30 - tithi) * (newNew / 30);

            if (Math.Abs(ahargana - BackNextConjunctionAhargana) < 1)
            {
                return BackNextConjunctionLongitude;
            }

            BackNextConjunctionAhargana = ahargana;
            BackNextConjunctionLongitude = GetConjunction(ahargana);
            return BackNextConjunctionLongitude;
        }
    }
}