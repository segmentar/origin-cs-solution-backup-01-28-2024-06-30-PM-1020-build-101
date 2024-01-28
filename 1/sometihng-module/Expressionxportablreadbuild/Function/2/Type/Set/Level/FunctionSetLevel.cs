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
        public partial class XDouble
        {
            public static IList<ExpressionxportablereadXl_velY> FunctionLevelSet(BinaryReader value_BINARYREADER, ExpressionxportablereadX_evelY[] Level_ARRAY)
            {
                ICollection<ExpressionxportablereadXl_velY> collectionResult = default;

                collectionResult = new Collection<ExpressionxportablereadXl_velY>();

                using (value_BINARYREADER)
                {
                    foreach (ExpressionxportablereadX_evelY Level_VALUE in Level_ARRAY)
                    {
                        Int32 objectDifference, typeDifference;

                        objectDifference = 0;

                        objectDifference = objectDifference + Level_VALUE.ObjectEndAddress;

                        objectDifference = objectDifference - Level_VALUE.ObjectStartAddress;

                        objectDifference = objectDifference + 1;

                        typeDifference = 0;

                        typeDifference = typeDifference + Level_VALUE.TypeEndAddress;

                        typeDifference = typeDifference - Level_VALUE.TypeStartAddress;

                        typeDifference = typeDifference + 1;

                        Byte[] objectByteArray, typeByteArray;

                        value_BINARYREADER.BaseStream.Seek(Level_VALUE.ObjectStartAddress, SeekOrigin.Begin);

                        objectByteArray = value_BINARYREADER.ReadBytes(objectDifference);

                        value_BINARYREADER.BaseStream.Seek(Level_VALUE.TypeStartAddress, SeekOrigin.Begin);

                        typeByteArray = value_BINARYREADER.ReadBytes(typeDifference);

                        ExpressionxportablereadXl_velY level;

                        level = new ExpressionxportablereadXl_velY();

                        level.Ordinal = Level_VALUE.Ordinal;

                        level.Layer = Level_VALUE.Layer;

                        level.Relate = Level_VALUE.Relate;

                        level.ObjectStartAddress = Level_VALUE.ObjectStartAddress;

                        level.ObjectEndAddress = Level_VALUE.ObjectEndAddress;

                        level.TypeStartAddress = Level_VALUE.TypeStartAddress;

                        level.TypeEndAddress = Level_VALUE.TypeEndAddress;

                        level.Identity = Level_VALUE.Identity;

                        level.ObjectByteArray = objectByteArray;

                        level.TypeByteArray = typeByteArray;

                        collectionResult.Add(level);

                        continue;
                    }

                    value_BINARYREADER.Close();

                    value_BINARYREADER.Dispose();
                }

                return new List<ExpressionxportablereadXl_velY>(collectionResult);
            }
        }
    }
}
