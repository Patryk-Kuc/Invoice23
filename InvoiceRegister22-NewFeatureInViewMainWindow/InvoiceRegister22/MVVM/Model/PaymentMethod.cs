using InvoiceRegister22.Core.Observable;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class PaymentMethod : ObservableObject
    {
        public int Id { get; set; }
        public string Method { get; set; }

        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
