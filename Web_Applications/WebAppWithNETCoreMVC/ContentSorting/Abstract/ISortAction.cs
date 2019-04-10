using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentSorting.Abstract
{
    public interface ISortAction<T> where T : class
    {
        Task<IQueryable<T>> Order();
    }
}
