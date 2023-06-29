using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiThiTXT.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_TXTCau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TXTCau3",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenLop = table.Column<string>(type: "TEXT", nullable: true),
                    KhoaHoc = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TXTCau3", x => x.MaLop);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TXTCau3");
        }
    }
}
