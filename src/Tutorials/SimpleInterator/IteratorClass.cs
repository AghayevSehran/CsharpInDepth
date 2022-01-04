using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterator
{
    internal class IteratorClass
    {
        public static IEnumerable<int> CreateSimpleIterator()
        {
            yield return 10;
            for (int i = 0; i < 3; i++)
            {
                yield return i;
            }
            yield return 20;
        }

        public static IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                yield return current;
                int oldCurrent = current;
                current = next;
                next = next + oldCurrent;

            }

        }
        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1, c;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
        public int FinonacciNumber(int n)
        {
            if (n > 2) return FinonacciNumber(n - 1) + FinonacciNumber(n - 2);
            else return n;
        }
        public int Factorial(int n)
        {
            if (n > 1) return n * Factorial(n - 1);
            return 1;
        }
        public void Factoriall(int num)
        {
            int n = 0;
            while (num > 0)
            {
                n = num;
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                Console.WriteLine("Factorial of {0}! = {1}\n", num, n);
                num--;
            }
        }

        public static IEnumerable<string> ReadLines(string path)
        {
            using (TextReader reader = File.OpenText(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }


    }
}
