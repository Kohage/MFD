using Data.Repo;
using Services.Interfaces;

namespace Services.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepo<T> _entity;

        public Service(IRepo<T> entity)
        {
            _entity = entity;
        }

        public async Task<T> AuthService(T entity)
        {
            return await _entity.AuthAsync(entity);
        }
        public async Task<T> SendEmailService(T entity)
        {
            return await _entity.SendEmailAsync(entity);
        }

        public async Task<T> SaveService(T entity)
        {
            return await _entity.SaveAsync(entity);
        }
        public async Task<T> GetAllService(T entity)
        {
            return await _entity.GetAllAsync(entity);
        }
        public async Task<T> GetByNameService(T entity)
        {
            return await _entity.GetByNameAsync(entity);
        }
        public async Task<T> GetByDateService(T entity)
        {
            return await _entity.GetByDateAsync(entity);
        }

    }
        
}
