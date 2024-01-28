using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial class Coregithub
    {
        public static ICollection CoregithubRebaseContainer(String[] Filesystem_ARRAY, String Rebase_ITEM, String Rebase_ENTRY)
        {
            IList listResult = new ArrayList();

            foreach (String Filesystem_VALUE in Filesystem_ARRAY)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Filesystem_VALUE.StartsWith(Rebase_ITEM) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var value = Format(Filesystem_VALUE);

                var remove = value.Remove(0, Rebase_ITEM.Length);

                var trim = remove.TrimStart((Char)Coreascii.EntityBackslash);

                var path = String.Empty;

                path = Path.Combine(path, Rebase_ENTRY);

                path = Path.Combine(path, trim);

                Tuple<String, String> tuple;

                tuple = new Tuple<String, String>(Filesystem_VALUE, path);

                listResult.Add(tuple);

                continue;
            }

            return listResult;
        }
    }
}
