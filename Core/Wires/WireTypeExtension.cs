using System;
using Core.Enums;

namespace Core.Wires
{
    public static class WireTypeExtension
    {
        public static Wire ToInstance(this WireType wire)
        {
            return (Wire)Activator.CreateInstance(
                Type.GetType("Core.Wires." + wire.ToString()), false);
        }
    }
}