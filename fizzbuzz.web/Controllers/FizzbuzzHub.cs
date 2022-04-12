using Microsoft.AspNetCore.SignalR;

namespace fizzbuzz.core
{
    public class FizzbuzzHub : Hub
    {
        private readonly FizzbuzzCalculator _fizzbuzzCalculator;
        public FizzbuzzHub(FizzbuzzCalculator fizzbuzzCalculator)
        {
            _fizzbuzzCalculator = fizzbuzzCalculator;
        }
        public async IAsyncEnumerable<string> SendFizzbuzzAsItIsDetermined(Dictionary<int, string> wordsWithNumbers)
        {
            for (int i = 0; i < 1000000; i++)
            {
                yield return _fizzbuzzCalculator.CallFizzbuzz(wordsWithNumbers, i).ToString();
                await Task.Delay(1000);
            }
        }
    }
}
