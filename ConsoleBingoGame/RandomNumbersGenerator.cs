﻿using System;
using System.Collections.Generic;

namespace ConsoleBingoGame
{
    public class RandomNumbersGenerator : IRandomNumbersGenerator
    {
        Random random;

        public RandomNumbersGenerator()
        {
            random = new Random();
        }

        public List<int> GenerateDistinctRandomNumbers(IRange range, int quantity)
        {
            var numbers = new List<int>();

            while (numbers.Count < quantity)
            {
                var randomNumber = GetRandomNumber(range);
                AddToList(numbers, randomNumber);
            }

            return numbers;
        }

        private static void AddToList(List<int> numbers, int randomNumber)
        {
            if (!numbers.Contains(randomNumber))
            {
                numbers.Add(randomNumber);
            }
        }

        private int GetRandomNumber(IRange range)
        {
            return random.Next(range.GetStart(), range.GetEnd());
        }
    }
}
