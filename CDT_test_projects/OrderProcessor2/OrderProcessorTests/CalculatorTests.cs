using System;
using System.Collections.Generic;
using NUnit.Framework;
using OrderProcessor;

namespace OrderProcessorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Product productA = new Product { Name = "A", UnitPrice = 2.50m, VatClass = "Standard" };
        private Product productB = new Product { Name = "B", UnitPrice = 1.00m, VatClass = "Reduced" };
        private Product productC = new Product { Name = "C", UnitPrice = 10.00m, VatClass = "Zero" };
        private Product productD = new Product { Name = "D", UnitPrice = 1.50m, VatClass = "Exempt" };

        [Test]
        public void StandardVatTest()
        {
            Calculator target = new Calculator();

            var orders = new List<Order>{
                new Order { ProductOrdered = this.productA, Quantity = 1 }
            };

            Assert.AreEqual(3.00m, target.Calculate(orders));
        }

        [Test]
        public void ReducedVatTest()
        {
            Calculator target = new Calculator();

            var orders = new List<Order>{
                new Order { ProductOrdered = this.productB, Quantity = 1 }
            };

            Assert.AreEqual(1.05m, target.Calculate(orders));
        }

        [Test]
        public void ZeroVatTest()
        {
            Calculator target = new Calculator();

            var orders = new List<Order>{
                new Order { ProductOrdered = this.productC, Quantity = 1 }
            };

            Assert.AreEqual(10.00m, target.Calculate(orders));
        }
    }
}
