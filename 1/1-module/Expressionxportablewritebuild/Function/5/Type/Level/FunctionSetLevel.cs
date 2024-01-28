using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuintuple
        {
            public static IList<ExpressionxportablewriteXleve_Y> FunctionLevelSet(ExpressionxportablewriteXlev_lY[] Level_ARRAY, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ICollection<ExpressionxportablewriteXleve_Y> collectionResult = default;

                collectionResult = new List<ExpressionxportablewriteXleve_Y>();

                foreach (ExpressionxportablewriteXlev_lY Level_VALUE in Level_ARRAY)
                {
                    Boolean isDefaultContagentCheck;

                    isDefaultContagentCheck = (Level_VALUE.Expressionxportable.Type == default).Equals(true);

                    String stringValue;

                    if (isDefaultContagentCheck)
                    {
                        stringValue = String.Empty;
                    }
                    else
                    {
                        stringValue = Level_VALUE.Expressionxportable.Type.FullName;
                    }

                    var inflect = new Object[2];

                    inflect[0] = Level_VALUE.Expressionxportable.RemoteArrayObject;

                    inflect[1] = Expressionxportableconfigure.WriterEncoding.GetBytes(stringValue);

                    ExpressionxportablewriteXleve_Y level;

                    level = new ExpressionxportablewriteXleve_Y();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relate = Level_VALUE.Relate;

                    level.Identity = Level_VALUE.Identity;

                    level.Type = Level_VALUE.Type;

                    level.ObjectByteArray = (Byte[])inflect[0];

                    level.TypeByteArray = (Byte[])inflect[1];

                    level.Expressionxportable = Level_VALUE.Expressionxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteXleve_Y>(collectionResult);
            }
        }
    }
}
