using Core;

namespace Core
{
    using System;

    public partial class Integerxportablerender
    {
        public static void Render(String PathName__VALUE, params Object[] array_OBJECT)
        {
            try
            {
                Boolean isDefaultCheck;

                isDefaultCheck = (array_OBJECT == default) is true;

                if (isDefaultCheck is true)
                {
                    array_OBJECT = new Object[0];
                }
                else
                    "false".ToString();

                Boolean isEqualCheck, shouldReturnCheck;

                isEqualCheck = Object.Equals(array_OBJECT.Length, 0) is true;

                shouldReturnCheck = isEqualCheck is true;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var inflect = new Object[4];

                inflect[0] = Normalize(PathName__VALUE);

                inflect[1] = ((String)inflect[0]).Split(new Char[] { (Char)Integerxportableascii.EntityUnderscore });

                inflect[2] = FullName((String[])inflect[1]);

                inflect[3] = CreateDirectory((String)inflect[2], true);

                var ordinal = 1;

                foreach (Object value_OBJECT in array_OBJECT)
                {
                    Boolean isDefaultContagentCheck;

                    isDefaultContagentCheck = (value_OBJECT == default) is true;

                    String stringValue;

                    if (isDefaultContagentCheck)
                    {
                        stringValue = Error();
                    }
                    else
                    {
                        stringValue = value_OBJECT.ToString();
                    }

                    var name = FileName((String[])inflect[1], ordinal);

                    var path_FILENAME_with_extension = CreateFile((String)inflect[3], name, stringValue, true);

                    ordinal = ordinal + 1;

                    continue;
                }

            } catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }

            return;
        }
    }
}
