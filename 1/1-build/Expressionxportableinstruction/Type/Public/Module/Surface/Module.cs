using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void Module(Expressionxportable value_EXPRESSIONXPORTABLE, String Module_VALUE)
        {
            try
            {
                IModule(value_EXPRESSIONXPORTABLE, Module_VALUE);

            } catch (Exception exception)
            {
                var information = new String[] {

                    nameof(Module)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Module().Initialize(information, exception));
            }

            return;
        }
    }
}
