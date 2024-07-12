using DAL.AbstractRepositories;
using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ConcreteRepositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly BlogSiteContext _context;
        private readonly DbSet<TEntity> _entities;
        public Repository(BlogSiteContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedDate = DateTime.Now;
                _entities.Update(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.Where(e => !e.IsDeleted).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _entities.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            entity.ModifiedDate = DateTime.Now;
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
