using System;
using System.Text;

namespace LibraryInfo
{
    public class Book
    {
        private string name;
        private string author;
        private string publisher;
        private int yearOfPublishing;
        private int iSBN;
        private const string PRINTLINE = "---------------";

        public string Name { get => name; }
        public string Author { get => author; }
        public string Publisher { get => publisher; }

        public int YearOfPublishing
        {
            get
            {
                return this.yearOfPublishing;
            }
        }

        public int ISBN { get => iSBN; }


        public Book(
            string name,
            string author,
            string publisher,
            int yearOfPublishing,
            int iSBN
            )
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.yearOfPublishing = yearOfPublishing;
            this.iSBN = iSBN;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(PRINTLINE);
            result.AppendLine($"Name: {this.Name}");
            result.AppendLine($"Author: {this.Author}");
            result.AppendLine($"Publisher: {this.Publisher}");
            result.AppendLine($"Date of Publishing: {this.YearOfPublishing}");
            result.AppendLine($"ISBN : {this.ISBN}");
            result.AppendLine(PRINTLINE);

            return result.ToString();
        }
    }
}
