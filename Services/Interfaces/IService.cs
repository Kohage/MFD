using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IService<T> where T : class
    {
        Task<T> AuthService(T entity);
        Task<T> SendEmailService(T entity);
        Task<T> SaveService(T entity);
        Task<T> GetAllService(T entity);
        Task<T> GetByNameService(T entity);
        Task<T> GetByDateService(T entity);

    }
}
