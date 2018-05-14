﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureExercise.Forum.Data.Model.Contracts
{
    public interface IAuditable
    {
        DateTime? CreatedOn { get; set; }
        DateTime? ModifiedOn { get; set; }
    }
}
