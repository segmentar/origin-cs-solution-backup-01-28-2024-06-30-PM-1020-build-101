using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablerender
    {
        public static String FullName(String[] Split_ARRAY)
        {
            String stringResult = default;

            var path = String.Empty;

            foreach (String Split_ITEM in Split_ARRAY)
            {
                path = Path.Combine(path, Split_ITEM);

                continue;
            }

            var result = path;

            stringResult = result;

            try
            {

            } catch (Exception exception)
            {
                Expressionxportablerenderlog.Log(exception);
            }

            return stringResult;
        }
    }
}
