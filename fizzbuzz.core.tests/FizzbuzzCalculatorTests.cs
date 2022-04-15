//using fizzbuzz.core.tests.Builders;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;

//namespace fizzbuzz.core.tests
//{
//    [TestClass]
//    public class FizzbuzzCalculatorTests
//    {
//        [TestMethod]
//        public void DivisibleBy3()
//        {
//            var builder = new FizzbuzzCalculatorBuilder()
//                .WithDataFor_WordNumberPairs();

//            var fizzbuzzCalculator = FizzbuzzCalculatorBuilder.Build();

//            var result = fizzbuzzCalculator.DetermineFizzbuzz(builder.wordsAndNumbers, 3);

//            Assert.IsNotNull(result);
//            Assert.AreEqual("Foo", result);
//        }

//        [TestMethod]
//        public void DivisibleBy5()
//        {
//            var builder = new FizzbuzzCalculatorBuilder()
//                .WithDataFor_WordNumberPairs();

//            var fizzbuzzCalculator = FizzbuzzCalculatorBuilder.Build();

//            var result = fizzbuzzCalculator.DetermineFizzbuzz(builder.wordsAndNumbers, 40);

//            Assert.IsNotNull(result);
//            Assert.AreEqual("Bar", result);
//        }

//        [TestMethod]
//        public void DivisibleBy7()
//        {
//            var builder = new FizzbuzzCalculatorBuilder()
//                .WithDataFor_WordNumberPairs();

//            var fizzbuzzCalculator = FizzbuzzCalculatorBuilder.Build();

//            var result = fizzbuzzCalculator.DetermineFizzbuzz(builder.wordsAndNumbers, 49);

//            Assert.IsNotNull(result);
//            Assert.AreEqual("Bazz", result);
//        }

//        [TestMethod]
//        public void DivisibleBy11()
//        {
//            var builder = new FizzbuzzCalculatorBuilder()
//                .WithDataFor_WordNumberPairs();

//            var fizzbuzzCalculator = FizzbuzzCalculatorBuilder.Build();

//            var result = fizzbuzzCalculator.DetermineFizzbuzz(builder.wordsAndNumbers, 44);

//            Assert.IsNotNull(result);
//            Assert.AreEqual("Banana", result);
//        }

//        [TestMethod]
//        public void DivisibleBy3And5()
//        {
//            var builder = new FizzbuzzCalculatorBuilder()
//                .WithDataFor_WordNumberPairs();

//            var fizzbuzzCalculator = FizzbuzzCalculatorBuilder.Build();

//            var result = fizzbuzzCalculator.DetermineFizzbuzz(builder.wordsAndNumbers, 30);

//            Assert.IsNotNull(result);
//            Assert.AreEqual("FooBar", result);
//        }

//        [TestMethod]
//        public void NotDivisableByKeyInDictionary()
//        {
//            var builder = new FizzbuzzCalculatorBuilder()
//                .WithDataFor_WordNumberPairs();

//            var fizzbuzzCalculator = FizzbuzzCalculatorBuilder.Build();

//            var result = fizzbuzzCalculator.DetermineFizzbuzz(builder.wordsAndNumbers, 34);

//            Assert.IsNotNull(result);
//            Assert.AreEqual("34", result);
//        }
//    }
//}