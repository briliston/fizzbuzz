namespace fizzbuzz.core
{
    public class FizzbuzzCalculator : IFizzbuzzCalculator
    {
        public string CallFizzbuzz(Dictionary<string, int> wordsWithNumbers, int i)
        {
            var result = "";
            foreach (var word in wordsWithNumbers)
            {
                if (i % word.Value == 0)
                {
                    result += word.Key;
                }
            }
            return string.IsNullOrEmpty(result) ? i.ToString() : result;
        }
    }

    public interface IFizzbuzzCalculator
    {
        string CallFizzbuzz(Dictionary<string, int> wordsWithNumbers, int i);
    }
}