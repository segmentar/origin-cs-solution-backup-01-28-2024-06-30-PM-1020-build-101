using Core;

namespace Core
{
    using System;

    public partial class Scopexportableasync
    { 
        public static Action Action(Scopexportableasynccontext value_SCOPEXPORTABLEASYNCCONTEXT)
        {
            Action actionResult = default;

            Action action;

            action = default;

            if (value_SCOPEXPORTABLEASYNCCONTEXT.ShouldSTA is true)
            {
                action = new Action(GroupSTA);
            }
            else
                "false".ToString();

            if (value_SCOPEXPORTABLEASYNCCONTEXT.ShouldMTA is true)
            {
                action = new Action(GroupMTA);
            }
            else
                "false".ToString();

            actionResult = action;

            return actionResult;
        }
    }
}
