using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AButton
    {
        public partial class Immutable
        {
            public static readonly Int32 Width;

            public static readonly Int32 Height;

            public static readonly Int32 PaddingHorizontal;

            public static readonly Int32 PaddingVertical;

            public static readonly FlatStyle FlatStyle;

            static Immutable()
            {
                Width = AButtonDefault.WidthDefault;

                Height = AButtonDefault.HeightDefault;

                PaddingHorizontal = AButtonDefault.PaddingHorizontalDefault;

                PaddingVertical = AButtonDefault.PaddingVerticalDefault;

                FlatStyle = AButtonDefault.FlatStyleDefault;

                return;
            }
        }
    }
}
