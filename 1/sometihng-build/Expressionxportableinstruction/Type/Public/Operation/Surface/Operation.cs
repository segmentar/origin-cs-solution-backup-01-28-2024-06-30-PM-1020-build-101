using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void Operation(Expressionxportable value_EXPRESSIONXPORTABLE, String Operation_VALUE, String[] Argument_ARRAY)
        {
            try
            {
                IOperation(value_EXPRESSIONXPORTABLE, Operation_VALUE, Argument_ARRAY);
            } 
            catch (Exception exception)
            {
                var information = new String[] { 
                
                    nameof(Operation)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Operation().Initialize(information, exception));
            }

            return;
        }
    }
}
