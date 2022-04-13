using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz.core
{
    public class FizzbuzzService : IFizzbuzzService
    {
        private readonly IFizzbuzzCalculator _calculator;
        public FizzbuzzService(IFizzbuzzCalculator calculator)
        {
            _calculator = calculator;
        }

        public async IAsyncEnumerable<string> SendFizzbuzzAsItIsDetermined(Dictionary<string, int> wordsWithNumbers)
        {
            for (int i = 0; i < 1000000; i++)
            {
                yield return _calculator.CallFizzbuzz(wordsWithNumbers, i).ToString();
                await Task.Delay(1000);
            }
        }
    }

    public interface IFizzbuzzService
    {
        public IAsyncEnumerable<string> SendFizzbuzzAsItIsDetermined(Dictionary<string, int> wordsWithNumbers);
    }
}
