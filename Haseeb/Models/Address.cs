using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haseeb.Models
{
    [Database]
    public class Address
    {
        public String Street { get; set; }
        public int Number { get; set; }
        public int ZipCode { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
    }
}
