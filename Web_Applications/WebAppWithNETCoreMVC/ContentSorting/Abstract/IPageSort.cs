﻿using MovieSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Models.Entities;

namespace ContentSorting.Abstract
{
    public interface IPageSort
    {
        Task<IQueryable<Student>> Sort(string order);
    }
}
