﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A disposição da caverna, cujas paredes estão pintadas com bovídeos, cavalos, cervos, cabras selvagens, felinos, entre outros animais, permite pensar que tratar-se de um santuário. As investigações levadas a cabo durante os últimos decénios permitem situar a cronologia das pinturas no final do Solutrense e princípio do Madalenense, ou seja, 17 000 anos AP",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/1e/Lascaux_painting.jpg",
                            Price = 9.99m,
                            Title = "Lascaux"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Vênus de Willendorf, hoje também conhecida como Mulher de Willendorf, é uma estatueta de Vénus estimada como esculpida entre 28 000 e 25 000 anos antes de Cristo.[1] Ela foi encontrada em 7 de Agosto de 1908 por um trabalhador de nome Johann Veram[2] ou Josef Veram,[3] não se sabe ao certo, que trabalhava na equipe do arqueólogo Josef Szombathy. Possui 11,1 cm (4 3/8 polegadas) de altura representando estilisticamente uma mulher, descoberta no sítio arqueológico do paleolítico situado perto de Willendorf, na Áustria.[4]",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Mona_Lisa%2C_by_Leonardo_da_Vinci%2C_from_C2RMF_retouched.jpg",
                            Price = 8.99m,
                            Title = "Vénus de Willendorf"
                        },
                        new
                        {
                            Id = 3,
                            Description = "O Dia do Juízo Final é um fresco do pintor renascentista italiano Michelangelo Buonarroti medindo 13,7 m x 12,2 m, pintado na parede do altar da Capela Sistina. É na visão do artista, uma representação do Juízo Final inspirada na narrativa bíblica.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Last_Judgement_%28Michelangelo%29.jpg/800px-Last_Judgement_%28Michelangelo%29.jpg",
                            Price = 5.99m,
                            Title = "Juízo Final (Michelangelo)"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
