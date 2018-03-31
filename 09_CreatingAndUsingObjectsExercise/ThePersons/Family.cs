using System.Collections.Generic;
using System.Linq;

namespace ThePersons
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            if (member != null)
            {
                this.members.Add(member);
            }
        }

        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(x => x.Age).First();
        }
    }
}
