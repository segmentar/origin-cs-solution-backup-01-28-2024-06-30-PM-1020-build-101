using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableapi
    {
        public static void ScheduleText(Expressionxportable expressionxportable, String text)
        {
            Expressionxportableschedule.GroupScheduleText(expressionxportable, text);

            return;
        }
    }
}
