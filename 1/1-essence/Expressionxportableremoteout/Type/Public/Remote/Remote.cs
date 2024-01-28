using Core;

namespace Core
{
    using System;
 
    public partial class Expressionxportableremoteout
    {
        public static Object Remote(Byte[] array_BYTE, Type value_TYPE)
        {
            Object objectResult = default;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(array_BYTE.Length, 0) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return objectResult;
            }
            else
                "false".ToString();

            Object objectValue;

            if (Object.Equals(typeof(String).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupString(array_BYTE);
            } 
            else if (Object.Equals(typeof(Char).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupChar(array_BYTE);
            }
            else if (Object.Equals(typeof(Boolean).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupBoolean(array_BYTE);
            }
            else if (Object.Equals(typeof(SByte).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupSByte(array_BYTE);
            }
            else if (Object.Equals(typeof(Int16).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupInt16(array_BYTE);
            }
            else if (Object.Equals(typeof(Int32).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupInt32(array_BYTE);
            }
            else if (Object.Equals(typeof(Int64).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupInt64(array_BYTE);
            }
            else if (Object.Equals(typeof(Byte).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupByte(array_BYTE);
            }
            else if (Object.Equals(typeof(UInt16).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupUInt16(array_BYTE);
            }
            else if (Object.Equals(typeof(UInt32).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupUInt32(array_BYTE);
            }
            else if (Object.Equals(typeof(UInt64).GetType().ToString(), value_TYPE))
            {
                objectValue = GroupUInt64(array_BYTE);
            }
            else
            { 
                objectValue = GroupObject(array_BYTE);
            }

            objectResult = objectValue;

            return objectResult;
        }
    }
}
