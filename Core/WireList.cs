using System.Collections.Generic;

namespace Core
{
    public class WireList
    {
        private LinkedList<WireType> _wireQueue;

        public WireList()
        {
            _wireQueue = new LinkedList<WireType>();
        }

        public void Add(WireType wire)
        {
            _wireQueue.AddLast(wire);
        }

        public bool IsFirst(WireType wire)
        {
            var element = _wireQueue.Find(wire);
            return element != null && element.Previous == null;
        }

        public bool IsLast(WireType wire)
        {
            var element = _wireQueue.Find(wire);
            return element != null && element.Next == null;
        }

        public WireType? Before(WireType wire)
        {
            var element = _wireQueue.Find(wire);

            return element?.Previous?.Value;
        }

        public WireType? After(WireType wire)
        {
            var element = _wireQueue.Find(wire);

            return element?.Next?.Value;
        }
    }
}