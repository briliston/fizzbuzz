namespace fizzbuzz.core
{
    public class FizzbuzzCalculator : IFizzbuzzCalculator
    {
        public IEnumerable<string> CallFizzbuzz(Dictionary<int, string> wordsWithNumbers, int i)
        {
            var result = "";
            foreach (var word in wordsWithNumbers)
            {
                if (i % word.Key == 0)
                {
                    result = word.Value;
                }
            }
            result = string.IsNullOrEmpty(result) ? i.ToString() : result;
            
            yield return result;
        }
    }

    public interface IFizzbuzzCalculator
    {
        IEnumerable<string> CallFizzbuzz(Dictionary<int, string> wordsWithNumbers, int i);
    }
}