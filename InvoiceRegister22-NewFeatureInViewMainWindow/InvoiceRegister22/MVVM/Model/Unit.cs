using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class Unit : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Products> Products { get; set; } = new List<Products>();
    }
}
