﻿using Light.Domain.Entities.Interfaces;
using Light.EntityFrameworkCore.Repositories;

namespace Sample.Data.Persistence
{
    public class AppRepository<TEntity>(
        AlphaDbContext context) :
        RepositoryBase<TEntity>(context),
        IAppRepository<TEntity>
        where TEntity : class, IEntity
    {
    }
}
