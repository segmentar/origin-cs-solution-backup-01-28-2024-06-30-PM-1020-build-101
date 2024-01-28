using Core;

namespace Core
{
    using System;

    public partial class ScopexportableCode
    {
        public enum RenderPath
        {
            Unset,
            Core_Scopexportable_Debug,
            Core_Scopexportable_Info,
            Core_Scopexportable_Render,
            Core_Scopexportable_Fatal
        }

        public enum FormDirection
        {
            Unset,
            Top,
            Bottom,
            Left,
            Right
        }
    }
}
