using Core;

namespace Core
{
    using System;

    public partial class Coreio
    {
        public static void Limit(String DirectoryFullName___VALUE, Int32 Limit_VALUE)
        {
            var array = CoreioLimitSetSurface(DirectoryFullName___VALUE, true, Limit_VALUE);

            foreach (String stringValue in array)
            {
                var format = String.Format("[{0}] expected ({1}) found ({2})", stringValue, Limit_VALUE, stringValue.Length);

                var concat = String.Concat(format, '\n', '\n', '\n');

                Console.Out.WriteLine(concat);

                continue;
            }

            Console.Out.WriteLine($"Unresolved problem(s) -> [{array.Length}]");

            return;
        }
    }
}
