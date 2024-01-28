using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableinstruction
    {
        public static void IOperation(Expressionxportable value_EXPRESSIONXPORTABLE, String Operation_VALUE, String[] Argument_ARRAY)
        {
            try
            {
                Bootxportableoperation.Operation(value_EXPRESSIONXPORTABLE, Operation_VALUE, Argument_ARRAY);
            }
            catch (Exception exception)
            {
                var information = new String[] { 
                
                    nameof(IOperation)
                };

                Expressionxportablerender.RenderError($"{ExpressionxportableCode.ProductPath.Core_Expressionxportable_Fatal}", new Expressionxportableinstructionfatal.Operation().Initialize(information, exception));
            }

            /*Expressionhost.HostStreamSelect(Operation_VALUE, Argument_ARRAY);

            Expressionhost.HostStreamOriginBegin(Operation_VALUE, Argument_ARRAY);

            Expressionhost.HostStreamSeek(Operation_VALUE, Argument_ARRAY);

            Expressionhost.HostStreamWriteIntegerBit32(Operation_VALUE, Argument_ARRAY);

            Expressionhost.HostStreamWriteIntegerBit32Sign(Operation_VALUE, Argument_ARRAY);

            Expressionhost.HostStreamWriteByteArray(Operation_VALUE, Argument_ARRAY);

            Expressionhost.HostStreamWriteSingleBit32(Operation_VALUE, Argument_ARRAY);

            Expressionhost.HostStreamFree(Operation_VALUE, Argument_ARRAY);

            Expressionhost.HostStreamCodePage(Operation_VALUE, Argument_ARRAY);*/

            return;
        }
    }
}
