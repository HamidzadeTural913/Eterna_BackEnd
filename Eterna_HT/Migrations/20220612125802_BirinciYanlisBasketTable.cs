using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna_HT.Migrations
{
    public partial class BirinciYanlisBasketTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boxs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoxIcon = table.Column<string>(nullable: true),
                    BoxTitle = table.Column<string>(nullable: true),
                    BoxSubTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boxs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boxs");
        }
    }
}
