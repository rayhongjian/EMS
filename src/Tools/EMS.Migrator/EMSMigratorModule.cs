using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using EMS.EntityFramework;

namespace EMS.Migrator
{
    [DependsOn(typeof(EMSDataModule))]
    public class EMSMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<EMSDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}