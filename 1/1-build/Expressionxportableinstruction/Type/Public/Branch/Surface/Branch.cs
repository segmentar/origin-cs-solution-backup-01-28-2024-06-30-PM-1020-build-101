using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void Branch(Expressionxportable value_EXPRESSIONXPORTABLE, String Branch_VALUE)
        {
            try
            {
                IBranch(value_EXPRESSIONXPORTABLE, Branch_VALUE);
            } 
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(Branch)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Branch().Initialize(information, exception));
            }

            return;
        }
    }
}
