using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class APanel : Panel,
Scopexportableinterface.IExposer<APanel>,
Scopexportableinterface.IAccessorder,
Scopexportableinterface.IStyleorder<APanel>,
Scopexportableinterface.IControlorder<APanel>
    {
        public Page PageValue = new Page();

        public APanel()
        {
            Accessorder();

            return;
        }

        ~APanel()
        {
            return;
        }

        public APanel ExposePage()
        {
            PageValue.Top = (AButton)(Controls.Find(Scopexportablename.EntityButtonNameTop, false)[0] as Control);

            PageValue.Bottom = (AButton)(Controls.Find(Scopexportablename.EntityButtonNameBottom, false)[0] as Control);

            PageValue.Left = (AButton)(Controls.Find(Scopexportablename.EntityButtonNameLeft, false)[0] as Control);

            PageValue.Right = (AButton)(Controls.Find(Scopexportablename.EntityButtonNameRight, false)[0] as Control);

            return this;
        }

        public APanel CleanPage()
        {
            return this;
        }

        public void Accessorder()
        {
            Styleorder().Controlorder().ExposePage();

            return;
        }

        public APanel Controlorder()
        {
            AButton[] abuttonArray;

            abuttonArray = new AButton[4];

            abuttonArray[0] = new AButton() { Name = Scopexportablename.EntityButtonNameTop };

            abuttonArray[1] = new AButton() { Name = Scopexportablename.EntityButtonNameBottom };

            abuttonArray[2] = new AButton() { Name = Scopexportablename.EntityButtonNameLeft };

            abuttonArray[3] = new AButton() { Name = Scopexportablename.EntityButtonNameRight };

            abuttonArray[0].BackColor = Color.Red;

            abuttonArray[1].BackColor = Color.Blue;

            abuttonArray[2].BackColor = Color.Yellow;

            abuttonArray[3].BackColor = Color.Green;

            ARichtextbox arichtextbox;

            arichtextbox = new ARichtextbox();

            this.Controls.Add(abuttonArray[0]);

            this.Controls.Add(abuttonArray[1]);

            this.Controls.Add(abuttonArray[2]);

            this.Controls.Add(abuttonArray[3]);

            this.Controls.Add(arichtextbox);

            return this;
        }

        public APanel Styleorder()
        {
            this.BackColor = Immutable.BackColor;

            this.Dock = Immutable.DockStyle;

            return this;
        }
    }
}
