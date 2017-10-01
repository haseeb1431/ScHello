using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haseeb.Models
{
    [Database]
    public class Franchise
    {
        public Corporation Owner { get; set; }
        public Address Location { get; set; }
        public string FranchiseName { get; set; }
    }
}
