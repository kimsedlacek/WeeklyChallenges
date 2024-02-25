using System;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null)
                return false;

            StringComparison comparison = ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;

            return words.Any(w => string.Equals(w, word, comparison));
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            int squareRoot = (int)Math.Sqrt(num);
            for (int i = 2; i <= squareRoot; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }
            Dictionary<char, int> lastIndexMap = new Dictionary<char, int>();
            HashSet<char> uniqueCharacters = new HashSet<char>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];
                if (lastIndexMap.ContainsKey(currentChar))
                {
                    lastIndexMap[currentChar] = i;
                    uniqueCharacters.Remove(currentChar);
                }
                else
                {
                    lastIndexMap.Add(currentChar, i);
                    uniqueCharacters.Add(currentChar);
                }
            }
            if (uniqueCharacters.Count == 0)
                return -1;
            if (uniqueCharacters.Count == 2 && str[0] != str[1])
                return 1;

            if (uniqueCharacters.Contains(str[0]))
                return 0;

            int lastUniqueIndex = -1;
            foreach (var character in uniqueCharacters)
            {
                if (lastIndexMap[character] > lastUniqueIndex)
                    lastUniqueIndex = lastIndexMap[character];
            }

            return lastUniqueIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int maxRepetitions = 0;
            int currentRepetitions = 1;
            for (int i=1; i<numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentRepetitions++;
                }
                else
                {
                    maxRepetitions = Math.Max(maxRepetitions, currentRepetitions);
                    currentRepetitions = 1;
                }
            }
            maxRepetitions = Math.Max(maxRepetitions, currentRepetitions);
            return maxRepetitions;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }
            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
                

            









