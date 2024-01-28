using Core;

namespace Core
{
    using System;

    public partial class Scopexportableasync
    {
        [MTAThread]
        public static void GroupMTA()
        {
            Target();

            return;
        }
    }
}
