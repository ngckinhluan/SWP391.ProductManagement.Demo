﻿namespace PMS.Repositories.Interface;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(string id);
    Task InsertAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}