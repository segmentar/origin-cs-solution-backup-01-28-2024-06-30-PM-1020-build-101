using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Runtime.Serialization;

    using System.Runtime.Serialization.Formatters;
    using System.Runtime.Serialization.Formatters.Binary;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupObject(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            MemoryStream memoryStream;

            memoryStream = new MemoryStream(Remote_ARRAY);

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
