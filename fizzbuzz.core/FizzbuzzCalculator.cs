﻿namespace fizzbuzz.core
{
    public class FizzbuzzCalculator : IFizzbuzzCalculator
    {
        public string[] CallFizzbuzz(Dictionary<int, string> wordsWithNumbers)
        {
            string[] results = new string[10000001];
            for (var i = 1; i <= 10000000; i++)
            {
                foreach (var word in wordsWithNumbers)
                {
                    if (i % word.Key == 0)
                    {
                        results[i] += word.Value;
                    }
                }
                results[i] = (String.IsNullOrEmpty(results[i]) ? i.ToString() : results[i]);
            }
            return results;
        }
    }
}