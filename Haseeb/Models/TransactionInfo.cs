using Starcounter;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haseeb.Models
{
    [Database]
    public class TransactionInfo
    {
        public DateTime TransactionDate { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Commission { get; set; }
        
        //Address of the property for which transaction has been made
        public Address PropertyAddress { get; set; }

        //Franchise that is involved in transaction
        public Franchise Benificary { get; set; }
    }
}
