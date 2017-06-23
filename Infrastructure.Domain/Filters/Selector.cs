using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Infrastructure.Domain.Filters
{

    public class OperatorExpr
    {
        /// <summary>
        /// $regex
        /// FIXME: сделать enum
        /// </summary>
        public string Operator;

        /// <summary>
        /// 
        /// </summary>
        public object Argument;

        /// <summary>
        /// Тип значения (берется из типа поля)
        /// </summary>
        public Type Type;

    }

    public class Selector
    {
        public Dictionary<string, OperatorExpr> Operators;
    }
}
