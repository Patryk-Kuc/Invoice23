using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class OrderedProducts : ObservableObject
    {
        public int Id { get; set; }
        public float QuantityProducts { get; set; }

        public int ProductId { get; set; }
        public int OrdersId { get; set; }

        public Orders Orders { get; set; }
        public List<Products> Products { get; set; } = new List<Products>();
    }
}
