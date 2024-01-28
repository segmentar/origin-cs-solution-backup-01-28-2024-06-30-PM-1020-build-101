using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableexecutearray
    {
        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Expressionxportableexecutearray) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ExecuteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ExecuteArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ExecuteArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ExecuteArray)
            });
        }
    }
}
