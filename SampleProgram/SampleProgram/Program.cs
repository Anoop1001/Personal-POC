using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SampleProgram
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B");
        }
    }

    class C:  B
    {
        public override void Print()
        {
            Console.WriteLine("C");
        }
    }
    class Program
    {
        /*
         * Input : 560
         * Output : 
         * 111
         * 222
         * 333
         * 444
         * 555
         * 
         * Input : 100<N<999
         * 
         */
        static void Main(string[] args)
        {
            int[] arr = new int[10] {1,2,3,4,5,6,7,8,8,9 };
            var groupedList = arr.GroupBy(x => x).Select(x => new { Key = x.Key, Count = x.Count() });
            var item = groupedList.First(x => x.Count == groupedList.Max(x => x.Count)).Key;
            Console.WriteLine(item);
        }

        /*
         * Input : 132568
         * Output : Error
         * 
         */
        private static void SecondProgram()
        {
            string input = String.Join("", Console.ReadLine().OrderBy(x=>x));
            int inc = 1;
            var missedNumbers = new List<int>();
            foreach(var c in input)
            {
                if(Convert.ToInt32(c.ToString()) != inc)
                {
                    missedNumbers.Add(inc);
                }
                inc++;
            }
            Console.WriteLine(missedNumbers.Count == 1 ? missedNumbers.First().ToString() : "Error"); 
        }

       
    }

    public class Animal
    {
        public virtual void SwitchProgram(string vehicle)
        {
            switch (vehicle)
            {
                case "Bike": { Console.WriteLine("Bike"); } break;
            }
        }
    }

    public class Elephant : Animal
    {
        public override void SwitchProgram(string s)
        {
            switch (s)
            {
                case "E": { Console.WriteLine("E"); } break;
            }
        }
    }
    public interface IdEmployee
    {
        public Guid Id { get; set; }
    }
    public interface IAddress
    {
        public string Address { get; set; }
    }
    public class Employee : IdEmployee, IAddress
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Guid Id { get; set; }
        public string Address { get; set; }


        public virtual int GetSalary(double d)
        {
            return 10;
        }
    }

    public class ContractEmployee : Employee
    {
        public override int GetSalary(double d)
        {
            return 100;
        }
    }
}
