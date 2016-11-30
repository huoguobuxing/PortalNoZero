using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Prnewswire.PortalNoZero.EntityFramework.Repositories
{
    public abstract class PortalNoZeroRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<PortalNoZeroDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected PortalNoZeroRepositoryBase(IDbContextProvider<PortalNoZeroDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class PortalNoZeroRepositoryBase<TEntity> : PortalNoZeroRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected PortalNoZeroRepositoryBase(IDbContextProvider<PortalNoZeroDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
