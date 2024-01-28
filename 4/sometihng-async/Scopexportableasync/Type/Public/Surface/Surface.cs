using Core;

namespace Core
{
    using System;

    public partial class Scopexportableasync
    {
        public static Object Surface(Scopexportableasynccontext value_SCOPEXPORTABLEASYNCCONTEXT)
        {
            Object objectResult = default;

            Object objectValue;

            objectValue = default;

            if (value_SCOPEXPORTABLEASYNCCONTEXT.ShouldTask is true)
            {
                objectValue = Task(value_SCOPEXPORTABLEASYNCCONTEXT);
            }
            else
                "false".ToString();

            if (value_SCOPEXPORTABLEASYNCCONTEXT.ShouldThread is true)
            {
                objectValue = Thread(value_SCOPEXPORTABLEASYNCCONTEXT);
            }
            else
                "false".ToString();

            objectResult = objectValue;

            return objectResult;
        }
    }
}
