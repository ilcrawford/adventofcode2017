using System;

namespace adventofcode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdventCmd day = new Day1();
            Console.WriteLine("Day1");
            day.doDay();
            Console.WriteLine("Day2");
            day = new Day2();
            day.doDay();
            //Console.Read();
        }
    }
}
