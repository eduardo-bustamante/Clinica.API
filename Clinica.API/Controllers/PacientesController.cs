using Clinica.API.Data;
using Clinica.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PacientesController : Controller
    {
        private readonly DataContext _context;

        public PacientesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("Mostrar Pacientes")]
        public async Task<IActionResult> Get()
        {
            var paciente = await _context.Pacientes.ToListAsync();
            return Ok(paciente);
        }

        [HttpGet("Buscar Paciente")]
        public async Task<IActionResult> Get(int id)
        {
            var pacientes = await _context.Pacientes.FirstOrDefaultAsync(x => x.ID == id);
            return Ok(pacientes);
        }

        [HttpPost("Cadastrar Paciente")]
        public async Task<IActionResult> Create(Paciente paciente)
        {
            await _context.AddAsync(paciente);
            await _context.SaveChangesAsync();
            return Ok(paciente);
        }


        [HttpPut("Editar Registro")]
        public async Task<IActionResult> Put(int id, [FromBody] Paciente paciente)
        {
            var _paciente = await _context.Pacientes.FirstOrDefaultAsync(x => x.ID == id);

            if (_paciente == null)
                return NotFound();


            _paciente.Nome = paciente.Nome;
            _paciente.Email = paciente.Email;
            _paciente.DataNascimento = paciente.DataNascimento;
            _paciente.Sexo = paciente.Sexo;
            _paciente.DataObito = paciente.DataObito;
            _paciente.DataUltimaConsulta = paciente.DataUltimaConsulta;
            _paciente.Ativo = paciente.EstaAtivo();




            await _context.SaveChangesAsync();

            return Ok(paciente);
        }


        [HttpDelete("Deletar Registro")]
        public IActionResult Delete(int id)
        {
            var _paciente = _context.Pacientes.FirstOrDefault(x => x.ID == id);

            if (_paciente == null)
                return NotFound();

            _context.Pacientes.Remove(_paciente);
            _context.SaveChanges();

            return Ok();
        }


    }
}
