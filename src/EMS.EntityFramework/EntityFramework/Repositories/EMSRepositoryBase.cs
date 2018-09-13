using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace EMS.EntityFramework.Repositories
{
    public abstract class EMSRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<EMSDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected EMSRepositoryBase(IDbContextProvider<EMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class EMSRepositoryBase<TEntity> : EMSRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected EMSRepositoryBase(IDbContextProvider<EMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
