using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct Scopexportablemfilearray
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemfilearray) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(FileInfoArrayObject) + ':' + ' ' + ". . ." + ' ' + $"<{((FileInfo[])FileInfoArrayObject).Length}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StackObject) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportablemagic.ScopexportablemagicStackCastDispenser(StackObject).Count}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(TextObject) + ':' + ' ' + (String)TextObject,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FileInfoArrayObject) + ':',
                String.Empty + String.Join('\n'.ToString(), (Object[])FileInfoArrayObject),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(StackObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablemagic.ScopexportablemagicStackCastDispenser(StackObject).ToArray())
            });
        }
    }
}
