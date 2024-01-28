using Core;

namespace Core
{
    using System;

    using System.Drawing;
    using System.Windows.Forms;

    public partial class ATextboxDefault
    {
        public static Color BackColorDefault;

        public static Color ForeColorDefault;

        public static BorderStyle BorderStyleDefault;

        public static String FontFamlyDefault;

        public static Single FontSizeDefault;

        public static FontStyle FontStyleDefault;

        public static Font FontDefault;

        static ATextboxDefault()
        {
            BackColorDefault = Color.LightCyan;

            ForeColorDefault = Color.DarkRed;

            FontFamlyDefault = Scopexportablename.EntityFontFamily;

            FontSizeDefault = 12.00F;

            FontStyleDefault = FontStyle.Regular;

            FontDefault = new Font(FontFamlyDefault, FontSizeDefault, FontStyleDefault);

            return;
        }
    }
}
