using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableio
    {
        public static FileInfo[] ExpressionxportableFileSetSurface(String Directory_VALUE, Boolean answer_SELF_should)
        {
            FileInfo[] arrayResult = default;

            var list = ExpressionxportableFileSet(Directory_VALUE, answer_SELF_should);

            var array = new FileInfo[list.Count];

            list.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
