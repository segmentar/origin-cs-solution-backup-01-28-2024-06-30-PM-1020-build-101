using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct Scopexportablemfilearray
    {
        public static void Sync()
        {
            var reflect = (FileInfo)(FileInfoStack.Pop() as Object);

            var text = File.ReadAllText(reflect.FullName);

            Text = text;

            return;
        }
    }
}
