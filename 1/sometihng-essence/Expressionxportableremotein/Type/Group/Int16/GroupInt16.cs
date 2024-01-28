using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void GroupInt16(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            var reflect = (Int16)(value_EXPRESSIONXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(Int16)];

            data.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            value_EXPRESSIONXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
