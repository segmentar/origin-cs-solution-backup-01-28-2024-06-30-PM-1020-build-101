using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IModule(Expressionxportable value_EXPRESSIONXPORTABLE, String Module_VALUE)
        {
            try
            {
                var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value_EXPRESSIONXPORTABLE.ModuleArrayListObject);

                list.Add(Module_VALUE);
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(IModule)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Module().Initialize(information, exception));
            }

            return;
        }
    }
}
