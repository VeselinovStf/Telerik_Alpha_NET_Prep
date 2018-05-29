using LectureExercise.Forum.Data.Model;
using LectureExercise.Forum.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureExercise.Forum.Servicess
{
    public class PostsService : IPostsService
    {
        private readonly IEfRepository<Post> postService;

        public PostsService(IEfRepository<Post> postService)
        {
            this.postService = postService;
        }

        public IQueryable<Post> GetAll()
        {
            return this.postService.All;
        }
    }
}
