using System.Web;
using System.Web.Mvc;

namespace Lesson_01_Task_Add
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
