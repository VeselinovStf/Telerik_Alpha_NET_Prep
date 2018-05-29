using System.Linq;
using LectureExercise.Forum.Data.Model;

namespace LectureExercise.Forum.Servicess
{
    public interface IPostsService
    {
        IQueryable<Post> GetAll();
    }
}