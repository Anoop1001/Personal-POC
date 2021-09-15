using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatingSystemPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfString = new List<string> { "Abc", "Def", "AA" };
            Console.WriteLine(string.Join(", " , listOfString.Where(x=>x.StartsWith("A"))));
        }
    }
}
