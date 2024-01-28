using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm : Form,
Scopexportableinterface.IExposable<AForm>,
Scopexportableinterface.IAccessorder,
Scopexportableinterface.IAssignorder<AForm>,
Scopexportableinterface.IBindorder<AForm>,
Scopexportableinterface.IStyleorder<AForm>,
Scopexportableinterface.IEventorder<AForm>,
Scopexportableinterface.IControlorder<AForm>,
Scopexportableinterface.ITimeorder<AForm>
    {
        public static AForm Instance { get; set; } = default;

        public static Single InstancePX;

        public static Single InstancePY;

        public static Int32 InstanceAX;

        public static Int32 InstanceAY;

        public static Single InstancePWidth;

        public static Single InstancePHeight;

        public static Int32 InstanceAWidth;

        public static Int32 InstanceAHeight;

        public static Point InstancePoint;

        public static Size InstanceSize;

        public Scopexportablemonitorcontext Scopexportablemonitorcontext = new Scopexportablemonitorcontext();

        public AForm()
        {
            Accessorder();

            return;
        }

        ~AForm()
        {
            CleanInstance();

            return;
        }

        public AForm ExposeInstance()
        {
            Instance = this;

            return this;
        }

        public AForm CleanInstance()
        {
            Instance = null;

            return this;
        }

        public void Accessorder()
        {
            ExposeInstance().Assignorder().Bindorder().Styleorder().Eventorder().Controlorder().Timeorder();

            return;
        }

        public AForm Assignorder()
        {
            InstancePX = 0;

            InstancePX = InstancePX + Screen.PrimaryScreen.Bounds.Size.Width;

            InstancePX = InstancePX / 2.00F;

            InstancePY = 0;

            InstancePY = InstancePY + Screen.PrimaryScreen.Bounds.Size.Height;

            InstancePY = InstancePY / 2.00F;

            InstancePWidth = 0;

            InstancePWidth = InstancePWidth + Screen.PrimaryScreen.Bounds.Size.Width;

            InstancePWidth = InstancePWidth / 2.00F;

            InstancePHeight = 0;

            InstancePHeight = InstancePHeight + Screen.PrimaryScreen.WorkingArea.Size.Height;

            InstancePHeight = InstancePHeight / 2.00F;

            InstancePX = InstancePX - (InstancePWidth / 2.00F);

            InstancePY = InstancePY - (InstancePHeight / 2.00F);

            InstanceAX = Convert.ToInt32(InstancePX);

            InstanceAY = Convert.ToInt32(InstancePY);

            InstanceAWidth = Convert.ToInt32(InstancePWidth);

            InstanceAHeight = Convert.ToInt32(InstancePHeight);

            InstancePoint = new Point(InstanceAX, InstanceAY);

            InstanceSize = new Size(InstanceAWidth, InstanceAHeight);

            return this;
        }

        public AForm Bindorder()
        {
            this.Location = InstancePoint;

            this.Size = InstanceSize;

            return this;
        }

        public AForm Styleorder()
        {
            this.Text = Immutable.Text;

            this.ShowIcon = Immutable.ShowIcon;

            this.StartPosition = Immutable.FormStartPosition;

            this.KeyPreview = Immutable.KeyPreview;

            return this;
        }

        public AForm Controlorder()
        {
            ATextbox atextbox;

            atextbox = new ATextbox();

            APanel apanel;

            apanel = new APanel();

            this.Controls.Add(atextbox);

            this.Controls.Add(apanel);

            return this;
        }

        public AForm Timeorder()
        {
            Timer timer;

            timer = new Timer();

            timer.Interval = 100;

            timer.Tick += Tickupdate;

            timer.Tick += Ticktextbox;

            timer.Tick += Tickrichtextbox;

            timer.Tick += Ticktopbutton;

            timer.Tick += Tickbottombutton;

            timer.Tick += Tickleftbutton;

            timer.Tick += Tickrightbutton;

            timer.Tick += Ticktopalign;

            timer.Tick += Tickbottomalign;

            timer.Tick += Tickleftalign;

            timer.Tick += Tickrightalign;

            timer.Start();

            return this;
        }

        public AForm Eventorder()
        {
            this.KeyPress += PropagateKeyPressRedirect;

            return this;
        }
    }
}
