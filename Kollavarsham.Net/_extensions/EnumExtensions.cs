using System;
using System.Collections.Generic;
using System.Linq;

namespace Kollavarsham.Net
{
    public static class EnumExtensions
    {
        public static Dictionary<int, string> ToDictionary(this Enum @enum)
        {
            var type = @enum.GetType();
            return Enum.GetValues(type).Cast<int>().ToDictionary(e => e, e => Enum.GetName(type, e));
        }        
    }
}