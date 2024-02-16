﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Operations
{
    public interface ICreate<TEntity> : ITransaction
    {
        Task<TEntity> Create(TEntity entity);        
    }
}