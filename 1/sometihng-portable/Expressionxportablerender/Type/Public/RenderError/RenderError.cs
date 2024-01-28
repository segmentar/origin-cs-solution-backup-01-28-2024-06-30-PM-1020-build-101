using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablerender
    {
        public static void RenderError(String PathName__VALUE, Expressionxportableerror value_EXPRESSIONXPORTABLEERROR)
        {
            try
            {
                Render(PathName__VALUE, value_EXPRESSIONXPORTABLEERROR);

            } catch (Exception exception)
            {
                Expressionxportablerenderlog.Log(exception);
            }

            return;
        }
    }
}
