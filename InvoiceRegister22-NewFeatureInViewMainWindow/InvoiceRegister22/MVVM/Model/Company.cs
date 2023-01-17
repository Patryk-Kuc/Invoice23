using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;
using System.Windows.Documents;

namespace InvoiceRegister22.MVVM.Model
{
    public class Company : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nip { get; set; }
        public string City { get; set; }
        public string? Street { get; set; }
        public string Postcode { get; set; }

        public Buyer Buyer { get; set; }
    }
}
