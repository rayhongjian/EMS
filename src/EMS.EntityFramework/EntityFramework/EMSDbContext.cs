using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using EMS.Authorization.Roles;
using EMS.Authorization.Users;
using EMS.MultiTenancy;

namespace EMS.EntityFramework
{
    public class EMSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
       

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public EMSDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in EMSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of EMSDbContext since ABP automatically handles it.
         */
        public EMSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public EMSDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public EMSDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
