using Newtonsoft.Json;
using System.Collections;
using System.Text;

namespace JSONdotNEt
{
    public class Book
    {
        //Neadet for Deserialize
        public Book()
        {
        }

        public Book(int id, string title, string description, params string[] genres)
        {
            Id = id;
            Title = title;
            Description = description;
            Genres = genres;
        }

        [JsonProperty("Id")]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable Genres { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Book Info");
            result.AppendLine($"{this.Id}");
            result.AppendLine($"{this.Title}");
            result.AppendLine($"{this.Description}");
            result.AppendLine($"--Genres--");
            foreach (var genre in this.Genres)
            {
                result.AppendLine($"{genre}");
            }

            return result.ToString();
        }
    }
}