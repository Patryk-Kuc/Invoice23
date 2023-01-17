using InvoiceRegister22.Core.Observable;

namespace InvoiceRegister22.MVVM.Model
{
    public class Products : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal NetPrice { get; set; }
        public decimal TaxRate { get; set; }

        public int UnitId { get; set;}
        public int CategoriesId { get; set; }
        public int OrderedProductsId { get; set; }
        public int WarehouseInventoryId { get; set; }

        public OrderedProducts OrderedProducts { get; set; }
        public Unit Unit { get; set; }
        public Categories Categories { get; set; }
        public WarehouseInventory WarehouseInventory { get; set; }
    }
}
