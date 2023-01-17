using InvoiceRegister22.Core.Observable;

namespace InvoiceRegister22.MVVM.Model
{
    public class Persons : ObservableObject
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string City { get; set; }
        public string? Street { get; set; }
        public string Postcode { get; set; }

        public Buyer Buyer { get; set; }
    }
}
