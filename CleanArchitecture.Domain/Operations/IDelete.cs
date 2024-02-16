using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Operations
{
    public interface IDelete<TKey, TFilter, TEntity> : IRead<TKey, TFilter, TEntity>, ITransaction
    {
        void Delete(TKey id);
    }
}
