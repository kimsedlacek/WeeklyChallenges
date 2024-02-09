using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            { return true; }
            else 
            { return false; }
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            { return true; }
            else
            { return false; }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            { return true; }
            else { return false; }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            { return true; }
            else { return false; }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null)
            { return numbers.DefaultIfEmpty().Min() + numbers.DefaultIfEmpty().Max(); }
            //else if (numbers == null)
            //{ return 0; }
            else { return 0; }

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int firstStr = str1.Length;
            int secondStr = str2.Length;

            if (firstStr < secondStr)
            { return firstStr; }
            else if (firstStr > secondStr)
            { return secondStr; }
            else return firstStr;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            { return 0; }
            int sumTotal = 0;
            foreach (var num in numbers)
            { sumTotal += num; }
            return sumTotal;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            { return 0; }
            int evenNums = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                { evenNums += num; }
            }
            return evenNums;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { return false; }
            var total = numbers.Sum();
            if (total % 2 != 0)
            { return true; }
            else { return false; }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //how many positive odd numbers exist between the given number and zero
            if (number >= 0)
            { return number / 2; }
            else { return 0; }
        }
    }
}

