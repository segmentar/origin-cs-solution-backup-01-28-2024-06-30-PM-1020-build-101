using Core;

namespace Core
{
    using System;

    public partial struct Integerxportableunite
    {
        [Integerxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Integerxportableunite) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsSign) + ':' + ' ' + IsSign,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(PreDecimalDigitArray) + ':' + ' ' + ". . ." + ' ' + $"<{PreDecimalDigitArray.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(SubDecimalDigitArray) + ':' + ' ' + ". . ." + ' ' + $"<{SubDecimalDigitArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(PreDecimalDigitArray) + ':',
                String.Empty + String.Join('\n'.ToString(), PreDecimalDigitArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(SubDecimalDigitArray) + ':',
                String.Empty + String.Join('\n'.ToString(), SubDecimalDigitArray)
            });
        }
    }
}
