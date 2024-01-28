using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XTriple
        {
            public static IList<ExpressionxportablewriteXle_elY> FunctionLevelSet(ExpressionxportablewriteXl_velY[] Level_ARRAY, Expressionxportable[] array_EXPRESSIONXPORTABLE)
            {
                ICollection<ExpressionxportablewriteXle_elY> collectionResult = default;

                collectionResult = new List<ExpressionxportablewriteXle_elY>();

                foreach (ExpressionxportablewriteXl_velY Level_ITEM in Level_ARRAY)
                {
                    var relate = 0;

                    foreach (ExpressionxportablewriteXl_velY Level_ENTRY in Level_ARRAY)
                    {
                        var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(Level_ENTRY.Expressionxportable.LayerArrayListObject);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = list.Contains(Level_ITEM.Expressionxportable) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        relate = Level_ENTRY.Ordinal;

                        break;
                    }

                    ExpressionxportablewriteXle_elY level;

                    level = new ExpressionxportablewriteXle_elY();

                    level.Ordinal = Level_ITEM.Ordinal;

                    level.Layer = Level_ITEM.Layer;

                    level.Relate = relate;

                    level.Expressionxportable = Level_ITEM.Expressionxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteXle_elY>(collectionResult);
            }
        }
    }
}
