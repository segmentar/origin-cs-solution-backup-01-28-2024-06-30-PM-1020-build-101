using Core;

namespace Core
{
    using System;

    public partial class Expressionenumerator
    {
        public static Expressionenumerator MakeExpressionenumeratorStructure(Expression value_EXPRESSION)
        {
            Expressionenumerator expressionenumeratorResult = default;

            Expressionenumerator expressionenumerator;

            expressionenumerator = new Expressionenumerator();

            expressionenumerator.ExpressionTarget = value_EXPRESSION;

            expressionenumeratorResult = expressionenumerator;

            return expressionenumeratorResult;
        }
    }
}
