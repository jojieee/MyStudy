using System;
using static System.Console;

namespace StringFormaBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0, -20}{1, -15}{2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            WriteLine(fmt, "Prentice", "K&R", "The C Programming Language");
        }
    }
}
