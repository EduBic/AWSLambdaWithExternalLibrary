using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DomainCoreLibrary;

namespace DomainCoreLibrary.Tests
{
    public class UtilityTest
    {
        [Fact]
        public void ShouldCompute()
        {
            double res = Utility.compute();
            Console.WriteLine(res);

        }
    }
}
