using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablelinear
    {
        public static void Export()
        {
            Expressionxportable.ExecuteLinkedListObject = ExecuteLinkedList;

            Expressionxportable.ParameterArrayListObject = ParameterArrayList;

            return;
        }
    }
}
