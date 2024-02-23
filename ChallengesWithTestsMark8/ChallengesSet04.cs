using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int even = 0;
            int odd = 0;
            
            foreach(int num in numbers)
            {
                if (num %2 == 0)
                {
                    even += num;
                }
            }
            foreach(int oddnum in numbers)
            {
                if (oddnum %2 != 0)
                { odd += oddnum; }
            }
            return  even - odd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            int length3 = str3.Length;
            int length4 = str4.Length;
            int minLength = Math.Min(length1, Math.Min(length2, Math.Min(length3, length4)));
            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int minNum = Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
            return minNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength3 + sideLength1 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            bool num = double.TryParse(input, out double number);
            return num;
                
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            if (count >= majority)
            {
                return true;
            }
            else return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;
            if (numbers == null  || numbers.Length == 0)
            {
                return 0;
            }
            foreach(var num in numbers)
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            if (count > 0)
            {
                return sum / count;
            }
            else return 0;
        }

        public int Factorial(int number)
        {
            var fact = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for(int i = number; i>0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
