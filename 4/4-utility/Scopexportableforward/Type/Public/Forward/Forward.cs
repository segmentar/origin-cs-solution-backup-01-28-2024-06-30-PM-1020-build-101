using Core;

namespace Core
{
    using System;

    public partial class Scopexportableforward
    {
        public static void Forward()
        {
            Scopexportablemframe.Pointer = Scopexportablemframe.Pointer + 1;

            return;
        }
    }
}
