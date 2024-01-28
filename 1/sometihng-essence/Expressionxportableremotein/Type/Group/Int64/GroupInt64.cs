using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void GroupInt64(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            var reflect = (Int64)(value_EXPRESSIONXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(Int64)];

            data.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            value_EXPRESSIONXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
