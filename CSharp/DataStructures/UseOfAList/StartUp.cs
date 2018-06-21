using ArrayList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfAList
{
    class StartUp
    {
        static void Main()
        {
            AList<int> list = new AList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list.RemoveAt(3);
           
        }
    }
}
