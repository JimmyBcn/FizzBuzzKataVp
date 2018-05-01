using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzKataVp
{
    public static class FizzBuzzEngine
    {
        public static string Launch(List<IFizzBuzzSpecification> specsList, int range)
        {
            string result = string.Empty;

            for (int i = 1; i <= range; i++)
            {
                var validSpecs = specsList.Where(fb => fb.IsSpecifiedBy(i));

                if (!validSpecs.Any())
                {
                    result += i.ToString();
                }
                else
                {
                    foreach (var spec in validSpecs)
                    {
                        result += spec.Text;
                    }
                }

                result += " ";
            }

            return result.TrimEnd();
        }
    }
}