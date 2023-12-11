using Clinica.API.Models;

namespace Clinica.API.Repository.Interfaces
{
    public interface IEntidadeRepository<TEntity> where TEntity : Entidade
    {



        public void Add<T>(T entity) where T : TEntity;
        public void Update<T>(T entity) where T : TEntity;
        public void Delete<T>(T entity) where T : TEntity;
        bool SaveChanges();
    }
}
