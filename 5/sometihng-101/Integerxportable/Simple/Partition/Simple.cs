using Core;

namespace Core
{
    using System;

    public partial class IntegerxportableSimple
    {
        public Integerxportable Result { get; set; } = default;

        public IntegerxportableSimple()
        {
            return;
        }

        ~IntegerxportableSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class IntegerxportableSimple
    {
        public IntegerxportableSimple(String Integerx_VALUE)
        {
            var parse = Integerxportable.Parse(Integerx_VALUE);

            var result = Integerxportable.IntegerxportableMakeDefaultSurface(parse, false);

            this.Result = result;

            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class IntegerxportableSimple
    {
        public IntegerxportableSimple(String Integerx_VALUE, Boolean answer_SIGN_is)
        {
            var parse = Integerxportable.Parse(Integerx_VALUE);

            var result = Integerxportable.IntegerxportableMakeDefaultSurface(parse, answer_SIGN_is);

            this.Result = result;
            
            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class IntegerxportableSimple
    {
        public IntegerxportableSimple(String PreDecimal__VALUE, String SubDecimal__VALUE, Boolean answer_SIGN_is)
        {
            var parse__PreDecimal = Integerxportable.Parse(PreDecimal__VALUE);

            var parse__SubDecimal = Integerxportable.Parse(SubDecimal__VALUE);

            var result_PreDecimal = Integerxportable.IntegerxportableMakeDefaultSurface(parse__PreDecimal, answer_SIGN_is);

            var result_SubDecimal = Integerxportable.IntegerxportableMakeDefaultSurface(parse__SubDecimal, answer_SIGN_is);

            result_PreDecimal.DecimalObject = result_SubDecimal;

            this.Result = result_PreDecimal;

            return;
        }
    }
}