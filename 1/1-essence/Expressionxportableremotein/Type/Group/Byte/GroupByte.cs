using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void GroupByte(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            var reflect = (Byte)(value_EXPRESSIONXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(Byte)];

            data.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            value_EXPRESSIONXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
