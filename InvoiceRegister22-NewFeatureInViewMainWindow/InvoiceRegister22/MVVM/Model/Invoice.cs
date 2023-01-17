using InvoiceRegister22.Core.Observable;
using System;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class Invoice : ObservableObject
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime DateOfInvoice { get; set; }

        public int OrderId { get; set; }

        public Payment Payment { get; set; }
        public Orders Orders { get; set; }
    }
}
