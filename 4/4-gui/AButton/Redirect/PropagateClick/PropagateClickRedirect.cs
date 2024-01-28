using Core;

namespace Core
{
    using System;

    public partial class AButton
    {
        public static void PropagateClickRedirect(Object sender, EventArgs e)
        {
            var reflect = (AButton)(sender as Object);

            ScopexportableCode.FormDirection formDirection;

            switch (reflect.Name)
            {
                case Scopexportablename.EntityButtonNameTop:
                    formDirection = ScopexportableCode.FormDirection.Top;
                    break;

                case Scopexportablename.EntityButtonNameBottom:
                    formDirection = ScopexportableCode.FormDirection.Bottom;
                    break;

                case Scopexportablename.EntityButtonNameLeft:
                    formDirection = ScopexportableCode.FormDirection.Left;
                    break;

                case Scopexportablename.EntityButtonNameRight:
                    formDirection = ScopexportableCode.FormDirection.Right;
                    break;

                default:
                    formDirection = ScopexportableCode.FormDirection.Unset;
                    break;
            }
            var result = reflect.FindForm();

            AForm aform;

            aform = new AForm();

            aform.Scopexportablemonitorcontext.Owner = (AForm)result;

            aform.Scopexportablemonitorcontext.FormDirection = formDirection;

            aform.Show(result);

            return;
        }
    }
}
