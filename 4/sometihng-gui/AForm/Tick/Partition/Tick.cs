using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Tickupdate(Object sender, EventArgs e)
        {
            var value = Controls.OfType<ATextbox>().FirstOrDefault<ATextbox>();

            Boolean isDefaultCheck, isNotDefaultCheck;

            isDefaultCheck = (value == default) is true;

            isNotDefaultCheck = isDefaultCheck is false;

            if (isNotDefaultCheck is true)
            {
                ATextbox.PropagateTextChangedRedirect(value, e);
            }
            else
                "false".ToString();

            return;
        }

        public void Ticktextbox(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                var inflect = new Object[1];

                inflect[0] = aform.Controls.OfType<ATextbox>().First<ATextbox>();

                Int32 x, y;

                x = 0;

                y = 0;

                Int32 width, height;

                width = 0;
                
                width = width + aform.ClientRectangle.Size.Width;

                height = 0;
                
                height = height + ((ATextbox)inflect[0]).ClientRectangle.Size.Height;

                Point point;

                point = new Point(x, y);

                Size size;

                size = new Size(width, height);

                ((ATextbox)inflect[0]).Location = point;

                ((ATextbox)inflect[0]).Size = size;

                continue;
            }
        }

        public void Tickrichtextbox(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                var inflect = new Object[2];

                inflect[0] = aform.Controls.OfType<ATextbox>().First<ATextbox>();

                inflect[1] = aform.Controls.OfType<APanel>().First<APanel>().Controls.OfType<ARichtextbox>().First<ARichtextbox>();

                Int32 x, y;

                x = 0;

                x = x + AButton.Immutable.Width;

                y = 0;

                y = y + AButton.Immutable.Height;

                y = y + ((ATextbox)inflect[0]).ClientRectangle.Size.Height;

                Int32 width, height;

                width = 0;
                
                width = width + aform.ClientRectangle.Size.Width;

                width = width - AButton.Immutable.Width;

                width = width - AButton.Immutable.Width;

                height = 0;

                height = height + aform.ClientRectangle.Height;

                height = height - ((ATextbox)inflect[0]).ClientRectangle.Size.Height;

                height = height - AButton.Immutable.Height;

                height = height - AButton.Immutable.Height;

                Point point;

                point = new Point(x, y);

                Size size;

                size = new Size(width, height);

                ((RichTextBox)inflect[1]).Location = point;

                ((RichTextBox)inflect[1]).Size = size;

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Ticktopbutton(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                var inflect = new Object[2];

                inflect[0] = aform.Controls.OfType<ATextbox>().First<ATextbox>();

                inflect[1] = aform.Controls.OfType<APanel>().First<APanel>();

                if ((((APanel)inflect[1]).PageValue.Top == default).Equals(false))
                {
                    Int32 x, y;

                    x = 0;

                    x = x + AButton.Immutable.Width;

                    y = 0;

                    y = y + ((ATextbox)inflect[0]).Size.Height;

                    Int32 width, height;

                    width = 0;

                    width = width + aform.ClientRectangle.Size.Width;

                    width = width - AButton.Immutable.Width;

                    width = width - AButton.Immutable.Width;

                    height = AButton.Immutable.Height;

                    if (AButtonPolicy.PaddingHorizontalPolicy is true)
                    {
                        x = x + AButton.Immutable.PaddingHorizontal;

                        width = width - AButton.Immutable.PaddingHorizontal;

                        width = width - AButton.Immutable.PaddingHorizontal;
                    }
                    else
                        "false".ToString();

                    if (AButtonPolicy.PaddingVerticalPolicy is true)
                    {
                        y = y + AButton.Immutable.PaddingVertical;

                        height = height - AButton.Immutable.PaddingVertical;

                        height = height - AButton.Immutable.PaddingVertical;
                    }
                    else
                        "false".ToString();

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    ((APanel)inflect[1]).PageValue.Top.Location = point;

                    ((APanel)inflect[1]).PageValue.Top.Size = size;

                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Tickbottombutton(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                var inflect = new Object[2];

                inflect[0] = aform.Controls.OfType<ATextbox>().First<ATextbox>();

                inflect[1] = aform.Controls.OfType<APanel>().First<APanel>();

                if ((((APanel)inflect[1]).PageValue.Bottom == default).Equals(false))
                {
                    Int32 x, y;

                    x = 0;

                    x = x + AButton.Immutable.Width;
                 
                    y = 0;

                    y = y + ((ATextbox)inflect[0]).Size.Height;

                    y = y + aform.ClientRectangle.Size.Height;

                    Int32 width, height;

                    width = 0;

                    width = width + aform.ClientRectangle.Size.Width;

                    width = width - AButton.Immutable.Width;

                    width = width - AButton.Immutable.Width;

                    height = 0;

                    height = height + AButton.Immutable.Height;

                    y = y - height;

                    y = y - ((ATextbox)inflect[0]).Size.Height;

                    if (AButtonPolicy.PaddingHorizontalPolicy is true)
                    {
                        x = x + AButton.Immutable.PaddingHorizontal;

                        width = width - AButton.Immutable.PaddingHorizontal;

                        width = width - AButton.Immutable.PaddingHorizontal;
                    }
                    else
                        "false".ToString();

                    if (AButtonPolicy.PaddingVerticalPolicy is true)
                    {
                        y = y + AButton.Immutable.PaddingVertical;

                        height = height - AButton.Immutable.PaddingVertical;

                        height = height - AButton.Immutable.PaddingVertical;
                    }
                    else
                        "false".ToString();

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    ((APanel)inflect[1]).PageValue.Bottom.Location = point;

                    ((APanel)inflect[1]).PageValue.Bottom.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Tickleftbutton(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                var inflect = new Object[2];

                inflect[0] = aform.Controls.OfType<ATextbox>().First<ATextbox>();

                inflect[1] = aform.Controls.OfType<APanel>().First<APanel>();

                if ((((APanel)inflect[1]).PageValue.Left == default).Equals(false))
                {
                    Int32 x, y;

                    x = 0;

                    y = 0;

                    y = y + ((ATextbox)inflect[0]).ClientRectangle.Size.Height;

                    y = y + AButton.Immutable.Height;

                    Int32 width, height;

                    width = 0;

                    width = width + AButton.Immutable.Width;

                    height = 0;

                    height = height + aform.ClientRectangle.Size.Height;

                    height = height - AButton.Immutable.Height;

                    height = height - AButton.Immutable.Height;

                    height = height - ((ATextbox)inflect[0]).ClientRectangle.Size.Height;

                    if (AButtonPolicy.PaddingHorizontalPolicy is true)
                    {
                        x = x + AButton.Immutable.PaddingHorizontal;

                        width = width - AButton.Immutable.PaddingHorizontal;

                        width = width - AButton.Immutable.PaddingHorizontal;
                    }
                    else
                        "false".ToString();

                    if (AButtonPolicy.PaddingVerticalPolicy is true)
                    {
                        y = y + AButton.Immutable.PaddingVertical;

                        height = height - AButton.Immutable.PaddingVertical;

                        height = height - AButton.Immutable.PaddingVertical;
                    }
                    else
                        "false".ToString();

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    ((APanel)inflect[1]).PageValue.Left.Location = point;

                    ((APanel)inflect[1]).PageValue.Left.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Tickrightbutton(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                var inflect = new Object[2];

                inflect[0] = aform.Controls.OfType<ATextbox>().First<ATextbox>();

                inflect[1] = aform.Controls.OfType<APanel>().First<APanel>();

                if ((((APanel)inflect[1]).PageValue.Right == default).Equals(false))
                {
                    Int32 x, y;

                    x = 0;

                    x = x + aform.ClientRectangle.Size.Width;

                    x = x - AButton.Immutable.Width;

                    y = 0;

                    y = y + ((ATextbox)inflect[0]).ClientRectangle.Size.Height;

                    y = y + AButton.Immutable.Height;

                    Int32 width, height;

                    width = 0;

                    width = width + AButton.Immutable.Width;

                    height = 0;

                    height = height + aform.ClientRectangle.Size.Height;

                    height = height - AButton.Immutable.Height;

                    height = height - AButton.Immutable.Height;

                    height = height - ((ATextbox)inflect[0]).ClientRectangle.Size.Height;

                    if (AButtonPolicy.PaddingHorizontalPolicy is true)
                    {
                        x = x + AButton.Immutable.PaddingHorizontal;

                        width = width - AButton.Immutable.PaddingHorizontal;

                        width = width - AButton.Immutable.PaddingHorizontal;
                    }
                    else
                        "false".ToString();

                    if (AButtonPolicy.PaddingVerticalPolicy is true)
                    {
                        y = y + AButton.Immutable.PaddingVertical;

                        height = height - AButton.Immutable.PaddingVertical;

                        height = height - AButton.Immutable.PaddingVertical;
                    }
                    else
                        "false".ToString();

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    ((APanel)inflect[1]).PageValue.Right.Location = point;

                    ((APanel)inflect[1]).PageValue.Right.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Ticktopalign(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                if ((aform.Scopexportablemonitorcontext.Owner == default).Equals(false) && aform.Scopexportablemonitorcontext.FormDirection is ScopexportableCode.FormDirection.Top)
                {
                    Int32 x, y;

                    x = 0;
                    
                    x = x + aform.Scopexportablemonitorcontext.Owner.Location.X;

                    y = 0;
                    
                    y = y + aform.Scopexportablemonitorcontext.Owner.Location.Y;

                    Int32 width, height;

                    width = 0;
                     
                    width = width + aform.Scopexportablemonitorcontext.Owner.Size.Width;

                    height = 0;
                    
                    height = height + aform.Scopexportablemonitorcontext.Owner.Size.Height;

                    y = y - height;

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    aform.Location = point;

                    aform.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Tickbottomalign(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                if ((aform.Scopexportablemonitorcontext.Owner == default).Equals(false) && aform.Scopexportablemonitorcontext.FormDirection is ScopexportableCode.FormDirection.Bottom)
                {
                    Int32 x, y;

                    x = 0;

                    x = x + aform.Scopexportablemonitorcontext.Owner.Location.X;

                    y = 0;

                    y = y + aform.Scopexportablemonitorcontext.Owner.Location.Y;

                    Int32 width, height;

                    width = 0;

                    width = width + aform.Scopexportablemonitorcontext.Owner.Size.Width;

                    height = 0;

                    height = height + aform.Scopexportablemonitorcontext.Owner.Size.Height;

                    y = y + height;

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    aform.Location = point;

                    aform.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Tickleftalign(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                if ((aform.Scopexportablemonitorcontext.Owner == default).Equals(false) && aform.Scopexportablemonitorcontext.FormDirection is ScopexportableCode.FormDirection.Left)
                {
                    Int32 x, y;

                    x = 0;

                    x = x + aform.Scopexportablemonitorcontext.Owner.Location.X;

                    y = 0;

                    y = y + aform.Scopexportablemonitorcontext.Owner.Location.Y;

                    Int32 width, height;

                    width = 0;

                    width = width + aform.Scopexportablemonitorcontext.Owner.Size.Width;

                    height = 0;

                    height = height + aform.Scopexportablemonitorcontext.Owner.Size.Height;

                    x = x - width;

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    aform.Location = point;

                    aform.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class AForm
    {
        public void Tickrightalign(Object sender, EventArgs e)
        {
            foreach (AForm aform in Application.OpenForms)
            {
                if ((aform.Scopexportablemonitorcontext.Owner == default).Equals(false) && aform.Scopexportablemonitorcontext.FormDirection is ScopexportableCode.FormDirection.Right)
                {
                    Int32 x, y;

                    x = 0;

                    x = x + aform.Scopexportablemonitorcontext.Owner.Location.X;

                    y = 0;

                    y = y + aform.Scopexportablemonitorcontext.Owner.Location.Y;

                    Int32 width, height;

                    width = 0;

                    width = width + aform.Scopexportablemonitorcontext.Owner.Size.Width;

                    height = 0;

                    height = height + aform.Scopexportablemonitorcontext.Owner.Size.Height;

                    x = x + width;

                    Point point;

                    point = new Point(x, y);

                    Size size;

                    size = new Size(width, height);

                    aform.Location = point;

                    aform.Size = size;
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}