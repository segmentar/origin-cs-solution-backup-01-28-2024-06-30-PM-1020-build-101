using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        [Expressionxportableisc]
        public partial class XQuadruple
        {
            public ExpressionxportablereadXlev_lY[] LevelArray;

            public XQuadruple(ExpressionxportablereadXlev_lY[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XQuadruple()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XQuadruple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(LevelArray) + ':' + ' ' + ". . ." + ' ' + $"<{LevelArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(LevelArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), LevelArray)
                });
            }
        }
    }
}
