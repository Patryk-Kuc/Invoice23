using InvoiceRegister22.Core.Observable;
using System;
using System.Collections.Generic;

namespace InvoiceRegister22.MVVM.Model
{
    public class Orders : ObservableObject
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public string? Description { get; set; }

        public int SellerId { get; set; }
        public int BuyerId { get; set; }

        public Invoice Invoice { get; set; }
        public Seller Seller { get; set; }
        public Buyer Buyer { get; set; }

        public List<OrderedProducts> OrderedProducts { get; set; } = new List<OrderedProducts>();
    }
}
