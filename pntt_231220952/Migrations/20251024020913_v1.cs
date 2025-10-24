using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pntt_231220952.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pnttComputer",
                columns: table => new
                {
                    PnttComId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PnttComName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PnttComPrice = table.Column<double>(type: "float", nullable: false),
                    PnttComImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PnttComStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pnttComputer", x => x.PnttComId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pnttComputer");
        }
    }
}
