using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Sales
{
    public class OrderDetailViewModel
    {
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public Decimal Price { set; get; }
    }
}