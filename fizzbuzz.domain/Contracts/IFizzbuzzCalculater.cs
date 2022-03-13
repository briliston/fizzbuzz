using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz.domain.Contracts
{
    public interface IFizzbuzzCalculater
    {
        public string[] CallFizzbuzz(Dictionary<int, string> wordsWithNumbers);
    }
}
