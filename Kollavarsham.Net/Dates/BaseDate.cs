using System;

namespace Kollavarsham.Net.Dates
{
    public abstract class BaseDate
    {
        public int Year { get; }
        public int Month { get; }
        public int Day { get; }

        protected BaseDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public DateTime GregorianDate { get; set; } = DateTime.MinValue;

        public int JulianDay { get; set; }

        public int Ahargana { get; set; }
        public int SauraMasa { get; set; }
        public int SauraDivasa { get; set; }

        public SakaNaksatra Naksatra { get; set; }

        public SakaMasa SakaMasa => (SakaMasa) Month;
    }
}