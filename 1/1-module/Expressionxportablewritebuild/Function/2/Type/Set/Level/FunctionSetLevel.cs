using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XDouble
        {
            public static IList<ExpressionxportablewriteXl_velY> FunctionLevelSet(ExpressionxportablewriteX_evelY[] Level_ARRAY)
            {
                ICollection<ExpressionxportablewriteXl_velY> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablewriteXl_velY>();

                foreach (ExpressionxportablewriteX_evelY Item_VALUE in Level_ARRAY)
                {
                    var layer = 1;

                    foreach (ExpressionxportablewriteX_evelY Entry_VALUE in Level_ARRAY)
                    {
                        var array = Expressionxportableset.ExpressionxportableAllSetSurface(Entry_VALUE.Expressionxportable, true);

                        foreach (Expressionxportable expressionxportable in array)
                        {
                            var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(expressionxportable.LayerArrayListObject);

                            Boolean isEqualCheck, shouldContinueCheck;

                            isEqualCheck = list.Contains(Item_VALUE.Expressionxportable) is true;

                            shouldContinueCheck = isEqualCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            layer = layer + 1;

                            break;
                        }

                        continue;
                    }

                    ExpressionxportablewriteXl_velY level;

                    level = new ExpressionxportablewriteXl_velY();

                    level.Ordinal = Item_VALUE.Ordinal;

                    level.Layer = layer;

                    level.Expressionxportable = Item_VALUE.Expressionxportable;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteXl_velY>(collectionResult);
            }
        }
    }
}
