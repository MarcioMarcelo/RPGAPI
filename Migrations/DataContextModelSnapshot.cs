﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgApi.Data;

#nullable disable

namespace RpgApi.Migrations
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

            modelBuilder.Entity("RpgApi.Models.Armas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dano")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonagemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonagemId")
                        .IsUnique();

                    b.ToTable("TB_ARMAS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dano = 10,
                            Nome = "Espada",
                            PersonagemId = 1
                        },
                        new
                        {
                            Id = 2,
                            Dano = 20,
                            Nome = "Machado",
                            PersonagemId = 2
                        },
                        new
                        {
                            Id = 3,
                            Dano = 7,
                            Nome = "Arco",
                            PersonagemId = 3
                        },
                        new
                        {
                            Id = 4,
                            Dano = 15,
                            Nome = "Maca",
                            PersonagemId = 4
                        },
                        new
                        {
                            Id = 5,
                            Dano = 10,
                            Nome = "Bordao",
                            PersonagemId = 5
                        },
                        new
                        {
                            Id = 6,
                            Dano = 4,
                            Nome = "Manopla",
                            PersonagemId = 6
                        },
                        new
                        {
                            Id = 7,
                            Dano = 6,
                            Nome = "Chicote",
                            PersonagemId = 7
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<int>("Forca")
                        .HasColumnType("int");

                    b.Property<byte[]>("FotoPersonagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Inteligencia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PontosVida")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_PERSONAGENS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Classe = 0,
                            Defesa = 0,
                            Forca = 0,
                            Inteligencia = 0,
                            Nome = "",
                            PontosVida = 0
                        },
                        new
                        {
                            Id = 2,
                            Classe = 1,
                            Defesa = 25,
                            Forca = 15,
                            Inteligencia = 30,
                            Nome = "Sam",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 3,
                            Classe = 3,
                            Defesa = 21,
                            Forca = 18,
                            Inteligencia = 35,
                            Nome = "Galadriel",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 4,
                            Classe = 2,
                            Defesa = 18,
                            Forca = 18,
                            Inteligencia = 37,
                            Nome = "Gandalf",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 5,
                            Classe = 1,
                            Defesa = 17,
                            Forca = 20,
                            Inteligencia = 31,
                            Nome = "Hobbit",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 6,
                            Classe = 3,
                            Defesa = 13,
                            Forca = 21,
                            Inteligencia = 34,
                            Nome = "Celeborn",
                            PontosVida = 100
                        },
                        new
                        {
                            Id = 7,
                            Classe = 2,
                            Defesa = 11,
                            Forca = 25,
                            Inteligencia = 35,
                            Nome = "Radagast",
                            PontosVida = 100
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAcesso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Foto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Perfil")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Jogador");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIOS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "seuEmail@gmail.com",
                            Latitude = -23.520024100000001,
                            Longitude = -46.596497999999997,
                            PasswordHash = new byte[] { 155, 240, 67, 54, 22, 116, 82, 208, 133, 22, 237, 110, 17, 157, 87, 92, 56, 186, 161, 80, 89, 155, 102, 59, 173, 184, 1, 214, 215, 65, 199, 83, 134, 58, 12, 92, 208, 78, 126, 55, 236, 193, 186, 225, 40, 192, 57, 197, 160, 201, 32, 175, 110, 175, 167, 122, 253, 40, 151, 14, 30, 248, 180, 58 },
                            PasswordSalt = new byte[] { 177, 200, 215, 210, 204, 86, 108, 236, 82, 196, 35, 135, 172, 227, 147, 198, 109, 249, 171, 164, 145, 235, 252, 43, 59, 141, 130, 220, 247, 221, 193, 47, 246, 85, 235, 166, 231, 1, 240, 113, 1, 167, 220, 103, 199, 43, 122, 81, 248, 23, 157, 177, 175, 253, 230, 111, 213, 105, 76, 19, 204, 67, 197, 135, 5, 41, 76, 170, 1, 183, 212, 29, 140, 37, 130, 22, 133, 43, 236, 31, 231, 200, 255, 185, 246, 59, 160, 96, 222, 67, 237, 65, 70, 137, 58, 173, 43, 10, 174, 221, 250, 104, 84, 31, 13, 11, 226, 229, 159, 188, 163, 55, 189, 252, 42, 47, 113, 112, 163, 45, 122, 190, 51, 135, 0, 242, 187, 102 },
                            Perfil = "Admin",
                            Username = "UsuarioAdmin"
                        });
                });

            modelBuilder.Entity("RpgApi.Models.Armas", b =>
                {
                    b.HasOne("RpgApi.Models.Personagem", "Personagem")
                        .WithOne("Armas")
                        .HasForeignKey("RpgApi.Models.Armas", "PersonagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personagem");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.HasOne("RpgApi.Models.Usuario", "Usuario")
                        .WithMany("Personagens")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("RpgApi.Models.Personagem", b =>
                {
                    b.Navigation("Armas")
                        .IsRequired();
                });

            modelBuilder.Entity("RpgApi.Models.Usuario", b =>
                {
                    b.Navigation("Personagens");
                });
#pragma warning restore 612, 618
        }
    }
}
