using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ATextbox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            PropagateKeyPressRedirect(this, e);

            if (ATextboxPrevent.PropagateKeyPressPrevent)
            {
                return;
            }
            else
            {
                base.OnKeyPress(e);
            }

            return;
        }
    }
}
