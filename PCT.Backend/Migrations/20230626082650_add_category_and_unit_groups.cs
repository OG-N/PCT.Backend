using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCT.Backend.Migrations
{
    /// <inheritdoc />
    public partial class add_category_and_unit_groups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "mst_unit",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "mst_category",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "mst_unit");

            migrationBuilder.DropColumn(
                name: "Group",
                table: "mst_category");
        }
    }
}
