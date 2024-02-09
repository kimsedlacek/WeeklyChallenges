using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            foreach(var tOrF in vals)
            {
                 
                if (tOrF == false)
                {
                    return true;
                }
            }
                 return false; 
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            { return false; }
            else if (numbers.Sum() % 2 != 0)
            { return true; }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit))
                { return true; };
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            { return 0; }
            else return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddsUnder100 = new List<int>();
            for (int i = 1; i < 100; i+= 2)
            { oddsUnder100.Add(i); }
            return oddsUnder100.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                { words[i] = words[i].ToUpper(); }
                
            }
        }
    }
}
