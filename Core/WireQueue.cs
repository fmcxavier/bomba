using System.Collections.Generic;

namespace Core
{
    public class WireQueue
    {
        private Queue<WireType> _wireQueue;

        public WireQueue()
        {
            _wireQueue = new Queue<WireType>();
        }

        public void Add(WireType wire)
        {
            _wireQueue.Enqueue(wire);
        }
    }
}