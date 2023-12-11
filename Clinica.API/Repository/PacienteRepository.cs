using Clinica.API.Data;
using Clinica.API.Models;
using Clinica.API.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Repository
{
    public class PacienteRepository : IEntidadeRepository<Paciente>
    {
        public void Add<T>(T entity) where T : Paciente
        {

            Console.Write(entity.Sexo);
        }

        public void Update<T>(T entity) where T : Paciente
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : Paciente
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
