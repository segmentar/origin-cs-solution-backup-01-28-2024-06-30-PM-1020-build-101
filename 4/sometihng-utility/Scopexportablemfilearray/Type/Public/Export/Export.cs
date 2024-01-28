using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemfilearray
    {
        public static Scopexportablemfilearray Export()
        {
            Scopexportablemfilearray scopexportablemonitorfilearrayResult = default;

            Scopexportablemfilearray scopexportablemonitorfilearray;

            scopexportablemonitorfilearray = new Scopexportablemfilearray();

            scopexportablemonitorfilearray.FileInfoArrayObject = FileInfoArray;

            scopexportablemonitorfilearray.StackObject = FileInfoStack;

            scopexportablemonitorfilearray.TextObject = Text;

            scopexportablemonitorfilearrayResult = scopexportablemonitorfilearray;

            return scopexportablemonitorfilearrayResult;
        }
    }
}
