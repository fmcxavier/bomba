using System;
using Core.Enums;

namespace Core
{
    public static class Extensions
    {
        public static WireType ToWireType(this string type)
        {
            WireType result;

            if (string.IsNullOrWhiteSpace(type) || !Enum.TryParse(type, true, out result))
                result = WireType.Invalid;

            return result;
        }
    }
}