using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    using System.Collections;
    using System.Net.Configuration;

    public partial class Expressionxportablehost
    {
        public static void HostStreamWriteByteArray(String value, String[] array)
        {
            try
            {
                /*Boolean isEqualContinuousCheck, shouldReturnCheck;

                isEqualContinuousCheck = Object.Equals(ExpressionName.EntityLibraryHostStreamWriteByteArray, value) is true;

                shouldReturnCheck = isEqualContinuousCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                var oth = array[0];

                var format = Expressionformat.ForgeDashlessFormat(oth);

                var inflect = new Object[4];

                var deflect = new IEnumerable[5];

                deflect[0] = (IEnumerable)(Expression.ViewLinkedListObject as Object);

                deflect[1] = new ArrayList((ICollection)(deflect[0] as IEnumerable));

                inflect[0] = ((ArrayList)deflect[1]).Count;

                inflect[1] = (((Int32)inflect[0]) - 1);

                inflect[2] = ((ArrayList)deflect[1])[(Int32)inflect[1]];

                deflect[2] = (IEnumerable)(((Expression)inflect[2]).LayerArrayListObject as Object);

                inflect[3] = (FileStream)(Expression.FileStreamObject);

                foreach (Expression item in deflect[2])
                {
                    Boolean shouldContinueCheck;

                    isEqualContinuousCheck = Object.Equals(item.StringIdentity.StringValue, format) is true;

                    shouldContinueCheck = isEqualContinuousCheck is false;

                    if (shouldContinueCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    deflect[3] = (IEnumerable)(item.LayerArrayListObject as Object);

                    deflect[4] = new Byte[new ArrayList((ICollection)deflect[3]).Count];

                    var indexer = 0;

                    foreach (Expression entry in deflect[3])
                    {
                        Integerx integerx;

                        integerx = new IntegerxSimple(entry.StringIdentity.StringValue).Result;

                        var Byte_VALUE = Integerxhost.GroupByte(integerx, true);

                        ((Byte[])deflect[4])[indexer] = Byte_VALUE;

                        indexer = indexer + 1;

                        continue;
                    }

                    BinaryWriter binaryWriter;

                    binaryWriter = new BinaryWriter((FileStream)inflect[3], (Encoding)Expression.FileStreamWriterEncoding, true);

                    using (binaryWriter)
                    {
                        binaryWriter.Write((Byte[])deflect[4]);

                        binaryWriter.Close();

                        binaryWriter.Dispose();
                    }

                    continue;
                }*/

            } catch (Exception exception)
            {
                Interopfatal.Render($"{ExpressionCode.RenderPath.Core_Expression_Fatal}", new Expressionfatal.HostStreamWriteByteArray().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
