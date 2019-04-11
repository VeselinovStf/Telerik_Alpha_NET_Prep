using CustomContentSorter.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversiteySystem.Data;
using UniversitySystem.Models.Entities;

namespace ContentSorting.SortingTypes
{
    // Specify T as your sort/order nead
    public class StudentFirstNameDescSort : ISortAction<Student>
    {
        //public readonly CONNECTION TO GET FROM 
      
        //Sorting/Ordering action
        public IList<Student> Order(IList<Student> source)
        {
            var call =  source.OrderByDescending(e => e.FirstMidName).ToList();

            return call;
        }

       
    }
}
