using Core;

namespace Core
{
    using System;

    public partial class Expressionxportable
    {
        public partial class Immutable
        {
            public static readonly String[] SystemIf;

            static Immutable()
            {
                SystemIf = ExpressionxportableDefault.SystemIfDefault;

                return;
            }
        }
    }
}
