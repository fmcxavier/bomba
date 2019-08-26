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
                new WireRule(ActionType.CantCut, WireType.White),
                new WireRule(ActionType.CantCut, WireType.Black)
            };
        }
    }
}