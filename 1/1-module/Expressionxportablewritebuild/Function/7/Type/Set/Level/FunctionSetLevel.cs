using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablewritebuildModule
    {
        public partial class XSeptuple
        {
            public static IList<ExpressionxportablewriteUl_velV> FunctionLevelSet(ExpressionxportablewriteU_evelV[] Level_ARRAY)
            {
                ICollection<ExpressionxportablewriteUl_velV> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablewriteUl_velV>();

                foreach (ExpressionxportablewriteU_evelV Level_VALUE in Level_ARRAY)
                {
                    ExpressionxportablewriteUl_velV level;

                    level = new ExpressionxportablewriteUl_velV();

                    level.Ordinal = Level_VALUE.Ordinal;

                    level.Layer = Level_VALUE.Layer;

                    level.Relate = Level_VALUE.Relate;

                    level.Identity = Level_VALUE.Identity;

                    level.Type = Level_VALUE.Type;

                    level.ObjectByteArray = Level_VALUE.ObjectByteArray;

                    level.TypeByteArray = Level_VALUE.TypeByteArray;

                    level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                    level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                    level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                    level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<ExpressionxportablewriteUl_velV>(collectionResult);
            }
        }
    }
}
