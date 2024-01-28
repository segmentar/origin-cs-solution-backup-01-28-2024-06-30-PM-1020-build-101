using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HEach(Expression expression, String value, String lower, String[] array)
        {
            try
            {
                var inflect = new Object[2];

                inflect[0] = lower.Split();

                inflect[1] = value.Split();

                var oth = ((String[])inflect[0])[0];

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityInstructionEach, oth) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                Each(expression, array);
            }
            catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.Each().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
