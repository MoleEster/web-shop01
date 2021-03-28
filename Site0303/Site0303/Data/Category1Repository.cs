using Site0303.Data.Interfaces;
using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data
{
    public class Category1Repository : IAllCategories1
    {
        private readonly AppDbContent appDbContent;
        public Category1Repository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Category1> AllCategories1 => appDbContent.Category1;
    }
}
