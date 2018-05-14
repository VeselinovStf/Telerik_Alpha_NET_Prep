using System;
using System.ComponentModel.DataAnnotations;

namespace LectureExercise.Forum.Data.Model
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
    }
}
