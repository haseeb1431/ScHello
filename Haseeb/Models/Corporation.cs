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

        public QueryResultRows<Franchise> Franchises => Db.SQL<Franchise>(
    "SELECT e FROM Corporation e WHERE e.Owner = ?", this);

        public QueryResultRows<Corporation> AllCorporation => Db.SQL<Corporation>(
    "SELECT c FROM Corporation c ");
    }
}
