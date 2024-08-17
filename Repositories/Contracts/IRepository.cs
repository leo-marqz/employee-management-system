
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Repositories.Contracts;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> SearchAsync(Func<T, bool> condition);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task InactivateAsync(int id);
    Task<bool> DeleteAsync(int id);
}