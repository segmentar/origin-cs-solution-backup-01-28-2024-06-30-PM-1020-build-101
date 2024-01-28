using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableexecuteSeal
    {
        public void Fivefifthquinaryquintuple()
        {   
            if (true)
            {
                Boolean isEqualCheck;

                isEqualCheck = (InstructionArray.Length < 1).Equals(true);

                var array = new String[0];

                if (isEqualCheck is false)
                {
                    var separator = new Char[1];

                    separator[0] = (Char)Expressionxportableascii.EntityWhitespace;

                    String[] stringArray;

                    stringArray = InstructionArray[0].Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    Array.Resize<String>(ref array, stringArray.Length);

                    stringArray.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);
                }
                else
                    "false".ToString();

                SplitArray = array;
            }
            else
                "false".ToString();

            if (true)
            {
                Boolean isEqualCheck;

                isEqualCheck = (SplitArray.Length < 1).Equals(true);

                Value = String.Empty;

                Lower = String.Empty;

                if (isEqualCheck is false)
                {
                    var value = SplitArray[0];

                    var lower = value.ToLower();

                    Value = value;

                    Lower = lower;
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (true)
            {
                Boolean isEqualCheck;

                isEqualCheck = (SplitArray.Length < 1).Equals(true);

                Argument = String.Empty;

                if (isEqualCheck is false)
                {
                    var aoth = SplitArray.Length;

                    var roth = (aoth - 1);

                    var array = new String[roth];

                    Array.Copy(SplitArray, 1, array, 0, roth);

                    var join = String.Join(((Char)Expressionxportableascii.EntityWhitespace).ToString(), array);

                    Argument = join;
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            if (true)
            {
                Boolean isEqualCheck;

                isEqualCheck = (InstructionArray.Length < 1).Equals(true);

                ParameterArray = new String[0];

                if (isEqualCheck is false)
                {
                    var aoth = InstructionArray.Length;

                    var roth = (aoth - 1);

                    var array = new String[roth];

                    Array.Copy(InstructionArray, 1, array, 0, roth);

                    Array.Resize<String>(ref ParameterArray, array.Length);

                    array.CopyTo(ParameterArray, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            SAJ();

            return;
        }
    }
}
