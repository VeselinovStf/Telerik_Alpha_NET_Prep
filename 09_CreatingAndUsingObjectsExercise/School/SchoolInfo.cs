using System.Collections.Generic;

namespace School
{
    public class SchoolInfo
    {
        private List<SchoolClass> classes;

        public SchoolInfo()
        {
            this.classes = new List<SchoolClass>();
        }

        public SchoolInfo(List<SchoolClass> classes) : this()
        {
            this.classes = classes;
        }

        public void AddClass(SchoolClass className)
        {
            this.classes.Add(className);
        }


    }
}
