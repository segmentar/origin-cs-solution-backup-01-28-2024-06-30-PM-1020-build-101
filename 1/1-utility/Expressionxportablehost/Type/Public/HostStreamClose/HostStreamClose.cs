using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablehost
    {
        public static void HostStreamFree(String value, String[] array)
        {
            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(Expressionxportablename.EntityLibraryHostStreamClose, value) is true;

            shouldReturnCheck = isEqualCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var first = array[0];

            foreach (Expressionxportable item in Expressionxportablefilesystemhook.ExpressionxportableArray)
            {
                foreach (Expressionxportable entry in Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(item.LayerArrayListObject))
                {
                    if (Object.Equals(((Expressionxportablestringsafe)entry.StringIdentity).Value, first) is true)
                    {
                        var reflect = (FileStream)(entry.ObjectIdentity as Object);
                        
                        using (var stream = reflect)
                        {
                            stream.Close();

                            stream.Dispose();
                        }
                    }
                    else
                        "false".ToString();

                    continue;
                }

                continue;
            }

            return;
        }
    }
}
