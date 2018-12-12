using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }

            Console.WriteLine("\n Recursion Unfolding --- n = {0} ", n);

        }
        static void range(int start, int stop)
        /* Displays numbers between start and stop - start <= stop */
        {
            if (start == stop)
            {
                /* stopping condition - what needs to be done? */
                Console.WriteLine("\n End of range!");
            }
            else if (start - stop < 0)
            {
                /* recursive call and print start*/
                Console.WriteLine(" x = {0} ", start);
                range(start + 1, stop);
            }
            else
            {
                /* recursive call and print start*/
                Console.WriteLine(" x = {0} ", start);
                range(start - 1, stop);
            }
        }

        static string getNumberString(int n)
        {

            if (n == 0)
                return "End";
            else
            {
                return "" + n;
            }
        }

        static int getMultiply(int n1, int n2)
        {
            if (n2 == 1)
            {
                return n1;
            }
            else
            {
                return n1 + getMultiply(n1, dec(n2));
           }

        }

        static int power(int n1, int n2)
        {
            if (n2 == 1)
            {
                return n1;
            }
            else
            {
                return n1 * power(n1, dec(n2));
            }
        }

        static int inc(int x)
        {
            return x + 1;
        }
        static int dec(int x)
        {
            return x - 1;
        }

        static void Main(string[] args)
        {
            //printNumbers(5);
            //range(5, 10);
            //Console.WriteLine(getNumberString(5));
            //Console.WriteLine(getMultiply(5, 5));
            Console.WriteLine(power(5, 3));
            //Console.WriteLine("{0}", dec(dec(10)));
            //Console.WriteLine("{0}", inc(inc(inc(inc(2)))));

            Console.ReadLine();
        }
    }
}
