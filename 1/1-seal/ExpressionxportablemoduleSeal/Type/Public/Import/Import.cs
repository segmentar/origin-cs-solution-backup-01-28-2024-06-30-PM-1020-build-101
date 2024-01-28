using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablemoduleSeal
    {
        public void Import(ExpressionxportablemodulePort Port_VALUE)
        {
            ModuleArray = ModuleArray = Port_VALUE.ModuleArray;

            DirectoryInfoArray = Port_VALUE.DirectoryInfoArray;

            FileInfoArray = Port_VALUE.FileInfoArray;

            return;
        }
    }
}
