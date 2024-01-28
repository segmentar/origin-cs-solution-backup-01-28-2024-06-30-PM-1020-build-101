using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static Object[] Load(String filename)
        {
            Object[] arrayResult = default;

            arrayResult = Expressionxportableload.GroupLoadFull(filename);

            return arrayResult;
        }
    }
}
