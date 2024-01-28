using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XQuadruple
        {
            public static IList<ExpressionxportablewriteXlev_lY> FunctionLevelSet(ExpressionxportablewriteXle_elY[] LeveL_ARRAY)
            {
                ICollection<ExpressionxportablewriteXlev_lY> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablewriteXlev_lY>();

                foreach (ExpressionxportablewriteXle_elY Level_VALUE in LeveL_ARRAY)
                {
                    var reflect = (Expressionxportablestringsafe)(Level_VALUE.Expressionxportable.StringIdentity as Object);
                    
                    ExpressionxportablewriteXlev_lY level;

                    level = new ExpressionxportablewriteXlev_lY();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relate = Level_VALUE.Relate;

                    level.Identity = reflect.Value;

                    level.Type = Level_VALUE.Expressionxportable.Type;

                    level.Expressionxportable = Level_VALUE.Expressionxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteXlev_lY>(collectionResult);
            }
        }
    }
}
