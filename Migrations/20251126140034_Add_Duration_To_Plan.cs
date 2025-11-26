using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlaner.Migrations
{
    /// <inheritdoc />
    public partial class Add_Duration_To_Plan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "plans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "plans");
        }
    }
}
