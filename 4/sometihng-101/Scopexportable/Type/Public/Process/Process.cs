using Core;

namespace Core
{
    using System;
    using System.IO;

    public partial class Scopexportable
    {
        public static void Process(Boolean answer_MONITOR_should)
        {
            Scopexportablemstate.Import(Scopexportablemstate.Data());

            Scopexportablemframe.Import(Scopexportablemframe.Data());

            Scopexportablemfilearray.Import(Scopexportablemfilearray.Data());

            Scopexportablemframe.LinkedList.AddFirst(Scopexportablemtransaction.Data());

            if (answer_MONITOR_should is true)
            {
                var value = Scopexportableasync.Depth(true, false, false, true);

                var result = Scopexportablemagic.ScopexportablemagicThreadStartDispenser(value, 1000);
            }
            else
                "false".ToString();

            foreach (FileInfo fileInfo in Scopexportablemfilearray.FileInfoArray)
            {
                Scopexportablemagic.ScopexportablemagicStackCastDispenser(Scopexportablemfilearray.FileInfoStack).Push(fileInfo);

                continue;
            }

            while (true)
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Scopexportablemstate.IsRun is false;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Scopexportableupdate.Update();

                continue;
            }

            return;
        }
    }
}
