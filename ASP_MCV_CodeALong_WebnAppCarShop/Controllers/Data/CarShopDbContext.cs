using ASP_MCV_CodeALong_WebnAppCarShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Controllers.Data
{
    public class CarShopDbContext : DbContext
    {
        public CarShopDbContext(DbContextOptions<CarShopDbContext> options) : base(options) { }

        //När vi skapar våra modeler körs denna
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Req
            base.OnModelCreating(modelBuilder);

            //ci, i och c kan ha vilket namn som helst
            modelBuilder.Entity<CarInsurance>().HasKey(ci =>
            new
            {
                ci.CarId,
                ci.InsuranceId
            });

            modelBuilder.Entity<CarInsurance>()
                .HasOne<Car>(ci => ci.Car)
                .WithMany(c => c.CarInsurances)
                .HasForeignKey(ci => ci.CarId);

            modelBuilder.Entity<CarInsurance>()
                .HasOne<Insurance>(ci => ci.Insurance)
                .WithMany(i => i.CarInsurances)
                .HasForeignKey(ci => ci.InsuranceId);
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<CarInsurance> CarInsurances { get; set; }

    }
}
