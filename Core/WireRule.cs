using Core.Enums;

namespace Core
{
    public class WireRule
    {
        private WireType _type;
        private Order _order;
        private ActionType _action;

        public WireType Type => _type;
        public Order Order => _order;
        public ActionType Action => _action;

        public WireRule(ActionType action, WireType type, Order order)
        {
            _type = type;
            _order = order;
            _action = action;
        }
    }
}