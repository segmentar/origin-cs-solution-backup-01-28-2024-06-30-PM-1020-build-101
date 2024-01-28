using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableSimple
    {
        public Expressionxportable Result { get; set; } = default;

        public ExpressionxportableSimple()
        {
            return;
        }

        ~ExpressionxportableSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class ExpressionxportableSimple
    {
        public ExpressionxportableSimple(String value_STRING, Object value_OBJECT)
        {
            var value = Expressionxportablestringsafe.ForgeDefault(value_STRING);

            var result = Expressionxportable.MakeExpressionxportableDefaultSurface(value, value_OBJECT);

            this.Result = result;

            return;
        }
    }
}