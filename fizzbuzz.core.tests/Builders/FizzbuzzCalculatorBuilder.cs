using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz.core.tests.Builders
{
    internal class FizzbuzzCalculatorBuilder
    {
        internal Dictionary<int, string> wordsAndNumbers;
        internal FizzbuzzCalculatorBuilder()
        {

        }

        internal FizzbuzzCalculator Build()
        {
            return new FizzbuzzCalculator();
        }

        internal FizzbuzzCalculatorBuilder WithDataFor_WordNumberPairs()
        {
            wordsAndNumbers = new Dictionary<int, string>
            {
                { 3, "Foo" },
                { 5, "Bar" },
                { 7, "Bazz" },
                { 11, "Banana" }
            };

            return this;
        }
    }
}
