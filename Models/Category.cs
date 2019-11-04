using System.Collections.Generic;

namespace ProductCatalog.Models
{
    public class Category
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<Product> Products { get; set; }
        
    }
}