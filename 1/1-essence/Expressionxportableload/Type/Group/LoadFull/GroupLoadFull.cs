using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableload
    {
        public static Object[] GroupLoadFull(String Filename_VALUE)
        {
            Object[] arrayResult = default;

            var inflect = new Object[2];

            inflect[0] = Expressionxportableloadcontext.Data();

            inflect[1] = Expressionxportablereadclose.Data();

            var array = GroupLoad((Expressionxportableloadcontext)inflect[0], (Expressionxportablereadclose)inflect[1], Filename_VALUE);

            arrayResult = array;

            return arrayResult;
        }
    }
}
