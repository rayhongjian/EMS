using Abp.Web.Mvc.Views;

namespace EMS.Web.Views
{
    public abstract class EMSWebViewPageBase : EMSWebViewPageBase<dynamic>
    {

    }

    public abstract class EMSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected EMSWebViewPageBase()
        {
            LocalizationSourceName = EMSConsts.LocalizationSourceName;
        }
    }
}