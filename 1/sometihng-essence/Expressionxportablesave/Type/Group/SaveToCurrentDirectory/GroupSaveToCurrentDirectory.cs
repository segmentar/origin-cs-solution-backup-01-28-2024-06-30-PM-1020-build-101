using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablesave
    {
        public static void GroupSaveToCurrentDirectory(Expressionxportable value_EXPRESSIONXPORTABLE, Expressionxportablesavecontext value_EXPRESSIONXPORTABLESAVECONTEXT, Expressionxportablewriteclose value_EXPRESSIONXPORTABLEWRITECLOSE, String FileName__VALUE)
        {
            var CurrentDirectory__PATH = Directory.GetCurrentDirectory();

            var path_FILE_filename = Path.Combine(CurrentDirectory__PATH, FileName__VALUE);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablestoreextension.EntityExtension);

            GroupSave(value_EXPRESSIONXPORTABLE, value_EXPRESSIONXPORTABLESAVECONTEXT, value_EXPRESSIONXPORTABLEWRITECLOSE, path_FILE_filename_with_extension);

            return;
        }
    }
}
