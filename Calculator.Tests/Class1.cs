using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio;
using NUnit.Compatibility;
using NUnit.Framework;
using Calculator;

namespace Calculator.Tests
{
    [TestFixture]
    public class Class1
    {
        CalculatorClass calc = new CalculatorClass(20, 10);

        [Test]
        public void AdditionalMethodMustReturn30()
        {
            Assert.AreEqual(30, calc.Additional()); //Are.Equal утверждает, что два значения равны (bool).
        }

        [Test]
        public void SubstractionMethodMustReturn10()
        {
            Assert.AreEqual(10, calc.Subtraction());
        }
        
        [Test]
        public void MultiplicationMethodMustReturn200()
        {
            Assert.AreEqual(200, calc.Miltiplication());
        }
        [Test]
        public void DevisionMethodMustReturn2()
        {
            Assert.AreEqual(2, calc.Division());
        }

       
    }
}
