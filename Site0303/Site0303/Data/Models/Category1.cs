using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data.Models
{
    public class Category1
    {
        public int Id { get; set; }
        public string category1Name { get; set; }
        public string Desc { get; set; }
        public List<Product> Products { get; set; }
    }
}
