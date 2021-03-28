using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ushort Price { get; set; }
        public string img { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsAviable { get; set; }
        public string Description { get; set; }
        public virtual Category1 Category1 { get; set; }

    }
}
