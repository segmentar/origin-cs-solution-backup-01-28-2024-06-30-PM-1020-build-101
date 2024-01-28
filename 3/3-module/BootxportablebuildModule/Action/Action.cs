using Core;

namespace Core
{
    using System;

    public partial class BootxportablebuildModule
    {
        public static BootxportablebuildModule Action()
        {
            BootxportablebuildModule moduleResult = default;

            moduleResult = Default();

            if (MaterialxportablePolicy.MaterialxportablereadbuildPolicy is true)
            {
                try
                {
                    Bootxportablerender.GroupRender($"{BootxportableCode.ProductPath.Core_Bootxportable_Render}-{nameof(BootxportablebuildModule)}-0", BootxportablebuildCycle.XZeroth);

                    Bootxportablerender.GroupRender($"{BootxportableCode.ProductPath.Core_Bootxportable_Render}-{nameof(BootxportablebuildModule)}-1", BootxportablebuildCycle.XPrimary.XSingle);
                }
                catch (Exception exception)
                {
                    Bootxportablerender.GroupRender($"{BootxportableCode.ProductPath.Core_Bootxportable_Fatal}", exception);
                }
            }
            else
                "false".ToString();

            return moduleResult;
        }
    }
}
