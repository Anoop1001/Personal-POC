using System;

namespace OperatingSystemPlatform
{
    public class AndroidOperatingSystem : OperatingSystem
    {
        public AndroidOperatingSystem(string name) : base(name)
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
