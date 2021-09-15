using System;
using System.Collections.Generic;
using System.Text;

namespace OperatingSystemPlatform
{
    public abstract class OperatingSystem : IOperatingSystem
    {
        public OperatingSystem(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract string Print();
    }
}
