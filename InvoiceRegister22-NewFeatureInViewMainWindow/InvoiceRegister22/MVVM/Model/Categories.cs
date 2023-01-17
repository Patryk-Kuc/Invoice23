using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class Categories : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CategoryId { get; set; }

        public List<Products> Products { get; set; }
    }
}
