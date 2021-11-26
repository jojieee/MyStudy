using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++ )
            {
                
                for (int j = 0; j <= i; j++) 
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int s = 5; s >= 0; s--)
            {
                for(int e = 0; e <= s; e++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("반복 횟수를 입력하세요: ");
            int jo = int.Parse(Console.ReadLine());

            for (int i = 0; i < jo; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
