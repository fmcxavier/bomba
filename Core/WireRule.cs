using Core.Enums;

namespace Core
{
    public class WireRule
    {
        private WireType _type;
        private ActionType _action;

        public WireType Type => _type;
        public ActionType Action => _action;

        public WireRule(ActionType action, WireType type)
        {
            _type = type;
            _action = action;
        }
    }
}