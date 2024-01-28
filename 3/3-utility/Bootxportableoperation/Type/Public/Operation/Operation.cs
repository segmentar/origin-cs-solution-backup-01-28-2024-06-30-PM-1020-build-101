using Core;

namespace Core
{
    using System;

    public partial class Bootxportableoperation
    {
        public static void Operation(Expressionxportable value_EXPRESSIONXPORTABLE, String Operation_VALUE, String[] Argument_ARRAY)
        {
            switch (Operation_VALUE)
            {
                case Bootxportablename.EntityConvert:
                    GroupConvert(value_EXPRESSIONXPORTABLE, Argument_ARRAY);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
