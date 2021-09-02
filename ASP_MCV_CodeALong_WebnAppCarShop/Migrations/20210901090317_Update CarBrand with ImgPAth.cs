using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_MCV_CodeALong_WebnAppCarShop.Migrations
{
    public partial class UpdateCarBrandwithImgPAth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "CarBrands",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "CarBrands");
        }
    }
}
