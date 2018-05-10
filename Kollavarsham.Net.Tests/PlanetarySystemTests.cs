using FluentAssertions;
using Kollavarsham.Net.PlanetarySystem;
using Kollavarsham.Net.PlanetarySystem.Planets;
using Xunit;

namespace Kollavarsham.Net.Tests
{
    public class Empty_Constructor
    {
        private PlanetarySystem.PlanetarySystem planetarySystem;
        private readonly Planets planets;

        public Empty_Constructor()
        {
            planetarySystem = new PlanetarySystem.PlanetarySystem();
            planets = planetarySystem.Planets;
        }

        [Fact]
        public void Should_Set_the_YugaRotation_Values_Correctly()
        {
            planets.Star.YugaRotation.Should().Be(1582237800);
            planets.Sun.YugaRotation.Should().Be(4320000);
            planets.Moon.YugaRotation.Should().Be(57753336);
            planets.Mercury.YugaRotation.Should().Be(17937000);
            planets.Venus.YugaRotation.Should().Be(7022388);
            planets.Mars.YugaRotation.Should().Be(2296824);
            planets.Jupiter.YugaRotation.Should().Be(364220);
            planets.Saturn.YugaRotation.Should().Be(146564);
            planets.Candrocca.YugaRotation.Should().Be(488219);
            planets.Rahu.YugaRotation.Should().Be(-232226);
        }
    }

    public class Constructor_With_SuryaSiddanta
    {
        private PlanetarySystem.PlanetarySystem planetarySystem;
        private readonly Planets planets;
        private readonly Yuga yuga;

        public Constructor_With_SuryaSiddanta()
        {
            planetarySystem = new PlanetarySystem.PlanetarySystem(System.SuryaSiddhanta);
            planets = planetarySystem.Planets;
            yuga = planetarySystem.Yuga;
        }

        [Fact]
        public void Should_Set_Up_The_Planetary_Constants_Correctly()
        {
            planets.Star.YugaRotation.Should().Be(1582237800);
            planets.Sun.YugaRotation.Should().Be(4320000);
            planets.Moon.YugaRotation.Should().Be(57753336);
            planets.Mercury.YugaRotation.Should().Be(17937000);
            planets.Venus.YugaRotation.Should().Be(7022388);
            planets.Mars.YugaRotation.Should().Be(2296824);
            planets.Jupiter.YugaRotation.Should().Be(364220);
            planets.Saturn.YugaRotation.Should().Be(146564);
            planets.Candrocca.YugaRotation.Should().Be(488219);
            planets.Rahu.YugaRotation.Should().Be(-232226);

            planets.Star.Rotation.Should().Be(0);
            planets.Sun.Rotation.Should().Be(4320000);
            planets.Moon.Rotation.Should().Be(57753336);
            planets.Mercury.Rotation.Should().Be(4320000);
            planets.Venus.Rotation.Should().Be(4320000);
            planets.Mars.Rotation.Should().Be(2296824);
            planets.Jupiter.Rotation.Should().Be(364220);
            planets.Saturn.Rotation.Should().Be(146564);
            planets.Candrocca.Rotation.Should().Be(488219);
            planets.Rahu.Rotation.Should().Be(-232226);

            planets.Star.Sighra.Should().Be(0);
            planets.Sun.Sighra.Should().Be(4320000);
            planets.Moon.Sighra.Should().Be(0);
            planets.Mercury.Sighra.Should().Be(17937000);
            planets.Venus.Sighra.Should().Be(7022388);
            planets.Mars.Sighra.Should().Be(4320000);
            planets.Jupiter.Sighra.Should().Be(4320000);
            planets.Saturn.Sighra.Should().Be(4320000);
            planets.Candrocca.Sighra.Should().Be(0);
            planets.Rahu.Sighra.Should().Be(0);

            planets.Star.Apogee.Should().Be(0);
            planets.Sun.Apogee.Should().Be(77.28333333333333);
            planets.Moon.Apogee.Should().Be(0);
            planets.Mercury.Apogee.Should().Be(220.45);
            planets.Venus.Apogee.Should().Be(79.83333333333333);
            planets.Mars.Apogee.Should().Be(130.03333333333333);
            planets.Jupiter.Apogee.Should().Be(171.3);
            planets.Saturn.Apogee.Should().Be(236.61666666666667);
            planets.Candrocca.Apogee.Should().Be(0);
            planets.Rahu.Apogee.Should().Be(0);

            planets.Star.MandaCircumference.Should().Be(0);
            planets.Sun.MandaCircumference.Should().Be(13.833333333333334);
            planets.Moon.MandaCircumference.Should().Be(31.833333333333332);
            planets.Mercury.MandaCircumference.Should().Be(29);
            planets.Venus.MandaCircumference.Should().Be(11.5);
            planets.Mars.MandaCircumference.Should().Be(73.5);
            planets.Jupiter.MandaCircumference.Should().Be(32.5);
            planets.Saturn.MandaCircumference.Should().Be(48.5);
            planets.Candrocca.MandaCircumference.Should().Be(0);
            planets.Rahu.MandaCircumference.Should().Be(0);

            planets.Star.SighraCircumference.Should().Be(0);
            planets.Sun.SighraCircumference.Should().Be(0);
            planets.Moon.SighraCircumference.Should().Be(0);
            planets.Mercury.SighraCircumference.Should().Be(131.5);
            planets.Venus.SighraCircumference.Should().Be(261);
            planets.Mars.SighraCircumference.Should().Be(233.5);
            planets.Jupiter.SighraCircumference.Should().Be(71);
            planets.Saturn.SighraCircumference.Should().Be(39.5);
            planets.Candrocca.SighraCircumference.Should().Be(0);
            planets.Rahu.SighraCircumference.Should().Be(0);

            yuga.CivilDays.Should().Be(1577917800);
            yuga.SynodicMonth.Should().Be(53433336);
            yuga.Adhimasa.Should().Be(1593336);
            yuga.Tithi.Should().Be(1603000080);
            yuga.Ksayadina.Should().Be(25082280);
        }
    }

    public class Constructor_With_Pancasiddantika
    {
        private PlanetarySystem.PlanetarySystem planetarySystem;
        private readonly Planets planets;
        private readonly Yuga yuga;

        public Constructor_With_Pancasiddantika()
        {
            planetarySystem = new PlanetarySystem.PlanetarySystem(System.Pancasiddhantika);
            planets = planetarySystem.Planets;
            yuga = planetarySystem.Yuga;
        }

        [Fact]
        public void Should_Set_Up_The_Planetary_Constants_Correctly()
        {
            planets.Star.YugaRotation.Should().Be(1582237828);
            planets.Sun.YugaRotation.Should().Be(4320000);
            planets.Moon.YugaRotation.Should().Be(57753336);
            planets.Mercury.YugaRotation.Should().Be(17937060);
            planets.Venus.YugaRotation.Should().Be(7022376);
            planets.Mars.YugaRotation.Should().Be(2296832);
            planets.Jupiter.YugaRotation.Should().Be(364220);
            planets.Saturn.YugaRotation.Should().Be(146568);
            planets.Candrocca.YugaRotation.Should().Be(488203);
            planets.Rahu.YugaRotation.Should().Be(-232238);

            planets.Star.Rotation.Should().Be(0);
            planets.Sun.Rotation.Should().Be(4320000);
            planets.Moon.Rotation.Should().Be(57753336);
            planets.Mercury.Rotation.Should().Be(4320000);
            planets.Venus.Rotation.Should().Be(4320000);
            planets.Mars.Rotation.Should().Be(2296832);
            planets.Jupiter.Rotation.Should().Be(364220);
            planets.Saturn.Rotation.Should().Be(146568);
            planets.Candrocca.Rotation.Should().Be(488203);
            planets.Rahu.Rotation.Should().Be(-232238);

            planets.Star.Sighra.Should().Be(0);
            planets.Sun.Sighra.Should().Be(4320000);
            planets.Moon.Sighra.Should().Be(0);
            planets.Mercury.Sighra.Should().Be(17937060);
            planets.Venus.Sighra.Should().Be(7022376);
            planets.Mars.Sighra.Should().Be(4320000);
            planets.Jupiter.Sighra.Should().Be(4320000);
            planets.Saturn.Sighra.Should().Be(4320000);
            planets.Candrocca.Sighra.Should().Be(0);
            planets.Rahu.Sighra.Should().Be(0);

            planets.Star.Apogee.Should().Be(0);
            planets.Sun.Apogee.Should().Be(77.28333333333333);
            planets.Moon.Apogee.Should().Be(0);
            planets.Mercury.Apogee.Should().Be(220.45);
            planets.Venus.Apogee.Should().Be(79.83333333333333);
            planets.Mars.Apogee.Should().Be(130.03333333333333);
            planets.Jupiter.Apogee.Should().Be(171.3);
            planets.Saturn.Apogee.Should().Be(236.61666666666667);
            planets.Candrocca.Apogee.Should().Be(0);
            planets.Rahu.Apogee.Should().Be(0);

            planets.Star.MandaCircumference.Should().Be(0);
            planets.Sun.MandaCircumference.Should().Be(13.833333333333334);
            planets.Moon.MandaCircumference.Should().Be(31.833333333333332);
            planets.Mercury.MandaCircumference.Should().Be(29);
            planets.Venus.MandaCircumference.Should().Be(11.5);
            planets.Mars.MandaCircumference.Should().Be(73.5);
            planets.Jupiter.MandaCircumference.Should().Be(32.5);
            planets.Saturn.MandaCircumference.Should().Be(48.5);
            planets.Candrocca.MandaCircumference.Should().Be(0);
            planets.Rahu.MandaCircumference.Should().Be(0);

            planets.Star.SighraCircumference.Should().Be(0);
            planets.Sun.SighraCircumference.Should().Be(0);
            planets.Moon.SighraCircumference.Should().Be(0);
            planets.Mercury.SighraCircumference.Should().Be(131.5);
            planets.Venus.SighraCircumference.Should().Be(261);
            planets.Mars.SighraCircumference.Should().Be(233.5);
            planets.Jupiter.SighraCircumference.Should().Be(71);
            planets.Saturn.SighraCircumference.Should().Be(39.5);
            planets.Candrocca.SighraCircumference.Should().Be(0);
            planets.Rahu.SighraCircumference.Should().Be(0);

            yuga.CivilDays.Should().Be(1577917828);
            yuga.SynodicMonth.Should().Be(53433336);
            yuga.Adhimasa.Should().Be(1593336);
            yuga.Tithi.Should().Be(1603000080);
            yuga.Ksayadina.Should().Be(25082252);
        }
    }
}