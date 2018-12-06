using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class PwnedPasswordTest
    {
        ValidationManager vM = new ValidationManager();

        [TestMethod]
        public void TestMethod1()
        {
            Task<bool> actual = vM.IsPasswordSafe("password123");
            bool expected = true;
            
            Console.WriteLine("Actaul Result: " + actual);
            
            Assert.AreEqual(expected, actual.Result);

        }
    }
}
