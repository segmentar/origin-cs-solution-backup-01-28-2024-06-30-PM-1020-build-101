using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Integerxportableincrement
    {
        public static Boolean IncrementReady()
        {
            Boolean booleanResult = default;

            try
            {
                Boolean boolean;

                boolean = true;

                var list = Integerxportablemagic.IntegerxportablemagicArrayListDispenser(Integerxportable.DigitLinkedList);

                foreach (Object objectValue in list)
                {
                    var reflect = (Char)(objectValue as Object);

                    boolean = boolean && Object.Equals(Integerxportableascii.EntityZero, (Int32)reflect) is true;

                    continue;
                }

                if (boolean is true)
                {
                    booleanResult = true;
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                Integerxportablerender.RenderError($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxportablefatal.IncrementReady().Initialize(new String[0], exception));
            }

            return booleanResult;
        }
    }
}
