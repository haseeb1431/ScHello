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
        
        public QueryResultRows<Franchise> AllFranchises => Db.SQL<Franchise>(
  "SELECT e FROM Franchise e WHERE e.Owner = ?", this);

    }
}
