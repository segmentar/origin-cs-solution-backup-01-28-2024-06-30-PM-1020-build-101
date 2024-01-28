using Core;

namespace Core
{
    using System;

    using System.Drawing;

    public partial class ARichtextboxDefault
    {
        public static Color BackColorDefault;

        public static Color ForeColorDefault;

        public static Boolean ReadOnlyDefault;

        public static String FontFamilyDefault;

        public static Single FontSizeDefault;

        public static FontStyle FontStyleDefault;

        public static Font FontDefault;

        static ARichtextboxDefault()
        {
            BackColorDefault = Color.DarkBlue;

            ForeColorDefault = Color.Yellow;

            ReadOnlyDefault = true;

            FontFamilyDefault = Scopexportablename.EntityFontFamily;

            FontSizeDefault = 16.00F;

            FontStyleDefault = FontStyle.Bold;

            FontDefault = new Font(FontFamilyDefault, FontSizeDefault, FontStyleDefault);

            return;
        }
    }
}
