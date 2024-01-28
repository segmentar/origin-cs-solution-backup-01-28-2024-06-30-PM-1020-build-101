using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;
    public partial class Scopexportablefontup
    {
        public static void Fontup()
        {
            foreach (AForm aform in Application.OpenForms)
            {
                var inflect = new Object[2];

                inflect[0] = aform.Controls.OfType<ATextbox>().First<ATextbox>();

                inflect[1] = aform.Controls.OfType<APanel>().First<APanel>().Controls.OfType<ARichtextbox>().First<ARichtextbox>();

                var value = 0.00F;

                value = value + ((ATextbox)inflect[0]).Font.Size;

                value = value + 1.00F;

                ((ATextbox)inflect[0]).Font = new Font(((ATextbox)inflect[0]).Font.FontFamily, value, ((ATextbox)inflect[0]).Font.Style);

                ((ARichtextbox)inflect[1]).Font = new Font(((ARichtextbox)inflect[1]).Font.FontFamily, value, ((ARichtextbox)inflect[1]).Font.Style);

                continue;
            }

            return;
        }
    }
}
