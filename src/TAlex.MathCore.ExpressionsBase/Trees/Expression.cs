﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace TAlex.MathCore.ExpressionEvaluation.Trees
{
    /// <summary>
    /// Provides the base class from which the classes that represent expression
    /// tree nodes are derived. This is an abstract class.
    /// </summary>
    /// <typeparam name="T">The type of the result of evaluating.</typeparam>
    public abstract class Expression<T> : IEvaluator<T>
    {
        public static readonly Expression<T> Null = new NullExpression();


        #region IEvaluator<T> Members

        public abstract T Evaluate();

        #endregion


        public VariableExpression<T> FindVariable(string name)
        {
            VariableExpression<T> var = null;
            bool isFound = false;
            FindVariable(name, ref var, ref isFound);
            return var;
        }

        public IEnumerable<VariableExpression<T>> FindAllVariables()
        {
            IList<VariableExpression<T>> vars = new List<VariableExpression<T>>();
            FindAllVariables(vars);
            return vars;
        }


        public abstract void FindVariable(string name, ref VariableExpression<T> var, ref bool isFound);

        public abstract void FindAllVariables(IList<VariableExpression<T>> foundedVariables);

        public abstract void ReplaceChild(Expression<T> oldExpression, Expression<T> newExpression);


        protected virtual string WrapWithParentheses(Expression<T> expr, params Type[] conditions)
        {
            foreach (var cond in conditions)
            {
                if (expr.GetType().GetTypeInfo().IsSubclassOf(cond))
                {
                    return String.Format("({0})", expr);
                }
            }
            return expr.ToString();
        }

        #region Nested Types

        internal class NullExpression : Expression<T>
        {
            public override T Evaluate()
            {
                throw new NullReferenceException();
            }

            public override void FindAllVariables(IList<VariableExpression<T>> foundedVariables)
            {
            }

            public override void FindVariable(string name, ref VariableExpression<T> var, ref bool isFound)
            {
            }

            public override void ReplaceChild(Expression<T> oldExpression, Expression<T> newExpression)
            {
            }

            public override string ToString()
            {
                return "NULL";
            }
        }

        #endregion
    }
}
