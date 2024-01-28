using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportablelayout
    {
        public static Expressionxportablelayout Data(Expressionxportable[] array_EXPRESSIONXPORTABLE)
        {
            Expressionxportablelayout expressionxportablelayoutResult = default;

            Int32 x, y, z;

            x = 0;

            x = x + array_EXPRESSIONXPORTABLE.Length;

            y = 0;

            y = y + Expressionxportableconfigure.StartAddress;

            z = 0;

            z = z + array_EXPRESSIONXPORTABLE.Length;

            z = z * Expressionxportableconfigure.ChunkSize;

            z = z + Expressionxportableconfigure.StartAddress;

            Expressionxportablelayout expressionxportablelayout;

            expressionxportablelayout = new Expressionxportablelayout();

            expressionxportablelayout.ExpressionCount = x;

            expressionxportablelayout.StartAddressSubjectTable = y;

            expressionxportablelayout.StartAddressObjectTable = z;

            expressionxportablelayoutResult = expressionxportablelayout;

            return expressionxportablelayoutResult;
        }
    }
}
