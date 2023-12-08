using Clinica.API.Data;
using Clinica.API.Repository.Interfaces;

namespace Clinica.API.Repository
{
    public class EntidadeRepository : IEntidadeRepository
    {
        private readonly DataContext _context;
        public EntidadeRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
