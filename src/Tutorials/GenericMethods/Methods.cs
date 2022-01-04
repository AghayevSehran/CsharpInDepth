using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    internal static class Methods
    {
        public static List<T> CopyAtMost<T>(
            List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);
            List<T> result = new List<T>(actualCount);
            for (int i = 0; i < actualCount; i++)
                result.Add(input[i]);
            return result;
        }
        public static void PrintItems<T>(List<T> items) where T : IFormattable
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString(null, culture));
            }
        }

    }
}
