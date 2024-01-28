using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablehost
    {
        public static void HostStreamFree(String value, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityLibraryHostStreamFree, value) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var list = Interop.InteropArrayListCastDispenser(Expression.FileStreamArrayListObject);

                list.Clear();

            } catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.HostStreamFree().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
