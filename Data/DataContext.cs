using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;
using RpgApi.utils;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
            
        public DbSet<Personagem> TB_PERSONAGENS{ get ; set; }
        public DbSet<Armas> TB_ARMAS{ get ; set; }
        public DbSet<Usuario> TB_USUARIOS { get; set; }
        public DbSet<Habilidade> TB_HABILIDADE { get; set; }
        public DbSet<PersonagemHabilidade> TB_PERSONAGEMHABILIDADE { get; set; }

            //Prop + TAB Criar propriedades
            //Ctor + TAB Criar construtor
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personagem>().HasData
            (
                new Personagem() { Id = 1 }, //Frodo Cavaleiro
                new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
                new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
                new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
                new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
                new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
                new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }

                //área para futuros inserts no banco

            );

            modelBuilder.Entity<Armas>().HasData
            (
                new Armas() { Id = 1, Nome = "Espada", Dano = 10, PersonagemId = 1},
                new Armas() { Id = 2, Nome = "Machado", Dano = 20, PersonagemId = 2},
                new Armas() { Id = 3, Nome = "Arco", Dano = 7, PersonagemId = 3},
                new Armas() { Id = 4, Nome = "Maca", Dano = 15, PersonagemId = 4},
                new Armas() { Id = 5, Nome = "Bordao", Dano = 10, PersonagemId = 5},
                new Armas() { Id = 6, Nome = "Manopla", Dano = 4, PersonagemId = 6},
                new Armas() { Id = 7, Nome = "Chicote", Dano = 6, PersonagemId = 7}
                
                //área para futuros inserts no banco
            );

              //Início da criação do usuário padrão.
            Usuario user = new Usuario();
            Criptografia.CriarPasswordHash("123456", out byte[] hash, out byte[]salt);
            user.Id = 1;
            user.Username = "UsuarioAdmin";
            user.PasswordString = string.Empty;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.Perfil = "Admin";
            user.Email = "seuEmail@gmail.com";
            user.Latitude = -23.5200241;
            user.Longitude = -46.596498;

            modelBuilder.Entity<Usuario>().HasData(user);            
            //Fim da criação do usuário padrão.

            //Define que se o Perfil não for informado, o valor padrao será jogador
            modelBuilder.Entity<Usuario>().Property(u => u.Perfil).HasDefaultValue("Jogador");
            
            modelBuilder.Entity<PersonagemHabilidade>()
                .HasKey(ph => new {ph.PersonagemId, ph.HabilidadeId});
            
            modelBuilder.Entity<Habilidade>().HasData
            (
                new Habilidade(){Id=1, Nome="Adormecer", Dano=39},
                new Habilidade(){Id=2, Nome="Congelar", Dano=39},
                new Habilidade(){Id=3, Nome="Hipnotizar", Dano=37}
            );

            modelBuilder.Entity<PersonagemHabilidade>().HasData
            (
                new PersonagemHabilidade() {PersonagemId = 1, HabilidadeId = 1},
                new PersonagemHabilidade() {PersonagemId = 1, HabilidadeId = 2},
                new PersonagemHabilidade() {PersonagemId = 2, HabilidadeId = 2},
                new PersonagemHabilidade() {PersonagemId = 3, HabilidadeId = 2},
                new PersonagemHabilidade() {PersonagemId = 3, HabilidadeId = 3},
                new PersonagemHabilidade() {PersonagemId = 4, HabilidadeId = 3},
                new PersonagemHabilidade() {PersonagemId = 5, HabilidadeId = 1},
                new PersonagemHabilidade() {PersonagemId = 6, HabilidadeId = 2},
                new PersonagemHabilidade() {PersonagemId = 7, HabilidadeId = 3}

            );

        }
        

    }
    
    }
    
    
