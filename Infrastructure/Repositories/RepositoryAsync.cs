using Application.Interfaces.Repositories;
using Domain.Contracts;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
   public class RepositoryAsync<T, TId> : IRepositoryAsync<T,TId> where T : AuditableEntity<TId>
    {
        private readonly AuditableContext _dbcontext;
        private readonly  DbSet<T> _dbSet;

      

        public RepositoryAsync(AuditableContext context) {
            _dbcontext = context;
            _dbSet = _dbcontext.Set<T>();      
        }

        public async Task AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);
            
        }
        public Task RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
            return Task.CompletedTask;
        }
        public async Task<IEnumerable<T>> GetAllAsync(string? includePropreties = null)
        {
            IQueryable<T> query=  _dbSet;
            if(!string.IsNullOrEmpty(includePropreties)) 
            {
                foreach (var item in includePropreties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includePropreties);
                }
            }
            return await query.ToListAsync();
        }
        public async Task<T> GetAsync(Expression<Func<T,bool>> filter , string? includePropreties = null)
        {
            IQueryable<T> query = _dbSet.Where(filter);
            if(!string.IsNullOrEmpty(includePropreties))
            {
                foreach (var item in includePropreties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries) )
                {
                    query = query.Include(includePropreties); 
                }
            }
           
            return await query.FirstOrDefaultAsync();
        }

        public Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);  
            return Task.CompletedTask;  
        }



    }
}
