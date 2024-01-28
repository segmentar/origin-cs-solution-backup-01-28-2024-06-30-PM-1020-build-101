using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ATextbox : TextBox,
Scopexportableinterface.IAccessorder,
Scopexportableinterface.IStyleorder<ATextbox>,
Scopexportableinterface.IEventorder<ATextbox>
    {
        public ATextbox()
        {
            Accessorder();

            return;
        }

        ~ATextbox()
        {
            return;
        }

        public void Accessorder()
        {
            Styleorder().Eventorder();

            return;
        }

        public ATextbox Eventorder()
        {
            this.TextChanged += PropagateTextChangedRedirect;

            this.KeyPress += PropagateKeyPressRedirect;

            return this;
        }

        public ATextbox Styleorder()
        {
            this.ForeColor = Immutable.ForeColor;

            this.BackColor = Immutable.BackColor;

            this.BorderStyle = Immutable.borderStyle;

            this.Font = Immutable.Font;

            return this;
        }
    }
}
