using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HVUnlock(Expressionxportable expressionxportable, String value, String lower, String argument, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablestoreunlock.EntityVUnlock, lower) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var result = Expressionxportableformat.DashlessFormat(argument);

                VUnlock(expressionxportable, result);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(HVUnlock)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Unlock().Initialize(information, exception));
            }

            return;
        }
    }
}
