using Core;

namespace Core
{
    using System;

    public partial class Integerxportableincrement
    {
        public static void IncrementTime(Integerxportable value_INTEGERX, Int32 Time_VALUE)
        {
            try
            {
                while (true)
                {
                    Boolean isEqualCheck, shouldBreakCheck;

                    isEqualCheck = Object.Equals(Time_VALUE, 0) is true;

                    shouldBreakCheck = isEqualCheck is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    IncrementControl(value_INTEGERX);

                    Time_VALUE = Time_VALUE - 1;

                    continue;
                }

            } catch (Exception exception)
            {
                Interopfatal.Render($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxfatal.DecrementTime().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
