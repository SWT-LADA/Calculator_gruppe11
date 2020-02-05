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

        [Test]
        public void Add_Add2and4_Return6()
        {
            Assert.That(calculator.Add(2, 4), Is.EqualTo(6));
        }

        [Test]
        public void Add_AddMinus2Andminus4_Returnminus6()
        {
            Assert.That(calculator.Add(-2,-4), Is.EqualTo(-6));
        }

        [Test]
        public void Subtract_2Minus4_ReturnMinus2()
        {
            Assert.That(calculator.Subtract(2,4), Is.EqualTo(-2));
        }

        [Test]
        public void Subtract_minus2minusMinus4_Return2()
        {
            Assert.That(calculator.Subtract(-2,-4), Is.EqualTo(2));
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