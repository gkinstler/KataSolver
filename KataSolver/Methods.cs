using System;
using System.Collections.Generic;
using System.Text;

namespace KataSolver
{
    public class BasicMathOps
    {
        public double BasicMathOpsTests(char operation, double value1, double value2)
        {
            if (operation == '+')
            {
                return value1 + value2;
            }

            else if (operation == '-')
            {
                return value1 - value2;
            }

            else if (operation == '*')
            {
                return value1 * value2;
            }

            else if (operation == '/')
            {
                return value1 / value2;
            }

            else
            {
                return 0;
            }

        }
    }

    public class CenturyFromYear
    {
        public static int СenturyFromYearTests(int year)
        {
            int century = year / 100;

            if (year % 100 == 0)
            {
                return century;
            }
            else
            {
                return century + 1;
            }
        }
    }

    public class EvenOrOdd
    { 
        public static string EvenOrOddTests(int number)
        {
            if (number == 0)
            {
                return "Even";
            }
            else if (number % 2 == 0)
            {
                return "Even";
            }
            return "Odd";
        }
    }

    public class MakeNegative
    {
        public static int MakeNegativeTests(int number)
        {
            int negNum = number * -1;

            if (number < 0)
            {
                return number;
            }
            else
            {
                return negNum;
            }
        }
        
    }

    public class DNAtoRNA
    {
        public static string DNAtoRNATests(string dna)
        {
            string RNA = dna.Replace('T', 'U');
            return (string)RNA;
        }
   
    }

    public class BonusTime
    {
        public static string Bonus_Time_Tests(int salary, bool bonus)
        {
            int SalaryWithBonus = salary * 10;
            string strSalaryWithBonus = SalaryWithBonus.ToString();

            if (bonus == true)
            {
                return ("$" + strSalaryWithBonus);
            }

            return ("$" + salary);
        }
    }

    public class RepeatString
    {
        public static string repeatStrTests(int n, string s)
        {
            string result = s;

            while (n > 1) { result = result + s; n--; }

            return result;
        }
    }

    public class GrasshopperSummation
    {
        public static int SummationTests(int num)
        {
            int answer = 0;

            for (int i = 0; i <= num; i++)
            {
                answer += i;
            }

            return answer;
        }
    }


    public class Multiplesof3and5
    {
        public static int MultiplesOf3and5_Tests(int value)
        {
            // no clue!!
            return value;
        }
    }

    public class FormatWordsIntoASentence
    {
        public static string FormatWordsIntoASentence_Tests(string words)
        {
            // no clue!!
            string newString = words;
            return newString;
        }
    }

    public class SplitStrings
    {
        public static string SplitStrings_Tests(string str)
        {
            // no clue!
            string answer = str;
            return answer;
        }
    }

    public class ThrowingDarts
    {
        public static int ThrowingDarts_Tests(int throw1, int throw2, int throw3)
        {
            // no clue!
            int total = 0;
            total = throw1 + throw2 + throw3;
            return total;
        }
    }

}
