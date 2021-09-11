using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }

        public bool? IsFeatured { get; set; }

        //define the relation many to many between product and Category
        public IList<ProductInCategory> ProductInCategories { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }

        public IList<Cart> Carts { get; set; }

        public IList<ProductImage> ProductImages { get; set; }
        public IList<ProductTranslation> ProductTranslations { get; set; }
    }
}