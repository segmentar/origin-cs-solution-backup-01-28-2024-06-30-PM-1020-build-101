using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XTriple
        {
            public static IList<ExpressionxportablereadXle_elY> FunctionLevelSet(ExpressionxportablereadXl_velY[] Level_ARRAY)
            {
                ICollection<ExpressionxportablereadXle_elY> collectionResult = default;

                collectionResult = new List<ExpressionxportablereadXle_elY>();

                foreach (ExpressionxportablereadXl_velY Level_VALUE in Level_ARRAY)
                {
                    var inflect = new Object[2];

                    inflect[0] = Expressionxportableremoteout.RemoteType(Level_VALUE.TypeByteArray);

                    inflect[1] = Expressionxportableremoteout.Remote(Level_VALUE.ObjectByteArray, (Type)inflect[0]);

                    ExpressionxportablereadXle_elY level;

                    level = new ExpressionxportablereadXle_elY();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relate = Level_VALUE.Relate;

                    level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                    level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                    level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                    level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                    level.Identity = Level_VALUE.Identity;

                    level.ObjectByteArray = Level_VALUE.ObjectByteArray;

                    level.TypeByteArray = Level_VALUE.TypeByteArray;

                    level.Object = (Object)inflect[1];

                    level.Type = (Type)inflect[0];

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablereadXle_elY>(collectionResult);
            }
        }
    }
}
