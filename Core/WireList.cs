using System.Collections.Generic;
using Core.Enums;

namespace Core
{
    public class WireList
    {
        private LinkedList<WireType> _wireCutList;

        public WireList()
        {
            _wireCutList = new LinkedList<WireType>();
        }

        public void Add(WireType wire)
        {
            _wireCutList.AddLast(wire);
        }

        public ResultType CutWires()
        {
            return ResultType.Disarm;
        }
    }
}