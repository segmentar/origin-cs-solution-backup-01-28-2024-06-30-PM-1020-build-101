using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class Scopexportableasync
    {
        public static Task Task(Scopexportableasynccontext value_SCOPEXPORTABLEASYNCCONTEXT)
        {
            Task taskResult = default;

            Task task;

            task = new Task(Action(value_SCOPEXPORTABLEASYNCCONTEXT));

            taskResult = task;

            return taskResult;
        }
    }
}
