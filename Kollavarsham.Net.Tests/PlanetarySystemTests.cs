using FluentAssertions;
using Kollavarsham.Net.PlanetarySystem;
using Kollavarsham.Net.PlanetarySystem.Planets;
using Xunit;

namespace Kollavarsham.Net.Tests
{
    public class EmptyConstructor
    {
        private readonly Planets _planets;

        public EmptyConstructor()
        {
            var planetarySystem = new PlanetarySystem.PlanetarySystem();
            _planets = planetarySystem.Planets;
        }

        [Fact]
        public void Should_Set_the_YugaRotation_Values_Correctly()
        {
            _planets.Star.YugaRotation.Should().Be(1582237800);
            _planets.Sun.YugaRotation.Should().Be(4320000);
            _planets.Moon.YugaRotation.Should().Be(57753336);
            _planets.Mercury.YugaRotation.Should().Be(17937000);
            _planets.Venus.YugaRotation.Should().Be(7022388);
            _planets.Mars.YugaRotation.Should().Be(2296824);
            _planets.Jupiter.YugaRotation.Should().Be(364220);
            _planets.Saturn.YugaRotation.Should().Be(146564);
            _planets.Candrocca.YugaRotation.Should().Be(488219);
            _planets.Rahu.YugaRotation.Should().Be(-232226);
        }
    }

    public class ConstructorWithSuryaSiddanta
    {
        private readonly Planets _planets;
        private readonly Yuga _yuga;

        public ConstructorWithSuryaSiddanta()
        {
            var planetarySystem = new PlanetarySystem.PlanetarySystem();
            _planets = planetarySystem.Planets;
            _yuga = planetarySystem.Yuga;
        }

        [Fact]
        public void Should_Set_Up_The_Planetary_Constants_Correctly()
        {
            _planets.Star.YugaRotation.Should().Be(1582237800);
            _planets.Sun.YugaRotation.Should().Be(4320000);
            _planets.Moon.YugaRotation.Should().Be(57753336);
            _planets.Mercury.YugaRotation.Should().Be(17937000);
            _planets.Venus.YugaRotation.Should().Be(7022388);
            _planets.Mars.YugaRotation.Should().Be(2296824);
            _planets.Jupiter.YugaRotation.Should().Be(364220);
            _planets.Saturn.YugaRotation.Should().Be(146564);
            _planets.Candrocca.YugaRotation.Should().Be(488219);
            _planets.Rahu.YugaRotation.Should().Be(-232226);

            _planets.Star.Rotation.Should().Be(0);
            _planets.Sun.Rotation.Should().Be(4320000);
            _planets.Moon.Rotation.Should().Be(57753336);
            _planets.Mercury.Rotation.Should().Be(4320000);
            _planets.Venus.Rotation.Should().Be(4320000);
            _planets.Mars.Rotation.Should().Be(2296824);
            _planets.Jupiter.Rotation.Should().Be(364220);
            _planets.Saturn.Rotation.Should().Be(146564);
            _planets.Candrocca.Rotation.Should().Be(488219);
            _planets.Rahu.Rotation.Should().Be(-232226);

            _planets.Star.Sighra.Should().Be(0);
            _planets.Sun.Sighra.Should().Be(4320000);
            _planets.Moon.Sighra.Should().Be(0);
            _planets.Mercury.Sighra.Should().Be(17937000);
            _planets.Venus.Sighra.Should().Be(7022388);
            _planets.Mars.Sighra.Should().Be(4320000);
            _planets.Jupiter.Sighra.Should().Be(4320000);
            _planets.Saturn.Sighra.Should().Be(4320000);
            _planets.Candrocca.Sighra.Should().Be(0);
            _planets.Rahu.Sighra.Should().Be(0);

            _planets.Star.Apogee.Should().Be(0);
            _planets.Sun.Apogee.Should().Be(77.28333333333333);
            _planets.Moon.Apogee.Should().Be(0);
            _planets.Mercury.Apogee.Should().Be(220.45);
            _planets.Venus.Apogee.Should().Be(79.83333333333333);
            _planets.Mars.Apogee.Should().Be(130.03333333333333);
            _planets.Jupiter.Apogee.Should().Be(171.3);
            _planets.Saturn.Apogee.Should().Be(236.61666666666667);
            _planets.Candrocca.Apogee.Should().Be(0);
            _planets.Rahu.Apogee.Should().Be(0);

            _planets.Star.MandaCircumference.Should().Be(0);
            _planets.Sun.MandaCircumference.Should().Be(13.833333333333334);
            _planets.Moon.MandaCircumference.Should().Be(31.833333333333332);
            _planets.Mercury.MandaCircumference.Should().Be(29);
            _planets.Venus.MandaCircumference.Should().Be(11.5);
            _planets.Mars.MandaCircumference.Should().Be(73.5);
            _planets.Jupiter.MandaCircumference.Should().Be(32.5);
            _planets.Saturn.MandaCircumference.Should().Be(48.5);
            _planets.Candrocca.MandaCircumference.Should().Be(0);
            _planets.Rahu.MandaCircumference.Should().Be(0);

            _planets.Star.SighraCircumference.Should().Be(0);
            _planets.Sun.SighraCircumference.Should().Be(0);
            _planets.Moon.SighraCircumference.Should().Be(0);
            _planets.Mercury.SighraCircumference.Should().Be(131.5);
            _planets.Venus.SighraCircumference.Should().Be(261);
            _planets.Mars.SighraCircumference.Should().Be(233.5);
            _planets.Jupiter.SighraCircumference.Should().Be(71);
            _planets.Saturn.SighraCircumference.Should().Be(39.5);
            _planets.Candrocca.SighraCircumference.Should().Be(0);
            _planets.Rahu.SighraCircumference.Should().Be(0);

            _yuga.CivilDays.Should().Be(1577917800);
            _yuga.SynodicMonth.Should().Be(53433336);
            _yuga.Adhimasa.Should().Be(1593336);
            _yuga.Tithi.Should().Be(1603000080);
            _yuga.Ksayadina.Should().Be(25082280);
        }
    }

    public class ConstructorWithPancasiddantika
    {
        private readonly Planets _planets;
        private readonly Yuga _yuga;

        public ConstructorWithPancasiddantika()
        {
            var planetarySystem = new PlanetarySystem.PlanetarySystem(System.Pancasiddhantika);
            _planets = planetarySystem.Planets;
            _yuga = planetarySystem.Yuga;
        }

        [Fact]
        public void Should_Set_Up_The_Planetary_Constants_Correctly()
        {
            _planets.Star.YugaRotation.Should().Be(1582237828);
            _planets.Sun.YugaRotation.Should().Be(4320000);
            _planets.Moon.YugaRotation.Should().Be(57753336);
            _planets.Mercury.YugaRotation.Should().Be(17937060);
            _planets.Venus.YugaRotation.Should().Be(7022376);
            _planets.Mars.YugaRotation.Should().Be(2296832);
            _planets.Jupiter.YugaRotation.Should().Be(364220);
            _planets.Saturn.YugaRotation.Should().Be(146568);
            _planets.Candrocca.YugaRotation.Should().Be(488203);
            _planets.Rahu.YugaRotation.Should().Be(-232238);

            _planets.Star.Rotation.Should().Be(0);
            _planets.Sun.Rotation.Should().Be(4320000);
            _planets.Moon.Rotation.Should().Be(57753336);
            _planets.Mercury.Rotation.Should().Be(4320000);
            _planets.Venus.Rotation.Should().Be(4320000);
            _planets.Mars.Rotation.Should().Be(2296832);
            _planets.Jupiter.Rotation.Should().Be(364220);
            _planets.Saturn.Rotation.Should().Be(146568);
            _planets.Candrocca.Rotation.Should().Be(488203);
            _planets.Rahu.Rotation.Should().Be(-232238);

            _planets.Star.Sighra.Should().Be(0);
            _planets.Sun.Sighra.Should().Be(4320000);
            _planets.Moon.Sighra.Should().Be(0);
            _planets.Mercury.Sighra.Should().Be(17937060);
            _planets.Venus.Sighra.Should().Be(7022376);
            _planets.Mars.Sighra.Should().Be(4320000);
            _planets.Jupiter.Sighra.Should().Be(4320000);
            _planets.Saturn.Sighra.Should().Be(4320000);
            _planets.Candrocca.Sighra.Should().Be(0);
            _planets.Rahu.Sighra.Should().Be(0);

            _planets.Star.Apogee.Should().Be(0);
            _planets.Sun.Apogee.Should().Be(77.28333333333333);
            _planets.Moon.Apogee.Should().Be(0);
            _planets.Mercury.Apogee.Should().Be(220.45);
            _planets.Venus.Apogee.Should().Be(79.83333333333333);
            _planets.Mars.Apogee.Should().Be(130.03333333333333);
            _planets.Jupiter.Apogee.Should().Be(171.3);
            _planets.Saturn.Apogee.Should().Be(236.61666666666667);
            _planets.Candrocca.Apogee.Should().Be(0);
            _planets.Rahu.Apogee.Should().Be(0);

            _planets.Star.MandaCircumference.Should().Be(0);
            _planets.Sun.MandaCircumference.Should().Be(13.833333333333334);
            _planets.Moon.MandaCircumference.Should().Be(31.833333333333332);
            _planets.Mercury.MandaCircumference.Should().Be(29);
            _planets.Venus.MandaCircumference.Should().Be(11.5);
            _planets.Mars.MandaCircumference.Should().Be(73.5);
            _planets.Jupiter.MandaCircumference.Should().Be(32.5);
            _planets.Saturn.MandaCircumference.Should().Be(48.5);
            _planets.Candrocca.MandaCircumference.Should().Be(0);
            _planets.Rahu.MandaCircumference.Should().Be(0);

            _planets.Star.SighraCircumference.Should().Be(0);
            _planets.Sun.SighraCircumference.Should().Be(0);
            _planets.Moon.SighraCircumference.Should().Be(0);
            _planets.Mercury.SighraCircumference.Should().Be(131.5);
            _planets.Venus.SighraCircumference.Should().Be(261);
            _planets.Mars.SighraCircumference.Should().Be(233.5);
            _planets.Jupiter.SighraCircumference.Should().Be(71);
            _planets.Saturn.SighraCircumference.Should().Be(39.5);
            _planets.Candrocca.SighraCircumference.Should().Be(0);
            _planets.Rahu.SighraCircumference.Should().Be(0);

            _yuga.CivilDays.Should().Be(1577917828);
            _yuga.SynodicMonth.Should().Be(53433336);
            _yuga.Adhimasa.Should().Be(1593336);
            _yuga.Tithi.Should().Be(1603000080);
            _yuga.Ksayadina.Should().Be(25082252);
        }
    }
}