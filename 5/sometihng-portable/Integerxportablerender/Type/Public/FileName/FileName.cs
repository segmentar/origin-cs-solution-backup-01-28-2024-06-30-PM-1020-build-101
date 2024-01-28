using Core;

namespace Core
{
    using System;

    public partial class Integerxportablerender
    {
        public static String FileName(String[] Split_ARRAY, Int32 Ordinal_VALUE)
        {
            String stringResult = default;

            try
            {
                var aoth = Split_ARRAY.Length;

                var roth = (aoth - 1);

                var eoth = Split_ARRAY[roth];

                var format = String.Format("{0} {1}", eoth, Ordinal_VALUE);

                var result = format;

                stringResult = result;

            } catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }

            return stringResult;
        }
    }
}
