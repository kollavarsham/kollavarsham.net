using System;
using Kollavarsham.Net.PlanetarySystem;
using Kollavarsham.Net.PlanetarySystem.Planets;

namespace Kollavarsham.Net
{
    public class Celestial
    {
        private Planets Planets { get; }
        private Yuga Yuga { get; }

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

        public static double GetTithi(double trueSolarLongitude, double trueLunarLongitude)
        {
            var eclipticLongitude = trueLunarLongitude - trueSolarLongitude;
            eclipticLongitude = MathHelper.Zero360(eclipticLongitude);

            return eclipticLongitude / 12;
        }

        public double GetMeanLongitude(double ahargana, int rotation)
        {
            // https://en.wikipedia.org/wiki/Mean_longitude
            // https://en.wikipedia.org/wiki/Ecliptic_coordinate_system#Spherical_coordinates
            return 360 * MathHelper.Fractional(rotation * ahargana / Yuga.CivilDays);
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

        public double GetConjunction(double ahargana)
        {
            var leftX = ahargana - 2;
            var leftY = GetEclipticLongitude(leftX);
            var rightX = ahargana + 2;
            var rightY = GetEclipticLongitude(rightX);
            return FindConjunction(leftX, leftY, rightX, rightY);
        }

        private double FindConjunction(double leftX, double leftY, double rightX, double rightY)
        {
            var width = (rightX - leftX) / 2;
            var centreX = (rightX + leftX) / 2;
            if (width < MathHelper.Epsilon)
            {
                return GetTrueSolarLongitude(centreX);
            }
            else
            {
                var centreY = GetEclipticLongitude(centreX);
                var relation = ThreeRelation(leftY, centreY, rightY);
                if (relation < 0)
                {
                    rightX += width;
                    rightY = GetEclipticLongitude(rightX);
                    return FindConjunction(centreX, centreY, rightX, rightY);
                }
                else if (relation > 0)
                {
                    leftX -= width;
                    leftY = GetEclipticLongitude(leftX);
                    return FindConjunction(leftX, leftY, centreX, centreY);
                }
                else
                {
                    leftX += width / 2;
                    leftY = GetEclipticLongitude(leftX);
                    rightX -= width / 2;
                    rightY = GetEclipticLongitude(rightX);
                    return FindConjunction(leftX, leftY, rightX, rightY);
                }
            }
        }
    }
}