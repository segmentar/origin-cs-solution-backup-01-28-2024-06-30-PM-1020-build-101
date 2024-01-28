using Core;

namespace Core
{
    using System;

    public partial class Scopexportableinterface
    {
        public interface IExposable
        {
            void ExposeInstance();

            void CleanInstance();
        }

        public interface IExposable<T>
        {
            T ExposeInstance();

            T CleanInstance();
        }
    }
}

namespace Core
{
    using System;

    public partial class Scopexportableinterface
    {
        public interface IExposer
        {
            void ExposePage();

            void CleanPage();
        }

        public interface IExposer<T>
        {
            T ExposePage();

            T CleanPage();
        }
    }
}

namespace Core
{
    using System;

    public partial class Scopexportableinterface
    {
        public interface IAccessorder
        {
            void Accessorder();
        }
    }
}

namespace Core
{
    public partial class Scopexportableinterface
    {
        public interface IAssignorder
        {
            void Assignorder();
        }

        public interface IAssignorder<T>
        {
            T Assignorder();
        }
    }
}

namespace Core
{
    public partial class Scopexportableinterface
    {
        public interface IBindorder
        {
            void Bindorder();
        }

        public interface IBindorder<T>
        {
            T Bindorder();
        }
    }
}

namespace Core
{
    public partial class Scopexportableinterface
    {
        public interface IStyleorder
        {
            void Styleorder();
        }

        public interface IStyleorder<T>
        {
            T Styleorder();
        }
    }
}

namespace Core
{
    public partial class Scopexportableinterface
    {
        public interface IEventorder
        {
            void Eventorder();
        }

        public interface IEventorder<T>
        {
            T Eventorder();
        }
    }
}

namespace Core
{
    public partial class Scopexportableinterface
    {
        public interface ITimeorder
        {
            void Timeorder();
        }

        public interface ITimeorder<T>
        {
            T Timeorder();
        }
    }
}

namespace Core
{
    public partial class Scopexportableinterface
    {
        public interface IControlorder
        {
            void Controlorder();
        }

        public interface IControlorder<T>
        {
            T Controlorder();
        }
    }
}