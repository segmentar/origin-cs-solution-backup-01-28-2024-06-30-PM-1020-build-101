using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableexecuteSeal
    {
        public ExpressionxportableexecutePort Export()
        {
            ExpressionxportableexecutePort portResult = default;

            ExpressionxportableexecutePort port;

            port = new ExpressionxportableexecutePort();

            port.ExpressionExecute = ExpressionExecute;

            port.ExpressionExecuteArray = ExpressionExecuteArray;

            port.ExpressionExecuteExecuting = ExpressionExecuteExecuting;

            port.Executearray = Executearray;

            port.Instruction = Instruction;

            port.InstructionArray = InstructionArray;

            port.InstructionExecuting = InstructionExecuting;

            port.SplitArray = SplitArray;

            port.Value =  Value;

            port.Lower = Lower;

            port.Argument = Argument;

            port.ParameterArray = ParameterArray;

            portResult = port;

            return portResult;
        }
    }
}
