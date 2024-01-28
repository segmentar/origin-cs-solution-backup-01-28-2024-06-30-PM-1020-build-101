using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableSequence
    {

        [Expressionxportableism]
        public static void Debug(Expressionxportablestringsafe value_EXPRESSIONXPORTABLESTRINGSAFE, Object value_OBJECT, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Expressionxportable) + ' ' + "::" + ' ' + nameof(ExpressionxportableSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(value_EXPRESSIONXPORTABLESTRINGSAFE) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(value_EXPRESSIONXPORTABLESTRINGSAFE) + ':' + ' ' + $"<safe><<{value_EXPRESSIONXPORTABLESTRINGSAFE.ValueSafe}>>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(value_OBJECT) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(value_OBJECT) + ':',
                String.Empty + value_OBJECT
            });

            Expressionxportablerender.Render($"{ExpressionxportableCode.RenderPath.Core_Expressionxportable_Debug}-{nameof(Expressionxportable)}Debug", join);

            return;
        }
    }
}
