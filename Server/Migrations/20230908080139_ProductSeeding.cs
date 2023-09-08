using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A disposição da caverna, cujas paredes estão pintadas com bovídeos, cavalos, cervos, cabras selvagens, felinos, entre outros animais, permite pensar que tratar-se de um santuário. As investigações levadas a cabo durante os últimos decénios permitem situar a cronologia das pinturas no final do Solutrense e princípio do Madalenense, ou seja, 17 000 anos AP", "https://upload.wikimedia.org/wikipedia/commons/1/1e/Lascaux_painting.jpg", 9.99m, "Lascaux" },
                    { 2, "Vênus de Willendorf, hoje também conhecida como Mulher de Willendorf, é uma estatueta de Vénus estimada como esculpida entre 28 000 e 25 000 anos antes de Cristo.[1] Ela foi encontrada em 7 de Agosto de 1908 por um trabalhador de nome Johann Veram[2] ou Josef Veram,[3] não se sabe ao certo, que trabalhava na equipe do arqueólogo Josef Szombathy. Possui 11,1 cm (4 3/8 polegadas) de altura representando estilisticamente uma mulher, descoberta no sítio arqueológico do paleolítico situado perto de Willendorf, na Áustria.[4]", "https://upload.wikimedia.org/wikipedia/commons/e/ec/Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg", 8.99m, "Vénus de Willendorf" },
                    { 3, "O Dia do Juízo Final é um fresco do pintor renascentista italiano Michelangelo Buonarroti medindo 13,7 m x 12,2 m, pintado na parede do altar da Capela Sistina. É na visão do artista, uma representação do Juízo Final inspirada na narrativa bíblica.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Last_Judgement_%28Michelangelo%29.jpg/800px-Last_Judgement_%28Michelangelo%29.jpg", 5.99m, "Juízo Final (Michelangelo)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
