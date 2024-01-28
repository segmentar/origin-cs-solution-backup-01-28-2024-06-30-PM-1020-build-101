using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Expressionxportableset
    {
        public static IList<Expressionxportable> ExpressionxportableAllSet(Expressionxportable value_EXPRESSIONXPORTABLE, Boolean answer_SELF_should)
        {
            ICollection<Expressionxportable> collectionResult = default;

            collectionResult = new Collection<Expressionxportable>();

            if (answer_SELF_should is true)
            {
                collectionResult.Add(value_EXPRESSIONXPORTABLE);
            }
            else
                "false".ToString();

            var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value_EXPRESSIONXPORTABLE.LayerArrayListObject);

            foreach (Expressionxportable item in list)
            {
                var array = ExpressionxportableAllSetSurface(item, answer_SELF_should);

                foreach (Expressionxportable entry in array)
                {
                    collectionResult.Add(entry);

                    continue;
                }

                continue;
            }

            return new List<Expressionxportable>(collectionResult);
        }
    }
}
