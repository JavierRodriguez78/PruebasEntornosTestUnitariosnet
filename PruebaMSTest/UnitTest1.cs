using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilidades;

namespace PruebaMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                //Arrange
                String color = "Blue";

                //Act
                bool actual = color.IsPrimaryColor();

                //Arrange
                const bool expected = false;
                Assert.Equals(expected, actual);

            }
        }
    }
}
