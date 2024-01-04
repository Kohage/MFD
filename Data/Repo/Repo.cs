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
    }
}
