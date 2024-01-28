using Core;

namespace Core
{
    using System;

    public partial class Integerxportabledecrement
    {
        public static Boolean DecrementRecurse()
        {
            Boolean booleanResult = default;

            try
            {
                var character = Integerxportable.Character();

                var value = DecrementBase(character);

                Boolean boolean;

                boolean = true;

                boolean = boolean && Object.Equals(Integerxportableascii.EntityNine, (Int32)value) is true;

                if (boolean is true)
                {
                    var node = Integerxportablemagic.IntegerxportablemagicLinkedListNodeCastDispenser<Object>(Integerxportable.Node());

                    node.Value = value;
                }
                else
                    "false".ToString();

                if (boolean is true)
                {
                    booleanResult = true;
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                Integerxportablerender.RenderError($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxportablefatal.DecrementRecurse().Initialize(new String[0], exception));
            }

            return booleanResult;
        }
    }
}
