using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AForm
    {
        public partial class Immutable
        {
            public static readonly String Text;

            public static readonly Boolean ShowIcon;

            public static readonly FormStartPosition FormStartPosition;

            public static readonly Boolean KeyPreview;

            static Immutable()
            {
                Text = AFormDefault.TextDefault;

                ShowIcon = AFormDefault.ShowIconDefault;

                FormStartPosition = AFormDefault.FormStartPositionDefault;

                KeyPreview = AFormDefault.KeyPreviewDefault;

                return;
            }
        }
    }
}
