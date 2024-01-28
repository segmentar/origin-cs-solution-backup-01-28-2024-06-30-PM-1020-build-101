using Core;

namespace Core
{
    using System;

    public partial class Scopexportablebackward
    {
        public static void Backward()
        {
            Scopexportablemframe.Pointer = Scopexportablemframe.Pointer - 1;
            
            return;
        }
    }
}
