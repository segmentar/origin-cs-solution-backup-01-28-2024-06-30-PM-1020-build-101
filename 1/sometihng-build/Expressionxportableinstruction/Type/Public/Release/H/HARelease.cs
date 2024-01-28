using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HARelease(Expression expression, String value, String lower, String[] array)
        {
            try
            {
                var inflect = new Object[2];

                inflect[0] = value.Split();

                inflect[1] = lower.Split();

                var oth = ((String[])inflect[1])[0];

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityInstructionRelease, oth) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                ARelease(expression);
            }
            catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.Release().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
