using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablehost
    {
        public static void HostStreamSelect(String value, String[] array)
        {
            try
            {
                /*Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityLibraryHostStreamSelect, value) is true;

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

                var list = Interop.InteropArrayListCastDispenser(Expression.FileStreamArrayListObject);

                Expression.FileStreamObject = list[First_RESULT];*/

            } catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.HostStreamSelect().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
