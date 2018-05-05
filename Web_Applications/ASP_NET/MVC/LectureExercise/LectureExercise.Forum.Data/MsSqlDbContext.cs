using LectureExercise.Forum.Data.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LectureExercise.Forum.Data
{

    public class MsSqlDbContext : IdentityDbContext<User>
    {
        public MsSqlDbContext()
            : base("LocalConnection", throwIfV1Schema: false)
        {
        }

        public static MsSqlDbContext Create()
        {
            return new MsSqlDbContext();
        }
    }
}
