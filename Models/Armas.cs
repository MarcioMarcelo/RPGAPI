
using RpgApi.Models;

namespace RpgApi.Models
{
    public class Armas
    {
      
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int Dano { get; set; }

        public Personagem Personagem { get; set; }

        public int PersonagemId { get; set; }

    }
}