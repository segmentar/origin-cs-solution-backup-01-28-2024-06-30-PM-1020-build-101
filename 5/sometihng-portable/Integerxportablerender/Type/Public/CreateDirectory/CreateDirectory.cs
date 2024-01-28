using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Integerxportablerender
    {
        public static String CreateDirectory(String Path_VALUE, Boolean answer_CREATE_should)
        {
            String stringResult = default;

            try
            {
                var boolean_CREATE_should = true;

                boolean_CREATE_should = boolean_CREATE_should && answer_CREATE_should is true;

                boolean_CREATE_should = boolean_CREATE_should && Directory.Exists(Path_VALUE) is false;

                Boolean shouldCreateContagentCheck;

                shouldCreateContagentCheck = boolean_CREATE_should is true;

                if (shouldCreateContagentCheck)
                {
                    DirectoryInfo directoryInfo;

                    directoryInfo = Directory.CreateDirectory(Path_VALUE);

                    stringResult = directoryInfo.FullName;
                }
                else
                {
                    stringResult = Path_VALUE;
                }

            } catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }

            return stringResult;
        }
    }
}
