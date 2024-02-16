using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Operations
{
    public interface IRead<TKey, TFilter, TEntity> : IFilter<TFilter, TEntity>
    {
        Task<TEntity> Get(TKey id);
        Task<IEnumerable<TEntity>> Get();
    }
}
