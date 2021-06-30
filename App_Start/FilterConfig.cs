using System.Web;
using System.Web.Mvc;

namespace _1811062672_PhanNguyenTrongDuc_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
