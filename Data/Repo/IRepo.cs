using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repo
{
    public interface IRepo<T> where T : class
    {
        Task<T> AuthAsync(T entity);
        Task<T> SendEmailAsync(T entity);
        Task<T> SaveAsync(T entity);
        Task<T> GetAllAsync(T entity);
        Task<T> GetByNameAsync(T entity);
        Task<T> GetByDateAsync(T entity);


    }
}
