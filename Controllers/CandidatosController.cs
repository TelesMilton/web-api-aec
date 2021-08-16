using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aec_gama_api.Models;

namespace aec_gama_api.Controllers
{
     [ApiController]
     [Route("[controller]")]
    public class CandidatosController : ControllerBase
    {
        private readonly DbContexto _context;

        public CandidatosController(DbContexto context)
        {
            _context = context;
        }

        // GET: Candidatos
        public async Task<IActionResult> Index()
        {
            var DbContexto = _context.Candidatos;
            return StatusCode(200, await _context.Candidatos.ToListAsync());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Candidato,Nome,Nascimento,Cep,Logradouro,Numero,Bairro,Cidade,UF,Telefone,Email")] Candidato candidato)
        {
        
                _context.Add(candidato);
                await _context.SaveChangesAsync();
                return StatusCode(201, candidato);
                
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Candidato,Nome,Nascimento,Cep,Logradouro,Numero,Bairro,Cidade,UF,Telefone,Email")] Candidato candidato)
        {
            if (id != candidato.Id_Candidato)
            {
                return NotFound();
            }

            {
                try
                {
                    _context.Update(candidato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidatoExists(candidato.Id_Candidato))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return StatusCode(200, candidato);
            }
        }

     
        [HttpDelete, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candidato = await _context.Candidatos.FindAsync(id);
            _context.Candidatos.Remove(candidato);
            await _context.SaveChangesAsync();
            return StatusCode(204);
        }

        private bool CandidatoExists(int id)
        {
            return _context.Candidatos.Any(e => e.Id_Candidato == id);
        }
    }
}
