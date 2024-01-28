using Core;

namespace Core
{
    using System;

    public partial class BootxportablebuildModule
    {
        public partial class XSingle
        {
            public static XSingle ForgeLevel()
            {
                XSingle xsingleResult = default;

                var value = Bootxportablefolder.Folder(true);

                var array = FunctionLevelSetSurface(value);

                XSingle xsingle;

                xsingle = new XSingle(array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
