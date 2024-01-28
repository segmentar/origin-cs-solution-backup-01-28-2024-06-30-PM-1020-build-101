using Core;

namespace Core
{
    using System;

    public partial class Bootxportableapi
    {
        public static Object[] Compile()
        {
            Object[] arrayResult = default;

            arrayResult = Bootxportablecompile.Compile();

            return arrayResult;
        }
    }
}
