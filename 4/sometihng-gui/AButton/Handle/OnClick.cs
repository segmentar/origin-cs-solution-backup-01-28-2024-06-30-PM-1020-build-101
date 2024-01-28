using Core;

namespace Core
{
    using System;

    public partial class AButton
    {
        protected override void OnClick(EventArgs e)
        {
            PropagateClickRedirect(this, e);

            if (AButtonPrevent.PropagateClickPrevent)
            {
                return;
            }
            else
            {
                base.OnClick(e);
            }

            return;
        }
    }
}
