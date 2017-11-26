using System;
using System.Drawing;
using Xunit;
using Utilidades;

namespace PruebaXunit
{
    public class Class1
    {
      
        public Color color;

        [Fact]
        public void StringExtensionIsBlueAprimaryColorTest()
        {
            //Arrange
            String color = "Blue";

            //Act
            bool actual = color.IsPrimaryColor();

            //Arrange
            const bool expected = false;
            Assert.Equal(expected, actual);

        }
    }
}
