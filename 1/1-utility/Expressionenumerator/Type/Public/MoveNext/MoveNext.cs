using Core;

namespace Core
{
    using System;

    public partial class Expressionenumerator
    {
        public Boolean MoveNext()
        {
            Boolean booleanResult = default;

            var reflect = (Expression)(ExpressionTarget as Object);

            var list = Interop.InteropArrayListCastDispenser(reflect.LayerArrayListObject);

            Boolean boolean;

            if (Object.Equals(list.Count, Position))
            {
                boolean = false;
            }
            else
            {
                boolean = true;
            }

            if (boolean is true)
            {
                ExpressionCurrent = list[Position];

                Position = Position + 1;
            }
            else
                "false".ToString();

            booleanResult = boolean;

            return booleanResult;
        }
    }
}
