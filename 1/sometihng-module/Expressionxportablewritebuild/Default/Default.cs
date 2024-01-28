using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        public static ExpressionxportablewritebuildModule Default(String Filename_VALUE, Expressionxportable[] array_EXPRESSIONXPORTABLE, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
        {
            ExpressionxportablewritebuildModule module;

            module = new ExpressionxportablewritebuildModule();

            var inflect = new Object[3];

            inflect[0] = Filename_VALUE;

            inflect[1] = array_EXPRESSIONXPORTABLE;

            inflect[2] = value_EXPRESSIONXPORTABLELAYOUT;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ExpressionxportablewritebuildCycle.XZeroth = xzeroth;

            module.XOne();

            module.XTwo();
            
            module.XThree();
            
            module.XFour();
            
            module.XFive();

            module.XSix();

            module.XSeven();

            ExpressionxportablewritebuildPort expressionxportablewritebuildPort;

            expressionxportablewritebuildPort = new ExpressionxportablewritebuildPort();

            expressionxportablewritebuildPort.Level = ExpressionxportablewritebuildCycle.XPrimary.XSingle.LevelArray;

            expressionxportablewritebuildPort.LevelLevel = ExpressionxportablewritebuildCycle.XSecondary.XDouble.LevelArray;

            expressionxportablewritebuildPort.LevelLevelLevel = ExpressionxportablewritebuildCycle.XTertiary.XTriple.LevelArray;

            expressionxportablewritebuildPort.LevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XQuaternary.XQuadruple.LevelArray;

            expressionxportablewritebuildPort.LevelLevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XQuinary.XQuintuple.LevelArray;

            expressionxportablewritebuildPort.LevelLevelLevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XSenary.XSextuple.LevelArray;

            expressionxportablewritebuildPort.LevelLevelLevelLevelLevelLevelLevel = ExpressionxportablewritebuildCycle.XSeptenary.XSeptuple.LevelArray;

            module.ExpressionxportablewritebuildPort = expressionxportablewritebuildPort;

            return module;
        }
    }
}
