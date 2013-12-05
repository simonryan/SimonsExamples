using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EasyKatas.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Number_divisible_by_3()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.DivisableByThree(6);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Number_not_divisible_by_3()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.DivisableByThree(7);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Number_divisible_by_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.DivisableByFive(10);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Number_not_divisible_by_11()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.DivisableByFive(11);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Number_divisible_by_3_and_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.DivisableByFive(15) && fizzBuzz.DivisableByThree(15);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Zero_not_divisible_by_3_and_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.DivisableByFive(0) && fizzBuzz.DivisableByThree(0);
            Assert.That(result, Is.False);
        }
        [Test]
        public void Number_not_divisible_by_3_and_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.DivisableByFive(10) && fizzBuzz.DivisableByThree(10);
            Assert.That(result, Is.False);
        }
    }
}
