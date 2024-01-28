using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Integerxportablerender
    {
        public static String CreateFile(String Path_VALUE, String Name_VALUE, String Content_VALUE, Boolean answer_CREATE_should)
        {
            String stringResult = default;

            try
            {
                var path_FILE_filename = Path.Combine(Path_VALUE, Name_VALUE);

                var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Integerxportablename.EntityRenderExtension);

                var boolean_CREATE_should = true;

                boolean_CREATE_should = boolean_CREATE_should && answer_CREATE_should is true;

                boolean_CREATE_should = boolean_CREATE_should && File.Exists(path_FILE_filename_with_extension) is false;

                Boolean shouldCreateCheck;

                shouldCreateCheck = boolean_CREATE_should is true;

                if (shouldCreateCheck is true)
                {
                    StreamWriter streamWriter;

                    streamWriter = File.CreateText(path_FILE_filename_with_extension);

                    using (streamWriter)
                    {
                        streamWriter.Write(Content_VALUE);

                        streamWriter.Flush();

                        streamWriter.Close();

                        streamWriter.Dispose();
                    }
                }
                else
                    "false".ToString();

                var result = path_FILE_filename_with_extension;

                stringResult = result;

            } catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.ToString());
            }

            return stringResult;
        }
    }
}
