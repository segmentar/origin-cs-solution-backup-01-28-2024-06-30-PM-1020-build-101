using Core;

namespace Core
{
    using System;

    using System.Threading;

    public partial class Scopexportablemagic
    {
        public static Thread ScopexportablemagicThreadStartDispenser(Object reflect_OBJECT, Int32 Linger_VALUE)
        {
            Thread threadResult = default;

            var result = (Thread)(reflect_OBJECT as Object);

            result.Start();

            result.Join(Linger_VALUE);

            threadResult = result;

            return threadResult;
        }
    }
}
