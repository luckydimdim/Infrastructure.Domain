using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Infrastructure.Domain.Filters
{
    public class Filter
    {
        /// <summary>
        /// criteria used to select documents
        /// </summary>
        public Selector Selector;

        /// <summary>
        /// Maximum number of results returned
        /// </summary>
        public int? Limit;

        /// <summary>
        ///  Skip the first ‘n’ results, where ‘n’ is the value specified
        /// </summary>
        public int? Skip;

        /// <summary>
        /// Sorting
        /// </summary>
        public Sort Sort;
    }
}
