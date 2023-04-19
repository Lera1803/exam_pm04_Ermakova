using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value1 = "Валерия";
            string value2 = "Ермакова";
            string value3 = "+7-913-926-34-94";

            bool correct = true;
            bool actual = TestProject.Class1.Validation(value1, value2, value3);
            Assert.AreEqual(correct, actual);
        }
    }
}
