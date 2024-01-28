using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablemoduleSeal
    {
        public ExpressionxportablemodulePort Export()
        {
            ExpressionxportablemodulePort portResult = default;

            ExpressionxportablemodulePort port;

            port = new ExpressionxportablemodulePort();

            port.ModuleArray = ModuleArray;

            port.DirectoryInfoArray = DirectoryInfoArray;

            port.FileInfoArray = FileInfoArray;

            portResult = port;

            return portResult;
        }
    }
}
