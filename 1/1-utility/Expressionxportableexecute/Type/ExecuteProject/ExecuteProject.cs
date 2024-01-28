using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableexecute
    {
        public static Expressionxportable ExecuteProject(Expressionxportable value_EXPRESSIONXPORTABLE, Boolean answer_CREATE_should)
        {
            Expressionxportable expressionxportableResult = default;

            var CurrentDirectory_PATH = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory_PATH, Expressionxportablename.EntityProjectFolderName);

            var create = true;

            create = create && answer_CREATE_should is true;

            create = create && Directory.Exists(path_DIRECTORY_full_name) is false;

            if (create is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            foreach (FileInfo fileInfo in Expressionxportableio.ExpressionxportableFileSetSurface(path_DIRECTORY_full_name, true))
            {
                var value = File.ReadAllText(fileInfo.FullName);

                ExecuteFile(value_EXPRESSIONXPORTABLE, value);

                continue;
            }

            var result = value_EXPRESSIONXPORTABLE;

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}
