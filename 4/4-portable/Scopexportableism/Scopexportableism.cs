using Core;

namespace Core
{
    using System;

    [AttributeUsage(AttributeTargets.Method)]
    public partial class Scopexportableism : Attribute
    {
        public Scopexportableism()
        {
            return;
        }

        ~Scopexportableism()
        {
            return;
        }
    }
}
