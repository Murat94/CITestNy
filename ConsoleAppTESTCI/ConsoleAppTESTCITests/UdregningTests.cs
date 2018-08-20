using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppTESTCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTESTCI.Tests
{
    [TestClass()]
    public class UdregningTests
    {
        [TestMethod()]
        public void addTest()
        {
            Udregning test1 = new Udregning();

         int acctual =   test1.add(4, 2);

            Assert.AreEqual(6, acctual);
        }

        [TestMethod()]
        public void addTestminus()
        {
            Udregning test2 = new Udregning();

            int acctual = test2.minus(4, 2);

            Assert.AreEqual(2, acctual);
        }
    }
}