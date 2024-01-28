using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class BootxportablebuildModule
    {
        public partial class XSingle
        {
            public static IList<BootxportablebuildX_evelY> FunctionLevelSet(String DirectoryFullName___VALUE)
            {
                ICollection<BootxportablebuildX_evelY> collectionResult = default;

                collectionResult = new Collection<BootxportablebuildX_evelY>();

                var array = Directory.GetFiles(DirectoryFullName___VALUE);

                foreach (String stringValue in array)
                {
                    FileInfo fileInfo;

                    fileInfo = new FileInfo(stringValue);

                    var value = File.ReadAllText(fileInfo.FullName);

                    var result = Expressionxportableapi.Root();

                    Expressionxportableapi.ScheduleText(result, value);

                    Expressionxportableapi.ReloadInExpressionFull(result, Path.GetRandomFileName());

                    BootxportablebuildX_evelY level;

                    level = new BootxportablebuildX_evelY();

                    level.FileInfo = fileInfo;

                    level.Text = Bootxportablestringsafe.ForgeDefault(value);

                    level.Expressionxportable = result;

                    collectionResult.Add(level);

                    continue;
                }

                return new List<BootxportablebuildX_evelY>(collectionResult);
            }
        }
    }
}
