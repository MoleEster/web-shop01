using Site0303.Data.Interfaces;
using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data.Mocks
{
    public class MockCategory1 : IAllCategories1
    {
        public IEnumerable<Category1> AllCategories1
        {
            get
            {
                return new List<Category1>
                {
                    new Category1{ category1Name="firearms", Desc = "Regular guns to protect yourself from a distance"},
                    new Category1{ category1Name="steel-arms", Desc = "elegant fast and appearing out of nowhere"},
                };
            }
        }
    }
}
