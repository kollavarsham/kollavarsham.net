using FluentAssertions;
using Xunit;

namespace Kollavarsham.Net.Tests
{
    public class MathHelperTests
    {
        [Fact]
        public void IsNumber_Should_Return_Correct_Results()
        {
            /*MathHelper.isNumber(0).Should().Be(true);
            MathHelper.isNumber(0.1).Should().Be(true);
            MathHelper.isNumber(-0.1).Should().Be(true);*/
            MathHelper.IsNumber("-0.1").Should().Be(true);
            MathHelper.IsNumber("23").Should().Be(true);
            /*MathHelper.isNumber(23.235927349).Should().Be(true);*/
            MathHelper.IsNumber("abchd").Should().Be(false);
            MathHelper.IsNumber("A quick brown fox").Should().Be(false);
        }

        [Fact]
        public void IsInt_Should_Return_Correct_Results()
        {
            MathHelper.IsInt(0).Should().Be(true);
            MathHelper.IsInt(0.1).Should().Be(false);
            MathHelper.IsInt(-0.1).Should().Be(false);
            MathHelper.IsInt("-42").Should().Be(true);
            MathHelper.IsInt("23").Should().Be(true);
            MathHelper.IsInt(23.235927349).Should().Be(false);
            MathHelper.IsInt("abchd").Should().Be(false);
            MathHelper.IsInt("A quick brown fox").Should().Be(false);
        }

        [Fact]
        public void TruncateDecimals_Should_Return_Correct_Results()
        {
            MathHelper.TruncateDecimals(0, 0).Should().Be(0);
            MathHelper.TruncateDecimals(0, 2).Should().Be(0);
            MathHelper.TruncateDecimals(0.2345, 2).Should().Be(0.23);
            MathHelper.TruncateDecimals(0.2385, 2).Should().Be(0.23);
            MathHelper.TruncateDecimals(0.23999, 2).Should().Be(0.23);
            MathHelper.TruncateDecimals(-456.23999, 2).Should().Be(-456.23);
            MathHelper.TruncateDecimals(456.999, 0).Should().Be(456);
            MathHelper.TruncateDecimals("456.999", 0).Should().Be(456);
        }

        [Fact]
        public void Truncate_Should_Return_Correct_Results()
        {
            MathHelper.Truncate(0.2345).Should().Be(0);
            MathHelper.Truncate(0.2385).Should().Be(0);
            MathHelper.Truncate(0.23999).Should().Be(0);
            MathHelper.Truncate(-456.23999).Should().Be(-456);
            MathHelper.Truncate(456.999).Should().Be(456);
            MathHelper.Truncate("456.999").Should().Be(456);
            MathHelper.Truncate("A quick brown fox").Should().Be(0);
            MathHelper.Truncate("-123456.350").Should().Be(-123456);
            MathHelper.Truncate("-123456").Should().Be(-123456);
        }

        [Fact]
        public void Floor_Should_Return_Correct_Results()
        {
            MathHelper.Floor(0.2345).Should().Be(0);
            MathHelper.Floor(-0.2385).Should().Be(-1);
            MathHelper.Floor(0.23999).Should().Be(0);
            MathHelper.Floor(-456.23999).Should().Be(-457);
            MathHelper.Floor(456.999).Should().Be(456);
            MathHelper.Floor("456.999").Should().Be(456);
            MathHelper.Floor("A quick brown fox").Should().Be(0);
            MathHelper.Floor("-123456.350").Should().Be(-123457);
            MathHelper.Floor(42.999).Should().Be(42);
            MathHelper.Floor(42.00001).Should().Be(42);
        }

        [Fact]
        public void Fractional_Should_Return_Correct_Results()
        {
            MathHelper.Fractional(0.2345).Should().BeCloseTo(0.2345, MathHelper.Epsilon);
            MathHelper.Fractional(-0.2385).Should().BeCloseTo(-0.2385, MathHelper.Epsilon);
            MathHelper.Fractional(0.23999).Should().BeCloseTo(0.23999, MathHelper.Epsilon);
            MathHelper.Fractional(-456.23999).Should().BeCloseTo(-0.23999, MathHelper.Epsilon);
            MathHelper.Fractional(456.999).Should().BeCloseTo(0.999, MathHelper.Epsilon);
            MathHelper.Fractional("456.999").Should().BeCloseTo(0.999, MathHelper.Epsilon);
            MathHelper.Fractional("A quick brown fox").Should().BeCloseTo(0, MathHelper.Epsilon);
            MathHelper.Fractional("-123456.350").Should().BeCloseTo(-0.350, MathHelper.Epsilon);
            MathHelper.Fractional(42.999).Should().BeCloseTo(0.999, MathHelper.Epsilon);
            MathHelper.Fractional(42.00001).Should().BeCloseTo(0.00001, MathHelper.Epsilon);
        }

        [Fact]
        public void Round_Should_Return_Correct_Results()
        {
            MathHelper.Round(0.2345).Should().Be(0);
            MathHelper.Round(-0.2385).Should().Be(0);
            MathHelper.Round(0.23999).Should().Be(0);
            MathHelper.Round(-456.23999).Should().Be(-456);
            MathHelper.Round(456.999).Should().Be(457);
            MathHelper.Round("456.999").Should().Be(457);
            MathHelper.Round("A quick brown fox").Should().Be(0);
            MathHelper.Round("-123456.350").Should().Be(-123456);
            MathHelper.Round(42.999).Should().Be(43);
            MathHelper.Round(-42.999).Should().Be(-43);
            MathHelper.Round(42.00001).Should().Be(42);
        }

        [Fact]
        public void Square_Should_Return_Correct_Results()
        {
            MathHelper.Square(0.2345).Should().BeCloseTo(0.05499025, MathHelper.Epsilon);
            MathHelper.Square(-0.2385).Should().BeCloseTo(0.05688225, MathHelper.Epsilon);
            MathHelper.Square(0.23999).Should().BeCloseTo(0.0575952001, MathHelper.Epsilon);
            MathHelper.Square(-456.23999).Should().BeCloseTo(208154.9284752001, MathHelper.Epsilon);
            MathHelper.Square(456.999).Should().BeCloseTo(208848.086001, MathHelper.Epsilon);
            MathHelper.Square("456.999").Should().BeCloseTo(208848.086001, MathHelper.Epsilon);
            MathHelper.Square("A quick brown fox").Should().BeCloseTo(0, MathHelper.Epsilon);
            MathHelper.Square(42.999).Should().BeCloseTo(1848.914001, MathHelper.Epsilon);
            MathHelper.Square(42.00001).Should().BeCloseTo(1764.0008400001, MathHelper.Epsilon);
            MathHelper.Square(5).Should().BeCloseTo(25, MathHelper.Epsilon);
            MathHelper.Square(9).Should().BeCloseTo(81, MathHelper.Epsilon);
        }

        [Fact]
        public void Zero360_Should_Return_Correct_Results()
        {
            MathHelper.Zero360(75.2).Should().Be(75.2);
            MathHelper.Zero360(-75.2).Should().Be(284.8);
            MathHelper.Zero360(370).Should().Be(10);
            MathHelper.Zero360(0).Should().Be(0);
            MathHelper.Zero360(0.234).Should().Be(0.234);
        }
    }
}