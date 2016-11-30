using Abp.Web.Mvc.Controllers;

namespace Prnewswire.PortalNoZero.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class PortalNoZeroControllerBase : AbpController
    {
        protected PortalNoZeroControllerBase()
        {
            LocalizationSourceName = PortalNoZeroConsts.LocalizationSourceName;
        }
    }
}