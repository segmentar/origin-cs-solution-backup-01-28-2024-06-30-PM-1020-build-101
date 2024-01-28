using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablehost
    {
        public static void HostStreamOriginBegin(String value, String[] array)
        {
            try
            {
                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(ExpressionName.EntityLibraryHostStreamOriginBegin, value) is true;

                shouldReturnCheck = isEqualCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                Expression.SeekOriginObject = SeekOrigin.Begin;

            }
            catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.HostStreamOriginBegin().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
