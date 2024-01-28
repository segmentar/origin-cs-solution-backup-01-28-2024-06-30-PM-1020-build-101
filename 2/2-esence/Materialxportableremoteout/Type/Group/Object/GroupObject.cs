using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Runtime.Serialization;

    using System.Runtime.Serialization.Formatters;
    using System.Runtime.Serialization.Formatters.Binary;

    public partial class Materialxportableremoteout
    {
        public static Object GroupObject(Byte[] array_BYTE)
        {
            Object objectResult = default;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(array_BYTE.Length, 0) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return objectResult;
            }
            else
                "false".ToString();

            MemoryStream memoryStream;

            memoryStream = new MemoryStream(array_BYTE);

            using (memoryStream)
            {
                IFormatter formatter;

                formatter = new BinaryFormatter();

                var result = formatter.Deserialize(memoryStream);

                objectResult = result;

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return objectResult;
        }
    }
}
