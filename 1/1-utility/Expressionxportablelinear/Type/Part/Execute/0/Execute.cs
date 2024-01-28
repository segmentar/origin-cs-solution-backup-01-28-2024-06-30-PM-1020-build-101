using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablelinear
    {
        public static ExpressionxportablelinearX_ortY Execute(Expressionxportable value_EXPRESSIONXPORTABLE, String Type_VALUE, Byte[] Remote_ARRAY)
        {
            ExpressionxportablelinearX_ortY portResult = default;

            ExpressionxportablelinearX_evelY level;

            level = new ExpressionxportablelinearX_evelY();

            level.Expressionxportable = value_EXPRESSIONXPORTABLE;

            level.Type = Type_VALUE;

            ExpressionxportablelinearX_ortY port;

            port = new ExpressionxportablelinearX_ortY();

            port.LevelArrayList = Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser(new Object[0]);

            Import();

            Onefirstprimarysingle(level, port);

            Export();

            portResult = port;

            return portResult;
        }
    }
}
