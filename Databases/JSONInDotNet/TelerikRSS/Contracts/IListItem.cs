using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikRSS.Contracts
{
    public interface IListItem
    {
        string Title { get; set; }
        string URL { get; set; }
    }
}
