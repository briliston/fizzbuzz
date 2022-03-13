using fizzbuzz.core.tests.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace fizzbuzz.core.tests
{
    [TestClass]
    public class FizzbuzzCalculatorTests
    {
        [TestMethod]
        public void DivisibleBy3()
        {
            var builder = new FizzbuzzCalculatorBuilder()
                .WithDataFor_WordNumberPairs();

            var fizzbuzzCalculator = builder.Build();

            var results = fizzbuzzCalculator.CallFizzbuzz(builder.wordsAndNumbers);

            Assert.IsNotNull(results);
            Assert.AreEqual("Foo", results[3]);
            Assert.AreEqual("Foo", results[27]);
        }

        [TestMethod]
        public void DivisibleBy5()
        {
            var builder = new FizzbuzzCalculatorBuilder()
                .WithDataFor_WordNumberPairs();

            var fizzbuzzCalculator = builder.Build();

            var results = fizzbuzzCalculator.CallFizzbuzz(builder.wordsAndNumbers);

            Assert.IsNotNull(results);
            Assert.AreEqual("Bar", results[5]);
            Assert.AreEqual("Bar", results[40]);
        }

        [TestMethod]
        public void DivisibleBy7()
        {
            var builder = new FizzbuzzCalculatorBuilder()
                .WithDataFor_WordNumberPairs();

            var fizzbuzzCalculator = builder.Build();

            var results = fizzbuzzCalculator.CallFizzbuzz(builder.wordsAndNumbers);

            Assert.IsNotNull(results);
            Assert.AreEqual("Bazz", results[7]);
            Assert.AreEqual("Bazz", results[49]);
        }

        [TestMethod]
        public void DivisibleBy11()
        {
            var builder = new FizzbuzzCalculatorBuilder()
                .WithDataFor_WordNumberPairs();

            var fizzbuzzCalculator = builder.Build();

            var results = fizzbuzzCalculator.CallFizzbuzz(builder.wordsAndNumbers);

            Assert.IsNotNull(results);
            Assert.AreEqual("Banana", results[11]);
            Assert.AreEqual("Banana", results[44]);
        }

        [TestMethod]
        public void DivisibleBy3And5()
        {
            var builder = new FizzbuzzCalculatorBuilder()
                .WithDataFor_WordNumberPairs();

            var fizzbuzzCalculator = builder.Build();

            var results = fizzbuzzCalculator.CallFizzbuzz(builder.wordsAndNumbers);

            Assert.IsNotNull(results);
            Assert.AreEqual("FooBar", results[30]);
            Assert.AreEqual("FooBar", results[60]);
        }

        [TestMethod]
        public void NotDivisableByKeyInDictionary()
        {
            var builder = new FizzbuzzCalculatorBuilder()
                .WithDataFor_WordNumberPairs();

            var fizzbuzzCalculator = builder.Build();

            var results = fizzbuzzCalculator.CallFizzbuzz(builder.wordsAndNumbers);

            Assert.IsNotNull(results);
            Assert.AreEqual("8", results[8]);
            Assert.AreEqual("34", results[34]);
        }
    }
}