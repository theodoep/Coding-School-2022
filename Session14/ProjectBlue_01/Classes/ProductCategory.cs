using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum ProductTypeEnum
    {
        Coffee = 0,
        Beverage = 1,
        Food = 2,
    }
    public class ProductCategory : Base
    {
        public ProductCategory() : base()
        {

        }

        public void ChooseType()
        {
            Dictionary<ProductTypeEnum, string> productTypes = new Dictionary<ProductTypeEnum, string>();
            productTypes.Add(ProductTypeEnum.Coffee, "Coffee");
            productTypes.Add(ProductTypeEnum.Beverage, "Beverage");
            productTypes.Add(ProductTypeEnum.Food, "Food");
        }
    }
}
