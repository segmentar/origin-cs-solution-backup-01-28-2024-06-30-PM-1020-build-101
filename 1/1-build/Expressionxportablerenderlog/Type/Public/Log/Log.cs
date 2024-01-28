using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablerenderlog
    {
        public static void Log(Object Result_VALUE)
        {
            Console.Out.WriteLine(Result_VALUE);

            System.Windows.Forms.MessageBox.Show(Result_VALUE.ToString());

            return;
        }
    }
}
