using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Integerxportablerender
    {
        public static String FullName(String[] Split_ARRAY)
        {
            String stringResult = default;

            try
            {
                var path = String.Empty;

                foreach (String Split_ITEM in Split_ARRAY)
                {
                    path = Path.Combine(path, Split_ITEM);

                    continue;
                }

                var result = path;

                stringResult = result;

            } catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }

            return stringResult;
        }
    }
}
