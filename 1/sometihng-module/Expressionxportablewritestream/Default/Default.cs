using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritestreamModule
    {
        public static ExpressionxportablewritestreamModule Default(String Filename_VALUE, Expressionxportable[] array_EXPRESSIONXPORTABLE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT, ExpressionxportablewritebuildPort value_EXPRESSIONXPORTABLEWRITEBUILDPORT)
        {
            ExpressionxportablewritestreamModule module;

            module = new ExpressionxportablewritestreamModule();

            var inflect = new Object[4];

            inflect[0] = Filename_VALUE;

            inflect[1] = array_EXPRESSIONXPORTABLE;

            inflect[2] = value_EXPRESSIONXPORTABLELAYOUT;

            inflect[3] = value_EXPRESSIONXPORTABLEWRITEBUILDPORT;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ExpressionxportablewriteCycle.XZeroth = xzeroth;

            module.XOne();

            module.XTwo();

            module.XThree();

            ExpressionxportablewritestreamPort expressionxportablewritestreamPort;

            expressionxportablewritestreamPort = new ExpressionxportablewritestreamPort();

            expressionxportablewritestreamPort.HeaderTableMemoryStream = ExpressionxportablewriteCycle.XPrimary.XSingle.MemoryStream;

            expressionxportablewritestreamPort.SubjectTableMemoryStream = ExpressionxportablewriteCycle.XSecondary.XDouble.MemoryStream;

            expressionxportablewritestreamPort.ObjectTableMemoryStream = ExpressionxportablewriteCycle.XTertiary.XTriple.MemoryStream;

            expressionxportablewritestreamPort.HeaderTableByteArray = ExpressionxportablewriteCycle.XPrimary.XSingle.ByteArray;

            expressionxportablewritestreamPort.SubjectTableByteArray = ExpressionxportablewriteCycle.XSecondary.XDouble.ByteArray;

            expressionxportablewritestreamPort.ObjectTableByteArray = ExpressionxportablewriteCycle.XTertiary.XTriple.ByteArray;

            module.ExpressionxportablewritestreamPort = expressionxportablewritestreamPort;

            return module;
        }
    }
}
