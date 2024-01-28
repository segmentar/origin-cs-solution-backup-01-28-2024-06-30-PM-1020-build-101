using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ARichtextbox : RichTextBox,
Scopexportableinterface.IAccessorder,
Scopexportableinterface.IStyleorder<ARichtextbox>
    {
        public ARichtextbox()
        {
            Accessorder();

            return;
        }

        ~ARichtextbox()
        {
            return;
        }

        public void Accessorder()
        {
            Styleorder();

            return;
        }

        public ARichtextbox Styleorder()
        {
            this.ForeColor = Immutable.ForeColor;

            this.BackColor = Immutable.BackColor;

            this.ReadOnly = Immutable.ReadOnly;

            this.Font = Immutable.Font;

            return this;
        }
    }
}
