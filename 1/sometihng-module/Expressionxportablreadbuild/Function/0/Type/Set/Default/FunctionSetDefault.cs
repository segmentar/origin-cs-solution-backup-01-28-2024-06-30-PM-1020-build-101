using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablereadbuildModule
    {   
        public partial class XZeroth
        {
            public static IList<Expressionxportable> FunctionDefaultSet(ExpressionxportablereadXlev_lY[] Level_ARRAY)
            {
                ICollection<Expressionxportable> collectionResult = default;

                collectionResult = new Collection<Expressionxportable>();

                foreach (ExpressionxportablereadXlev_lY Level_VALIE in Level_ARRAY)
                {
                    collectionResult.Add(Level_VALIE.Expressionxportable);

                    continue;
                }

                return new List<Expressionxportable>(collectionResult);
            }
        }
    }
}
