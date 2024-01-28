using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablereload
    {
        public static Expressionxportable GroupReloadInExpression(Expressionxportable value_EXPRESSIONXPORTABLE, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT, Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT, Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE, Expressionxportablereloadcontext value_EXPRESSIONXPORTABLERELOADCONTEXT, String FileName__VALUE)
        {
            Expressionxportable expressionxportableResult = default;

            var CurrentDirectory__VALUE = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory__VALUE, Expressionxportablestoreextension.EntityFolderName);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, FileName__VALUE);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablestoreextension.EntityExtension);

            var array = GroupReload(value_EXPRESSIONXPORTABLE, value_EXPRESSIONXPORTABLESAVECONTEXT, value_EXPRESSIONXPORTABLEWRITECLOSE, value_EXPRESSIONXPORTABLELOADCONTEXT, value_EXPRESSIONXPORTABLEREADCLOSE, value_EXPRESSIONXPORTABLERELOADCONTEXT, path_FILE_filename_with_extension);

            var reflect = (ExpressionxportablereadbuildModule)(array[2] as Object);

            var result = reflect.ExpressionxportablereadbuildPort.Expressionxportable;

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}