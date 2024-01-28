using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSextuple
        {
            public static IList<ExpressionxportablewriteU_evelV> FunctionLevelSet(ExpressionxportablewriteXleve_Y[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ICollection<ExpressionxportablewriteU_evelV> collectionResult = default;

                collectionResult = new List<ExpressionxportablewriteU_evelV>();

                var index = 0;

                index = index + value_EXPRESSIONXPORTABLELAYOUT.StartAddressObjectTable;

                foreach (ExpressionxportablewriteXleve_Y Level_VALUE in Level_ARRAY)
                {
                    Int32 i, j, x, y, u, v;

                    i = Math.Max(((Byte[])Level_VALUE.ObjectByteArray).Length, 1);

                    j = Math.Max(((Byte[])Level_VALUE.TypeByteArray).Length, 1);

                    x = 0;

                    x = x + index;

                    y = 0;

                    y = y + index;

                    y = y + i;

                    y = y - 1;

                    u = 0;

                    u = u + y;

                    u = u + 1;

                    v = 0;

                    v = v + u;

                    v = v + j;

                    v = v - 1;

                    ExpressionxportablewriteU_evelV level;

                    level = new ExpressionxportablewriteU_evelV();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relate = Level_VALUE.Relate;

                    level.Identity = Level_VALUE.Identity;

                    level.Type = Level_VALUE.Type;

                    level.ObjectByteArray = Level_VALUE.ObjectByteArray;

                    level.TypeByteArray = Level_VALUE.TypeByteArray;

                    level.ObjectStartAddress = x;

                    level.ObjectEndAddress = y;

                    level.TypeStartAddress = u;

                    level.TypeEndAddress = v;

                    level.Expressionxportable = Level_VALUE.Expressionxportable;

                    collectionResult.Add(level);

                    index = index + Level_VALUE.ObjectByteArray.Length;

                    index = index + Level_VALUE.TypeByteArray.Length;

                    continue;
                }

                return new List<ExpressionxportablewriteU_evelV>(collectionResult);
            }
        }
    }
}
