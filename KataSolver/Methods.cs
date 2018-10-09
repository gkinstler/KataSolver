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


}
