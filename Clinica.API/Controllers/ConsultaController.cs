using Clinica.API.Data;
using Clinica.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly DataContext _context;
        public ConsultaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Mostrar Consultas")]
        public async Task<IActionResult> Get()
        {
            var consultas = await _context.Consultas.ToListAsync();
            return Ok(consultas);
        }

        [HttpGet("Buscar Consulta")]
        public async Task<IActionResult> Get(int id)
        {
            var consulta = await _context.Consultas.FirstOrDefaultAsync(x => x.ID == id);
            return Ok(consulta);
        }

        [HttpPost("Cadastrar Consulta")]
        public async Task<IActionResult> Create(Consulta consulta)
        {
            await _context.AddAsync(consulta);
            await _context.SaveChangesAsync();
            return Ok(consulta);
        }
    }
}
