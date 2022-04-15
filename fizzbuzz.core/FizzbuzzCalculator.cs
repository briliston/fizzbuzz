using fizzbuzz.core.Models;

namespace fizzbuzz.core
{
    public class FizzbuzzCalculator
    {
        public static IEnumerable<string> DetermineFizzbuzz(FizzbuzzParametersModel parameters)
        {
            for (int i = 1; i < parameters.Total; i++)
            {
                var result = "";
                foreach (var entry in parameters.Entries!)
                {
                    if (i % entry.Divisor == 0)
                        result += entry.Word;
                }
                yield return string.IsNullOrEmpty(result) ? i.ToString() : result;
            }
        }
    }
}