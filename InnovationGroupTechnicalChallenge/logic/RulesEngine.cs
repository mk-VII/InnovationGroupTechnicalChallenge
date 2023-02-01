using InnovationGroupTechnicalChallenge.logic;
using InnovationGroupTechnicalChallenge.Model;

namespace InnovationGroupTechnicalChallenge.Logic;

public class RulesEngine
{
    private readonly IEnumerable<Rule> _rules;

    public RulesEngine(IEnumerable<Rule> rules)
    {
        _rules = rules;
    }

    public OrderStatus GetStatusForOrder(Order order)
    {
        var rulesMetByOrder = _rules.Where(rule => rule.IsMet(order));

        return rulesMetByOrder.FirstOrDefault()?.Outcome ?? OrderStatus.Confirmed;
    }
}