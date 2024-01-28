using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        [Integerxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Integerxportable) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsSign) + ':' + ' ' + IsSign,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(DigitLinkedListObject) + ':' + ' ' + ". . ." + ' ' + $"<{Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(DigitLinkedListObject).Count}>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(PositionStackObject) + ':' + ' ' + ". . ." + ' ' + $"<{Integerxportablemagic.IntegerxportablemagicStackCastDispenser<Object>(PositionStackObject).Count}>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(DecimalObject) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(DigitLinkedListObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(DigitLinkedListObject)),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(PositionStackObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Integerxportablemagic.IntegerxportablemagicStackCastDispenser<Object>(PositionStackObject)),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(DecimalObject) + ':',
                String.Empty + DecimalObject
            });
        }
    }
}