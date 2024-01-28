using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablelinear
    {
        public static void Multiline(ExpressionxportablelinearXle_elY Level_VALUE, ExpressionxportablelinearX_ortY Port_VALUE)
        {
            ParameterArrayList.Add(Level_VALUE.Reflect);

            Singleprimaryfirstone();

            var reflect = (String[])(ParameterArrayList.ToArray(typeof(String)) as Array);

            ParameterArrayList.Clear();

            ExpressionxportablelinearXlev_lY level;

            level = new ExpressionxportablelinearXlev_lY();

            level.Expressionxportable = Level_VALUE.Expressionxportable;

            level.Type = Level_VALUE.Type;

            level.ExecuteArray = Level_VALUE.ExecuteArray;

            level.Reflect = Level_VALUE.Reflect;

            level.ParameterArray = reflect;

            Fourfourthquatenaryquadruple(level, Port_VALUE);

            return;
        }
    }
}
