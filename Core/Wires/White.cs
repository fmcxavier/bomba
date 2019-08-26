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