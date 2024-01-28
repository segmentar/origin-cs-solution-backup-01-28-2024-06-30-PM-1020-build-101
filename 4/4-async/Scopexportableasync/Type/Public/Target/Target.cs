using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Scopexportableasync
    {
        public static void Target()
        {
            Form form;

            form = new AForm();

            ApplicationContext applicationContext;

            applicationContext = new AApplicationcontext(form);

            Application.Run(applicationContext);

            return;
        }
    }
}
