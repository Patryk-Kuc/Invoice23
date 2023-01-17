using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class BankAccount : ObservableObject
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccoundNumber { get; set; }

        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
