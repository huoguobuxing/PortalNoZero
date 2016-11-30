using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace Prnewswire.PortalNoZero
{
    [DependsOn(typeof(AbpWebApiModule), typeof(PortalNoZeroApplicationModule))]
    public class PortalNoZeroWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(PortalNoZeroApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
