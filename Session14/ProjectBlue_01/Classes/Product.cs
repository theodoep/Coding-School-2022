using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Product : Base
    {
        public Guid ProductCategoryID { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public ProductTypeEnum ProductType { get; set; }

        public Product() : base()
        {
            ProductCategoryID = new ProductCategory().ID;
        }

    }

}
