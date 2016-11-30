using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Prnewswire.PortalNoZero.EntityFramework;

namespace Prnewswire.PortalNoZero
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(PortalNoZeroCoreModule))]
    public class PortalNoZeroDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<PortalNoZeroDbContext>(null);
        }
    }
}
