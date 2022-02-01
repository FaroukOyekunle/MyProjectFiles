using LibraryManagementSystem.Context;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Implementations.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        protected LMSApplicationContext _context { get; set; }

        public async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAsync(IList<int> ids)
        {
            return await _context.Set<T>()
                .Where(e => ids.Contains(e.Id)).ToListAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Set<T>()
                .AnyAsync(e => e.Id == id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>()
                .Where(expression).ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>()
                .AddAsync(entity);
            return entity;
        }

        public IQueryable<T> Query()
        {
            return _context.Set<T>()
                .AsQueryable();
        }

        public Task<T> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Task.FromResult(entity);

        }

        public Task DeleteAsync(int id)
        {
            var entity = new T
            {
                Id = id
            };

            _context.Entry(entity).State = EntityState.Deleted;
            return Task.CompletedTask;
        }

        public Task DeleteAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            return Task.CompletedTask;
        }


        public async Task<IEnumerable<T>> AddAsync(IEnumerable<T> entities)
        {
            await _context.AddRangeAsync(entities);
            return entities;
        }

        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>()
               .AnyAsync(expression);
        }

        public Task<TEntity> UpdateAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Task.FromResult(entity);
        }

        public Task DeleteAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            _context.Entry(entity).State = EntityState.Deleted;
            return Task.CompletedTask;
        }

        public async Task<TEntity> AddAsync<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            await _context.Set<TEntity>()
                .AddAsync(entity);
            return entity;
        }

        public async Task<TEntity> GetAsync<TEntity>(int id) where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public Task DeleteAsync<TEntity>(int id) where TEntity : BaseEntity, new()
        {
            var entity = new TEntity()
            {
                Id = id
            };
            _context.Entry(entity).State = EntityState.Deleted;
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<TEntity>> GetAsync<TEntity>(IList<int> ids) where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>()
                .Where(e => ids.Contains(e.Id)).ToListAsync();
        }

        public async Task<bool> ExistsAsync<TEntity>(int id) where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>()
                .AnyAsync(e => e.Id == id);
        }

        public async Task<bool> ExistsAsync<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : BaseEntity
        {
            return await _context.Set<TEntity>()
                .AnyAsync(expression);
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : BaseEntity
        {
            return _context.Set<TEntity>()
                .AsQueryable();
        }

        public IQueryable<TEntity> Query<TEntity>(Expression<Func<TEntity, bool>> expression) where TEntity : BaseEntity
        {
            return _context.Set<TEntity>()
                .Where(expression);
        }
    }
}
