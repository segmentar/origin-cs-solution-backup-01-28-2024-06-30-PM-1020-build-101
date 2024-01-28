using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        public static ExpressionxportablereadbuildModule Default(String Filename_VALUE, ExpressionxportablereadfilePort value_EXPRESSIONXPORTABLEREADFILEPORT, ExpressionxportablereadstreamPort value_EXPRESSIONXPORTABLEREADSTREAMPORT)
        {
            ExpressionxportablereadbuildModule module;

            module = new ExpressionxportablereadbuildModule();

            var inflect = new Object[3];

            inflect[0] = Filename_VALUE;

            inflect[1] = value_EXPRESSIONXPORTABLEREADFILEPORT;

            inflect[2] = value_EXPRESSIONXPORTABLEREADSTREAMPORT;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ExpressionxportablereadbuildCycle.XZeroth = xzeroth;

            module.XOne();
                
            module.XTwo();

            module.XThree();

            module.XFour();

            XZeroth.FunctionBuildVoid(ExpressionxportablereadbuildCycle.XQuaternary.XQuadruple.LevelArray);

            ExpressionxportablereadbuildPort expressionxportablereadbuildPort;

            expressionxportablereadbuildPort = new ExpressionxportablereadbuildPort();

            expressionxportablereadbuildPort.ExpressionxportableArray = XZeroth.FunctionDefaultSetSurface(ExpressionxportablereadbuildCycle.XQuaternary.XQuadruple.LevelArray);

            expressionxportablereadbuildPort.Expressionxportable = XZeroth.Default(ExpressionxportablereadbuildCycle.XQuaternary.XQuadruple.LevelArray);

            module.ExpressionxportablereadbuildPort = expressionxportablereadbuildPort;

            return module;
        }
    }
}
