using FluentAssertions;
using Xunit;

namespace Kollavarsham.Net.Tests
{
    public class CelestialTests
    {
        private readonly Celestial _celestial;

        public CelestialTests()
        {
            _celestial = new Celestial();
        }

        [Fact]
        public void ThreeRelation_Should_Return_Correct_Results()
        {
            Celestial.ThreeRelation(-1, 1, 3).Should().Be(1);
            Celestial.ThreeRelation(1, -1, -3).Should().Be(-1);
            Celestial.ThreeRelation(1, 1, 1).Should().Be(0);
            Celestial.ThreeRelation(1, 5, -3).Should().Be(0); //invalid scenario
        }

        [Fact]
        public void GetTithi_Should_Return_Correct_Results()
        {
            Celestial.GetTithi(294.989551683806, 37.5275236212135).Should()
                .BeCloseTo(8.54483099478396, MathHelper.Epsilon);
            Celestial.GetTithi(333.593757395798, 45.9229472947752).Should()
                .BeCloseTo(6.02743249158144, MathHelper.Epsilon);
            Celestial.GetTithi(15.597297524597, 123.3068304585275).Should()
                .BeCloseTo(8.97579441116087, MathHelper.Epsilon);
            Celestial.GetTithi(163.989551683806, 15.5275236212135).Should()
                .BeCloseTo(17.6281643281173, MathHelper.Epsilon);
            Celestial.GetTithi(3.593757395798, 245.9229472947752).Should()
                .BeCloseTo(20.1940991582481, MathHelper.Epsilon);
            Celestial.GetTithi(56.597297524597, 302.3068304585275).Should()
                .BeCloseTo(20.4757944111609, MathHelper.Epsilon);
        }

        [Fact]
        public void GetMandaEquation_Should_Return_Correct_Results()
        {
            _celestial.GetMandaEquation(216.448410870245, Planet.Sun).Should()
                .BeCloseTo(-1.30810722363905, MathHelper.Epsilon);
            _celestial.GetMandaEquation(-72.3184309200178, Planet.Moon).Should()
                .BeCloseTo(-4.83281883352571, MathHelper.Epsilon);
            _celestial.GetMandaEquation(150.807334962742, Planet.Moon).Should()
                .BeCloseTo(2.47190852495064, MathHelper.Epsilon);
            _celestial.GetMandaEquation(206.122810882618, Planet.Sun).Should()
                .BeCloseTo(-0.969422483995786, MathHelper.Epsilon);
            _celestial.GetMandaEquation(203.067198238109, Planet.Moon).Should()
                .BeCloseTo(-1.98547851952987, MathHelper.Epsilon);
            _celestial.GetMandaEquation(210.065221570941, Planet.Sun).Should()
                .BeCloseTo(-1.10305954670912, MathHelper.Epsilon);
            _celestial.GetMandaEquation(176.937266597806, Planet.Moon).Should()
                .BeCloseTo(0.270697085906033, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.094016226779, Planet.Sun).Should()
                .BeCloseTo(-1.03685394627977, MathHelper.Epsilon);
            _celestial.GetMandaEquation(163.872300782873, Planet.Moon).Should()
                .BeCloseTo(1.40749058746745, MathHelper.Epsilon);
            _celestial.GetMandaEquation(207.108413554698, Planet.Sun).Should()
                .BeCloseTo(-1.00328649380511, MathHelper.Epsilon);
            _celestial.GetMandaEquation(190.002232417937, Planet.Moon).Should()
                .BeCloseTo(-0.880005747995446, MathHelper.Epsilon);
            _celestial.GetMandaEquation(209.07961889886, Planet.Sun).Should()
                .BeCloseTo(-1.07011491083048, MathHelper.Epsilon);
            _celestial.GetMandaEquation(176.937266597806, Planet.Moon).Should()
                .BeCloseTo(0.270697085906033, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.094016226779, Planet.Sun).Should()
                .BeCloseTo(-1.03685394627977, MathHelper.Epsilon);
            _celestial.GetMandaEquation(170.404783692979, Planet.Moon).Should()
                .BeCloseTo(0.844536073585857, MathHelper.Epsilon);
            _celestial.GetMandaEquation(207.601214890739, Planet.Sun).Should()
                .BeCloseTo(-1.02010791244252, MathHelper.Epsilon);
            _celestial.GetMandaEquation(183.469749507872, Planet.Moon).Should()
                .BeCloseTo(-0.306629778128034, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.58681756282, Planet.Sun).Should()
                .BeCloseTo(-1.05352335673225, MathHelper.Epsilon);
            _celestial.GetMandaEquation(176.937266597806, Planet.Moon).Should()
                .BeCloseTo(0.270697085906033, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.094016226779, Planet.Sun).Should()
                .BeCloseTo(-1.03685394627977, MathHelper.Epsilon);
            _celestial.GetMandaEquation(190.002232417937, Planet.Moon).Should()
                .BeCloseTo(-0.880005747995446, MathHelper.Epsilon);
            _celestial.GetMandaEquation(209.07961889886, Planet.Sun).Should()
                .BeCloseTo(-1.07011491083048, MathHelper.Epsilon);
            _celestial.GetMandaEquation(183.469749507872, Planet.Moon).Should()
                .BeCloseTo(-0.306629778128034, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.58681756282, Planet.Sun).Should()
                .BeCloseTo(-1.05352335673225, MathHelper.Epsilon);
            _celestial.GetMandaEquation(180.203508055438, Planet.Moon).Should()
                .BeCloseTo(-0.0179953506933944, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.340416894636, Planet.Sun).Should()
                .BeCloseTo(-1.04519830661684, MathHelper.Epsilon);
            _celestial.GetMandaEquation(186.735990965544, Planet.Moon).Should()
                .BeCloseTo(-0.594275735600709, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.833218230676, Planet.Sun).Should()
                .BeCloseTo(-1.06182894265887, MathHelper.Epsilon);
            _celestial.GetMandaEquation(183.469749507872, Planet.Moon).Should()
                .BeCloseTo(-0.306629778128034, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.58681756282, Planet.Sun).Should()
                .BeCloseTo(-1.05352335673225, MathHelper.Epsilon);
            _celestial.GetMandaEquation(176.937266597806, Planet.Moon).Should()
                .BeCloseTo(0.270697085906033, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.094016226779, Planet.Sun).Should()
                .BeCloseTo(-1.03685394627977, MathHelper.Epsilon);
            _celestial.GetMandaEquation(180.203508055438, Planet.Moon).Should()
                .BeCloseTo(-0.0179953506933944, MathHelper.Epsilon);
            _celestial.GetMandaEquation(208.340416894636, Planet.Sun).Should()
                .BeCloseTo(-1.04519830661684, MathHelper.Epsilon);
            _celestial.GetMandaEquation(83.931123946793, Planet.Mercury).Should()
                .BeCloseTo(4.59454849262788, MathHelper.Epsilon);
            _celestial.GetMandaEquation(81.6338497004791, Planet.Mercury).Should()
                .BeCloseTo(4.57122541974445, MathHelper.Epsilon);
            _celestial.GetMandaEquation(191.523444971968, Planet.Venus).Should()
                .BeCloseTo(-0.365635863559596, MathHelper.Epsilon);
            _celestial.GetMandaEquation(191.706262903748, Planet.Venus).Should()
                .BeCloseTo(-0.37135641118768, MathHelper.Epsilon);
            _celestial.GetMandaEquation(34.7045977141798, Planet.Mars).Should()
                .BeCloseTo(6.67523064837691, MathHelper.Epsilon);
            _celestial.GetMandaEquation(31.3669823899913, Planet.Mars).Should()
                .BeCloseTo(6.10047750894678, MathHelper.Epsilon);
            _celestial.GetMandaEquation(-91.5542432559879, Planet.Jupiter).Should()
                .BeCloseTo(-5.17767683561233, MathHelper.Epsilon);
            _celestial.GetMandaEquation(-88.9654048381817, Planet.Jupiter).Should()
                .BeCloseTo(-5.17874093000353, MathHelper.Epsilon);
            _celestial.GetMandaEquation(-42.8326673204595, Planet.Saturn).Should()
                .BeCloseTo(-5.25521105975762, MathHelper.Epsilon);
            _celestial.GetMandaEquation(-40.2050617905807, Planet.Saturn).Should()
                .BeCloseTo(-4.98912071710793, MathHelper.Epsilon);
        }

        [Fact]
        public void Declination_Should_Return_Correct_Results()
        {
            Celestial.Declination(31.3101877453024).Should().BeCloseTo(12.2026059914001, MathHelper.Epsilon);
            Celestial.Declination(42.2597957259723).Should().BeCloseTo(15.8742931864835, MathHelper.Epsilon);
            Celestial.Declination(59.2349729472294).Should().BeCloseTo(20.4565845497204, MathHelper.Epsilon);
            Celestial.Declination(62.5975972349908).Should().BeCloseTo(21.1677169773821, MathHelper.Epsilon);
            Celestial.Declination(80.4818781723799).Should().BeCloseTo(23.6492922420057, MathHelper.Epsilon);
            Celestial.Declination(121.1497130809087).Should().BeCloseTo(20.3707052985127, MathHelper.Epsilon);
            Celestial.Declination(320.8687779979979).Should().BeCloseTo(-14.8738036439391, MathHelper.Epsilon);
        }

        [Fact]
        public void GetTrueLunarLongitude_Should_Return_Correct_Results()
        {
            _celestial.GetTrueLunarLongitude(2299158.5).Should().BeCloseTo(167.084587116821, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2299159.5).Should().BeCloseTo(179.618866280373, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2299160.5).Should().BeCloseTo(191.953219840454, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2299161.5).Should().BeCloseTo(204.131519861513, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2361220.5).Should().BeCloseTo(349.195739637822, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2361221.5).Should().BeCloseTo(1.82309136307406, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2361222.5).Should().BeCloseTo(14.6945040053245, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(1721457.5).Should().BeCloseTo(6.55724149356419, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2456656.5).Should().BeCloseTo(16.24829446685, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2456657.5).Should().BeCloseTo(29.8253740270552, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2455957.5).Should().BeCloseTo(156.709071062542, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2456351.5).Should().BeCloseTo(316.081404838166, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2455985.5).Should().BeCloseTo(165.854323537076, MathHelper.Epsilon);
            _celestial.GetTrueLunarLongitude(2433313.5).Should().BeCloseTo(236.806759936797, MathHelper.Epsilon);
        }

        [Fact]
        public void GetTrueSolarLongitude_Should_Return_Correct_Results()
        {
            _celestial.GetTrueSolarLongitude(2299158.5).Should().BeCloseTo(215.330481398828, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2299159.5).Should().BeCloseTo(216.345092245966, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2299160.5).Should().BeCloseTo(217.360117559963, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2299161.5).Should().BeCloseTo(218.375548627069, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2361220.5).Should().BeCloseTo(183.139229101953, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2361221.5).Should().BeCloseTo(184.136821438217, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2361222.5).Should().BeCloseTo(185.135030298228, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(1721457.5).Should().BeCloseTo(355.302664567532, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2456656.5).Should().BeCloseTo(288.309252298232, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2456657.5).Should().BeCloseTo(289.32751969395, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2455957.5).Should().BeCloseTo(320.200309773426, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2456351.5).Should().BeCloseTo(348.803993428264, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2455985.5).Should().BeCloseTo(348.072902270539, MathHelper.Epsilon);
            _celestial.GetTrueSolarLongitude(2433313.5).Should().BeCloseTo(322.249740952942, MathHelper.Epsilon);
        }

        [Fact]
        public void GetMeanLongitude_Should_Return_Correct_Results()
        {
            _celestial.GetMeanLongitude(1868236.15634155, 4320000).Should()
                .BeCloseTo(298.54776362783, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15637207, 4320000).Should()
                .BeCloseTo(298.547793708385, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15635681, 4320000).Should()
                .BeCloseTo(298.547778668108, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15635681, 4320000).Should()
                .BeCloseTo(298.547778668108, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15637207, 4320000).Should()
                .BeCloseTo(298.547793708385, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15636444, 4320000).Should()
                .BeCloseTo(298.547786188246, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15635681, 4320000).Should()
                .BeCloseTo(298.547778668108, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15636444, 4320000).Should()
                .BeCloseTo(298.547786188246, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15636063, 4320000).Should()
                .BeCloseTo(298.547782433088, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15636063, 4320000).Should()
                .BeCloseTo(298.547782433088, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15636444, 4320000).Should()
                .BeCloseTo(298.547786188246, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15636253, 4320000).Should()
                .BeCloseTo(298.54778430592, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15636063, 4320000).Should()
                .BeCloseTo(298.547782433088, MathHelper.Epsilon);
            _celestial.GetMeanLongitude(1868236.15636253, 4320000).Should()
                .BeCloseTo(298.54778430592, MathHelper.Epsilon);
        }

        [Fact]
        public void GetEclipticLongitude_Should_Return_Correct_Results()
        {
            _celestial.GetEclipticLongitude(1710693).Should().BeCloseTo(168.08719102714, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710694).Should().BeCloseTo(154.755365716082, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710695).Should().BeCloseTo(141.463254728984, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710696).Should().BeCloseTo(128.268162836368, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772755).Should().BeCloseTo(59.276089124806, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772756).Should().BeCloseTo(70.8982212421655, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772757).Should().BeCloseTo(82.3090362371512, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1132992).Should().BeCloseTo(95.3516217819625, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868191).Should().BeCloseTo(35.3086446106693, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868192).Should().BeCloseTo(22.4428920586289, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867492).Should().BeCloseTo(87.4807549325996, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867886).Should().BeCloseTo(156.157101234428, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867520).Should().BeCloseTo(67.5269642534404, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1844848).Should().BeCloseTo(154.486799638547, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710693).Should().BeCloseTo(168.08719102714, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710694).Should().BeCloseTo(154.755365716082, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710695).Should().BeCloseTo(141.463254728984, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710696).Should().BeCloseTo(128.268162836368, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772755).Should().BeCloseTo(59.276089124806, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772756).Should().BeCloseTo(70.8982212421655, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772757).Should().BeCloseTo(82.3090362371512, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1132992).Should().BeCloseTo(95.3516217819625, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868191).Should().BeCloseTo(35.3086446106693, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868192).Should().BeCloseTo(22.4428920586289, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867492).Should().BeCloseTo(87.4807549325996, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867886).Should().BeCloseTo(156.157101234428, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867520).Should().BeCloseTo(67.5269642534404, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1844848).Should().BeCloseTo(154.486799638547, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710693).Should().BeCloseTo(168.08719102714, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710694).Should().BeCloseTo(154.755365716082, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710695).Should().BeCloseTo(141.463254728984, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710696).Should().BeCloseTo(128.268162836368, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772755).Should().BeCloseTo(59.276089124806, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772756).Should().BeCloseTo(70.8982212421655, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772757).Should().BeCloseTo(82.3090362371512, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1132992).Should().BeCloseTo(95.3516217819625, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868191).Should().BeCloseTo(35.3086446106693, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868192).Should().BeCloseTo(22.4428920586289, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867492).Should().BeCloseTo(87.4807549325996, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867886).Should().BeCloseTo(156.157101234428, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867520).Should().BeCloseTo(67.5269642534404, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1844848).Should().BeCloseTo(154.486799638547, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710693).Should().BeCloseTo(168.08719102714, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710694).Should().BeCloseTo(154.755365716082, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710695).Should().BeCloseTo(141.463254728984, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710696).Should().BeCloseTo(128.268162836368, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772755).Should().BeCloseTo(59.276089124806, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772756).Should().BeCloseTo(70.8982212421655, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772757).Should().BeCloseTo(82.3090362371512, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1132992).Should().BeCloseTo(95.3516217819625, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868191).Should().BeCloseTo(35.3086446106693, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868192).Should().BeCloseTo(22.4428920586289, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867492).Should().BeCloseTo(87.4807549325996, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867886).Should().BeCloseTo(156.157101234428, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867520).Should().BeCloseTo(67.5269642534404, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1844848).Should().BeCloseTo(154.486799638547, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710693).Should().BeCloseTo(168.08719102714, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710694).Should().BeCloseTo(154.755365716082, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710695).Should().BeCloseTo(141.463254728984, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1710696).Should().BeCloseTo(128.268162836368, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772755).Should().BeCloseTo(59.276089124806, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772756).Should().BeCloseTo(70.8982212421655, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1772757).Should().BeCloseTo(82.3090362371512, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1132992).Should().BeCloseTo(95.3516217819625, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868191).Should().BeCloseTo(35.3086446106693, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1868192).Should().BeCloseTo(22.4428920586289, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867492).Should().BeCloseTo(87.4807549325996, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867886).Should().BeCloseTo(156.157101234428, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1867520).Should().BeCloseTo(67.5269642534404, MathHelper.Epsilon);
            _celestial.GetEclipticLongitude(1844848).Should().BeCloseTo(154.486799638547, MathHelper.Epsilon);
        }

        [Fact]
        public void GetConjunction_Should_Return_Correct_Results()
        {
            _celestial.GetConjunction(1710693).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710694).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710695).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710696).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1772755).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772756).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772757).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1132992).Should().BeCloseTo(330.403978010768, MathHelper.Epsilon);
            _celestial.GetConjunction(1868191).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1868192).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1867492).Should().BeCloseTo(278.46912256809, MathHelper.Epsilon);
            _celestial.GetConjunction(1867886).Should().BeCloseTo(327.315683844566, MathHelper.Epsilon);
            _celestial.GetConjunction(1867520).Should().BeCloseTo(308.537344813799, MathHelper.Epsilon);
            _celestial.GetConjunction(1844848).Should().BeCloseTo(274.457623345507, MathHelper.Epsilon);
            _celestial.GetConjunction(1710693).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710694).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710695).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710696).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1772755).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772756).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772757).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1132992).Should().BeCloseTo(330.403978010768, MathHelper.Epsilon);
            _celestial.GetConjunction(1868191).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1868192).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1867492).Should().BeCloseTo(278.46912256809, MathHelper.Epsilon);
            _celestial.GetConjunction(1867886).Should().BeCloseTo(327.315683844566, MathHelper.Epsilon);
            _celestial.GetConjunction(1867520).Should().BeCloseTo(308.537344813799, MathHelper.Epsilon);
            _celestial.GetConjunction(1844848).Should().BeCloseTo(274.457623345507, MathHelper.Epsilon);
            _celestial.GetConjunction(1710693).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710694).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710695).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710696).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1772755).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772756).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772757).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1132992).Should().BeCloseTo(330.403978010768, MathHelper.Epsilon);
            _celestial.GetConjunction(1868191).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1868192).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1867492).Should().BeCloseTo(278.46912256809, MathHelper.Epsilon);
            _celestial.GetConjunction(1867886).Should().BeCloseTo(327.315683844566, MathHelper.Epsilon);
            _celestial.GetConjunction(1867520).Should().BeCloseTo(308.537344813799, MathHelper.Epsilon);
            _celestial.GetConjunction(1844848).Should().BeCloseTo(274.457623345507, MathHelper.Epsilon);
            _celestial.GetConjunction(1710693).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710694).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710695).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710696).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1772755).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772756).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772757).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1132992).Should().BeCloseTo(330.403978010768, MathHelper.Epsilon);
            _celestial.GetConjunction(1868191).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1868192).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1867492).Should().BeCloseTo(278.46912256809, MathHelper.Epsilon);
            _celestial.GetConjunction(1867886).Should().BeCloseTo(327.315683844566, MathHelper.Epsilon);
            _celestial.GetConjunction(1867520).Should().BeCloseTo(308.537344813799, MathHelper.Epsilon);
            _celestial.GetConjunction(1844848).Should().BeCloseTo(274.457623345507, MathHelper.Epsilon);
            _celestial.GetConjunction(1710693).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710694).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710695).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1710696).Should().BeCloseTo(195.220929584348, MathHelper.Epsilon);
            _celestial.GetConjunction(1772755).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772756).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1772757).Should().BeCloseTo(145.265504902157, MathHelper.Epsilon);
            _celestial.GetConjunction(1132992).Should().BeCloseTo(330.403978010768, MathHelper.Epsilon);
            _celestial.GetConjunction(1868191).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1868192).Should().BeCloseTo(256.693393501849, MathHelper.Epsilon);
            _celestial.GetConjunction(1867492).Should().BeCloseTo(278.46912256809, MathHelper.Epsilon);
            _celestial.GetConjunction(1867886).Should().BeCloseTo(327.315683844566, MathHelper.Epsilon);
            _celestial.GetConjunction(1867520).Should().BeCloseTo(308.537344813799, MathHelper.Epsilon);
            _celestial.GetConjunction(1844848).Should().BeCloseTo(274.457623345507, MathHelper.Epsilon);
        }

        [Fact]
        public void GetDaylightEquation_Should_Return_Correct_Results()
        {
            _celestial.GetDaylightEquation(2018, 10.5, 1710693).Should()
                .BeCloseTo(-0.005420561412729585, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1710694).Should()
                .BeCloseTo(-0.005614522183274197, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1710695).Should()
                .BeCloseTo(-0.005807467501313135, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1710696).Should()
                .BeCloseTo(-0.005999348448389154, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1772755).Should()
                .BeCloseTo(0.00107770027863962, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1772756).Should()
                .BeCloseTo(0.0008716564611006835, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1772757).Should()
                .BeCloseTo(0.0006654834899484697, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1132992).Should()
                .BeCloseTo(-0.003588875611065327, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1868191).Should()
                .BeCloseTo(-0.013036431706478948, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1868192).Should()
                .BeCloseTo(-0.013001996328907502, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1867492).Should()
                .BeCloseTo(-0.010004131830564776, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1867886).Should()
                .BeCloseTo(-0.004905444657490358, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1867520).Should()
                .BeCloseTo(-0.005051116361050748, MathHelper.Epsilon);
            _celestial.GetDaylightEquation(2018, 10.5, 1844848).Should()
                .BeCloseTo(-0.009693442247709978, MathHelper.Epsilon);
        }

        [Fact]
        public void GetSunriseTime_Should_Return_Correct_Results()
        {
            var sunriseTime = Celestial.GetSunriseTime(0.0, 0.0);
            sunriseTime.Hour.Should().Be(0);
            sunriseTime.Minute.Should().Be(0);

            sunriseTime = Celestial.GetSunriseTime(0.14583333333333, 0.0);
            sunriseTime.Hour.Should().Be(3);
            sunriseTime.Minute.Should().Be(29);

            sunriseTime = Celestial.GetSunriseTime(0.25, 0.0);
            sunriseTime.Hour.Should().Be(6);
            sunriseTime.Minute.Should().Be(0);

            sunriseTime = Celestial.GetSunriseTime(0.48958333333333, 0.0);
            sunriseTime.Hour.Should().Be(11);
            sunriseTime.Minute.Should().Be(44);

            sunriseTime = Celestial.GetSunriseTime(0.5, 0.0);
            sunriseTime.Hour.Should().Be(12);
            sunriseTime.Minute.Should().Be(0);

            sunriseTime = Celestial.GetSunriseTime(0.68402777777778, 0.0);
            sunriseTime.Hour.Should().Be(16);
            sunriseTime.Minute.Should().Be(25);

            sunriseTime = Celestial.GetSunriseTime(0.75, 0.0);
            sunriseTime.Hour.Should().Be(18);
            sunriseTime.Minute.Should().Be(0);
        }

        [Fact]
        public void GetLastConjunctionLongitude_Should_Return_Results()
        {
            _celestial.GetLastConjunctionLongitude(1710693, 8.54483099478396).Should()
                .BeCloseTo(165.6082302520299, MathHelper.Epsilon);
            _celestial.GetLastConjunctionLongitude(1810694, 9.74443045978396).Should()
                .BeCloseTo(106.68697671647189, MathHelper.Epsilon);
            _celestial.GetLastConjunctionLongitude(1910695, 10.54899456473964).Should()
                .BeCloseTo(21.008813423509878, MathHelper.Epsilon);
        }

        [Fact]
        public void GetNextConjunctionLongitude_Should_Return_Results()
        {
            _celestial.GetNextConjunctionLongitude(1710693, 8.54483099478396).Should()
                .BeCloseTo(195.2209295926904, MathHelper.Epsilon);
            _celestial.GetNextConjunctionLongitude(1810694, 9.74443045978396).Should()
                .BeCloseTo(135.03288802411012, MathHelper.Epsilon);
            _celestial.GetNextConjunctionLongitude(1910695, 10.54899456473964).Should()
                .BeCloseTo(49.155790280363135, MathHelper.Epsilon);
        }
    }
}