using Core;

namespace Core
{
    using System;

    public partial class Integerxportabledecrement
    {
        public static void DecrementTime(Integerxportable value_INTEGERX, Int32 Time_VALUE)
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

                    DecrementControl(value_INTEGERX);

                    Time_VALUE = Time_VALUE - 1;

                    continue;
                }

            } catch (Exception exception)
            {
                Integerxportablerender.RenderError($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxportablefatal.DecrementTime().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
