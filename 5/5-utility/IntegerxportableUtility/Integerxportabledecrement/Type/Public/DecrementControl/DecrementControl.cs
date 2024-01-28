using Core;

namespace Core
{
    using System;

    public partial class Integerxportabledecrement
    {
        public static Integerxportable DecrementControl(Integerxportable value_INTEGERX)
        {
            Integerxportable integerxResult = default;

            try
            {
                if (value_INTEGERX.IsSign)
                {
                    //Integerxincrement.Increment(value_INTEGERX);
                }
                else
                {
                    Decrement(value_INTEGERX);
                }

                integerxResult = value_INTEGERX;

            } catch (Exception exception)
            {
                Integerxportablerender.RenderError($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxportablefatal.DecrementControl().Initialize(new String[0], exception));
            }

            return integerxResult;
        }
    }
}
