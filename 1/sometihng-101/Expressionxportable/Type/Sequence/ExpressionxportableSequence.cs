using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableSequence
    {
        public Expressionxportable Result { get; set; } = default;

        public ExpressionxportableSequence(Expressionxportablestringsafe value_EXPRESSIONXPORTABLESTRINGSAFE, Object value_OBJECT, Boolean answer_DEBUG_is)
        {
            Debug(value_EXPRESSIONXPORTABLESTRINGSAFE, value_OBJECT, answer_DEBUG_is);

            Expressionxportable expressionxportable;

            expressionxportable = new Expressionxportable(value_EXPRESSIONXPORTABLESTRINGSAFE, value_OBJECT, answer_DEBUG_is);

            this.Result = expressionxportable;

            return;
        }

        ~ExpressionxportableSequence()
        {
            return;
        }
    }
}
