using Core;

namespace Core
{
    using System;

    public partial class IntegerxportableSequence
    {
        [Integerxportableism]
        public static void Debug(Char[] Digit_ARRAY, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            System.Windows.Forms.MessageBox.Show("debug is not false");

            var join = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Integerxportable) + ' ' + "::" + ' ' + nameof(IntegerxportableSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Digit_ARRAY) + ':' + ' ' + ". . ." + ' ' + $"<{Digit_ARRAY.Length}>", 
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Digit_ARRAY) + ':',
                String.Empty + String.Join('\n'.ToString(), Digit_ARRAY)
            });

            Integerxportablerender.Render($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Debug}-{nameof(Integerxportable)}Debug", join);

            return;
        }
    }
}
