using System;
using System.Collections.Generic;
using System.Reflection;
using Core.Enums;
using Core.Wires;

namespace Core
{
    public class WireList
    {
        private LinkedList<Wire> _wireCutList;

        public WireList()
        {
            _wireCutList = new LinkedList<Wire>();
        }

        public WireList(List<WireType> wireTypeList)
        {
            _wireCutList = new LinkedList<Wire>();

            foreach (var wireType in wireTypeList)
            {
                Add(wireType);
            }
        }

        public void Add(WireType wire)
        {
            Wire newWire = wire.ToInstance();
            _wireCutList.AddLast(newWire);
        }

        public ResultType CutWires()
        {
            var current = _wireCutList.First;
            var result = ResultType.Disarm;
            while (current != null && result != ResultType.Explode)
            {
                result = current.Value.Cut(current.Next?.Value);
                current = current.Next;
            }

            return result;
        }
    }
}