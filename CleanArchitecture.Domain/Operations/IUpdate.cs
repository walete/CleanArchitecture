using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Operations
{
    public interface IUpdate<TKey, TFilter, TEntity> : IRead<TKey, TFilter,TEntity>, ITransaction
    {
        Task<TEntity> Update(TKey id, TEntity entity);
    }
}
