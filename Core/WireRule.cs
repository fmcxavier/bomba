using Core.Enums;

namespace Core
{
    public class WireRule
    {
        private WireType _type;
        private Order _order;
        private ActionType _action;

        public WireRule(WireType type, Order order, ActionType action)
        {
            _type = type;
            _order = order;
            _action = action;
        }
    }
}