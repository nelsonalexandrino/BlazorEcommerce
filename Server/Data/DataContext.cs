
namespace BlazorEcommerce.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base (options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "Lascaux",
					Description = "A disposição da caverna, cujas paredes estão pintadas com bovídeos, cavalos, cervos, cabras selvagens, felinos, entre outros animais, permite pensar que tratar-se de um santuário. As investigações levadas a cabo durante os últimos decénios permitem situar a cronologia das pinturas no final do Solutrense e princípio do Madalenense, ou seja, 17 000 anos AP",
					ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1e/Lascaux_painting.jpg",
					Price = 9.99m
				},
			new Product
			{
				Id = 2,
				Title = "Vénus de Willendorf",
				Description = "Vênus de Willendorf, hoje também conhecida como Mulher de Willendorf, é uma estatueta de Vénus estimada como esculpida entre 28 000 e 25 000 anos antes de Cristo.[1] Ela foi encontrada em 7 de Agosto de 1908 por um trabalhador de nome Johann Veram[2] ou Josef Veram,[3] não se sabe ao certo, que trabalhava na equipe do arqueólogo Josef Szombathy. Possui 11,1 cm (4 3/8 polegadas) de altura representando estilisticamente uma mulher, descoberta no sítio arqueológico do paleolítico situado perto de Willendorf, na Áustria.[4]",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg",
				Price = 8.99m
			},
			new Product
			{
				Id = 3,
				Title = "Juízo Final (Michelangelo)",
				Description = "O Dia do Juízo Final é um fresco do pintor renascentista italiano Michelangelo Buonarroti medindo 13,7 m x 12,2 m, pintado na parede do altar da Capela Sistina. É na visão do artista, uma representação do Juízo Final inspirada na narrativa bíblica.",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Last_Judgement_%28Michelangelo%29.jpg/800px-Last_Judgement_%28Michelangelo%29.jpg",
				Price = 5.99m
			});
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Product> Products { get; set; }
	}
}
