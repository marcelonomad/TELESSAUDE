using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelessaudeData.Contexts;
using TelessaudeData.Models;
using TelessaudeData.Repositories.Interfaces;

namespace TelessaudeData.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly TelessaudeContext _context;
        private readonly DbSet<T> _entities;

        public BaseRepository(TelessaudeContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }
        public async Task<T> GetById(Guid id)
        {
            return await _entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async void Insert(T entity)
        {
            await _entities.AddAsync(entity);
            _context.SaveChanges();
        }
        public async void Update(T entity)
        {
            var oldEntity = await _context.FindAsync<T>(entity.Id);
            _context.Entry(oldEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {

            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public async Task<int> Count()
        {
            return await _entities.CountAsync<T>();
        }

    }
}

