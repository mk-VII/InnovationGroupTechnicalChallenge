using InnovationGroupTechnicalChallenge.Model;

namespace InnovationGroupTechnicalChallenge.logic
{
    public class Rule
    {
        public IEnumerable<Predicate<Order>> Predicates { get; }
        public OrderStatus Outcome { get; }

        public Rule(IEnumerable<Predicate<Order>> predicates, OrderStatus outcome)
        {
            Predicates = predicates;
            Outcome = outcome;
        }

        public bool IsMet(Order order) => Predicates.All(rule => rule.Invoke(order));
    }
}
