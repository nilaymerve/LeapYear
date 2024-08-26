using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYears
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*In this kata you should simply determine, whether a given year is a leap year or not. In case you don't know the rules, here they are;
            Years divisible by 4 are leap years,
but years divisible by 100 are not leap years,
but years divisible by 400 are leap years.
Tested years are in range 1600 ≤ year ≤ 4000.*/
            int year = 2001;
            Console.WriteLine(year + " is a leap year:" + IsLeapYear(year));
        }
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

