using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repo
{
    public class Repo<T> : IRepo<T> where T : class
    {
        DataContext _context;
        DbSet<T> _dbset;

        public async Task<T> AuthAsync(T entity)
        {
            return entity;
        }

        public async Task<T> SendEmailAsync(T entity)
        {
            return entity;
        }
        public async Task<T> SaveAsync(T entity)
        {
            return entity;
        }
        public async Task<T> GetAllAsync(T entity)
        {
            return entity;
        }
        public async Task<T> GetByNameAsync(T entity)
        {
            return entity;
        }
        public async Task<T> GetByDateAsync(T entity)
        {
            return entity;
        }
    }
}
