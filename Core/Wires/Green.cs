using Core.Enums;

namespace Core.Wires
{
    public class Green : Wire
    {
        public Green()
        {
            Type = WireType.Green;
            Rules = new[]
            {
                new WireRule(ActionType.MustCut, WireType.Orange),
                new WireRule(ActionType.MustCut, WireType.White)
            };
        }
    }
}