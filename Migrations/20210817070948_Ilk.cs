using Microsoft.EntityFrameworkCore.Migrations;

namespace AgustosMarket.Migrations
{
    public partial class Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "KategoriAd" },
                values: new object[] { 1, "Temizlik" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "KategoriAd" },
                values: new object[] { 2, "Meyve/Sebze" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "BirimFiyat", "KategoriId", "UrunAd" },
                values: new object[,]
                {
                    { 1, 19.90m, 1, "Deterjan" },
                    { 2, 9.90m, 1, "Sabun" },
                    { 3, 9.90m, 1, "Temizlik Bezi" },
                    { 4, 6.90m, 2, "Elma" },
                    { 5, 5.00m, 2, "Karpuz" },
                    { 6, 15.40m, 2, "Çilek" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
