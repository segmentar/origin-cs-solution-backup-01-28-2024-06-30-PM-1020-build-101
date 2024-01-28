using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class APanelDefault
    {
        public static Color BackColorDefault;

        public static DockStyle DockStyleDefault;

        static APanelDefault()
        {
            BackColorDefault = Color.Orange;

            DockStyleDefault = DockStyle.Fill;

            return;
        }
    }
}
