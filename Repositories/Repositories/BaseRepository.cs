using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class BaseRepository<T> where T : class
    {
        public BankAccountTypeContext _context;
        
        public BaseRepository()
        {
            _context = new BankAccountTypeContext();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
    }
}

