using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial struct Scopexportablemfilearray
    {
        public static void Import(Scopexportablemfilearray value_SCOPEXPORTABLEMONITORFILEARRAY)
        {
            FileInfoArray = (FileInfo[])value_SCOPEXPORTABLEMONITORFILEARRAY.FileInfoArrayObject;

            FileInfoStack = (Stack)value_SCOPEXPORTABLEMONITORFILEARRAY.StackObject;

            Text = (String)value_SCOPEXPORTABLEMONITORFILEARRAY.TextObject;

            return;
        }
    }
}
