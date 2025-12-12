using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlaner.Migrations
{
    /// <inheritdoc />
    public partial class Add_Pinned_Property_To_Plans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pinned",
                table: "exercises");

            migrationBuilder.AddColumn<bool>(
                name: "Pinned",
                table: "plans",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pinned",
                table: "plans");

            migrationBuilder.AddColumn<bool>(
                name: "Pinned",
                table: "exercises",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
