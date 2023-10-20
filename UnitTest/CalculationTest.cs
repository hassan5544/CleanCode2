using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode2;

namespace UnitTest
{
    public class CalculationTest
    {
        [Theory]
        [InlineData(5, 25)]
        [InlineData(2, 4)]
        [InlineData(0,0)]
        public void CalculateSquareTest(int number, int Expected)
        {
            //Act
            int acutal = Calculation.CalculateSquare(number);

            //Assert
            Assert.Equal(Expected, acutal);
        }
    }
}
