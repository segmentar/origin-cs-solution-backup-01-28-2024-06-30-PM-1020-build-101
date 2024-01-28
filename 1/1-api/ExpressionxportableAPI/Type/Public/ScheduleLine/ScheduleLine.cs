using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void ScheduleLine(Expressionxportable expressionxportable, String[] stringArray)
        {
            Expressionxportableschedule.GroupScheduleLine(expressionxportable, stringArray);

            return;
        }
    }
}
