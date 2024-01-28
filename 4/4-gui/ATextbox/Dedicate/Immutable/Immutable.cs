using Core;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ATextbox
    {
        public partial class Immutable
        {
            public static readonly Color BackColor;

            public static readonly Color ForeColor;

            public static readonly BorderStyle borderStyle;

            public static readonly String FontFamly;

            public static readonly Single FontSize;

            public static readonly FontStyle FontStyle;

            public static readonly Font Font;

            static Immutable()
            {
                BackColor = ATextboxDefault.BackColorDefault;

                ForeColor = ATextboxDefault.ForeColorDefault;

                borderStyle = ATextboxDefault.BorderStyleDefault;

                FontFamly = ATextboxDefault.FontFamlyDefault;

                FontSize = ATextboxDefault.FontSizeDefault;

                FontStyle = ATextboxDefault.FontStyleDefault;

                Font = ATextboxDefault.FontDefault;

                return;
            }
        }
    }
}
