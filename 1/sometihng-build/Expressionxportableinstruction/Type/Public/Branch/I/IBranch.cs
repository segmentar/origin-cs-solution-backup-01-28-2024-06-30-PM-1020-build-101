using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IBranch(Expressionxportable value_EXPRESSIONXPORTABLE, String Branch_VALUE)
        {
            try
            {
                var list = Expressionxportablemagic.ExpressionxportablemagicLinkedListCastDispenser<Object>(Expressionxportable.ViewLinkedListObject);

                var reflect = (Expressionxportable)(list.Last.Value as Object);

                if (Object.Equals(Expressionxportablename.EntityFilesystemFile, Branch_VALUE) is true)
                {
                    reflect.ObjectIdentity = new Expressionxportablefilesystemfile();
                }
                else
                    "false".ToString();

                if (Object.Equals(Expressionxportablename.EntityFilesystemFolder, Branch_VALUE) is true)
                {
                    reflect.ObjectIdentity = new Expressionxportablefilesystemfolder();
                }
                else
                    "false".ToString();

                if (Object.Equals(Expressionxportablename.EntityFilesystemhook, Branch_VALUE) is true)
                {
                    reflect.ObjectIdentity = new Expressionxportablefilesystemhook();
                }
                else
                    "false".ToString();

                if (Object.Equals(Expressionxportablename.EntityQueryRequire, Branch_VALUE) is true)
                {
                    reflect.ObjectIdentity = new Expressionxportablerequire();
                }
                else
                    "false".ToString();
            }
            catch (Exception exception)
            {
                var information = new String[] {

                    nameof(IBranch)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Branch().Initialize(information, exception));
            }

            return;
        }
    }
}
