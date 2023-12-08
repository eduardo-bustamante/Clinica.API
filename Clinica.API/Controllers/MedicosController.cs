using Clinica.API.Data;
using Clinica.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Clinica.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicosController : Controller
    {

        private readonly DataContext _context;
        public MedicosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Mostrar Médicos")]
        public async Task<IActionResult> Get()
        {

            var medico = await _context.Medicos.ToListAsync();
            return Ok(medico);
        }


        [HttpGet("Buscar Médicos")]
        public async Task<IActionResult> Get(int id)
        {
            var medicos = await _context.Medicos.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(medicos);
        }

        [HttpPost("Cadastrar Medico")]
        public async Task<IActionResult> Create(Medico medico)
        {
            await _context.AddAsync(medico);
            await _context.SaveChangesAsync();
            return Ok(medico);
        }


        [HttpPut("Editar Registro   ")]
        public async Task<IActionResult> Put(int id, [FromBody] Medico medico)
        {
            var _medico = await _context.Medicos.FirstOrDefaultAsync(x => x.Id   == id);

            if (_medico == null)
                return NotFound();

            _context.Medicos.Update(_medico);

            await _context.SaveChangesAsync();

            return Ok(medico);
        }


        [HttpDelete("Deletar Registro")]
        public IActionResult Delete(int id)
        {
            var _medico = _context.Medicos.FirstOrDefault(x => x.Id == id);

            if (_medico == null)
                return NotFound();

            _context.Medicos.Remove(_medico);
            _context.SaveChanges();

            return Ok();
        }

    }
}

