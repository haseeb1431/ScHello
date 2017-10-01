using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScHello.Modul
{
    [Database]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //For fun to keep the old name
        public string LastNameOld { get; set; }

        public QueryResultRows<Expense> Expenses => Db.SQL<Expense>(
            "SELECT e FROM Expense e WHERE e.Spender = ?",
            this);

        public decimal CurrentBalance => Db.SQL<decimal>(
                "SELECT SUM(e.Amount) FROM Expense e WHERE e.Spender = ?",
                this)
                .FirstOrDefault();

    }
}
