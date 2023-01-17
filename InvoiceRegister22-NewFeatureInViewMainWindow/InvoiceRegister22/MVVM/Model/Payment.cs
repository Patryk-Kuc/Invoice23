using InvoiceRegister22.Core.Observable;
using System;

namespace InvoiceRegister22.MVVM.Model
{
    public class Payment : ObservableObject
    {
        public int Id { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public string? PaymentDescription { get; set; }

        public int InvoiceId { get; set; }
        public int BankAccountId { get; set; }
        public int PaymentMethodId { get; set; }

        public Invoice Invoice { get; set; }
        public BankAccount BankAccount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
