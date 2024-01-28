using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableio
    {
        public static DirectoryInfo[] ExpressionxportableFolderSetSurface(String Directory_VALUE, Boolean answer_SELF_should)
        {
            DirectoryInfo[] arrayResult = default;

            var list = ExpressionxportableFolderSet(Directory_VALUE, answer_SELF_should);

            var array = new DirectoryInfo[list.Count];

            list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
