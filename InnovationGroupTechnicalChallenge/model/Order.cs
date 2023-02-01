namespace InnovationGroupTechnicalChallenge.Model;

public class Order
{
    public bool IsRushOrder { get; }
    public OrderType OrderType { get; }
    public bool IsNewCustomer { get; }
    public bool IsLargeOrder { get; }

    public Order(bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder)
    {
        IsRushOrder = isRushOrder;
        OrderType = orderType;
        IsNewCustomer = isNewCustomer;
        IsLargeOrder = isLargeOrder;
    }
}