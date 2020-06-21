using FluentAssertions;
using NUnit.Framework;
using PromoEngineRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoEngineTests
{
    public class PromoEngineTest
    {
        PromoEngineClient promoClient;
        public PromoEngineTest()
        {
            promoClient = new PromoEngineClient();
        }
        [Test]
        [TestCase("3 of A's for 130")]
        public void TestScenario1(string activePromo)
        {
            List<string> orders = new List<string>
            {
                "5*A","1*B","1*C"
            };

            var totalValue = promoClient.ApplyPromo(activePromo, orders);
            totalValue.Should().Be(280);

        }

        [Test]
        [TestCase("2 of B's for 45")]
        public void TestScenario2(string activePromo)
        {
            List<string> orders = new List<string>
            {
                "5*A","5*B","1*C"
            };

            var totalValue = promoClient.ApplyPromo(activePromo, orders);
            totalValue.Should().Be(390);
        }
        [Test]
        [TestCase("C & D for 30")]
        public void TestScenario3(string activePromo)
        {
            List<string> orders = new List<string>
            {
                "3*A","5*B","1*C","1*D"
            };

            var totalValue = promoClient.ApplyPromo(activePromo, orders);
            totalValue.Should().Be(330);
        }
    }
}
