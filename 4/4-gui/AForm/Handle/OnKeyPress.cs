using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AForm
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            PropagateKeyPressRedirect(this, e);

            if (AFormPrevent.PropagateKeyPressPrevent)
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
