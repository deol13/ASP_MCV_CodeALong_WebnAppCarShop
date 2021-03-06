// <auto-generated />
using ASP_MCV_CodeALong_WebnAppCarShop.Controllers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Migrations
{
    [DbContext(typeof(CarShopDbContext))]
    [Migration("20210901093536_Added insurance and relationship between Car and Insurance")]
    partial class AddedinsuranceandrelationshipbetweenCarandInsurance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP_MCV_CodeALong_WebnAppCarShop.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("ASP_MCV_CodeALong_WebnAppCarShop.Models.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarBrands");
                });

            modelBuilder.Entity("ASP_MCV_CodeALong_WebnAppCarShop.Models.CarInsurance", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceId")
                        .HasColumnType("int");

                    b.HasKey("CarId", "InsuranceId");

                    b.HasIndex("InsuranceId");

                    b.ToTable("CarInsurances");
                });

            modelBuilder.Entity("ASP_MCV_CodeALong_WebnAppCarShop.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("ASP_MCV_CodeALong_WebnAppCarShop.Models.CarInsurance", b =>
                {
                    b.HasOne("ASP_MCV_CodeALong_WebnAppCarShop.Models.Car", "Car")
                        .WithMany("CarInsurances")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_MCV_CodeALong_WebnAppCarShop.Models.Insurance", "Insurance")
                        .WithMany("CarInsurances")
                        .HasForeignKey("InsuranceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Insurance");
                });

            modelBuilder.Entity("ASP_MCV_CodeALong_WebnAppCarShop.Models.Car", b =>
                {
                    b.Navigation("CarInsurances");
                });

            modelBuilder.Entity("ASP_MCV_CodeALong_WebnAppCarShop.Models.Insurance", b =>
                {
                    b.Navigation("CarInsurances");
                });
#pragma warning restore 612, 618
        }
    }
}
