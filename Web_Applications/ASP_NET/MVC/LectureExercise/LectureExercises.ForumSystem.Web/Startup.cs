using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LectureExercises.ForumSystem.Web.Startup))]
namespace LectureExercises.ForumSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
