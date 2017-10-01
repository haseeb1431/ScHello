using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haseeb.Models
{
    [Database]
    public class Corporation
    {
        public string CorpName { get; set; }

        public decimal FranchisesCount => Db.SQL<decimal>(
  "SELECT COUNT(e.FranchiseName) FROM Franchise e WHERE e.Owner = ?", this).FirstOrDefault();
        

        public QueryResultRows<Franchise> AllFranchises => Db.SQL<Franchise>(
  "SELECT e FROM Franchise e WHERE e.Owner = ?", this);

    }
}
