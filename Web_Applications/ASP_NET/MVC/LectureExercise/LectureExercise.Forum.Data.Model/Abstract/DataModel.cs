﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LectureExercise.Forum.Data.Model.Contracts;

namespace LectureExercise.Forum.Data.Model.Abstract
{
    public abstract class DataModel : IDeletable, IAuditable
    {
        public DataModel()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public  Guid Id{get;set;}

        [Index]
        public bool IsDeleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }
    }
}
