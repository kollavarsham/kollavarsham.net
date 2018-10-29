using System;
using FluentAssertions;
using Xunit;

namespace Kollavarsham.Net.Tests
{
    public class CalendarTests
    {
        private readonly Calendar _calendar;

        public CalendarTests()
        {
            _calendar = new Calendar(new Celestial());
        }

        [Fact]
        public void GregorianDateToJulianDay_Should_Return_Correct_Results()
        {
            Calendar.GregorianDateToJulianDay(new DateTime(2014, (int) Month.February, 16)).Should().Be(2456704.5);
            Calendar.GregorianDateToJulianDay(new DateTime(2013, (int) Month.December, 30)).Should().Be(2456656.5);
            Calendar.GregorianDateToJulianDay(new DateTime(2013, (int) Month.December, 31)).Should().Be(2456657.5);
            Calendar.GregorianDateToJulianDay(new DateTime(2012, (int) Month.January, 31)).Should().Be(2455957.5);
            Calendar.GregorianDateToJulianDay(new DateTime(2013, (int) Month.February, 28)).Should().Be(2456351.5);
            Calendar.GregorianDateToJulianDay(new DateTime(2012, (int) Month.February, 28)).Should().Be(2455985.5);
            Calendar.GregorianDateToJulianDay(new DateTime(2001, (int) Month.January, 1)).Should().Be(2451910.5);
            Calendar.GregorianDateToJulianDay(new DateTime(1950, (int) Month.February, 1)).Should().Be(2433313.5);
            Calendar.GregorianDateToJulianDay(new DateTime(1997, (int) Month.September, 30)).Should().Be(2450721.5);
            Calendar.GregorianDateToJulianDay(new DateTime(1752, (int) Month.March, 24)).Should().Be(2361047.5);
            Calendar.GregorianDateToJulianDay(new DateTime(1752, (int) Month.September, 2)).Should().Be(2361209.5);
            Calendar.GregorianDateToJulianDay(new DateTime(1997, (int) Month.December, 30)).Should().Be(2450812.5);
            /* no going earlier than AD in .NET!
            Calendar.GregorianDateToJulianDay(new DateTime(-1, (int) Month.January, 31)).Should().Be(1720722.5);
            Calendar.GregorianDateToJulianDay(new DateTime(-4, (int) Month.October, 31)).Should().Be(1719900.5);
            */
        }

        [Fact]
        public void GetMasaNum_Should_Return_Correct_Results()
        {
            Calendar.GetMasaNum(31.3101877453024, 190.002232417937).Should().Be(1);
            Calendar.GetMasaNum(42.2597957259723, 209.07961889886).Should().Be(1);
            Calendar.GetMasaNum(59.2349729472294, 183.469749507872).Should().Be(1);
            Calendar.GetMasaNum(62.5975972349908, 208.58681756282).Should().Be(2);
            Calendar.GetMasaNum(80.4818781723799, 180.203508055438).Should().Be(2);
            Calendar.GetMasaNum(121.1497130809087, 208.340416894636).Should().Be(4);
            Calendar.GetMasaNum(320.8687779979979, 195.735990965544).Should().Be(10);
            Calendar.GetMasaNum(131.3101877453024, 10.002232417937).Should().Be(4);
            Calendar.GetMasaNum(242.2597957259723, 9.07961889886).Should().Be(8);
            Calendar.GetMasaNum(359.2349729472294, 83.469749507872).Should().Be(11);
            Calendar.GetMasaNum(62.5975972349908, 108.58681756282).Should().Be(2);
            Calendar.GetMasaNum(142.8812491322719, 142.8812491322719).Should().Be(5);
            Calendar.GetMasaNum(280.4818781723799, 180.203508055438).Should().Be(9);
            Calendar.GetMasaNum(21.1497130809087, 108.340416894636).Should().Be(0);
            Calendar.GetMasaNum(20.8687779979979, 286.735990965544).Should().Be(0);
        }

        [Fact]
        public void GetSauraMasaAndSauraDivasa_Should_Return_Correct_Results()
        {
            _calendar.GetSauraMasaAndSauraDivasa(2299158.5, 0).SauraMasa.Should().Be(7);
            _calendar.GetSauraMasaAndSauraDivasa(2299159.5, 0).SauraMasa.Should().Be(7);
            _calendar.GetSauraMasaAndSauraDivasa(2299160.5, 0).SauraMasa.Should().Be(7);
            _calendar.GetSauraMasaAndSauraDivasa(2299161.5, 0).SauraMasa.Should().Be(7);
            _calendar.GetSauraMasaAndSauraDivasa(2361220.5, 0).SauraMasa.Should().Be(6);
            _calendar.GetSauraMasaAndSauraDivasa(2361221.5, 0).SauraMasa.Should().Be(6);
            _calendar.GetSauraMasaAndSauraDivasa(2361222.5, 0).SauraMasa.Should().Be(6);
            _calendar.GetSauraMasaAndSauraDivasa(1721457.5, 0).SauraMasa.Should().Be(11);
            _calendar.GetSauraMasaAndSauraDivasa(2456656.5, 0).SauraMasa.Should().Be(9);
            _calendar.GetSauraMasaAndSauraDivasa(2456657.5, 0).SauraMasa.Should().Be(9);
            _calendar.GetSauraMasaAndSauraDivasa(2455957.5, 0).SauraMasa.Should().Be(10);
            _calendar.GetSauraMasaAndSauraDivasa(2456351.5, 0).SauraMasa.Should().Be(11);
            _calendar.GetSauraMasaAndSauraDivasa(2455985.5, 0).SauraMasa.Should().Be(11);
            _calendar.GetSauraMasaAndSauraDivasa(2433313.5, 0).SauraMasa.Should().Be(10);
            _calendar.GetSauraMasaAndSauraDivasa(2299158.5, 0).SauraDivasa.Should().Be(6);
            _calendar.GetSauraMasaAndSauraDivasa(2299159.5, 0).SauraDivasa.Should().Be(7);
            _calendar.GetSauraMasaAndSauraDivasa(2299160.5, 0).SauraDivasa.Should().Be(8);
            _calendar.GetSauraMasaAndSauraDivasa(2299161.5, 0).SauraDivasa.Should().Be(9);
            _calendar.GetSauraMasaAndSauraDivasa(2361220.5, 0).SauraDivasa.Should().Be(4);
            _calendar.GetSauraMasaAndSauraDivasa(2361221.5, 0).SauraDivasa.Should().Be(5);
            _calendar.GetSauraMasaAndSauraDivasa(2361222.5, 0).SauraDivasa.Should().Be(6);
            _calendar.GetSauraMasaAndSauraDivasa(1721457.5, 0).SauraDivasa.Should().Be(27);
            _calendar.GetSauraMasaAndSauraDivasa(2456656.5, 0).SauraDivasa.Should().Be(19);
            _calendar.GetSauraMasaAndSauraDivasa(2456657.5, 0).SauraDivasa.Should().Be(20);
            _calendar.GetSauraMasaAndSauraDivasa(2455957.5, 0).SauraDivasa.Should().Be(21);
            _calendar.GetSauraMasaAndSauraDivasa(2456351.5, 0).SauraDivasa.Should().Be(20);
            _calendar.GetSauraMasaAndSauraDivasa(2455985.5, 0).SauraDivasa.Should().Be(19);
            _calendar.GetSauraMasaAndSauraDivasa(2433313.5, 0).SauraDivasa.Should().Be(23);
            _calendar.GetSauraMasaAndSauraDivasa(2313.5, 0).SauraDivasa.Should().Be(31);
        }

        [Fact]
        public void FindSamkranti_Should_Return_Correct_Results()
        {
            _calendar.FindSamkranti(1868206, 1868207).Should().BeCloseTo(1868206.71761142, MathHelper.Epsilon);
            _calendar.FindSamkranti(1868236, 1868237).Should().BeCloseTo(1868236.15636098, MathHelper.Epsilon);
            _calendar.FindSamkranti(1868266, 1868267).Should().BeCloseTo(1868266.00000001, MathHelper.Epsilon);
            _calendar.FindSamkranti(1721431, 1721432).Should().BeCloseTo(1721431.9425787, MathHelper.Epsilon);
            _calendar.FindSamkranti(2299153, 2299154).Should().BeCloseTo(2299153.23922039, MathHelper.Epsilon);
        }

        [Fact]
        public void GetNaksatra_Should_Return_Correct_Results()
        {
            Calendar.GetNaksatra(167.084587116821).Saka.Should().Be("Hasta");
            Calendar.GetNaksatra(179.618866280373).Saka.Should().Be("Citra");
            Calendar.GetNaksatra(191.953219840454).Saka.Should().Be("Svati");
            Calendar.GetNaksatra(204.131519861513).Saka.Should().Be("Visakha");
            Calendar.GetNaksatra(349.195739637822).Saka.Should().Be("Revati");
            Calendar.GetNaksatra(1.82309136307406).Saka.Should().Be("Asvini");
            Calendar.GetNaksatra(14.6945040053245).Saka.Should().Be("Bharani");
            Calendar.GetNaksatra(6.55724149356419).Saka.Should().Be("Asvini");
            Calendar.GetNaksatra(16.24829446685).Saka.Should().Be("Bharani");
            Calendar.GetNaksatra(29.8253740270552).Saka.Should().Be("Krttika");
            Calendar.GetNaksatra(156.709071062542).Saka.Should().Be("UPhalguni");
            Calendar.GetNaksatra(316.081404838166).Saka.Should().Be("Satabhisaj");
            Calendar.GetNaksatra(165.854323537076).Saka.Should().Be("Hasta");
            Calendar.GetNaksatra(236.806759936797).Saka.Should().Be("Jyestha");
            Calendar.GetNaksatra(167.084587116821).EnNaksatra.Should().Be("Atham");
            Calendar.GetNaksatra(179.618866280373).EnNaksatra.Should().Be("Chithra");
            Calendar.GetNaksatra(191.953219840454).EnNaksatra.Should().Be("Chothi");
            Calendar.GetNaksatra(204.131519861513).EnNaksatra.Should().Be("Vishakham");
            Calendar.GetNaksatra(349.195739637822).EnNaksatra.Should().Be("Revathi");
            Calendar.GetNaksatra(1.82309136307406).EnNaksatra.Should().Be("Ashwathi");
            Calendar.GetNaksatra(14.6945040053245).EnNaksatra.Should().Be("Bharani");
            Calendar.GetNaksatra(6.55724149356419).EnNaksatra.Should().Be("Ashwathi");
            Calendar.GetNaksatra(16.24829446685).EnNaksatra.Should().Be("Bharani");
            Calendar.GetNaksatra(29.8253740270552).EnNaksatra.Should().Be("Karthika");
            Calendar.GetNaksatra(156.709071062542).EnNaksatra.Should().Be("Uthram");
            Calendar.GetNaksatra(316.081404838166).EnNaksatra.Should().Be("Chathayam");
            Calendar.GetNaksatra(165.854323537076).EnNaksatra.Should().Be("Atham");
            Calendar.GetNaksatra(236.806759936797).EnNaksatra.Should().Be("Thrikketta");
            Calendar.GetNaksatra(167.084587116821).MlNaksatra.Should().Be("അത്തം");
            Calendar.GetNaksatra(179.618866280373).MlNaksatra.Should().Be("ചിത്ര");
            Calendar.GetNaksatra(191.953219840454).MlNaksatra.Should().Be("ചോതി");
            Calendar.GetNaksatra(204.131519861513).MlNaksatra.Should().Be("വിശാഖം");
            Calendar.GetNaksatra(349.195739637822).MlNaksatra.Should().Be("രേവതി");
            Calendar.GetNaksatra(1.82309136307406).MlNaksatra.Should().Be("അശ്വതി");
            Calendar.GetNaksatra(14.6945040053245).MlNaksatra.Should().Be("ഭരണി");
            Calendar.GetNaksatra(6.55724149356419).MlNaksatra.Should().Be("അശ്വതി");
            Calendar.GetNaksatra(16.24829446685).MlNaksatra.Should().Be("ഭരണി");
            Calendar.GetNaksatra(29.8253740270552).MlNaksatra.Should().Be("കാർത്തിക");
            Calendar.GetNaksatra(156.709071062542).MlNaksatra.Should().Be("ഉത്രം");
            Calendar.GetNaksatra(316.081404838166).MlNaksatra.Should().Be("ചതയം");
            Calendar.GetNaksatra(165.854323537076).MlNaksatra.Should().Be("അത്തം");
            Calendar.GetNaksatra(236.806759936797).MlNaksatra.Should().Be("തൃക്കേട്ട");
        }

        [Fact]
        public void AharganaToKali_Should_Return_Correct_Results()
        {
            _calendar.AharganaToKali(1710693).Should().Be(4683);
            _calendar.AharganaToKali(1710694).Should().Be(4683);
            _calendar.AharganaToKali(1710695).Should().Be(4683);
            _calendar.AharganaToKali(1710696).Should().Be(4683);
            _calendar.AharganaToKali(1772755).Should().Be(4853);
            _calendar.AharganaToKali(1772756).Should().Be(4853);
            _calendar.AharganaToKali(1772757).Should().Be(4853);
            _calendar.AharganaToKali(1132992).Should().Be(3101);
            _calendar.AharganaToKali(1868191).Should().Be(5114);
            _calendar.AharganaToKali(1868192).Should().Be(5114);
            _calendar.AharganaToKali(1867492).Should().Be(5112);
            _calendar.AharganaToKali(1867886).Should().Be(5113);
            _calendar.AharganaToKali(1867520).Should().Be(5112);
            _calendar.AharganaToKali(1844848).Should().Be(5050);
        }

        [Fact]
        public void KaliToSaka_Should_Return_Correct_Results()
        {
            Calendar.KaliToSaka(4683).Should().Be(1504);
            Calendar.KaliToSaka(4683).Should().Be(1504);
            Calendar.KaliToSaka(4683).Should().Be(1504);
            Calendar.KaliToSaka(4683).Should().Be(1504);
            Calendar.KaliToSaka(4853).Should().Be(1674);
            Calendar.KaliToSaka(4853).Should().Be(1674);
            Calendar.KaliToSaka(4853).Should().Be(1674);
            Calendar.KaliToSaka(3101).Should().Be(-78);
            Calendar.KaliToSaka(5114).Should().Be(1935);
            Calendar.KaliToSaka(5114).Should().Be(1935);
            Calendar.KaliToSaka(5112).Should().Be(1933);
            Calendar.KaliToSaka(5113).Should().Be(1934);
            Calendar.KaliToSaka(5112).Should().Be(1933);
            Calendar.KaliToSaka(5050).Should().Be(1871);
        }

        [Fact]
        public void TimeIntoFractionalDay_Should_Return_The_Expected_Results()
        {
            var originalDate = new DateTime(1979, 4, 22, 0, 0, 1, DateTimeKind.Utc); // Tue May 22 1979 00:00:01
            var date = originalDate;
            Calendar.TimeIntoFractionalDay(date).Should().BeCloseTo(0.0, MathHelper.Epsilon);

            date = originalDate.AddHours(3).AddMinutes(30); // Tue May 22 1979 03:30:01
            // => ((3 * 60) + 30) minutes => 210 minutes
            // => 210 / 1440 => 0.14583333333333
            Calendar.TimeIntoFractionalDay(date).Should().BeCloseTo(0.14583333333333, MathHelper.Epsilon);

            date = originalDate.AddHours(6).AddMinutes(0); // Tue May 22 1979 06:00:01
            // => ((6 * 60) + 0) minutes => 360 minutes
            // => 360 / 1440 => 0.25
            Calendar.TimeIntoFractionalDay(date).Should().BeCloseTo(0.25, MathHelper.Epsilon);

            date = originalDate.AddHours(11).AddMinutes(45); // Tue May 22 1979 11:45:01
            // => ((11 * 60) + 45) minutes => 705 minutes
            // => 705 / 1440 => 0.48958333333333
            Calendar.TimeIntoFractionalDay(date).Should().BeCloseTo(0.48958333333333, MathHelper.Epsilon);

            date = originalDate.AddHours(12).AddMinutes(0); // Tue May 22 1979 12:00:01
            // => ((12 * 60) + 0) minutes => 720 minutes
            // => 720 / 1440 => 0.5
            Calendar.TimeIntoFractionalDay(date).Should().BeCloseTo(0.5, MathHelper.Epsilon);

            date = originalDate.AddHours(16).AddMinutes(25); // Tue May 22 1979 16:25:01
            // => ((16 * 60) + 25) minutes => 985 minutes
            // => 985 / 1440 => 0.68402777777778
            Calendar.TimeIntoFractionalDay(date).Should().BeCloseTo(0.68402777777778, MathHelper.Epsilon);

            date = originalDate.AddHours(18).AddMinutes(0); // Tue May 22 1979 18:00:01
            // => ((18 * 60) + 0) minutes => 1080 minutes
            // => 1080 / 1440 => 0.75
            Calendar.TimeIntoFractionalDay(date).Should().BeCloseTo(0.75, MathHelper.Epsilon);
        }
    }
}