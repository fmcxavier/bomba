using Core.Enums;
using Core.Wires;
using NUnit.Framework;

namespace Tests
{
    public class WireTests
    {
        [Test]
        public void White()
        {
            Wire wire = new White();

            Assert.AreEqual(ResultType.Explode, wire.Cut(new White()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Red()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Black()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Orange()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Green()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Purple()));
        }

        [Test]
        public void Red()
        {
            Wire wire = new Red();

            Assert.AreEqual(ResultType.Explode, wire.Cut(new White()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Red()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Black()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Orange()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Green()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Purple()));
        }

        [Test]
        public void Black()
        {
            Wire wire = new Black();

            Assert.AreEqual(ResultType.Explode, wire.Cut(new White()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Red()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Black()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Orange()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Green()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Purple()));
        }

        [Test]
        public void Orange()
        {
            Wire wire = new White();

            Assert.AreEqual(ResultType.Explode, wire.Cut(new White()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Red()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Black()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Orange()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Green()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Purple()));
        }

        [Test]
        public void Green()
        {
            Wire wire = new White();

            Assert.AreEqual(ResultType.Disarm, wire.Cut(new White()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Red()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Black()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Orange()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Green()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Purple()));
        }

        [Test]
        public void Purple()
        {
            Wire wire = new Purple();

            Assert.AreEqual(ResultType.Explode, wire.Cut(new White()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Red()));
            Assert.AreEqual(ResultType.Disarm, wire.Cut(new Black()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Orange()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Green()));
            Assert.AreEqual(ResultType.Explode, wire.Cut(new Purple()));
        }
    }
}