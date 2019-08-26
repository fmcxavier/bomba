using Core.Enums;

namespace Core.Wires
{
    public class Red : Wire
    {
        public Red()
        {
            Type = WireType.Red;
            Rules = new[]
            {
                new WireRule(ActionType.MustCut, WireType.Green)
            };
        }
    }
}