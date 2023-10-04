using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZ_WalksAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Regions");
        }
    }
}
