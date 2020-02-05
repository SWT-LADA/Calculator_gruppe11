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


        [Test]
        public void Multiply_2and4_Return8()
        {
            Assert.That(calculator.Multiply(2,4), Is.EqualTo(8));
        }

        [Test]
        public void Multiply_minus2andminus4_8()
        {
            Assert.That(calculator.Multiply(-2,-4), Is.EqualTo(8));
        }

        [Test]
        public void Power_4opi2_Return16()
        {
            Assert.That(calculator.Power(2,4), Is.EqualTo(16));
        }


    }
}