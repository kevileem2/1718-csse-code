using System;

namespace priemgetal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number under 100");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++) 
                {
                    if (i % j == 0) 
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && i > 1)
                {
                    Console.WriteLine ( "Prime:" + i );
                }
                // isPrime = true;
            }

        }
    }
}
