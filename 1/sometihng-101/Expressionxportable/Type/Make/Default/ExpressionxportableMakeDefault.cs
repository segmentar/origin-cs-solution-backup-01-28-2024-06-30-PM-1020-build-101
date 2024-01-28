using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public static Expressionxportable MakeExpressionxportableDefault(Expressionxportablestringsafe value_EXPRESSIONXPORTABLESTRINGSAFE, Object value_OBJECT, Boolean answer_DEBUG_is)
        {
            Expressionxportable expressionxportableResult = default;

            var result = new ExpressionxportableSequence(value_EXPRESSIONXPORTABLESTRINGSAFE, value_OBJECT, answer_DEBUG_is).Result;

            Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(ExpressionxportablePolicy.ExpressionxportableArrayListObject).Add(result);

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}
