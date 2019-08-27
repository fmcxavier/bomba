using System.Collections.Generic;
using Core;
using Core.Enums;
using Core.Wires;
using NUnit.Framework;

namespace Tests
{
    public class WireListTests
    {
        [Test]
        public void Disarm()
        {
            WireList list = new WireList();
            list.Add(WireType.White);
            list.Add(WireType.Red);
            list.Add(WireType.Green);
            list.Add(WireType.White);

            Assert.AreEqual(ResultType.Disarm, list.CutWires());
        }

        [Test]
        public void Explode()
        {
            WireList list = new WireList();
            list.Add(WireType.White);
            list.Add(WireType.Orange);
            list.Add(WireType.Green);
            list.Add(WireType.White);

            Assert.AreEqual(ResultType.Explode, list.CutWires());
        }

        [Test]
        public void WireTypeListConstructor_Disarm()
        {
            WireList list = new WireList(new List<WireType>() { WireType.White, WireType.Red, WireType.Green, WireType.White });

            Assert.AreEqual(ResultType.Disarm, list.CutWires());
        }

        [Test]
        public void WireTypeListConstructor_Explode()
        {
            WireList list = new WireList(new List<WireType>() { WireType.White, WireType.Orange, WireType.Green, WireType.White });

            Assert.AreEqual(ResultType.Explode, list.CutWires());
        }
    }
}