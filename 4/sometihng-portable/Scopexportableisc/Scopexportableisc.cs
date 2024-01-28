using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public partial class Scopexportableisc : Attribute
    {
        public Scopexportableisc()
        {
            return;
        }

        ~Scopexportableisc()
        {
            return;
        }
    }
}
