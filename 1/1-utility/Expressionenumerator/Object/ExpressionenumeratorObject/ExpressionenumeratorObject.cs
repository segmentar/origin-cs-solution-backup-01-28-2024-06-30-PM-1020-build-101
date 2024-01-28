using Core;

namespace Core
{
    using System;

    public partial class Expressionenumerator
    {
        [Interop.ISM]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Expressionenumerator) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ExpressionTarget) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ExpressionCurrent) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Position) + ':' + ' ' + Position,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ExpressionTarget) + ':',
                String.Empty + ExpressionTarget,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ExpressionCurrent) + ':',
                String.Empty + ExpressionCurrent
            });
        }
    }
}
