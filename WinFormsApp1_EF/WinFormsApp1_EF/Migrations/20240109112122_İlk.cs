using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1_EF.Migrations
{
    /// <inheritdoc />
    public partial class İlk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ogrenciler",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    okulNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ogrenciler", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ogrenciler");
        }
    }
}
