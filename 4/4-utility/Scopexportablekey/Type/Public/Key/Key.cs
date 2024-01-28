using Core;

namespace Core
{
    using System;

    public partial class Scopexportablekey
    {
        public static void Key(Char value_CHARACTER)
        {
            var convert = Convert.ToInt32(value_CHARACTER);

            if (Object.Equals(convert, Scopexportableascii.EntityOne) is true)
            {
                Scopexportablefontdown.Fontdown();
            }
            else
                "false".ToString();

            if (Object.Equals(convert, Scopexportableascii.EntityTwo) is true)
            {
                Scopexportablefontup.Fontup();
            }
            else
                "false".ToString();

            if (Object.Equals(convert, Scopexportableascii.EntityThree) is true)
            {
                Scopexportablepause.Pause();
            }
            else
                "false".ToString();

            if (Object.Equals(convert, Scopexportableascii.EntityFour) is true)
            {
                Scopexportableskip.Skip();
            }
            else
                "false".ToString();

            if (Object.Equals(convert, Scopexportableascii.EntityFive) is true)
            {
                Scopexportablebackward.Backward();
            }
            else
                "false".ToString();

            if (Object.Equals(convert, Scopexportableascii.EntitySix) is true)
            {
                Scopexportableforward.Forward();
            }
            else
                "false".ToString();

            return;
        }
    }
}
