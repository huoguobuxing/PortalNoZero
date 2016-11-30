using Abp.Application.Services;

namespace Prnewswire.PortalNoZero
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class PortalNoZeroAppServiceBase : ApplicationService
    {
        protected PortalNoZeroAppServiceBase()
        {
            LocalizationSourceName = PortalNoZeroConsts.LocalizationSourceName;
        }
    }
}