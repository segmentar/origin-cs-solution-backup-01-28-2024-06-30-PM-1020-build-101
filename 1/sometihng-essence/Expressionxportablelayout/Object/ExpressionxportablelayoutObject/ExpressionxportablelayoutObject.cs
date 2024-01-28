using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportablelayout
    {
        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Expressionxportablelayout) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ExpressionCount) + ':' + ' ' + ExpressionCount,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StartAddressSubjectTable) + ':' + ' ' + StartAddressSubjectTable,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(StartAddressObjectTable) + ':' + ' ' + StartAddressObjectTable,
                String.Empty + '}'
            });
        }
    }   
}
