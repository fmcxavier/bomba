using System.Collections.Generic;
using System.Linq;
using Core.Enums;

namespace Core.Wires
{
    public abstract class Wire
    {
        protected WireRule[] Rules;
        public WireType Type;

        protected ResultType Cut(Wire before, Wire after)
        {
            ResultType result = CheckByOrder(before, Order.Before);

            if (result == ResultType.Disarm)
                result = CheckByOrder(after, Order.After);

            return result;
        }

        private ResultType CheckByOrder(Wire wire, Order order)
        {
            ResultType result = ResultType.Explode;

            var mustCut =
                Rules.Where(x =>
                    x.Order == order &&
                    x.Action == ActionType.MustCut);

            var cantCut =
                Rules.Where(x =>
                    x.Order == order &&
                    x.Action == ActionType.CantCut);

            if (mustCut.Any(x => x.Type == wire.Type) && cantCut.All(x => x.Type != wire.Type))
                result = ResultType.Disarm;

            return result;
        }
    }
}