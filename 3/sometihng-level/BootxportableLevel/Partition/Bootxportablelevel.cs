using Core;

namespace Core
{
    using System;

    using System.IO;

    [Bootxportableisc]
    public partial struct BootxportablebuildX_evelY
    {
        public FileInfo FileInfo;

        public Bootxportablestringsafe Text;

        public Expressionxportable Expressionxportable;

        [Bootxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(BootxportablebuildX_evelY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + nameof(FileInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + nameof(Text) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + nameof(Text) + ':' + ' ' + Text.ValueSafe,
                String.Empty + '\t' + '~' + "04" + nameof(Expressionxportable) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FileInfo) + ':',
                String.Empty + FileInfo,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Expressionxportable) + ':',
                String.Empty + Expressionxportable
            });
        }
    }
}
