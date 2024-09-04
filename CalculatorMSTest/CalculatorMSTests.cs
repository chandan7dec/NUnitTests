namespace Sparky
{
    [TestClass]
    public class CalculatorMSTests
    {
        Calculate calculate = new Calculate();
        [TestMethod]
        public void TestAdd()
        {
            
            double z = calculate.Add(10, 20);
            Assert.AreEqual(z, 30);
        }

        [TestMethod]
        public void Testsubtract()
        {

            double z = calculate.Substract(20, 20);
            Assert.AreEqual(z, 0);
        }
        [TestMethod]
        public void TestMultiply()
        {

            double z = calculate.multiply(10, 20);
            Assert.AreEqual(z, 200);
        }
        [TestMethod]
        public void TestDivide()
        {

            double z = calculate.Divide(20, 20);
            Assert.AreEqual(z, 1);
        }
    }
}