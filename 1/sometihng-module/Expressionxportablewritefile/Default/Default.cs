using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablewritefileModule
    {
        public static ExpressionxportablewritefileModule Default(String Filename_VALUE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, ExpressionxportablewritebuildPort value_EXPRESSIONXPORTABLEWRITEBUILD, ExpressionxportablewritestreamPort value_EXPRESSIONXPORTABLEWRITESTREAM)
        {
            ExpressionxportablewritefileModule module;

            module = new ExpressionxportablewritefileModule();

            var inflect = new Object[5];

            inflect[0] = Filename_VALUE;

            inflect[1] = value_EXPRESSIONXPORTABLELAYOUT;

            inflect[2] = value_EXPRESSIONXPORTABLEWRITECLOSE;

            inflect[3] = value_EXPRESSIONXPORTABLEWRITEBUILD;

            inflect[4] = value_EXPRESSIONXPORTABLEWRITESTREAM;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ExpressionxportablewritefileCycle.XZeroth = new XZeroth(inflect);

            module.XOne();

            ExpressionxportablewritefilePort expressionxportablewritefilePort;

            expressionxportablewritefilePort = new ExpressionxportablewritefilePort();

            expressionxportablewritefilePort.FileStream = ExpressionxportablewritefileCycle.XPrimary.XSingle.FileStream;

            expressionxportablewritefilePort.MemoryStream = ExpressionxportablewritefileCycle.XPrimary.XSingle.MemoryStream;

            module.ExpressionxportablewritefilePort = expressionxportablewritefilePort;

            return module;
        }
    }
}
