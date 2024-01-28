using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablelinear
    {
        public static void Fourfourthquatenaryquadruple(ExpressionxportablelinearXlev_lY Level_VALUE, ExpressionxportablelinearX_ortY Port_VALUE)
        {
            Port_VALUE.LevelLevelLevelLevel = Level_VALUE;

            Port_VALUE.LevelArrayList.Add(Level_VALUE);

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(Level_VALUE.ParameterArray.Length, 0) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var oth = Level_VALUE.ParameterArray[0];

            var lower = oth.ToLower();

            var aoth = Level_VALUE.ParameterArray.Length;

            var roth = (aoth - 1);

            var array = new String[roth];

            Array.Copy(Level_VALUE.ParameterArray, 1, array, 0, roth);

            ExpressionxportablelinearXleve_Y level;

            level = new ExpressionxportablelinearXleve_Y();

            level.Expressionxportable = Level_VALUE.Expressionxportable;

            level.Type = Level_VALUE.Type;

            level.ExecuteArray = Level_VALUE.ExecuteArray;

            level.Reflect = Level_VALUE.Reflect;

            level.ParameterArray = Level_VALUE.ParameterArray;

            level.Value = oth;

            level.Lower = lower;

            level.ArgumentArray = array;

            Fivefifthquinaryquintuple(level, Port_VALUE);

            return;
        }
    }
}
