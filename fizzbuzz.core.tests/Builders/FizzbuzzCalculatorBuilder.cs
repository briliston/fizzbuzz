//using fizzbuzz.core.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace fizzbuzz.core.tests.Builders
//{
//    internal class FizzbuzzCalculatorBuilder
//    {
//        internal FizzbuzzParametersModel? parameters;

//        internal static FizzbuzzCalculator Build()
//        {
//            return new FizzbuzzCalculator();
//        }

//        internal FizzbuzzCalculatorBuilder WithDataFor_WordNumberPairs()
//        {
//            parameters = new FizzbuzzParametersModel
//            {
//                Total = 100,
//                Entries = new WordNumberPairModel[]
//                {
//                    new WordNumberPairModel { Word = "Foo", Divisor = 3 },
//                    new WordNumberPairModel { Word = "Bar", Divisor = 5 },
//                    new WordNumberPairModel { Word = "Bazz", Divisor = 7 },
//                    new WordNumberPairModel { Word = "Banana", Divisor = 11 }
//                },
//                ConnectionId = ""
//            };

//            return this;
//        }
//    }
//}
