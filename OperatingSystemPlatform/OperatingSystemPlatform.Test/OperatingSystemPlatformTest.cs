using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace OperatingSystemPlatform.Test
{
    [TestFixture]
    public class OperatingSystemPlatformTest
    {
        [Test]
        public void Test(string os)
        {
            var sys = new WindowsOperatingSystem(os);
            sys.Print();
        }
    }
}
