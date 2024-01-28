using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel(Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                XSingle xsingleResult = default;

                var array = FunctionLevelSetSurface(array_EXPRESSIONXPORTABLE);

                XSingle xsingle;

                xsingle = new XSingle(array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
