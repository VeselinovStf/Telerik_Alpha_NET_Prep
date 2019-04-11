using CustomContentSorter.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversiteySystem.Data;
using UniversitySystem.Models.Entities;

namespace ContentSorting.SortingTypes
{
    public class StudentEnrollmentDateDescSort : ISortAction<Student>
    {  
        //Sorting/Ordering action
        public IList<Student> Order(IList<Student> source)
        {
            var call = source
                .OrderByDescending(e => e.EnrollmentDate.Value.Year)
                .ThenByDescending(e => e.EnrollmentDate.Value.Day)
                .ToList();

            return call;
        }
    
    }
}
