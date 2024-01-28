using Core;

namespace Core
{
    using System;

    public partial class Scopexportableasync
    {
        [STAThread]
        public static void GroupSTA()
        {
            Target();

            return;
        }
    }
}
