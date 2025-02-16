using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_DEMO
{
    internal static class IntExtensions
    {
        public static int Reverse(this int numbers)
        {
            int reversenumber = 0, remainder;
            while (numbers != 0)
            {
                remainder = numbers % 10;
                reversenumber = reversenumber * 10 + remainder;
                numbers = numbers / 10;

            }
            return reversenumber;
        }
        public static long Reverse(this long numbers)
        {
            long reversenumber = 0, remainder;
            while (numbers != 0)
            {
                remainder = numbers % 10;
                reversenumber = reversenumber * 10 + remainder;
                numbers = numbers / 10;

            }
            return reversenumber;
        }
    }
}