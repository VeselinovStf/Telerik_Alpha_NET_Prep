using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomContentSorter.Abstract
{
    public interface ISortAction<T> where T : class
    {
        IList<T> Order(IList<T> source);
    }
}
