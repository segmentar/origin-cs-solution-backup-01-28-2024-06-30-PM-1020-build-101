using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportableexecuteSeal
    {
        public void Import(ExpressionxportableexecutePort Port_VALUE)
        {
            ExpressionExecute = Port_VALUE.ExpressionExecute;

            ExpressionExecuteArray = Port_VALUE.ExpressionExecuteArray;

            ExpressionExecuteExecuting = Port_VALUE.ExpressionExecuteExecuting;

            Executearray = Port_VALUE.Executearray;

            Instruction = Port_VALUE.Instruction;

            InstructionArray = Port_VALUE.InstructionArray;

            InstructionExecuting = Port_VALUE.InstructionExecuting;

            SplitArray = Port_VALUE.SplitArray;

            Value = Port_VALUE.Value;

            Lower = Port_VALUE.Lower;

            Argument = Port_VALUE.Argument;

            ParameterArray = Port_VALUE.ParameterArray;

            return;
        }
    }
}
