using System.Web;
using System.Web.Mvc;

namespace LectureExercises.ForumSystem.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
