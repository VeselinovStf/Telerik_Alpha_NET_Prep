using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public interface IAccountable
    {
        Client ClientName { get; }
         decimal Balance { get; }
         decimal MonthlyProcent { get; }
    }
}
