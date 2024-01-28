using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemfilearray
    {
        public static Scopexportablemfilearray Data()
        {
            Scopexportablemfilearray scopexportablemfilearrayResult = default;

            Scopexportablemfilearray scopexportablemfilearray;

            scopexportablemfilearray = new Scopexportablemfilearray();

            scopexportablemfilearray.FileInfoArrayObject = Scopexportableio.ScopeDirectoryFileArray(true);

            scopexportablemfilearray.StackObject = Scopexportablemagic.ScopexportablemagicStackDispenser(new Object[0]);

            scopexportablemfilearray.TextObject = String.Empty;

            scopexportablemfilearrayResult = scopexportablemfilearray;

            return scopexportablemfilearrayResult;
        }
    }
}
