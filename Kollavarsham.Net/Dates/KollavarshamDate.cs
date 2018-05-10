namespace Kollavarsham.Net.Dates
{
    public class KollavarshamDate : BaseDate
    {
        public KollavarshamDate(int year = 0, int month = 0, int day = 0) :
            base(year, month, day)
        {
        }
    
        public MalayalaNaksatra MalayalaNaksatra => (MalayalaNaksatra) Naksatra;

        public MalayalaMasa MalayalaMasa => (MalayalaMasa) Month;
    }
}