using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class WarehouseInventory : ObservableObject 
    {
        public int Id { get; set; }
        public float State { get; set; }

        public int ProductsId { get; set; }

        public List<Products> Products { get; set; }
    }
}
