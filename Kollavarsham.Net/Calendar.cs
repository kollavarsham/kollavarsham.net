using System;
using System.Collections.Generic;

namespace Kollavarsham.Net
{
    public class Calendar
    {
        private readonly Celestial _celestial;

        public Calendar(Celestial celestial)
        {
            _celestial = celestial;
        }

        public static double GregorianDateToJulianDay(DateTime date)
        {
            //  TODO:
            // Annotate all the magic numbers below !
            // There is some explanation here - http://quasar.as.utexas.edu/BillInfo/JulianDatesG.html

            var year = date.Year;
            var month = date.Month;
            var day = date.Day;

            if (month < 3) {
                year -= 1;
                month += 12;
            }

            var julianDay = MathHelper.Truncate(365.25 * year) + MathHelper.Truncate(30.59 * (month - 2)) + day + 1721086.5;

            if (year < 0) {
                julianDay -= 1;
                if (year % 4 == 0 && month > 3) {
                    julianDay += 1;
                }
            }

            if (julianDay >= 2299160) {
                julianDay += MathHelper.Truncate((double) year / 400) - MathHelper.Truncate(year / 100) + 2;
            }

            return julianDay;
        }

        public static double TimeIntoFractionalDay(DateTime date)
        {
            return (double) (date.Hour * 60 + date.Minute) / (24 * 60);
        }

        public static int KaliToSaka(int kaliYear)
        {
            return kaliYear - 3179;
        }

        public int AharganaToKali(double ahargana)
        {
            return MathHelper.Truncate(ahargana * _celestial.Planets[Planet.Sun].YugaRotation / _celestial.Yuga.CivilDays);
        }

        public static Naksatra GetNaksatra(double trueLunarLongitude)
        {
            var naksatra = MathHelper.Truncate(trueLunarLongitude * 27 / 360);
            
            return new Naksatra(naksatra);
        }
    }

}