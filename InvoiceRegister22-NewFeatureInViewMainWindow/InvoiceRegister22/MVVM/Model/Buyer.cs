using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class Buyer : ObservableObject
    {
        public int Id { get; set; }

        public int? CompanyId { get; set; }
        public int? PersonsId { get; set; }

        public Company Company { get; set; }
        public Persons Persons { get; set; }
        public List<Orders> Orders { get; set; } = new List<Orders>();
    }
}
