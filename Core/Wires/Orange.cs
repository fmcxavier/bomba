using Core.Enums;

namespace Core.Wires
{
    public class Orange : Wire
    {
        public Orange()
        {
            Type = WireType.Orange;
            Rules = new[]
            {
                new WireRule(ActionType.MustCut, WireType.Red),
                new WireRule(ActionType.MustCut, WireType.Black)
            };
        }
    }
}