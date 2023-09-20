using Microsoft.EntityFrameworkCore;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
            
        public DbSet<Personagem> TB_PERSONAGENS{ get ; set; }
        public DbSet<Armas> TB_ARMAS{ get ; set; }

    
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
                new Armas() { Id = 1, Nome = "Espada", Dano = 10},
                new Armas() { Id = 2, Nome = "Machado", Dano = 20},
                new Armas() { Id = 3, Nome = "Arco", Dano = 7},
                new Armas() { Id = 4, Nome = "Maca", Dano = 15},
                new Armas() { Id = 5, Nome = "Bordao", Dano = 10},
                new Armas() { Id = 6, Nome = "Manopla", Dano = 4},
                new Armas() { Id = 7, Nome = "Chicote", Dano = 6}
                
                //área para futuros inserts no banco

            );
        }


          
    



    }
    
    
    
    }
    
    
