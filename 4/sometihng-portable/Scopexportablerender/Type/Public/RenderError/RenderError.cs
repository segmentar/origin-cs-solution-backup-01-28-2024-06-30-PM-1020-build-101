using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablerender
    {
        public static void RenderError(String PathName__VALUE, Scopexportable value_SCOPEXPORTABLE)
        {
            try
            {
                Render(PathName__VALUE, value_SCOPEXPORTABLE);

            } catch (Exception exception)
            {
                Scopexportablerenderlog.Log(exception);
            }

            return;
        }
    }
}
