using System.Linq;
using EMS.EntityFramework;
using EMS.MultiTenancy;

namespace EMS.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly EMSDbContext _context;

        public DefaultTenantCreator(EMSDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
