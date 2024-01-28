using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class Expressionxportablelinear
    {
        public static void Onefirstprimarysingle(ExpressionxportablelinearX_evelY Level_VALUE, ExpressionxportablelinearX_ortY Port_VALUE)
        {
            Port_VALUE.Level = Level_VALUE;

            Port_VALUE.LevelArrayList.Add(Level_VALUE);

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(typeof(Expressionxportableexecutearray).ToString(), Level_VALUE.Type) is true;

            shouldReturnCheck = isEqualCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var data = ((Encoding)Expressionxportable.ReaderRemoteEncodingObject).GetString((Byte[])Level_VALUE.Expressionxportable.RemoteArrayObject);

            var separator = new String[] { Expressionxportableradical.EntityNewLine };

            var split = data.Split(separator, StringSplitOptions.None);

            var zee = (split.Length + 1);

            Array.Resize(ref split, zee);

            var roth = (split.Length - 1);

            split[roth] = String.Empty;

            ExpressionxportablelinearXl_velY level;

            level = new ExpressionxportablelinearXl_velY();

            level.Expressionxportable = Level_VALUE.Expressionxportable;

            level.Type = Level_VALUE.Type;

            level.ExecuteArray = split;

            Twosecondsecondarydouble(level, Port_VALUE);

            return;
        }
    }
}
