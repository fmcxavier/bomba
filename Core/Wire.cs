using System.Collections.Generic;
using Core.Enums;

namespace Core
{
    public abstract class Wire
    {
        private WireRule[] _rules;

        public ResultType Cut()
        {
            return ResultType.Explode;
        }
    }
}