using InnovationGroupTechnicalChallenge.logic;
using InnovationGroupTechnicalChallenge.Logic;
using InnovationGroupTechnicalChallenge.Model;

namespace InnovationGroupTechnicalChallengeTests.Logic
{
    [TestClass]
    public class RulesEngineTests
    {
        private static RulesEngine CreateOrderEngine() =>
            new(OrderRules.RulesList);

        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void LargeRepairNewCustomer_ShouldReturn_Closed(bool isRushOrder)
        {
            var status = CreateOrderEngine().GetStatusForOrder(new Order(isRushOrder, OrderType.Repair, true, true));

            Assert.AreEqual(OrderStatus.Closed, status);
        }

        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void LargeRushHire_ShouldReturn_Closed(bool isNewCustomer)
        {
            var status = CreateOrderEngine().GetStatusForOrder(new Order(true, OrderType.Hire, isNewCustomer, true));

            Assert.AreEqual(OrderStatus.Closed, status);
        }

        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void LargeRepair_ShouldReturn_AuthenticationRequired(bool isRushOrder)
        {
            var status = CreateOrderEngine().GetStatusForOrder(new Order(isRushOrder, OrderType.Repair, false, true));

            Assert.AreEqual(OrderStatus.AuthenticationRequired, status);
        }

        [TestMethod]
        [DataRow(OrderType.Repair)]
        [DataRow(OrderType.Hire)]
        public void RushNewCustomer_ShouldReturn_AuthenticationRequired(OrderType orderType)
        {
            var status = CreateOrderEngine().GetStatusForOrder(new Order(true, orderType, true, false));

            Assert.AreEqual(OrderStatus.AuthenticationRequired, status);
        }

        [TestMethod]
        [DataRow(OrderType.Repair)]
        [DataRow(OrderType.Hire)]
        public void Default_ShouldReturn_Confirmed(OrderType orderType)
        {
            var status = CreateOrderEngine().GetStatusForOrder(new Order(false, orderType, false, false));

            Assert.AreEqual(OrderStatus.Confirmed, status);
        }
    }
}
