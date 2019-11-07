using Microsoft.EntityFrameworkCore.Migrations;

namespace WU18.KingPim.Data.Migrations
{
    public partial class db09_Removed_Nullable_from_bools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Publish",
                table: "Products",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Discontinued",
                table: "Products",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Publish",
                table: "Products",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "Discontinued",
                table: "Products",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
