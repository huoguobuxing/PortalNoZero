using Abp.Web.Mvc.Views;

namespace Prnewswire.PortalNoZero.Web.Views
{
    public abstract class PortalNoZeroWebViewPageBase : PortalNoZeroWebViewPageBase<dynamic>
    {

    }

    public abstract class PortalNoZeroWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PortalNoZeroWebViewPageBase()
        {
            LocalizationSourceName = PortalNoZeroConsts.LocalizationSourceName;
        }
    }
}