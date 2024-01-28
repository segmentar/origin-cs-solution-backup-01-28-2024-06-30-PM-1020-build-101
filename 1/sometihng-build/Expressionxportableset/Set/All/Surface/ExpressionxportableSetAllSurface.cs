using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableset
    {
        public static Expressionxportable[] ExpressionxportableAllSetSurface(Expressionxportable value_EXPRESSIONXPORTABLE, Boolean answer_SELF_should)
        {
            Expressionxportable[] arrayResult = default;

            var list = ExpressionxportableAllSet(value_EXPRESSIONXPORTABLE, answer_SELF_should);

            var array = new Expressionxportable[list.Count];

            list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
