using System.Text;

namespace StudentsInfo
{
    public class Student
    {
        private static int studentsCount = 0;
        private string firstName;
        private string midleName;
        private string lastName;
        private byte course;
        private Specialities speciality;
        private Universities university;
        private string eMail;
        private string phoneNumber;

        public Student()
        {
            this.firstName = null;
            this.midleName = null;
            this.lastName = null;
            this.course = 0;
            this.speciality = 0;
            this.university = 0;
            this.eMail = null;
            this.phoneNumber = null;

            studentsCount++;
        }

        public Student(
            string firstName,
            string midleName,
            string lastName)
            :this()
        {
            this.firstName = firstName;
            this.midleName = midleName;
            this.lastName = lastName;
     
        }

        public Student(string firstName,
            string midleName,
            string lastName,
            byte course,
            Specialities speciality,
           Universities university,
            string eMail,
           string phoneNumber)
            : this(firstName, midleName, lastName)
        {
            this.course = course;
            this.speciality = speciality;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;

        }

        public static int StudentsCount { get => studentsCount; }
        public string FirstName { get => firstName; }
        public string MidleName { get => midleName; }
        public string LastName { get => lastName; }
        public byte Course { get => course; }
        public Specialities Speciality { get => speciality; }
        public Universities University { get => university; }
        public string EMail { get => eMail; }
        public string PhoneNumber { get => phoneNumber; }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Student : {this.FirstName} {this.MidleName} {this.LastName}");
            result.AppendLine($"Course: {this.Course}");
            result.AppendLine($"Speciality: {this.Speciality}");
            result.AppendLine($"University: {this.University}");
            result.AppendLine($"E-Mail: {this.EMail}");
            result.AppendLine($"Phone Number: {this.PhoneNumber}");

            return result.ToString();
        }
    }
}
