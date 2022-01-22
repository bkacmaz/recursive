using System;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Re(0);
            Console.WriteLine("Hello World!");

            int Re (int i)
            {
                i++;
                if (i < 5)
                {
                    Re(i);
                }
                return i;
            }

        }
    }
}
