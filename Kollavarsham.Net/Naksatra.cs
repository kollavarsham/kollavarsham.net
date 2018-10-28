using System;
using System.Collections.Generic;

namespace Kollavarsham.Net
{
    public sealed class Naksatra
    {
        private static IReadOnlyDictionary<int, string> SakaNaksatras => SakaNaksatra.Asvini.ToDictionary();
        private static IReadOnlyDictionary<int, string> EnMalayalamNaksatras => MalayalaNaksatra.Ashwathi.ToDictionary();
        private static IReadOnlyDictionary<int, string> MlMalayalaNaksatras => new Dictionary<int, string>
        {
            [0] = "അശ്വതി",
            [1] = "ഭരണി",
            [2] = "കാർത്തിക",
            [3] = "രോഹിണി",
            [4] = "മകയിരം",
            [5] = "തിരുവാതിര",
            [6] = "പുണർതം",
            [7] = "പൂയം",
            [8] = "ആയില്യം",
            [9] = "മകം",
            [10] = "പൂരം",
            [11] = "ഉത്രം",
            [12] = "അത്തം",
            [13] = "ചിത്ര",
            [14] = "ചോതി",
            [15] = "വിശാഖം",
            [16] = "അനിഴം",
            [17] = "തൃക്കേട്ട",
            [18] = "മൂലം",
            [19] = "പൂരാടം",
            [20] = "ഉത്രാടം",
            [21] = "തിരുവോണം",
            [22] = "അവിട്ടം",
            [23] = "ചതയം",
            [24] = "പൂരുരുട്ടാതി",
            [25] = "ഉത്രട്ടാതി",
            [26] = "രേവതി"
        };

        public Naksatra(int naksatra)
        {
            if (naksatra < 0 || naksatra > 27)
            {
                throw new ArgumentOutOfRangeException();
            }

            Saka = SakaNaksatras[naksatra];
            EnNaksatra = EnMalayalamNaksatras[naksatra];
            MlNaksatra = MlMalayalaNaksatras[naksatra];
        }

        public string Saka { get; }
        public string EnNaksatra { get; }
        public string MlNaksatra { get; }
    }
}