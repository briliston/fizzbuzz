using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz.core.tests.Builders
{
    internal class FizzbuzzCalculatorBuilder
    {
        internal Dictionary<string, int> wordsAndNumbers;
        internal FizzbuzzCalculatorBuilder()
        {

        }

        internal FizzbuzzCalculator Build()
        {
            return new FizzbuzzCalculator();
        }

        internal FizzbuzzCalculatorBuilder WithDataFor_WordNumberPairs()
        {
            wordsAndNumbers = new Dictionary<string, int>
            {
                { "Foo", 3 },
                { "Bar", 5 },
                { "Bazz", 7 },
                { "Banana", 11 }
            };

            return this;
        }
    }
}
