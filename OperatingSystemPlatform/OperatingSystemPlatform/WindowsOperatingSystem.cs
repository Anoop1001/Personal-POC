using System;

namespace OperatingSystemPlatform
{
    public class WindowsOperatingSystem : OperatingSystem
    {
        public WindowsOperatingSystem(string name) : base(name)
        {

        }
        public override string Print()
        {
            string toPrint = $"Hi, I am from {Name}";
            Console.WriteLine(toPrint);
            return toPrint;
        }
    }
}
