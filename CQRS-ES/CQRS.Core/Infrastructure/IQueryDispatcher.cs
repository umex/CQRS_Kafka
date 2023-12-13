using CQRS.Core.Queries;

namespace CQRS.Core.Infrastructure
{
    public interface IQueryDispatcher<TEntity>
    {
        //both methods could be done with generics but we used Liskov principle
        void RegisterHandler<TQuery>(Func<TQuery, Task<List<TEntity>>> handler) where TQuery : BaseQuery;
        Task<List<TEntity>> SendAsync(BaseQuery query);
    }
}