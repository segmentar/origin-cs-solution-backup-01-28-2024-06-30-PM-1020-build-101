using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class ARichtextbox
    {
        public partial class Immutable
        {
            public static readonly Color BackColor;

            public static readonly Color ForeColor;

            public static readonly Boolean ReadOnly;

            public static readonly String FontFamily;

            public static readonly Single FontSize;

            public static readonly FontStyle FontStyle;

            public static readonly Font Font;

            static Immutable()
            {
                BackColor = ARichtextboxDefault.BackColorDefault;

                ForeColor = ARichtextboxDefault.ForeColorDefault;

                ReadOnly = ARichtextboxDefault.ReadOnlyDefault;

                FontFamily = ARichtextboxDefault.FontFamilyDefault;

                FontSize = ARichtextboxDefault.FontSizeDefault;

                FontStyle = ARichtextboxDefault.FontStyleDefault;

                Font = ARichtextboxDefault.FontDefault;

                return;
            }
        }
    }
}
