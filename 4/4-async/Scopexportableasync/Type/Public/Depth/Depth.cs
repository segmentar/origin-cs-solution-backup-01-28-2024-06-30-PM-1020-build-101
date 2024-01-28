using Core;

namespace Core
{
    using System;

    public partial class Scopexportableasync
    {
        public static Object Depth(Boolean answer_STA_should, Boolean answer_MTA_should, Boolean answer_TASK_should, Boolean answer_THREAD_should)
        {
            Object objectResult = default;

            Scopexportableasynccontext scopexportableasynccontext;

            scopexportableasynccontext = new Scopexportableasynccontext();

            if (answer_STA_should is true)
            {
                scopexportableasynccontext.ShouldSTA = true;
            }
            else
                "false".ToString();

            if (answer_MTA_should is true)
            {
                scopexportableasynccontext.ShouldMTA = true;
            }
            else
                "false".ToString();

            if (answer_TASK_should is true)
            {
                scopexportableasynccontext.ShouldTask = true;
            }
            else
                "false".ToString();

            if (answer_THREAD_should is true)
            {
                scopexportableasynccontext.ShouldThread = true;
            }
            else
                "false".ToString();

            var result = Surface(scopexportableasynccontext);

            objectResult = result;

            return objectResult;
        }
    }
}
