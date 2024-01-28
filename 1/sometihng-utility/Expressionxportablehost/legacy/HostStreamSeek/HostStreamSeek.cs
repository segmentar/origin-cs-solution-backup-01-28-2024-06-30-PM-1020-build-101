using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablehost
    {
        public static void HostStreamSeek(String value, String[] array)
        {
            try
            {
                /*Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityLibraryHostStreamSeek, value) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var first = array[0];

                var First_VALUE = new IntegerxSimple(first).Result;

                var First_RESULT = Integerxhost.Int32(First_VALUE);

                var stream = (FileStream)Expression.FileStreamObject;

                stream.Seek(First_RESULT, (SeekOrigin)Expression.SeekOriginObject);*/

            } catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.HostStreamSeek().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
