using Core;

namespace Core
{
    using System;

    public partial class Integerxportablerender
    {
        public static String Error()
        {
            String stringResult = default;

            try
            {
                var concat = String.Concat(String.Empty, "This object just so happned to be default", ' ', ":(");

                var result = concat;

                stringResult = result;

            } catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }

            return stringResult;
        }
    }
}
