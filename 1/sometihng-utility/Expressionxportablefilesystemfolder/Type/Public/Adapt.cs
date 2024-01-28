using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportablefilesystemfolder
    {
        public static void Adapt(Expressionxportable item_EXPRESSIONXPORTABLE, Expressionxportable entry_EXPRESSIONXPORTABLE, String Builder_VALUE)
        {
            var result = Path.Combine(Builder_VALUE, ((Expressionxportablestringsafe)entry_EXPRESSIONXPORTABLE.StringIdentity).Value);

            if (entry_EXPRESSIONXPORTABLE.ObjectIdentity is Expressionxportablefilesystemfolder)
            {
                if (Directory.Exists(result) is true)
                {
                    Directory.Delete(result, true);
                }
                else
                    "false".ToString();

                if (Directory.Exists(result) is false)
                {
                    DirectoryInfo directoryInfo;

                    directoryInfo = Directory.CreateDirectory(result);

                    result = directoryInfo.FullName;
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (entry_EXPRESSIONXPORTABLE.ObjectIdentity is Expressionxportablefilesystemfile)
            {
                if (File.Exists(result) is true)
                {
                    File.Delete(result);
                }
                else
                    "false".ToString();

                if (File.Exists(result) is false)
                {
                    FileStream fileStream;

                    fileStream = File.Create(result);

                    var list = Expressionxportablemagic.ExpressionxportablemagicArrayListDispenser(new Object[0]);

                    foreach (Expressionxportable value in Expressionxportableset.ExpressionxportableAllSetSurface(item_EXPRESSIONXPORTABLE, true))
                    {
                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = value.ObjectIdentity is Expressionxportablefilesystemhook;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        list.Add(value);

                        continue;
                    }
                    
                    Array.Resize(ref Expressionxportablefilesystemhook.ExpressionxportableArray, list.Count);

                    list.CopyTo(Expressionxportablefilesystemhook.ExpressionxportableArray);

                    foreach (Expressionxportable value in Expressionxportablefilesystemhook.ExpressionxportableArray)
                    {
                        Expressionxportable expressionxportable;

                        expressionxportable = new ExpressionxportableSimple(((Expressionxportablestringsafe)entry_EXPRESSIONXPORTABLE.StringIdentity).Value, fileStream).Result;

                        fileStream.Close();

                        fileStream.Dispose();

                        Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value.LayerArrayListObject).Add(expressionxportable);

                        continue;
                    }
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            foreach (Expressionxportable value in Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(entry_EXPRESSIONXPORTABLE.LayerArrayListObject))
            {
                Adapt(item_EXPRESSIONXPORTABLE, value, result);

                continue;
            }

            return;
        }
    }
}
