using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz.core
{
    public class FizzbuzzService : IFizzbuzzService
    {
        private readonly FizzbuzzCalculator _calculator;
        public FizzbuzzService(FizzbuzzCalculator calculator)
        {
            _calculator = calculator;
        }
        public void DetermineFizzbuzzValues(Dictionary<int, string> wordsWithNumbers)
        {
            var results = "";
            for (int i = 0; i < 1000000; i++)
            {
                results += _calculator.CallFizzbuzz(wordsWithNumbers, i).ToString();
            }

            //use signal r to get results to the front end
        }
    }

    public interface IFizzbuzzService
    {
        public void DetermineFizzbuzzValues(Dictionary<int, string> wordsWithNumbers);
    }
}
