
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySystem.Models.Entities;

namespace CustomContentSorter.Abstract
{
    public interface IPageSort
    {
        IList<Student> Sort(string order, IList<Student> source);
    }
}
