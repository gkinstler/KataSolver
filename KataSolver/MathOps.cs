using System;
using System.Collections.Generic;
using System.Text;

namespace KataSolver
{
    public class MathOps
    {
        public double BasicOps(char operation, double value1, double value2)
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
}
