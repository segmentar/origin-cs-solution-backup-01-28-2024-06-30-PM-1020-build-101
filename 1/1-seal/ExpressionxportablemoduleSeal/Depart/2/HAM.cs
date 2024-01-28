using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ExpressionxportablemoduleSeal
    {
        public void HAM()
        {
            var value = Expressionxportablefolder.Folder();

            var array = Expressionxportableio.ExpressionxportableFolderSetSurface(value.FullName, true);

            var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(Desorb[1]);

            foreach (DirectoryInfo directoryInfo in array)
            {
                var name = Path.GetFileNameWithoutExtension(directoryInfo.FullName);

                var boolean = true;

                boolean = boolean && Object.Equals(Module, name) is true;

                boolean = boolean && Directory.Exists(directoryInfo.FullName) is true;

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = boolean is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                list.Add(directoryInfo);

                continue;
            }

            DirectoryInfoArray = new DirectoryInfo[list.Count];

            list.CopyTo(DirectoryInfoArray, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            Threethirdtertiarytriple();

            list.Clear();

            return;
        }
    }
}
