using Core.Enums;

namespace Core.Wires
{
    public class Black : Wire
    {
        public Black()
        {
            Type = WireType.Black;
            Rules = new[]
            {
                new WireRule(ActionType.CantCut, WireType.White),
                new WireRule(ActionType.CantCut, WireType.Green),
                new WireRule(ActionType.CantCut, WireType.Orange)
            };
        }
    }
}