using Cmas.Infrastructure.Domain.Filters;

namespace Cmas.Infrastructure.Domain.Criteria
{
    public class CriteriaWithFilter: ICriterion
    {
        public Filter Filter;

        public CriteriaWithFilter(Filter filter = null)
        {
            Filter = filter;
        }
    }
}
