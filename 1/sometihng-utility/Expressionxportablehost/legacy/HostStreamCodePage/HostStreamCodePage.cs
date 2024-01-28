using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class Expressionxportablehost
    {
        public static void HostStreamCodePage(String value, String[] array)
        {
            try
            {
                /*Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityLibraryHostStreamCodePage, value) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var first = array[0];

                var First_VALUE = new IntegerxSimple(first).Result;

                var First_RESLUT = Integerxhost.Int32(First_VALUE);

                System.Windows.Forms.MessageBox.Show($"asd [{First_RESLUT}]");

                Expression.FileStreamWriterEncoding = Encoding.GetEncoding(First_RESLUT);*/

            } catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.HostStreamCodePage().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
