using System.Reflection;
using Abp.Modules;

namespace Prnewswire.PortalNoZero
{
    [DependsOn(typeof(PortalNoZeroCoreModule))]
    public class PortalNoZeroApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
