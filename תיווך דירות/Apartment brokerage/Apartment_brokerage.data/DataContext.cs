
using Microsoft.EntityFrameworkCore;
using Apartment_brokerage.Core.Entities;

namespace Apartment_brokerage
{
    public class DataContext:DbContext
    {
        public new DbSet<Apartment> Apartments { get; set; }


        public new DbSet<SellingApartment> SellingApartment { get; set; }

        public new DbSet<Client> Client { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Apartment_brokerage");
        }
    }
}
