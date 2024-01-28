using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ExpressionxportablereadbuildModule
    {
        public partial class XSingle
        {
            public static IList<ExpressionxportablereadX_evelY> FunctionLevelSet(BinaryReader value_BINARYREADER, Expressionxportablelayout value_EXPRESSIONXPORTABLELAYOUT)
            {
                ICollection<ExpressionxportablereadX_evelY> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablereadX_evelY>();

                using (value_BINARYREADER)
                {
                    value_BINARYREADER.BaseStream.Seek(value_EXPRESSIONXPORTABLELAYOUT.StartAddressSubjectTable, SeekOrigin.Begin);

                    var index = 0;

                    do
                    {
                        Boolean isEqualCheck, shouldBreakCheck;

                        isEqualCheck = Object.Equals(value_EXPRESSIONXPORTABLELAYOUT.ExpressionCount, index) is true;

                        shouldBreakCheck = isEqualCheck is true;

                        if (shouldBreakCheck is true)
                        {
                            break;
                        }
                        else
                            "false".ToString();

                        var position = 0;

                        position = position + index;

                        position = position * Expressionxportableconfigure.ChunkSize;

                        position = position + value_EXPRESSIONXPORTABLELAYOUT.StartAddressSubjectTable;

                        value_BINARYREADER.BaseStream.Seek(position, SeekOrigin.Begin);

                        var absorb = new Int32[7];

                        absorb[0] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                        absorb[1] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                        absorb[2] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                        absorb[3] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                        absorb[4] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                        absorb[5] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                        absorb[6] = Convert.ToInt32(value_BINARYREADER.ReadUInt32());

                        var value = value_BINARYREADER.ReadString();

                        ExpressionxportablereadX_evelY level;

                        level = new ExpressionxportablereadX_evelY();

                        level.Ordinal = absorb[0];

                        level.Layer = absorb[1];

                        level.Relate = absorb[2];

                        level.ObjectStartAddress = absorb[3];

                        level.ObjectEndAddress = absorb[4];

                        level.TypeStartAddress = absorb[5];

                        level.TypeEndAddress = absorb[6];

                        level.Identity = value;

                        collectionResult.Add(level);

                        index = index + 1;

                        continue;

                    } while (true);

                    value_BINARYREADER.Close();

                    value_BINARYREADER.Dispose();
                }

                return new List<ExpressionxportablereadX_evelY>(collectionResult);
            }
        }
    }
}
