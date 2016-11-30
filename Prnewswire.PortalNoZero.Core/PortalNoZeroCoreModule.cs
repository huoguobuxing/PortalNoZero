using System.Reflection;
using Abp.Modules;

namespace Prnewswire.PortalNoZero
{
    public class PortalNoZeroCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
