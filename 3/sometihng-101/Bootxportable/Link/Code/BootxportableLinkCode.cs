using Core;

namespace Core
{
    using System;

    public partial class BootxportableCode
    {
        public enum RenderPath
        {
            Unset,
            Core_Bootxportable_Debug,
            Core_Bootxportable_Info
        }
        public enum ProductPath
        {
            Unset,
            Core_Bootxportable_Render,
            Core_Bootxportable_Fatal
        }
    }
}
