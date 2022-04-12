namespace fizzbuzz.core
{
    public class FizzbuzzCalculator : IFizzbuzzCalculator
    {
        public string CallFizzbuzz(Dictionary<int, string> wordsWithNumbers, int i)
        {
            var result = "";
            foreach (var word in wordsWithNumbers)
            {
                if (i % word.Key == 0)
                {
                    result += word.Value;
                }
            }
            return string.IsNullOrEmpty(result) ? i.ToString() : result;
        }
    }

    public interface IFizzbuzzCalculator
    {
        string CallFizzbuzz(Dictionary<int, string> wordsWithNumbers, int i);
    }
}