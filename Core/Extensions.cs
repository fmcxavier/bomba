using System;
using System.Collections.Generic;
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

        public static List<WireType> ToWireTypeArray(this string[] typeArray)
        {
            var result = new List<WireType>();
            foreach (var type in typeArray)
            {
                result.Add(type.ToWireType());
            }

            return result;
        }
    }
}