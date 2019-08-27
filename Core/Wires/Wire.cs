using System;
using System.Collections.Generic;
using System.Linq;
using Core.Enums;

namespace Core.Wires
{
    public abstract class Wire
    {
        protected WireRule[] Rules;
        protected WireType Type;

        public ResultType Cut(Wire after)
        {
            ResultType result = CheckActionType(after, ActionType.MustCut);

            if (result == ResultType.Disarm)
                result = CheckActionType(after, ActionType.CantCut);

            return result;
        }

        private ResultType CheckActionType(Wire wire, ActionType action)
        {
            ResultType result = ResultType.Explode;

            var mustCut =
                Rules.Where(x =>
                    x.Action == ActionType.MustCut);

            var cantCut =
                Rules.Where(x =>
                    x.Action == ActionType.CantCut);

            if ((!mustCut.Any() || (wire != null && mustCut.Any(x => x.Type == wire?.Type))) && cantCut.All(x => x.Type != wire?.Type))
                result = ResultType.Disarm;

            return result;
        }
    }

    public static class WireTypeExtensions
    {
        public static Wire ToInstance(this WireType wire)
        {
            return (Wire)Activator.CreateInstance(
                Type.GetType("Core.Wires." + wire.ToString()), false);
        }
    }
}