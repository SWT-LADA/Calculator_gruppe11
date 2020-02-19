using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Uge5;
using NUnit.Framework;

namespace ClassLibrary1
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
        [TestCase(-2, -4, -6)]
        [TestCase(-2, 3, 1)]


        public void Add(double a, double b, double x)
        {
            Assert.That(calculator.Add(a, b), Is.EqualTo(x));
        }


        [TestCase(2, 4, -2)]
        [TestCase(-2, -4, 2)]
        [TestCase(-2, 3, -5)]


        public void Subtract(double a, double b, double x)
        {
            Assert.That(calculator.Subtract(a, b), Is.EqualTo(x));
        }


        [TestCase(2, 4, 8)]
        [TestCase(-2, -4, 8)]
        [TestCase(-2, 3, -6)]
        [TestCase(5, 0, 0)]


        public void Multiply(double a, double b, double res)
        {
            Assert.That(calculator.Multiply(a, b), Is.EqualTo(res));

        }


        [TestCase(2, 4, 16)]
        [TestCase(-4, -2, 0.0625)]
        [TestCase(3, -2, -8)]
        [TestCase(0, 5, 1)]
        [TestCase(1, 5, 5)]


        public void Power(double a, double b, double res)
        {
            Assert.That(calculator.Power(a, b), Is.EqualTo(res).Within(0.0001));
        }

        [Test]
        public void Accumulator_IsZero_ReturnZero()
        {
            Assert.That(calculator.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Accumulator_Add_ReturnFour()
        {
            calculator.Add(2, 2);

            Assert.That(calculator.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void Accumulator_SubstractAdd_ReturnFour()
        {
            calculator.Subtract(4, 2);
            calculator.Add(2, 2);

            Assert.That(calculator.Accumulator, Is.EqualTo(4));
        }

        [TestCase(2, 3, 3, 2, 6)]
        [TestCase(4, 1, -2, -2, 4)]
        [TestCase(2, 3, -1, 2, -2)]
        [TestCase(2, 3, -1, 2, -2)]

        public void Accumulator_MultiplyPower_ReturnEight(double a, double b, double c, double d, double res)
        {
            calculator.Power(a, b);
            calculator.Multiply(c, d);

            Assert.That(calculator.Accumulator, Is.EqualTo(res));
        }


        [Test]
        public void Clear_OneOperation_ReturnZero()
        {
            calculator.Add(2, 2);
            calculator.Clear();

            Assert.That(calculator.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_TwoOperations_ReturnZero()
        {
            calculator.Add(2, 2);
            calculator.Power(3, 2);
            calculator.Clear();

            Assert.That(calculator.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Clear_ThreeOperations_ReturnZero()
        {
            calculator.Add(2, 2);
            calculator.Power(3, 2);
            calculator.Multiply(2, 3);
            calculator.Clear();

            Assert.That(calculator.Accumulator, Is.EqualTo(0));
        }
    }
}
