using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablehost
    {
        public static void HostStreamWriteSingleBit32(String value, String[] array)
        {
            try
            {
                System.Windows.Forms.MessageBox.Show($"value -> {value}");

                Boolean isEqualContinuousCheck, shouldReturnCheck;

                isEqualContinuousCheck = Object.Equals(ExpressionName.EntityLibraryHostStreamWriteSingleBit32, value) is true;

                shouldReturnCheck = isEqualContinuousCheck is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                System.Windows.Forms.MessageBox.Show("success");
            } 
            catch (Exception exception)
            {
                // TODO
            }

            return;
        }
    }
}
