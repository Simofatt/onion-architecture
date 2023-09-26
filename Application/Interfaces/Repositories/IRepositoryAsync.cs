using Domain.Contracts;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IRepositoryAsync<T, TId> where T : class ,IEntity<TId> 
    {
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync(string? includePropreties = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter, string? includePropreties = null);
        Task UpdateAsync(T entity);

    }
}
