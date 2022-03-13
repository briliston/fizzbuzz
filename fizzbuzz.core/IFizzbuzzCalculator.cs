using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz.core
{
    public interface IFizzbuzzCalculator
    {
        public string[] CallFizzbuzz(Dictionary<int, string> wordsWithNumbers);
    }
}
