using Core;

namespace Core
{
    using System;

    public partial class Integerxportablerender
    {
        public static String Normalize(String PathName__VALUE)
        {
            String stringResult = default;

            try
            {
                var separator = new Char[] { (Char)Integerxportableascii.EntityDash };

                var split = PathName__VALUE.Split(separator, StringSplitOptions.None);

                var join = String.Join(((Char)Integerxportableascii.EntityUnderscore).ToString(), split);

                var result = join;

                stringResult = result;

            } catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }

            return stringResult;
        }
    }
}
