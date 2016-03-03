using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello_World_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World_Test.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetGreetingTest()
        {
            Assert.AreSame("Hello github!", Program.GetGreeting());
        }
    }
}