﻿using LectureExercise.Forum.Data.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace LectureExercise.Forum.Data
{

    public class MsSqlDbContext : IdentityDbContext<User>
    {
        public MsSqlDbContext()
            : base("LocalConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Post> Posts { get; set; }

        public static MsSqlDbContext Create()
        {
            return new MsSqlDbContext();
        }
    }
}
