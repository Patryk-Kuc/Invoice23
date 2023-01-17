using InvoiceRegister22.Core.Constant;
using InvoiceRegister22.MVVM.Model;
using Microsoft.EntityFrameworkCore;

namespace InvoiceRegister22.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Paymentes { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<OrderedProducts> OrderedProducts { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Company> Company { get; set; } 
        public DbSet<Persons> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>(ei =>
            {
                ei.Property(i => i.City).IsRequired().HasMaxLength(DBConstant.CityNameMaxLength);
                ei.Property(i => i.InvoiceNumber).IsRequired().HasMaxLength(20);
                ei.Property(i => i.DateOfInvoice).IsRequired();
                ei.Property(i => i.OrderId).IsRequired();
                ei.HasOne(i => i.Payment).WithOne(p => p.Invoice).HasForeignKey<Payment>(p => p.InvoiceId);
            });
            modelBuilder.Entity<Payment>(ep =>
            {
                ep.Property(p => p.PaymentStatus).IsRequired().HasMaxLength(DBConstant.PaymentStatusMaxLength);
                ep.Property(p => p.PaymentDeadline).IsRequired();
                ep.Property(p => p.PaymentDescription).HasMaxLength(DBConstant.DescriptionMaxLength);
                ep.Property(p => p.BankAccountId).IsRequired();
                ep.Property(p => p.PaymentMethodId).IsRequired();
                ep.Property(p => p.InvoiceId).IsRequired();
            });
            modelBuilder.Entity<Orders>(eo =>
            {
                eo.Property(o => o.SaleDate).IsRequired();
                eo.Property(o => o.Description).HasMaxLength(DBConstant.DescriptionMaxLength);
                eo.Property(o => o.BuyerId).IsRequired();
                eo.Property(o => o.SellerId).IsRequired();
                eo.HasOne(o => o.Invoice).WithOne(i => i.Orders).HasForeignKey<Invoice>(i => i.OrderId);
                eo.HasMany(o => o.OrderedProducts).WithOne(op =>op.Orders).HasForeignKey(op => op.OrdersId);
            });
            modelBuilder.Entity<BankAccount>(eba =>
            {
                eba.Property(ba => ba.BankName).IsRequired().HasMaxLength(DBConstant.BankNameMaxLength);
                eba.Property(ba => ba.AccoundNumber).IsRequired().HasMaxLength(DBConstant.AccoundNumberLength);
                eba.HasMany(ba => ba.Payments).WithOne(p => p.BankAccount).HasForeignKey(p => p.BankAccountId);
            });
            modelBuilder.Entity<PaymentMethod>(epm =>
            {
                epm.Property(pm => pm.Method).IsRequired().HasMaxLength(DBConstant.MethodPaymentMaxLength);
                epm.HasMany(pm => pm.Payments).WithOne(p => p.PaymentMethod).HasForeignKey(p => p.PaymentMethodId);
            });
            modelBuilder.Entity<Seller>(es =>
            {
                es.Property(s => s.Name).IsRequired().HasMaxLength(DBConstant.NameMaxLength);
                es.Property(s => s.Nip).IsRequired().IsRequired().HasMaxLength(DBConstant.NIPLength);
                es.Property(s => s.City).IsRequired().HasMaxLength(DBConstant.CityNameMaxLength);
                es.Property(s => s.Street).HasMaxLength(DBConstant.StreetNameMaxLength);
                es.Property(s => s.Postcode).IsRequired().HasMaxLength(DBConstant.PostcodeLength);
                es.HasMany(es => es.Orders).WithOne(o => o.Seller).HasForeignKey(o => o.SellerId);
            });
            modelBuilder.Entity<OrderedProducts>(eop =>
            {
                eop.Property(op => op.ProductId).IsRequired();
                eop.Property(op => op.OrdersId).IsRequired();
                eop.Property(op => op.QuantityProducts).IsRequired();
                eop.HasMany(op => op.Products).WithOne(p => p.OrderedProducts).HasForeignKey(p => p.OrderedProductsId);
            });
            modelBuilder.Entity<Products>(ep =>
            {
                ep.Property(p => p.Name).IsRequired().HasMaxLength(DBConstant.NameMaxLength);
                ep.Property(p => p.CategoriesId).IsRequired();
                ep.Property(p => p.UnitId).IsRequired();
                ep.Property(p => p.NetPrice).IsRequired();
                ep.Property(p => p.TaxRate).IsRequired();
            });
            modelBuilder.Entity<Unit>(eu =>
            {
                eu.Property(p => p.Name).IsRequired().HasMaxLength(DBConstant.NameUnitMaxLength);
                eu.HasMany(u => u.Products).WithOne(p => p.Unit).HasForeignKey(p => p.UnitId);
            });
            modelBuilder.Entity<Categories>(ec =>
            {
                ec.Property(p => p.Name).IsRequired().HasMaxLength(DBConstant.CategoriesNameMaxLength);
                ec.HasMany(c => c.Products).WithOne(p => p.Categories).HasForeignKey(p => p.CategoriesId);
            });
            modelBuilder.Entity<WarehouseInventory>(ew =>
            {
                ew.Property(w => w.ProductsId).IsRequired();
                ew.Property(w => w.State).IsRequired();
                ew.HasMany(w => w.Products).WithOne(p => p.WarehouseInventory).HasForeignKey(p => p.WarehouseInventoryId);
            });
            modelBuilder.Entity<Buyer>(eb =>
            {
                eb.Property(b => b.CompanyId).IsRequired();
                eb.Property(b => b.PersonsId).IsRequired();
                eb.HasMany(b => b.Orders).WithOne(o => o.Buyer).HasForeignKey(o => o.BuyerId);
            });
            modelBuilder.Entity<Company>(ec =>
            {
                ec.Property(c => c.Name).IsRequired().HasMaxLength(DBConstant.NameMaxLength);
                ec.Property(c => c.Nip).IsRequired().IsRequired().HasMaxLength(DBConstant.NIPLength);
                ec.Property(c => c.City).IsRequired().HasMaxLength(DBConstant.CityNameMaxLength);
                ec.Property(c => c.Street).HasMaxLength(DBConstant.StreetNameMaxLength);
                ec.Property(c => c.Postcode).IsRequired().HasMaxLength(DBConstant.PostcodeLength);
                ec.HasOne(c => c.Buyer).WithOne(b => b.Company).HasForeignKey<Buyer>(b => b.CompanyId);
            });
            modelBuilder.Entity<Persons>(ep =>
            {
                ep.Property(p => p.FirstName).IsRequired().HasMaxLength(DBConstant.NameMaxLength);
                ep.Property(p => p.LastName).IsRequired().HasMaxLength(DBConstant.NameMaxLength);
                ep.Property(p => p.Pesel).IsRequired().HasMaxLength(DBConstant.PeselLength);
                ep.Property(p => p.City).IsRequired().HasMaxLength(DBConstant.CityNameMaxLength);
                ep.Property(p => p.Street).HasMaxLength(DBConstant.StreetNameMaxLength);
                ep.Property(p => p.Postcode).IsRequired().HasMaxLength(DBConstant.PostcodeLength);
                ep.HasOne(p => p.Buyer).WithOne(b => b.Persons).HasForeignKey<Buyer>(b => b.PersonsId);
            });        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DBConstant.ConnectString);
        }
    }
}
