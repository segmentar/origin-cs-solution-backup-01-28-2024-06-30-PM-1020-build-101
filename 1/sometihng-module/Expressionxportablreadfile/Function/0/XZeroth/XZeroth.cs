﻿using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadfileModule
    {
        [Expressionxportableism]
        public partial class XZeroth
        {
            public Object[] ObjectArray;

            public XZeroth(Object[] objectArray)
            {
                this.ObjectArray = objectArray;

                return;
            }

            ~XZeroth()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XZeroth) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ObjectArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ObjectArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ObjectArray)
                });
            }
        }
    }
}
