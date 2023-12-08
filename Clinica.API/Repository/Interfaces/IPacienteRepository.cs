using Clinica.API.Models;

namespace Clinica.API.Repository.Interfaces
{
    public interface IPacienteRepository
    {
        IEnumerable<Paciente>Get()
    }
}
