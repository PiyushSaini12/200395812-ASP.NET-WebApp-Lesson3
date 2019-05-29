using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Lesson_Final_200395812
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
