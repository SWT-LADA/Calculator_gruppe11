using System.Runtime.CompilerServices;
using Calculator_Uge5;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class Tests
    {

        private Calculator calculator;

        [SetUp]

        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(2, 4, 6)]
        [TestCase(-2,-4,-6)]


        public void Add(double a, double b, double x)
        {
            Assert.That(calculator.Add(a, b), Is.EqualTo(x));
        }


        [TestCase(2, 4, -2)]
        [TestCase(-2, -4, 2)]


        public void Subtract(double a, double b, double x)
        {
            Assert.That(calculator.Subtract(a, b), Is.EqualTo(x));
        }


        [TestCase(2,5,10)]
        [TestCase(5,7,35)]
        public void Multiply(double a, double b, double res)
        {
            Assert.That(calculator.Multiply(a, b), Is.EqualTo(res));

        }

        [Test]
        public void Power_4opi2_Return16()
        {
            Assert.That(calculator.Power(2,4), Is.EqualTo(16));
        }


    }
}