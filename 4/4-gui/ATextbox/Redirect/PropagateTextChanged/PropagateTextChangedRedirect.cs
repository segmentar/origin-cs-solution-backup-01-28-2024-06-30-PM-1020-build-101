using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ATextbox
    {
        public static void PropagateTextChangedRedirect(Object sender, EventArgs e)
        {
            Boolean isDefaultCheck, isNotDefaultCheck;

            isDefaultCheck = (Form.ActiveForm == default).Equals(true);

            isNotDefaultCheck = isDefaultCheck is false;

            if (isNotDefaultCheck is true)
            {
                if (Form.ActiveForm.Controls.OfType<APanel>().First<APanel>().Controls.OfType<ARichtextbox>().First<ARichtextbox>().Focused is true)
                {
                    Form.ActiveForm.Controls.OfType<ATextbox>().First<ATextbox>().Focus();
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            var reflect = (ATextbox)(sender as Object);

            var result = Scopexportablemmanager.Manage(reflect.Text);

            var value = reflect.FindForm().Controls.OfType<APanel>().First<APanel>().Controls.OfType<ARichtextbox>().First<ARichtextbox>();

            value.Text = result;

            return;
        }
    }
}
