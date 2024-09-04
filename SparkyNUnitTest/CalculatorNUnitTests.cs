using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculate calc = new();

            //Act
            double result = calc.Add(10, 20);

            //Assert
            ClassicAssert.AreEqual(result, 30);

        }


        [Test]
        //[TestCase(5.4, 10.5)]
        public void OddRanger_InputMinAndMaxRange_ReturnValidOddNumebrsRange()
        {
            Calculate calc = new();
            List<int> expectedOddRange = new() { 5, 7, 9 };

            //act
            List<int> result = calc.GetOddRange(5, 10);

            //Assert
            ClassicAssert.That(result, Is.EquivalentTo(expectedOddRange));
            ClassicAssert.AreEqual(expectedOddRange, result);


        }
    }

    
}
