using System;
using static System.Console;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "조지원";
            int age = 29;
            WriteLine($"{name,-10}, {age:D3}");

            name = "조지원";
            age = 29;
            WriteLine($"{name}, {(age > 30 ? "아저씨네" : "아직어리네")}");
            
        }
    }
}
