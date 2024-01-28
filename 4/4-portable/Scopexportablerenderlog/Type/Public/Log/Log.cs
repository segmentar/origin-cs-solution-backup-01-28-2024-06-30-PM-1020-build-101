using Core;

namespace Core
{
    using System;

    public partial class Scopexportablerenderlog
    {
        public static void Log(Object value_OBJECT)
        {
            Console.Out.WriteLine(value_OBJECT);

            System.Windows.Forms.MessageBox.Show(value_OBJECT.ToString());

            return;
        }
    }
}
