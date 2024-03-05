using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDavomi8
{
    public class ProductComparer : EqualityComparer<Product>
    {
        public int ProductID { get; set; }

        public override bool Equals(Product? product, Product? anotherProduct)
        {
            return (product?.Id == anotherProduct?.Id );
        }

        public override int GetHashCode([DisallowNull] Product product)
        {
            return product.Id.GetHashCode();
        }
    }       
}
