using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void HModule(Expressionxportable expressionxportable, String value, String lower, String argument, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(Expressionxportablestoremodule.EntityModule, lower) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var result = Expressionxportableformat.DashlessFormat(argument);

                Module(expressionxportable, result);
            }
            catch (Exception exception)
            {
                var information = new String[] { 
                
                    nameof(HModule)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Module().Initialize(information, exception));
            }

            return;
        }
    }
}
