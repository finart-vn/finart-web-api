using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finart_stock_web_api.Data.Migrations
{
    /// <inheritdoc />
    public partial class DeleteTimeInUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "update_at",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "created_at",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "update_at",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
