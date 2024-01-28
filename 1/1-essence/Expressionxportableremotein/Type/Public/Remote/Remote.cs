using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void Remote(Expressionxportable[] array_EXPRESSIONXPORTABLE)
        {
            foreach (Expressionxportable value_EXPRESSIONXPORTABLE in array_EXPRESSIONXPORTABLE)
            {
                if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(Boolean)))
                {
                    //GroupBoolean(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(Char)))
                {
                    //GroupChar(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(String)))
                {
                    //GroupString(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(Byte)))
                {
                    //GroupByte(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(UInt16)))
                {
                    //GroupUInt16(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(UInt32)))
                {
                    //GroupUInt32(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(UInt64)))
                {
                    //GroupUInt64(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(SByte)))
                {
                    //GroupSByte(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(Int16)))
                {
                    //GroupInt16(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(Int32)))
                {
                    //GroupInt32(value_EXPRESSIONXPORTABLE);
                }
                else if (Object.Equals(value_EXPRESSIONXPORTABLE.Type, typeof(Int64)))
                {
                    //GroupInt64(value_EXPRESSIONXPORTABLE);
                }
                else
                {
                    GroupObject(value_EXPRESSIONXPORTABLE);
                }

                continue;
            }

            return;
        }
    }
}
