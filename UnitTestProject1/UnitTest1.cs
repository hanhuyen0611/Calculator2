using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddOperator()
        {
            Calculator1 c = new Calculator1(10, 5);
            ketQua = c.Exectute("+");

        }

    }
}
