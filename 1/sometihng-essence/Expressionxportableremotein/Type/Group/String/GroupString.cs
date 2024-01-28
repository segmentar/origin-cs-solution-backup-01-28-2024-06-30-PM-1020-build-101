using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class Expressionxportableremotein
    {
        public static void GroupString(Expressionxportable value_EXPRESSIONXPORTABLE)
        {
            var reflect = (String)(value_EXPRESSIONXPORTABLE.ObjectIdentity as Object);

            var data = ((Encoding)Expressionxportableconfigure.WriterEncoding).GetBytes(reflect);

            var array = new Byte[reflect.Length];

            data.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            value_EXPRESSIONXPORTABLE.RemoteArrayObject = array;

            return;
        }
    }
}
