using Core.Enums;

namespace Core.Wires
{
    public class Purple : Wire
    {
        public Purple()
        {
            Type = WireType.Purple;
            Rules = new[]
            {
                new WireRule(ActionType.CantCut, WireType.Purple),
                new WireRule(ActionType.CantCut, WireType.Green),
                new WireRule(ActionType.CantCut, WireType.Orange),
                new WireRule(ActionType.CantCut, WireType.White)
            };
        }
    }
}