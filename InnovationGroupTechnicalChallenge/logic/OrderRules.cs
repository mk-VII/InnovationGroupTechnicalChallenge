
using InnovationGroupTechnicalChallenge.Model;

namespace InnovationGroupTechnicalChallenge.logic
{
    public class OrderRules
    {
        public static Rule[] RulesList => new Rule[]
            {
                new(new Predicate<Order>[]
                {
                    order => order.IsLargeOrder,
                    order => order.OrderType == OrderType.Repair,
                    order => order.IsNewCustomer
                }, OrderStatus.Closed),
                new(new Predicate<Order>[]
                {
                    order => order.IsLargeOrder,
                    order => order.OrderType == OrderType.Hire,
                    order => order.IsRushOrder
                }, OrderStatus.Closed),
                new(new Predicate<Order>[]
                {
                    order => order.IsLargeOrder,
                    order => order.OrderType == OrderType.Repair
                }, OrderStatus.AuthenticationRequired),
                new(new Predicate<Order>[]
                {
                    order => order.IsRushOrder,
                    order => order.IsNewCustomer
                }, OrderStatus.AuthenticationRequired)
            };
    }
}
