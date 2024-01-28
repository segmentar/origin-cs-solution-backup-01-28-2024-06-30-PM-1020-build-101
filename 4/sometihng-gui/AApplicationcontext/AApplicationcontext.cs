using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class AApplicationcontext : ApplicationContext
    {
        public AApplicationcontext(Form form) : base(form)
        {
            return;
        }

        ~AApplicationcontext()
        {
            return;
        }
    }
}
