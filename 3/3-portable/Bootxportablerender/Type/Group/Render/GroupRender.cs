using Core;

namespace Core
{
    using System;

    public partial class Bootxportablerender
    {
        public static void GroupRender(String Route_VALUE, params Object[] array_OBJECT)
        {
            var item = Bootxportableformat.DirectoryRoute(Route_VALUE, true);

            var result = Bootxportableio.GroupCreateDirectory(item, true);

            var ordinal = 1;

            foreach (Object value_OBJECT in array_OBJECT)
            {
                var entry = Bootxportableformat.GroupFileRoute(result.FullName, ordinal);
                
                Bootxportableio.GroupCreateFile(entry, value_OBJECT, true);

                ordinal = ordinal + 1;

                continue;
            }

            return;
        }
    }
}
