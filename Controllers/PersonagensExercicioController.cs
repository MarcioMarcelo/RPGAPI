using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            //Colar os objetos da lista do chat aqui
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        [HttpGet("GetByNome/{nome}")]

        public IActionResult GetByNome(string nome)
        {
            
            List<Personagem> listaBusca = personagens.FindAll(p => p.Nome == nome);
            
            if (listaBusca.Count > 0)
            {
                return Ok(listaBusca); 
            }
            else
            {
                return NotFound("Nao foi encontrado");
            }
            
        }

        [HttpPost("PostValidacao")]

        public IActionResult PostValidacao(Personagem novoPersonagem)
        {
            if (novoPersonagem.Defesa < 10)
                return BadRequest("Defesa não pode ter o valor menor que 10 (dez).");
            else
            {
            
                if(novoPersonagem.Inteligencia > 30)
                    return BadRequest("Inteligência não pode ter o valor maior que 30 (trinta).");
                else
                {
                    personagens.Add(novoPersonagem);
                    return Ok(personagens);
                } 
            }

        }

        [HttpPost("PostValidacaoMago")]
    
        public IActionResult PostValidacaoMago(Personagem novoPersonagem)
        {
            if (novoPersonagem.Classe == ClasseEnum.Mago && novoPersonagem.Inteligencia < 35)
            {
                return BadRequest("Um personagem do tipo Mago não pode ter inteligência menor que 35.");
            }
            else
            {
            personagens.Add(novoPersonagem);
            return Ok(personagens);
            }
        }

        [HttpGet("GetClerigoMago")]
        
        public IActionResult GetClerigoMago()
        {
            List<Personagem> clerigosEMagos = personagens
            .Where(p => p.Classe == ClasseEnum.Clerigo || p.Classe == ClasseEnum.Mago)
            .OrderByDescending(p => p.PontosVida)
            .ToList();

            return Ok(clerigosEMagos);
        }

        [HttpGet("GetEstatisticas")]

        public IActionResult GetEstatisticas()
        {
            int quantidadePersonagens = personagens.Count;
            int somatorioInteligencia = personagens.Sum(p => p.Inteligencia);

            string mensagem = $"Quantidade de personagens: {quantidadePersonagens}. Somatório de inteligência: {somatorioInteligencia}.";

            return Ok(mensagem);
        }

        [HttpGet("GetbyClasse/{classe}")]
        public IActionResult GetbyClasse(int classe)
        {
            if (!Enum.IsDefined(typeof(ClasseEnum), classe))
            {
                return BadRequest("ID de classe inválido");
            }

            ClasseEnum classeSelecionada = (ClasseEnum)classe;

            List<Personagem> listaBusca = personagens.FindAll(p => p.Classe == classeSelecionada);

            if (listaBusca.Count > 0)
            {
                return Ok(listaBusca);
            }
            else
            {
                return NotFound("Nenhum personagem encontrado para a classe informada.");
            }
        }






























    }
}