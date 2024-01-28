using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scopexportablemmanager
    {
        public static String Manage(String value_STRING)
        {
            String stringResult = default;

            String stringValue;

            var inflect = new Object[1];

            var deflect = new IEnumerable[1];

            deflect[0] = Scopexportablemagic.ScopexportablemagicArrayListDispenser(Scopexportablemframe.LinkedList);
                
            if (Object.Equals(Scopexportablemagic.ScopexportablemagicArrayListCastDispenser(deflect[0]).Count, 0) is true)
            {
                stringValue = String.Empty;

                stringResult = stringValue;

                return stringResult;
            }
            else
                "false".ToString();

            inflect[0] = Scopexportablemagic.ScopexportablemagicArrayListCastDispenser(deflect[0])[Scopexportablemframe.Pointer];

            var reflect = (Scopexportablemtransaction)(inflect[0]);
            
            switch (value_STRING)
            {
                case Scopexportablename.EntityMonitorState:
                    stringValue = reflect.Scopexportablemonitorstate.ToString();
                    break;

                case Scopexportablename.EntityMonitorFrame:
                    stringValue = reflect.Scopexportablemframe.ToString();
                    break;

                case Scopexportablename.EntityMonitorFileArray:
                    stringValue = reflect.Scopexportablemonitorfilearray.ToString();
                    break;

                default:
                    stringValue = default;
                    break;
            }

            stringResult = stringValue;

            return stringResult;
        }
    }
}
