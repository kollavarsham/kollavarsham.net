using System;
using Kollavarsham.Net.Dates;

namespace Kollavarsham.Net
{
    public class Calendar
    {
        private readonly Celestial _celestial;
        private int _samkrantiYear;
        private int _samkrantiMonth;
        private int _samkrantiDay;
        private int _samkrantiHour;
        private int _samkrantiMin;

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

            if (month < 3)
            {
                year -= 1;
                month += 12;
            }

            var julianDay = MathHelper.Truncate(365.25 * year) +
                            MathHelper.Truncate(30.59 * (month - 2)) +
                            day +
                            1721086.5;

            if (year < 0)
            {
                julianDay -= 1;
                if (year % 4 == 0 && month > 3)
                {
                    julianDay += 1;
                }
            }

            if (julianDay >= 2299160)
            {
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
            return MathHelper.Truncate(ahargana * _celestial.Planets[Planet.Sun].YugaRotation /
                                       _celestial.Yuga.CivilDays);
        }

        public static Naksatra GetNaksatra(double trueLunarLongitude)
        {
            var naksatra = MathHelper.Truncate(trueLunarLongitude * 27 / 360);

            return new Naksatra(naksatra);
        }

        public double FindSamkranti(double leftAhargana, double rightAhargana)
        {
            var width = (rightAhargana - leftAhargana) / 2;
            var centreAhargana = (rightAhargana + leftAhargana) / 2;

            if (width < MathHelper.Epsilon)
            {
                return centreAhargana;
            }

            var centreTslong = _celestial.GetTrueSolarLongitude(centreAhargana);
            centreTslong -= MathHelper.Truncate(centreTslong / 30) * 30;

            return centreTslong < 5
                ? FindSamkranti(leftAhargana, centreAhargana)
                : FindSamkranti(centreAhargana, rightAhargana);
        }

        public SauraDate GetSauraMasaAndSauraDivasa(double ahargana, int desantara)
        {
            // If today is the first day then 1
            // Otherwise yesterday's + 1
            int month;
            int day;
            ahargana = MathHelper.Truncate(ahargana);
            if (IsTodaySauraMasaFirst(ahargana, desantara))
            {
                day = 1;
                var tsLongTomorrow = _celestial.GetTrueSolarLongitude(ahargana + 1);
                month = MathHelper.Truncate(tsLongTomorrow / 30) % 12;
                month = (month + 12) % 12;
            }
            else
            {
                var sauraDate = GetSauraMasaAndSauraDivasa(ahargana - 1, desantara);
                month = sauraDate.SauraMasa;
                day = sauraDate.SauraDivasa + 1;
            }

            return new SauraDate {SauraMasa = month, SauraDivasa = day};
        }

        private bool IsTodaySauraMasaFirst(double ahargana, int desantara)
        {
            /*
             //    Definition of the first day
             //    samkranti is between today's 0:00 and 24:00
             //    ==
             //    at 0:00 before 30x, at 24:00 after 30x
             */
            var trueSolarLongitudeToday = _celestial.GetTrueSolarLongitude(ahargana - desantara);
            var trueSolarLongitudeTomorrow = _celestial.GetTrueSolarLongitude(ahargana - desantara + 1);

            trueSolarLongitudeToday -= MathHelper.Truncate(trueSolarLongitudeToday / 30) * 30;
            trueSolarLongitudeTomorrow -= MathHelper.Truncate(trueSolarLongitudeTomorrow / 30) * 30;

            if (25 < trueSolarLongitudeToday && trueSolarLongitudeTomorrow < 5)
            {
                CalculateSamkranti(ahargana, desantara);
                return true;
            }

            return false;
        }

        private void CalculateSamkranti(double ahargana, int desantara)
        {
            var samkrantiAhargana = FindSamkranti(ahargana, ahargana + 1) + desantara;
            // below line is the fix that Yano-san worked in for Kerala dates - #20140223 cf. try_calculations
            var roundedSamkranti = MathHelper.Truncate(samkrantiAhargana) + 0.5;
            var samkrantiModernDate = JulianDayToModernDate(AharganaToJulianDay(roundedSamkranti));

            if (samkrantiModernDate is JulianDate date1)
            {
                _samkrantiYear = date1.Year;
                _samkrantiMonth = date1.Month;
                _samkrantiDay = date1.Day;
            }
            else if (samkrantiModernDate is DateTime date)
            {
                _samkrantiYear = date.Year;
                _samkrantiMonth = date.Month;
                _samkrantiDay = date.Day;
            }

            var fractionalDay = MathHelper.Fractional(samkrantiAhargana) * 24;
            _samkrantiHour = MathHelper.Truncate(fractionalDay);
            _samkrantiMin = MathHelper.Truncate(60 * MathHelper.Fractional(fractionalDay));
        }

        private static object JulianDayToModernDate(double julianDay)
        {
            // Will return JulianDate object for any date before 1st January 1583 AD and Date objects for later dates
            return julianDay < 2299239
                ? (object) JulianDayToJulianDate(julianDay)
                : JulianDayToGregorianDate(julianDay);
        }

        private static DateTime JulianDayToGregorianDate(double julianDay)
        {
            var a = julianDay + 68569;
            var b = MathHelper.Truncate(a / 36524.25);
            var c = a - MathHelper.Truncate(36524.25 * b + 0.75);
            var e = MathHelper.Truncate((c + 1) / 365.2425);
            var f = c - MathHelper.Truncate(365.25 * e) + 31;
            var g = MathHelper.Truncate(f / 30.59);
            var h = MathHelper.Truncate((double) g / 11);

            var day = MathHelper.Truncate(f - MathHelper.Truncate(30.59 * g) +
                                          (julianDay - MathHelper.Truncate(julianDay)));
            var month = MathHelper.Truncate(g - 12 * h + 2);
            var year = MathHelper.Truncate(100 * (b - 49) + e + h);

            return new DateTime(year, month - 1, day);
        }

        private static JulianDate JulianDayToJulianDate(double julianDay)
        {
            var j = MathHelper.Truncate(julianDay) + 1402;
            var k = MathHelper.Truncate((double) (j - 1) / 1461);
            var l = j - 1461 * k;
            var n = MathHelper.Truncate((double) (l - 1) / 365) - MathHelper.Truncate((double) l / 1461);
            var i = l - 365 * n + 30;
            var J = MathHelper.Truncate((double) 80 * i / 2447);
            var I = MathHelper.Truncate((double) J / 11);

            var day = i - MathHelper.Truncate((double) 2447 * J / 80);
            var month = J + 2 - 12 * I;
            var year = 4 * k + n + I - 4716;

            return new JulianDate(year, month, day);
        }

        private static double AharganaToJulianDay(double ahargana)
        {
            return 588465.50 + ahargana;
        }

        public static int GetMasaNum(double trueSolarLongitude, double lastConjunctionLongitude)
        {
            var masaNum = MathHelper.Truncate(trueSolarLongitude / 30) % 12;
            if (masaNum == MathHelper.Truncate(lastConjunctionLongitude / 30) % 12)
            {
                masaNum += 1;
            }

            masaNum = (masaNum + 12) % 12;
            return masaNum;
        }
    }
}