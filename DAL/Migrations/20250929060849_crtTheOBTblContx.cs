using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class crtTheOBTblContx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bond_owned",
                columns: table => new
                {
                    ob_id = table.Column<int>(type: "int", nullable: false),
                    ob_bond_series = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ob_bond_no = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bond_owned", x => x.ob_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bond_owned");
        }
    }
}
