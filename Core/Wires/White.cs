using System.Linq;
using Core.Enums;

namespace Core.Wires
{
    public class White : Wire
    {
        public White()
        {
            Type = WireType.White;
            Rules = new[]
            {
                new WireRule(ActionType.MustCut, WireType.White, Order.After),
                new WireRule(ActionType.MustCut, WireType.Black, Order.After)
            };
        }
    }
}