using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scopexportableupdate
    {
        public static void Update()
        {
            if (Object.Equals(Scopexportablemfilearray.FileInfoStack.Count, 0) is true)
            {
                Scopexportablemstate.IsRun = false;

                return;
            }
            else
                "false".ToString();

            while (true)
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Scopexportablemstate.IsPause is true;

                shouldBreakCheck = isEqualCheck is false;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                continue;
            }

            Scopexportablemfilearray.Sync();

            Thread.Sleep(Scopexportablemstate.Interval);

            Scopexportablemframe.Pointer = Scopexportablemframe.Pointer + 1;

            Scopexportablemframe.LinkedList.AddLast(Scopexportablemtransaction.Data());

            return;
        }
    }
}
