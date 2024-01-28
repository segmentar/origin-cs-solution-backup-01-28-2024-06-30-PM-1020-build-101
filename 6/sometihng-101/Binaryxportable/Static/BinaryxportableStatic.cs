using Core;

namespace Core
{
    using System;

    public partial class Binaryxportable
    {
        static Binaryxportable()
        {
            return;
        }

        public static void Procedure()
        {
            BinaryxportablePolicy.BinaryxportableDebugPolicy = true;

            BinaryxportablePolicy.BinaryxportableInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            return;
        }

        public static void Raise()
        {
            if (BinaryxportablePolicy.BinaryxportableInfoPolicy is true)
            {

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
