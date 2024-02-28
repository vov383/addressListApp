using addressListApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace addressListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Form1 f1 = new Form1();
            // Act
            f1.selectAll();
            // Assert

        }
    }
}
