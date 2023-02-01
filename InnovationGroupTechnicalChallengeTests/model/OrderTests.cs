using InnovationGroupTechnicalChallenge.Model;

namespace InnovationGroupTechnicalChallengeTests.Model
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        [DataRow(false, OrderType.Repair, false, false)]
        [DataRow(true, OrderType.Repair, false, false)]
        [DataRow(false, OrderType.Repair, true, false)]
        [DataRow(false, OrderType.Repair, false, true)]
        [DataRow(true, OrderType.Repair, true, false)]
        [DataRow(false, OrderType.Repair, true, true)]
        [DataRow(true, OrderType.Repair, false, true)]
        [DataRow(true, OrderType.Repair, true, true)]
        [DataRow(false, OrderType.Hire, false, false)]
        [DataRow(true, OrderType.Hire, false, false)]
        [DataRow(false, OrderType.Hire, true, false)]
        [DataRow(false, OrderType.Hire, false, true)]
        [DataRow(true, OrderType.Hire, true, false)]
        [DataRow(false, OrderType.Hire, true, true)]
        [DataRow(true, OrderType.Hire, false, true)]
        [DataRow(true, OrderType.Hire, true, true)]
        public void ShouldCreate_Order(bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder)
        {
            var createdOrder = new Order(isRushOrder, orderType, isNewCustomer, isLargeOrder);

            Assert.AreEqual(isRushOrder, createdOrder.IsRushOrder);
            Assert.AreEqual(orderType, createdOrder.OrderType);
            Assert.AreEqual(isNewCustomer, createdOrder.IsNewCustomer);
            Assert.AreEqual(isLargeOrder, createdOrder.IsLargeOrder);
        }
    }
}
