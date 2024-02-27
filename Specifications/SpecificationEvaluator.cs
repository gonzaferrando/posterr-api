using Microsoft.EntityFrameworkCore;

namespace Posterr.api.Specifications
{
    public static class SpecificationEvaluator
    {
        public static IQueryable<TEntity> GetQuery<TEntity>(IQueryable<TEntity> inputQueryable, Specification<TEntity> specification) where TEntity : class
        {
            IQueryable<TEntity> query = inputQueryable;

            if (specification.Criteria is not null)
            {
                query = query.Where(specification.Criteria);
            }

            query = specification.IncludeExpressions.Aggregate(query, (current, includeExpression) => current.Include(includeExpression));

            if (specification.OrderByExpression is not null)
            {
                query = query.OrderBy(specification.OrderByExpression);
            }
            else if (specification.OrderByDescendingExpression is not null)
            {
                query = query.OrderByDescending(specification.OrderByDescendingExpression);
            }

            return query;
        }
    }
}
