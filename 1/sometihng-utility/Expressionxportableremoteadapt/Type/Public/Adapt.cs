using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteadapt
    {
        public static void Adapt(Expressionxportable value_EXPRESSIONXPORTABLE, String Type_VALUE, Byte[] Remote_ARRAY)
        {
            if (value_EXPRESSIONXPORTABLE.ObjectIdentity is Expressionxportableexecutearray)
            {
                var value = Expressionxportablelinear.Execute(value_EXPRESSIONXPORTABLE, Type_VALUE, Remote_ARRAY);

                ExpressionxportablelinearModule expressionxportablelinearModule = ExpressionxportablelinearModule.Action(value);
            }
            else
                "false".ToString();

            foreach (Expressionxportable expressionxportable in Expressionxportableset.ExpressionxportableAllSetSurface(value_EXPRESSIONXPORTABLE, true))
            {
                if (expressionxportable.ObjectIdentity is Expressionxportablefilesystemfolder)
                {
                    Expressionxportablefilesystemfolder.Adapt(value_EXPRESSIONXPORTABLE, expressionxportable, System.IO.Directory.GetCurrentDirectory());
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}
