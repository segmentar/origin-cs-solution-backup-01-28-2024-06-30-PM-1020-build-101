using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableio
    {
        public static void GroupCreateFile(String FileFilename__VALUE, Object value_OBJECT, Boolean answer_CREATE_should)
        {
            var boolean = true;

            boolean = boolean && answer_CREATE_should is true;

            boolean = boolean && File.Exists(FileFilename__VALUE) is false;

            boolean = boolean && (value_OBJECT == default).Equals(false);

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = boolean is true;

            shouldReturnCheck = isEqualCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var value = value_OBJECT.ToString();

            StreamWriter streamWriter;

            streamWriter = File.CreateText(FileFilename__VALUE);

            using (streamWriter)
            {
                streamWriter.Write(value);

                streamWriter.Flush();

                streamWriter.Close();

                streamWriter.Dispose();
            }

            return;
        }
    }
}
