using Core;

namespace Core
{
    using System;

    public partial class BootxportablebuildModule
    {
        public partial class XSingle
        {
            public static BootxportablebuildX_evelY[] FunctionLevelSetSurface(String DirectoryFullName___VALUE)
            {
                BootxportablebuildX_evelY[] arrayResult = default;

                var list = FunctionLevelSet(DirectoryFullName___VALUE);

                var array = new BootxportablebuildX_evelY[list.Count];

                list.CopyTo(array, BootxportablePolicy.BootxportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
