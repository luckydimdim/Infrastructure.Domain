﻿using System;

namespace Cmas.Infrastructure.Domain.Queries
{
    public class QueryBuilder : IQueryBuilder
    {
        private readonly Func<Type, object> _dataServiceFactory;

        public QueryBuilder(Func<Type, object> dataServiceFactory)
        {
            _dataServiceFactory = dataServiceFactory;
        }

        public IQueryFor<TResult> For<TResult>()
        {
            return _dataServiceFactory(typeof(IQueryFor<TResult>)) as IQueryFor<TResult>;
        }
    }
}
