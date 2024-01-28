using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HVLock(Expressionxportable expressionxportable, String value, String lower, String argument, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablestorelock.EntityVLock, lower) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var result = Expressionxportableformat.DashlessFormat(argument);

                VLock(expressionxportable, result);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(HVLock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Lock().Initialize(information, exception));
            }

            return;
        }
    }
}
