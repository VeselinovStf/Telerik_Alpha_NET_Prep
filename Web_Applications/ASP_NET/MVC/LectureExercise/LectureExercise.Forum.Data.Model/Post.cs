using LectureExercise.Forum.Data.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace LectureExercise.Forum.Data.Model
{
    public class Post: DataModel
    {
        
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual User Author { get; set; }

    }
}
