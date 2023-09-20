using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Data;
using Microsoft.EntityFrameworkCore;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class ArmasController : ControllerBase
    {
         private readonly DataContext _context;

         public ArmasController(DataContext context)
         {
            _context = context; 
         }

         [HttpGet("{id}")]

        public async Task<IActionResult> GetSingle(int id)
        {
            try 
            {
                Armas a = await _context.TB_ARMAS
                    .FirstOrDefaultAsync(aBusca => aBusca.Id == id);
                
                return Ok(a); 
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

         [HttpGet ("GetAll")]

        public async Task<IActionResult> Get()
        {
            try 
            {
                List<Armas> lista = await _context.TB_ARMAS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Armas novaArma)
        {
            try
            {
                await _context.TB_ARMAS.AddAsync(novaArma);
                await _context.SaveChangesAsync();

                return Ok(novaArma.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]

        public async Task<IActionResult> Update(Armas novaArma)
        {
            try 
            {
            
                _context.TB_ARMAS.Update(novaArma);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest (ex.Message);
            }
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Armas aRemover = await _context.TB_ARMAS.FirstOrDefaultAsync(a => a.Id == id);

                _context.TB_ARMAS.Remove(aRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();
                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}