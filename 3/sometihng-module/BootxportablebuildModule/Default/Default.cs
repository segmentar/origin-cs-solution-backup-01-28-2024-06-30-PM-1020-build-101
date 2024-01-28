using Core;

namespace Core
{
    using System;

    public partial class BootxportablebuildModule
    {
        public static BootxportablebuildModule Default()
        {
            BootxportablebuildModule module;

            module = new BootxportablebuildModule();

            var inflect = new Object[0];

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            BootxportablebuildCycle.XZeroth = xzeroth;

            module.XOne();

            return module;
        }
    }
}
