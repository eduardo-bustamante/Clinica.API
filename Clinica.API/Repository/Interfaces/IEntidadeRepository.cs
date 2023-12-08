namespace Clinica.API.Repository.Interfaces
{
    public interface IEntidadeRepository
    {
  


        public void Add<T>(T entity) where T : class;
        public void Update<T>(T entity) where T : class;
        public void Delete<T>(T entity) where T : class;
        bool SaveChanges();
    }
}
