using CustomContentSorter.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversiteySystem.Data;
using UniversitySystem.Models.Entities;

namespace ContentSorting.SortingTypes
{
    public class StudentLastNameDescSort : ISortAction<Student>
    {       

        //Sorting/Ordering action
        public  IList<Student> Order(IList<Student> source)
        {
            var call = source.OrderByDescending(e => e.LastName).ToList();

            return call;
        }

    }
}
