using EMS.EntityFramework;
using EntityFramework.DynamicFilters;

namespace EMS.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly EMSDbContext _context;

        public InitialHostDbBuilder(EMSDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
