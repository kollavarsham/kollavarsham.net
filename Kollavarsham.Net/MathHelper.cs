using System;

namespace Kollavarsham.Net
{
    public static class MathHelper
    {
        public static double Epsilon { get; } = 1e-8;

        public static double RadianInDegrees { get; } = 180 / Math.PI;

        public static bool IsNumber(string n)
        {
            return double.TryParse(n, out _);
        }

        public static bool IsInt(string n)
        {
            return int.TryParse(n, out _);
        }

        public static bool IsInt(double n)
        {
            return Math.Abs(n % 1) <= double.Epsilon * 100;
        }

        public static double TruncateDecimals(string num, int digits)
        {
            return IsNumber(num) ? TruncateDecimals(double.Parse(num), digits) : 0;
        }

        public static double TruncateDecimals(double num, int digits)
        {
            // https://stackoverflow.com/a/3143691/218882
            var digitInTens = Math.Pow(10, digits);
            return Math.Truncate(digitInTens * num) / digitInTens;
        }

        public static int Truncate(string n)
        {
            return IsNumber(n) ? Truncate(double.Parse(n)) : 0;
        }

        public static int Truncate(double n)
        {
            return (int) TruncateDecimals(n, 0);
        }

        public static int Floor(string n)
        {
            return IsNumber(n) ? Floor(double.Parse(n)) : 0;
        }

        public static int Floor(double n)
        {
            return (int) Math.Floor(n);
        }

        public static double Fractional(string n)
        {
            return IsNumber(n) ? Fractional(double.Parse(n)) : 0;
        }

        public static double Fractional(double n)
        {
            return n % 1;
        }

        public static int Round(string n)
        {
            return IsNumber(n) ? Round(double.Parse(n)) : 0;
        }

        public static int Round(double n)
        {
            return Floor(n + 0.5);
        }

        public static double Square(string n)
        {
            return IsNumber(n) ? Square(double.Parse(n)) : 0;
        }

        public static double Square(double n)
        {
            return Math.Pow(n, 2);
        }

        public static double Zero360(double angleInDegrees)
        {
            var result = angleInDegrees - Truncate(angleInDegrees / 360) * 360;

            return result < 0 ? 360 + result : result;
        }
    }
}