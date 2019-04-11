using ContentSorting.SortingTypes;
using CustomContentSorter.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UniversiteySystem.Data;
using UniversitySystem.Models.Entities;

namespace ContentSorting
{
    public class StudentSort : IPageSort
    {
        // Set for every Sortable entity
        public Dictionary<StudentSortRule, ISortAction<Student>> Options =
            new Dictionary<StudentSortRule, ISortAction<Student>>();

        public StudentSort()
        {
            this.Options.Add(StudentSortRule.FirstName, new StudentFirstNameDescSort());
            this.Options.Add(StudentSortRule.LastName, new StudentLastNameDescSort());          
            this.Options.Add(StudentSortRule.EnrollmentDate, new StudentEnrollmentDateDescSort());
        }
       
        public IList<Student> Sort(string order, IList<Student> source)
        {
            var orderKey = (StudentSortRule)Enum.Parse(typeof(StudentSortRule), order, true);

            var ordered =  Options[orderKey].Order(source);

            return ordered;
        }
    }
}
