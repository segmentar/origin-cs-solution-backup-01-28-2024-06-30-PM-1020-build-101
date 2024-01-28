using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremotein
    {
        public static void GroupChar(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            var reflect = (Char)(value_EXPRESSIONXPORTABLE.ObjectIdentity as Object);

            var data = BitConverter.GetBytes(reflect);

            var array = new Byte[sizeof(Char)];

            data.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            value_EXPRESSIONXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
