using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void GroupSByte(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            var reflect = (SByte)(value_EXPRESSIONXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(SByte)];

            data.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            value_EXPRESSIONXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
