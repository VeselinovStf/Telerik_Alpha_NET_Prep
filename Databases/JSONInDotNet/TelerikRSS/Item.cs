using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikRSS.Contracts;

namespace TelerikRSS
{
    public class Item : IListItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("@url")]
        public string URL { get; set; }
    }
}
