using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HOperation(Expressionxportable expressionxportable, String value, String lower, String argument, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablestoreoperation.EntityOperation, lower) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var result = Expressionxportableformat.DashlessFormat(argument);

                Operation(expressionxportable, result, array);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(HOperation)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Operation().Initialize(information, exception));
            }

            return;
        }
    }
}
