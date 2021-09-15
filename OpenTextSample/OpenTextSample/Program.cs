using System;
using System.Threading.Tasks;

namespace OpenTextSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = "A", s = "B";
            GenericSystem.Swap(ref f, ref s);
            Console.WriteLine($"f = { f} s = {s}");

            int fI = 10, sI = 20;
            GenericSystem.Swap(ref fI, ref sI);
            Console.WriteLine($"f = { fI} s = {sI}");
        }
    }

    class GenericSystem
    {
        public static void Swap<T>(ref T first, ref  T second)
        {
            var sum = first;
            first = second;
            second = sum;
        }

        public async Task Run()
        {
            var checkIfExists = await CheckIfExistsInDB(10);
            if(checkIfExists)
            {
                Console.WriteLine("Exists Here");
            }
            RunIndependentThread();
        }

        public async Task<bool> CheckIfExistsInDB(int id)
        {
            return await Task.FromResult(true);
        }

        public async Task<bool> RunIndependentThread()
        {
            return await Task.FromResult(true);
        }
    }
}
