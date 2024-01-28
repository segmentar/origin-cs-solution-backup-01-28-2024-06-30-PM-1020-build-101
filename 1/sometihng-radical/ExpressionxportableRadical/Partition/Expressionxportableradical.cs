using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableradical
    {
        public static Char[] EntityNewLineRadical = new Char[] { (Char)Expressionxportableascii.EntityCarriageReturn, (Char)Expressionxportableascii.EntityLineFeed };

        public static String EntityNewLineConcat = String.Concat(EntityNewLineRadical);

        public static String[] EntityNewLineSeparator = new String[1] { EntityNewLineConcat };

        public static Char[] EntityNormalRadical = new Char[] { (Char)Expressionxportableascii.EntityWhitespace, (Char)Expressionxportableascii.EntityUnderscore, (Char)Expressionxportableascii.EntityDash };

        public static Char[] EntityMultilineRadical = new Char[] { (Char)Expressionxportableascii.EntityWhitespace, (Char)Expressionxportableascii.EntityComma };
    }
}



