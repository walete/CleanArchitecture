using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Operations
{
    public interface IFilter<TFilter, TEntity>
    {
        Task<IQueryable<TEntity>> ApplyFilter(TFilter filter);
        Task<IQueryable<TEntity>> ApplyFilter(IQueryable<TEntity> origin, TFilter filter);
        Task<IEnumerable<TEntity>> Filter(TFilter filter);

    }
}
