using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class Seller : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nip { get; set; }
        public string City { get; set; }
        public string? Street { get; set; }
        public string Postcode { get; set; }

        public List<Orders> Orders { get; set; } = new List<Orders>();
    }
}
