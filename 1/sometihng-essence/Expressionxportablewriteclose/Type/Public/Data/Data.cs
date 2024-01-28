using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportablewriteclose
    {
        public static Expressionxportablewriteclose Data()
        {
            Expressionxportablewriteclose expressionxportablewritecloseResult = default;

            Expressionxportablewriteclose expressionxportablewriteclose;

            expressionxportablewriteclose = new Expressionxportablewriteclose();

            expressionxportablewriteclose.FlushShould = true;

            expressionxportablewriteclose.FileStreamCloseShould = true;

            expressionxportablewriteclose.HeaderTableMemoryStreamCloseShould = true;

            expressionxportablewriteclose.SubjectTableMemoryStreamCloseShould = true;

            expressionxportablewriteclose.ObjectTableMemoryStreamCloseShould = true;

            expressionxportablewritecloseResult = expressionxportablewriteclose;

            return expressionxportablewritecloseResult;
        }
    }
}
