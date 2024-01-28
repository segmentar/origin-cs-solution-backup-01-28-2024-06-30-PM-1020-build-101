using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scopexportableasync
    {
        public static Thread Thread(Scopexportableasynccontext value_SCOPEXPORTABLEASYNCCONTEXT)
        {
            Thread threadResult = default;

            ThreadStart threadStart;

            threadStart = new ThreadStart(Action(value_SCOPEXPORTABLEASYNCCONTEXT));

            Thread thread;

            thread = new Thread(threadStart);

            threadResult = thread;

            return threadResult;
        }
    }
}
