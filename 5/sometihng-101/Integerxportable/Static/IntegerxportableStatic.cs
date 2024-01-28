using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        static Integerxportable()
        {
            return;
        }

        public static void Procedure()
        {
            IntegerxportablePolicy.IntegerxportableDebugPolicy = true;

            IntegerxportablePolicy.IntegerxportableInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            return;
        }

        public static void Raise()
        {
            if (IntegerxportablePolicy.IntegerxportableInfoPolicy is true)
            {
                Integerxportablerender.Render($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Info}-{nameof(Integerxportable)}Info", Integerxportablemagic.IntegerxportablemagicArrayListCastDispenser(IntegerxportablePolicy.IntegerxportableArrayListObject).ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
