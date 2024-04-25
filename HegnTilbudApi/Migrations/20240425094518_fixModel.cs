using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HegnTilbudApi.Migrations
{
    /// <inheritdoc />
    public partial class fixModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "rafHegn");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "rafHegn");

            migrationBuilder.DropColumn(
                name: "Thick",
                table: "rafHegn");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "rafHegn",
                newName: "Quantity");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "rafHegn",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "rafHegn",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "rafHegn",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "rafHegn");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "rafHegn");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "rafHegn");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "rafHegn",
                newName: "Width");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "rafHegn",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "rafHegn",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Thick",
                table: "rafHegn",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
