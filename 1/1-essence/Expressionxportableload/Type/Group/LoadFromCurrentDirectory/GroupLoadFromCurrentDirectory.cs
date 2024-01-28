using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableload
    {
        public static Expressionxportable GroupLoadFromCurrentDirectory(Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT, Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE, String FileName__VALUE)
        {
            Expressionxportable expressionxportableResult = default;

            var CurrentDirectory__PATH = Directory.GetCurrentDirectory();

            var path_FILE_filename = Path.Combine(CurrentDirectory__PATH, FileName__VALUE);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablestoreextension.EntityExtension);

            var array = GroupLoad(value_EXPRESSIONXPORTABLELOADCONTEXT, value_EXPRESSIONXPORTABLEREADCLOSE, path_FILE_filename_with_extension);

            var reflect = (ExpressionxportablereadbuildPort)(array[2] as Object);

            var result = reflect.Expressionxportable;

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}
