using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
using RpgApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagemHabilidadesController : ControllerBase
    {
        private readonly DataContext _context;
        public PersonagemHabilidadesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonagemHabilidadeAsync(PersonagemHabilidade novoPersonagemHabilidade)
        {
            try
            {
                Personagem personagem = await _context.TB_PERSONAGENS
                    .Include(p => p.Arma)
                    .Include(p => p.PersonagemHabilidades).ThenInclude(ps => ps.Habilidade)
                    .FirstOrDefaultAsync(p => p.Id == novoPersonagemHabilidade.PersonagemId);

                if (personagem == null)
                    throw new System.Exception("Personagem não encontrado para o Id informado.");

                Habilidade habilidade = await _context.TB_HABILIDADES
                                    .FirstOrDefaultAsync(h => h.Id == novoPersonagemHabilidade.HabilidadeId);
                if (habilidade == null)
                throw new System.Exception("Habilidade não encontrada.");

                PersonagemHabilidade ph = new PersonagemHabilidade();
                ph.Personagem = personagem;
                ph.Habilidade = habilidade;
                await _context.TB_PERSONAGENS_HABILIDADES.AddAsync(ph);
                int linhaAfetadas = await _context.SaveChangesAsync();

                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle (int id)
        {
            try
            {
                Personagem p = await _context.TB_PERSONAGENS
                    .Include(ar => ar.Arma)
                    .Include(ph => ph.PersonagemHabilidades)
                        .ThenInclude(h => h.Habilidade)
                    .FirstOrDefaultAsync(pBusca => pBusca.Id == id);
                return Ok(p);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}