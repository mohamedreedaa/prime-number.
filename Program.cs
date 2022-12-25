using System;

namespace pime_number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter start numer");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("enter end number");
            int end = int.Parse(Console.ReadLine());
            for (int x =start ; x<=end ; x++)
            {
                for ( int y =1 ; y<=x ; y++)
                {
                    if (x % y == 0)
                        sum ++;
                }
                if (sum ==2)
                {
                    Console.WriteLine(x);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                    continue;
                }
            }
        }
    }
}
