using Ivysoft.OnlineSystem.Data.Models.Contracts;
using System.Linq;

namespace Ivysoft.OnlineSystem.Data.Repositories
{
    public interface IEfRepository<T> where T : class, IDeletable
    {
        IQueryable<T> All { get; }

        IQueryable<T> AllWithDeleted { get; }

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
