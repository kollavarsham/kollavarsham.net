using FluentAssertions;
using FluentAssertions.Numeric;

namespace Kollavarsham.Net.Tests
{
    public static class NumericAssertionsExtensions
    {
        public static AndConstraint<NumericAssertions<double>> BeCloseTo(this NumericAssertions<double> parent,
            double nearbyValue, double delta, string because = "", params object[] becauseArgs)
        {
            return parent.BeInRange(nearbyValue - delta, nearbyValue + delta, because, becauseArgs);
        }
    }
}