using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableDefault
    {
        public static String[] SystemIfDefault;

        static ExpressionxportableDefault() 
        {
            SystemIfDefault = new String[] {

                "vunlock _core_system_if_",
                "unlock _if_",
                "branch _query_require_",
                "release"
            };

            return;
        }
    }
}
