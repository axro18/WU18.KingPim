using Microsoft.EntityFrameworkCore.Migrations;

namespace WU18.KingPim.Data.Migrations
{
    public partial class db09_removed_FK_for_subcategory_from_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);
        }
    }
}
