using System.Web;
using System.Web.Mvc;

namespace EntityFrameWorkDataFrist
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
