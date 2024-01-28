using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class Bootxportableformat
    {
        public static String DirectoryRoute(String value_STRING, Boolean answer_ASSEMBLY_should)
        {
            String stringResult = default;

            var split = value_STRING.Split(Bootxportableradical.EntityFormat, StringSplitOptions.RemoveEmptyEntries);

            var result = String.Empty;

            if (answer_ASSEMBLY_should is true)
            {
                FileInfo fileInfo;

                fileInfo = new FileInfo(Assembly.GetEntryAssembly().Location);

                var value = Path.GetDirectoryName(fileInfo.FullName);

                result = Path.Combine(result, value);
            }
            else
                "false".ToString();

            foreach (String stringValue in split)
            {
                result = Path.Combine(result, stringValue);

                continue;
            }

            stringResult = result;

            return stringResult;
        }
    }
}
