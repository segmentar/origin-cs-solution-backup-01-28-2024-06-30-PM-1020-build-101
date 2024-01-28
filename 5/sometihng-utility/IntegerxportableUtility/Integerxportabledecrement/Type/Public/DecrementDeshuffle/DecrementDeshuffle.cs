using Core;

namespace Core
{
    using System;

    public partial class Integerxportabledecrement
    {
        public static void DecrementDeshuffle()
        {
            try
            {
                Integerxportable.DigitLinkedList.RemoveFirst();

            }
            catch (Exception exception)
            {
                Integerxportablerender.RenderError($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxportablefatal.DecrementDeshuffle().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
